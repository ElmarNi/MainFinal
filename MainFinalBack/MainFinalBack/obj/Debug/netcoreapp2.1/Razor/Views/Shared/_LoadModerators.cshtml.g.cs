#pragma checksum "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f50220863adf00b96540c3581440ef67533e4d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadModerators), @"mvc.1.0.view", @"/Views/Shared/_LoadModerators.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoadModerators.cshtml", typeof(AspNetCore.Views_Shared__LoadModerators))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f50220863adf00b96540c3581440ef67533e4d8a", @"/Views/Shared/_LoadModerators.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a35a9e6cea623b428d6d0165fc73b0719c75ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadModerators : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(60, 11, true);
            WriteLiteral("\r\n<tbody>\r\n");
            EndContext();
#line 8 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
     foreach (var u in Model)
    {

#line default
#line hidden
            BeginContext(109, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(140, 11, false);
#line 11 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
           Write(u.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(151, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(175, 10, false);
#line 12 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
           Write(u.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(185, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(209, 7, false);
#line 13 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
           Write(u.Email);

#line default
#line hidden
            EndContext();
            BeginContext(216, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(240, 10, false);
#line 14 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
           Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(250, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 16 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                 if (u.IsBlocked)
                {

#line default
#line hidden
            BeginContext(329, 49, true);
            WriteLiteral("                    <p style=\"margin:0\">Yes</p>\r\n");
            EndContext();
#line 19 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(438, 48, true);
            WriteLiteral("                    <p style=\"margin:0\">No</p>\r\n");
            EndContext();
#line 23 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                }

#line default
#line hidden
            BeginContext(505, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 26 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                 if (u.IsBlocked)
                {

#line default
#line hidden
            BeginContext(596, 85, true);
            WriteLiteral("                    <a href=\"\" class=\"btn btn-info btn-block\" id=\"un-block\" data-id=\"");
            EndContext();
            BeginContext(682, 4, false);
#line 28 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                                                                                Write(u.Id);

#line default
#line hidden
            EndContext();
            BeginContext(686, 15, true);
            WriteLiteral("\">Unblock</a>\r\n");
            EndContext();
#line 29 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(761, 84, true);
            WriteLiteral("                    <a href=\"\" class=\"btn btn-danger btn-block\" id=\"block\" data-id=\"");
            EndContext();
            BeginContext(846, 4, false);
#line 32 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                                                                               Write(u.Id);

#line default
#line hidden
            EndContext();
            BeginContext(850, 13, true);
            WriteLiteral("\">Block</a>\r\n");
            EndContext();
#line 33 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
                }

#line default
#line hidden
            BeginContext(882, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_LoadModerators.cshtml"
    }

#line default
#line hidden
            BeginContext(923, 8, true);
            WriteLiteral("</tbody>");
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
