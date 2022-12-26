using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migrationtipodoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipdoc_entemi",
                table: "Tipo_Documento");

            migrationBuilder.DropColumn(
                name: "tipdoc_fecemi",
                table: "Tipo_Documento");

            migrationBuilder.DropColumn(
                name: "tipdoc_fecven",
                table: "Tipo_Documento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tipdoc_entemi",
                table: "Tipo_Documento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tipdoc_fecemi",
                table: "Tipo_Documento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "tipdoc_fecven",
                table: "Tipo_Documento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
