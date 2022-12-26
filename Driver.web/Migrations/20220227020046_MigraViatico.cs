using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraViatico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_chofer",
                table: "Viaticos_Cabecera",
                newName: "id_servcab");

            migrationBuilder.AlterColumn<double>(
                name: "viatcab_total",
                table: "Viaticos_Cabecera",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "viatcab_desc",
                table: "Viaticos_Cabecera",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "viatcab_desc",
                table: "Viaticos_Cabecera");

            migrationBuilder.RenameColumn(
                name: "id_servcab",
                table: "Viaticos_Cabecera",
                newName: "id_chofer");

            migrationBuilder.AlterColumn<double>(
                name: "viatcab_total",
                table: "Viaticos_Cabecera",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
