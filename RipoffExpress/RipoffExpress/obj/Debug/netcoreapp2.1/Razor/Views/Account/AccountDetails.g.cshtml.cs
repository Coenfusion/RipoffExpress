#pragma checksum "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e03d602899a3a0d6b783d7c3caf182a2e73a194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccountDetails), @"mvc.1.0.view", @"/Views/Account/AccountDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/AccountDetails.cshtml", typeof(AspNetCore.Views_Account_AccountDetails))]
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
#line 1 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\_ViewImports.cshtml"
using RipoffExpress;

#line default
#line hidden
#line 2 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\_ViewImports.cshtml"
using RipoffExpress.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e03d602899a3a0d6b783d7c3caf182a2e73a194", @"/Views/Account/AccountDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9126b1dee94129cea0ac57317aa15f9a3c707a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccountDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RipoffExpress.Models.AccountModels.AccountDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/LoadPartial.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
  
    ViewData["Title"] = "Account details";

#line default
#line hidden
            BeginContext(111, 148, true);
            WriteLiteral("\r\n\r\n<div class=\"jumbotron vertical-center\">\r\n    <div class=\"container text-center\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\"> ");
            EndContext();
            BeginContext(260, 24, false);
#line 11 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
                              Write(ViewData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(284, 115, true);
            WriteLiteral(" </div>\r\n            <div class=\"col-md-8\">\r\n                <section>\r\n                    <h3>Account Details of ");
            EndContext();
            BeginContext(400, 26, false);
#line 14 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
                                      Write(ViewData["SessionMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(426, 701, true);
            WriteLiteral(@" </h3>
                </section>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <section>
                    <ul>
                        <li><a id=""LoadOverview"">Overview</a></li>
                        <li><a id=""LoadChanges"">Change Details</a></li>
                        <li><a id=""LoadOrderHistory"">Order History</a></li>
                        <li><a id=""LoadAddressBook"">Shipping Address</a></li>
                    </ul>
                </section>
            </div>
            <div class=""col-md-8"">
                <div id=""LoadPartials""></div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(1127, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165e57253536459da3a8dd8694de70cf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1193, 89, true);
            WriteLiteral("\r\n<script>\r\n    $(\'#LoadOverview\').on(\'click\', () => {\r\n        $(\"#LoadPartials\").load(\"");
            EndContext();
            BeginContext(1283, 50, false);
#line 39 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
                            Write(Html.Raw(Url.Action("AccountOverview", "Account")));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 96, true);
            WriteLiteral(" \")\r\n    });\r\n    \r\n    $(\'#LoadChanges\').on(\'click\', () => {\r\n        $(\"#LoadPartials\").load(\"");
            EndContext();
            BeginContext(1430, 49, false);
#line 43 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
                            Write(Html.Raw(Url.Action("AccountChanges", "Account")));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 97, true);
            WriteLiteral(" \")\r\n    });\r\n\r\n    $(\'#LoadOrderHistory\').on(\'click\', () => {\r\n        $(\"#LoadPartials\").load(\"");
            EndContext();
            BeginContext(1577, 48, false);
#line 47 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
                            Write(Html.Raw(Url.Action("AccountOrders", "Account")));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 96, true);
            WriteLiteral(" \")\r\n    });\r\n\r\n    $(\'#LoadAddressBook\').on(\'click\', () => {\r\n        $(\"#LoadPartials\").load(\"");
            EndContext();
            BeginContext(1722, 53, false);
#line 51 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Account\AccountDetails.cshtml"
                            Write(Html.Raw(Url.Action("AccountAddressBook", "Account")));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 23, true);
            WriteLiteral(" \")\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RipoffExpress.Models.AccountModels.AccountDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
