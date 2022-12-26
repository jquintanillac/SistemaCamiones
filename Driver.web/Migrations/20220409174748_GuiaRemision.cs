using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class GuiaRemision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "faccab_guia",
                table: "Factura_Cabecera");

            migrationBuilder.AddColumn<int>(
                name: "id_tipserv",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "servcab_guia",
                table: "Servicio_Cabecera",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_tipserv",
                table: "Servicio_Cabecera");

            migrationBuilder.DropColumn(
                name: "servcab_guia",
                table: "Servicio_Cabecera");

            migrationBuilder.AddColumn<int>(
                name: "faccab_guia",
                table: "Factura_Cabecera",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
