#pragma checksum "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55dce1c3ac1d53ab0faa4c5b97c9ca3e3ede4eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Administrador), @"mvc.1.0.view", @"/Views/Home/Administrador.cshtml")]
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
#line 1 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\_ViewImports.cshtml"
using ConsultaVeterinario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\_ViewImports.cshtml"
using ConsultaVeterinario.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dce1c3ac1d53ab0faa4c5b97c9ca3e3ede4eb4", @"/Views/Home/Administrador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa61f048b9f33f764f080f8409ae4ee9b80805f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Administrador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dados>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
  
    ViewData["Title"] = "Administrador";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Administrador</h1>
Listar Consultas

<div class=""table-responsive table-striped"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">
                    Nome
                </th>
                <th scope=""col"">
                    Email
                </th>
                <th scope=""col"">
                    Animal
                </th>
                <th scope=""col"">
                    Horario
                </th>
                <th scope=""col"">
                    Informação
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 32 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    /\r\n                    ");
#nullable restore
#line 41 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
               Write(item.Animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
               Write(item.DataHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
               Write(item.Consulta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Michael\source\repos\ConsultaVeterinario\Views\Home\Administrador.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
