#pragma checksum "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a830bcdbe77c33275ff3f303117c99286d740ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\_ViewImports.cshtml"
using MarketStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\_ViewImports.cshtml"
using MarketStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a830bcdbe77c33275ff3f303117c99286d740ebe", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1820e61c2dee8ca409468eb17dcadd317f64a5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MarketStore.Models.AboutFp>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml"
  
	Layout="~/Views/Shared/_Home.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Title page -->
	<section class=""bg-img1 txt-center p-lr-15 p-tb-92"" style=""background-image: url('/Home/images/bg-01.jpg');"">
		<h2 class=""ltext-105 cl0 txt-center"">
			About
		</h2>
	</section>	


	<!-- Content page -->
	<section class=""bg0 p-t-75 p-b-120"">
		<div class=""container"">
");
#nullable restore
#line 17 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml"
             foreach(var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"row p-b-148\">\n\t\t\t\t\n\t\t\t\n\t\t\t\t<div class=\"col-md-7 col-lg-8\">\n\t\t\t\t\t<div class=\"p-t-7 p-r-85 p-r-15-lg p-r-0-md\">\n\t\t\t\t\t\t<h3 class=\"mtext-111 cl2 p-b-16\">\n\t\t\t\t\t\t\tOur Story\n\t\t\t\t\t\t</h3>\n\t\t\t\n\t\n\n\t\t\t\t\t\t<p class=\"stext-113 cl6 p-b-26\">\n\t\t\t\t\t\t\t\n\t\t\t\t\t\t");
#nullable restore
#line 32 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml"
                   Write(item.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</p>\n\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\n\t\t\t\t<div class=\"col-11 col-md-5 col-lg-4 m-lr-auto\">\n\t\t\t\t\t<div class=\"how-bor1 \">\n\t\t\t\t\t\t<div class=\"hov-img0\">\n");
            WriteLiteral("\t\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a830bcdbe77c33275ff3f303117c99286d740ebe4754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml"
                          WriteLiteral(Url.Content("~/Home/images/" + item.ImagePath));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\n\t\t\t\t\t</div>\n\t\t\t\t\t\n\t\t\t\t</div>\n\t\t\t</div>\n");
#nullable restore
#line 50 "C:\Users\HamzaTrini\Desktop\visual_studio\MarketStore\MarketStore\Views\Home\About.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\n\t\t\t</section>\n\t\t\t\n\t\t");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MarketStore.Models.AboutFp>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
