#pragma checksum "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faedbdf4b80b6d0ab6476bfd52f9a68bc9add479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Message_Chat), @"mvc.1.0.view", @"/Areas/User/Views/Message/Chat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Message/Chat.cshtml", typeof(AspNetCore.Areas_User_Views_Message_Chat))]
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
#line 1 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\_ViewImports.cshtml"
using MainFinalBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\_ViewImports.cshtml"
using MainFinalBack.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\_ViewImports.cshtml"
using MainFinalBack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faedbdf4b80b6d0ab6476bfd52f9a68bc9add479", @"/Areas/User/Views/Message/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a35a9e6cea623b428d6d0165fc73b0719c75ca", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Message_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatModeratorVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:absolute; bottom:2%; display:contents"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 154, true);
            WriteLiteral("\r\n<div class=\"container\" id=\"ModeratorChat\">\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(178, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47e553fbcb24cc4b967339dfa7394e6", async() => {
                BeginContext(227, 4, true);
                WriteLiteral("User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 47, true);
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(282, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d83705bc51e4122a0e2a999989b28f5", async() => {
                BeginContext(304, 8, true);
                WriteLiteral("Messages");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(316, 231, true);
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">Chat</li>\r\n        </ol>\r\n    </nav>\r\n    <div class=\"messages\" style=\"min-height: calc(100vh - 320px);max-height: calc(100vh - 320px); overflow-y:scroll\">\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
         foreach (var m in Model.ChatMessages)
        {
            

#line default
#line hidden
#line 14 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
             if (m.Message.From == Model.ApplicationUser.Id)
            {

#line default
#line hidden
            BeginContext(683, 38, true);
            WriteLiteral("                <span class=\"d-block\">");
            EndContext();
            BeginContext(722, 18, false);
#line 16 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                 Write(m.Message.Date.Day);

#line default
#line hidden
            EndContext();
            BeginContext(740, 1, true);
            WriteLiteral(",");
            EndContext();
            BeginContext(742, 30, false);
#line 16 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                     Write(m.Message.Date.ToString("MMM"));

#line default
#line hidden
            EndContext();
            BeginContext(772, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(775, 19, false);
#line 16 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                                                      Write(m.Message.Date.Year);

#line default
#line hidden
            EndContext();
            BeginContext(794, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(798, 32, false);
#line 16 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                                                                             Write(m.Message.Date.ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(830, 144, true);
            WriteLiteral("</span>\r\n                <div class=\"message\" style=\"background-color:#344269\">\r\n                    <p style=\"margin:0; word-break:break-word\">");
            EndContext();
            BeginContext(975, 14, false);
#line 18 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                          Write(m.Message.Body);

#line default
#line hidden
            EndContext();
            BeginContext(989, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 20 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1067, 49, true);
            WriteLiteral("                <span class=\"d-block text-right\">");
            EndContext();
            BeginContext(1117, 18, false);
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                            Write(m.Message.Date.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 1, true);
            WriteLiteral(",");
            EndContext();
            BeginContext(1137, 30, false);
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                                Write(m.Message.Date.ToString("MMM"));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1170, 19, false);
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                                                                 Write(m.Message.Date.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 122, true);
            WriteLiteral("</span>\r\n                <div class=\"message text-right\">\r\n                    <p style=\"margin:0; word-break:break-word\">");
            EndContext();
            BeginContext(1312, 14, false);
#line 25 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
                                                          Write(m.Message.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 27 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
            }

#line default
#line hidden
#line 27 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1382, 18, true);
            WriteLiteral("\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1400, 402, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37350377819340a59dc494c687923f70", async() => {
                BeginContext(1475, 84, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Message</label>\r\n            ");
                EndContext();
                BeginContext(1559, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04e52eda0584494089864d2a136b1905", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 34 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message.Body);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1612, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1626, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29db66a2740243dcb901b52938201ad7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 35 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\User\Views\Message\Chat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message.Body);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1693, 102, true);
                WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" class=\"btn btn-block btn-success\" value=\"Send\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1802, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatModeratorVM> Html { get; private set; }
    }
}
#pragma warning restore 1591