#pragma checksum "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e292339d18065725eb7fb5cdbf1974b4f749b26d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Home_Carrito), @"mvc.1.0.view", @"/Areas/Cliente/Views/Home/Carrito.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Home/Carrito.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Home_Carrito))]
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
#line 1 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 1 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e292339d18065725eb7fb5cdbf1974b4f749b26d", @"/Areas/Cliente/Views/Home/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Home_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_3  text-center col-sm-2 col-md-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1 checkout_btn_1 float-right col-sm-2 col-md-3 text-center mt-md-0 mt-sm-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
  
    ViewData["Title"] = "Carrito";

#line default
#line hidden
            BeginContext(95, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(1650, 768, true);
            WriteLiteral(@"
<section class=""cart_area "">
    <div class=""container"">
        <div class=""cart_inner"">
            <div class=""table-responsive"">
                <h1>Carrito</h1>
                <br />
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"" style=""font-size:18px; color:black;"">Producto</th>
                            <th scope=""col"" style=""font-size:18px; color:black;"">Categoria</th>
                            <th scope=""col"" style=""font-size:18px; color:black;"">Precio</th>
                            <th scope=""col"" style=""font-size:18px; color:black;"">Eliminar</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 73 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
                         foreach (var k in Model)
                        {


#line default
#line hidden
            BeginContext(2498, 235, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <div class=\"media\">\r\n                                        <div class=\"d-flex\">\r\n                                            ");
            EndContext();
            BeginContext(2733, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e292339d18065725eb7fb5cdbf1974b4f749b26d8156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2743, "~/", 2743, 2, true);
#line 80 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
AddHtmlAttributeValue("", 2745, k.Imagen, 2745, 9, false);

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
            BeginContext(2758, 163, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"media-body\">\r\n                                            <p>");
            EndContext();
            BeginContext(2922, 8, false);
#line 83 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
                                          Write(k.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(2930, 215, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                                <td>\r\n                                    <h5>");
            EndContext();
            BeginContext(3146, 36, false);
#line 88 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
                                   Write(k.CategoriaProductos.nombreCategoria);

#line default
#line hidden
            EndContext();
            BeginContext(3182, 124, true);
            WriteLiteral("</h5>\r\n                                </td>\r\n                                <td>\r\n                                    <h5>");
            EndContext();
            BeginContext(3307, 8, false);
#line 91 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
                                   Write(k.Precio);

#line default
#line hidden
            EndContext();
            BeginContext(3315, 243, true);
            WriteLiteral("</h5>\r\n                                </td>\r\n                                <td>\r\n                                    <h5 class=\"text-center\">\r\n                                        <span class=\"fas fa-trash-alt button button-contactForm\">");
            EndContext();
            BeginContext(3558, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e292339d18065725eb7fb5cdbf1974b4f749b26d11966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
                                                                                                                                                                   WriteLiteral(k.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3647, 126, true);
            WriteLiteral("</span>\r\n                                    </h5>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 99 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"


                        }

#line default
#line hidden
            BeginContext(3804, 279, true);
            WriteLiteral(@"
                    </tbody>
                </table>
                <br />
                <div class=""text-right"">
                    <h5 class="""" style=""font-size:20px; color:black;"">Total facturado:</h5>
                    <h5 style=""font-size:20px; color:black;"">$");
            EndContext();
            BeginContext(4084, 24, false);
#line 108 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Home\Carrito.cshtml"
                                                         Write(Model.Sum(c => c.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(4108, 123, true);
            WriteLiteral("</h5>\r\n                </div>\r\n                <br />\r\n                        <div class=\"\">\r\n                            ");
            EndContext();
            BeginContext(4231, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e292339d18065725eb7fb5cdbf1974b4f749b26d16187", async() => {
                BeginContext(4320, 16, true);
                WriteLiteral("Seguir comprando");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4340, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4370, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e292339d18065725eb7fb5cdbf1974b4f749b26d17890", async() => {
                BeginContext(4524, 16, true);
                WriteLiteral("Proceder a pagar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4544, 158, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n<!--================End Cart Area =================-->\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
