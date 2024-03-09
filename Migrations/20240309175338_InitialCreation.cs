using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektOOP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ime_zaposlenika = table.Column<string>(type: "TEXT", nullable: false),
                    prezime_zaposlenika = table.Column<string>(type: "TEXT", nullable: false),
                    username_zaposlenika = table.Column<string>(type: "TEXT", nullable: false),
                    password_zaposlenika = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenici", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zaposlenici");
        }
    }
}
