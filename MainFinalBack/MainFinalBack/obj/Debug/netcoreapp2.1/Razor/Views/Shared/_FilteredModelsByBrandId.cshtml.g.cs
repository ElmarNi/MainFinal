#pragma checksum "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_FilteredModelsByBrandId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb870da285b496433aa1c628e14fed74ec709944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FilteredModelsByBrandId), @"mvc.1.0.view", @"/Views/Shared/_FilteredModelsByBrandId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FilteredModelsByBrandId.cshtml", typeof(AspNetCore.Views_Shared__FilteredModelsByBrandId))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb870da285b496433aa1c628e14fed74ec709944", @"/Views/Shared/_FilteredModelsByBrandId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a35a9e6cea623b428d6d0165fc73b0719c75ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FilteredModelsByBrandId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_FilteredModelsByBrandId.cshtml"
 foreach (var m in Model)
{

#line default
#line hidden
            BeginContext(59, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(63, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28335ea7613943958d2bec17948f0dbb", async() => {
                BeginContext(86, 6, false);
#line 5 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_FilteredModelsByBrandId.cshtml"
                     Write(m.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 5 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_FilteredModelsByBrandId.cshtml"
       WriteLiteral(m.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\MainFinalBack\MainFinalBack\Views\Shared\_FilteredModelsByBrandId.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model>> Html { get; private set; }
    }
}
#pragma warning restore 1591
