#pragma checksum "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99307f7d996be4f7a59914357b35b2d45f92040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Orden_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/Orden/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Orden/Index.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Orden_Index))]
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
#line 1 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 1 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99307f7d996be4f7a59914357b35b2d45f92040", @"/Areas/Cliente/Views/Orden/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Orden_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Orden>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonEditOrdenPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 210, true);
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"container\">\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Lista de Ordenes</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n");
            EndContext();
            BeginContext(388, 200, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <br />\r\n\r\n    <div>\r\n        <table class=\"table table-striped border text-center\">\r\n\r\n            <tr class=\"table-info\">\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(589, 39, false);
#line 27 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.numeroOrden));

#line default
#line hidden
            EndContext();
            BeginContext(628, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(696, 34, false);
#line 30 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(730, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(798, 34, false);
#line 33 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Correo));

#line default
#line hidden
            EndContext();
            BeginContext(832, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(900, 34, false);
#line 36 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(934, 186, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n                <th class=\"text-center\">\r\n                    Acción\r\n                </th>\r\n            </tr>\r\n\r\n");
            EndContext();
#line 46 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
             foreach (var k in Model)
            {

#line default
#line hidden
            BeginContext(1174, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1223, 13, false);
#line 50 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
           Write(k.numeroOrden);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1292, 8, false);
#line 53 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
           Write(k.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1300, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1356, 8, false);
#line 56 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
           Write(k.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(1364, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1420, 8, false);
#line 59 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
           Write(k.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 92, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1520, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f99307f7d996be4f7a59914357b35b2d45f920408497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 64 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = k.ID;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1576, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1627, 44, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1688, 208, true);
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            //Guardar\r\n            var guardar = \'");
                EndContext();
                BeginContext(1897, 19, false);
#line 80 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
                      Write(TempData["guardar"]);

#line default
#line hidden
                EndContext();
                BeginContext(1916, 148, true);
                WriteLiteral("\'\r\n            if (guardar != \'\') {\r\n                alertify.success(guardar);\r\n            }\r\n\r\n            //Editar\r\n\r\n            var editar = \'");
                EndContext();
                BeginContext(2065, 18, false);
#line 87 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
                     Write(TempData["editar"]);

#line default
#line hidden
                EndContext();
                BeginContext(2083, 148, true);
                WriteLiteral("\'\r\n            if (editar != \'\') {\r\n                alertify.success(editar);\r\n            }\r\n\r\n            //Eliminar\r\n            var eliminar = \'");
                EndContext();
                BeginContext(2232, 20, false);
#line 93 "C:\Users\verly\OneDrive\Desktop\ProyectoFinal-Programacion3\TiendaOnline\Areas\Cliente\Views\Orden\Index.cshtml"
                       Write(TempData["eliminar"]);

#line default
#line hidden
                EndContext();
                BeginContext(2252, 129, true);
                WriteLiteral("\'\r\n            if (eliminar != \'\') {\r\n                alertify.error(eliminar);\r\n            }\r\n\r\n\r\n        })\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Orden>> Html { get; private set; }
    }
}
#pragma warning restore 1591
