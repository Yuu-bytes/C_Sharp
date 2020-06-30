#pragma checksum "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Adicionar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92165b377f421b13735c6c1f939fc0e1ac092ccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Adicionar), @"mvc.1.0.view", @"/Views/Home/Adicionar.cshtml")]
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
#line 1 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\_ViewImports.cshtml"
using PressaoDiario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\_ViewImports.cshtml"
using PressaoDiario.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92165b377f421b13735c6c1f939fc0e1ac092ccf", @"/Views/Home/Adicionar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee99b026fda65283b9504d2a0d5b6a89bd487e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Adicionar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Adicionar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Adicionar.cshtml"
  
    ViewData["Title"] = "Adicionar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center mt-3 text-secondary\">Adicionar</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92165b377f421b13735c6c1f939fc0e1ac092ccf4157", async() => {
                WriteLiteral(@"
    <div class=""form mt-5"">
        <input type=""hidden"" name=""Visualizado"" value=""false"" />
        <div class=""row"">
            <div class=""form-group col"">
                <input type=""text"" placeholder=""Data"" class=""form-control"" name=""Data"" id=""Data"" required />
            </div>
        </div>
        <div class=""row"">
            <div class=""form-group col-3"">
                <input type=""number"" min=""0"" max=""200"" class=""form-control"" name=""Sistolica"" id=""Sistolica"" required />
            </div>
            <span style=""font-size: 25px"">/</span>
            <div class=""form-group col-3"">
                <input type=""number"" min=""0"" max=""200"" class=""form-control"" name=""Diastolica"" id=""Diastolica"" required />
            </div>
            
        <div class=""form-group col-2"">
            <div class=""row"">
                <input type=""radio"" id=""Manha"" name=""Periodo"" value=""1"" checked />
                <label for=""Manha""><span class=""material-icons"">wb_sunny</span></label>
   ");
                WriteLiteral(@"         </div>
            <div class=""row"">
                <input type=""radio"" id=""Noite"" name=""Periodo"" value=""2"" />
                <label for=""Noite""><span class=""material-icons"">brightness_3</span></label><br />
            </div>
        </div>
            
            <div class=""form-group col"">
                <input type=""number"" min=""0"" max=""200"" class=""form-control"" name=""Batimentos"" id=""Batimentos"" required />
            </div>

            <svg id=""i-activity"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 32 32"" width=""30"" height=""38"" fill=""none"" stroke=""currentcolor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"">
                <path d=""M4 16 L11 16 14 29 18 3 21 16 28 16"" />
            </svg>
        </div>
        <input type=""submit"" value=""Salvar"" class=""col-12 mt-5 p-2 btn-light border"" />
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
