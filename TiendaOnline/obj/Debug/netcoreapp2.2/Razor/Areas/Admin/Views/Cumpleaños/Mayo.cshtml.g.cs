#pragma checksum "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Cumpleaños\Mayo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86dbb800616d9ec2a599b7ec76157cc8f8ee170f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Mayo), @"mvc.1.0.view", @"/Areas/Admin/Views/Cumpleaños/Mayo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cumpleaños/Mayo.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cumpleaños_Mayo))]
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
#line 1 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#line 2 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86dbb800616d9ec2a599b7ec76157cc8f8ee170f", @"/Areas/Admin/Views/Cumpleaños/Mayo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cumpleaños_Mayo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaOnline.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Cumpleaños\Mayo.cshtml"
  
    ViewData["Title"] = "Cumpleaños Mayo";

#line default
#line hidden
            BeginContext(108, 409, true);
            WriteLiteral(@"
<br />
<br />
<div class=""row"">
    <div class=""col-6"">
        <h2 class=""text-info"">Cumpleaños del mes de Mayo</h2>

    </div>
</div>
<br />

<div>
    <table class=""table table-striped border text-center"" id=""cumple"">
        <thead>
            <tr class=""table-info"">
                <th>Correo</th>
                <th>Fecha</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 25 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Cumpleaños\Mayo.cshtml"
             foreach (var k in Model)
            {

#line default
#line hidden
            BeginContext(571, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(618, 10, false);
#line 28 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Cumpleaños\Mayo.cshtml"
                   Write(k.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(628, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(660, 17, false);
#line 29 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Cumpleaños\Mayo.cshtml"
                   Write(k.fechaNacimiento);

#line default
#line hidden
            EndContext();
            BeginContext(677, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Jesus\Documents\Cuatrimestre\5to cuatrimestre\Programacion 3 - Amadis\Proyecto final\ProyectoFinal-Programacion3\TiendaOnline\Areas\Admin\Views\Cumpleaños\Mayo.cshtml"

            }

#line default
#line hidden
            BeginContext(724, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(781, 2203, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        //DataTable
        $(document).ready(function () {
            $('#cumple').DataTable({
                ""language"": idioma_espanol,
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'copy',
                        text: 'COPIAR'
                    },
                    {
                        extend: 'pdf',
                        text: 'PDF'
                    },
                    {
                        extend: 'excel',
                        text: 'EXCEL'
                    },
                    {
                        extend: 'csv',
                        text: 'CSV'
                    },
                    {
                        extend: 'print',
                        text: 'IMPRIMIR'
                    }
                ]
            });
        });

        var idioma_espanol = {
            ""sProcessing"": ""Procesando..."",
            ""sLe");
                WriteLiteral(@"ngthMenu"": ""Mostrar _MENU_ registros"",
            ""sZeroRecords"": ""No se encontraron resultados"",
            ""sEmptyTable"": ""Ningún dato disponible en esta tabla"",
            ""sInfo"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
            ""sInfoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
            ""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
            ""sInfoPostFix"": """",
            ""sSearch"": ""Buscar:"",
            ""sUrl"": """",
            ""sInfoThousands"": "","",
            ""sLoadingRecords"": ""Cargando..."",
            ""oPaginate"": {
                ""sFirst"": ""Primero"",
                ""sLast"": ""Último"",
                ""sNext"": ""Siguiente"",
                ""sPrevious"": ""Anterior""
            },
            ""oAria"": {
                ""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
        ");
                WriteLiteral("    },\r\n            \"buttons\": {\r\n                \"copy\": \"Copiar\",\r\n                \"colvis\": \"Visibilidad\"\r\n            }\r\n        }\r\n\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(2987, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TiendaOnline.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
