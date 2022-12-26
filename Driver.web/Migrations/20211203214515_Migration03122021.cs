using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migration03122021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Combustible",
                columns: table => new
                {
                    id_combu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_plac = table.Column<int>(type: "int", nullable: false),
                    id_grifo = table.Column<int>(type: "int", nullable: false),
                    combu_obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    combu_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    combu_cant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    combu_prec = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustible", x => x.id_combu);
                });

            migrationBuilder.CreateTable(
                name: "Grifo",
                columns: table => new
                {
                    id_grifo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grifo_descr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grifo_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grifo", x => x.id_grifo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combustible");

            migrationBuilder.DropTable(
                name: "Grifo");
        }
    }
}
