using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Server.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DifficultyId",
                table: "Personas",
                newName: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Personas",
                newName: "DifficultyId");
        }
    }
}
