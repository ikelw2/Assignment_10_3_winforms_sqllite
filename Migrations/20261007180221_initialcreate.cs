using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment_10_3_winforms_sqllite.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VIN = table.Column<string>(type: "TEXT", nullable: true),
                    Make = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "VIN", "Year" },
                values: new object[,]
                {
                    { 1, "Ford", "Mustang", "1FA6P8CF0HXXXXXXX", 1980 },
                    { 2, "Chevrolet", "Corvette", "1G1AY0780AXXXXXXX", 1980 },
                    { 3, "Toyota", "Celica", "JZA8000XXXXXXXXXX", 1980 },
                    { 4, "Volkswagen", "Beetle", "1V4BA31D0BXXXXXXX", 1980 },
                    { 5, "BMW", "3 Series", "WBAAJ51000XXXXXXX", 1980 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
