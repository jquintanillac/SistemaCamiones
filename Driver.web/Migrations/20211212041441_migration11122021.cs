using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class migration11122021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Placa");

            migrationBuilder.RenameColumn(
                name: "chofer_brevette",
                table: "Chofer",
                newName: "chofer_nrolicen");

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

            migrationBuilder.AddColumn<string>(
                name: "tipdoc_condpag",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipdoc_nro",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "tipdoc_reqpart",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "chofer_feccese",
                table: "Chofer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "chofer_fecingr",
                table: "Chofer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "chofer_fecnac",
                table: "Chofer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "chofer_incid",
                table: "Chofer",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "chofer_score",
                table: "Chofer",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "id_cliente",
                table: "Chofer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_concontrac",
                table: "Chofer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_espec",
                table: "Chofer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_tiplinc",
                table: "Chofer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Condicion_Contractual",
                columns: table => new
                {
                    id_concontrac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    concontrac_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    concontrac_cod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condicion_Contractual", x => x.id_concontrac);
                });

            migrationBuilder.CreateTable(
                name: "Generales",
                columns: table => new
                {
                    id_gene = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gene_emp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gene_ruc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gene_direc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gene_telef = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generales", x => x.id_gene);
                });

            migrationBuilder.CreateTable(
                name: "Semiremolque",
                columns: table => new
                {
                    id_semire = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Tipcam = table.Column<int>(type: "int", nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    semi_placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semi_marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semi_modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semi_año = table.Column<DateTime>(type: "datetime2", nullable: false),
                    semi_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semiremolque", x => x.id_semire);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Camion",
                columns: table => new
                {
                    id_Tipcam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipcam_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipcam_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipcam_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Camion", x => x.id_Tipcam);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_especialidad",
                columns: table => new
                {
                    id_espec = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    espec_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    espec_cod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_especialidad", x => x.id_espec);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Licencia",
                columns: table => new
                {
                    id_tiplinc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tiplinc_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiplinc_cod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Licencia", x => x.id_tiplinc);
                });

            migrationBuilder.CreateTable(
                name: "Tracto",
                columns: table => new
                {
                    id_tracto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    tracto_placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tracto_marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tracto_modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tracto_año = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tracto_km = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracto", x => x.id_tracto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Condicion_Contractual");

            migrationBuilder.DropTable(
                name: "Generales");

            migrationBuilder.DropTable(
                name: "Semiremolque");

            migrationBuilder.DropTable(
                name: "Tipo_Camion");

            migrationBuilder.DropTable(
                name: "Tipo_especialidad");

            migrationBuilder.DropTable(
                name: "Tipo_Licencia");

            migrationBuilder.DropTable(
                name: "Tracto");

            migrationBuilder.DropColumn(
                name: "tipdoc_entemi",
                table: "Tipo_Documento");

            migrationBuilder.DropColumn(
                name: "tipdoc_fecemi",
                table: "Tipo_Documento");

            migrationBuilder.DropColumn(
                name: "tipdoc_fecven",
                table: "Tipo_Documento");

            migrationBuilder.DropColumn(
                name: "tipdoc_condpag",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "tipdoc_nro",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "tipdoc_reqpart",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "chofer_feccese",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "chofer_fecingr",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "chofer_fecnac",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "chofer_incid",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "chofer_score",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "id_cliente",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "id_concontrac",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "id_espec",
                table: "Chofer");

            migrationBuilder.DropColumn(
                name: "id_tiplinc",
                table: "Chofer");

            migrationBuilder.RenameColumn(
                name: "chofer_nrolicen",
                table: "Chofer",
                newName: "chofer_brevette");

            migrationBuilder.CreateTable(
                name: "Placa",
                columns: table => new
                {
                    id_plac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plac_carreta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plac_nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plac_nro = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placa", x => x.id_plac);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Placa_plac_nro",
                table: "Placa",
                column: "plac_nro",
                unique: true,
                filter: "[plac_nro] IS NOT NULL");
        }
    }
}
