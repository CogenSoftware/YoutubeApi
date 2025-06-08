using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Toyota");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Ford");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Honda");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fashion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Smartphones");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Men's Fashion");

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Detail Description 1", "Detail Title 1" });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Detail Description 2", "Detail Title 2" });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Detail Description 3", "Detail Title 3" });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Detail Description 4", "Detail Title 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 28, 10, 841, DateTimeKind.Utc).AddTicks(4076), "Product Description 1", 10m, 100m, "Product Title 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 28, 10, 841, DateTimeKind.Utc).AddTicks(5563), "Product Description 2", 20m, 200m, "Product Title 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 28, 10, 841, DateTimeKind.Utc).AddTicks(5566), "Product Description 3", 30m, 300m, "Product Title 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 28, 10, 841, DateTimeKind.Utc).AddTicks(5568), "Product Description 4", 40m, 400m, "Product Title 4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Koyuncu - Özbey");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bademci - Özberk");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Akar , Kutlay and Yetkiner");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Öyle voluptatem quia kulu et labore sit corporis dışarı sandalye. Non lambadaki blanditiis quia lambadaki velit ducimus dignissimos.", "Voluptatem otobüs ve." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Okuma ea quasi oldular dolorem nostrum esse quasi architecto nemo. Nemo dağılımı ipsam incidunt kapının esse dolorem. Çıktılar consequuntur bilgiyasayarı commodi bahar çarpan ipsa voluptatem. İpsam değerli blanditiis kulu. Explicabo aliquam layıkıyla eum nisi.", "Numquam ipsa eve." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Oldular filmini aut çorba bilgiyasayarı aperiam sevindi layıkıyla. Fugit voluptatem reprehenderit. Dolor için otobüs aut incidunt quaerat.", "Sinema fugit ut." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Koştum totam voluptatem mi ea cezbelendi. Sandalye tv perferendis qui oldular sit nihil. Sit esse odio et düşünüyor nostrum beatae.", "Qui ad labore." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 22, 37, 779, DateTimeKind.Utc).AddTicks(962), "Quasi consequatur consequatur commodi. Filmini okuma yazın koşuyorlar bilgiyasayarı tv accusantium yapacakmış. Okuma makinesi sarmal camisi.", 45.73m, 383.30m, "Licensed Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 22, 37, 782, DateTimeKind.Utc).AddTicks(4152), "Ratione filmini quia okuma et. Explicabo ullam yapacakmış eaque okuma exercitationem. Bilgisayarı deleniti kutusu. Beatae sokaklarda velit aspernatur magni ea odit. Dignissimos nesciunt duyulmamış doğru veritatis masaya ab.", 96.03m, 622.13m, "Fantastic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 22, 37, 782, DateTimeKind.Utc).AddTicks(4396), "Mutlu ipsa sunt sevindi sayfası velit sinema velit hesap voluptatem. Quia salladı kalemi. Dicta qui ullam vitae qui illo. İpsum dolorem quis.", 16.19m, 654.70m, "Refined Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 22, 37, 782, DateTimeKind.Utc).AddTicks(4507), "Sequi sokaklarda et beğendim molestiae qui karşıdakine ut. Consequatur aliquid gitti orta sıradanlıktan gül düşünüyor mutlu nostrum.", 88.69m, 138.66m, "Awesome Steel Computer" });
        }
    }
}
