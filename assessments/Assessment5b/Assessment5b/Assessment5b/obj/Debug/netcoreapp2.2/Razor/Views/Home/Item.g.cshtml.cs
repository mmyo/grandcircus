#pragma checksum "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4979255c193ec5b1a683e2e11bd69a69cafac0af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Item), @"mvc.1.0.view", @"/Views/Home/Item.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Item.cshtml", typeof(AspNetCore.Views_Home_Item))]
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
#line 1 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4979255c193ec5b1a683e2e11bd69a69cafac0af", @"/Views/Home/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3933ee428082eb9a9207a83583e76cc877803508", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml"
  
    ViewData["Title"] = "Item";

#line default
#line hidden
            BeginContext(152, 21, true);
            WriteLiteral("\r\n<h1>Item quantity: ");
            EndContext();
            BeginContext(174, 60, false);
#line 8 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml"
              Write(HttpContextAccessor.HttpContext.Session.GetInt32("quantity"));

#line default
#line hidden
            EndContext();
            BeginContext(234, 78, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <button class=\"btn btn-primary\" type=\"button\" id=\"addItem\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n            onclick=\"", 312, "\"", 381, 3);
            WriteAttributeValue("", 335, "location.href=\'", 335, 15, true);
#line 12 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml"
WriteAttributeValue("", 350, Url.Action("AddItem", "Home"), 350, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 380, "\'", 380, 1, true);
            EndWriteAttribute();
            BeginContext(382, 106, true);
            WriteLiteral(">\r\n        Add One Item\r\n    </button>\r\n\r\n    <button class=\"btn btn-danger\" type=\"button\" id=\"deleteItem\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n            onclick=\"", 488, "\"", 560, 3);
            WriteAttributeValue("", 511, "location.href=\'", 511, 15, true);
#line 17 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml"
WriteAttributeValue("", 526, Url.Action("DeleteItem", "Home"), 526, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 559, "\'", 559, 1, true);
            EndWriteAttribute();
            BeginContext(561, 73, true);
            WriteLiteral(">\r\n        Delete One Item\r\n    </button>\r\n</div>\r\n<p></p>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(634, 336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4979255c193ec5b1a683e2e11bd69a69cafac0af7198", async() => {
                BeginContext(724, 239, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Enter Quantity</label>\r\n            <input class=\"form-control\" name=\"quantity\" />\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Update Quantity</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(970, 89, true);
            WriteLiteral("\r\n</div>\r\n<p></p>\r\n<div>\r\n    <button class=\"btn btn-success\" type=\"button\" id=\"checkout\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n            onclick=\"", 1059, "\"", 1129, 3);
            WriteAttributeValue("", 1082, "location.href=\'", 1082, 15, true);
#line 35 "C:\Users\myo\OneDrive - KNEX\Documents\grandcircus\assessments\Assessment5b\Assessment5b\Assessment5b\Views\Home\Item.cshtml"
WriteAttributeValue("", 1097, Url.Action("Checkout", "Home"), 1097, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 1128, "\'", 1128, 1, true);
            EndWriteAttribute();
            BeginContext(1130, 50, true);
            WriteLiteral(">\r\n        Checkout\r\n    </button>\r\n</div>\r\n\r\n\r\n\r\n");
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