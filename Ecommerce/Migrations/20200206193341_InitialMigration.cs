using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
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
                    ProductImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
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
                columns: new[] { "ProductId", "Description", "Name", "Price", "ProductImage", "Sku" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Gortex Backpack", 57, "https://source.unsplash.com/random/350×300/?backpack,gortex", "187420-1217" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Tent", 129, "https://source.unsplash.com/random/350×300/?tent", "187420-1217" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Boots", 199, "https://source.unsplash.com/random/350×300/?boots,hiking", "187420-1217" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Sleeping Bag", 99, "https://source.unsplash.com/random/350×300/?sleeping,bag", "187420-1217" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Lantern", 57, "https://source.unsplash.com/random/350×300/?lantern,camping", "187420-1217" },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Cooler", 29, "https://source.unsplash.com/random/900×700/?cooler,camping", "187420-1217" },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Knife", 89, "https://source.unsplash.com/random/300×300/?knife", "187420-1217" },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Stove", 99, "https://source.unsplash.com/random/300×300/?stove,capming", "187420-1217" },
                    { 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Head Lamps", 34, "https://source.unsplash.com/random/350×300/?headlamp", "187420-1217" },
                    { 10, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Smartwatch", 129, "https://source.unsplash.com/random/350×300/?smartwatch", "187420-1217" },
                    { 11, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "GPS", 299, "https://source.unsplash.com/random/350×300/?garmin,gps", "187420-1217" },
                    { 12, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Sleeping Bag", 99, "https://source.unsplash.com/random/350×300/?sleeping,bag", "187420-1217" },
                    { 13, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Camping Cot", 57, "https://source.unsplash.com/random/350×300/?cot,camping", "187420-1217" },
                    { 14, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Whitewater Raft", 629, "https://source.unsplash.com/random/350×300/?raft,river", "187420-1217" },
                    { 15, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", "Hammock", 69, "https://source.unsplash.com/random/350×300/?hammock", "187420-1217" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
