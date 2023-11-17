using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesChemikalia.Migrations
{
    /// <inheritdoc />
    public partial class Uzytecznosc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uzytecznosc",
                table: "Chemikalium",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uzytecznosc",
                table: "Chemikalium");
        }
    }
}
