#pragma checksum "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88ddfae53672935377ad01a11b24af2c5ce4511a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_Details), @"mvc.1.0.view", @"/Views/Veiculo/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Veiculo/Details.cshtml", typeof(AspNetCore.Views_Veiculo_Details))]
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
#line 1 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\_ViewImports.cshtml"
using Fast_Entregas;

#line default
#line hidden
#line 2 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\_ViewImports.cshtml"
using Fast_Entregas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88ddfae53672935377ad01a11b24af2c5ce4511a", @"/Views/Veiculo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e57456748e9e8528fa18a08bb68a9c2b12e137", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.Veiculo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(67, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Veiculo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(198, 46, false);
#line 14 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodVeiculo));

#line default
#line hidden
            EndContext();
            BeginContext(244, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(308, 42, false);
#line 17 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodVeiculo));

#line default
#line hidden
            EndContext();
            BeginContext(350, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(413, 45, false);
#line 20 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(458, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(522, 41, false);
#line 23 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(563, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(626, 41, false);
#line 26 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(667, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(731, 37, false);
#line 29 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(768, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(831, 43, false);
#line 32 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Renavam));

#line default
#line hidden
            EndContext();
            BeginContext(874, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(938, 39, false);
#line 35 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Renavam));

#line default
#line hidden
            EndContext();
            BeginContext(977, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1040, 39, false);
#line 38 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1143, 35, false);
#line 41 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1241, 42, false);
#line 44 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1347, 38, false);
#line 47 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1448, 41, false);
#line 50 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmUso));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1553, 37, false);
#line 53 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmUso));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1653, 43, false);
#line 56 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodDono));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1760, 39, false);
#line 59 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodDono));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1847, 68, false);
#line 64 "C:\Google Drive\UFS\6 periodo\Engenharia de software 2\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Veiculo\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1923, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88ddfae53672935377ad01a11b24af2c5ce4511a12131", async() => {
                BeginContext(1945, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1961, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.Veiculo> Html { get; private set; }
    }
}
#pragma warning restore 1591