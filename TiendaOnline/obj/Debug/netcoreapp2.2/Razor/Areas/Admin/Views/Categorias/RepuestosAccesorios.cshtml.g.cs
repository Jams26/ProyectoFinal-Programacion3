#pragma checksum "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c27a304bc1b175fa8542f29feaaabb979f6ecac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categorias_RepuestosAccesorios), @"mvc.1.0.view", @"/Areas/Admin/Views/Categorias/RepuestosAccesorios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Categorias/RepuestosAccesorios.cshtml", typeof(AspNetCore.Areas_Admin_Views_Categorias_RepuestosAccesorios))]
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
#line 1 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 1 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27a304bc1b175fa8542f29feaaabb979f6ecac8", @"/Areas/Admin/Views/Categorias/RepuestosAccesorios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categorias_RepuestosAccesorios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button boxed-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(97, 260, true);
            WriteLiteral(@"

<br />
<div class=""container"">

    <h2>Categoria Repuestos Y Accesorios</h2>
    <br />
    <!--? Popular Items Start -->
    <div class=""popular-items"">
        <div class="""">
            <!-- Section tittle -->
            <div class=""row"">

");
            EndContext();
#line 20 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
                 foreach (var producto in Model)
                {

#line default
#line hidden
            BeginContext(426, 204, true);
            WriteLiteral("                    <div class=\"col-xl-4 col-lg-4 col-md-6 col-sm-6\">\r\n                        <div class=\"single-popular-items mb-50 text-center\">\r\n                            <div class=\"popular-img\">\r\n");
            EndContext();
            BeginContext(729, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(763, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c27a304bc1b175fa8542f29feaaabb979f6ecac86595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 773, "~/", 773, 2, true);
#line 27 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
AddHtmlAttributeValue("", 775, producto.Imagen, 775, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(800, 111, true);
            WriteLiteral("\r\n                                <div class=\"img-cap\">\r\n                                    <span class=\"p-2\">");
            EndContext();
            BeginContext(911, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27a304bc1b175fa8542f29feaaabb979f6ecac88419", async() => {
                BeginContext(1030, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
                                                                                                     WriteLiteral(producto.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1042, 386, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""favorit-items"">
                                    <span class=""flaticon-heart""></span>
                                </div>
                            </div>
                            <div class=""popular-caption"">
                                <h3><a href=""product_details.html"">");
            EndContext();
            BeginContext(1429, 15, false);
#line 36 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
                                                              Write(producto.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 51, true);
            WriteLiteral("</a></h3>\r\n                                <span> $");
            EndContext();
            BeginContext(1496, 15, false);
#line 37 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"
                                   Write(producto.Precio);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 105, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 41 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Categorias\RepuestosAccesorios.cshtml"

                }

#line default
#line hidden
            BeginContext(1637, 117, true);
            WriteLiteral("            </div>\r\n\r\n            <!-- Button -->\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Popular Items End -->");
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
