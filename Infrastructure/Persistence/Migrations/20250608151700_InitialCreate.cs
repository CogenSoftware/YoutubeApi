using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 8, 15, 16, 58, 944, DateTimeKind.Utc).AddTicks(8512), false, "Kunter - Aybar" },
                    { 2, new DateTime(2025, 6, 8, 15, 16, 58, 950, DateTimeKind.Utc).AddTicks(5262), false, "Kulaksızoğlu, Sarıoğlu and Tunçeri" },
                    { 3, new DateTime(2025, 6, 8, 15, 16, 58, 950, DateTimeKind.Utc).AddTicks(5591), false, "Demirbaş Inc" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 8, 15, 16, 58, 908, DateTimeKind.Utc).AddTicks(7055), false, "Games", 0, 1 },
                    { 2, new DateTime(2025, 6, 8, 15, 16, 58, 910, DateTimeKind.Utc).AddTicks(286), false, "Computers", 0, 1 },
                    { 3, new DateTime(2025, 6, 8, 15, 16, 58, 910, DateTimeKind.Utc).AddTicks(352), false, "Clothing", 1, 1 },
                    { 4, new DateTime(2025, 6, 8, 15, 16, 58, 910, DateTimeKind.Utc).AddTicks(362), false, "Computers", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 8, 15, 16, 58, 918, DateTimeKind.Utc).AddTicks(4102), "Vel sed camisi. Kalemi dolayı okuma gazete voluptatum.", false, "Un enim olduğu." },
                    { 2, 1, new DateTime(2025, 6, 8, 15, 16, 58, 934, DateTimeKind.Utc).AddTicks(1671), "Qui kulu iusto bundan ab et magnam beatae sed. İpsum minima consequatur doğru amet kutusu. Mutlu ipsam ea. Ona eius çıktılar non dicta et qui voluptatem mi gitti. Düşünüyor magni dicta ea çakıl türemiş ötekinden architecto architecto.", false, "Sayfası koştum ipsa." },
                    { 3, 2, new DateTime(2025, 6, 8, 15, 16, 58, 934, DateTimeKind.Utc).AddTicks(2227), "Explicabo karşıdakine et biber suscipit nemo açılmadan. Ut ducimus dicta velit laudantium laudantium illo okuma blanditiis modi. Totam ötekinden aliquid perferendis. Işık koşuyorlar nihil karşıdakine qui dışarı layıkıyla çarpan biber sinema. İncidunt nemo inventore ut düşünüyor dolayı adipisci layıkıyla gazete iure.", false, "De nemo ipsum." },
                    { 4, 2, new DateTime(2025, 6, 8, 15, 16, 58, 934, DateTimeKind.Utc).AddTicks(2530), "Ullam quia deleniti deleniti commodi değirmeni illo aliquam. Doğru ad bahar gidecekmiş quis bahar domates gül eve. Ullam commodi voluptatem sıfat. Sit ut deleniti olduğu oldular koşuyorlar incidunt amet dolayı.", false, "Işık un in." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 8, 15, 16, 58, 938, DateTimeKind.Utc).AddTicks(2617), "İncidunt dağılımı aliquid ab. Voluptatem consequatur quam çarpan enim voluptatem quis sinema suscipit eos. Sed sit çobanın enim. Gülüyorum quia mıknatıslı filmini dignissimos dışarı masanın sandalye açılmadan. Qui karşıdakine esse velit iusto.", 28.73m, false, 313.98m, "Licensed Plastic Chicken" },
                    { 2, 2, new DateTime(2025, 6, 8, 15, 16, 58, 941, DateTimeKind.Utc).AddTicks(9184), "Koştum ullam aut. Praesentium ki esse eaque et duyulmamış dolorem. Rem inventore tempora. Non çıktılar dolorem quia ona blanditiis.", 54.75m, false, 503.77m, "Practical Granite Pants" },
                    { 3, 3, new DateTime(2025, 6, 8, 15, 16, 58, 941, DateTimeKind.Utc).AddTicks(9595), "Yazın çakıl corporis vitae sarmal uzattı quam balıkhaneye duyulmamış. Gülüyorum et nostrum mıknatıslı karşıdakine quis autem.", 93.40m, false, 808.81m, "Small Cotton Bike" },
                    { 4, 1, new DateTime(2025, 6, 8, 15, 16, 58, 941, DateTimeKind.Utc).AddTicks(9749), "Sinema ut orta. Masanın qui sandalye. Layıkıyla iusto çorba consequatur çıktılar veniam.", 45.39m, false, 956.52m, "Licensed Concrete Mouse" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
