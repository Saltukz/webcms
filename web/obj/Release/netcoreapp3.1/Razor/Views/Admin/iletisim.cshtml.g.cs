#pragma checksum "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f5a4677a5b8295720debe62d34ab3e7b643db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_iletisim), @"mvc.1.0.view", @"/Views/Admin/iletisim.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f5a4677a5b8295720debe62d34ab3e7b643db0", @"/Views/Admin/iletisim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a75b78060fa44535fc9a713ac8df25f5bec3aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormModelContact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
  
    Layout = "_AdminLayout";

    var basvurular = Model.Contacts;

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

                <th>
                    <span class=""fa fa-comment"">Mesaj</span>
                </th>

                <th>
                    <span class=""fa fa-comment"">Kampanya</span>
                </th>
                <th>Date</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 37 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
             if (Model.Contacts.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                 foreach (var basvuru in basvurular)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a href=\"#\" class=\"title\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                   Write(basvuru.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"magic-links\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1136, "\"", 1143, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"trash\">Sil</a> | <a");
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1208, 2);
            WriteAttributeValue("", 1178, "/admin/KariyerList/", 1178, 19, true);
#nullable restore
#line 47 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
WriteAttributeValue("", 1197, basvuru.Id, 1197, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">İncele</a>\r\n                    </div>\r\n                </td>\r\n                <td class=\"hide\">\r\n                    <a href=\"#\">");
#nullable restore
#line 51 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                           Write(basvuru.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td class=\"hide\">\r\n                    <a href=\"#\">");
#nullable restore
#line 54 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                           Write(basvuru.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
               Write(basvuru.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"hide\">\r\n");
#nullable restore
#line 61 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                     if (@basvuru.Kampanya == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 64 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 68 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n                </td>\r\n                <td>\r\n                    <span class=\"date\">");
#nullable restore
#line 72 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                                  Write(basvuru.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert\">\r\n                    <h3>Başvuru bulunamadı</h3>\r\n                </div>\r\n");
#nullable restore
#line 82 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 91 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
         for (int i = 0; i < totalpages; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2447, "\"", 2511, 2);
            WriteAttributeValue("", 2455, "page-item", 2455, 9, true);
#nullable restore
#line 94 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
WriteAttributeValue(" ", 2464, Model.PageInfo.CurrentPage==i+1?"active":"", 2465, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 2515, "\"", 2548, 2);
            WriteAttributeValue("", 2522, "/admin/kariyer?page=", 2522, 20, true);
#nullable restore
#line 94 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
WriteAttributeValue("", 2542, i+1, 2542, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"
                                                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 95 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\iletisim.cshtml"





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormModelContact> Html { get; private set; }
    }
}
#pragma warning restore 1591
