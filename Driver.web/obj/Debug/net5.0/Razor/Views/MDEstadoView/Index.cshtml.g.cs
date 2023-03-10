#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDEstadoView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "939a0c978912157f22bb0c8e5787ed765024dee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDEstadoView_Index), @"mvc.1.0.view", @"/Views/MDEstadoView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"939a0c978912157f22bb0c8e5787ed765024dee5", @"/Views/MDEstadoView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDEstadoView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDEstadoView\Index.cshtml"
  
	ViewData["Title"] = "Estados";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "939a0c978912157f22bb0c8e5787ed765024dee53561", async() => {
                WriteLiteral(@"
	<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css"" />
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
				<h3 class=""text-center"">ESTADOS</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				 <div class=""row"">
					 <input type=""hidden"" id=""id_estad""");
            BeginWriteAttribute("value", " value=\"", 723, "\"", 731, 0);
            EndWriteAttribute();
            WriteLiteral(@"  />	
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Descripcion: </label>
						<input id=""estad_desc"" placeholder=""Descripcion Estado"" class=""form-control"" />						
					</div>
					<div class=""form-group col"">
						<label class=""control-label"">(*) Nro. Orden: </label>
						<input id=""estad_iden"" placeholder=""Nro. Orden"" class=""form-control"" />						
					</div>
				 </div>
				 <div class=""row"">
					<div class=""col-md-1""></div>
					<div class=""col-md-3"" >
						<div class=""form-group form-check"">
							<input type=""checkbox"" class=""form-check-input"" id=""estad_act"" checked=""checked"" >
							<label class=""form-check-label"" >Activo</label>					
						</div>
					</div>											    
				 </div>	
				 <div class=""row"">
					 <div class=""col-md-6"">
						<button id=""btnsave"" class=""btn btn-success btn-sm"">Guardar</button>
						<button id=""btnAddnew"" class=""btn btn-primary btn-sm"">Limpiar Datos</button>	
					</div>	
				 </div>
				 <br />
				 <div c");
            WriteLiteral(@"lass=""row"">
					 <div class=""col-md-6"">
						<h6><label>Campos obligatorios(*)</label></h6>
					</div>	
				 </div>
			 </div>
		</div>
	<div class=""card-body"">
			<table id=""tblesta"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th class=""d-none"">ID</th>
						<th>Descripcion</th>
						<th>Nro. Orden</th>
						<th>Activo</th>
						<th>Accciones</th>
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
	<script type=""text/javascript"">
		$(document).ready(function () {
			$('#tblesta').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDEstados"",
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
                    ""paginate"": {
                        ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true");
                WriteLiteral(@",								
				""columns"": [
					{ data: 'id_estad', ""visible"": false },
					{ data: 'estad_desc' },
					{ data: 'estad_iden' },
					{ data: 'estad_act',
							""render"": function (data, type, row){
							if (row.estad_act === true) { return 'Activo';	}
							else { return 'Inactivo'; }					
						} 						
					},
					{
						data: ""id"", render: function (data, type, row, meta) {
							return ""<button class='btn-md btn-primary' onclick='Edit("" + JSON.stringify(row) + "")'>Editar</button>"" +
								   ""<button class='btn-md btn-danger'  onclick='Delete("" + JSON.stringify(row) + "")'>Eliminar</button>"";
						}
					}
				]
			});

			$(""#btnsave"").click(function() {
				var estad_desc = $(""#estad_desc"").val();
				var estad_iden = $(""#estad_iden"").val();

				if(estad_desc === '' || estad_iden === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
                else{
					var mDEstados = {
						id_estad: $.trim($(""#id_estad"").val()) =");
                WriteLiteral(@"= """" ? 0 : $(""#id_estad"").val(),  
						estad_desc: $(""#estad_desc"").val(),
						estad_iden: $(""#estad_iden"").val(),
						estad_act: $(""#estad_act"").prop(""checked"") ? true : false				
					};
				
					$.post(""api/SVMDEstados"", { mDEstados : mDEstados })
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

		function Edit(oEstado) {
			$(""#id_estad"").val(oEstado.id_estad);
			$(""#estad_desc"").val(oEstado.estad_desc);
			$(""#estad_iden"").val(oEstado.estad_iden);
			$(""#estad_act"").val(oEstado.estad_act);
		}

		function Delete(oEstado) {
			var id = oEstado.id_estad;		
			$.ajax({
				url: ""api/SVMDEstados/"" + id,
				type: ""DELETE"",
				success: function(result){										 
					 swal('Mensaje de confirmacion', 'Carga eliminada', 'success');
					 ReloadGrid();
				}
			});											
		}

		functio");
                WriteLiteral("n Reset() {\r\n\t\t\t$(\"#id_estad\").val(0);\r\n\t\t\t$(\"#estad_desc\").val(\"\");\r\n\t\t\t$(\"#estad_iden\").val(\"\");\r\n\t\t\t\r\n\t\t}\r\n\t\tfunction ReloadGrid() {\r\n\t\t\t$(\"#tblesta\").DataTable().clear();\r\n\t\t\t$(\"#tblesta\").DataTable().ajax.reload();\r\n\t\t}\r\n\r\n\t</script>\r\n");
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
