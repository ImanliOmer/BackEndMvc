#pragma checksum "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\Shared\Components\Features\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9760d45155d6228aa784e30acfd3db27591086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Features_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Features/Default.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\_ViewImports.cshtml"
using AllupBackendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\_ViewImports.cshtml"
using AllupBackendProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9760d45155d6228aa784e30acfd3db27591086", @"/Views/Shared/Components/Features/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d87adf098acc6f4ebc559cff82bcd88f36aa1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Features_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Feature>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("   \n\n <section class=\"features-banner-area pt-80 pb-100\">\n        <div class=\"container-fluid custom-container\">\n            <div class=\"features-banner-wrapper d-flex flex-wrap\">\n");
#nullable restore
#line 7 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\Shared\Components\Features\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-features-banner d-flex\">\n                        <div class=\"banner-icon\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f9760d45155d6228aa784e30acfd3db275910864511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/banner-icon/", 423, 14, true);
#nullable restore
#line 11 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\Shared\Components\Features\Default.cshtml"
AddHtmlAttributeValue("", 437, item.ImageUrl, 437, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                        <div class=\"banner-content media-body\">\n                            <h3 class=\"banner-title\">");
#nullable restore
#line 14 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\Shared\Components\Features\Default.cshtml"
                                                Write(item.BannerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 15 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\Shared\Components\Features\Default.cshtml"
                          Write(item.BannerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div> <!-- single features banner -->\n");
#nullable restore
#line 18 "C:\Users\asus\Desktop\AllupBackendProject-main\AllupBackendProject\Views\Shared\Components\Features\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div> <!-- features banner wrapper -->\n        </div> <!-- container -->\n    </section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
