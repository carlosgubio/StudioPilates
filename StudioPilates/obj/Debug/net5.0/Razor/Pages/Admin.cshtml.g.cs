#pragma checksum "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124d1eee08c4e1278cb389662d76b731cb5e5fce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudioPilates.Pages.Pages_Admin), @"mvc.1.0.razor-page", @"/Pages/Admin.cshtml")]
namespace StudioPilates.Pages
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
#line 1 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\_ViewImports.cshtml"
using StudioPilates;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124d1eee08c4e1278cb389662d76b731cb5e5fce", @"/Pages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407495d4020eecfe9db42bc9e641294d9e34b652", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\Admin.cshtml"
  
    ViewData["Title"] = "Área Administrativa";
    Layout = "_BackTemplate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"container mt-3\">\r\n    <div class=\"row justify-content-md-center\">\r\n        <div class=\"col-md-12 text-center mt-3\">\r\n            <h1>");
#nullable restore
#line 10 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\Admin.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>Seja bem vindo(a)!</p>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Admin> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Admin> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Admin>)PageContext?.ViewData;
        public Pages_Admin Model => ViewData.Model;
    }
}
#pragma warning restore 1591
