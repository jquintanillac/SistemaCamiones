using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class _04122021Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipdoc_iden",
                table: "Tipo_Documento");

            migrationBuilder.AddColumn<bool>(
                name: "tipdoc_act",
                table: "Tipo_Documento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "tipdoc_tipo",
                table: "Tipo_Documento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "carg_desc",
                table: "Carga",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Factura_Cabecera",
                columns: table => new
                {
                    id_faccab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    id_servcab = table.Column<int>(type: "int", nullable: false),
                    faccab_serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faccab_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faccab_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faccab_fecvenc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faccab_monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    faccab_igv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    faccab_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura_Cabecera", x => x.id_faccab);
                });

            migrationBuilder.CreateTable(
                name: "Liquidacion",
                columns: table => new
                {
                    id_liqui = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_servcab = table.Column<int>(type: "int", nullable: false),
                    liqui_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    liqui_monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    liqui_fecreg = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidacion", x => x.id_liqui);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carga_carg_desc",
                table: "Carga",
                column: "carg_desc",
                unique: true,
                filter: "[carg_desc] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factura_Cabecera");

            migrationBuilder.DropTable(
                name: "Liquidacion");

            migrationBuilder.DropIndex(
                name: "IX_Carga_carg_desc",
                table: "Carga");

            migrationBuilder.DropColumn(
                name: "tipdoc_act",
                table: "Tipo_Documento");

            migrationBuilder.DropColumn(
                name: "tipdoc_tipo",
                table: "Tipo_Documento");

            migrationBuilder.AddColumn<int>(
                name: "tipdoc_iden",
                table: "Tipo_Documento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "carg_desc",
                table: "Carga",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
