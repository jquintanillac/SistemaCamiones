#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDFaccabView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56f4bb8f25aaa153ad40008676510dd61853d651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDFaccabView_Index), @"mvc.1.0.view", @"/Views/MDFaccabView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56f4bb8f25aaa153ad40008676510dd61853d651", @"/Views/MDFaccabView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDFaccabView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_cliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_servcab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_tipdoc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDFaccabView\Index.cshtml"
  
	ViewData["Title"] = "Facturacion";
	 Layout="~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d6515221", async() => {
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
				<h3 class=""text-center"">FACTURACION</h3>
			 </div>
			 <hr />
			 <br />		
			 <div class=""container-fluid"">  
				 <div class=""row"">
					 <input type=""hidden"" id=""id_faccab""");
            BeginWriteAttribute("value", " value=\"", 840, "\"", 848, 0);
            EndWriteAttribute();
            WriteLiteral("  />\t\r\n\t\t\t\t     <div class=\"form-group col\">\r\n\t\t\t\t\t\t<label class=\"control-label\">(*) Cliente: </label>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d6517232", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d6517520", async() => {
                    WriteLiteral("Seleccione Cliente");
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
#line 27 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDFaccabView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.cliente, "id_cliente", "clie_razsocial"));

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
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group col\">\r\n\t\t\t\t\t\t<label class=\"control-label\">(*) Nro. viaje: </label>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d65110105", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d65110394", async() => {
                    WriteLiteral("Seleccione Viaje");
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
#line 33 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDFaccabView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.viaje, "id_servcab", "servcab_nro"));

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
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t </div>\r\n\t\t\t\t <div class=\"row\">\r\n\t\t\t\t\t<div class=\"form-group col\">\r\n\t\t\t\t\t\t<label class=\"control-label\">(*) Tipo documento: </label>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d65113028", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f4bb8f25aaa153ad40008676510dd61853d65113317", async() => {
                    WriteLiteral("Seleccione tipo documento");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 41 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDFaccabView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.tipodoc, "id_tipdoc", "tipdoc_desc"));

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
						<label class=""control-label"">(*) Serie: </label>
						<input id=""faccab_serie"" placeholder=""Ingrese serie"" class=""form-control"" />						
					</div>	
					<div class=""form-group col"">
						<label class=""control-label"">(*) Nro. Factura: </label>
						<input id=""faccab_nro"" placeholder=""Ingrese factura""  class=""form-control"" />						
					</div>
					<div class=""form-group col"">
						<label class=""control-label"">(*) Nro. Guia: </label>
						<input id=""faccab_guia"" placeholder=""Ingrese Guia""  class=""form-control"" />						
					</div>	
				 </div>	
				 <div class=""row"">
					<div class=""form-group col"">
						<label class=""control-label"">(*) Fecha factura: </label>
						<input id=""faccab_fecreg"" type=""date"" class=""form-control"" />						
					</div>	
					<div class=""form-group col"">
						<label class=""control-label"">(*) Fecha vencimiento: </label>
						<input id=""faccab_fecvenc"" type=""date"" class=""form-control"" />						
				");
            WriteLiteral(@"	</div>										    
				 </div>	
				  <div class=""row"">
					<div class=""form-group col"">
						<label class=""control-label"">(*) Monto: </label>
						<input id=""faccab_monto"" type=""number"" step=""0.01"" class=""form-control"" />						
					</div>	
					<div class=""form-group col"">
						<label class=""control-label"">(*) Igv: </label>
						<input id=""faccab_igv"" type=""number"" step=""0.01"" class=""form-control"" />						
					</div>
					<div class=""form-group col"">
						<label class=""control-label"">(*) Total: </label>
						<input id=""faccab_total"" type=""number"" step=""0.01"" class=""form-control"" />						
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
					</div");
            WriteLiteral(@">	
				 </div>
			 </div>
		</div>
	<div class=""card-body"">
			<table id=""tblfactu"" class=""table table-striped table-bordered"" style=""width: 100%"">
				<thead>
					<tr>
						<th class=""d-none"">id_faccab</th>
						<th class=""d-none"">id_cliente</th>
						<th class=""d-none"">id_servcab</th>
						<th class=""d-none"">id_tipdoc</th>
						<th>Serie</th>
						<th>Nro. Factura</th>
						<th>Fecha Registro</th>
						<th>fecha Vencimiento</th>
						<th>Monto</th>
						<th>Igv</th>
						<th>Monto total</th>
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
				$(""#id_cliente"").select2({

				});	
				$(""#id_servcab"").select2({

				});	
			});

			$('#tblfactu').DataTable({
				""ajax"": {
				""url"": ""/api/SVMDFactura_Cabecera"",
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
                WriteLiteral(@"                 ""paginate"": {
                        ""next"": ""siguiente"",
                        ""previous"": ""Anterior""
                    }
				},
                ""scrollX"": true,
                ""responsive"": true,								
				""columns"": [
					{ data: 'id_faccab', ""visible"": false },
					{ data: 'id_cliente', ""visible"": false },
					{ data: 'id_servcab', ""visible"": false },
					{ data: 'id_tipdoc', ""visible"": false },
					{ data: 'faccab_serie' },
					{ data: 'faccab_nro' },
					{ data: 'faccab_fecreg' },
					{ data: 'faccab_fecvenc' },
					{ data: 'faccab_monto' },
					{ data: 'faccab_igv' },
					{ data: 'faccab_total' },
					{
						data: ""id"", render: function (data, type, row, meta) {
							return ""<button class='btn-md btn-primary' onclick='Edit("" + JSON.stringify(row) + "")'>Editar</button>"" +
								   ""<button class='btn-md btn-danger'  onclick='Delete("" + JSON.stringify(row) + "")'>Eliminar</button>"";
						}
					}
				]
			});

			$(""#btnsave"").click(fu");
                WriteLiteral(@"nction() {
				var	id_cliente = $.trim($(""#id_cliente"").val()) == """" ? 0 : $(""#id_cliente"").val();  
				var	id_servcab = $.trim($(""#id_servcab"").val()) == """" ? 0 : $(""#id_servcab"").val(); 
				var	id_tipdoc = $.trim($(""#id_tipdoc"").val()) == """" ? 0 : $(""#id_tipdoc"").val();
				var	faccab_serie = $(""#faccab_serie"").val();
				var	faccab_nro = $(""#faccab_nro"").val();
				var	faccab_fecreg = $(""#faccab_fecreg"").val();
				var	faccab_fecvenc = $(""#faccab_fecvenc"").val();
				var	faccab_monto =  $(""#faccab_monto"").val();
				var	faccab_igv = $(""#faccab_igv"").val();
				var	faccab_total = $(""#faccab_total"").val();
				
				if(id_cliente === 'Seleccione Cliente' || id_servcab === 'Seleccione Viaje' || id_tipdoc === 'Seleccione tipo documento' || faccab_serie === '' || faccab_nro === '' || faccab_fecreg === '' || faccab_fecvenc === '' || faccab_monto === '' || faccab_igv === '' || faccab_total === ''){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
				}
              ");
                WriteLiteral(@"  else{
					var oMDFactura_Cabecera = {
						id_faccab: $.trim($(""#id_faccab"").val()) == """" ? 0 : $(""#id_faccab"").val(),  
						id_cliente: $.trim($(""#id_cliente"").val()) == """" ? 0 : $(""#id_cliente"").val(),  
						id_servcab: $.trim($(""#id_servcab"").val()) == """" ? 0 : $(""#id_servcab"").val(),  
						id_tipdoc: $.trim($(""#id_tipdoc"").val()) == """" ? 0 : $(""#id_tipdoc"").val(),  
						faccab_serie: $(""#faccab_serie"").val(),
						faccab_nro: $(""#faccab_nro"").val(),
						faccab_fecreg: $(""#faccab_fecreg"").val(),
						faccab_fecvenc: $(""#faccab_fecvenc"").val(),
						faccab_monto: $(""#faccab_monto"").val(),
						faccab_igv: $(""#faccab_igv"").val(),
						faccab_total: $(""#faccab_total"").val()			
					};
				
					$.post(""api/SVMDFactura_Cabecera"", { oMDFactura_Cabecera : oMDFactura_Cabecera })
					.done(function (data) {
						Reset();
						ReloadGrid();
						swal('Mensaje de confirmacion', 'Registro Grabado', 'success');
					});
				}
			});

			$(""#btnAddnew"").click(function(){
");
                WriteLiteral(@"				Reset();
			});
		});

		function Edit(oFactu) {
			$(""#id_faccab"").val(oFactu.id_faccab);
			$(""#id_cliente"").val(oFactu.id_cliente);
			$(""#id_servcab"").val(oFactu.id_servcab);
			$(""#id_tipdoc"").val(oFactu.id_tipdoc);
			$(""#faccab_serie"").val(oFactu.faccab_serie);
			$(""#faccab_nro"").val(oFactu.faccab_nro);
			$(""#faccab_fecreg"").val(oFactu.faccab_fecreg);
			$(""#faccab_fecvenc"").val(oFactu.faccab_fecvenc);
			$(""#faccab_monto"").val(oFactu.faccab_monto);
			$(""#faccab_igv"").val(oFactu.faccab_igv);
			$(""#faccab_total"").val(oFactu.faccab_total);
		}

		function Delete(oFactu) {
			var id = oFactu.id_faccab;		
			$.ajax({
				url: ""api/SVMDFactura_Cabecera/"" + id,
				type: ""DELETE"",
				success: function(result){										 
					 swal('Mensaje de confirmacion', 'Registro eliminado', 'success');
					 ReloadGrid();
				}
			});											
		}

		function Reset() {
			$(""#id_faccab"").val(0);
			$(""#id_cliente"").val(0).change();
			$(""#id_servcab"").val(0).change();
			$(""");
                WriteLiteral(@"#id_tipdoc"").val(0).change();
			$(""#faccab_serie"").val("""");
			$(""#faccab_nro"").val("""");
			$(""#faccab_fecreg"").val("""");
			$(""#faccab_fecvenc"").val("""");
			$(""#faccab_monto"").val(0);
			$(""#faccab_igv"").val(0);
			$(""#faccab_total"").val(0);
			
		}
		function ReloadGrid() {
			$(""#tblfactu"").DataTable().clear();
			$(""#tblfactu"").DataTable().ajax.reload();
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
