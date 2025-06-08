using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdjustDecimalPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 944, DateTimeKind.Utc).AddTicks(8512), "Kunter - Aybar" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 950, DateTimeKind.Utc).AddTicks(5262), "Kulaksızoğlu, Sarıoğlu and Tunçeri" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 950, DateTimeKind.Utc).AddTicks(5591), "Demirbaş Inc" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 908, DateTimeKind.Utc).AddTicks(7055), "Games" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 910, DateTimeKind.Utc).AddTicks(286), "Computers" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 910, DateTimeKind.Utc).AddTicks(352), "Clothing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 910, DateTimeKind.Utc).AddTicks(362), "Computers" });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 918, DateTimeKind.Utc).AddTicks(4102), "Vel sed camisi. Kalemi dolayı okuma gazete voluptatum.", "Un enim olduğu." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 934, DateTimeKind.Utc).AddTicks(1671), "Qui kulu iusto bundan ab et magnam beatae sed. İpsum minima consequatur doğru amet kutusu. Mutlu ipsam ea. Ona eius çıktılar non dicta et qui voluptatem mi gitti. Düşünüyor magni dicta ea çakıl türemiş ötekinden architecto architecto.", "Sayfası koştum ipsa." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 934, DateTimeKind.Utc).AddTicks(2227), "Explicabo karşıdakine et biber suscipit nemo açılmadan. Ut ducimus dicta velit laudantium laudantium illo okuma blanditiis modi. Totam ötekinden aliquid perferendis. Işık koşuyorlar nihil karşıdakine qui dışarı layıkıyla çarpan biber sinema. İncidunt nemo inventore ut düşünüyor dolayı adipisci layıkıyla gazete iure.", "De nemo ipsum." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 934, DateTimeKind.Utc).AddTicks(2530), "Ullam quia deleniti deleniti commodi değirmeni illo aliquam. Doğru ad bahar gidecekmiş quis bahar domates gül eve. Ullam commodi voluptatem sıfat. Sit ut deleniti olduğu oldular koşuyorlar incidunt amet dolayı.", "Işık un in." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 938, DateTimeKind.Utc).AddTicks(2617), "İncidunt dağılımı aliquid ab. Voluptatem consequatur quam çarpan enim voluptatem quis sinema suscipit eos. Sed sit çobanın enim. Gülüyorum quia mıknatıslı filmini dignissimos dışarı masanın sandalye açılmadan. Qui karşıdakine esse velit iusto.", 28.73m, 313.98m, "Licensed Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 941, DateTimeKind.Utc).AddTicks(9184), "Koştum ullam aut. Praesentium ki esse eaque et duyulmamış dolorem. Rem inventore tempora. Non çıktılar dolorem quia ona blanditiis.", 54.75m, 503.77m, "Practical Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 941, DateTimeKind.Utc).AddTicks(9595), "Yazın çakıl corporis vitae sarmal uzattı quam balıkhaneye duyulmamış. Gülüyorum et nostrum mıknatıslı karşıdakine quis autem.", 93.40m, 808.81m, "Small Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 16, 58, 941, DateTimeKind.Utc).AddTicks(9749), "Sinema ut orta. Masanın qui sandalye. Layıkıyla iusto çorba consequatur çıktılar veniam.", 45.39m, 956.52m, "Licensed Concrete Mouse" });
        }
    }
}
