#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDRepuestos_TercerosView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d03abd351e5b84d5baa6cbfd9045f32e6be8aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDRepuestos_TercerosView_Index), @"mvc.1.0.view", @"/Views/MDRepuestos_TercerosView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d03abd351e5b84d5baa6cbfd9045f32e6be8aa", @"/Views/MDRepuestos_TercerosView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDRepuestos_TercerosView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_vehi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDRepuestos_TercerosView\Index.cshtml"
  
	ViewData["Title"] = "Mantenimiento Terceros";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d03abd351e5b84d5baa6cbfd9045f32e6be8aa4955", async() => {
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
				<h3 class=""text-center"">MANTENIMIENTO TERCEROS</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				 <div class=""row"">
					 <input type=""hidden"" id=""id_repter""");
            BeginWriteAttribute("value", " value=\"", 862, "\"", 870, 0);
            EndWriteAttribute();
            WriteLiteral("  />\t\r\n\t\t\t\t\t <div class=\"form-group col\">\r\n                        <label class=\"control-label\">(*) Producto: </label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d03abd351e5b84d5baa6cbfd9045f32e6be8aa7000", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d03abd351e5b84d5baa6cbfd9045f32e6be8aa7288", async() => {
                    WriteLiteral("Seleccione producto");
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
#line 27 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDRepuestos_TercerosView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.producto, "id_product", "product_descr"));

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col\">\r\n                        <label class=\"control-label\">(*) Placa: </label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d03abd351e5b84d5baa6cbfd9045f32e6be8aa9915", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63d03abd351e5b84d5baa6cbfd9045f32e6be8aa10203", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 33 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDRepuestos_TercerosView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.vehiculo, "id_vehi", "vehi_placa"));

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
                        <label class=""control-label"">(*) Cantidad: </label>
                        <input type=""number""  id=""repter_cant"" placeholder=""Cantidad"" class=""form-control"" /> 
                    </div>  	
                   <div class=""form-group col"">
                        <label class=""control-label"">(*) Costo Total: </label>
                        <input type=""number""  id=""repter_costo"" placeholder=""Costo"" class=""form-control"" /> 
                    </div>                   
                </div>
				 <div class=""row"">
				    <div class=""form-group col"">
                        <label class=""control-label"">(*) Descripcion: </label>
                        <textarea id=""repter_desc"" placeholder=""Descripicion"" class=""form-control""></textarea> 
                    </div>		                     
                </div>
				<div class=""row"">
                   	<div class=""form-");
            WriteLiteral(@"group col"">
                        <label class=""control-label"">(*) Fecha ingreso: </label>
                        <input id=""repter_fecreg"" type=""date"" class=""form-control"" />
                    </div>
					<div class=""form-group col"">
                        <label class=""control-label"">(*) Fecha Salida: </label>
                        <input id=""repter_fecsal"" type=""date"" class=""form-control"" />
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
			<table id=""tblrepter"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
	");
            WriteLiteral(@"				<tr>
						<th class=""d-none"">id_repter</th>
						<th class=""d-none"">id_product</th>
						<th class=""d-none"">id_vehi</th>
						<th>Producto</th>
						<th>Placa</th>
						<th>Cantidad</th>
						<th>Costo</th>
						<th>Descripcion</th>
						<th>Fecha ingreso</th>
						<th>Fecha salida</th>
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
				$(""#id_product"").select2({

				});
				$(""#id_vehi"").select2({

				});
			});
			$('#tblrepter').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDRepuestos_Terceros"",
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
                WriteLiteral(@"             ""paginate"": {
                        ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,								
				""columns"": [
					{ data: 'id_repter', ""visible"": false },
					{ data: 'id_vehi', ""visible"": false },
					{ data: 'id_product', ""visible"": false },
					{ data: 'product_descr' },
					{ data: 'vehi_placa' },
					{ data: 'repter_cant' },
					{ data: 'repter_costo' },
					{ data: 'repter_desc' },
					{ data: 'repter_fecreg' },
					{ data: 'repter_fecsal' },
					{
						data: ""id"", render: function (data, type, row, meta) {
							return ""<button class='btn-md btn-primary' onclick='Edit("" + JSON.stringify(row) + "")'>Editar</button>"" +
								   ""<button class='btn-md btn-danger'  onclick='Delete("" + JSON.stringify(row) + "")'>Eliminar</button>"";
						}
					}
				]
			});

			$(""#btnsave"").click(function() {

				var id_product = $(""#id_product"").va");
                WriteLiteral(@"l();
				var	id_vehi = $(""#id_vehi"").val();
				var	repter_cant = $(""#repter_cant"").val();
				var	repter_costo = $(""#repter_costo"").val();
				var	repter_desc = $(""#repter_desc"").val();
				var	repter_fecreg = $(""#repter_fecreg"").val();	
				var	repter_fecsal = $(""#repter_fecsal"").val();

				if(id_product === 'Seleccione producto' || id_vehi === 'Seleccione vehiculo' || repter_cant === '' || repter_costo === '' || repter_desc === '' || repter_fecreg === '' || repter_fecsal === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
				else{
					var oReputer = {
						id_repcam: $.trim($(""#id_repter"").val()) == """" ? 0 : $(""#id_repter"").val(),  
						id_product: $(""#id_product"").val(),
						id_vehi: $(""#id_vehi"").val(),
						repter_cant: $(""#repter_cant"").val(),
						repter_costo: $(""#repter_costo"").val(),
						repter_desc: $(""#repter_desc"").val(),
						repter_fecreg: $(""#repter_fecreg"").val(),	
						repter_fecsal: $(""#repter_fecsal"").val()	
			");
                WriteLiteral(@"		};
				
					$.post(""api/SVMDRepuestos_Terceros"", { oReputer : oReputer })
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

		function Edit(oReputer) {
			$(""#id_repter"").val(oReputer.id_repter);
			$(""#id_product"").val(oReputer.id_product).change();
			$(""#id_vehi"").val(oReputer.id_vehi).change();
			$(""#repter_cant"").val(oReputer.repter_cant);
			$(""#repter_costo"").val(oReputer.repter_costo);
			$(""#repter_desc"").val(oReputer.repter_desc);
			$(""#repter_fecreg"").val(oReputer.repter_fecreg);
			$(""#repter_fecsal"").val(oReputer.repter_fecsal);
		}

		function Delete(oReputer) {
			var id = oReputer.id_repter;		
			$.ajax({
				url: ""api/SVMDRepuestos_Terceros/"" + id,
				type: ""DELETE"",
				success: function(result){										 
					 swal('Mensaje de confirmacion', 'Carga eliminada', 'success');
					");
                WriteLiteral(@" ReloadGrid();
				}
			});											
		}

		function Reset() {
		    $(""#id_repter"").val(0);
			$(""#id_product"").val(0).change();
			$(""#id_vehi"").val(0).change();
			$(""#repter_cant"").val(0);
			$(""#repter_costo"").val(0);
			$(""#repter_desc"").val("""");
			$(""#repter_fecreg"").val("""");
			$(""#repter_fecsal"").val("""");
			
		}
		function ReloadGrid() {
			$(""#tblrepter"").DataTable().clear();
			$(""#tblrepter"").DataTable().ajax.reload();
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