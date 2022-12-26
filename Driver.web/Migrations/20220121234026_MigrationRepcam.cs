using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigrationRepcam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Repuestos_Camion");

            migrationBuilder.RenameColumn(
                name: "id_repuesto",
                table: "Repuestos_Camion",
                newName: "id_vehi");

            migrationBuilder.RenameColumn(
                name: "id_plac",
                table: "Repuestos_Camion",
                newName: "id_product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_vehi",
                table: "Repuestos_Camion",
                newName: "id_repuesto");

            migrationBuilder.RenameColumn(
                name: "id_product",
                table: "Repuestos_Camion",
                newName: "id_plac");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Repuestos_Camion",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
