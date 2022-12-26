using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migratodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carga_carg_desc",
                table: "Carga");

            migrationBuilder.AlterColumn<string>(
                name: "carg_desc",
                table: "Carga",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "carg_cod",
                table: "Carga",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carga_carg_desc",
                table: "Carga",
                column: "carg_desc",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carga_carg_desc",
                table: "Carga");

            migrationBuilder.AlterColumn<string>(
                name: "carg_desc",
                table: "Carga",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "carg_cod",
                table: "Carga",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Carga_carg_desc",
                table: "Carga",
                column: "carg_desc",
                unique: true,
                filter: "[carg_desc] IS NOT NULL");
        }
    }
}
