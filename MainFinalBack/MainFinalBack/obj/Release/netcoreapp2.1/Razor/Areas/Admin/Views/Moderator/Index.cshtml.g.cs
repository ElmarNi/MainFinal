#pragma checksum "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7a303272f1867ce290308efe9394f47afcd0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Moderator_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Moderator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Moderator/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Moderator_Index))]
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
#line 1 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\_ViewImports.cshtml"
using MainFinalBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\_ViewImports.cshtml"
using MainFinalBack.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\_ViewImports.cshtml"
using MainFinalBack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7a303272f1867ce290308efe9394f47afcd0bb", @"/Areas/Admin/Views/Moderator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a35a9e6cea623b428d6d0165fc73b0719c75ca", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Moderator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 151, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <nav aria-label=\"breadcrumb\">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(182, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "857d3e6217164d5ba172ca79df82a82f", async() => {
                BeginContext(212, 5, true);
                WriteLiteral("Admin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(221, 138, true);
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">Moderators</li>\r\n            </ol>\r\n        </nav>\r\n        ");
            EndContext();
            BeginContext(359, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9490d06681b049ec838d6d9330fffeee", async() => {
                BeginContext(421, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            BeginContext(431, 451, true);
            WriteLiteral(@"
        <div class=""table-responsive"">
            <table class=""table text-white w-100"" id=""moderators"">
                <thead>
                    <tr>
                        <th>Firstname</th>
                        <th>Lastname</th>
                        <th>Email</th>
                        <th>Username</th>
                        <th>Blocked</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 23 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                     foreach (var u in Model)
                    {

#line default
#line hidden
            BeginContext(952, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1015, 11, false);
#line 26 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                           Write(u.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(1026, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1066, 10, false);
#line 27 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                           Write(u.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1116, 7, false);
#line 28 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                           Write(u.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1123, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1163, 10, false);
#line 29 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                           Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 31 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                 if (u.IsBlocked)
                                {

#line default
#line hidden
            BeginContext(1300, 65, true);
            WriteLiteral("                                    <p style=\"margin:0\">Yes</p>\r\n");
            EndContext();
#line 34 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1473, 64, true);
            WriteLiteral("                                    <p style=\"margin:0\">No</p>\r\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1572, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 41 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                 if (u.IsBlocked)
                                {

#line default
#line hidden
            BeginContext(1727, 101, true);
            WriteLiteral("                                    <a href=\"\" class=\"btn btn-info btn-block\" id=\"un-block\" data-id=\"");
            EndContext();
            BeginContext(1829, 4, false);
#line 43 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                                                                                Write(u.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 15, true);
            WriteLiteral("\">Unblock</a>\r\n");
            EndContext();
#line 44 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1956, 100, true);
            WriteLiteral("                                    <a href=\"\" class=\"btn btn-danger btn-block\" id=\"block\" data-id=\"");
            EndContext();
            BeginContext(2057, 4, false);
#line 47 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                                                                               Write(u.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2061, 13, true);
            WriteLiteral("\">Block</a>\r\n");
            EndContext();
#line 48 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2109, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\User\Desktop\final\MF\MainFinalBack\MainFinalBack\Areas\Admin\Views\Moderator\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2198, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
