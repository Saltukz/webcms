#pragma checksum "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c5b267903da6116b30846bb7162488ac0ab8fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Uygulamalar), @"mvc.1.0.view", @"/Views/Admin/Uygulamalar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c5b267903da6116b30846bb7162488ac0ab8fb", @"/Views/Admin/Uygulamalar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bc7e4419cc0c4e143c60eeb25ac883fa765fca", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Uygulamalar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UygulamalarBigModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/DeleteUygulama"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
  
    Layout = "_AdminLayout";

    var uygulamalarListe = Model.uygulamalarList;

    var totalpages = Model.PageInfo.TotalPages();




#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-"">
    <h1>
        Uygulamalar
        <a href=""/admin/uygulama-ekle"">Uygulama Ekle</a>
        <a href=""/admin/uygulama-dil-ekle"">Uygulama Dil Ekle</a>
    </h1>
</div>

<div class=""clear"" style=""height: 10px;""></div>

<div class=""table"">
    <table>
        <thead>
            <tr>
                <th>Uygulama Adı</th>
                <th class=""hide"">Uygulama Kodu</th>
                <th class=""hide"">Uygulama Dili</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
             if (Model.uygulamalarList.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                 foreach (var uygulama in uygulamalarListe)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <a href=\"#\" class=\"title\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                           Write(uygulama.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"magic-links\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61c5b267903da6116b30846bb7162488ac0ab8fb6245", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1242, "\"", 1262, 1);
#nullable restore
#line 45 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
WriteAttributeValue("", 1250, uygulama.Id, 1250, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
                WriteLiteral("                                    <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1395, "\"", 1544, 14);
                WriteAttributeValue("", 1405, "return", 1405, 6, true);
                WriteAttributeValue(" ", 1411, "confirm(\'", 1412, 10, true);
#nullable restore
#line 48 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
WriteAttributeValue("", 1421, uygulama.Name, 1421, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1435, "başlıklı", 1436, 9, true);
                WriteAttributeValue(" ", 1444, "kategoriyi", 1445, 11, true);
                WriteAttributeValue(" ", 1455, "silmek", 1456, 7, true);
                WriteAttributeValue(" ", 1462, "istediğinize", 1463, 13, true);
                WriteAttributeValue(" ", 1475, "emin", 1476, 5, true);
                WriteAttributeValue(" ", 1480, "misiniz?", 1481, 9, true);
                WriteAttributeValue(" ", 1489, "Bununla", 1490, 8, true);
                WriteAttributeValue(" ", 1497, "birlikte", 1498, 9, true);
                WriteAttributeValue(" ", 1506, "içindeki", 1507, 9, true);
                WriteAttributeValue(" ", 1515, "dokumanlarda", 1516, 13, true);
                WriteAttributeValue(" ", 1528, "silinecektir.\')", 1529, 16, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\r\n                                ");
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
            WriteLiteral("\r\n                                <a style=\"margin-top:2px;\" class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1736, "\"", 1774, 2);
            WriteAttributeValue("", 1743, "/admin/uygulamalar/", 1743, 19, true);
#nullable restore
#line 50 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
WriteAttributeValue("", 1762, uygulama.Id, 1762, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            <a href=\"#\">");
#nullable restore
#line 54 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                                   Write(uygulama.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            <a href=\"#\">");
#nullable restore
#line 57 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                                   Write(uygulama.Culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert\">\r\n                    <h3>Uygulama bulunamadı.</h3>\r\n                </div>\r\n");
#nullable restore
#line 67 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 76 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
         for (int i = 0; i < totalpages; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2506, "\"", 2570, 2);
            WriteAttributeValue("", 2514, "page-item", 2514, 9, true);
#nullable restore
#line 79 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
WriteAttributeValue(" ", 2523, Model.PageInfo.CurrentPage==i+1?"active":"", 2524, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 2574, "\"", 2620, 2);
            WriteAttributeValue("", 2581, "/admin/uygulamalar-kategori?page=", 2581, 33, true);
#nullable restore
#line 79 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
WriteAttributeValue("", 2614, i+1, 2614, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"
                                                                                                                               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 80 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Admin\Uygulamalar.cshtml"





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UygulamalarBigModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
