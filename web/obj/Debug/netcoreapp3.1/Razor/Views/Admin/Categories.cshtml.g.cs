#pragma checksum "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3aaf312e92602f0a2a85804cd744a9e4b23b66a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Categories), @"mvc.1.0.view", @"/Views/Admin/Categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3aaf312e92602f0a2a85804cd744a9e4b23b66a", @"/Views/Admin/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bc7e4419cc0c4e143c60eeb25ac883fa765fca", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/DeleteCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
  
    Layout = "_AdminLayout";

    var categories = Model.categories;

    var totalpages = Model.PageInfo.TotalPages();




#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-"">
    <h1>
        Kategoriler
        <a href=""/admin/kategori-ekle"">Kategori Ekle</a>
        <a href=""/admin/kategori-dil-ekle"">Kategoriye Dil Ekle</a>
    </h1>
</div>

<div class=""clear"" style=""height: 10px;""></div>

<div class=""table"">
    <table>
        <thead>
            <tr>
                <th>Kategori Adı</th>
                <th class=""hide"">Kategori Kodu</th>
                <th class=""hide"">Kategori Dili</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
             if (Model.categories.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                 foreach (var kategori in categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <a href=\"#\" class=\"title\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                           Write(kategori.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"magic-links\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3aaf312e92602f0a2a85804cd744a9e4b23b66a6231", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"categoryid\"");
                BeginWriteAttribute("value", " value=\"", 1225, "\"", 1253, 1);
#nullable restore
#line 45 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
WriteAttributeValue("", 1233, kategori.CategoryId, 1233, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
                WriteLiteral("                                    <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1386, "\"", 1536, 14);
                WriteAttributeValue("", 1396, "return", 1396, 6, true);
                WriteAttributeValue(" ", 1402, "confirm(\'", 1403, 10, true);
#nullable restore
#line 48 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
WriteAttributeValue("", 1412, kategori.Title, 1412, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1427, "başlıklı", 1428, 9, true);
                WriteAttributeValue(" ", 1436, "kategoriyi", 1437, 11, true);
                WriteAttributeValue(" ", 1447, "silmek", 1448, 7, true);
                WriteAttributeValue(" ", 1454, "istediğinize", 1455, 13, true);
                WriteAttributeValue(" ", 1467, "emin", 1468, 5, true);
                WriteAttributeValue(" ", 1472, "misiniz?", 1473, 9, true);
                WriteAttributeValue(" ", 1481, "Bununla", 1482, 8, true);
                WriteAttributeValue(" ", 1489, "birlikte", 1490, 9, true);
                WriteAttributeValue(" ", 1498, "içindeki", 1499, 9, true);
                WriteAttributeValue(" ", 1507, "dokumanlarda", 1508, 13, true);
                WriteAttributeValue(" ", 1520, "silinecektir.\')", 1521, 16, true);
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
            BeginWriteAttribute("href", " href=\"", 1728, "\"", 1774, 2);
            WriteAttributeValue("", 1735, "/admin/kategoriler/", 1735, 19, true);
#nullable restore
#line 50 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
WriteAttributeValue("", 1754, kategori.CategoryId, 1754, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            <a href=\"#\">");
#nullable restore
#line 54 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                                   Write(kategori.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td class=\"hide\">\r\n                            <a href=\"#\">");
#nullable restore
#line 57 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                                   Write(kategori.Culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert\">\r\n                    <h3>Kategori bulunamadı</h3>\r\n                </div>\r\n");
#nullable restore
#line 67 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 76 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
         for (int i = 0; i < totalpages; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2505, "\"", 2569, 2);
            WriteAttributeValue("", 2513, "page-item", 2513, 9, true);
#nullable restore
#line 79 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
WriteAttributeValue(" ", 2522, Model.PageInfo.CurrentPage==i+1?"active":"", 2523, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 2573, "\"", 2610, 2);
            WriteAttributeValue("", 2580, "/admin/kategoriler?page=", 2580, 24, true);
#nullable restore
#line 79 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
WriteAttributeValue("", 2604, i+1, 2604, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"
                                                                                                                      Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 80 "C:\Users\User\Desktop\dotnetcms\dotnetcms\web\Views\Admin\Categories.cshtml"





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591