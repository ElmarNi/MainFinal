#pragma checksum "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d6559bddb4047e9a5c60275f98db582688b9b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Moderator_Views_Advertisement_Index), @"mvc.1.0.view", @"/Areas/Moderator/Views/Advertisement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Moderator/Views/Advertisement/Index.cshtml", typeof(AspNetCore.Areas_Moderator_Views_Advertisement_Index))]
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
#line 1 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\_ViewImports.cshtml"
using MainFinalBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\_ViewImports.cshtml"
using MainFinalBack.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\_ViewImports.cshtml"
using MainFinalBack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d6559bddb4047e9a5c60275f98db582688b9b5", @"/Areas/Moderator/Views/Advertisement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a35a9e6cea623b428d6d0165fc73b0719c75ca", @"/Areas/Moderator/Views/_ViewImports.cshtml")]
    public class Areas_Moderator_Views_Advertisement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Advertisement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block text-center mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 323, true);
            WriteLiteral(@"

<style>
    table div:not(.delete-buttons) {
        display: none !important;
    }

    table img {
        width: 150px !important;
        max-width: unset;
    }
</style>
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(358, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79012ac6856c459d9536b37114118858", async() => {
                BeginContext(388, 9, true);
                WriteLiteral("Moderator");
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
            BeginContext(401, 612, true);
            WriteLiteral(@"</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Advertisements</li>
        </ol>
    </nav>
    <div class=""table-responsive"">
        <table class=""table"" id=""ads"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>User Email</th>
                    <th>Brand</th>
                    <th>Model</th>
                    <th>Verified</th>
                    <th>Updated date</th>
                    <th>Price</th>
                    <th>Is VIP?</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 36 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                 foreach (var ad in Model)
                {

#line default
#line hidden
            BeginContext(1076, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1160, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d863b677c7847be8b1810451293aff9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1170, "~/img/", 1170, 6, true);
#line 40 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
AddHtmlAttributeValue("", 1176, ad.Car.MainImageUrl, 1176, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1200, 63, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(1264, 24, false);
#line 43 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                       Write(ad.ApplicationUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 37, true);
            WriteLiteral("</td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(1326, 23, false);
#line 45 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                       Write(ad.Car.Model.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1349, 37, true);
            WriteLiteral("</td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(1387, 17, false);
#line 47 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                       Write(ad.Car.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1404, 39, true);
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n");
            EndContext();
#line 50 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                             if (ad.IsVerified)
                            {

#line default
#line hidden
            BeginContext(1523, 50, true);
            WriteLiteral("                                <span>Yes</span>\r\n");
            EndContext();
#line 53 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1669, 49, true);
            WriteLiteral("                                <span>No</span>\r\n");
            EndContext();
#line 57 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1749, 61, true);
            WriteLiteral("                        </td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(1811, 18, false);
#line 60 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                       Write(ad.UpdatedDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1829, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(1831, 20, false);
#line 60 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                                           Write(ad.UpdatedDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1851, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(1853, 19, false);
#line 60 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                                                                 Write(ad.UpdatedDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 37, true);
            WriteLiteral("</td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(1910, 12, false);
#line 62 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                       Write(ad.Car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 41, true);
            WriteLiteral(" $</td>\r\n\r\n                        <td>\r\n");
            EndContext();
#line 65 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                             if (ad.Car.IsVip)
                            {

#line default
#line hidden
            BeginContext(2042, 50, true);
            WriteLiteral("                                <span>Yes</span>\r\n");
            EndContext();
#line 68 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2188, 49, true);
            WriteLiteral("                                <span>No</span>\r\n");
            EndContext();
#line 72 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2268, 89, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2357, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58e50568803d4409beddd92cf3bb25bb", async() => {
                BeginContext(2471, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                                                                                                                          WriteLiteral(ad.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2482, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 78 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Areas\Moderator\Views\Advertisement\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2561, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Advertisement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
