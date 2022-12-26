using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraServicios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_plac",
                table: "Servicio_Detalle",
                newName: "id_vehi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_vehi",
                table: "Servicio_Detalle",
                newName: "id_plac");
        }
    }
}
