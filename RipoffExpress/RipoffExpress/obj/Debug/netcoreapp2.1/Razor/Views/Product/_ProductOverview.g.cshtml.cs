#pragma checksum "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edc68659ee39758fdffe26c027da896d0a5ca3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__ProductOverview), @"mvc.1.0.view", @"/Views/Product/_ProductOverview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/_ProductOverview.cshtml", typeof(AspNetCore.Views_Product__ProductOverview))]
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
#line 1 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
using RipoffExpress.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edc68659ee39758fdffe26c027da896d0a5ca3b", @"/Views/Product/_ProductOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9126b1dee94129cea0ac57317aa15f9a3c707a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__ProductOverview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModelView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
  
    ViewData["Title"] = "RipOffExpress";

#line default
#line hidden
            BeginContext(121, 13, true);
            WriteLiteral("\r\n<table>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
     foreach (var product in Model)
    {
        

#line default
#line hidden
            BeginContext(188, 46, true);
            WriteLiteral("        <tr>\r\n            <td><a href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 234, "\"", 257, 1);
#line 15 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
WriteAttributeValue("", 240, product.MediaUrl, 240, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(258, 63, true);
            WriteLiteral(" alt=\"Product picture\" /></a></td>\r\n            <td><a href=\"\">");
            EndContext();
            BeginContext(322, 12, false);
#line 16 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
                      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(334, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(362, 13, false);
#line 17 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(375, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 19 "C:\Users\coenv\Desktop\Ripoff\RipoffExpress\RipoffExpress\RipoffExpress\Views\Product\_ProductOverview.cshtml"
        
    }

#line default
#line hidden
            BeginContext(414, 10, true);
            WriteLiteral("\r\n</table>");
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
