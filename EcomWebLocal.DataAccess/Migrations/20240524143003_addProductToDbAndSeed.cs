using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcomWebLocal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDbAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", "Harry Potter, the boy who lived", "9781781106501", 99.0, 90.0, 80.0, 85.0, "Harry Potter and the Sorcerer’s Stone" },
                    { 2, "J.K. Rowling", "Harry Potter, the boy who lived", "9781781106501", 40.0, 30.0, 20.0, 25.0, "Harry Potter and the Sorcerer’s Stone" },
                    { 3, "J.K. Rowling", "Harry Potter, the boy who lived", "9781781106501", 55.0, 50.0, 35.0, 40.0, "Harry Potter and the Sorcerer’s Stone" },
                    { 4, "J.K. Rowling", "Harry Potter, the boy who lived", "9781781106501", 70.0, 65.0, 55.0, 60.0, "Harry Potter and the Sorcerer’s Stone" },
                    { 5, "J.K. Rowling", "Harry Potter, the boy who lived", "9781781106501", 30.0, 27.0, 20.0, 25.0, "Harry Potter and the Sorcerer’s Stone" },
                    { 6, "J.K. Rowling", "Harry Potter, the boy who lived", "9781781106501", 25.0, 23.0, 20.0, 22.0, "Harry Potter and the Sorcerer’s Stone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
