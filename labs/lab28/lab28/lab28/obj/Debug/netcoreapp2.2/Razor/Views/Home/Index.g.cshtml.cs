#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab4e824d8866a442634fd60c2507ad88427c183"
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\_ViewImports.cshtml"
using lab28;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\_ViewImports.cshtml"
using lab28.Models;

#line default
#line hidden
#line 2 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab4e824d8866a442634fd60c2507ad88427c183", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81330a96261e0f4fae27be83959ebc88d42bffd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Deck>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(123, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(170, 64, true);
            WriteLiteral("<h1 class=\"display-4\">Lab 28</h1>\r\n\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
#line 12 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
     if (@HttpContextAccessor.HttpContext.Session.GetString("deckId") == null)
    {

#line default
#line hidden
            BeginContext(321, 151, true);
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            <p>No deck found. Click button below for a new deck of cards.</p>\r\n        </div>\r\n");
            EndContext();
#line 17 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(479, 66, true);
            WriteLiteral("\r\n    <div>\r\n        <button type=\"submit\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 545, "\"", 601, 3);
            WriteAttributeValue("", 555, "location.href=\'", 555, 15, true);
#line 20 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
WriteAttributeValue("", 570, Url.Action("NewDeck", "Home"), 570, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 600, "\'", 600, 1, true);
            EndWriteAttribute();
            BeginContext(602, 42, true);
            WriteLiteral(">Get New Deck</button>\r\n    </div>\r\n    \r\n");
            EndContext();
#line 23 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
         if (@HttpContextAccessor.HttpContext.Session.GetString("deckId") != null)
        {

#line default
#line hidden
            BeginContext(739, 92, true);
            WriteLiteral("            <div class=\"alert alert-primary\" role=\"alert\">\r\n                <b>Deck Id:</b> ");
            EndContext();
            BeginContext(832, 59, false);
#line 26 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
                           Write(HttpContextAccessor.HttpContext.Session.GetString("deckId"));

#line default
#line hidden
            EndContext();
            BeginContext(891, 43, true);
            WriteLiteral("\r\n                <b>Cards Remaining: </b> ");
            EndContext();
            BeginContext(935, 61, false);
#line 27 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
                                    Write(HttpContextAccessor.HttpContext.Session.GetInt32("remaining"));

#line default
#line hidden
            EndContext();
            BeginContext(996, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 29 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1029, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 32 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
     if (@HttpContextAccessor.HttpContext.Session.GetInt32("remaining") == 0)
    {

#line default
#line hidden
            BeginContext(1119, 120, true);
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            <p>No cards remaining in deck.</p>\r\n        </div>\r\n");
            EndContext();
#line 37 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1246, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
     if (ViewData["drawnCardsList"] != null)
    {

#line default
#line hidden
            BeginContext(1301, 15, true);
            WriteLiteral("        <div>\r\n");
            EndContext();
#line 42 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
             foreach (var card in ViewData["drawnCardsList"] as IList<Card>)
            {

#line default
#line hidden
            BeginContext(1409, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1429, "\"", 1446, 1);
#line 44 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
WriteAttributeValue("", 1435, card.Image, 1435, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1447, 14, true);
            WriteLiteral(" width=\"50\">\r\n");
            EndContext();
#line 45 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1476, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 47 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1501, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
     if (@HttpContextAccessor.HttpContext.Session.GetString("deckId") != null)
    {

#line default
#line hidden
            BeginContext(1590, 72, true);
            WriteLiteral("        <div>\r\n            <button type=\"submit\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1662, "\"", 1720, 3);
            WriteAttributeValue("", 1672, "location.href=\'", 1672, 15, true);
#line 53 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
WriteAttributeValue("", 1687, Url.Action("DrawCards", "Home"), 1687, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1719, "\'", 1719, 1, true);
            EndWriteAttribute();
            BeginContext(1721, 40, true);
            WriteLiteral(">Draw 5 Cards</button>\r\n        </div>\r\n");
            EndContext();
#line 55 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\labs\lab28\lab28\lab28\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1768, 28, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Deck> Html { get; private set; }
    }
}
#pragma warning restore 1591
