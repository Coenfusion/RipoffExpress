#pragma checksum "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e59eac2444e6a99aae745227adf1d8975f9ec2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Store), @"mvc.1.0.view", @"/Views/Store/Store.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Store.cshtml", typeof(AspNetCore.Views_Store_Store))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 2 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\_ViewImports.cshtml"
using RipoffExpress;

#line default
#line hidden
#line 1 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
using RipoffExpress.Models;

#line default
#line hidden
#line 3 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e59eac2444e6a99aae745227adf1d8975f9ec2e", @"/Views/Store/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9126b1dee94129cea0ac57317aa15f9a3c707a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreViewModel>
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
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
  
    ViewData["Title"] = "Store";

#line default
#line hidden
            BeginContext(167, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(169, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af653e4d2bde48caacc0af34ee579afa", async() => {
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
            BeginContext(235, 33, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center;\">");
            EndContext();
            BeginContext(269, 10, false);
#line 12 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(279, 515, true);
            WriteLiteral(@"</h2>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""StoreNavigation"">
            <table>
                <tr>
                    <td>
                        Home
                    </td>
                    <td>
                        Best selling
                    </td>
                    <td>
                        New Arrivals
                    </td>
                    <td>
                        Feedback
                    </td>
                    <td>
");
            EndContext();
#line 31 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
                          
                            if (Context.Session.GetInt32("UserId") == Model.Account.Id)
                            {

#line default
#line hidden
            BeginContext(942, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 976, "\"", 1063, 1);
#line 34 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
WriteAttributeValue("", 983, Url.Action("StoreProductManagement","Store", new { userId = Model.Account.Id }), 983, 80, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1064, 22, true);
            WriteLiteral(">Manage Products</a>\r\n");
            EndContext();
#line 35 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1144, 250, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\" style=\"margin-top:100px;\">\r\n        <div class=\"StoreCategories\" id=\"LoadCategories\" data-url=\"");
            EndContext();
            BeginContext(1395, 38, false);
#line 46 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
                                                              Write(Url.Action("StoreCategories", "Store"));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 94, true);
            WriteLiteral(" \">\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"StoreProducts\" id=\"LoadProducts\" data-url=\"");
            EndContext();
            BeginContext(1528, 36, false);
#line 50 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Store\Store.cshtml"
                                                      Write(Url.Action("StoreProducts", "Store"));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 273, true);
            WriteLiteral(@""">

    </div>
</div>

<script>
    $(document).ready(function () {
        registerAjaxLinkLoad(""#LoadCategories"", "".StoreCategories"");
    })
    $(document).ready(function () {
        registerAjaxLinkLoad(""#LoadProducts"", "".StoreProducts"");
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
