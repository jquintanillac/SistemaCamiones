﻿// <auto-generated />
using System;
using Driver.web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Driver.web.Migrations
{
    [DbContext(typeof(Datacontext))]
    [Migration("20220106031044_MigraVehiculo")]
    partial class MigraVehiculo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Driver.web.Data.Entities.MDCarga", b =>
                {
                    b.Property<int>("id_carga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("carg_act")
                        .HasColumnType("bit");

                    b.Property<string>("carg_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("carg_desc")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id_carga");

                    b.HasIndex("carg_desc")
                        .IsUnique()
                        .HasFilter("[carg_desc] IS NOT NULL");

                    b.ToTable("Carga");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDChofer", b =>
                {
                    b.Property<int>("id_chofer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("chofer_act")
                        .HasColumnType("bit");

                    b.Property<string>("chofer_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("chofer_feccese")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("chofer_fecingr")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("chofer_fecnac")
                        .HasColumnType("datetime2");

                    b.Property<double>("chofer_incid")
                        .HasColumnType("float");

                    b.Property<string>("chofer_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("chofer_score")
                        .HasColumnType("float");

                    b.Property<int>("id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("id_concontrac")
                        .HasColumnType("int");

                    b.Property<int>("id_espec")
                        .HasColumnType("int");

                    b.Property<int>("id_tipempl")
                        .HasColumnType("int");

                    b.HasKey("id_chofer");

                    b.ToTable("Chofer");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDCliente", b =>
                {
                    b.Property<int>("id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("clie_act")
                        .HasColumnType("bit");

                    b.Property<string>("clie_condpag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clie_dociden")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("clie_razsocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clie_reqpart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_tipdoc")
                        .HasColumnType("int");

                    b.HasKey("id_cliente");

                    b.HasIndex("clie_dociden")
                        .IsUnique()
                        .HasFilter("[clie_dociden] IS NOT NULL");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDCombustible", b =>
                {
                    b.Property<int>("id_combu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("combu_cant")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("combu_fecreg")
                        .HasColumnType("datetime2");

                    b.Property<string>("combu_obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("combu_prec")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("id_grifo")
                        .HasColumnType("int");

                    b.Property<int>("id_plac")
                        .HasColumnType("int");

                    b.HasKey("id_combu");

                    b.ToTable("Combustible");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDCondicion_Contractual", b =>
                {
                    b.Property<int>("id_concontrac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("concontrac_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("concontrac_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_concontrac");

                    b.ToTable("Condicion_Contractual");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDDocumento_Cabecera", b =>
                {
                    b.Property<int>("id_doccab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("doccab_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doccab_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("doccab_fecreg")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_chofer")
                        .HasColumnType("int");

                    b.HasKey("id_doccab");

                    b.ToTable("Documento_Cabecera");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDDocumento_Detalle", b =>
                {
                    b.Property<int>("id_docdet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("docdet_alert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("docdet_entemi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("docdet_fecemi")
                        .HasColumnType("datetime2");

                    b.Property<string>("docdet_obse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("docdet_regis")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("docdet_venci")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_doccab")
                        .HasColumnType("int");

                    b.Property<int>("id_tipdoc")
                        .HasColumnType("int");

                    b.HasKey("id_docdet");

                    b.ToTable("Documento_Detalle");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDEspecialidad", b =>
                {
                    b.Property<int>("id_espec")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("espec_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("espec_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_espec");

                    b.ToTable("Tipo_especialidad");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDEstados", b =>
                {
                    b.Property<int>("id_estad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("estad_act")
                        .HasColumnType("bit");

                    b.Property<string>("estad_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estad_iden")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_estad");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDEstados_Camion", b =>
                {
                    b.Property<int>("id_estcam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("estcam_fecfin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("estcam_fecini")
                        .HasColumnType("datetime2");

                    b.Property<string>("estcam_obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_estad")
                        .HasColumnType("int");

                    b.Property<int>("id_vehi")
                        .HasColumnType("int");

                    b.HasKey("id_estcam");

                    b.ToTable("Estados_Camion");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDFactura_Cabecera", b =>
                {
                    b.Property<int>("id_faccab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("faccab_fecreg")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("faccab_fecvenc")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("faccab_igv")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("faccab_monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("faccab_nro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faccab_serie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("faccab_total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("id_servcab")
                        .HasColumnType("int");

                    b.HasKey("id_faccab");

                    b.ToTable("Factura_Cabecera");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDGenerales", b =>
                {
                    b.Property<int>("id_gene")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gene_direc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gene_emp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gene_ruc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gene_telef")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_gene");

                    b.ToTable("Generales");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDGrifo", b =>
                {
                    b.Property<int>("id_grifo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("grifo_act")
                        .HasColumnType("bit");

                    b.Property<string>("grifo_descr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grifo_direc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_grifo");

                    b.ToTable("Grifo");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDInventario", b =>
                {
                    b.Property<int>("id_invet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("invet_act")
                        .HasColumnType("bit");

                    b.Property<int>("invet_cant")
                        .HasColumnType("int");

                    b.Property<string>("invet_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("invet_iden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("invet_prepro")
                        .HasColumnType("float");

                    b.HasKey("id_invet");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDLiquidacion", b =>
                {
                    b.Property<int>("id_liqui")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_servcab")
                        .HasColumnType("int");

                    b.Property<string>("liqui_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("liqui_fecreg")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("liqui_monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id_liqui");

                    b.ToTable("Liquidacion");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDMantenimiento_Predictivo", b =>
                {
                    b.Property<int>("id_mantpred")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_plac")
                        .HasColumnType("int");

                    b.Property<int>("id_repuesto")
                        .HasColumnType("int");

                    b.Property<string>("mantpred_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mantpred_descr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("mantpred_fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("mantpred_obser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_mantpred");

                    b.ToTable("Mantenimiento_Predictivo");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDMarca", b =>
                {
                    b.Property<int>("id_marca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("marca_act")
                        .HasColumnType("bit");

                    b.Property<string>("marca_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marca_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_marca");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDMenu", b =>
                {
                    b.Property<int>("id_menu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("menu_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("menu_iden")
                        .HasColumnType("int");

                    b.HasKey("id_menu");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDModelo", b =>
                {
                    b.Property<int>("id_modelo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("modelo_act")
                        .HasColumnType("bit");

                    b.Property<string>("modelo_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_modelo");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDProveedor", b =>
                {
                    b.Property<int>("id_proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_tipdoc")
                        .HasColumnType("int");

                    b.Property<bool>("prover_act")
                        .HasColumnType("bit");

                    b.Property<string>("prover_condpago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prover_direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prover_dociden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prover_producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prover_razsocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_proveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDRepuestos", b =>
                {
                    b.Property<int>("id_repuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("repus_act")
                        .HasColumnType("bit");

                    b.Property<int>("repus_cant")
                        .HasColumnType("int");

                    b.Property<string>("repus_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("repus_fecing")
                        .HasColumnType("datetime2");

                    b.Property<string>("repus_iden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("repus_preuni")
                        .HasColumnType("float");

                    b.HasKey("id_repuesto");

                    b.ToTable("Repuestos");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDRepuestos_Camion", b =>
                {
                    b.Property<int>("id_repcam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("id_plac")
                        .HasColumnType("int");

                    b.Property<int>("id_repuesto")
                        .HasColumnType("int");

                    b.Property<string>("repcam_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("repcam_fecreg")
                        .HasColumnType("datetime2");

                    b.HasKey("id_repcam");

                    b.ToTable("Repuestos_Camion");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDRol", b =>
                {
                    b.Property<int>("Idrol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("rol_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idrol");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDRol_Permisos", b =>
                {
                    b.Property<int>("id_rolperm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idrol")
                        .HasColumnType("int");

                    b.Property<int>("id_menu")
                        .HasColumnType("int");

                    b.Property<int>("id_submenu")
                        .HasColumnType("int");

                    b.Property<bool>("rolperm_act")
                        .HasColumnType("bit");

                    b.HasKey("id_rolperm");

                    b.ToTable("Rol_Permisos");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDRol_Usuario", b =>
                {
                    b.Property<int>("Idrol_usua")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Idrol")
                        .HasColumnType("int");

                    b.HasKey("Idrol_usua");

                    b.ToTable("Rol_Usuario");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDServicio_Cabecera", b =>
                {
                    b.Property<int>("id_servcab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("id_cliente")
                        .HasColumnType("int");

                    b.Property<string>("servcab_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("servcab_fec")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("servcab_fecreg")
                        .HasColumnType("datetime2");

                    b.Property<double>("servcab_montotal")
                        .HasColumnType("float");

                    b.Property<string>("servcab_nro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servcab_obs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_servcab");

                    b.ToTable("Servicio_Cabecera");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDServicio_Detalle", b =>
                {
                    b.Property<int>("id_servdet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_carga")
                        .HasColumnType("int");

                    b.Property<int>("id_chofer")
                        .HasColumnType("int");

                    b.Property<int>("id_plac")
                        .HasColumnType("int");

                    b.Property<int>("id_servcab")
                        .HasColumnType("int");

                    b.Property<int>("id_transp")
                        .HasColumnType("int");

                    b.Property<int>("id_ubigeo")
                        .HasColumnType("int");

                    b.Property<int>("servdet_cant")
                        .HasColumnType("int");

                    b.Property<string>("servdet_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servdet_nro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("servdet_preunit")
                        .HasColumnType("float");

                    b.HasKey("id_servdet");

                    b.ToTable("Servicio_Detalle");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDSubmenu", b =>
                {
                    b.Property<int>("id_submenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_menu")
                        .HasColumnType("int");

                    b.Property<string>("submenu_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("submenu_iden")
                        .HasColumnType("int");

                    b.HasKey("id_submenu");

                    b.ToTable("Submenu");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDTipo_Semiremolque", b =>
                {
                    b.Property<int>("id_Tipsemi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Tipsemi_act")
                        .HasColumnType("bit");

                    b.Property<string>("Tipsemi_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipsemi_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Tipsemi");

                    b.ToTable("Tipo_Semiremolque");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDTipo_camion", b =>
                {
                    b.Property<int>("id_Tipcam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Tipcam_act")
                        .HasColumnType("bit");

                    b.Property<string>("Tipcam_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipcam_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Tipcam");

                    b.ToTable("Tipo_Camion");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDTipo_documento", b =>
                {
                    b.Property<int>("id_tipdoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("tipdoc_act")
                        .HasColumnType("bit");

                    b.Property<string>("tipdoc_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipdoc_tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_tipdoc");

                    b.ToTable("Tipo_Documento");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDTipo_emple", b =>
                {
                    b.Property<int>("id_tipempl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("tipempl_act")
                        .HasColumnType("bit");

                    b.Property<string>("tipempl_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_tipempl");

                    b.ToTable("Tipo_empleado");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDTipo_licencia", b =>
                {
                    b.Property<int>("id_tiplinc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tiplinc_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tiplinc_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_tiplinc");

                    b.ToTable("Tipo_Licencia");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDTransportista", b =>
                {
                    b.Property<int>("id_transp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("transp_act")
                        .HasColumnType("bit");

                    b.Property<string>("transp_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("transp_doc")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id_transp");

                    b.HasIndex("transp_doc")
                        .IsUnique()
                        .HasFilter("[transp_doc] IS NOT NULL");

                    b.ToTable("Transportista");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDUbigeo", b =>
                {
                    b.Property<int>("id_ubigeo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ubig_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubig_depa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubig_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubig_dist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubig_prov")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_ubigeo");

                    b.ToTable("Ubigeo");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDUsuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Usua_Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Usua_act")
                        .HasColumnType("bit");

                    b.Property<string>("Usua_apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_user")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Usua_user")
                        .IsUnique()
                        .HasFilter("[Usua_user] IS NOT NULL");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDVehiculo", b =>
                {
                    b.Property<int>("id_vehi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_Tipcam")
                        .HasColumnType("int");

                    b.Property<int>("id_Tipsemi")
                        .HasColumnType("int");

                    b.Property<int>("id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("id_marca")
                        .HasColumnType("int");

                    b.Property<int>("id_modelo")
                        .HasColumnType("int");

                    b.Property<bool>("vehi_act")
                        .HasColumnType("bit");

                    b.Property<string>("vehi_año")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehi_km")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehi_placa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_vehi");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDViaticos_Cabecera", b =>
                {
                    b.Property<int>("id_viatcab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_chofer")
                        .HasColumnType("int");

                    b.Property<DateTime>("viatcab_fecentre")
                        .HasColumnType("datetime2");

                    b.Property<string>("viatcab_obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("viatcab_total")
                        .HasColumnType("float");

                    b.HasKey("id_viatcab");

                    b.ToTable("Viaticos_Cabecera");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDViaticos_Detalle", b =>
                {
                    b.Property<int>("id_viatdet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_viatcab")
                        .HasColumnType("int");

                    b.Property<DateTime>("viajdet_fecfin")
                        .HasColumnType("datetime2");

                    b.Property<string>("viatdet_concep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("viatdet_fecini")
                        .HasColumnType("datetime2");

                    b.Property<string>("viatdet_monuni")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_viatdet");

                    b.ToTable("Viaticos_Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
