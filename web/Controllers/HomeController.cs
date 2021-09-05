using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web.Models;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using System.Text;
using System.Configuration;
using System.Net;
using data.Abstract;
using business.Abstract;
using entity;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;
using AspNetCore.SEOHelper.Sitemap;
using DNTCaptcha.Core;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHtmlLocalizer<HomeController> _localizer;
        private IProductService _productService;
        private ICategoryService _categoryService;
        private IKariyerService _kariyerService;
        private IContactService _contactService;
        private IDokumanService _dokumanService;
        private readonly IWebHostEnvironment _env;
        private IUygulamalarService _uygulamalarService;
        private INewsService _newsService;
        private readonly IDNTCaptchaValidatorService _validatorService;
        private readonly DNTCaptchaOptions _captchaOptions;
        private IConfiguration _configuration;




        public HomeController(ILogger<HomeController> logger,
            IHtmlLocalizer<HomeController> localizer,
            IProductService productService,
            ICategoryService categoryService,
            IKariyerService kariyerService,
            IContactService contactService,
            IDokumanService dokumanService,
            IWebHostEnvironment env,
            IUygulamalarService uygulamalarService,
            INewsService newsService,
            IConfiguration configuration,
            IDNTCaptchaValidatorService validatorService,
            IOptions<DNTCaptchaOptions> options
            )
        {
            _logger = logger;
            _localizer = localizer;
            _productService = productService;
            _categoryService = categoryService;
            _kariyerService = kariyerService;
            _contactService = contactService;
            _dokumanService = dokumanService;
            _env = env;
            _uygulamalarService = uygulamalarService;
            _newsService = newsService;
            _configuration = configuration;
            _validatorService = validatorService;
            _captchaOptions = options == null ? throw new ArgumentNullException(nameof(options)) : options.Value;
        }


     


        public IActionResult Index()
        {
          

            var list = new List<SitemapNode>();


            var levhalar = _uygulamalarService.GetAll();

            var thermoformCategory = _categoryService.GetAll();

            var haberler = _newsService.GetAll();

            foreach (var levha in levhalar)
            {
                var url = levha.SeoUrl;

                list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = $"https://yollawebe.com/levhalar/{url}", Frequency = SitemapFrequency.Always });
            }

            foreach (var thermoform in thermoformCategory)
            {
                var thermourl = thermoform.SeoUrl;

                list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = $"https://yollawebe.com/{thermourl}", Frequency = SitemapFrequency.Always });
            }

            foreach (var haber in haberler)
            {
                var haberurl = haber.SeoUrl;

                list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = $"https://yollawebe.com/haberler/{haberurl}", Frequency = SitemapFrequency.Always });
            }



            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/", Frequency = SitemapFrequency.Always });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/anasayfa", Frequency = SitemapFrequency.Always });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/hakkimizda", Frequency = SitemapFrequency.Always });
          
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/isg-politika", Frequency = SitemapFrequency.Always });
           
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/yatirimci-iliskileri", Frequency = SitemapFrequency.Always });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/guncelleniyor", Frequency = SitemapFrequency.Always });
          
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/iletisim", Frequency = SitemapFrequency.Always });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://yollawebe.com/kariyer", Frequency = SitemapFrequency.Always });

            new SitemapDocument().CreateSitemapXML(list, _env.ContentRootPath);



            return View();
        }

        [Route("/Home/HandleError/{code:int}")]
        public IActionResult HandleError(int code)
        {
            ViewData["ErrorMessage"] = $"Error occurred. The ErrorCode is: {code}";
            return View("~/Views/Shared/HandleError.cshtml");
        }



        public IActionResult Iletisim()
        {
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        [ValidateDNTCaptcha(ErrorMessage = "Please enter the security code as a number.",

                    CaptchaGeneratorLanguage = Language.English,
                    CaptchaGeneratorDisplayMode = DisplayMode.ShowDigits)]
        public IActionResult contactme(BigViewModel model)
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            // Culture contains the information of the requested culture
            var culture = rqf.RequestCulture.Culture;


            if (ModelState.IsValid)
            {

                var tel = model.FormModelContact.Telefon.Replace("(", "").Replace(")", "").Replace("-", "");

                var kampanya = "";
                if (model.FormModelContact.Kampanya == 1)
                {
                    kampanya = "kampanyayı kabul ediyorum.";
                }
                else
                {
                    kampanya = "kampanyayı kabul etmiyorum.";
                }

                var mailto = _configuration.GetSection("AppSettings")["emailTo"];
                MailMessage _mm = new MailMessage();
                _mm.SubjectEncoding = Encoding.Default;
                _mm.Subject = model.FormModelContact.AdiSoyadi + " --//--  " + model.FormModelContact.Email;
                _mm.BodyEncoding = Encoding.Default;
                _mm.Body = "İsim: " + model.FormModelContact.AdiSoyadi + "-------Email:" + model.FormModelContact.Email
                    + "--------Telefon: " + model.FormModelContact.Telefon + "---------Kampanya:"
                    + kampanya
                    + "------------Mesaj:" + model.FormModelContact.Mesaj;
                var mailfrom = _configuration.GetSection("AppSettings")["emailAccount"];
                _mm.From = new MailAddress(mailfrom);
                _mm.To.Add(mailto);

                SmtpClient _smtpClient = new SmtpClient();
                _smtpClient.Host = _configuration.GetSection("AppSettings")["emailHost"];
                _smtpClient.Port = int.Parse(_configuration.GetSection("AppSettings")["emailPort"]);
                _smtpClient.Credentials = new NetworkCredential(_configuration.GetSection("AppSettings")["emailAccount"], _configuration.GetSection("AppSettings")["emailPassword"]);
                _smtpClient.EnableSsl = bool.Parse(_configuration.GetSection("AppSettings")["emailSecure"]);

                _smtpClient.Send(_mm);

                ModelState.Clear();


                var entity = new Contact()
                {
                    Name = model.FormModelContact.AdiSoyadi,
                    Email = model.FormModelContact.Email,
                    Telephone = tel,
                    Message = model.FormModelContact.Mesaj,
                    Kampanya = model.FormModelContact.Kampanya,
                    Tarih = DateTime.Now
                };

                _contactService.Create(entity);

                if (culture.Name == "tr")
                {
                    var msg = new AlertMessage()
                    {
                        Message = "Mesajınız bize ulaştı. En kısa zamanda geri dönüş yapılacaktır.",
                        AlertType = "success"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }
                else
                {
                    var msg = new AlertMessage()
                    {
                        Message = "Your message has reached us.We will eesponse as soon as possible.",
                        AlertType = "success"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }


            }
            else
            {
                if (culture.Name == "tr")
                {
                    var msg = new AlertMessage()
                    {
                        Message = "Bir Hata oluştu lütfen güvenlik kodunuzu kontrol ediniz.",
                        AlertType = "danger"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }
                else
                {
                    var msg = new AlertMessage()
                    {
                        Message = "An Error has occurred, please check your security code.",
                        AlertType = "danger"
                    };
                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }

            }


            return LocalRedirect(model.returnUrl);
        }
        public IActionResult Kariyer()
        {

            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> KariyerSubmit(BigViewModel model)
        {

            

            if (ModelState.IsValid)
            {

                var tel = model.KariyerModel.Telephone.Replace("(", "").Replace(")", "").Replace("-", "");
               
                var entity = new Kariyer()
                {
                    Ad = model.KariyerModel.Name,
                    Email = model.KariyerModel.Email,
                    Telephone = tel,
                    Message = model.KariyerModel.Message,
                    BasvuruTarihi = DateTime.Now
                };

                if (model.KariyerModel.file != null)
                {

                  entity.CvUrl = model.KariyerModel.file.FileName;

                  var extension = Path.GetExtension(model.KariyerModel.file.FileName);

                   var randomName = String.Format($"{model.KariyerModel.Email + "_" + Guid.NewGuid()}{extension}");

                  entity.CvUrl = randomName;

                  var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Cvler", randomName);

                    if (extension == ".pdf")
                    {
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await model.KariyerModel.file.CopyToAsync(stream);
                        }


                        _kariyerService.Create(entity);
                        var msg = new AlertMessage()
                        {
                            Message = "Gönderim başarılı.",
                            AlertType = "success"
                        };
                        TempData["message"] = JsonConvert.SerializeObject(msg);
                        

                    }
                    else if (extension == ".doc")
                    {
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await model.KariyerModel.file.CopyToAsync(stream);
                        }


                        _kariyerService.Create(entity);
                        var msg = new AlertMessage()
                        {
                            Message = "Gönderim başarılı.",
                            AlertType = "success"
                        };
                        TempData["message"] = JsonConvert.SerializeObject(msg);
                    }
                    else
                    {

                        var msg = new AlertMessage()
                        {
                            Message = "Lütfen dosyanızın formatını kntrol ediniz.",
                            AlertType = "danger"
                        };
                        TempData["message"] = JsonConvert.SerializeObject(msg);
                       
                    }
                }

                return RedirectToAction("kariyer", model);
            }  
            else
            {
                var msg = new AlertMessage()
                {
                    Message = "Sunucuda bir hata oluştu. Lütfen daha sonra tekrar deneyin.",
                    AlertType = "danger"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("kariyer", model);
            }

            

        }

        public IActionResult YatirimciIliskileri()
        {
            return View();
        }


        

        [HttpPost]
        public IActionResult CultureManagement(string culture,string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });

            return LocalRedirect(returnUrl);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            return View();
        }

      



        private  void CreateMessage(string message, string alerttype)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alerttype
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

        }

       
        public IActionResult Search(string searchString)
        {

            var model = new BigViewModel()
            {
                SearchModel = new SearchModel()
                {
                    searchedThermoformCategories = _categoryService.GetSearchResult(searchString),
                    searchedDocuments = _dokumanService.GetSearchResult(searchString)
                }
                
                    
              
              
            };


            return View(model);
            
        }




    

        public IActionResult Hakkimizda()
        {
            return View();
        }


        public IActionResult KurumsalPolitika()
        {
            return View();
        }

    
     

     

       

       



    }
}
