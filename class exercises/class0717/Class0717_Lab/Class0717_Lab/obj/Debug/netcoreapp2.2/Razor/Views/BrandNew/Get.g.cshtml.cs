#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\BrandNew\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561331aa336bb5927ddc9fb9e72e71a7c09972f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BrandNew_Get), @"mvc.1.0.view", @"/Views/BrandNew/Get.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BrandNew/Get.cshtml", typeof(AspNetCore.Views_BrandNew_Get))]
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\_ViewImports.cshtml"
using Class0717_Lab;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\_ViewImports.cshtml"
using Class0717_Lab.Models;

#line default
#line hidden
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\BrandNew\Get.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"561331aa336bb5927ddc9fb9e72e71a7c09972f5", @"/Views/BrandNew/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6ef779ab746351b55280882bad45dcd71b3643", @"/Views/_ViewImports.cshtml")]
    public class Views_BrandNew_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\BrandNew\Get.cshtml"
  
    ViewData["Title"] = "Get";

#line default
#line hidden
            BeginContext(151, 31, true);
            WriteLiteral("\r\n<h1>Get</h1>\r\n\r\n<p>ViewData: ");
            EndContext();
            BeginContext(183, 31, false);
#line 10 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\BrandNew\Get.cshtml"
        Write(ViewData["DateTimeNowViewData"]);

#line default
#line hidden
            EndContext();
            BeginContext(214, 20, true);
            WriteLiteral(" </p>\r\n<p>TempData: ");
            EndContext();
            BeginContext(235, 31, false);
#line 11 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\BrandNew\Get.cshtml"
        Write(TempData["DateTimeNowTempData"]);

#line default
#line hidden
            EndContext();
            BeginContext(266, 19, true);
            WriteLiteral(" </p>\r\n<p>Session: ");
            EndContext();
            BeginContext(286, 71, false);
#line 12 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0717\Class0717_Lab\Class0717_Lab\Views\BrandNew\Get.cshtml"
       Write(HttpContextAccessor.HttpContext.Session.GetString("DateTimeNowSession"));

#line default
#line hidden
            EndContext();
            BeginContext(357, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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
