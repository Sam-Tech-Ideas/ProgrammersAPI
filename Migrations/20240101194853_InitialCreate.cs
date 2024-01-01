using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProgrammersAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    CodeName = table.Column<string>(type: "TEXT", nullable: false),
                    ExperienceYrs = table.Column<int>(type: "INTEGER", nullable: false),
                    MobileDev = table.Column<bool>(type: "INTEGER", nullable: false),
                    PortfolioUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Programmers",
                columns: new[] { "Id", "CodeName", "ExperienceYrs", "FullName", "MobileDev", "PortfolioUrl" },
                values: new object[,]
                {
                    { 1, "KyleSams", 1, "Winfred Agyekum", false, "" },
                    { 2, "", 3, "Samuel", true, "" },
                    { 3, "", 3, "Samuel", true, "" },
                    { 4, "", 3, "Samuel", true, "" },
                    { 5, "", 3, "Samuel", true, "" },
                    { 6, "", 3, "Samuel", true, "" },
                    { 7, "", 3, "Samuel", true, "" },
                    { 8, "", 3, "Samuel", true, "" },
                    { 9, "", 3, "Samuel", true, "" },
                    { 10, "", 3, "Samuel", true, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programmers");
        }
    }
}
