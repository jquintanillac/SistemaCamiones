using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraInventario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "repus_desc",
                table: "Repuestos");

            migrationBuilder.DropColumn(
                name: "invet_iden",
                table: "Inventario");

            migrationBuilder.AddColumn<int>(
                name: "id_product",
                table: "Inventario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_product",
                table: "Inventario");

            migrationBuilder.AddColumn<string>(
                name: "repus_desc",
                table: "Repuestos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "invet_iden",
                table: "Inventario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
