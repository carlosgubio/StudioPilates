#pragma checksum "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d375a911db4e328db3c3c3bffe7f11c015840f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudioPilates.Pages.CustomerCRUD.Pages_CustomerCRUD_Details), @"mvc.1.0.razor-page", @"/Pages/CustomerCRUD/Details.cshtml")]
namespace StudioPilates.Pages.CustomerCRUD
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d375a911db4e328db3c3c3bffe7f11c015840f80", @"/Pages/CustomerCRUD/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407495d4020eecfe9db42bc9e641294d9e34b652", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CustomerCRUD_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height:300px;max-width:300px;border:solid 1px gray; border-radius:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>Dados Pessoais</h4>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 13 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 14 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 15 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 16 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 17 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 18 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 19 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 20 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 21 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 22 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 23 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Birth_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 24 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Birth_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n    <h4>Endereço</h4>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 28 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 29 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 30 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 31 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 32 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 33 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 34 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 35 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 36 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 37 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 38 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 39 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 40 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Customer.Address.Zip_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 41 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Customer.Address.Zip_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n    <div class=\"form-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d375a911db4e328db3c3c3bffe7f11c015840f8013284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
      WriteLiteral(Model.PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "C:\Users\carlo\source\StudioPilates\StudioPilates\Pages\CustomerCRUD\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d375a911db4e328db3c3c3bffe7f11c015840f8015517", async() => {
                WriteLiteral("Voltar à Listagem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudioPilates.Pages.CustomerCRUD.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudioPilates.Pages.CustomerCRUD.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudioPilates.Pages.CustomerCRUD.DetailsModel>)PageContext?.ViewData;
        public StudioPilates.Pages.CustomerCRUD.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591