#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a986441d47d46b2711f83fe53d4ce7f008c1a50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\_ViewImports.cshtml"
using classNotes0708_mvc;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\_ViewImports.cshtml"
using classNotes0708_mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a986441d47d46b2711f83fe53d4ce7f008c1a50", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7009816c458b2f1c37533b3fa87c2d003bae1d34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<classNotes0708_mvc.Models.PrivacyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(103, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(108, 17, false);
#line 8 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(125, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml"
 if (Model.DisplayPolicy)
{

#line default
#line hidden
            BeginContext(164, 71, true);
            WriteLiteral("    <p>Use this page to detail your site\'s privacy policy.</p>\r\n    <p>");
            EndContext();
            BeginContext(236, 10, false);
#line 13 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml"
  Write(Model.AsOf);

#line default
#line hidden
            EndContext();
            BeginContext(246, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(260, 20, false);
#line 14 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml"
  Write(Model.PolicyVerbiage);

#line default
#line hidden
            EndContext();
            BeginContext(280, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\class exercises\class0708\classNotes0708_mvc\classNotes0708_mvc\Views\Home\Privacy.cshtml"

}

#line default
#line hidden
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<classNotes0708_mvc.Models.PrivacyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
