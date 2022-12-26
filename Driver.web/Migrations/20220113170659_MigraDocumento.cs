using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraDocumento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "doccab_tipo",
                table: "Documento_Cabecera",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_vehi",
                table: "Documento_Cabecera",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "doccab_tipo",
                table: "Documento_Cabecera");

            migrationBuilder.DropColumn(
                name: "id_vehi",
                table: "Documento_Cabecera");
        }
    }
}
