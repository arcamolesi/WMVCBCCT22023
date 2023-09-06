using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCBCCT22023.Migrations
{
    /// <inheritdoc />
    public partial class atualizasalas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Salas",
                table: "Salas");

            migrationBuilder.RenameTable(
                name: "Salas",
                newName: "Sala");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Sala",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sala",
                table: "Sala",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sala",
                table: "Sala");

            migrationBuilder.RenameTable(
                name: "Sala",
                newName: "Salas");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Salas",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salas",
                table: "Salas",
                column: "id");
        }
    }
}
