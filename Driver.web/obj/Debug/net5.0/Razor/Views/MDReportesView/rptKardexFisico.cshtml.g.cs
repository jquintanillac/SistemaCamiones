#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72db38b0eb3266c5dc6853122053b01e1364a50d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDReportesView_rptKardexFisico), @"mvc.1.0.view", @"/Views/MDReportesView/rptKardexFisico.cshtml")]
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
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\_ViewImports.cshtml"
using Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\_ViewImports.cshtml"
using Driver.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\_ViewImports.cshtml"
using Driver.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72db38b0eb3266c5dc6853122053b01e1364a50d", @"/Views/MDReportesView/rptKardexFisico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDReportesView_rptKardexFisico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "rptKardexFisico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MDReportesView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
  
	ViewData["Title"] = "Kardex Fisico";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72db38b0eb3266c5dc6853122053b01e1364a50d4544", async() => {
                WriteLiteral(@"
	<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/buttons/1.7.0/css/buttons.bootstrap4.min.css"" />
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.2/font/bootstrap-icons.css"">
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<br />
<div class=""container-fluid"">
	<div class=""card"">
		<div class=""card-header"">
			 <div class=""div-title"">
				<h3 class=""text-center"">REPORTE KARDEX FISICO</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72db38b0eb3266c5dc6853122053b01e1364a50d6595", async() => {
                WriteLiteral(@"
				<div class=""row"">
                   <div class=""form-group col"">
						<label class=""control-label"">(*) Fecha Inicio: </label>
						<input id=""Fecini"" name=""Fecini"" type=""date"" class=""form-control"" />						
					</div>
					<div class=""form-group col"">
						<label class=""control-label"">(*) Fecha Fin: </label>
						<input id=""Fecfin"" name=""Fecfin"" type=""date"" class=""form-control"" />						
					</div>
				</div>
				<div class=""row"">
					 <div class=""col-md-6"">
						<button type=""submit"" id=""btnbuscar"" class=""btn btn-success btn-sm"">Buscar</button>			
					</div>	
				 </div>
				");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"    
			 </div>
		</div>
		<div class=""card-body"">
			<table id=""tblkardex"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th>PRODUCTO</th>
						<th>CANTIDAD</th>
						<th>FECHA INGRESO</th>
						<th>FECHA SALIDA</th>						
					</tr>
				</thead>
				<tbody>
");
#nullable restore
#line 56 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
                      foreach (var item in ViewBag.rptKardexFisico) 
					 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t <tr>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 60 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
                           Write(item.product_descr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 63 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
                           Write(item.repus_cant);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 66 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
                           Write(item.repus_fecing);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 69 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
                           Write(item.repcam_fecreg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td> \r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 72 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDReportesView\rptKardexFisico.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/pdfmake.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/vfs_fonts.js""></script>    
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.7.0/js/dataTables.buttons.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.7.0/js/buttons.bootstrap4.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.7.0/js/buttons.html5.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.7.0/js/buttons.print.min.js""></script>
	");
                WriteLiteral(@"<script type=""text/javascript"">
		$(document).ready(function () {
			$('#tblkardex').DataTable({				
				""pageLength"": 15,
				 ""language"": {
                    ""lengthMenu"": ""Mostrar _MENU_ registros por pagina"",
                    ""zeroRecords"": ""No se encontraron registros"",
                    ""info"": ""Mostrar pagina _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""No se encontraron registros"",
                    ""infoFiltered"": ""(filtrado de _MAX_ registros totales)"",
                    ""search"": ""Buscar:"",
                    ""paginate"": {
                        ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,
				""dom"": 'Bfrtilp',
                ""buttons"": [
                    {
                        ""extend"": 'excelHtml5',
                        ""text"": '<i class=""bi bi-file-earmark-excel""></i>',
                        ""titleAttr"": 'Exportar a exce");
                WriteLiteral(@"l',
                        ""className"": 'btn btn-success'
                    },
                    {
                        ""extend"": 'pdfHtml5',
                        ""text"": '<i class=""bi bi-file-earmark-pdf""></i>',
                        ""titleAttr"": 'Exportar a PDF',
                        ""className"": 'btn btn-danger'
                    },
                ]
			});
		
		});
	

	</script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591