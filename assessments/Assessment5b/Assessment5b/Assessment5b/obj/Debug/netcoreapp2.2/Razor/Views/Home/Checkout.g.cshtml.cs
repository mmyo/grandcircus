#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc4743ce6f3ad93695f462a6bfb8df8282cde1e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Checkout.cshtml", typeof(AspNetCore.Views_Home_Checkout))]
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\_ViewImports.cshtml"
using Assessment5b;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\_ViewImports.cshtml"
using Assessment5b.Models;

#line default
#line hidden
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Checkout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4743ce6f3ad93695f462a6bfb8df8282cde1e7", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3933ee428082eb9a9207a83583e76cc877803508", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
            BeginContext(156, 42, true);
            WriteLiteral("\r\n<h1>Checkout</h1>\r\n\r\n<h1>Item quantity: ");
            EndContext();
            BeginContext(199, 60, false);
#line 10 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Checkout.cshtml"
              Write(HttpContextAccessor.HttpContext.Session.GetInt32("quantity"));

#line default
#line hidden
            EndContext();
            BeginContext(259, 64, true);
            WriteLiteral("</h1>\r\n\r\n<button class=\"btn btn-primary\" type=\"button\" id=\"home\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n        onclick=\"", 323, "\"", 386, 3);
            WriteAttributeValue("", 342, "location.href=\'", 342, 15, true);
#line 13 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 357, Url.Action("Index", "Home"), 357, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 385, "\'", 385, 1, true);
            EndWriteAttribute();
            BeginContext(387, 90, true);
            WriteLiteral(">Continue Shopping</button>\r\n\r\n<button class=\"btn btn-danger\" type=\"button\" id=\"emptyCart\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n        onclick=\"", 477, "\"", 544, 3);
            WriteAttributeValue("", 496, "location.href=\'", 496, 15, true);
#line 16 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 511, Url.Action("EmptyCart", "Home"), 511, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 543, "\'", 543, 1, true);
            EndWriteAttribute();
            BeginContext(545, 20, true);
            WriteLiteral(">Empty Cart</button>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
