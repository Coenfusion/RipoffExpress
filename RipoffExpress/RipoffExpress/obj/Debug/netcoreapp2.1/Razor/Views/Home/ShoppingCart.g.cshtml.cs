#pragma checksum "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "030ada6bd44f19806c6985b497b24b812a838bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShoppingCart), @"mvc.1.0.view", @"/Views/Home/ShoppingCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShoppingCart.cshtml", typeof(AspNetCore.Views_Home_ShoppingCart))]
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
#line 1 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\_ViewImports.cshtml"
using RipoffExpress;

#line default
#line hidden
#line 1 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
using RipoffExpress.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"030ada6bd44f19806c6985b497b24b812a838bb7", @"/Views/Home/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9126b1dee94129cea0ac57317aa15f9a3c707a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
  
    ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
            BeginContext(113, 68, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        <table>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
             foreach (ProductModelView product in Model.order.OrderItems)
            {


#line default
#line hidden
            BeginContext(273, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 337, "\"", 360, 1);
#line 18 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
WriteAttributeValue("", 343, product.MediaUrl, 343, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(361, 89, true);
            WriteLiteral(" alt=\"ProductImage\" />\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(451, 12, false);
#line 21 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(463, 74, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    &euro; ");
            EndContext();
            BeginContext(538, 13, false);
#line 24 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
                      Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(551, 93, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 644, "\"", 756, 1);
#line 27 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
WriteAttributeValue("", 651, Url.Action("RemoveProductFromOrder", "Order" , new { productId = product.Id, orderId = Model.order.Id }), 651, 105, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(757, 55, true);
            WriteLiteral(">Remove</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"

            }

#line default
#line hidden
            BeginContext(829, 289, true);
            WriteLiteral(@"
            <!--button to remove products, possibly up amount of products  and link to product-->
        </table>
    </div>
    <div class=""col-md-5"">
        <table>
            <thead>Default Shipping Address</thead>
            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(1119, 37, false);
#line 41 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
               Write(Model.account.ShippingAddress.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1261, 40, false);
#line 46 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
               Write(Model.account.ShippingAddress.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(1301, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1304, 34, false);
#line 46 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
                                                          Write(Model.account.ShippingAddress.City);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1443, 38, false);
#line 51 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
               Write(Model.account.ShippingAddress.Province);

#line default
#line hidden
            EndContext();
            BeginContext(1481, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1484, 37, false);
#line 51 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
                                                        Write(Model.account.ShippingAddress.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1626, 41, false);
#line 56 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Home\ShoppingCart.cshtml"
               Write(Model.account.ShippingAddress.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 154, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <!-- button to switch address, total price and button to pay.-->\r\n    </div>\r\n</div>");
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
