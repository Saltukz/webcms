#pragma checksum "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8fb759003a39954194635246e09a6b7f33d336d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminNav), @"mvc.1.0.view", @"/Views/Shared/_AdminNav.cshtml")]
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
#line 3 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\_ViewImports.cshtml"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\_ViewImports.cshtml"
using web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\_ViewImports.cshtml"
using entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\_ViewImports.cshtml"
using web.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fb759003a39954194635246e09a6b7f33d336d", @"/Views/Shared/_AdminNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bc7e4419cc0c4e143c60eeb25ac883fa765fca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
   
    var pageAction = ViewContext.RouteData.Values["Action"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--navbar-->
<div class=""navbar"">
    <ul dropdown>
        <li>
            <a href=""/admin"">
                <span class=""fa fa-home""></span>
                <span class=""title"">
                    Işık Plastik Admin Panel
                </span>
            </a>
        </li>
     
       
    </ul>
</div>

<!--sidebar-->
<div class=""sidebar"">
   
    <ul>
        <li");
            BeginWriteAttribute("class", " class=\"", 480, "\"", 534, 1);
#nullable restore
#line 26 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 488, pageAction == "KariyerList" ? "active" : "", 488, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a href=\"/admin/kariyer\">\r\n                <span class=\"fa fa-tachometer\"></span>\r\n                <span class=\"title\">\r\n                    Kariyer\r\n                </span>\r\n            </a>\r\n        </li>\r\n\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 771, "\"", 822, 1);
#nullable restore
#line 35 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 779, pageAction == "iletisim" ? "active" : "", 779, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a href=\"/admin/iletisim\">\r\n                <span class=\"fa fa-tachometer\"></span>\r\n                <span class=\"title\">\r\n                    İletişim\r\n                </span>\r\n            </a>\r\n        </li>\r\n\r\n\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1063, "\"", 1116, 1);
#nullable restore
#line 45 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 1071, pageAction == "dokumanlar" ? "active" : "", 1071, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""#"">
                <span class=""fa fa-thumb-tack""></span>
                <span class=""title"">
                    Döküman Merkezi
                </span>
            </a>
            <ul class=""sub-menu"">
                <li class=""active"">
                    <a href=""/admin/dokuman-kategori"">
                        Döküman Kategori
                    </a>
                </li>
                <li>
                    <a href=""/admin/dokumanlar"">
                        Dökümanlar
                    </a>
                </li>
            </ul>
        </li>
        <li");
            BeginWriteAttribute("class", " class=\"", 1741, "\"", 1792, 1);
#nullable restore
#line 65 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 1749, pageAction == "Haberler" ? "active" : "", 1749, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""/admin/haberler"">
                <span class=""fa fa-thumb-tack""></span>
                <span class=""title"">
                    Haberler
                </span>
            </a>
            <ul class=""sub-menu"">
                <li class=""active"">
                    <a href=""/admin/haberler"">
                        Tüm Haberler
                    </a>
                </li>
                <li>
                    <a href=""/admin/haber-ekle"">
                        Haber Ekle
                    </a>
                </li>
            </ul>
        </li>



        <li");
            BeginWriteAttribute("class", " class=\"", 2418, "\"", 2471, 1);
#nullable restore
#line 88 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 2426, pageAction == "thermoform" ? "active" : "", 2426, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""#"">
                <span class=""fa fa-thumb-tack""></span>
                <span class=""title"">
                    Kategoriler-Ürünler
                </span>
            </a>
            <ul class=""sub-menu"">
                <li class=""active"">
                    <a href=""/admin/kategoriler"">
                        Kategoriler
                    </a>
                </li>
                <li>
                    <a href=""/admin/urunler"">
                        Ürünler
                    </a>
                </li>
            </ul>
        </li>


        <li");
            BeginWriteAttribute("class", " class=\"", 3088, "\"", 3139, 1);
#nullable restore
#line 110 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 3096, pageAction == "uygulama" ? "active" : "", 3096, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""#"">
                <span class=""fa fa-thumb-tack""></span>
                <span class=""title"">
                    Uygulamalar
                </span>
            </a>
            <ul class=""sub-menu"">
                <li class=""active"">
                    <a href=""/admin/uygulamalar"">
                        Uygulamalar
                    </a>
                </li>
            
            </ul>
        </li>

        <li");
            BeginWriteAttribute("class", " class=\"", 3609, "\"", 3657, 1);
#nullable restore
#line 127 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Shared\_AdminNav.cshtml"
WriteAttributeValue("", 3617, pageAction == "cikis" ? "active" : "", 3617, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""/account/logout"">
                <span class=""fa fa-tachometer""></span>
                <span class=""title"">
                    Çıkış
                </span>
            </a>
        </li>


        <a href=""#"" class=""collapse-menu"">
            <span class=""fa fa-arrow-circle-left""></span>
            <span class=""title"">
                Collapse menu
            </span>
        </a>




</div>

<!--content-->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
