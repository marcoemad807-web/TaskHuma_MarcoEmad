using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Product 1", 100m },
                    { 2, 2, "Product 2", 200m },
                    { 3, 1, "Product 3", 300m },
                    { 4, 2, "Product 4", 400m },
                    { 5, 1, "Product 5", 500m },
                    { 6, 2, "Product 6", 600m },
                    { 7, 1, "Product 7", 700m },
                    { 8, 2, "Product 8", 800m },
                    { 9, 1, "Product 9", 900m },
                    { 10, 2, "Product 10", 1000m },
                    { 11, 1, "Product 11", 1100m },
                    { 12, 2, "Product 12", 1200m },
                    { 13, 1, "Product 13", 1300m },
                    { 14, 2, "Product 14", 1400m },
                    { 15, 1, "Product 15", 1500m },
                    { 16, 2, "Product 16", 1600m },
                    { 17, 1, "Product 17", 1700m },
                    { 18, 2, "Product 18", 1800m },
                    { 19, 1, "Product 19", 1900m },
                    { 20, 2, "Product 20", 2000m },
                    { 21, 1, "Product 21", 2100m },
                    { 22, 2, "Product 22", 2200m },
                    { 23, 1, "Product 23", 2300m },
                    { 24, 2, "Product 24", 2400m },
                    { 25, 1, "Product 25", 2500m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
