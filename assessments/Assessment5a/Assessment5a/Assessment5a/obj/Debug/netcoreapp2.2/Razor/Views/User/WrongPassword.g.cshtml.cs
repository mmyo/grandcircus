#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5a\Assessment5a\Assessment5a\Views\User\WrongPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca9e312bf8a412594d78312d02d757d5980fde0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_WrongPassword), @"mvc.1.0.view", @"/Views/User/WrongPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/WrongPassword.cshtml", typeof(AspNetCore.Views_User_WrongPassword))]
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5a\Assessment5a\Assessment5a\Views\_ViewImports.cshtml"
using Assessment5a;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5a\Assessment5a\Assessment5a\Views\_ViewImports.cshtml"
using Assessment5a.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca9e312bf8a412594d78312d02d757d5980fde0", @"/Views/User/WrongPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da9dbc8cb16282f0ecfebc35a1338fc8e77bbd9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_WrongPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5a\Assessment5a\Assessment5a\Views\User\WrongPassword.cshtml"
  
    ViewData["Title"] = "WrongPassword";

#line default
#line hidden
            BeginContext(51, 26, true);
            WriteLiteral("\r\n<h1>Incorrect password, ");
            EndContext();
            BeginContext(78, 12, false);
#line 6 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5a\Assessment5a\Assessment5a\Views\User\WrongPassword.cshtml"
                   Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(90, 13, true);
            WriteLiteral(" !!!</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591