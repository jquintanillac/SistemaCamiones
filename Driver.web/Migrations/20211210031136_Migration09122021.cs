using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migration09122021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUsuario_reg",
                table: "Rol_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUsuario_reg",
                table: "Rol_Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
