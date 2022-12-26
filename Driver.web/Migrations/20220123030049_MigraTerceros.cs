using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraTerceros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "repcam_fecsal",
                table: "Repuestos_Camion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Terceros_camion",
                columns: table => new
                {
                    id_repter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_vehi = table.Column<int>(type: "int", nullable: false),
                    id_product = table.Column<int>(type: "int", nullable: false),
                    repter_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repter_cant = table.Column<int>(type: "int", nullable: false),
                    repter_costo = table.Column<double>(type: "float", nullable: false),
                    repter_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    repter_fecsal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terceros_camion", x => x.id_repter);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terceros_camion");

            migrationBuilder.DropColumn(
                name: "repcam_fecsal",
                table: "Repuestos_Camion");
        }
    }
}
