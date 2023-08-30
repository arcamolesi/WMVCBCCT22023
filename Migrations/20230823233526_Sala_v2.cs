using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCBCCT22023.Migrations
{
    /// <inheritdoc />
    public partial class Sala_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Cursos_cursoID",
                table: "Salas");

            migrationBuilder.DropIndex(
                name: "IX_Salas_cursoID",
                table: "Salas");

            migrationBuilder.DropColumn(
                name: "cursoID",
                table: "Salas");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Salas",
                newName: "situacao");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Salas",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "situacao",
                table: "Salas",
                newName: "status");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Salas",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddColumn<int>(
                name: "cursoID",
                table: "Salas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salas_cursoID",
                table: "Salas",
                column: "cursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Cursos_cursoID",
                table: "Salas",
                column: "cursoID",
                principalTable: "Cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
