using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigrationUbigeo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_depa",
                table: "Ubigeo");

            migrationBuilder.DropColumn(
                name: "id_dist",
                table: "Ubigeo");

            migrationBuilder.DropColumn(
                name: "id_prov",
                table: "Ubigeo");

            migrationBuilder.AddColumn<string>(
                name: "ubig_cod",
                table: "Ubigeo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ubig_depa",
                table: "Ubigeo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ubig_dist",
                table: "Ubigeo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ubig_prov",
                table: "Ubigeo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ubig_cod",
                table: "Ubigeo");

            migrationBuilder.DropColumn(
                name: "ubig_depa",
                table: "Ubigeo");

            migrationBuilder.DropColumn(
                name: "ubig_dist",
                table: "Ubigeo");

            migrationBuilder.DropColumn(
                name: "ubig_prov",
                table: "Ubigeo");

            migrationBuilder.AddColumn<int>(
                name: "id_depa",
                table: "Ubigeo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_dist",
                table: "Ubigeo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_prov",
                table: "Ubigeo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
