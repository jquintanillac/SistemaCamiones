#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDClienteView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4e94cfc262c3d199b37691b23844ed9627e3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDClienteView_Index), @"mvc.1.0.view", @"/Views/MDClienteView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4e94cfc262c3d199b37691b23844ed9627e3b7", @"/Views/MDClienteView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDClienteView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_tipdoc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDClienteView\Index.cshtml"
  
	ViewData["Title"] = "Cliente";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4e94cfc262c3d199b37691b23844ed9627e3b74529", async() => {
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
				<h3 class=""text-center"">CLIENTES</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				 <div class=""row"">
					 <input type=""hidden"" id=""id_cliente""");
            BeginWriteAttribute("value", " value=\"", 834, "\"", 842, 0);
            EndWriteAttribute();
            WriteLiteral(@"  />					
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Razon Social: </label>
						<input id=""clie_razsocial"" placeholder=""Razon Social"" class=""form-control"" />						
					</div>
				 </div>
				 <div class=""row"">
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Tipo documento: </label>
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4e94cfc262c3d199b37691b23844ed9627e3b76776", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4e94cfc262c3d199b37691b23844ed9627e3b77064", async() => {
                    WriteLiteral("Seleccione documento");
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
#line 33 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDClienteView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.tipdoc, "id_tipdoc", "tipdoc_desc"));

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
					<div class=""form-group col"">
						<label class=""control-label"">(*) Numero Documento: </label>
						<input id=""clie_dociden"" placeholder=""Nro. de documento identidad"" class=""form-control"" />						
					</div>														    
				 </div>
				  <div class=""row"">
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Condicion de pago: </label>
						<input id=""clie_condpag"" placeholder=""Condicion de pago"" class=""form-control"" />							
					</div>
					<div class=""form-group col"">
						<label class=""control-label"">(*) Requisitos particulares: </label>
						<input id=""clie_reqpart"" placeholder=""Requisitos particulares"" class=""form-control"" />						
					</div>														    
				 </div>
				 <div class=""row"">
					<div class=""col-md-1""></div>
					<div class=""col-md-3"" >
						<div class=""form-group form-check"">
							<input type=""checkbox"" class=""form-check-input"" id=""clie_act"" checked=""checked"" >
							<label class=""form-check-label"" >Ac");
            WriteLiteral(@"tivo</label>					
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
                 <div class=""row"">
					 <div class=""col-md-6"">
						<h6><label>Campos obligatorios(*)</label></h6>
					</div>	
				 </div>
			 </div>
		</div>
		<div class=""card-body"">
			<table id=""tblclie"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th class=""d-none"">ID</th>
						<th class=""d-none"">Tipdoc</th>
						<th>Razon Social</th>
						<th>Documento Identidad</th>
						<th>Condicion de pago</th>
						<th>Requisitos particulares</th>
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
	<script src=""https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js""></script>
	<script type=""text/javascript"">
		$(document).ready(function () {
			 $(function () {
				$(""#id_tipdoc"").select2({

				});				
			});
			$('#tblclie').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDCliente"",
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
                     ");
                WriteLiteral(@"   ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,								
				""columns"": [
					{ data: 'id_cliente', ""visible"": false },
					{ data: 'id_tipdoc', ""visible"": false  },
					{ data: 'clie_razsocial' },
					{ data: 'clie_dociden' },
				    { data: 'clie_condpag' },
					{ data: 'clie_reqpart' },
					{ data: 'clie_act', 
						""render"": function (data, type, row){
							if (row.clie_act === true) { return 'Activo';	}
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
				
				var id_tipdoc = $(""#id_tip");
                WriteLiteral(@"doc"").val();
				var	clie_razsocial = $(""#clie_razsocial"").val();
				var	clie_dociden = $(""#clie_dociden"").val();
				var	clie_condpag = $(""#clie_condpag"").val();
				var	clie_reqpart = $(""#clie_reqpart"").val();
				if(id_tipdoc === 'Seleccione documento' || clie_razsocial === '' || clie_dociden === '' || clie_condpag === '' || clie_reqpart === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
                else{
					var mDCliente = {
					id_cliente: $.trim($(""#id_cliente"").val()) == """" ? 0 : $(""#id_cliente"").val(),  
					id_tipdoc: $(""#id_tipdoc"").val(),
					clie_razsocial: $(""#clie_razsocial"").val(),
					clie_dociden: $(""#clie_dociden"").val(),
					clie_condpag: $(""#clie_condpag"").val(),
					clie_reqpart: $(""#clie_reqpart"").val(),
					clie_act: $(""#clie_act"").prop(""checked"") ? true : false				
				};
				
				$.post(""api/SVMDCliente"", { mDCliente : mDCliente })
					.done(function (data) {
						Reset();
						ReloadGrid();
						swal");
                WriteLiteral(@"('Mensaje de confirmacion', 'Registro Grabado', 'success');
					});
				}
				
			});

			$(""#btnAddnew"").click(function(){
				Reset();
			});
		});

		function Edit(oCliente) {
			$(""#id_cliente"").val(oCliente.id_cliente);
			$(""#id_tipdoc"").val(oCliente.id_tipdoc);
			$(""#clie_razsocial"").val(oCliente.clie_razsocial);
			$(""#clie_dociden"").val(oCliente.clie_dociden);
			$(""#clie_condpag"").val(oCliente.clie_condpag);
			$(""#clie_reqpart"").val(oCliente.clie_reqpart);
			$(""#clie_act"").val(oCliente.clie_act);
		}

		function Delete(oCliente) {
			var id = oCliente.id_cliente;		
			$.ajax({
				url: ""api/SVMDCliente/"" + id,
				type: ""DELETE"",
				success: function(result){										 
					 swal('Mensaje de confirmacion', 'Carga eliminada', 'success');
					 ReloadGrid();
				}
			});											
		}

		function Reset() {
			$(""#id_cliente"").val(0);
			$(""#id_tipdoc"").val(0);
			$(""#clie_razsocial"").val("""");
			$(""#clie_dociden"").val("""");
			$(""#clie_condpag"").val("""");
		");
                WriteLiteral("\t$(\"#clie_reqpart\").val(\"\");\r\n\t\t\t\r\n\t\t}\r\n\t\tfunction ReloadGrid() {\r\n\t\t\t$(\"#tblclie\").DataTable().clear();\r\n\t\t\t$(\"#tblclie\").DataTable().ajax.reload();\r\n\t\t}\r\n\r\n\t</script>\r\n");
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
