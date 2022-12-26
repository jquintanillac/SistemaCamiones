using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migracion07112021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mantenimiento_Predictivo",
                columns: table => new
                {
                    id_mantpred = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_plac = table.Column<int>(type: "int", nullable: false),
                    id_repuesto = table.Column<int>(type: "int", nullable: false),
                    mantpred_descr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mantpred_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mantpred_fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mantpred_obser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimiento_Predictivo", x => x.id_mantpred);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    id_proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_tipdoc = table.Column<int>(type: "int", nullable: false),
                    prover_razsocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prover_dociden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prover_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.id_proveedor);
                });

            migrationBuilder.CreateTable(
                name: "Viaticos_Cabecera",
                columns: table => new
                {
                    id_viatcab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_chofer = table.Column<int>(type: "int", nullable: false),
                    viatcab_total = table.Column<double>(type: "float", nullable: false),
                    viatcab_obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viatcab_fecentre = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viaticos_Cabecera", x => x.id_viatcab);
                });

            migrationBuilder.CreateTable(
                name: "Viaticos_Detalle",
                columns: table => new
                {
                    id_viatdet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_viatcab = table.Column<int>(type: "int", nullable: false),
                    viatdet_concep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viatdet_monuni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viatdet_fecini = table.Column<DateTime>(type: "datetime2", nullable: false),
                    viajdet_fecfin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viaticos_Detalle", x => x.id_viatdet);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mantenimiento_Predictivo");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Viaticos_Cabecera");

            migrationBuilder.DropTable(
                name: "Viaticos_Detalle");
        }
    }
}
