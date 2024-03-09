using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektOOP.Migrations
{
    /// <inheritdoc />
    public partial class TrecaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "kategorija",
                table: "Zaposlenici",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kategorija",
                table: "Zaposlenici");
        }
    }
}
