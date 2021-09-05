using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using web.Identity;
using web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace web.Controllers
{


    public class AccountController : Controller
    {
     
        readonly UserManager<User> _userManager;
        readonly SignInManager<User> _signInManager;
        private object _configuration;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
           


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
           

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);

            if(user == null)
            {
                ModelState.AddModelError("", "Kullanıcı adı yanlış");
                return View(model);
            }

            var userClaims = await _userManager.GetClaimsAsync(user);



            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);



            
            if (result.Succeeded)
            {

                Claim claim = new Claim("pozisyon", "admin");
                if (!userClaims.Any(x => x.Type == "pozisyon"))
                    await _userManager.AddClaimAsync(user, claim);


              
                return RedirectToAction("Index", "Admin");

                
            }
            else
            {
                return View(model);
            }
           
        }


        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return Redirect("/");
        }




    }
}
