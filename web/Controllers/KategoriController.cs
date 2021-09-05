using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Abstract;
using entity;
using web.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;


namespace web.Controllers
{
    public class KategoriController : Controller
    {

        private readonly ILogger<KategoriController> _logger;
        private readonly IHtmlLocalizer<KategoriController> _localizer;
        private IProductService _productService;
        private ICategoryService _categoryService;
       


        public KategoriController(ILogger<KategoriController> logger,
            IHtmlLocalizer<KategoriController> localizer,
            IProductService productService,
            ICategoryService categoryService)
        {
            _logger = logger;
            _localizer = localizer;
            _productService = productService;
            _categoryService = categoryService;
          

        }


        public IActionResult Details(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return RedirectToAction("s404", "Home");
            }

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;
            
            Category category1 = _categoryService.GetBySeoUrl(url);
           
            
            if (category1 == null)
            {
                return NotFound();
            }


            var code = category1.Code;
            Category category2 = _categoryService.GetAll()
                .Where(i => i.Culture == culture.Name && i.Code == code).FirstOrDefault();


            var bigViewModel = new BigViewModel()
            {

                CategoryModel = new CategoryModel()
                {
                    category = category2,
                    products = _productService.GetProductsbyCategory(url)
                    //products = _productService.GetAll()
                    
                },

                FormModelContact = new FormModelContact()

            };




            var renk = _localizer["Color"];
            ViewData["Color"] = renk;





            return View(bigViewModel);


        }



       
    }
}
