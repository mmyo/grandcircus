#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab21\CoffeeShop\CoffeeShop\Views\User\ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eca6b06fab82e4bd41d9f86e89fb3f4708da14c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewAll), @"mvc.1.0.view", @"/Views/User/ViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ViewAll.cshtml", typeof(AspNetCore.Views_User_ViewAll))]
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab21\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab21\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eca6b06fab82e4bd41d9f86e89fb3f4708da14c", @"/Views/User/ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab21\CoffeeShop\CoffeeShop\Views\User\ViewAll.cshtml"
  
    ViewData["Title"] = "ViewAll";

#line default
#line hidden
            BeginContext(64, 30, true);
            WriteLiteral("\r\n<h1>ViewAll</h1>\r\n\r\nWelcome ");
            EndContext();
            BeginContext(95, 15, false);
#line 9 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab21\CoffeeShop\CoffeeShop\Views\User\ViewAll.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
