#pragma checksum "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53c1e88e272db9d01d71d1ce5679b491c2c6fde2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dokuman_Index), @"mvc.1.0.view", @"/Views/Dokuman/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\_ViewImports.cshtml"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\_ViewImports.cshtml"
using web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\_ViewImports.cshtml"
using entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\_ViewImports.cshtml"
using web.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c1e88e272db9d01d71d1ce5679b491c2c6fde2", @"/Views/Dokuman/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bc7e4419cc0c4e143c60eeb25ac883fa765fca", @"/Views/_ViewImports.cshtml")]
    public class Views_Dokuman_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BigViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
  
    Layout = "_Layout";
    var kategoriler = Model.DokumanModel.dokumanCategories;
    var dokumanlar = Model.DokumanModel.dokumanlar;

    var relation = Model.DokumanModel.relation;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("head", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 340, "\"", 375, 1);
#nullable restore
#line 13 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
WriteAttributeValue("", 350, localizer["description"], 350, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 404, "\"", 436, 1);
#nullable restore
#line 14 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
WriteAttributeValue("", 414, localizer["keywords"], 414, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <title>");
#nullable restore
#line 15 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
      Write(localizer["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Işık Plastik</title>\r\n");
            }
            );
            DefineSection("css", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("<div class=\"container\">\r\n    <h2>Dokumanlar</h2>\r\n\r\n    \r\n\r\n    <div class=\"panel-group\" id=\"accordion\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
         foreach (var item in kategoriler)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"panel panel-default\">\r\n                <div class=\"panel-heading\">\r\n                    <h4 class=\"panel-title\">\r\n                        <a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            BeginWriteAttribute("href", " href=\"", 898, "\"", 939, 2);
            WriteAttributeValue("", 905, "#collapse", 905, 9, true);
#nullable restore
#line 34 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
WriteAttributeValue("", 914, item.DokumanCategoryId, 914, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
                                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h4>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1028, "\"", 1066, 2);
            WriteAttributeValue("", 1033, "collapse", 1033, 8, true);
#nullable restore
#line 37 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
WriteAttributeValue("", 1041, item.DokumanCategoryId, 1041, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
                     foreach (var dokuman in dokumanlar)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
                         foreach (var relate in relation)
                        {
                            if (relate.Item1 == dokuman.DokumanId && relate.Item2.Contains(item.DokumanCategoryId))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul class=\"list-group\">\r\n                                    <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1568, 1);
#nullable restore
#line 46 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
WriteAttributeValue("", 1549, dokuman.DokumanUrl, 1549, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
                                                                                         Write(dokuman.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n");
#nullable restore
#line 48 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Dokuman\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BigViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591