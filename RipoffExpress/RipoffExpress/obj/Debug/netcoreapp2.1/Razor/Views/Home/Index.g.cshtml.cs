#pragma checksum "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c67da7011d8ca4623abfcfcfa118337cea89da99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
using RipoffExpress.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c67da7011d8ca4623abfcfcfa118337cea89da99", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9126b1dee94129cea0ac57317aa15f9a3c707a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModelView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/LoadPartial.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(117, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(119, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2617739ad2e4396a3385f387cbb7f74", async() => {
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
            BeginContext(185, 137, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div id=\"categoryBox\" class=\"col-md-3\">\r\n        <div class=\"productCategories\" id=\"LoadCategories\" data-url=\"");
            EndContext();
            BeginContext(323, 39, false);
#line 13 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
                                                                Write(Url.Action("ProductCategories", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(362, 68, true);
            WriteLiteral("\">\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-1\"></div>\r\n");
            EndContext();
#line 18 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(462, 87, true);
            WriteLiteral("        <div id=\"productBox\" class=\"col-md-8\">\r\n            <table id=\"productTable\">\r\n");
            EndContext();
#line 22 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
            BeginContext(617, 56, true);
            WriteLiteral("                    <tr>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 673, "\"", 737, 1);
#line 25 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
WriteAttributeValue("", 680, Url.Action("Product","Product", new { Id = product.Id }), 680, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(738, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(739, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e24ac317a1d456e9bbf6227a3858ee6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 749, "~/images/uploads/product/", 749, 25, true);
#line 25 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 774, product.MediaUrl, 774, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(842, 58, true);
            WriteLiteral("</a></td>\r\n                        <td id=\"productName\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 900, "\"", 964, 1);
#line 26 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
WriteAttributeValue("", 907, Url.Action("Product","Product", new { Id = product.Id }), 907, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(965, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(967, 12, false);
#line 26 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
                                                                                                            Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(979, 46, true);
            WriteLiteral("</a></td>\r\n                        <td>&euro; ");
            EndContext();
            BeginContext(1026, 13, false);
#line 27 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
                              Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 29 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1092, 38, true);
            WriteLiteral("            </table>\r\n        </div>\r\n");
            EndContext();
#line 32 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1154, 110, true);
            WriteLiteral("        <div id=\"productBox\" class=\"col-md-8\">\r\n            <div class=\"Products\" id=\"LoadProducts\" data-url=\"");
            EndContext();
            BeginContext(1265, 40, false);
#line 36 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
                                                         Write(Url.Action("MostRecentProducts", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 42, true);
            WriteLiteral("\">\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 40 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1354, 72, true);
            WriteLiteral("</div>\r\n<script>\r\n    function ShowProducts(prop) {\r\n        var url = \"");
            EndContext();
            BeginContext(1427, 69, false);
#line 44 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\Index.cshtml"
              Write(Html.Raw(Url.Action("ProductOverview", "Home", new { id = "catId" })));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 325, true);
            WriteLiteral(@"""
        url = url.replace(""catId"", prop);
        $(""#LoadProducts"").load(url)
    }
    $(document).ready(function () {
        registerAjaxLinkLoad(""#LoadCategories"", "".productCategories"");
    })
    $(document).ready(function () {
        registerAjaxLinkLoad(""#LoadProducts"", "".Products"");
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductModelView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
