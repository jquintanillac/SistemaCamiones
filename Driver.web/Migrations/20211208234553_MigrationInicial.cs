using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Distrito");

            migrationBuilder.DropTable(
                name: "Provincia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    id_depa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depa_act = table.Column<bool>(type: "bit", nullable: false),
                    depa_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    depa_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    dist_act = table.Column<bool>(type: "bit", nullable: false),
                    dist_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dist_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distrito", x => x.id_dist);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    id_prov = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prov_act = table.Column<bool>(type: "bit", nullable: false),
                    prov_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prov_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.id_prov);
                });
        }
    }
}
