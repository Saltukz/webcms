#pragma checksum "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047fb127acd4ddd022ace8ef53fc618b8ff7b687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Haberler_Details), @"mvc.1.0.view", @"/Views/Haberler/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047fb127acd4ddd022ace8ef53fc618b8ff7b687", @"/Views/Haberler/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bc7e4419cc0c4e143c60eeb25ac883fa765fca", @"/Views/_ViewImports.cshtml")]
    public class Views_Haberler_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BigViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
  
    var haber = Model.HaberDetailModel.New;

#line default
#line hidden
#nullable disable
            DefineSection("head", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 118, "\"", 150, 1);
#nullable restore
#line 6 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
WriteAttributeValue("", 128, haber.MetaDescription, 128, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>");
#nullable restore
#line 8 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
      Write(haber.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Işık Plastik</title>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "047fb127acd4ddd022ace8ef53fc618b8ff7b6874588", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 221, "~/images/News/", 221, 14, true);
#nullable restore
#line 12 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
AddHtmlAttributeValue("", 235, haber.ImageUrl, 235, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
AddHtmlAttributeValue("", 257, haber.Title, 257, 12, false);

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
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 13 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
Write(haber.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<p>");
#nullable restore
#line 15 "C:\Users\celou\OneDrive\Masaüstü\webcms\web\Views\Haberler\Details.cshtml"
Write(Html.Raw(haber.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BigViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
