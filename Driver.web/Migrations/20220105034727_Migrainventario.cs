using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migrainventario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    id_invet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invet_iden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invet_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invet_cant = table.Column<int>(type: "int", nullable: false),
                    invet_prepro = table.Column<double>(type: "float", nullable: false),
                    invet_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.id_invet);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventario");
        }
    }
}
