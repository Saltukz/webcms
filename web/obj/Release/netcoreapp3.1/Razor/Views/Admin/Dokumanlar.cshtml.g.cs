#pragma checksum "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8588ab152f88c1a74312b58cf998e31f600b1e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dokumanlar), @"mvc.1.0.view", @"/Views/Admin/Dokumanlar.cshtml")]
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
#line 2 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\_ViewImports.cshtml"
using IsikPlastik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\_ViewImports.cshtml"
using IsikPlastik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\_ViewImports.cshtml"
using isik.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\_ViewImports.cshtml"
using IsikPlastik.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8588ab152f88c1a74312b58cf998e31f600b1e8f", @"/Views/Admin/Dokumanlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a75b78060fa44535fc9a713ac8df25f5bec3aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Dokumanlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DokumanModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletedokuman"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
  
    Layout = "_AdminLayout";

    var dokumanlar = Model.dokumanlar;

    var totalpages = Model.PageInfo.TotalPages();



#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-"">
    <h1>
        Dökümanlar
        <a href=""/admin/dokuman-ekle"">Döküman Ekle</a>
        <a href=""/admin/dokuman-dil-ekle"">Döküman Dil Ekle</a>
    </h1>
</div>

<div class=""clear"" style=""height: 10px;""></div>

<div class=""table"">
    <table>
        <thead>
            <tr>
                <th>Döküman Adı</th>
                <th class=""hide"">Döküman Kodu</th>
                <th class=""hide"">Döküman Dili</th>
                <th class=""hide"">Döküman Url</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
             if (Model.dokumanlar.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                 foreach (var dokuman in dokumanlar)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a href=\"#\" class=\"title\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                   Write(dokuman.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"magic-links\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8588ab152f88c1a74312b58cf998e31f600b1e8f6402", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1187, "\"", 1213, 1);
#nullable restore
#line 45 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
WriteAttributeValue("", 1195, dokuman.DokumanId, 1195, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            \r\n");
                WriteLiteral("                            <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1358, "\"", 1506, 14);
                WriteAttributeValue("", 1368, "return", 1368, 6, true);
                WriteAttributeValue(" ", 1374, "confirm(\'", 1375, 10, true);
#nullable restore
#line 48 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
WriteAttributeValue("", 1384, dokuman.Name, 1384, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1397, "başlıklı", 1398, 9, true);
                WriteAttributeValue(" ", 1406, "kategoriyi", 1407, 11, true);
                WriteAttributeValue(" ", 1417, "silmek", 1418, 7, true);
                WriteAttributeValue(" ", 1424, "istediğinize", 1425, 13, true);
                WriteAttributeValue(" ", 1437, "emin", 1438, 5, true);
                WriteAttributeValue(" ", 1442, "misiniz?", 1443, 9, true);
                WriteAttributeValue(" ", 1451, "Bununla", 1452, 8, true);
                WriteAttributeValue(" ", 1459, "birlikte", 1460, 9, true);
                WriteAttributeValue(" ", 1468, "içindeki", 1469, 9, true);
                WriteAttributeValue(" ", 1477, "dokumanlarda", 1478, 13, true);
                WriteAttributeValue(" ", 1490, "silinecektir.\')", 1491, 16, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                     \r\n                    </div>\r\n                </td>\r\n                <td class=\"hide\">\r\n                    <a href=\"#\">");
#nullable restore
#line 54 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                           Write(dokuman.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td class=\"hide\">\r\n                    <a href=\"#\">");
#nullable restore
#line 57 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                           Write(dokuman.Culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td class=\"hide\">\r\n                    <a href=\"#\">");
#nullable restore
#line 60 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                           Write(dokuman.DokumanUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert\">\r\n                    <h3>Kategori bulunamadı</h3>\r\n                </div>\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 79 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
         for (int i = 0; i < totalpages; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2381, "\"", 2445, 2);
            WriteAttributeValue("", 2389, "page-item", 2389, 9, true);
#nullable restore
#line 82 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
WriteAttributeValue(" ", 2398, Model.PageInfo.CurrentPage==i+1?"active":"", 2399, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 2449, "\"", 2485, 2);
            WriteAttributeValue("", 2456, "/admin/dokumanlar?page=", 2456, 23, true);
#nullable restore
#line 82 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
WriteAttributeValue("", 2479, i+1, 2479, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"
                                                                                                                     Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 83 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Dokumanlar.cshtml"





        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DokumanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
