#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDViatdetView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63e02dad93c8c038d1d14769619c2dc343be76a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDViatdetView_Index), @"mvc.1.0.view", @"/Views/MDViatdetView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63e02dad93c8c038d1d14769619c2dc343be76a", @"/Views/MDViatdetView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDViatdetView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_chofer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDViatdetView\Index.cshtml"
  
	ViewData["Title"] = "Asginacion viaticos";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63e02dad93c8c038d1d14769619c2dc343be76a4576", async() => {
                WriteLiteral(@"
	<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css"" />
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<link href=""https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/css/select2.min.css"" rel=""stylesheet"" />
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
            WriteLiteral("\r\n\r\n<br />\r\n<div class=\"container-fluid\">\r\n\t<div class=\"card\">\r\n\t\t<div class=\"card-header\">\r\n\t\t\t <div class=\"div-title\">\r\n\t\t\t\t<h3 class=\"text-center\">ASIGNAR VIATICOS</h3>\r\n\t\t\t </div>\r\n\t\t\t <hr />\r\n\t\t\t <br />\t\t\r\n\t\t\t <h4>Nro. Viatico: ");
#nullable restore
#line 23 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDViatdetView\Index.cshtml"
                          Write(ViewData["id_viatcab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t <div class=\"container-fluid\">  \r\n\t\t\t\t <div class=\"row\">\t\t\r\n\t\t\t\t\t <input type=\"hidden\" id=\"id_viatdet\"");
            BeginWriteAttribute("value", " value=\"", 910, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral("  />\t\r\n\t\t\t\t\t <input type=\"hidden\" id=\"id_viatcab\"");
            BeginWriteAttribute("value", " value=\"", 968, "\"", 999, 1);
#nullable restore
#line 27 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDViatdetView\Index.cshtml"
WriteAttributeValue("", 976, ViewData["id_viatcab"], 976, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\t\t\t\t\t \r\n\t\t\t\t\t <div class=\"form-group col\">\r\n\t\t\t\t\t\t<label class=\"control-label\">(*) Chofer: </label>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63e02dad93c8c038d1d14769619c2dc343be76a7386", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63e02dad93c8c038d1d14769619c2dc343be76a7674", async() => {
                    WriteLiteral("Seleccione chofer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDViatdetView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.chofer, "id_chofer", "chofer_nomcompleto"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
	    		 <div class=""row"">
					<div class=""form-group col"">
						<label class=""control-label"">(*) Concepto: </label>
						<input id=""viatdet_concep"" placeholder=""Ingrese concepto"" class=""form-control"" />						
					</div>	
					<div class=""form-group col"">
						<label class=""control-label"">(*) Precio unitario: </label>
						<input id=""viatdet_monuni"" type=""number"" step=""0.01"" class=""form-control"" />						
					</div>										    
				 </div>
				 <div class=""row"">
					 <div class=""form-group col"">
                        <label class=""control-label"">(*) Fecha inicio: </label>
                        <input id=""viatdet_fecini"" type=""date"" class=""form-control"" />
                    </div>
					 <div class=""form-group col"">
                        <label class=""control-label"">(*) Fecha fin: </label>
                        <input id=""viajdet_fecfin"" type=""date"" class=""form-control"" />
                    </div>									    
				 </div>
				 <div class");
            WriteLiteral(@"=""row"">
					 <div class=""col-md-6"">
						<button id=""btnsave"" class=""btn btn-success btn-sm"">Guardar</button>
						<button id=""btnAddnew"" class=""btn btn-primary btn-sm"">Limpiar Datos</button>	
					</div>	
				 </div>
				 <br />
				 <div class=""row"">
					 <div class=""col-md-6"">
						<h6><label>Campos obligatorios(*)</label></h6>
					</div>	
				 </div>
			 </div>
		</div>
		<div class=""card-body"">
			<table id=""tblviatdet"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th class=""d-none"">id_viatdet</th>
						<th class=""d-none"">id_viatcab</th>
						<th class=""d-none"">id_chofer</th>
						<th>Chofer</th>	
						<th>Viatico</th>					
						<th>Precio unitario</th>
						<th>Fecha Inicio</th>
						<th>Fecha Fin</th>
						<th>Acciones</th>
					</tr>
				</thead>
				<tbody></tbody>
			</table>
		</div>
	</div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css""></script>
	<script src=""https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js""></script>
	<script type=""text/javascript"">
		$(document).ready(function () {
			$(function () {
				$(""#id_chofer"").select2({

				});	
			});
			//var origin = $(location).attr('origin'); 
			//var url = origin + '/api/SVMDDocumento_Detalle/';
			var id = $(""#id_viatcab"").val();
			$('#tblviatdet').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDViaticos_Detalle/"" + id,
				""dataSrc"": """"				
				},
				""pageLength"": 15,
				 ""language"": {
                    ""lengthMenu"": ""Mostrar _MENU_ registros por pagina"",
                    ""zeroRecords"": ""No se encontraron registros"",
                    ""info"": ""Mostrar pagina _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""No se encontraron registros"",
                    """);
                WriteLiteral(@"infoFiltered"": ""(filtrado de _MAX_ registros totales)"",
                    ""search"": ""Buscar:"",
                    ""paginate"": {
                        ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,								
				""columns"": [
					{ data: 'id_viatdet', ""visible"": false },
					{ data: 'id_viatcab', ""visible"": false },
					{ data: 'id_chofer', ""visible"": false },
					{ data: 'chof_nomcomp' },
					{ data: 'viatdet_concep' },
					{ data: 'viatdet_monuni' },
					{ data: 'viatdet_fecini' },
					{ data: 'viajdet_fecfin' },
					{
						data: ""id"", render: function (data, type, row, meta) {
							return ""<button class='btn btn-primary btn-sm' onclick='Edit("" + JSON.stringify(row) + "")'>Editar</button>"" +
								   ""<button class='btn btn-danger btn-sm'  onclick='Delete("" + JSON.stringify(row) + "")'>Eliminar</button>"";
						}
					}
				]
			});

			$(""#btnsave"").");
                WriteLiteral(@"click(function() {

				var id_viatcab = $(""#id_viatcab"").val();  
				var	id_chofer = $(""#id_chofer"").val();
				var	viatdet_concep = $(""#viatdet_concep"").val();
				var	viatdet_monuni = $(""#viatdet_monuni"").val();
				var	viatdet_fecini = $(""#viatdet_fecini"").val();
				var	viajdet_fecfin = $(""#viajdet_fecfin"").val();

				if(id_viatcab === 'Seleccione viaje' || id_chofer === '' || viatdet_concep === '' || viatdet_monuni === ''  || viatdet_fecini === ''  || viajdet_fecfin === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
				else{
					var origin = $(location).attr('origin'); 
					var url = origin + '/api/SVMDViaticos_Detalle';
					var mDViaticos_Detalle = {
						id_viatdet: $.trim($(""#id_viatdet"").val()) == """" ? 0 : $(""#id_viatdet"").val(),  
						id_viatcab: $(""#id_viatcab"").val(),  
						id_chofer: $(""#id_chofer"").val(),
						viatdet_concep: $(""#viatdet_concep"").val(),
						viatdet_monuni: $(""#viatdet_monuni"").val(),
						viatdet_fe");
                WriteLiteral(@"cini: $(""#viatdet_fecini"").val(),
						viajdet_fecfin: $(""#viajdet_fecfin"").val()
					};
				
					$.post(url, { mDViaticos_Detalle : mDViaticos_Detalle })
					.done(function (data) {
						Reset();
						ReloadGrid();
						swal('Mensaje de confirmacion', 'Registro Grabado', 'success');
					});								
				}			
			});

			$(""#btnAddnew"").click(function(){
				Reset();
			});
		});

		function Edit(oViatdet) {
			$(""#id_viatdet"").val(oViatdet.id_viatdet);
			$(""#id_viatcab"").val(oViatdet.id_viatcab);
			$(""#id_chofer"").val(oViatdet.id_chofer);			
			$(""#viatdet_concep"").val(oViatdet.viatdet_concep);
			$(""#viatdet_monuni"").val(oViatdet.viatdet_monuni);
			$(""#viatdet_fecini"").val(oViatdet.viatdet_fecini);
			$(""#viajdet_fecfin"").val(oViatdet.viajdet_fecfin);
			
		}

		function Delete(oViatdet) {
			var origin = $(location).attr('origin'); 
			var url = origin + '/api/SVMDViaticos_Detalle/';
			var id = oViatdet.id_viatdet;		
			$.ajax({
				url: url + id,
				type: ""DEL");
                WriteLiteral(@"ETE"",
				success: function(result){										 
					 swal('Mensaje de confirmacion', 'Registro eliminado', 'success');
					 ReloadGrid();
				}
			});											
		}

		function Reset() {
			$(""#id_viatdet"").val(0);
			$(""#id_chofer"").val(0).change();			
			$(""#viatdet_concep"").val("""");
			$(""#viatdet_monuni"").val("""");
			$(""#viatdet_fecini"").val("""");
			$(""#viajdet_fecfin"").val("""");
			
		}
		function ReloadGrid() {
			$(""#tblviatdet"").DataTable().clear();
			$(""#tblviatdet"").DataTable().ajax.reload();
		}

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
