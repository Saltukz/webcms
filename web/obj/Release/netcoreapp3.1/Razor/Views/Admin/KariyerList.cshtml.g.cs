#pragma checksum "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a532d8d441540af375d15727ec06186ef97483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_KariyerList), @"mvc.1.0.view", @"/Views/Admin/KariyerList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a532d8d441540af375d15727ec06186ef97483", @"/Views/Admin/KariyerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a75b78060fa44535fc9a713ac8df25f5bec3aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_KariyerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KariyerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteCv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
  
    Layout = "_AdminLayout";

    var basvurular = Model.Kariyers;

    var totalpages = Model.PageInfo.TotalPages();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-"">
    <h1>
        Başvurular
    </h1>
</div>

<div class=""clear"" style=""height: 10px;""></div>

<div class=""table"">
    <table>
        <thead>
            <tr>
                <th>İsim</th>
                <th class=""hide"">E-Mail</th>
                <th class=""hide"">Telefon</th>
                <th class=""hide"">Cv</th>
                <th>
                    <span class=""fa fa-comment"">Mesaj</span>
                </th>
                <th>Date</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 33 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
             if (Model.Kariyers.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                 foreach (var basvuru in basvurular)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <a href=\"#\" class=\"title\">\r\n                                ");
#nullable restore
#line 40 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                           Write(basvuru.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"magic-links\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3a532d8d441540af375d15727ec06186ef974836955", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1225, "\"", 1251, 1);
#nullable restore
#line 44 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
WriteAttributeValue("", 1233, basvuru.KariyerId, 1233, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
                WriteLiteral("                                    <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1384, "\"", 1469, 9);
                WriteAttributeValue("", 1394, "return", 1394, 6, true);
                WriteAttributeValue(" ", 1400, "confirm(\'", 1401, 10, true);
#nullable restore
#line 47 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
WriteAttributeValue("", 1410, basvuru.Ad, 1410, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1421, "isimli", 1422, 7, true);
                WriteAttributeValue(" ", 1428, "cvyi", 1429, 5, true);
                WriteAttributeValue(" ", 1433, "silmek", 1434, 7, true);
                WriteAttributeValue(" ", 1440, "istediğinize", 1441, 13, true);
                WriteAttributeValue(" ", 1453, "emin", 1454, 5, true);
                WriteAttributeValue(" ", 1458, "misiniz?\')", 1459, 11, true);
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
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            <a href=\"#\">");
#nullable restore
#line 53 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                                   Write(basvuru.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            <a href=\"#\">");
#nullable restore
#line 56 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                                   Write(basvuru.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3a532d8d441540af375d15727ec06186ef9748311066", async() => {
                WriteLiteral("Cv Gör");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2013, "~/Cvler/", 2013, 8, true);
#nullable restore
#line 59 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
AddHtmlAttributeValue("", 2021, basvuru.CvUrl, 2021, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                       Write(basvuru.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <span class=\"date\">");
#nullable restore
#line 65 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                                          Write(basvuru.BasvuruTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert\">\r\n                    <h3>Başvuru bulunamadı</h3>\r\n                </div>\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 84 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
         for (int i = 0; i < totalpages; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2702, "\"", 2766, 2);
            WriteAttributeValue("", 2710, "page-item", 2710, 9, true);
#nullable restore
#line 87 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
WriteAttributeValue(" ", 2719, Model.PageInfo.CurrentPage==i+1?"active":"", 2720, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 2770, "\"", 2803, 2);
            WriteAttributeValue("", 2777, "/admin/kariyer?page=", 2777, 20, true);
#nullable restore
#line 87 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
WriteAttributeValue("", 2797, i+1, 2797, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"
                                                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 88 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\KariyerList.cshtml"





        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KariyerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
