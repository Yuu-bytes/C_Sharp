#pragma checksum "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0829b8c5e175f510e4d291d6e90f44d8269e51e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0829b8c5e175f510e4d291d6e90f44d8269e51e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee99b026fda65283b9504d2a0d5b6a89bd487e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.DTOs.Pressao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"ml-lg-5\">\r\n        <h1>Diário da Pressão</h1>\r\n        <input class=\"btn btn-secondary btn-block mb-2\" type=\"button\" value=\"Enviar para o Médico\"");
            BeginWriteAttribute("onclick", " onclick=\"", 249, "\"", 304, 3);
            WriteAttributeValue("", 259, "location=\'", 259, 10, true);
#nullable restore
#line 9 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
WriteAttributeValue("", 269, Url.Action("EnviarEmail", "Home"), 269, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 303, "\'", 303, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
        <div class=""table-responsive table-striped"">
            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">
                            Data
                        </th>
                        <th scope=""col"">
                            Pressão
                        </th>
                        <th scope=""col"">
                            Batimento
                        </th>
                        <th scope=""col"">

                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {
                        if (item.Visualizado == false) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 34 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                           Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                           Write(item.Sistolica);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                /\r\n                                ");
#nullable restore
#line 39 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                           Write(item.Diastolica);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                           Write(item.Batimentos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <svg id=""i-activity"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 32 32"" width=""20"" height=""20"" fill=""none"" stroke=""currentcolor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"">
                                    <path d=""M4 16 L11 16 14 29 18 3 21 16 28 16"" />
                                </svg>
");
#nullable restore
#line 46 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                                 if (item.Periodo == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"material-icons\">\r\n                                        wb_sunny\r\n                                    </span>\r\n");
#nullable restore
#line 51 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"material-icons\">\r\n                                        brightness_3\r\n                                    </span>\r\n");
#nullable restore
#line 57 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td style=\"text-align: right; width: 125px !important\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2587, "\"", 2619, 2);
            WriteAttributeValue("", 2594, "/Home/Excluir?id=", 2594, 17, true);
#nullable restore
#line 60 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
WriteAttributeValue("", 2611, item.Id, 2611, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a> |\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2670, "\"", 2701, 2);
            WriteAttributeValue("", 2677, "/Home/Editar?id=", 2677, 16, true);
#nullable restore
#line 61 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
WriteAttributeValue("", 2693, item.Id, 2693, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <nav class=\"nav justify-content-end\">\r\n            <button type=\"button\" class=\"btn btn-light rounded-circle\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3012, "\"", 3057, 3);
            WriteAttributeValue("", 3022, "location=\'", 3022, 10, true);
#nullable restore
#line 70 "D:\_Programação\C#\PressaoDiario\PressaoDiario\Views\Home\Index.cshtml"
WriteAttributeValue("", 3032, Url.Action("Adicionar"), 3032, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3056, "\'", 3056, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <svg id=""i-plus"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 32 32"" width=""32"" height=""32"" fill=""none"" stroke=""currentcolor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"">
                    <path d=""M16 2 L16 30 M2 16 L30 16"" />
                </svg>
            </button>
        </nav>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.DTOs.Pressao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
