#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bc10e08db5823fcd8cfd65c89024c7a61b8653"
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\_ViewImports.cshtml"
using GoogleVisionApi;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\_ViewImports.cshtml"
using GoogleVisionApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bc10e08db5823fcd8cfd65c89024c7a61b8653", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1081536f2d49324f858a482280994158f17825d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FaceDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(76, 33, true);
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n");
            EndContext();
#line 9 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
         foreach (var face in @Model)
        {

#line default
#line hidden
            BeginContext(159, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 175, "\"", 196, 1);
#line 11 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 181, face.ImagePath, 181, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(197, 27, true);
            WriteLiteral(">\r\n            <div>Anger: ");
            EndContext();
            BeginContext(225, 10, false);
#line 12 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
                   Write(face.Anger);

#line default
#line hidden
            EndContext();
            BeginContext(235, 30, true);
            WriteLiteral("</div>\r\n            <div>Joy: ");
            EndContext();
            BeginContext(266, 8, false);
#line 13 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
                 Write(face.Joy);

#line default
#line hidden
            EndContext();
            BeginContext(274, 33, true);
            WriteLiteral("</div>\r\n            <div>Sorrow: ");
            EndContext();
            BeginContext(308, 11, false);
#line 14 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
                    Write(face.Sorrow);

#line default
#line hidden
            EndContext();
            BeginContext(319, 35, true);
            WriteLiteral("</div>\r\n            <div>Surprise: ");
            EndContext();
            BeginContext(355, 13, false);
#line 15 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
                      Write(face.Surprise);

#line default
#line hidden
            EndContext();
            BeginContext(368, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 16 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\final\GoogleVisionApi\GoogleVisionApi\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(387, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FaceDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
