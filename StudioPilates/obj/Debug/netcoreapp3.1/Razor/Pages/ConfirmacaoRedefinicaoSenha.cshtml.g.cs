#pragma checksum "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\ConfirmacaoRedefinicaoSenha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77fdfc455098d689203e8ebfb976554fe9fd3dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudioPilates.Pages.Pages_ConfirmacaoRedefinicaoSenha), @"mvc.1.0.razor-page", @"/Pages/ConfirmacaoRedefinicaoSenha.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77fdfc455098d689203e8ebfb976554fe9fd3dd5", @"/Pages/ConfirmacaoRedefinicaoSenha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407495d4020eecfe9db42bc9e641294d9e34b652", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ConfirmacaoRedefinicaoSenha : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\ConfirmacaoRedefinicaoSenha.cshtml"
  
    ViewData["title"] = "Redefinição de Senha Realizada com Sucesso!";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\ConfirmacaoRedefinicaoSenha.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>A redefinição de sua senha foi realizada com sucesso. Para fazer o login agora, <a href=\"/Login\">clique aqui</a>.</p>\r\n<p>\r\n    <a class=\"btn btn-outline-success\" href=\"/Login\">Clique aqui para fazer o login!</a>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_ConfirmacaoRedefinicaoSenha> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_ConfirmacaoRedefinicaoSenha> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_ConfirmacaoRedefinicaoSenha>)PageContext?.ViewData;
        public Pages_ConfirmacaoRedefinicaoSenha Model => ViewData.Model;
    }
}
#pragma warning restore 1591
