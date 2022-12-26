using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigrationCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipdoc_nro",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "tipdoc_reqpart",
                table: "Cliente",
                newName: "clie_reqpart");

            migrationBuilder.RenameColumn(
                name: "tipdoc_condpag",
                table: "Cliente",
                newName: "clie_condpag");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "clie_reqpart",
                table: "Cliente",
                newName: "tipdoc_reqpart");

            migrationBuilder.RenameColumn(
                name: "clie_condpag",
                table: "Cliente",
                newName: "tipdoc_condpag");

            migrationBuilder.AddColumn<int>(
                name: "tipdoc_nro",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
