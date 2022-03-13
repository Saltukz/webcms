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
    public class DokumanController : Controller
    {
        private readonly ILogger<DokumanController> _logger;
        private readonly IHtmlLocalizer<DokumanController> _localizer;
        private IDokumanService _dokumanService;
        private IDokumanCategoryService _dokumanCategoryService;




        public DokumanController(ILogger<DokumanController> logger,
            IHtmlLocalizer<DokumanController> localizer,
           IDokumanService dokumanService,
           IDokumanCategoryService dokumanCategoryService)
        {
            _logger = logger;
            _localizer = localizer;
            _dokumanCategoryService = dokumanCategoryService;
            _dokumanService = dokumanService;
            



        }
        public async Task<IActionResult> IndexAsync()
        {
            

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;



            var dokumanCategories = await _dokumanCategoryService.GetAll();
            dokumanCategories.Where(i => i.Culture == culture.Name).ToList();






            var documents = _dokumanService.GetAllWithCategories()
                .Where(i => i.Culture == culture.Name).ToList();

            var relation = _dokumanService.GetRelationTable();
                




            var bigViewModel = new BigViewModel()
            {

                DokumanModel = new DokumanModel()
                {
                    
                     dokumanCategories = dokumanCategories,
                    // plastikKullanimAlanlari = _plastikKullanimAlaniService.GetProductsbyCategory(plastikLevhalar1.Code,culture.Name)
                    //products = _productService.GetAll()
                    dokumanlar = documents,
                    relation = relation
                   
                },

                FormModelContact = new FormModelContact()

            };


            return View(bigViewModel);
        }
    }
}
