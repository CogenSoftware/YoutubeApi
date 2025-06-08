using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Koyuncu - Özbey" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bademci - Özberk" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Akar , Kutlay and Yetkiner" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Home" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Music" });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Öyle voluptatem quia kulu et labore sit corporis dışarı sandalye. Non lambadaki blanditiis quia lambadaki velit ducimus dignissimos.", "Voluptatem otobüs ve." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Okuma ea quasi oldular dolorem nostrum esse quasi architecto nemo. Nemo dağılımı ipsam incidunt kapının esse dolorem. Çıktılar consequuntur bilgiyasayarı commodi bahar çarpan ipsa voluptatem. İpsam değerli blanditiis kulu. Explicabo aliquam layıkıyla eum nisi.", "Numquam ipsa eve." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oldular filmini aut çorba bilgiyasayarı aperiam sevindi layıkıyla. Fugit voluptatem reprehenderit. Dolor için otobüs aut incidunt quaerat.", "Sinema fugit ut." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Koştum totam voluptatem mi ea cezbelendi. Sandalye tv perferendis qui oldular sit nihil. Sit esse odio et düşünüyor nostrum beatae.", "Qui ad labore." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 447, DateTimeKind.Utc).AddTicks(2028), "Saygıner and Sons" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 452, DateTimeKind.Utc).AddTicks(5616), "Yeşilkaya - Orbay" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 452, DateTimeKind.Utc).AddTicks(7765), "Babaoğlu, Poyrazoğlu and Özkara" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 414, DateTimeKind.Utc).AddTicks(3566), "Music" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 415, DateTimeKind.Utc).AddTicks(7947), "Grocery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 415, DateTimeKind.Utc).AddTicks(8007), "Beauty" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 415, DateTimeKind.Utc).AddTicks(8012), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 422, DateTimeKind.Utc).AddTicks(6636), "Ki sit sed değirmeni. Mutlu adanaya sed quae aperiam sıla. Telefonu ab quae molestiae umut eos. Numquam beğendim de beğendim.", "Adresini laudantium consequatur." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 437, DateTimeKind.Utc).AddTicks(8665), "Veritatis ad dolores hesap sit anlamsız ekşili mi. Gülüyorum qui gülüyorum koyun vel magni esse. Quae suscipit et exercitationem cezbelendi.", "Cezbelendi sıla nesciunt." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 437, DateTimeKind.Utc).AddTicks(9030), "Bilgiyasayarı umut beatae. Çünkü ve esse tempora numquam commodi. Et sıfat sit umut bilgiyasayarı teldeki et minima dolore sed. Minima sequi sarmal. Consequuntur sevindi rem dağılımı commodi laboriosam perferendis cezbelendi.", "Ötekinden voluptatem bahar." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 437, DateTimeKind.Utc).AddTicks(9165), "Totam sed yapacakmış lakin. Işık quaerat enim eve dolore labore dicta rem ötekinden odit.", "Veniam sed adanaya." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 441, DateTimeKind.Utc).AddTicks(6723), "Sıla göze aut praesentium minima aliquam vitae. Voluptatem quis sokaklarda biber esse dergi exercitationem şafak et. Sit quia aperiam dicta quis ipsum fugit. Suscipit esse lakin iusto sokaklarda oldular molestiae.", 44.51m, 474.39m, "Unbranded Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 445, DateTimeKind.Utc).AddTicks(649), "Quia dicta veritatis. Çıktılar et numquam beğendim kalemi yazın ut ab voluptatem. Sıradanlıktan eaque ut voluptatem sokaklarda bahar beğendim bundan sokaklarda vel. Corporis cezbelendi ve praesentium sit iure voluptatem corporis. Gül sıfat masaya dışarı koyun de.", 43.30m, 440.07m, "Intelligent Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 445, DateTimeKind.Utc).AddTicks(995), "Kapının ut salladı tempora et numquam un amet iusto. Yazın gitti enim totam. Voluptatem eaque voluptatem laudantium biber sinema magnam explicabo sit bilgisayarı.", 38.14m, 618.81m, "Licensed Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 19, 8, 445, DateTimeKind.Utc).AddTicks(1113), "Consectetur voluptatem dignissimos consectetur corporis. Tv quis mıknatıslı umut tempora bilgiyasayarı enim ab ona hesap. Sayfası nemo dolayı exercitationem ullam dolayı nemo sandalye. İçin magni ratione.", 46.47m, 161.12m, "Handcrafted Steel Bike" });
        }
    }
}
