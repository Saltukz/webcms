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
    public class ReferansController : Controller
    {


        private readonly ILogger<ReferansController> _logger;
        private readonly IHtmlLocalizer<ReferansController> _localizer;
        private IProjectsService _projectsService;
        private IProjectGaleryService _projectGaleryService;
      




        public ReferansController(ILogger<ReferansController> logger,
            IHtmlLocalizer<ReferansController> localizer,
            IProjectsService projectsService,
            IProjectGaleryService projectGaleryService)
        {
            _logger = logger;
            _localizer = localizer;
            _projectsService = projectsService;
            _projectGaleryService = projectGaleryService;
         



        }
        public async Task<IActionResult> ListAsync(string pcode)
        {
            
            if (string.IsNullOrEmpty(pcode))
            {
                return NotFound();
            }

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;

            Projects proje = _projectsService.GetByCode(pcode);


            if (proje == null)
            {
                return NotFound();
            }


            //   var code = proje.Code;
            var proje1 = await _projectGaleryService.GetAll();
            proje1.Select(p => p.Code).Distinct().ToList();

            var menuList = _projectGaleryService.GetGalleryByProject(pcode, culture.Name)
               .Select(p => p.ProjeAlani).Distinct().ToList();

          

            var menuliste = menuList.Skip(1).ToList();
             List<ProjectGalery> projectGaleries = _projectGaleryService.GetGalleryByProject(pcode, culture.Name)
                    .OrderByDescending(p => p.ProjectGalleryId)
                   
                    .ToList();                                
          
          
            var bigViewModel = new BigViewModel()
            {

                ProjectModel = new ProjectModel()
                {

                    project = proje,
                
                    projectGaleries = projectGaleries,
                    menuList = menuList

                },

                FormModelContact = new FormModelContact()

            };
            return View(bigViewModel);




        }
    }
}
