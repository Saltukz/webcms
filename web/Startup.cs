using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using AspNetCore.SEOHelper;
using business.Abstract;
using business.Concrete;
using data.Abstract;
using data.Concrete.EfCore;
using web.Extensions;
using web.Helpers;
using web.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using DNTCaptcha.Core;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.ResponseCompression;

namespace web
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnetion")), ServiceLifetime.Transient);
            services.AddDbContext<ShopContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnetion")));
            //services.AddDbContext<ApplicationContext>(options => options.UseSqlServer();
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            // Add Response compression services
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 7;
                options.Password.RequireNonAlphanumeric = true;

                //locout

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(600);
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

              

            });

            services.ConfigureApplicationCookie(options =>
            {
                
                options.LoginPath = "/login";
                options.LogoutPath = "/";
                options.AccessDeniedPath = "/";
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".yollawebe.security.cookie",
                    SameSite = SameSiteMode.Strict
                };
            });






   

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductManager>();                  
            services.AddScoped<ICategoryService, CategoryManager>();            
            services.AddScoped<IContactService, ContactManager>();           
            services.AddScoped<IDokumanService, DokumanManager>();        
            services.AddScoped<IDokumanCategoryService, DokumanCategoryManager>();           
            services.AddScoped<IKariyerService, KariyerManager>();
            services.AddScoped<INewsService, NewsManager>();    
            services.AddScoped<IUygulamalarService, UygulamalarManager>();           
            services.AddScoped<IProjectGaleryService, ProjectGaleryManager>();            
            services.AddScoped<IProjectsService, ProjectsManager>();


            services.AddDNTCaptcha(option => option.UseCookieStorageProvider().ShowThousandsSeparators(false).WithEncryptionKey("web.formsecurity"));

            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddMvc().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            
            services.AddMvcCore(options =>
            {
                options.OutputFormatters.Clear(); // Remove json for simplicity
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            });


            services.Configure<RequestLocalizationOptions>(
                opt =>
                {
                   

                    var supportedCulteres = new List<CultureInfo>
                    {
                        new CultureInfo("tr"),
                        new CultureInfo("en"),
                        new CultureInfo("ru"),
                        new CultureInfo("es"),
                        new CultureInfo("fr"),
                        new CultureInfo("ar")
                    };
                    opt.DefaultRequestCulture = new RequestCulture("tr");
                    opt.SupportedCultures = supportedCulteres;
                    opt.SupportedUICultures = supportedCulteres;
                });



      


        }




        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //initializing custom roles 
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<User>>();
            string[] roleNames = { "Admin", "Editor", "Member" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                // ensure that the role does not exist
                if (!roleExist)
                {
                    //create the roles and seed them to the database: 
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // find the user with the admin email 
            var _user = await UserManager.FindByEmailAsync("");

            // check if the user exists
            if (_user == null)
            {
                //Here you could create the super admin who will maintain the web app
                var poweruser = new User
                {
                    UserName = "",
                    Email = "",
                };
                string adminPassword = "";

                var createPowerUser = await UserManager.CreateAsync(poweruser, adminPassword);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the role
                    await UserManager.AddToRoleAsync(poweruser, "Admin");

                }

              
            }
  
        }





        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env,
            IServiceProvider serviceProvider)
        {

            

            if (env.IsDevelopment())
            {
             
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePagesWithReExecute("/Home/HandleError/{0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            CreateRoles(serviceProvider).Wait();

            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);


            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse =
                r =>
                {
                    string path = r.File.PhysicalPath;
                    if (path.EndsWith(".css") || path.EndsWith(".js") || path.EndsWith(".gif") || path.EndsWith(".jpg") || path.EndsWith(".png") || path.EndsWith(".svg") || path.EndsWith(".jpeg"))
                    {
                        TimeSpan maxAge = new TimeSpan(15, 0, 0, 0);
                        r.Context.Response.Headers.Append("Cache-Control", "max-age=" + maxAge.TotalSeconds.ToString("0"));
                    }
                }
            });


            app.UseAuthentication();
            app.UseRouting();

            app.Use((context, next) => {
                // Ignore requests that don't point to static files.
                if (!context.Request.Path.StartsWithSegments("/Cvler"))
                {
                    return next();
                }


                if (context.User.IsInRole("admin"))
                {
                    return next();
                }
                // Don't return a 401 response if the user is already authenticated.
                if (context.User.Identities.Any(identity => identity.HasClaim("pozisyon", "admin")))
                {
                    return next();
                }

                // Stop processing the request and return a 401 response.
                context.Response.StatusCode = 401;
                return Task.FromResult(0);
            });


            app.UseAuthorization();










            app.UseXMLSitemap(env.ContentRootPath);

            app.UseRobotsTxt(env.ContentRootPath);

            app.UseEndpoints(endpoints =>
            {
              

                endpoints.MapControllerRoute(
name: "anasayfa",
pattern: "/anasayfa",
defaults: new { controller = "Home", action = "Index" }
);


                endpoints.MapControllerRoute(
                name: "anasayfa",
                pattern: "/kutuphane",
                defaults: new { controller = "Dokuman", action = "Index" }
                );



                endpoints.MapControllerRoute(
name: "anasayfa",
pattern: "/anasayfa",
defaults: new { controller = "Home", action = "Index" }
);


                endpoints.MapControllerRoute(
    name: "yatirimciiliskileri",
    pattern: "/yatirimci-iliskileri",
    defaults: new { controller = "Home", action = "YatirimciIliskileri" }
    );




              

                endpoints.MapControllerRoute(
             name: "kurumsalpolitika",
             pattern: "/kurumsal-politika",
             defaults: new { controller = "Home", action = "KurumsalPolitika" }
             );


                endpoints.MapControllerRoute(
             name: "hakkimizda",
             pattern: "/hakkimizda",
             defaults: new { controller = "Home", action = "Hakkimizda" }
             );




                endpoints.MapControllerRoute(
             name: "admingiris",
             pattern: "/login",
             defaults: new { controller = "Account", action = "Login" }
             );

             
                

                endpoints.MapControllerRoute(
              name: "adminuygulamakategoridilekle",
              pattern: "admin/uygulama-dil-ekle",
              defaults: new { controller = "Admin", action = "UygulamalarLangAdd" }
              );


                endpoints.MapControllerRoute(
              name: "adminuygulamakategoriekle",
              pattern: "admin/uygulama-ekle",
              defaults: new { controller = "Admin", action = "UygulamaAdd" }
              );


                endpoints.MapControllerRoute(
               name: "adminuygulamalar",
               pattern: "admin/uygulamalar",
               defaults: new { controller = "Admin", action = "Uygulamalar" }
               );

                endpoints.MapControllerRoute(
            name: "adminuygulamalaredit",
            pattern: "admin/uygulamalar/{id?}",
            defaults: new { controller = "Admin", action = "UygulamalarEdit" }
            );

                endpoints.MapControllerRoute(
              name: "search",
              pattern: "search",
              defaults: new { controller = "Home", action = "Search" }
              );

                endpoints.MapControllerRoute(
               name: "adminrunekle",
               pattern: "admin/urun-ekle",
               defaults: new { controller = "Admin", action = "ProductAdd" }
               );

                endpoints.MapControllerRoute(
                name: "admintermoformurunler",
                pattern: "admin/urunler",
                defaults: new { controller = "Admin", action = "Products" }
                );

                endpoints.MapControllerRoute(
             name: "adminthermoformurunedit",
             pattern: "admin/urunler/{id?}",
             defaults: new { controller = "Admin", action = "ProductEdit" }
             );




                endpoints.MapControllerRoute(
                name: "admincategorydil",
                pattern: "admin/kategori-dil-ekle",
                defaults: new { controller = "Admin", action = "CategoryLangAdd" }
                );


                endpoints.MapControllerRoute(
               name: "admindokumaneekle",
               pattern: "admin/kategori-ekle",
               defaults: new { controller = "Admin", action = "CategoryAdd" }
               );

                endpoints.MapControllerRoute(
               name: "admintcategories",
               pattern: "admin/kategoriler",
               defaults: new { controller = "Admin", action = "Categories" }
               );

                endpoints.MapControllerRoute(
              name: "adminkategoriedit",
              pattern: "admin/kategoriler/{id?}",
              defaults: new { controller = "Admin", action = "CategoryEdit" }
              );

                endpoints.MapControllerRoute(
               name: "admindokumanadileekle",
               pattern: "admin/dokuman-dil-ekle",
               defaults: new { controller = "Admin", action = "DokumanLangAdd" }
               );

                endpoints.MapControllerRoute(
               name: "admindokumaneklenormal",
               pattern: "admin/dokuman-ekle",
               defaults: new { controller = "Admin", action = "DokumanAdd" }
               );



                endpoints.MapControllerRoute(
                name: "admindokumanlar",
                pattern: "admin/dokumanlar",
                defaults: new { controller = "Admin", action = "Dokumanlar" }
                );

                endpoints.MapControllerRoute(
               name: "admindokumanedit",
               pattern: "admin/dokumanlar/{id?}",
               defaults: new { controller = "Admin", action = "DokumanlarEdit" }
               );


                endpoints.MapControllerRoute(
                name: "admindokumaneekle",
                pattern: "admin/dokuman-kategori-dil-ekle",
                defaults: new { controller = "Admin", action = "DokumanKategoriLangAdd" }
                );

                endpoints.MapControllerRoute(
                name: "admindokumaneekle",
                pattern: "admin/dokuman-kategori-ekle",
                defaults: new { controller = "Admin", action = "DokumanKategoriAdd" }
                );


                endpoints.MapControllerRoute(
                name: "admindokumankategori",
                pattern: "admin/dokuman-kategori",
                defaults: new { controller = "Admin", action = "DokumanKategori" }
                );

                endpoints.MapControllerRoute(
               name: "admindokumankategoriedit",
               pattern: "admin/dokuman-kategori/{id?}",
               defaults: new { controller = "Admin", action = "DokumanKategoriEdit" }
               );


                endpoints.MapControllerRoute(
                 name: "admindilekle",
                 pattern: "admin/dil-ekle",
                 defaults: new { controller = "Admin", action = "AddLanguageToNews" }
                 );


                endpoints.MapControllerRoute(
                  name: "adminhaberekle",
                  pattern: "admin/haber-ekle",
                  defaults: new { controller = "Admin", action = "AddNews" }
                  );

                endpoints.MapControllerRoute(
                  name: "adminhaberler",
                  pattern: "admin/haberler",
                  defaults: new { controller = "Admin", action = "News" }
                  );

                endpoints.MapControllerRoute(
                  name: "adminhaberedit",
                  pattern: "admin/haberler/{id?}",
                  defaults: new { controller = "Admin", action = "EditNews" }
                  );

                endpoints.MapControllerRoute(
                   name: "adminiletisim",
                   pattern: "admin/iletisim",
                   defaults: new { controller = "Admin", action = "iletisim" }
                   );

                endpoints.MapControllerRoute(
                   name: "adminkariyer",
                   pattern: "admin/kariyer",
                   defaults: new { controller = "Admin", action = "KariyerList" }
                   );



                endpoints.MapControllerRoute(
                  name: "referanslar",
                  pattern: "projeler/{pcode}",
              defaults: new { controller = "Referans", action = "List" }
              );


              //  endpoints.MapControllerRoute(
              //    name: "projeler",
              //    pattern: "projeler/Policam/{pcode}",
              //defaults: new { controller = "Referans", action = "List" }
              //);


                endpoints.MapControllerRoute(
                  name: "haber-detay",
                  pattern: "haberler/{seocode}",
              defaults: new { controller = "Haberler", action = "Details" }
              );


                endpoints.MapControllerRoute(
                   name: "uygulamalardetails",
                  pattern: "uygulamalar",
             defaults: new { controller = "Uygulama", action = "List" }
             );

                endpoints.MapControllerRoute(
                  name: "uygulamalardetails",
                 pattern: "uygulamalar/{seo}",
            defaults: new { controller = "Uygulama", action = "Details" }
            );

                endpoints.MapControllerRoute(
                   name: "urunlerdetails",
                  pattern: "kategoriler/{url}",
             defaults: new { controller = "Kategori", action = "Details" }
             );


                endpoints.MapControllerRoute(
                 name: "haberler",
                 pattern: "haberler",
             defaults: new { controller = "Haberler", action = "Index" }
             );


                endpoints.MapControllerRoute(
                   name: "yatirimci-iliskileri",
                   pattern: "yatirimci-iliskileri",
               defaults: new { controller = "Home", action = "YatirimciIliskileri" }
               );
             
                endpoints.MapControllerRoute(
                     name: "kariyer",
                    pattern: "kariyer",
               defaults: new { controller = "Home", action = "kariyer" }
               );
                endpoints.MapControllerRoute(
                     name: "iletisim",
                    pattern: "iletisim",
               defaults: new { controller = "Home", action = "iletisim" }
               );


              

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
