#pragma checksum "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281d11294de50dfa224986f315d609678df54404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
using Google.Apis.AnalyticsReporting.v4.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281d11294de50dfa224986f315d609678df54404", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a75b78060fa44535fc9a713ac8df25f5bec3aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnalyticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("adminhead", async() => {
                WriteLiteral(@"

    <title>Admin Anasayfa | I????k Plastik</title>


    <style>

        #divAnalytics {
            display: grid;
            grid-template-columns: 100px auto 100px 100px;
            grid-gap: 8px;
        }



            #divAnalytics div:nth-child(-n+4) {
                font-weight: bold;
            }
    </style>

");
            }
            );
            WriteLiteral("<div id=\"divAnalytics\">\r\n\r\n    <div>pagePath</div>\r\n\r\n    <div>pageTitle</div>\r\n\r\n    <div>pageViews</div>\r\n\r\n    <div>users</div>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
     foreach (ReportRow row in Model.AnalyticsRecords)

    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
         foreach (string dimension in row.Dimensions)

        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 46 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
            Write(dimension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
         foreach (var metric in row.Metrics[0].Values) // row.Metrics is a list of DateRangeValuess (double 'ss' is intentional), however we only have 1 DateRangeValues so we just use row.Metrics[0].
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 55 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
            Write(metric);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\User\Desktop\isiknet2son\isik.net yedek 2\IsikPlastik\Views\Admin\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnalyticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
