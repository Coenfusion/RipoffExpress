#pragma checksum "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb52ac2959a1cd54f85fc81c9de27f9a8ff28061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart__ShoppingCartAddressBook), @"mvc.1.0.view", @"/Views/ShoppingCart/_ShoppingCartAddressBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/_ShoppingCartAddressBook.cshtml", typeof(AspNetCore.Views_ShoppingCart__ShoppingCartAddressBook))]
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
#line 1 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
using RipoffExpress.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb52ac2959a1cd54f85fc81c9de27f9a8ff28061", @"/Views/ShoppingCart/_ShoppingCartAddressBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9126b1dee94129cea0ac57317aa15f9a3c707a9", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart__ShoppingCartAddressBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
   ShippingAddress s = Model.Account.AddressBook.FirstOrDefault(x => x.Default == true); 

#line default
#line hidden
            BeginContext(156, 31, true);
            WriteLiteral("\r\n<select id=\"addressId\">\r\n    ");
            EndContext();
            BeginContext(187, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1a9ee1b649645dcb93584d0482eb52c", async() => {
                BeginContext(230, 9, false);
#line 8 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                         Write(s.Address);

#line default
#line hidden
                EndContext();
                BeginContext(239, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(242, 12, false);
#line 8 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                                     Write(s.PostalCode);

#line default
#line hidden
                EndContext();
                BeginContext(254, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(257, 6, false);
#line 8 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                                                    Write(s.City);

#line default
#line hidden
                EndContext();
                BeginContext(263, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(266, 9, false);
#line 8 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                                                             Write(s.Country);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 8 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                           WriteLiteral(s.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(284, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
     foreach (ShippingAddress sa in Model.Account.AddressBook.Where(x => x.Default == false))
    {

#line default
#line hidden
            BeginContext(388, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(396, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4012e6da876f40fd859d311f770d9662", async() => {
                BeginContext(420, 10, false);
#line 11 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                          Write(sa.Address);

#line default
#line hidden
                EndContext();
                BeginContext(430, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(433, 13, false);
#line 11 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                       Write(sa.PostalCode);

#line default
#line hidden
                EndContext();
                BeginContext(446, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(449, 7, false);
#line 11 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                                       Write(sa.City);

#line default
#line hidden
                EndContext();
                BeginContext(456, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(459, 10, false);
#line 11 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
                                                                 Write(sa.Country);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
           WriteLiteral(sa.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(478, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
    }

#line default
#line hidden
            BeginContext(487, 37, true);
            WriteLiteral("</select>\r\n<a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 524, "\"", 606, 1);
#line 14 "C:\Users\gebruiker\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\ShoppingCart\_ShoppingCartAddressBook.cshtml"
WriteAttributeValue("", 531, Url.Action("OrderFinalization","Order", new { orderId = @Model.Order.Id }), 531, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 16, true);
            WriteLiteral(">Check Out</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
