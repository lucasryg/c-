#pragma checksum "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef26d5e63105b5a9f3fe7d917a7945b9da4c172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidos/Index.cshtml", typeof(AspNetCore.Views_Pedidos_Index))]
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
#line 1 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef26d5e63105b5a9f3fe7d917a7945b9da4c172", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 30, true);
            WriteLiteral(" <main>\r\n        <h2>Pede aí, ");
            EndContext();
            BeginContext(79, 17, false);
#line 3 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(96, 16, true);
            WriteLiteral("!</h2>\r\n        ");
            EndContext();
            BeginContext(112, 2179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ef26d5e63105b5a9f3fe7d917a7945b9da4c1724494", async() => {
                BeginContext(176, 175, true);
                WriteLiteral("\r\n            <div>\r\n                <label for=\"nome\">Nome Completo</label>\r\n                <br />\r\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 351, "\"", 378, 1);
#line 8 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 359, Model.Cliente.Nome, 359, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(379, 214, true);
                WriteLiteral(" name=\"nome\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"endereco\">Endereço</label>\r\n                <br />\r\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 593, "\"", 624, 1);
#line 14 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 601, Model.Cliente.Endereco, 601, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(625, 202, true);
                WriteLiteral(" name=\"endereco\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"telefone\">Telefone para contato</label>\r\n                <br />\r\n                <input id=\"telefone\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 827, "\"", 858, 1);
#line 20 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 835, Model.Cliente.Telefone, 835, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(859, 194, true);
                WriteLiteral(" placeholder=\"11 12345 6789\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"email\">E-mail</label>\r\n                <br />\r\n                <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1053, "\"", 1081, 1);
#line 26 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 1061, Model.Cliente.Email, 1061, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1082, 264, true);
                WriteLiteral(@"name=""email""/>
            </div>

            <div class=""double-field"">
                <div>
                    <label for=""hamburguer"">Hamburguer</label>
                    <select id=""hamburguer"" name = ""hamburguer"" required>
                        ");
                EndContext();
                BeginContext(1346, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ef26d5e63105b5a9f3fe7d917a7945b9da4c1727733", async() => {
                    BeginContext(1381, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1399, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                     foreach (var hamburguer in Model.Hamburgueres)
                    {

#line default
#line hidden
                BeginContext(1493, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1517, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ef26d5e63105b5a9f3fe7d917a7945b9da4c17210204", async() => {
                    BeginContext(1550, 15, false);
#line 36 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                                                   Write(hamburguer.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1565, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1571, 16, false);
#line 36 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                                                                        Write(hamburguer.preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                          WriteLiteral(hamburguer.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1596, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1621, 237, true);
                WriteLiteral("                       \r\n                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"shake\">Shake</label>\r\n                    <select id=\"shake\" name = \"shake\">\r\n                        ");
                EndContext();
                BeginContext(1858, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ef26d5e63105b5a9f3fe7d917a7945b9da4c17213231", async() => {
                    BeginContext(1893, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1911, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                         foreach (var s in Model.Shakes)
                        {

#line default
#line hidden
                BeginContext(1998, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2026, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ef26d5e63105b5a9f3fe7d917a7945b9da4c17215700", async() => {
                    BeginContext(2050, 6, false);
#line 47 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                                              Write(s.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2056, 12, true);
                    WriteLiteral(" por apenas ");
                    EndContext();
                    BeginContext(2069, 7, false);
#line 47 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                                                                 Write(s.preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                              WriteLiteral(s.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2085, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2114, 170, true);
                WriteLiteral("                      \r\n                    </select>\r\n                </div>\r\n            </div>\r\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 4 "C:\Users\52965431810\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedidos\Index.cshtml"
AddHtmlAttributeValue("", 140, Url.Action("Registrar","Pedidos"), 140, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2291, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
