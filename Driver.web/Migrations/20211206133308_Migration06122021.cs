using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.web.Migrations
{
    public partial class Migration06122021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rol_Rol_Usuario_Rol_UsuarioIdrol_usua",
                table: "Rol");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Rol_Usuario_Rol_UsuarioIdrol_usua",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_Rol_UsuarioIdrol_usua",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_Usua_user",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Rol_Rol_UsuarioIdrol_usua",
                table: "Rol");

            migrationBuilder.DropColumn(
                name: "Rol_UsuarioIdrol_usua",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Rol_UsuarioIdrol_usua",
                table: "Rol");

            migrationBuilder.AlterColumn<string>(
                name: "Usua_user",
                table: "Usuario",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Usua_pass",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Usua_nombres",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Usua_email",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Usua_apellidos",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Usua_user",
                table: "Usuario",
                column: "Usua_user",
                unique: true,
                filter: "[Usua_user] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuario_Usua_user",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "Usua_user",
                table: "Usuario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usua_pass",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usua_nombres",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usua_email",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usua_apellidos",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol_UsuarioIdrol_usua",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol_UsuarioIdrol_usua",
                table: "Rol",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Rol_UsuarioIdrol_usua",
                table: "Usuario",
                column: "Rol_UsuarioIdrol_usua");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Usua_user",
                table: "Usuario",
                column: "Usua_user",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Rol_UsuarioIdrol_usua",
                table: "Rol",
                column: "Rol_UsuarioIdrol_usua");

            migrationBuilder.AddForeignKey(
                name: "FK_Rol_Rol_Usuario_Rol_UsuarioIdrol_usua",
                table: "Rol",
                column: "Rol_UsuarioIdrol_usua",
                principalTable: "Rol_Usuario",
                principalColumn: "Idrol_usua",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Rol_Usuario_Rol_UsuarioIdrol_usua",
                table: "Usuario",
                column: "Rol_UsuarioIdrol_usua",
                principalTable: "Rol_Usuario",
                principalColumn: "Idrol_usua",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
