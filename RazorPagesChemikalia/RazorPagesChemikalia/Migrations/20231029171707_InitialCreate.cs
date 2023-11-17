using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesChemikalia.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chemikalium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOdkrycia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rozpuszczalnosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toksycznosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zapach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanSkupienia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemperaturaTopnienia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemikalium", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chemikalium");
        }
    }
}
