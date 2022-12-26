using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c039566-63ec-4f57-9eae-1a60f986ff8f", "6dd8ba02-f283-4c25-b0a3-d471af0261e7" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=348", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=79", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=393", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=982", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=828", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=874", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=896", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=187", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=746", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=48", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=728", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=664", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=962", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=555", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=812", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=540", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=757", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=934", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=16", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=492", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=357", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=743", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=468", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=883", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=179", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=415", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=189", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=513", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=840", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=578", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=727", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=712", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=729", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=204", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=213", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=756", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=390", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=183", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=940", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=753", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=614", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=986", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=277", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=77", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=729", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=321", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=199", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=789", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=117", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=279", 1, "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d38f734-cca1-4472-bdd3-f789e6a32751", "0137acb4-e62c-44d1-bba7-b5ea837ba49d" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random", 0, null });
        }
    }
}
