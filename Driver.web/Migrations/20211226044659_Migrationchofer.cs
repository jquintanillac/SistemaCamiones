using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migrationchofer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chofer_chofer_dni",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "chofer_dni",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "chofer_nrolicen",
                table: "Chofer");

            migrationBuilder.RenameColumn(
                name: "docdet_fecven",
                table: "Documento_Detalle",
                newName: "docdet_venci");

            migrationBuilder.RenameColumn(
                name: "docdet_fecreg",
                table: "Documento_Detalle",
                newName: "docdet_regis");

            migrationBuilder.RenameColumn(
                name: "docdet_alerta",
                table: "Documento_Detalle",
                newName: "docdet_fecemi");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Documento_Cabecera",
                newName: "id_chofer");

            migrationBuilder.AddColumn<string>(
                name: "docdet_alert",
                table: "Documento_Detalle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "docdet_entemi",
                table: "Documento_Detalle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "docdet_obse",
                table: "Documento_Detalle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "doccab_fecreg",
                table: "Documento_Cabecera",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "docdet_alert",
                table: "Documento_Detalle");

            migrationBuilder.DropColumn(
                name: "docdet_entemi",
                table: "Documento_Detalle");

            migrationBuilder.DropColumn(
                name: "docdet_obse",
                table: "Documento_Detalle");

            migrationBuilder.DropColumn(
                name: "doccab_fecreg",
                table: "Documento_Cabecera");

            migrationBuilder.RenameColumn(
                name: "docdet_venci",
                table: "Documento_Detalle",
                newName: "docdet_fecven");

            migrationBuilder.RenameColumn(
                name: "docdet_regis",
                table: "Documento_Detalle",
                newName: "docdet_fecreg");

            migrationBuilder.RenameColumn(
                name: "docdet_fecemi",
                table: "Documento_Detalle",
                newName: "docdet_alerta");

            migrationBuilder.RenameColumn(
                name: "id_chofer",
                table: "Documento_Cabecera",
                newName: "IdUsuario");

            migrationBuilder.AddColumn<string>(
                name: "chofer_dni",
                table: "Chofer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "chofer_nrolicen",
                table: "Chofer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chofer_chofer_dni",
                table: "Chofer",
                column: "chofer_dni",
                unique: true,
                filter: "[chofer_dni] IS NOT NULL");
        }
    }
}
