#pragma checksum "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\BigSlider\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3084f21be019cfcd2eeb80db1c168a397bb61f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Indecor_Views_BigSlider_Detail), @"mvc.1.0.view", @"/Areas/Indecor/Views/BigSlider/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Indecor/Views/BigSlider/Detail.cshtml", typeof(AspNetCore.Areas_Indecor_Views_BigSlider_Detail))]
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
#line 1 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\_ViewImports.cshtml"
using Indecor.Models;

#line default
#line hidden
#line 2 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\_ViewImports.cshtml"
using Indecor.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3084f21be019cfcd2eeb80db1c168a397bb61f39", @"/Areas/Indecor/Views/BigSlider/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd88756579251d584dfa034420c37e9f59e14fcb", @"/Areas/Indecor/Views/_ViewImports.cshtml")]
    public class Areas_Indecor_Views_BigSlider_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BigSlider>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("350px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\BigSlider\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 126, true);
            WriteLiteral("\r\n<h2>Detail</h2>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h3>Title: ");
            EndContext();
            BeginContext(187, 11, false);
#line 10 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\BigSlider\Detail.cshtml"
                  Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(198, 35, true);
            WriteLiteral("</h3>\r\n            <p>Description: ");
            EndContext();
            BeginContext(234, 17, false);
#line 11 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\BigSlider\Detail.cshtml"
                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(251, 26, true);
            WriteLiteral("</p>\r\n            <p>  <a>");
            EndContext();
            BeginContext(278, 10, false);
#line 12 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\BigSlider\Detail.cshtml"
               Write(Model.Link);

#line default
#line hidden
            EndContext();
            BeginContext(288, 67, true);
            WriteLiteral("</a> : This is Link which you want! </p>\r\n           \r\n            ");
            EndContext();
            BeginContext(355, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56befa64a9ef48c296fd9643f3f87bb1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 365, "~/img/", 365, 6, true);
#line 14 "C:\Users\Code\source\repos\Indecor\Indecor\Indecor\Areas\Indecor\Views\BigSlider\Detail.cshtml"
AddHtmlAttributeValue("", 371, Model.Image, 371, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(400, 91, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n          <div class=\"col-12\">\r\n              ");
            EndContext();
            BeginContext(491, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7979c2851cff49279c81deddec334ba5", async() => {
                BeginContext(513, 43, true);
                WriteLiteral(" <i class=\"fas fa-arrow-left\"></i> Go Back ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(560, 48, true);
            WriteLiteral("\r\n</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BigSlider> Html { get; private set; }
    }
}
#pragma warning restore 1591
