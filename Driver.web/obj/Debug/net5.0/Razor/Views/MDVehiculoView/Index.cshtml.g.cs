#pragma checksum "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90e9a79ec508cd31adbd3f371ba830e3324e50a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MDVehiculoView_Index), @"mvc.1.0.view", @"/Views/MDVehiculoView/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e9a79ec508cd31adbd3f371ba830e3324e50a2", @"/Views/MDVehiculoView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb910c6e08ead7c8c532fd364a3a2bfafd623ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MDVehiculoView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_Tipcam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_Tipsemi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_cliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_modelo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("id_marca"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml"
  
    ViewData["Title"] = "Vehiculos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a25929", async() => {
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
                <h3 class=""text-center"">VEHICULOS</h3>
            </div>
            <hr />
            <br />
            <div class=""container-fluid"">
                <div class=""row"">
                    <input type=""hidden"" id=""id_vehi""");
            BeginWriteAttribute("value", " value=\"", 929, "\"", 937, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <div class=""form-group col"">
                        <label class=""control-label"">(*) Placa: </label>
                        <input id=""vehi_placa"" placeholder=""Placa"" class=""form-control"" />
                    </div>
                    <div class=""form-group col"">
                        <label class=""control-label"">(*) Kilometraje: </label>
                        <input id=""vehi_km"" placeholder=""Km"" class=""form-control"" />
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group col"">
                        <label class=""control-label"">(*) Año: </label>
                        <input id=""vehi_año"" placeholder=""Año"" class=""form-control"" />
                    </div>
                    <div class=""form-group col"">
                        <label class=""control-label"">(*) Tipo Vehiculo: </label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a28870", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a29158", async() => {
                    WriteLiteral("Seleccione tipo");
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
#line 41 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Tipcam, "id_Tipcam", "Tipcam_desc"));

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
                        <label class=""control-label"">(*) Tipo semiremolque: </label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a211847", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a212136", async() => {
                    WriteLiteral("Seleccione semiremilque");
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
#line 49 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Tipsemi, "id_Tipsemi", "Tipsemi_desc"));

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col\">\r\n                        <label class=\"control-label\">(*) Cliente: </label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a214758", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a215047", async() => {
                    WriteLiteral("Seleccione cliente");
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
#line 55 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml"
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"form-group col\">\r\n                        <label class=\"control-label\">(*) Modelo: </label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a217730", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a218019", async() => {
                    WriteLiteral("Seleccione modelo");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 63 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.modelo, "id_modelo", "modelo_desc"));

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col\">\r\n                        <label class=\"control-label\">(*) Marca: </label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a220630", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e9a79ec508cd31adbd3f371ba830e3324e50a220919", async() => {
                    WriteLiteral("Seleccione marca");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 69 "D:\Proyectos Personales\Camiones\Driver\Driver.web\Views\MDVehiculoView\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.marca, "id_marca", "marca_desc"));

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
                    <div class=""col-md-6"">
                        <div class=""form-group form-check"">
                            <input type=""checkbox"" class=""form-check-input"" id=""vehi_act"" checked=""checked"">
                            <label class=""form-check-label"">Activo</label>
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
    ");
            WriteLiteral(@"        <table id=""tblvehi"" class=""table table-striped table-bordered"" style=""width: 100%"">
                <thead>
                    <tr>
                        <th class=""d-none"">ID</th>
                        <th>Placa</th>
                        <th>Kilometraje</th>
                        <th>Año</th>                       
                        <th class=""d-none"">id_Tipcam</th>
                        <th class=""d-none"">id_Tipsemi</th>
                        <th class=""d-none"">id_cliente</th>
                        <th class=""d-none"">id_modelo</th>
                        <th class=""d-none"">id_marca</th>
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
			$(""#id_Tipcam"").select2({

			});	
            $(""#id_Tipsemi"").select2({

			});	
            $(""#id_cliente"").select2({

			});	
            $(""#id_modelo"").select2({

			});
            $(""#id_marca"").select2({

			});	
		});

        $('#tblvehi').DataTable({
            ""ajax"": {
            ""url"": ""/api/SVMDVehiculo"",
            ""dataSrc"": """"
            },
            ""pageLength"": 15,
             ""language"": {
                ""lengthMenu"": ""Mostrar _MENU_ registros por pagina"",
                ""zeroRecords"": ""No se encontraron registros"",
                ""info"": ""Mostrar pagina _PAGE_ de _PAGES_"",
        ");
                WriteLiteral(@"        ""infoEmpty"": ""No se encontraron registros"",
                ""infoFiltered"": ""(filtrado de _MAX_ registros totales)"",
                ""search"": ""Buscar:"",
                ""paginate"": {
                    ""next"": ""siguiente"",
                    ""previous"": ""Anterior""
                }
            },
            ""scrollX"": true,
            ""responsive"": true,
            ""columns"": [
                { data: 'id_vehi', ""visible"": false },
                { data: 'vehi_placa' },
                { data: 'vehi_km' },
                { data: 'vehi_año' },
                { data: 'id_Tipcam', ""visible"": false },
                { data: 'id_Tipsemi', ""visible"": false },
                { data: 'id_cliente', ""visible"": false },
                { data: 'id_modelo', ""visible"": false  },
                { data: 'id_marca', ""visible"": false  },
                { data: 'vehi_act',
                    ""render"": function (data, type, row){
                        if (row.vehi_act === true) { re");
                WriteLiteral(@"turn 'Activo';	}
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

             var vehi_placa = $(""#vehi_placa"").val();
             var vehi_km = $(""#vehi_km"").val();
             var vehi_año = $(""#vehi_año"").val();
             var id_Tipcam = $(""#id_Tipcam"").val();
             var id_Tipsemi = $(""#id_Tipsemi"").val();
             var id_cliente = $(""#id_cliente"").val();
             var id_modelo = $(""#id_modelo"").val();
             var id_marca = $(""#id_marca"").val();

          ");
                WriteLiteral(@"   if(vehi_placa === '' || vehi_km === '' || vehi_año === '' || id_Tipcam === 'Seleccione tipo' || id_Tipsemi === 'Seleccione semiremilque' || id_cliente === 'Seleccione cliente' || id_modelo === 'Seleccione modelo' || id_marca === 'Seleccione marca'){
					swal('Mensaje de advertencia', 'Complete los campos requeridos', 'error');
			 }
			 else{
                 var mDVehiculo = {
                    id_vehi: $.trim($(""#id_vehi"").val()) == """" ? 0 : $(""#id_vehi"").val(),
                    vehi_placa: $(""#vehi_placa"").val(),
                    vehi_km: $(""#vehi_km"").val(),
                    vehi_año: $(""#vehi_año"").val(),
                    id_Tipcam: $(""#id_Tipcam"").val(),
                    id_Tipsemi: $(""#id_Tipsemi"").val(),
                    id_cliente: $(""#id_cliente"").val(),
                    id_modelo: $(""#id_modelo"").val(),
                    id_marca: $(""#id_marca"").val(),
                    vehi_act: $(""#vehi_act"").prop(""checked"") ? true : false
                };

      ");
                WriteLiteral(@"          $.post(""api/SVMDVehiculo"", { mDVehiculo : mDVehiculo })
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

    function Edit(oVehiculo) {
        $(""#id_vehi"").val(oVehiculo.id_vehi);
        $(""#vehi_placa"").val(oVehiculo.vehi_placa);
        $(""#vehi_km"").val(oVehiculo.vehi_km);
        $(""#vehi_año"").val(oVehiculo.vehi_año);
        $(""#id_Tipcam"").val(oVehiculo.id_Tipcam);
        $(""#id_Tipsemi"").val(oVehiculo.id_Tipsemi);
        $(""#id_cliente"").val(oVehiculo.id_cliente);
        $(""#id_modelo"").val(oVehiculo.id_modelo);
        $(""#id_marca"").val(oVehiculo.id_marca);      
        $(""#vehi_act"").val(oVehiculo.vehi_act);
    }

    function Delete(oVehiculo) {
        var id = oVehiculo.id_");
                WriteLiteral(@"vehi;
        $.ajax({
            url: ""api/SVMDVehiculo/"" + id,
            type: ""DELETE"",
            success: function(result){
                 swal('Mensaje de confirmacion', 'Carga eliminada', 'success');
                 ReloadGrid();
            }
        });
    }

    function Reset() {
        $(""#id_vehi"").val(0);
        $(""#vehi_placa"").val("""");
        $(""#vehi_km"").val("""");
        $(""#vehi_año"").val("""");
        $(""#id_Tipcam"").val("""");
        $(""#id_Tipsemi"").val("""");
        $(""#id_cliente"").val("""");
        $(""#id_modelo"").val("""");
        $(""#id_marca"").val("""");      



    }
    function ReloadGrid() {
        $(""#tblvehi"").DataTable().clear();
        $(""#tblvehi"").DataTable().ajax.reload();
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