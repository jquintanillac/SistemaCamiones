#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDDocucabeView\Vehiculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0cf16a0857b8caeb0a13321a12f8ef916d375a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDDocucabeView_Vehiculo), @"mvc.1.0.view", @"/Views/MDDocucabeView/Vehiculo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0cf16a0857b8caeb0a13321a12f8ef916d375a", @"/Views/MDDocucabeView/Vehiculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDDocucabeView_Vehiculo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_vehi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDDocucabeView\Vehiculo.cshtml"
  
	ViewData["Title"] = "Documentos vehiculo";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0cf16a0857b8caeb0a13321a12f8ef916d375a4563", async() => {
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
            WriteLiteral(@"

<br />
<div class=""container-fluid"">
	<div class=""card"">
		<div class=""card-header"">
			 <div class=""div-title"">
				<h3 class=""text-center"">DOCUMENTOS VEHICULOS</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				 <div class=""row"">
					 <input type=""hidden"" id=""id_doccab""");
            BeginWriteAttribute("value", " value=\"", 857, "\"", 865, 0);
            EndWriteAttribute();
            WriteLiteral("  />\r\n\t\t\t\t\t <input type=\"hidden\" id=\"doccab_tipo\" value=\"P\"  />\r\n\t\t\t\t\t <div class=\"form-group col\">\r\n\t\t\t\t\t\t<label class=\"control-label\">(*) Vehiculo: </label>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0cf16a0857b8caeb0a13321a12f8ef916d375a6652", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0cf16a0857b8caeb0a13321a12f8ef916d375a6940", async() => {
                    WriteLiteral("Seleccione vehiculo");
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
#line 28 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDDocucabeView\Vehiculo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.placa, "id_vehi", "vehi_placa"));

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
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t </div>\r\n\t\t\t\t  <div class=\"row\">\r\n\t\t\t\t\t <div class=\"form-group col\">\r\n\t\t\t\t\t\t<label class=\"control-label\">(*) Nro. documento: </label>\r\n\t\t\t\t\t\t<input id=\"doccab_cod\"");
            BeginWriteAttribute("value", " value=\"", 1432, "\"", 1459, 1);
#nullable restore
#line 36 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDDocucabeView\Vehiculo.cshtml"
WriteAttributeValue("", 1440, ViewData["Nrodoc"], 1440, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nro. Documento"" class=""form-control"" />							
					</div>
					<div class=""form-group col"">
						<label class=""control-label"">(*) Descripcion: </label>
						<input id=""doccab_desc"" placeholder=""Descripcion"" class=""form-control"" />						
					</div>														    
				 </div>
				 <div class=""row"">
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
			<table id=""tblchofer"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th class=""d-none"">ID</th>
						<th class=""d-none"">id_vehi</th>
						<th>Vehiculo</th>
						<th>Nro. Documento</th>
						<th>Descripcion</th>
");
            WriteLiteral("\t\t\t\t\t\t<th>Estado</th>\r\n\t\t\t\t\t\t<th>Accciones</th>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\t\t\t\t<tbody></tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css""></script>
	<script src=""https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js""></script>
	<script type=""text/javascript"">
		$(document).ready(function () {
			 $(function () {
				$(""#id_vehi"").select2({

				});	
			});
			var id = $('#doccab_tipo').val();
			$('#tblchofer').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDDocumento_Cabecera/"" + id,
				""dataSrc"": """"				
				},
				""pageLength"": 15,
				 ""language"": {
                    ""lengthMenu"": ""Mostrar _MENU_ registros por pagina"",
                    ""zeroRecords"": ""No se encontraron registros"",
                    ""info"": ""Mostrar pagina _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""No se encontraron registros"",
                    ""infoFiltered"": ""(filtrado de _MAX_ registros totales)"",
                    ""search"": ""Buscar:"",
    ");
                WriteLiteral(@"                ""paginate"": {
                        ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,								
				""columns"": [
					{ data: 'id_doccab', ""visible"": false },
					{ data: 'id_chofer', ""visible"": false },
					{ data: 'chof_nomcomp' },
					{ data: 'doccab_cod' },
					{ data: 'doccab_desc' },
					{ data: 'doccab_est'},
					{
						data: ""id"", render: function (data, type, row, meta) {
							return ""<button class='btn btn-primary btn-sm' onclick='Edit("" + JSON.stringify(row) + "")'>Agregar</button>"" +
								   ""<button class='btn btn-danger btn-sm'  onclick='Delete("" + JSON.stringify(row) + "")'>Eliminar</button>"";
						}
					}
				],
				""rowCallback"": function( row, data, index ) {
								if (data.doccab_est == ""V"") {
									$('td', row).css('background-color', 'Red');
								}
								else if (data.doccab_est == ""P"") {
									$('td', row).c");
                WriteLiteral(@"ss('background-color', 'Yellow');
								}
								else  {
									$('td', row).css('background-color', 'White');
								}
				}		   
			});		

			$(""#btnsave"").click(function() {
				var id_vehi = $(""#id_vehi"").val();
				var	doccab_cod = $(""#doccab_cod"").val();
				var	doccab_tipo = $(""#doccab_tipo"").val();
				var	doccab_desc = $(""#doccab_desc"").val();

				if(id_vehi === 'Seleccione vehiculo' || doccab_cod === '' || doccab_tipo === '' || doccab_desc === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
                else{
					var origin = $(location).attr('origin'); 
					var url = origin + '/api/SVMDDocumento_Cabecera';
					var mDDocumento_Cabecera = {
						id_doccab: $.trim($(""#id_doccab"").val()) == """" ? 0 : $(""#id_doccab"").val(),  
						id_chofer: 0,
						chof_nomcomp: """",
						id_vehi: $(""#id_vehi"").val(),
						vehi_placa: """",
						doccab_cod: $(""#doccab_cod"").val(),
						doccab_tipo: $(""#doccab_tipo"").val(),
						docc");
                WriteLiteral(@"ab_desc: $(""#doccab_desc"").val()
				};
				
				$.post(url, { mDDocumento_Cabecera : mDDocumento_Cabecera })
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

		function Edit(oDoccab) {
			var id = oDoccab.id_doccab;		
			var origin = $(location).attr('origin'); 
			var url = ""/MDDocudetView/Index/"" + id;
		    window.location.href = url;			
		}

		function Delete(oDoccab) {
			var origin = $(location).attr('origin'); 
			var url = origin + '/api/SVMDDocumento_Cabecera/';
			var id = oDoccab.id_doccab;		
			$.ajax({
				url: url + id,
				type: ""DELETE"",
				success: function(result){										 
					 swal('Mensaje de confirmacion', 'Registro eliminado', 'success');
					 ReloadGrid();
				}
			});											
		}

		function Reset() {
			$(""#id_doccab"").val(0)
			$(""#id_chofer"").val(0),
	");
                WriteLiteral("\t\t$(\"#doccab_tipo\").val(\"\"),\r\n\t\t\t$(\"#doccab_desc\").val(\"\")\r\n\t\t\t\r\n\t\t}\r\n\t\tfunction ReloadGrid() {\r\n\t\t\t$(\"#tblchofer\").DataTable().clear();\r\n\t\t\t$(\"#tblchofer\").DataTable().ajax.reload();\r\n\t\t}\r\n\r\n\t</script>\r\n");
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