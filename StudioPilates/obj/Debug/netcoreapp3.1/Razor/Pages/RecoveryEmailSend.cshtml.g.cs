#pragma checksum "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\RecoveryEmailSend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe59a9e38423e26d9ad809fe4644060b18c43de9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudioPilates.Pages.Pages_RecoveryEmailSend), @"mvc.1.0.razor-page", @"/Pages/RecoveryEmailSend.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe59a9e38423e26d9ad809fe4644060b18c43de9", @"/Pages/RecoveryEmailSend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407495d4020eecfe9db42bc9e641294d9e34b652", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RecoveryEmailSend : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\RecoveryEmailSend.cshtml"
  
    ViewData["title"] = "E-mail de Recuperação de Senha Enviado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\RecoveryEmailSend.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>
    As instruções para recuperação de sua senha foram enviadas para o e-mail informado.
    Confira sua caixa de mensagens e siga as instruções para recuperar sua senha.
    Caso não tenha recebido uma mensagem com o link para redefinição de sua senha,
    verifique se o e-mail informado é realmente o mesmo que usou quando cadastrou sua conta.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_RecoveryEmailSend> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_RecoveryEmailSend> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_RecoveryEmailSend>)PageContext?.ViewData;
        public Pages_RecoveryEmailSend Model => ViewData.Model;
    }
}
#pragma warning restore 1591