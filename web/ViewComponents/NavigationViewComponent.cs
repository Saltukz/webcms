using business.Abstract;
using data.Abstract;
using web.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.ViewComponents
{

    public class NavigationViewComponent:ViewComponent
    {

              private readonly ILogger<NavigationViewComponent> _logger;
        private readonly IHtmlLocalizer<NavigationViewComponent> _localizer;
        private IProductService _productService;
        private ICategoryService _categoryService ;
        private IUygulamalarService _uygulamalarService;
        private IProjectsService _projectsService;
        private IProjectGaleryService _projectGaleryService;


        public NavigationViewComponent(ILogger<NavigationViewComponent> logger,
            IHtmlLocalizer<NavigationViewComponent> localizer,
            IProductService productService,
            ICategoryService categoryService,
            IUygulamalarService uygulamalarService,
            IProjectsService projectsService,
            IProjectGaleryService projectGaleryService)
        {
            _logger = logger;
            _localizer = localizer;
            _productService = productService;
            _categoryService = categoryService;
            _uygulamalarService = uygulamalarService;
            _projectsService = projectsService;
            _projectGaleryService = projectGaleryService;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;

            var kategoriler = await _categoryService.GetAll();
            var kategorilerlast = kategoriler.Where(i => i.Culture == culture.Name).ToList();

            var projeler = await _projectsService.GetAll();


            var projegaleriler = await _projectGaleryService.GetAll();
            var projegalerilerlast = projegaleriler.Where(i => i.Culture == culture.Name).ToList();

            var layoutModel = new LayoutModel()
            {
                categories = kategorilerlast,
                
               

                uygulamalar = _uygulamalarService.GetAllByCulture(culture.Name),

                projects = projeler,

                projectGaleries = projegalerilerlast


            };


            return View(layoutModel);
        }
    }
}
