#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDProveedorView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02446e4a051860ae61855aea9e22b1b1771fdd13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDProveedorView_Index), @"mvc.1.0.view", @"/Views/MDProveedorView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02446e4a051860ae61855aea9e22b1b1771fdd13", @"/Views/MDProveedorView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDProveedorView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDProveedorView\Index.cshtml"
  
	ViewData["Title"] = "Proveedor";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02446e4a051860ae61855aea9e22b1b1771fdd134543", async() => {
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
				<h3 class=""text-center"">PROVEEDOR</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				  <div class=""row"">
					 <input type=""hidden"" id=""id_proveedor""");
            BeginWriteAttribute("value", " value=\"", 840, "\"", 848, 0);
            EndWriteAttribute();
            WriteLiteral(@"  />					
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Razon Social: </label>
						<input id=""prover_razsocial"" placeholder=""Razon Social"" class=""form-control"" />						
					</div>
				 </div>
				 <div class=""row"">
					<div class=""form-group col"">
						<label class=""control-label"">(*) Tipo documento: </label>
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02446e4a051860ae61855aea9e22b1b1771fdd136795", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02446e4a051860ae61855aea9e22b1b1771fdd137083", async() => {
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
#line 33 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDProveedorView\Index.cshtml"
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
						<label class=""control-label"">(*) RUC: </label>
						<input id=""prover_dociden"" placeholder=""Nro. de documento identidad"" class=""form-control"" />						
					</div>														    
				 </div>
				 <div class=""row"">
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Producto: </label>
						<input id=""prover_producto"" placeholder=""Ingrese producto"" class=""form-control"" />						
					</div>	
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Condicion de pago: </label>
						<input id=""prover_condpago"" placeholder=""Ingrese condicion de pago"" class=""form-control"" />						
					</div>	
				 </div>
				 <div class=""row"">
					 <div class=""form-group col"">
						<label class=""control-label"">(*) Direccion: </label>
						<input id=""prover_direccion"" placeholder=""Ingrese direccion"" class=""form-control"" />						
					</div>					
				 </div>
				 <div class=""row"">
					<div class=""col-md-1"">");
            WriteLiteral(@"</div>
					<div class=""col-md-3"" >
						<div class=""form-group form-check"">
							<input type=""checkbox"" class=""form-check-input"" id=""prover_act"" checked=""checked"" >
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
				 <div class=""row"">
					 <div class=""col-md-6"">
						<h6><label>Campos obligatorios(*)</label></h6>
					</div>	
				 </div>
			 </div>
		</div>
	<div class=""card-body"">
			<table id=""tblprov"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th class=""d-none"">ID</th>
						<th class=""d-none"">Tipdoc</th>
						<th>Razon Social</th>
						<th>RUC</th>
						<th>Producto</th>
						<th>Condicion de pago</th>
				");
            WriteLiteral("\t\t<th>Direccion</th>\r\n\t\t\t\t\t\t<th>Activo</th>\r\n\t\t\t\t\t\t<th>Accciones</th>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\t\t\t\t<tbody></tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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


			$('#tblprov').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDProveedor"",
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
                WriteLiteral(@"    ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,								
				""columns"": [
					{ data: 'id_proveedor', ""visible"": false },
					{ data: 'id_tipdoc', ""visible"": false },
					{ data: 'prover_razsocial' },
					{ data: 'prover_dociden' },
					{ data: 'prover_producto' },
					{ data: 'prover_condpago' },
					{ data: 'prover_direccion' },					
					{ data: 'prover_act', 
								""render"": function (data, type, row){
									if (row.prover_act === true) { return 'Activo';	}
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

			$(""#bt");
                WriteLiteral(@"nsave"").click(function() {

				var	id_tipdoc = $(""#id_tipdoc"").val();
				var	prover_razsocial = $(""#prover_razsocial"").val();
				var	prover_dociden = $(""#prover_dociden"").val();
				var	prover_producto = $(""#prover_producto"").val();
				var	prover_condpago = $(""#prover_condpago"").val();	
				var	prover_direccion = $(""#prover_direccion"").val();	

				if(id_tipdoc === 'Seleccione documento' || prover_razsocial === '' || prover_dociden === '' || prover_producto === '' || prover_condpago === '' || prover_direccion === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
				else{
					var mDProveedor = {
						id_proveedor: $.trim($(""#id_proveedor"").val()) == """" ? 0 : $(""#id_proveedor"").val(),  
						id_tipdoc: $(""#id_tipdoc"").val(),
						prover_razsocial: $(""#prover_razsocial"").val(),
						prover_dociden: $(""#prover_dociden"").val(),
						prover_producto: $(""#prover_producto"").val(),
						prover_condpago: $(""#prover_condpago"").val(),	
						prover_");
                WriteLiteral(@"direccion: $(""#prover_direccion"").val(),	
						prover_act: $(""#prover_act"").prop(""checked"") ? true : false				
					};
				
					$.post(""api/SVMDProveedor"", { mDProveedor : mDProveedor })
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

		function Edit(oProver) {
			$(""#id_proveedor"").val(oProver.id_proveedor);			
			$(""#prover_razsocial"").val(oProver.prover_razsocial);
			$(""#prover_dociden"").val(oProver.prover_dociden);
			$(""#prover_producto"").val(oProver.prover_producto);
			$(""#prover_condpago"").val(oProver.prover_condpago);
			$(""#prover_direccion"").val(oProver.prover_direccion);
			$(""#prover_act"").val(oProver.prover_act);
		}

		function Delete(oProver) {
			var id = oProver.id_carga;		
			$.ajax({
				url: ""api/SVMDProveedor/"" + id,
				type: ""DELETE"",
				success: function(result){										 ");
                WriteLiteral(@"
					 swal('Mensaje de confirmacion', 'Carga eliminada', 'success');
					 ReloadGrid();
				}
			});											
		}

		function Reset() {
			$(""#id_proveedor"").val(0);			
			$(""#prover_razsocial"").val("""");
			$(""#prover_dociden"").val("""");
			$(""#prover_producto"").val("""");
			$(""#prover_condpago"").val("""");
			$(""#prover_direccion"").val("""");
			
		}
		function ReloadGrid() {
			$(""#tblprov"").DataTable().clear();
			$(""#tblprov"").DataTable().ajax.reload();
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
