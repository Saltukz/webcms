using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Abstract;
using entity;
using web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using web.Helpers;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;


using Google.Apis.Services;

using Google.Apis.AnalyticsReporting.v4;

using Google.Apis.AnalyticsReporting.v4.Data;

using Google.Apis.Auth.OAuth2;

using Google.Apis.Auth.OAuth2.Flows;

using Google.Apis.Auth.OAuth2.Responses;

namespace web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private readonly ILogger<AdminController> _logger;
        private readonly IHtmlLocalizer<AdminController> _localizer;
        private IDokumanService _dokumanService;
        private IDokumanCategoryService _dokumanCategoryService;
        private INewsService _newsService;
        private IKariyerService _kariyerService;
        private IContactService _contactService;
        private GetRightCategory getRightCategory;
        private ICategoryService _categoryService;
        private IProductService _productService;
        private IUygulamalarService _uygulamalarService;
        private IWebHostEnvironment _webHostEnvironment;





        public AdminController(ILogger<AdminController> logger,
           IHtmlLocalizer<AdminController> localizer,
           IDokumanService dokumanService,
           IDokumanCategoryService dokumanCategoryService,
           INewsService newsService,
           IKariyerService kariyerService,
           IContactService contactService,
           ICategoryService categoryService,
           IProductService productService,
           IUygulamalarService uygulamalarService,
           IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _localizer = localizer;
            _dokumanCategoryService = dokumanCategoryService;
            _dokumanService = dokumanService;
            _kariyerService = kariyerService;
            _contactService = contactService;
            _newsService = newsService;
            _categoryService = categoryService;
            _productService = productService;
            _uygulamalarService = uygulamalarService;
            _webHostEnvironment = webHostEnvironment;
       

        }




        public async Task<IActionResult> Index()
        {
            //// Specify the urls for which we want analytics data (we only supply the path for each url because the domain can be obtained from the project_id of your GA API Key)
            //var filtersExpression = "ga:pagePath==/hakkimizda,ga:pagePath==/yatirimci-iliskileri"; // each url path is separated by a comma

            //// Specify the date range for which we want analytics data
            //var dateRange = new DateRange
            //{

            //    StartDate = "2021-01-01",

            //    EndDate = "2021-03-14"

            //};

            //// Specify the dimensions we want metrics for
            //var dimensions = new List<Dimension>
            // {

            //new Dimension { Name = "ga:pagePath" },

            //new Dimension { Name = "ga:pageTitle" }

            //};

            //// Specify the metrics we are interested in
            //var metrics = new List<Metric>
            // {

            //new Metric { Expression = "ga:pageViews" },

            //new Metric { Expression = "ga:users" }

            // };

            //// Create a ReportRequest object for the above urls, date range, dimensions & metrics
            //var reportRequest = new ReportRequest

            //{
                
            //    DateRanges = new List<DateRange> { dateRange }, // it is possible to specify multiple date ranges.
            //    Dimensions = dimensions,

            //    Metrics = metrics,

            //   FiltersExpression = filtersExpression,

            //    ViewId = "ga:239523416" // a ReportRequest must contain a ViewId (also called a ReportId) from which the data are collected. See appendix below for instructions how to find your Google Analytics viewId
            //};



            //// Collect all ReportRequest objects in a single GetReportsRequest object (we have created only 1 ReportRequest object, but we can have up to 5 in a single API call)
            //var getReportsRequest = new GetReportsRequest
            //{
            //    ReportRequests = new List<ReportRequest> { reportRequest }
            //};



            //// Load our Google Analytics API Key file to create a GoogleCredential for Google Analytics API authorization
            //var pathGAKey = Path.Combine(_webHostEnvironment.ContentRootPath, "ga-api-key.json");

            //var credential = GetGoogleCredential(pathGAKey);

            //// Create an AnalyticsReportingService object to make the Google Analytics API call
            //var analyticsService = new AnalyticsReportingService(new BaseClientService.Initializer

            //{

            //    ApplicationName = "yollawebe", // The Google Analytics project that we target (however this is also in the API Key)
            //    HttpClientInitializer = credential // Access to the target Google Analytics project
            //});



            //// Using our AnalyticsReportingService object we create a BatchGetRequest object, which will contain our batch (in our case only 1) of ReportRequests as well as target GA Project and necessary credentials to access that GA Project.
            //var batchGetRequest = analyticsService.Reports.BatchGet(getReportsRequest);



            //// On the BatchGetRequest object invoke the actual Google Analytics API call.
            //var getReportsResponse = await batchGetRequest.ExecuteAsync();



            //// The GetReportsResponse object send from Google Analytics API contains a Reports list (1 report for each ReportRequest object we send)
            //var analyticsData = getReportsResponse.Reports[0].Data;



            ///*

            // * Here I use a class, AnalyticsViewModel, that for this Hello World example can look like this :

            // * public class AnalyticsViewModel

            // * {

            // *    public List<ReportRow> AnalyticsRecords { get; set; }

            // * }

            // */

            //var model = new AnalyticsViewModel();
            //if (analyticsData.Rows != null)

            //{

            //    model.AnalyticsRecords = analyticsData.Rows.ToList();

            //}

            //else // No data was send from Google Analytics API, so pass an empty list to the client.
            //{

            //    model.AnalyticsRecords = new List<ReportRow>();

            //}



            return View();
        }

        static GoogleCredential GetGoogleCredential(string pathGAKey)

        {

            GoogleCredential credential;

            using (FileStream stream = new FileStream(pathGAKey, FileMode.Open, FileAccess.Read, FileShare.Read))

            {
                credential = GoogleCredential.FromStream(stream); // that was easy indeed!
            }

            // We need to specify the authorization scope, here we just want to read data.
            string[] scopes = new string[]
            {
               AnalyticsReportingService.Scope.Analytics,
                AnalyticsReportingService.Scope.AnalyticsReadonly

            };

            credential = credential.CreateScoped(scopes); // the final version.


            return credential;
        }

        #region Kariyer

        public async Task<IActionResult> KariyerListAsync(int page = 1)
        {
            const int pageSize = 10;


            var basvurular = await  _kariyerService.GetAll();

            

            var model = new KariyerModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = basvurular.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                Kariyers = _kariyerService.GetByPageSize(page, pageSize)

            };

            return View(model);
        }

      


        [HttpPost]
        public async Task<IActionResult> deleteCvAsync(int id)
        {
            var entity = await _kariyerService.GetById(id);

            if (entity != null)
            {
                _kariyerService.Delete(entity);
            }

            return RedirectToAction("KariyerList");
        }
        #endregion


        #region İletisim

        public async Task<IActionResult> iletisimAsync(int page = 1)
        {
            const int pageSize = 10;


            var iletisim = await  _contactService.GetAll();



            var model = new FormModelContact()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = iletisim.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                Contacts = _contactService.GetByPageSize(page, pageSize)

            };

            return View(model);
        }
        #endregion


        #region News


        public async Task<IActionResult> NewsAsync(int page = 1)
        {
            const int pageSize = 10;


            var haberler = await _newsService.GetAll();


            var model = new HaberlerModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = haberler.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                News = _newsService.GetByPageSize(page, pageSize)

            };

            return View(model);
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewsMethod(HaberlerModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new News()
                {
                    Code = UrlFriendly.URLFriendly(model.Title),
                    Culture = model.Culture,
                    Title = model.Title,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    SeoUrl = model.SeoUrl,

                    MetaDescription = model.MetaDescription,
                 
                    CreatedDate = DateTime.Now

                };

                if (model.SeoUrl == null)
                {
                    var friendlyUrl = UrlFriendly.URLFriendly(model.Title);
                    entity.SeoUrl = friendlyUrl;
                }
                else
                {
                    entity.SeoUrl = model.SeoUrl;
                }

                if (model.file != null)
                {

                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Title) + "_" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\News", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }



                _newsService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("News", "Admin");
            }

            return RedirectToAction("AddNews", model);
        }

        [HttpPost]
        public async Task<IActionResult> deletehaberAsync(int haberId)
        {
            var entity = await _newsService.GetById(haberId);

            if (entity != null)
            {
                _newsService.Delete(entity);
            }

            return RedirectToAction("News");
        }

        public async Task<IActionResult> EditNewsAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = await _newsService.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new HaberlerModel()
            {
                NewsId = entity.NewsId,
                Culture = entity.Culture,
                Title = entity.Title,
                ShortDescription = entity.ShortDescription,
                Description = entity.Description,
                SeoUrl = entity.SeoUrl,
                ImageUrl = entity.ImageUrl,
                MetaDescription = entity.ShortDescription,
          
                Code = entity.Code,
                CreatedDate = entity.CreatedDate


            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditNewsSubmit(HaberlerModel model, IFormFile file)
        {

            var entity = await _newsService.GetById(model.NewsId);

            if (entity == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                entity.Code = model.Code;
                entity.Title = model.Title;
                entity.ShortDescription = model.ShortDescription;
                entity.Description = model.Description;
                entity.ImageUrl = model.ImageUrl;
                entity.MetaDescription = model.ShortDescription;
               
                entity.Culture = model.Culture;

                entity.SeoUrl = model.SeoUrl;

                entity.CreatedDate = entity.CreatedDate;

                if (file != null)
                {
                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Title) + "_" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\News", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }
                }

                _newsService.Update(entity);


                return RedirectToAction("News");
            }

            return RedirectToAction("EditNews", model.NewsId);




        }

        public async Task<IActionResult> AddLanguageToNewsAsync(HaberlerModel model)
        {

            var kodlar = await _newsService.GetAll();
            var kodlarlast= kodlar.Select(x => x.Code).Distinct().ToList();


            //var sozluk = _newsService.GetAll()
            //    .ToDictionary(x => x.Code, x => x.Culture);

            //var sozluk = _newsService.GetAll()
            //    .GroupBy(x => x.Code)
            //    .ToDictionary(x => x.Key, x => x.ToArray());

            string[] lanugage = new string[]
            {
                "tr","en","es","ru","fr","ar",
            };


            List<string> codeBilgi = new List<string>();
            var cultureInfo = _newsService.GetTuple()
                .Where(x => x.Item1 == model.RequestedNew)
                .ToList();

            foreach (var dic in cultureInfo)
            {
                codeBilgi.Add(dic.Item2);
            }


            List<string> liste = new List<string>();

            liste = lanugage.Except(codeBilgi).ToList();
            //foreach (var item in cultureInfo)
            //{
            //    liste.Add(new PInfo {Code=item.Item1,Culture = item.Item2  });
            //}


            var model2 = new HaberlerModel()
            {
                Codes = kodlarlast,
                AllCultures = liste
            };

            return View(model2);
        }

        [HttpPost]
        public async Task<IActionResult> AddLanguageToNewsSubmit(HaberlerModel model)
        {


            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new News()
                {
                    Code = model.RequestedNew,
                    Culture = model.Culture,
                    Title = model.Title,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    SeoUrl = model.SeoUrl,

                    MetaDescription = model.ShortDescription,
         
                    CreatedDate = DateTime.Now

                };

                if (model.SeoUrl == null)
                {
                    var friendlyUrl = UrlFriendly.URLFriendly(model.Title);
                    entity.SeoUrl = friendlyUrl;
                }
                else
                {
                    entity.SeoUrl = model.SeoUrl;
                }

                if (model.file != null)
                {

                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Title) + "_" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\News", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }



                _newsService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("News", "Admin");
            }

            return RedirectToAction("AddLanguageToNews", model);
        }


        public IActionResult GetSelectedNew(HaberlerModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new HaberlerModel()
                {
                    RequestedNew = model.RequestedNew
                };


                return RedirectToAction("AddLanguageToNews", data);
            }
            return RedirectToAction("AddLanguageToNews", "Admin");
        }

        #endregion


        #region DokumanMerkezi


        public async Task<IActionResult> DokumanKategoriAsync(int page = 1)
        {
            const int pageSize = 10;


            var kategoriler = await _dokumanCategoryService.GetAll();


            var model = new DokumanModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = kategoriler.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                dokumanCategories = _dokumanCategoryService.GetByPageSize(page, pageSize)

            };

            return View(model);

        }


        public IActionResult DokumanKategoriAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DokumanKategoriAddMethod(DokumanModel model)
        {

            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new DokumanCategory()
                {
                    Code = UrlFriendly.URLFriendly(model.Name),
                    Culture = model.Culture,
                    Name = model.Name

                };

                _dokumanCategoryService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("DokumanKategori", "Admin");
            }



            return RedirectToAction("DokumanKategori", "Admin");
        }


        public async Task<IActionResult> DokumanKategoriLangAddAsync(DokumanModel model)
        {

            var kodlar = await _dokumanCategoryService.GetAll();
            var kodlarlast = kodlar.Select(x => x.Code).Distinct().ToList();

            string[] lanugage = new string[]
           {
                "tr","en","es","ru","fr","ar",
           };


            List<string> codeBilgi = new List<string>();
            var cultureInfo = _dokumanCategoryService.GetTuple()
                .Where(x => x.Item1 == model.RequestedData)
                .ToList();

            foreach (var dic in cultureInfo)
            {
                codeBilgi.Add(dic.Item2);
            }


            List<string> liste = new List<string>();

            liste = lanugage.Except(codeBilgi).ToList();
            //foreach (var item in cultureInfo)
            //{
            //    liste.Add(new PInfo {Code=item.Item1,Culture = item.Item2  });
            //}


            var model2 = new DokumanModel()
            {
                Codes = kodlarlast,
                AllCultures = liste
            };

            return View(model2);



        }


        public IActionResult GetSelectDokumanKategori(DokumanModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new DokumanModel()
                {
                    RequestedData = model.RequestedData
                };


                return RedirectToAction("DokumanKategoriLangAdd", data);
            }
            return RedirectToAction("DokumanKategoriLangAdd", "Admin");
        }

        [HttpPost]
        public IActionResult DokumanKategoriAddLangMethod(DokumanModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new DokumanCategory()
                {
                    Code = model.RequestedData,
                    Culture = model.Culture,
                    Name = model.Name,


                };


                _dokumanCategoryService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("DokumanKategori", "Admin");
            }

            return RedirectToAction("DokumanKategoriLangAdd", model);
        }

        [HttpPost]
        public async Task<IActionResult> deletedokumankategoriAsync(int categoryid)
        {
            var entity = await _dokumanCategoryService.GetById(categoryid);

            if (entity != null)
            {
                _dokumanCategoryService.DeleteWithDocuments(entity);
            }


            return RedirectToAction("DokumanKategori", "Admin");
        }


        public async Task<IActionResult> DokumanKategoriEditAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var entity = await _dokumanCategoryService.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new DokumanModel()
            {

                Culture = entity.Culture,
                DokumanCategoryId = entity.DokumanCategoryId,
                Code = entity.Code,
                Name = entity.Name


            };

            return View(model);


        }



        [HttpPost]
        public async Task<IActionResult> EditDokumanCategorySubmitAsync(DokumanModel model)
        {

            var entity = await _dokumanCategoryService.GetById(model.DokumanCategoryId);

            if (entity == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                entity.Code = model.Code;
                entity.Name = model.Name;

                entity.Culture = model.Culture;


                _dokumanCategoryService.Update(entity);


                return RedirectToAction("DokumanKategori");
            }

            return RedirectToAction("DokumanKategori", model.DokumanCategoryId);




        }

        #endregion


        #region Dokumanlar

        public async Task<IActionResult> DokumanlarAsync(int page = 1)
        {
            const int pageSize = 10;


            var dokumanlar = await _dokumanService.GetAll();




            var model = new DokumanModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = dokumanlar.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                dokumanlar = _dokumanService.GetByPageSize(page, pageSize)

            };

            return View(model);

        }



        public async Task<IActionResult> DokumanAddAsync()
        {
            var dokumancategories = await _dokumanCategoryService.GetAll();
            dokumancategories.Where(z => z.Culture == "tr").ToList();

            var model = new DokumanModel()
            {
                dokumanCategories = dokumancategories
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DokumanAddMethod(DokumanModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");

                var selectedCategory = _dokumanCategoryService.GetById(model.DokumanCategoryId);

                var entity = new Dokuman()
                {
                    Code = UrlFriendly.URLFriendly(model.Name),
                    Culture = model.Culture,
                    Name = model.Name,








                };

                if (model.file != null)
                {

                    entity.DokumanUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_" + Guid.NewGuid()}{extension}");

                    entity.DokumanUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }



                _dokumanService.CreateRaw(entity, model.DokumanCategoryIds);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Dokumanlar", "Admin");
            }

            return RedirectToAction("DokumanAdd", model);
        }


        [HttpPost]
        public async Task<IActionResult> deletedokumanAsync(int id)
        {
            var entity = await _dokumanService.GetById(id);

            if (entity != null)
            {
                _dokumanService.Delete(entity);
            }


            return RedirectToAction("Dokumanlar", "Admin");
        }


        public async Task<IActionResult> DokumanLangAddAsync(DokumanModel model)
        {
            var dokumancategories = await _dokumanCategoryService.GetAll();
            dokumancategories.Where(z => z.Culture == "tr").ToList();



            var kodlar = await _dokumanService.GetAll();
            var kodlarlas = kodlar.Select(x => x.Code).Distinct().ToList();

            string[] lanugage = new string[]
           {
                "tr","en","es","ru","fr","ar",
           };


            List<string> codeBilgi = new List<string>();
            var cultureInfo = _dokumanService.GetTuple()
                .Where(x => x.Item1 == model.RequestedData)
                .ToList();

            foreach (var dic in cultureInfo)
            {
                codeBilgi.Add(dic.Item2);
            }


            List<string> liste = new List<string>();

            liste = lanugage.Except(codeBilgi).ToList();
            //foreach (var item in cultureInfo)
            //{
            //    liste.Add(new PInfo {Code=item.Item1,Culture = item.Item2  });
            //}


            var model2 = new DokumanModel()
            {
                Codes = kodlarlas,
                AllCultures = liste,
                dokumanCategories = dokumancategories

            };

            return View(model2);
        }


        public IActionResult GetSelectDokuman(DokumanModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new DokumanModel()
                {
                    RequestedData = model.RequestedData
                };


                return RedirectToAction("DokumanLangAdd", data);
            }
            return RedirectToAction("DokumanLangAdd", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> DokumanAddLangMethod(DokumanModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");

                var selectedCategory = _dokumanCategoryService.GetById(model.DokumanCategoryId);

                var entity = new Dokuman()
                {
                    Code = model.RequestedData,
                    Culture = model.Culture,
                    Name = model.Name,








                };

                if (model.file != null)
                {

                    entity.DokumanUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_" + Guid.NewGuid()}{extension}");

                    entity.DokumanUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }

                //get right category
                // Debug.Print("denemeadmin");
                //  var dize = getRightCategory.GetRightCategories(model.DokumanCategoryIds, model.Culture);
                var lastobje = await _dokumanService.GetAll();
                var lastobjelast = lastobje.OrderByDescending(i => i.DokumanId).First();
                var lastsayi = lastobjelast.DokumanId;
                Debug.Print(model.DokumanCategoryIds.ToString());
                var liste = new List<DokumanCategory>();
                for (int id = 1; id < lastsayi; id++)
                {
                    if (model.DokumanCategoryIds.Contains(id))
                    {
                        var dk = await _dokumanCategoryService.GetById(id);
                        liste.Add(dk);
                    }
                }


                Debug.Print("deneme");
                List<int> liste2 = new List<int>();
                foreach (var category in liste)
                {
                    var right = await _dokumanCategoryService.GetAll();
                    var rightlast = right.Where(i => i.Code == category.Code && i.Culture == model.Culture)
                         .FirstOrDefault();

                    liste2.Add(rightlast.DokumanCategoryId);
                }

                foreach (var item in liste2)
                {
                    Debug.Print(liste2.ToString());
                }

                int[] rightIds = liste2.ToArray();






                _dokumanService.CreateRaw(entity, rightIds);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Dokumanlar", "Admin");
            }

            return RedirectToAction("DokumanLangAdd", model);

        }
        #endregion


        #region Category

        public async Task<IActionResult> CategoriesAsync(int page = 1)
        {
            const int pageSize = 10;


            var kategoriler = await _categoryService.GetAll();
            kategoriler.OrderBy(i => i.Code);


            var model = new CategoryModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = kategoriler.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                categories = _categoryService.GetByPageSize(page, pageSize)

            };

            return View(model);
        }


        public IActionResult CategoryAdd()
        {
            return View();
        }



        [HttpPost]
        public async  Task<IActionResult> CategoryAddMethod(CategoryModel model)
        {

            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new Category()
                {
                    Code = UrlFriendly.URLFriendly(model.Title),
                    Culture = model.Culture,
                    Title = model.Title,

                    Description = model.Description,
                    SeoUrl = model.SeoUrl,

                    MetaDescription = model.MetaDescription,
                    Granuls = model.Granuls
           


                };

                if (model.SeoUrl == null)
                {
                    var friendlyUrl = UrlFriendly.URLFriendly(model.Title);
                    entity.SeoUrl = friendlyUrl;
                }
                else
                {
                    entity.SeoUrl = model.SeoUrl;
                }

                if (model.file != null)
                {

                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Title) + "_image" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\kategori", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }





                _categoryService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Categories", "Admin");
            }

            return RedirectToAction("CategoryAdd", model);
        }



        public async Task<IActionResult> CategoryLangAddAsync(CategoryModel model)
        {

            var kodlar = await _categoryService.GetAll();
            var kodlarlaast = kodlar.Select(x => x.Code).Distinct().ToList();

            string[] lanugage = new string[]
           {
                "tr","en","es","ru","fr","ar",
           };


            List<string> codeBilgi = new List<string>();
            var cultureInfo = _categoryService.GetTuple()
                .Where(x => x.Item1 == model.RequestedData)
                .ToList();

            foreach (var dic in cultureInfo)
            {
                codeBilgi.Add(dic.Item2);
            }


            List<string> liste = new List<string>();

            liste = lanugage.Except(codeBilgi).ToList();
            //foreach (var item in cultureInfo)
            //{
            //    liste.Add(new PInfo {Code=item.Item1,Culture = item.Item2  });
            //}


            var model2 = new CategoryModel()
            {
                Codes = kodlarlaast,
                AllCultures = liste
            };

            return View(model2);



        }


        public IActionResult GetSelectedCategory(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new CategoryModel()
                {
                    RequestedData = model.RequestedData
                };


                return RedirectToAction("CategoryLangAdd", data);
            }
            return RedirectToAction("CategoryLangAdd", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAddLangMethod(CategoryModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new Category()
                {
                    Code = model.RequestedData,
                    Culture = model.Culture,
                    Title = model.Title,

                    Description = model.Description,
                    SeoUrl = model.SeoUrl,

                    MetaDescription = model.MetaDescription,
                    Granuls = model.Granuls
               


                };

                if (model.SeoUrl == null)
                {
                    var friendlyUrl = UrlFriendly.URLFriendly(model.Title);
                    entity.SeoUrl = friendlyUrl;
                }
                else
                {
                    entity.SeoUrl = model.SeoUrl;
                }



                if (model.file != null)
                {

                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Title) + "_image" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\kategori", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }

                _categoryService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Categories", "Admin");
            }

            return RedirectToAction("CategoryLangAdd", model);
        }



        [HttpPost]
        public async Task<IActionResult> DeleteCategoryAsync(int categoryid)
        {
            var entity = await _categoryService.GetById(categoryid);

            if (entity != null)
            {
                _categoryService.DeleteWithDocuments(entity);
            }


            return RedirectToAction("Categories", "Admin");
        }


        public async Task<IActionResult> CategoryEditAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var entity = await _categoryService.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new CategoryModel()
            {

                Culture = entity.Culture,
                CategoryId = entity.CategoryId,
                Code = entity.Code,
                Title = entity.Title,
                Description = entity.Description,
                SeoUrl = entity.SeoUrl,
                MetaDescription = entity.MetaDescription,
                Granuls = entity.Granuls,
                ImageUrl = entity.ImageUrl
                
         


            };


            



            return View(model);


        }



        [HttpPost]
        public async Task<IActionResult> EditCategorySubmit(CategoryModel model)
        {

            var entity = await _categoryService.GetById(model.CategoryId);

            if (entity == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                entity.Code = model.Code;
                entity.Title = model.Title;
                entity.SeoUrl = model.SeoUrl;
                entity.Description = model.Description;
                entity.MetaDescription = model.MetaDescription;
                entity.Granuls = model.Granuls;

                entity.Culture = model.Culture;




                if (model.file != null)
                {

                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Title) + "_image" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\kategori", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }
                else
                {
                    entity.ImageUrl = model.ImageUrl;
                }


                _categoryService.Update(entity);


                return RedirectToAction("Categories", "Admin");
            }

            return RedirectToAction("Categories", model.CategoryId);




        }


        #endregion




        #region Product
        public async Task<IActionResult> ProductsAsync(int page = 1)
        {
            const int pageSize = 10;


            var products = await _productService.GetAll();

            var categories = await _categoryService.GetAll();

            var relation = _productService.GetRelationTable();
            var model = new ProductModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = products.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                Products = _productService.GetByPageSize(page, pageSize),
                categories = categories,
                relation = relation

            };

            return View(model);

        }

        public async Task<IActionResult> ProductAddAsync()
        {
            var categories = await _categoryService.GetAll();
            categories.Where(z => z.Culture == "tr").ToList();

            var model = new ProductModel()
            {
                categories = categories
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductAddMethod(ProductModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new Product()
                {
                    Code = model.Code,
                    Culture = model.Culture,
                    Renk = model.Renk,
                    UstGenislik = model.UstGenislik,
                    UstCap = model.UstCap,
                    AltCap = model.AltCap,
                    TbCap = model.TbCap,
                    Yukseklik = model.Yukseklik,
                    Hacim = model.Hacim,
                    TamHacim = model.TamHacim,
                    Baski = model.Baski,
                    SosisIciAdet = model.SosisIciAdet,
                    KoliIciAdet = model.KoliIciAdet
                    









                };

                if (model.file != null)
                {

                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Code) + "_" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\urunresimler", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }


                }



                _productService.CreateRaw(entity, model.CategoryIds);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Products", "Admin");
            }

            return RedirectToAction("Products", model);
        }




        [HttpPost]
        public async Task<IActionResult> deleteproductAsync(int id)
        {
            var entity = await _productService.GetById(id);

            if (entity != null)
            {
                _productService.DeleteWithRelation(entity);
            }


            return RedirectToAction("Products", "Admin");
        }




        public async Task<IActionResult> ProductEditAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _productService.GetByIdWithCategories((int)id);

            // var entity = _productService.GetById((int)id);
            var categories = await  _categoryService.GetAll();
            categories.Where(z => z.Culture == "tr").ToList();


            if (entity == null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Code = entity.Code,
                Culture = entity.Culture,
                Renk = entity.Renk,
                UstGenislik = entity.UstGenislik,
                UstCap = entity.UstCap,
                AltCap = entity.AltCap,
                TbCap = entity.TbCap,
                Yukseklik = entity.Yukseklik,
                Hacim = entity.Hacim,
                TamHacim = entity.TamHacim,
                Baski = entity.Baski,
                SosisIciAdet = entity.SosisIciAdet,
                KoliIciAdet = entity.KoliIciAdet,
                ImageUrl = entity.ImageUrl,

                categories = categories,

                Selectedcategories = entity.ProductCategories.Select(i => i.CategoryId).ToList()


            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductEditMethod(ProductModel model, IFormFile file)
        {

            var entity = await _productService.GetById(model.ProductId);

            if (entity == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                model.Code = entity.Code;
                model.Culture = entity.Culture;
                model.Renk = entity.Renk;
                model.UstGenislik = entity.UstGenislik;
                model.UstCap = entity.UstCap;
                model.AltCap = entity.AltCap;
                model.TbCap = entity.TbCap;
                model.Yukseklik = entity.Yukseklik;
                model.Hacim = entity.Hacim;
                model.TamHacim = entity.TamHacim;
                model.Baski = entity.Baski;
                model.SosisIciAdet = entity.SosisIciAdet;
                model.KoliIciAdet = entity.KoliIciAdet;
                model.ImageUrl = entity.ImageUrl;

                if (file != null)
                {
                    entity.ImageUrl = model.file.FileName;

                    var extension = Path.GetExtension(model.file.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Code) + "_" + Guid.NewGuid()}{extension}");

                    entity.ImageUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\urunresimler", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.file.CopyToAsync(stream);
                    }
                }

                _productService.Update(entity, model.CategoryIds);


                return RedirectToAction("Products", "Admin");
            }

            return RedirectToAction("ProductEdit", model);




        }

        #endregion



        #region Uygulamalar


        public async Task<IActionResult> UygulamalarAsync(int page = 1)
        {
            const int pageSize = 10;


            var kategoriler = await _categoryService.GetAll();
            kategoriler.OrderBy(i => i.Code);


            var model = new UygulamalarBigModel()
            {

                PageInfo = new PageInfo()
                {
                    TotalItems = kategoriler.Count(),
                    CurrentPage = page,
                    ItemsPerPage = pageSize
                },
                uygulamalarList = _uygulamalarService.GetByPageSize(page, pageSize)

            };

            return View(model);
        }

        public IActionResult UygulamaAdd()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> UygulamalarAddMethod(UygulamalarBigModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new Uygulama()
                {
                    Code = UrlFriendly.URLFriendly(model.Name),
                    Culture = model.Culture,
                    Name = model.Name,
                    Description = model.Description,
                    MetaDescription = model.MetaDescription
            
                };



                if (model.SeoUrl == null)
                {
                    var friendlyUrl = UrlFriendly.URLFriendly(model.Name);
                    entity.SeoUrl = friendlyUrl;
                }
                else
                {
                    entity.SeoUrl = model.SeoUrl;
                }


                if (model.filePdf != null)
                {

                    entity.PdfUrl = model.filePdf.FileName;

                    var extension = Path.GetExtension(model.filePdf.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Pdf" + Guid.NewGuid()}{extension}");

                    entity.PdfUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.filePdf.CopyToAsync(stream);
                    }


                }

                if (model.fileBrosur != null)
                {

                    entity.Brosur = model.fileBrosur.FileName;

                    var extension = Path.GetExtension(model.fileBrosur.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Brosur" + Guid.NewGuid()}{extension}");

                    entity.Brosur = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileBrosur.CopyToAsync(stream);
                    }


                }

                if (model.fileDataSheet != null)
                {

                    entity.DataSheet = model.fileDataSheet.FileName;

                    var extension = Path.GetExtension(model.fileDataSheet.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Datasheet" + Guid.NewGuid()}{extension}");

                    entity.DataSheet = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileDataSheet.CopyToAsync(stream);
                    }


                }


                if (model.fileSayfaResmi != null)
                {

                    entity.SayfaResmi = model.fileSayfaResmi.FileName;

                    var extension = Path.GetExtension(model.fileSayfaResmi.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Resim" + Guid.NewGuid()}{extension}");

                    entity.SayfaResmi = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\uygulamalar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileSayfaResmi.CopyToAsync(stream);
                    }


                }



                _uygulamalarService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Uygulamalar", "Admin");
            }

            return RedirectToAction("UygulamalarAdd", model);
        }



        public async Task<IActionResult> UygulamalarLangAddAsync(UygulamalarBigModel model)
        {

            var kodlar = await _uygulamalarService.GetAll();
            var stringkodlar= kodlar.Select(x => x.Code).Distinct().ToList();


            string[] lanugage = new string[]
           {
                "tr","en","es","ru","fr","ar",
           };


            List<string> codeBilgi = new List<string>();
            var cultureInfo = _uygulamalarService.GetTuple()
                .Where(x => x.Item1 == model.RequestedData)
                .ToList();

            foreach (var dic in cultureInfo)
            {
                codeBilgi.Add(dic.Item2);
            }


            List<string> liste = new List<string>();

            liste = lanugage.Except(codeBilgi).ToList();
            //foreach (var item in cultureInfo)
            //{
            //    liste.Add(new PInfo {Code=item.Item1,Culture = item.Item2  });
            //}


            var model2 = new UygulamalarBigModel()
            {
                Codes = stringkodlar,
                AllCultures = liste
            };

            return View(model2);



        }


        public IActionResult GetSelectedUygulama(UygulamalarBigModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new UygulamalarBigModel()
                {
                    RequestedData = model.RequestedData
                };


                return RedirectToAction("UygulamalarLangAdd", data);
            }
            return RedirectToAction("UygulamalarLangAdd", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> UygulamalarLangAddMethod(UygulamalarBigModel model)
        {
            if (ModelState.IsValid)
            {

                //var tel = model.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");



                var entity = new Uygulama()
                {
                    Code = model.RequestedData,
                    Culture = model.Culture,
                    Name = model.Name,
                    Description = model.Description,
                    MetaDescription = model.MetaDescription
          
                };



                if (model.SeoUrl == null)
                {
                    var friendlyUrl = UrlFriendly.URLFriendly(model.Name);
                    entity.SeoUrl = friendlyUrl;
                }
                else
                {
                    entity.SeoUrl = model.SeoUrl;
                }


                if (model.filePdf != null)
                {

                    entity.PdfUrl = model.filePdf.FileName;

                    var extension = Path.GetExtension(model.filePdf.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Pdf" + Guid.NewGuid()}{extension}");

                    entity.PdfUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.filePdf.CopyToAsync(stream);
                    }


                }

                if (model.fileBrosur != null)
                {

                    entity.Brosur = model.fileBrosur.FileName;

                    var extension = Path.GetExtension(model.fileBrosur.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Brosur" + Guid.NewGuid()}{extension}");

                    entity.Brosur = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileBrosur.CopyToAsync(stream);
                    }


                }

                if (model.fileDataSheet != null)
                {

                    entity.DataSheet = model.fileDataSheet.FileName;

                    var extension = Path.GetExtension(model.fileDataSheet.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Datasheet" + Guid.NewGuid()}{extension}");

                    entity.DataSheet = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileDataSheet.CopyToAsync(stream);
                    }


                }


                if (model.fileSayfaResmi != null)
                {

                    entity.SayfaResmi = model.fileSayfaResmi.FileName;

                    var extension = Path.GetExtension(model.fileSayfaResmi.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Datasheet" + Guid.NewGuid()}{extension}");

                    entity.SayfaResmi = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\uygulamalar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileSayfaResmi.CopyToAsync(stream);
                    }


                }



                _uygulamalarService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = "Başarılı",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);



                return RedirectToAction("Uygulama", "Admin");
            }

            return RedirectToAction("UygulamalarAdd", model);
        }



        [HttpPost]
        public async Task<IActionResult> DeleteUygulamaAsync(int id)
        {
            var entity = await _uygulamalarService.GetById(id);

            if (entity != null)
            {
                _uygulamalarService.Delete(entity);
            }


            return RedirectToAction("Uygulama", "Admin");
        }


        public async Task<IActionResult> UygulamalarEditAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var entity = await _uygulamalarService.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new UygulamalarBigModel()
            {

                Culture = entity.Culture,
                Id = entity.Id,
                Code = entity.Code,
                Name = entity.Name,
                Description = entity.Description,
                SeoUrl = entity.SeoUrl,
                MetaDescription = entity.MetaDescription,
                SayfaResmi = entity.SayfaResmi,

  
                PdfUrl = entity.PdfUrl,
                DataSheet = entity.DataSheet,
                Brosur = entity.Brosur


            };

            return View(model);


        }



        [HttpPost]
        public async Task<IActionResult> UygulamalarEditMethod(UygulamalarBigModel model)
        {

            var entity = await  _uygulamalarService.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                entity.Culture = model.Culture;
                entity.Id = model.Id;
                entity.Code = model.Code;
                entity.Name = model.Name;
                entity.Description = model.Description;

                entity.SeoUrl = model.SeoUrl;

                entity.MetaDescription = model.MetaDescription;

                entity.PdfUrl = model.PdfUrl;
                entity.DataSheet = model.DataSheet;
                entity.Brosur = model.Brosur;

                entity.SayfaResmi = model.SayfaResmi;


                if (model.SeoUrl != null)
                {
                    entity.SeoUrl = model.SeoUrl;
                }
            


                if (model.filePdf != null)
                {

                    entity.PdfUrl = model.filePdf.FileName;

                    var extension = Path.GetExtension(model.filePdf.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Pdf" + Guid.NewGuid()}{extension}");

                    entity.PdfUrl = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.filePdf.CopyToAsync(stream);
                    }


                }

                if (model.fileBrosur != null)
                {

                    entity.Brosur = model.fileBrosur.FileName;

                    var extension = Path.GetExtension(model.fileBrosur.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Brosur" + Guid.NewGuid()}{extension}");

                    entity.Brosur = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileBrosur.CopyToAsync(stream);
                    }


                }

                if (model.fileDataSheet != null)
                {

                    entity.DataSheet = model.fileDataSheet.FileName;

                    var extension = Path.GetExtension(model.fileDataSheet.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Datasheet" + Guid.NewGuid()}{extension}");

                    entity.DataSheet = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\dosyalar\\dokumanlar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileDataSheet.CopyToAsync(stream);
                    }


                }


                if (model.fileSayfaResmi != null)
                {

                    entity.SayfaResmi = model.fileSayfaResmi.FileName;

                    var extension = Path.GetExtension(model.fileSayfaResmi.FileName);

                    var randomName = String.Format($"{UrlFriendly.URLFriendly(model.Name) + "_Resim" + Guid.NewGuid()}{extension}");

                    entity.SayfaResmi = randomName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\uygulamalar", randomName);


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.fileSayfaResmi.CopyToAsync(stream);
                    }


                }
          
             
                    _uygulamalarService.Update(entity);
              
              
                

                return RedirectToAction("Uygulamalar", "Admin");
            }

            return RedirectToAction("Uygulamalar", model.Id);




        }


        #endregion



    }
}
