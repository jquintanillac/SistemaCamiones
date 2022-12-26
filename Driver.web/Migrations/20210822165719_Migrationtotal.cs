using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migrationtotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_sede",
                table: "Rol_Usuario",
                newName: "IdUsuario_reg");

            migrationBuilder.RenameColumn(
                name: "id_sede",
                table: "Rol",
                newName: "IdUsuario");

            migrationBuilder.CreateTable(
                name: "Carga",
                columns: table => new
                {
                    id_carga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carg_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carg_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carg_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carga", x => x.id_carga);
                });

            migrationBuilder.CreateTable(
                name: "Chofer",
                columns: table => new
                {
                    id_chofer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chofer_dni = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    chofer_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chofer_apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chofer_brevette = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chofer_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chofer", x => x.id_chofer);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_tipdoc = table.Column<int>(type: "int", nullable: false),
                    clie_razsocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clie_dociden = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    clie_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    id_depa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depa_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    depa_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    depa_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.id_depa);
                });

            migrationBuilder.CreateTable(
                name: "Distrito",
                columns: table => new
                {
                    id_dist = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dist_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dist_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dist_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distrito", x => x.id_dist);
                });

            migrationBuilder.CreateTable(
                name: "Documento_Cabecera",
                columns: table => new
                {
                    id_doccab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    doccab_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doccab_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento_Cabecera", x => x.id_doccab);
                });

            migrationBuilder.CreateTable(
                name: "Documento_Detalle",
                columns: table => new
                {
                    id_docdet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_doccab = table.Column<int>(type: "int", nullable: false),
                    id_tipdoc = table.Column<int>(type: "int", nullable: false),
                    docdet_fecven = table.Column<DateTime>(type: "datetime2", nullable: false),
                    docdet_alerta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    docdet_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento_Detalle", x => x.id_docdet);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    id_estad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    estad_iden = table.Column<int>(type: "int", nullable: false),
                    estad_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estad_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.id_estad);
                });

            migrationBuilder.CreateTable(
                name: "Estados_Camion",
                columns: table => new
                {
                    id_estcam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_plac = table.Column<int>(type: "int", nullable: false),
                    id_transp = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    estcam_fecini = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estcam_fecfin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estcam_obs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Camion", x => x.id_estcam);
                });

            migrationBuilder.CreateTable(
                name: "Placa",
                columns: table => new
                {
                    id_plac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plac_nro = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    plac_carreta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plac_nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placa", x => x.id_plac);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    id_prov = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prov_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prov_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prov_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.id_prov);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    id_repuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    repus_iden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repus_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repus_cant = table.Column<int>(type: "int", nullable: false),
                    repus_preuni = table.Column<double>(type: "float", nullable: false),
                    repus_act = table.Column<bool>(type: "bit", nullable: false),
                    repus_fecing = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.id_repuesto);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos_Camion",
                columns: table => new
                {
                    id_repcam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_repuesto = table.Column<int>(type: "int", nullable: false),
                    id_plac = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    repcam_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repcam_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos_Camion", x => x.id_repcam);
                });

            migrationBuilder.CreateTable(
                name: "Servicio_Cabecera",
                columns: table => new
                {
                    id_servcab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    servcab_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servcab_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servcab_fec = table.Column<DateTime>(type: "datetime2", nullable: false),
                    servcab_montotal = table.Column<double>(type: "float", nullable: false),
                    servcab_obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servcab_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio_Cabecera", x => x.id_servcab);
                });

            migrationBuilder.CreateTable(
                name: "Servicio_Detalle",
                columns: table => new
                {
                    id_servdet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_servcab = table.Column<int>(type: "int", nullable: false),
                    id_transp = table.Column<int>(type: "int", nullable: false),
                    id_chofer = table.Column<int>(type: "int", nullable: false),
                    id_plac = table.Column<int>(type: "int", nullable: false),
                    id_ubigeo = table.Column<int>(type: "int", nullable: false),
                    id_carga = table.Column<int>(type: "int", nullable: false),
                    servdet_cant = table.Column<int>(type: "int", nullable: false),
                    servdet_preunit = table.Column<double>(type: "float", nullable: false),
                    servdet_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servdet_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio_Detalle", x => x.id_servdet);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Documento",
                columns: table => new
                {
                    id_tipdoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipdoc_iden = table.Column<int>(type: "int", nullable: false),
                    tipdoc_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Documento", x => x.id_tipdoc);
                });

            migrationBuilder.CreateTable(
                name: "Transportista",
                columns: table => new
                {
                    id_transp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transp_doc = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    transp_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transp_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportista", x => x.id_transp);
                });

            migrationBuilder.CreateTable(
                name: "Ubigeo",
                columns: table => new
                {
                    id_ubigeo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_depa = table.Column<int>(type: "int", nullable: false),
                    id_prov = table.Column<int>(type: "int", nullable: false),
                    id_dist = table.Column<int>(type: "int", nullable: false),
                    ubig_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeo", x => x.id_ubigeo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chofer_chofer_dni",
                table: "Chofer",
                column: "chofer_dni",
                unique: true,
                filter: "[chofer_dni] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_clie_dociden",
                table: "Cliente",
                column: "clie_dociden",
                unique: true,
                filter: "[clie_dociden] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Placa_plac_nro",
                table: "Placa",
                column: "plac_nro",
                unique: true,
                filter: "[plac_nro] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transportista_transp_doc",
                table: "Transportista",
                column: "transp_doc",
                unique: true,
                filter: "[transp_doc] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carga");

            migrationBuilder.DropTable(
                name: "Chofer");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Distrito");

            migrationBuilder.DropTable(
                name: "Documento_Cabecera");

            migrationBuilder.DropTable(
                name: "Documento_Detalle");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Estados_Camion");

            migrationBuilder.DropTable(
                name: "Placa");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "Repuestos_Camion");

            migrationBuilder.DropTable(
                name: "Servicio_Cabecera");

            migrationBuilder.DropTable(
                name: "Servicio_Detalle");

            migrationBuilder.DropTable(
                name: "Tipo_Documento");

            migrationBuilder.DropTable(
                name: "Transportista");

            migrationBuilder.DropTable(
                name: "Ubigeo");

            migrationBuilder.RenameColumn(
                name: "IdUsuario_reg",
                table: "Rol_Usuario",
                newName: "id_sede");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Rol",
                newName: "id_sede");
        }
    }
}
