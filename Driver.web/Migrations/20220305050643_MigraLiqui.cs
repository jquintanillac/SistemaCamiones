using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraLiqui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_servcab",
                table: "Liquidacion",
                newName: "id_viatcab");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_viatcab",
                table: "Liquidacion",
                newName: "id_servcab");
        }
    }
}
