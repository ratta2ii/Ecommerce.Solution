using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Total = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    ProductImage = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "OrderId", "Price", "ProductImage", "Sku" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Backpack", null, 57, "https://picsum.photos/200", "187420-1217" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Tent", null, 129, "https://picsum.photos/200", "187420-1217" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Boots", null, 199, "https://picsum.photos/200", "187420-1217" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Sleeping Bag", null, 99, "https://picsum.photos/200", "187420-1217" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
