using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigraViajes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_carga",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "id_ubigeo",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "servdet_cant",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "servdet_desc",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "servdet_nro",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Servicio_Cabecera");

            migrationBuilder.AddColumn<DateTime>(
                name: "servdet_Fecreg",
                table: "Servicio_Detalle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "servdet_cantdet",
                table: "Servicio_Detalle",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "id_cliente",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "id_carga",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_ubigeo_llegada",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_ubigeo_partida",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "servcab_canttotal",
                table: "Servicio_Cabecera",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "servcab_km",
                table: "Servicio_Cabecera",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "servdet_Fecreg",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "servdet_cantdet",
                table: "Servicio_Detalle");

            migrationBuilder.DropColumn(
                name: "id_carga",
                table: "Servicio_Cabecera");

            migrationBuilder.DropColumn(
                name: "id_ubigeo_llegada",
                table: "Servicio_Cabecera");

            migrationBuilder.DropColumn(
                name: "id_ubigeo_partida",
                table: "Servicio_Cabecera");

            migrationBuilder.DropColumn(
                name: "servcab_canttotal",
                table: "Servicio_Cabecera");

            migrationBuilder.DropColumn(
                name: "servcab_km",
                table: "Servicio_Cabecera");

            migrationBuilder.AddColumn<int>(
                name: "id_carga",
                table: "Servicio_Detalle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_ubigeo",
                table: "Servicio_Detalle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "servdet_cant",
                table: "Servicio_Detalle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "servdet_desc",
                table: "Servicio_Detalle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "servdet_nro",
                table: "Servicio_Detalle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_cliente",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Servicio_Cabecera",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
