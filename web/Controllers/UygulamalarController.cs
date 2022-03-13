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
    public class UygulamalarController : Controller
    {

        private readonly ILogger<UygulamalarController> _logger;
        private readonly IHtmlLocalizer<UygulamalarController> _localizer;
        private IUygulamalarService _uygulamalarService;
      



        public UygulamalarController(ILogger<UygulamalarController> logger,
            IHtmlLocalizer<UygulamalarController> localizer,
            IUygulamalarService uygulamalarService)
        {
            _logger = logger;
            _localizer = localizer;
            _uygulamalarService = uygulamalarService;
           


        }


        public async Task<IActionResult> DetailsAsync(string seo)
        {
            if (string.IsNullOrEmpty(seo))
            {
                return NotFound();
            }

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;

            Uygulama uygulamalar1 = _uygulamalarService.GetBySeoUrl(seo);


            if (uygulamalar1 == null)
            {
                return NotFound();
            }


            var code = uygulamalar1.Code;
            var uygulamalar = await _uygulamalarService.GetAll();
            var uygulamalarlast = uygulamalar.Where(i => i.Culture == culture.Name && i.Code == code).FirstOrDefault();




            var bigViewModel = new BigViewModel()
            {


                UygulamalarModel = new UygulamalarModel()
                {
                    uygulama = uygulamalarlast
                    // plastikKullanimAlanlari = _plastikKullanimAlaniService.GetProductsbyCategory(plastikLevhalar1.Code,culture.Name)
                    //products = _productService.GetAll()

                },

                FormModelContact = new FormModelContact()

            };


            return View(bigViewModel);


        }

        public async Task<IActionResult> ListAsync()
        {


            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;

            var uygulamalar = await _uygulamalarService.GetAll();
            uygulamalar.Where(i => i.Culture == culture.Name).ToList();

            var bigViewModel = new BigViewModel()
            {

                UygulamalarModel = new UygulamalarModel()
                {
                    uygulamalar = uygulamalar
                    // plastikKullanimAlanlari = _plastikKullanimAlaniService.GetProductsbyCategory(plastikLevhalar1.Code,culture.Name)
                    //products = _productService.GetAll()

                },

                FormModelContact = new FormModelContact()

            };


            return View(bigViewModel);
        }
    }
}
