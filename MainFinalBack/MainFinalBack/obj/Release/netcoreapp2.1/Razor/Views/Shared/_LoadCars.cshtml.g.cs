#pragma checksum "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57722463666ff444ecd64ebdf172bab4786972d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadCars), @"mvc.1.0.view", @"/Views/Shared/_LoadCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoadCars.cshtml", typeof(AspNetCore.Views_Shared__LoadCars))]
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
#line 1 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\_ViewImports.cshtml"
using MainFinalBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\_ViewImports.cshtml"
using MainFinalBack.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\_ViewImports.cshtml"
using MainFinalBack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57722463666ff444ecd64ebdf172bab4786972d", @"/Views/Shared/_LoadCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a35a9e6cea623b428d6d0165fc73b0719c75ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Advertisement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg w-100 custom-bg-green-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 20, true);
            WriteLiteral("<input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 86, "\"", 118, 1);
#line 7 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
WriteAttributeValue("", 94, ViewBag.SelectedAdCount, 94, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(119, 66, true);
            WriteLiteral(" id=\"count\" />\r\n<input type=\"hidden\" value=\"3\" id=\"takenCars\" />\r\n");
            EndContext();
#line 9 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
 foreach (var ad in Model)
{

#line default
#line hidden
            BeginContext(216, 112, true);
            WriteLiteral("    <div class=\"col-12\">\r\n        <div class=\"car-list-item\">\r\n            <div class=\"image\">\r\n                ");
            EndContext();
            BeginContext(328, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d422a1f4ae84890b0e49232ab56f61a", async() => {
                BeginContext(396, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(418, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c39b99a201a4349b95fecad03e5e47c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 428, "~/img/", 428, 6, true);
#line 15 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
AddHtmlAttributeValue("", 434, ad.Car.MainImageUrl, 434, 20, false);

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
                BeginContext(456, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
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
            BeginContext(478, 116, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"car-details\">\r\n                <h2 class=\"mb-2\">\r\n                    ");
            EndContext();
            BeginContext(594, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d27ab57742a4443397b6b13e099e12d7", async() => {
                BeginContext(663, 23, false);
#line 20 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                                                                                   Write(ad.Car.Model.Brand.Name);

#line default
#line hidden
                EndContext();
                BeginContext(686, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(689, 17, false);
#line 20 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                                                                                                             Write(ad.Car.Model.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
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
            BeginContext(710, 87, true);
            WriteLiteral("\r\n                </h2>\r\n                <div class=\"reviews\">\r\n                    <a>");
            EndContext();
            BeginContext(798, 18, false);
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                  Write(ad.UpdatedDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(816, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(819, 31, false);
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                                       Write(ad.UpdatedDate.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(850, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(853, 19, false);
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                                                                         Write(ad.UpdatedDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(872, 191, true);
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"about-car my-2\">\r\n                    <span>\r\n                        <i class=\"fas fa-map-marker-alt\"></i>\r\n                        ");
            EndContext();
            BeginContext(1064, 24, false);
#line 28 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                   Write(ad.Car.City.Country.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1091, 16, false);
#line 28 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                                              Write(ad.Car.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 136, true);
            WriteLiteral("\r\n                    </span>\r\n                    <span>\r\n                        <i class=\"fas fa-cogs\"></i>\r\n                        ");
            EndContext();
            BeginContext(1244, 24, false);
#line 32 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                   Write(ad.Car.Transmission.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 146, true);
            WriteLiteral("\r\n                    </span>\r\n                    <span>\r\n                        <i class=\"far fa-calendar-times\"></i>\r\n                        ");
            EndContext();
            BeginContext(1415, 22, false);
#line 36 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                   Write(ad.Car.ManufactureYear);

#line default
#line hidden
            EndContext();
            BeginContext(1437, 31, true);
            WriteLiteral("\r\n                    </span>\r\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                     if (ad.Car.IsVip)
                    {

#line default
#line hidden
            BeginContext(1531, 154, true);
            WriteLiteral("                        <span>\r\n                            <i class=\"fas fa-gem\"></i>\r\n                            VIP\r\n                        </span>\r\n");
            EndContext();
#line 44 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                    }

#line default
#line hidden
            BeginContext(1708, 108, true);
            WriteLiteral("                    <span>\r\n                        <i class=\"fa fa-list-alt\"></i>\r\n                        ");
            EndContext();
            BeginContext(1817, 20, false);
#line 47 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                   Write(ad.Car.CarClass.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1837, 111, true);
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"more\">\r\n                    ");
            EndContext();
            BeginContext(1948, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c61f1da8be994a9f8f9f93615f469c50", async() => {
                BeginContext(2016, 16, true);
                WriteLiteral("More information");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
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
            BeginContext(2036, 145, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"booking\">\r\n                <div class=\"price\">\r\n                    <span>$");
            EndContext();
            BeginContext(2182, 12, false);
#line 56 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                      Write(ad.Car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2194, 53, true);
            WriteLiteral("</span>/day\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(2247, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb09077d5874bda97010a7ee94b2610", async() => {
                BeginContext(2357, 8, true);
                WriteLiteral("Book Now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
                                                             WriteLiteral(ad.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2369, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 62 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadCars.cshtml"
}

#line default
#line hidden
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