using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCBCCT22023.Migrations
{
    /// <inheritdoc />
    public partial class Salas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
