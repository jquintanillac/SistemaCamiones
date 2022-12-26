using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigrationTipo_Servicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "faccab_guia",
                table: "Factura_Cabecera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tipo_Servicio",
                columns: table => new
                {
                    id_tipserv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipserv_descr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipserv_act = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Servicio", x => x.id_tipserv);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tipo_Servicio");

            migrationBuilder.DropColumn(
                name: "faccab_guia",
                table: "Factura_Cabecera");
        }
    }
}
