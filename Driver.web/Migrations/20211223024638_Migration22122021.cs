using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migration22122021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Semiremolque");

            migrationBuilder.DropTable(
                name: "Tracto");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Estados_Camion");

            migrationBuilder.RenameColumn(
                name: "id_transp",
                table: "Estados_Camion",
                newName: "id_vehi");

            migrationBuilder.RenameColumn(
                name: "id_plac",
                table: "Estados_Camion",
                newName: "id_estad");

            migrationBuilder.AddColumn<int>(
                name: "id_tipempl",
                table: "Chofer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    id_marca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marca_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marca_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.id_marca);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    id_modelo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modelo_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.id_modelo);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_empleado",
                columns: table => new
                {
                    id_tipempl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipempl_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipempl_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_empleado", x => x.id_tipempl);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Semiremolque",
                columns: table => new
                {
                    id_Tipsemi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipsemi_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipsemi_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipsemi_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Semiremolque", x => x.id_Tipsemi);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    id_vehi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Tipcam = table.Column<int>(type: "int", nullable: false),
                    id_Tipsemi = table.Column<int>(type: "int", nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    id_modelo = table.Column<int>(type: "int", nullable: false),
                    id_marca = table.Column<int>(type: "int", nullable: false),
                    vehi_placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehi_km = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehi_año = table.Column<DateTime>(type: "datetime2", nullable: false),
                    semi_act = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.id_vehi);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Tipo_empleado");

            migrationBuilder.DropTable(
                name: "Tipo_Semiremolque");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "id_tipempl",
                table: "Chofer");

            migrationBuilder.RenameColumn(
                name: "id_vehi",
                table: "Estados_Camion",
                newName: "id_transp");

            migrationBuilder.RenameColumn(
                name: "id_estad",
                table: "Estados_Camion",
                newName: "id_plac");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Estados_Camion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Semiremolque",
                columns: table => new
                {
                    id_semire = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Tipcam = table.Column<int>(type: "int", nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    semi_act = table.Column<bool>(type: "bit", nullable: false),
                    semi_año = table.Column<DateTime>(type: "datetime2", nullable: false),
                    semi_marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semi_modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semi_placa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semiremolque", x => x.id_semire);
                });

            migrationBuilder.CreateTable(
                name: "Tracto",
                columns: table => new
                {
                    id_tracto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    tracto_año = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tracto_km = table.Column<double>(type: "float", nullable: false),
                    tracto_marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tracto_modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tracto_placa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracto", x => x.id_tracto);
                });
        }
    }
}
