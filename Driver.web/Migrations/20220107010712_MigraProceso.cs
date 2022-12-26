using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraProceso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estados_Camion");

            migrationBuilder.CreateTable(
                name: "Proceso",
                columns: table => new
                {
                    id_proces = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proces_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proces_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proces_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceso", x => x.id_proces);
                });

            migrationBuilder.CreateTable(
                name: "Proceso_Estado",
                columns: table => new
                {
                    id_proest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_proces = table.Column<int>(type: "int", nullable: false),
                    id_estad = table.Column<int>(type: "int", nullable: false),
                    proest_obs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceso_Estado", x => x.id_proest);
                });

            migrationBuilder.CreateTable(
                name: "Proceso_vehiculo",
                columns: table => new
                {
                    id_provehi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_vehi = table.Column<int>(type: "int", nullable: false),
                    id_proces = table.Column<int>(type: "int", nullable: false),
                    provehi_totalh = table.Column<double>(type: "float", nullable: false),
                    provehi_obs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceso_vehiculo", x => x.id_provehi);
                });

            migrationBuilder.CreateTable(
                name: "Proceso_Vehiculo_Detalle",
                columns: table => new
                {
                    id_provehidet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_provehi = table.Column<int>(type: "int", nullable: false),
                    provehidet_fecini = table.Column<DateTime>(type: "datetime2", nullable: false),
                    provehidet_fecfin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceso_Vehiculo_Detalle", x => x.id_provehidet);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proceso");

            migrationBuilder.DropTable(
                name: "Proceso_Estado");

            migrationBuilder.DropTable(
                name: "Proceso_vehiculo");

            migrationBuilder.DropTable(
                name: "Proceso_Vehiculo_Detalle");

            migrationBuilder.CreateTable(
                name: "Estados_Camion",
                columns: table => new
                {
                    id_estcam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estcam_fecfin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estcam_fecini = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estcam_obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_estad = table.Column<int>(type: "int", nullable: false),
                    id_vehi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Camion", x => x.id_estcam);
                });
        }
    }
}
