// <auto-generated />
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
    [Migration("20211109050029_09112021Driver")]
    partial class _09112021Driver
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_carga");

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

                    b.Property<string>("chofer_brevette")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chofer_dni")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("chofer_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_chofer");

                    b.HasIndex("chofer_dni")
                        .IsUnique()
                        .HasFilter("[chofer_dni] IS NOT NULL");

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

                    b.Property<string>("clie_dociden")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("clie_razsocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_tipdoc")
                        .HasColumnType("int");

                    b.HasKey("id_cliente");

                    b.HasIndex("clie_dociden")
                        .IsUnique()
                        .HasFilter("[clie_dociden] IS NOT NULL");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDDepartamento", b =>
                {
                    b.Property<int>("id_depa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("depa_act")
                        .HasColumnType("bit");

                    b.Property<string>("depa_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("depa_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_depa");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDDistrito", b =>
                {
                    b.Property<int>("id_dist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("dist_act")
                        .HasColumnType("bit");

                    b.Property<string>("dist_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dist_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_dist");

                    b.ToTable("Distrito");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDDocumento_Cabecera", b =>
                {
                    b.Property<int>("id_doccab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("doccab_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doccab_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_doccab");

                    b.ToTable("Documento_Cabecera");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDDocumento_Detalle", b =>
                {
                    b.Property<int>("id_docdet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("docdet_alerta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("docdet_fecreg")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("docdet_fecven")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_doccab")
                        .HasColumnType("int");

                    b.Property<int>("id_tipdoc")
                        .HasColumnType("int");

                    b.HasKey("id_docdet");

                    b.ToTable("Documento_Detalle");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDEstados", b =>
                {
                    b.Property<int>("id_estad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("estad_act")
                        .HasColumnType("bit");

                    b.Property<string>("estad_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estad_iden")
                        .HasColumnType("int");

                    b.HasKey("id_estad");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDEstados_Camion", b =>
                {
                    b.Property<int>("id_estcam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("estcam_fecfin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("estcam_fecini")
                        .HasColumnType("datetime2");

                    b.Property<string>("estcam_obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_plac")
                        .HasColumnType("int");

                    b.Property<int>("id_transp")
                        .HasColumnType("int");

                    b.HasKey("id_estcam");

                    b.ToTable("Estados_Camion");
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

            modelBuilder.Entity("Driver.web.Data.Entities.MDPlaca", b =>
                {
                    b.Property<int>("id_plac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("plac_carreta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plac_nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plac_nro")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id_plac");

                    b.HasIndex("plac_nro")
                        .IsUnique()
                        .HasFilter("[plac_nro] IS NOT NULL");

                    b.ToTable("Placa");
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

                    b.Property<string>("prover_dociden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prover_razsocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_proveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDProvincia", b =>
                {
                    b.Property<int>("id_prov")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("prov_act")
                        .HasColumnType("bit");

                    b.Property<string>("prov_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prov_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_prov");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDRepuestos", b =>
                {
                    b.Property<int>("id_repuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

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

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("Rol_UsuarioIdrol_usua")
                        .HasColumnType("int");

                    b.Property<string>("rol_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idrol");

                    b.HasIndex("Rol_UsuarioIdrol_usua");

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

                    b.Property<int>("IdUsuario_reg")
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

            modelBuilder.Entity("Driver.web.Data.Entities.MDTipo_documento", b =>
                {
                    b.Property<int>("id_tipdoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tipdoc_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipdoc_iden")
                        .HasColumnType("int");

                    b.HasKey("id_tipdoc");

                    b.ToTable("Tipo_Documento");
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

                    b.Property<int>("id_depa")
                        .HasColumnType("int");

                    b.Property<int>("id_dist")
                        .HasColumnType("int");

                    b.Property<int>("id_prov")
                        .HasColumnType("int");

                    b.Property<string>("ubig_desc")
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

                    b.Property<int?>("Rol_UsuarioIdrol_usua")
                        .HasColumnType("int");

                    b.Property<string>("Usua_Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Usua_act")
                        .HasColumnType("bit");

                    b.Property<string>("Usua_apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usua_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Rol_UsuarioIdrol_usua");

                    b.HasIndex("Usua_user")
                        .IsUnique();

                    b.ToTable("Usuario");
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

            modelBuilder.Entity("Driver.web.Data.Entities.MDRol", b =>
                {
                    b.HasOne("Driver.web.Data.Entities.MDRol_Usuario", "Rol_Usuario")
                        .WithMany()
                        .HasForeignKey("Rol_UsuarioIdrol_usua");

                    b.Navigation("Rol_Usuario");
                });

            modelBuilder.Entity("Driver.web.Data.Entities.MDUsuario", b =>
                {
                    b.HasOne("Driver.web.Data.Entities.MDRol_Usuario", "Rol_Usuario")
                        .WithMany()
                        .HasForeignKey("Rol_UsuarioIdrol_usua");

                    b.Navigation("Rol_Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
