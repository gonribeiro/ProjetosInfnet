#pragma checksum "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0921cede2517d4a6ef4d8447a666b54ec9a6c9c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstacaoRecarga_Index), @"mvc.1.0.view", @"/Views/EstacaoRecarga/Index.cshtml")]
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
#line 1 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\_ViewImports.cshtml"
using EstacoesDaCidade.Apresentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\_ViewImports.cshtml"
using EstacoesDaCidade.Apresentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0921cede2517d4a6ef4d8447a666b54ec9a6c9c3", @"/Views/EstacaoRecarga/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f8c32eefc33663a20bb6070695f63219e9d628", @"/Views/_ViewImports.cshtml")]
    public class Views_EstacaoRecarga_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EstacoesDaCidade.Dominio.Entidades.EstacaoRecarga>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Como cadastrar uma nova localização?</h3>

1. No computador, abra o <a href=""https://www.google.com/maps"" target=""_blank"">Google Maps</a>. Se estiver usando o Google Maps em modo Lite, o desenho de um raio aparecerá na parte inferior, e você não poderá ver as coordenadas de um lugar.
<br/>2. Clique com o botão direito do mouse no lugar ou na área no mapa.
<br />3. Selecione ""O que há aqui?"".
<br />4. Na parte inferior, você verá um cartão com as coordenadas.
<br />5. Copie as coordenadas (não se esqueça do sinal de negativo ["" - "" (menos)] se houver).
<br />6. Cole nos respectivos campos Latitude e Longitude ao criar ou editar uma localização.
<br />Veja o exemplo de como fica abaixo: 
<br /><br />

<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0921cede2517d4a6ef4d8447a666b54ec9a6c9c35672", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                (Exemplo) Estação Shopping Nova América
            </td>
            <td>
                Recarga de Dispositivo Móvel
            </td>
            <td>
                -228777006
            </td>
            <td>
                -432716991
            </td>
            <td>
                <a href=""https://localhost:44301/maps/index.html?latitude=-228777006&longitude=-432716991"" target=""_blank"">Ver no Mapa</a>
            </td>
        </tr>
");
#nullable restore
#line 57 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0921cede2517d4a6ef4d8447a666b54ec9a6c9c311082", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0921cede2517d4a6ef4d8447a666b54ec9a6c9c313335", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0921cede2517d4a6ef4d8447a666b54ec9a6c9c315594", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2704, "\"", 2800, 4);
            WriteAttributeValue("", 2711, "https://localhost:44301/maps/index.html?latitude=", 2711, 49, true);
#nullable restore
#line 76 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
WriteAttributeValue("", 2760, item.Latitude, 2760, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2774, "&longitude=", 2774, 11, true);
#nullable restore
#line 76 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
WriteAttributeValue("", 2785, item.Longitude, 2785, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Ver no Mapa</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 79 "C:\Users\Tiago\Desktop\OneDrive - IQ-UFRJ\Cursos\Dev\.NET Core\ProjetosInfnet\EstacoesDaCidade\EstacoesDaCidade.Apresentacao\Views\EstacaoRecarga\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EstacoesDaCidade.Dominio.Entidades.EstacaoRecarga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
