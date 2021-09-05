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
    public class HaberlerController : Controller
    {



        private readonly ILogger<HaberlerController> _logger;
        private readonly IHtmlLocalizer<HaberlerController> _localizer;
        private INewsService _newsService;
       



        public HaberlerController(ILogger<HaberlerController> logger,
            IHtmlLocalizer<HaberlerController> localizer,
           INewsService newsService)
        {
            _logger = logger;
            _localizer = localizer;
            _newsService = newsService;
            


        }
        public IActionResult Index()
        {

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;


            //var haberler = _newsService.GetAll()
            //    .Where(i => i.Culture == culture.Name).ToList();

            var haberler = _newsService.GetAll();


            var model = new BigViewModel()
            {
                HaberlerModel = new HaberlerModel()
                {
                    News = haberler
                }
            };

            return View(model);
        }


        public IActionResult Details(string seocode)
        {

            if (string.IsNullOrEmpty(seocode))
            {
                return NotFound();
            }

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;

            News haber = _newsService.GetBySeoUrl(seocode,culture.Name);


            var code = haber.Code;
            News haber1 = _newsService.GetAll()
                .Where(i => i.Culture == culture.Name && i.Code == code).FirstOrDefault();

            var model = new BigViewModel()
            {
                HaberDetailModel = new HaberDetailModel()
                {
                    New = haber1
                }
            };

            return View(model);
        }
    }
}
