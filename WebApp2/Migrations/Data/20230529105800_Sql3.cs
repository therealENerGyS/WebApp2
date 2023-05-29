using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp2.Migrations.Data
{
    /// <inheritdoc />
    public partial class Sql3 : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTagEntity",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTagEntity", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductTagEntity_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTagEntity_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" },
                    { 4, "discount" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Apple watch", "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/MKU93_VW_34FR+watch-40-alum-starlight-nc-se_VW_34FR_WF_CO?wid=1400&hei=1400&trim=1%2C0&fmt=p-jpg&qlt=95&.v=1683237043713", "Apple watch series", 249m },
                    { 2, "Table Lamp", "https://media.wigerdals.com/2022/02/Table-lamp-in-teak-2.jpg", "Table Lamp", 30m },
                    { 3, "Laptop Thinkpad Lenovo", "https://www.lenovo.com/medias/lenovo-laptops-thinkpad-E14-gen-4-14-amd-hero.png?context=bWFzdGVyfHJvb3R8Mjc0OTQ4fGltYWdlL3BuZ3xoMDMvaGJhLzE0MDYwNzY4NDI4MDYyLnBuZ3xjNGVkYmNkOTkwOGNjNjc1YzdjNGM5Nzk3MjE4MDFmODg0Y2VkNGQwNjljMzYzYjk2NDFkMDMwYTZjNzk3MGI1", "Laptop Thinkpad Lenovo", 499m },
                    { 4, "Table Lamp", "https://modernity.ams3.cdn.digitaloceanspaces.com/2022/08/7613f256-819x1024.jpg", "Table Lamp", 45m },
                    { 5, "Gumshoes black fashion", "https://www.designboom.com/wp-content/uploads/2018/04/gumshoe-2-818x491.jpg", "Gumshoes black fashion", 89m },
                    { 6, "Woman White Dress", "https://media.dior.com/couture/ecommerce/media/catalog/product/T/L/1674064948_321L25A3608_X0200_E01_GH.jpg", "Woman White Dress", 119m },
                    { 7, "Kettle Water Boiler", "https://www.cremashop.se/media/cache/gallery_image/content/products/wilfa/wk-5/419.jpg", "Kettle Water Boiler", 49m },
                    { 8, "Congee Cooking Rice Cooker", "https://cdn.abicart.com/shop/images/22157092-origpic-aff204/ws35/42135/art35/h7092/4053.jpg", "Congee Cooking Rice Cooker", 149m },
                    { 9, "Woman Black Dress", "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQ6anbJ4z73KFj3oxAJxf8yOEL393b3xQy-9L63YkllIwxDQfTmh97w0uI2mwnurM2FOSvWUOGm_11SUT1croSUzp8-ZvpfQjAyCRkh0euMYXrS8jnZrhCj&usqp=CAE", "Woman Black Dress", 99m },
                    { 10, "Laptop HP", "https://www.elgiganten.se/image/dv_web_D180001002758719/312968/hp-barbar-dator-15-r3-58256-156-barbar-dator.jpg", "Laptop HP", 349m },
                    { 11, "Table Lamp", "https://02.cdn37.se/ak1/images/2.754688/crme-atelier-soft-serve-table-lamp-grande-mocha.jpeg", "Table Lamp", 20m },
                    { 12, "Samsung Watch", "https://images.samsung.com/is/image/samsung/assets/se/2208/pcd/watches/Galaxy_Watch5_mo.png?$264_264_PNG$", "Samsung Watch", 459m },
                    { 13, "Table Lamp - scelerisque tempore", "https://www.boconcept.com/on/demandware.static/-/Sites-master-catalog/default/dwcfe950b0/images/1100000/1106997.jpg", "Table Lamp - scelerisque tempore", 25m },
                    { 14, "Table Lamp - scelerisque tempore", "https://cdn.shopify.com/s/files/1/0337/3871/9365/articles/cult-design-blog-banner-heading-top-10-table-lamps-design-icons15_1140x650.jpg?v=1658359748", "Table Lamp - scelerisque tempore", 49m },
                    { 15, "Apple watch series", "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/apple-watch-se-og-202303?wid=600&hei=315&fmt=jpeg&qlt=95&.v=1677202217654", "Apple watch series", 299m },
                    { 16, "Gumshoes black fashion", "https://footwearnews.com/wp-content/uploads/2018/04/gumshoe_02.jpg", "Gumshoes black fashion", 99m },
                    { 17, "Woman red dress", "https://hips.hearstapps.com/hmg-prod/images/rat-and-b-1587127096.jpg?resize=480:*", "Woman red dress", 139m },
                    { 18, "Kettle water boiler", "https://i5.walmartimages.com/asr/7a2f144a-f0e7-41f8-85e2-a89f684b9590.97045698436cf2c8f293ac63672af5be.jpeg", "Kettle water boiler", 99m },
                    { 19, "Rice cooker", "https://m.media-amazon.com/images/I/71JWnktqA8L._AC_SL1500_.jpg", "Rice cooker", 199m },
                    { 20, "Pizza tomato sauce kebab", "https://foodbydrygast.com/assets/images/recipes/kebab_pizza.webp", "Pizza tomato sauce kebab", 19m }
                });

            migrationBuilder.InsertData(
                table: "ProductTagEntity",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 4, 13 },
                    { 4, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTagEntity_CategoryId",
                table: "ProductTagEntity",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ProductTagEntity");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
