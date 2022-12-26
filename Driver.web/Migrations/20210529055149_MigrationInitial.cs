using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class MigrationInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rol_Usuario",
                columns: table => new
                {
                    Idrol_usua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idrol = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    id_sede = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol_Usuario", x => x.Idrol_usua);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Idrol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rol_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_sede = table.Column<int>(type: "int", nullable: false),
                    Rol_UsuarioIdrol_usua = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Idrol);
                    table.ForeignKey(
                        name: "FK_Rol_Rol_Usuario_Rol_UsuarioIdrol_usua",
                        column: x => x.Rol_UsuarioIdrol_usua,
                        principalTable: "Rol_Usuario",
                        principalColumn: "Idrol_usua",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usua_user = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Usua_nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usua_apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usua_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usua_pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usua_Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usua_act = table.Column<bool>(type: "bit", nullable: false),
                    Usua_imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol_UsuarioIdrol_usua = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_Usuario_Rol_UsuarioIdrol_usua",
                        column: x => x.Rol_UsuarioIdrol_usua,
                        principalTable: "Rol_Usuario",
                        principalColumn: "Idrol_usua",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Rol_UsuarioIdrol_usua",
                table: "Rol",
                column: "Rol_UsuarioIdrol_usua");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Rol_UsuarioIdrol_usua",
                table: "Usuario",
                column: "Rol_UsuarioIdrol_usua");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Usua_user",
                table: "Usuario",
                column: "Usua_user",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Rol_Usuario");
        }
    }
}
