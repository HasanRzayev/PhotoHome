using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class jnininininnin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74a1f39b-d9a1-4cd7-99d4-f4056defcb95", "9aa860cc-696f-4a81-98ce-aef67c4327fe" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=136", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=125", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=385", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=130", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=59", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=307", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=265", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=462", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=212", "Super", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Title", "catagory_id", "user_id" },
                values: new object[] { "Bomba", "https://source.unsplash.com/random/200x200?sig=517", "Super", 1, "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Images");

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
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=348", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=79", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=393", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=982", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=828", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=874", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=896", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=187", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=746", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=48", 0, null });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "DownloadCount", "ImageUrl", "LikeCount", "catagory_id", "user_id" },
                values: new object[,]
                {
                    { 11, 24, "https://source.unsplash.com/random/200x200?sig=728", 24, 0, null },
                    { 12, 24, "https://source.unsplash.com/random/200x200?sig=664", 24, 0, null },
                    { 13, 24, "https://source.unsplash.com/random/200x200?sig=962", 24, 0, null },
                    { 14, 24, "https://source.unsplash.com/random/200x200?sig=555", 24, 0, null },
                    { 15, 24, "https://source.unsplash.com/random/200x200?sig=812", 24, 0, null },
                    { 16, 24, "https://source.unsplash.com/random/200x200?sig=540", 24, 0, null },
                    { 17, 24, "https://source.unsplash.com/random/200x200?sig=757", 24, 0, null },
                    { 18, 24, "https://source.unsplash.com/random/200x200?sig=934", 24, 0, null },
                    { 19, 24, "https://source.unsplash.com/random/200x200?sig=16", 24, 0, null },
                    { 20, 24, "https://source.unsplash.com/random/200x200?sig=492", 24, 0, null },
                    { 21, 24, "https://source.unsplash.com/random/200x200?sig=357", 24, 0, null },
                    { 22, 24, "https://source.unsplash.com/random/200x200?sig=743", 24, 0, null },
                    { 23, 24, "https://source.unsplash.com/random/200x200?sig=468", 24, 0, null },
                    { 24, 24, "https://source.unsplash.com/random/200x200?sig=883", 24, 0, null },
                    { 25, 24, "https://source.unsplash.com/random/200x200?sig=179", 24, 0, null },
                    { 26, 24, "https://source.unsplash.com/random/200x200?sig=415", 24, 0, null },
                    { 27, 24, "https://source.unsplash.com/random/200x200?sig=189", 24, 0, null },
                    { 28, 24, "https://source.unsplash.com/random/200x200?sig=513", 24, 0, null },
                    { 29, 24, "https://source.unsplash.com/random/200x200?sig=840", 24, 0, null },
                    { 30, 24, "https://source.unsplash.com/random/200x200?sig=578", 24, 0, null },
                    { 31, 24, "https://source.unsplash.com/random/200x200?sig=727", 24, 0, null },
                    { 32, 24, "https://source.unsplash.com/random/200x200?sig=712", 24, 0, null },
                    { 33, 24, "https://source.unsplash.com/random/200x200?sig=729", 24, 0, null },
                    { 34, 24, "https://source.unsplash.com/random/200x200?sig=204", 24, 0, null },
                    { 35, 24, "https://source.unsplash.com/random/200x200?sig=213", 24, 0, null },
                    { 36, 24, "https://source.unsplash.com/random/200x200?sig=756", 24, 0, null },
                    { 37, 24, "https://source.unsplash.com/random/200x200?sig=390", 24, 0, null },
                    { 38, 24, "https://source.unsplash.com/random/200x200?sig=183", 24, 0, null },
                    { 39, 24, "https://source.unsplash.com/random/200x200?sig=940", 24, 0, null },
                    { 40, 24, "https://source.unsplash.com/random/200x200?sig=753", 24, 0, null },
                    { 41, 24, "https://source.unsplash.com/random/200x200?sig=614", 24, 0, null },
                    { 42, 24, "https://source.unsplash.com/random/200x200?sig=986", 24, 0, null },
                    { 43, 24, "https://source.unsplash.com/random/200x200?sig=277", 24, 0, null },
                    { 44, 24, "https://source.unsplash.com/random/200x200?sig=77", 24, 0, null },
                    { 45, 24, "https://source.unsplash.com/random/200x200?sig=729", 24, 0, null },
                    { 46, 24, "https://source.unsplash.com/random/200x200?sig=321", 24, 0, null },
                    { 47, 24, "https://source.unsplash.com/random/200x200?sig=199", 24, 0, null },
                    { 48, 24, "https://source.unsplash.com/random/200x200?sig=789", 24, 0, null },
                    { 49, 24, "https://source.unsplash.com/random/200x200?sig=117", 24, 0, null },
                    { 50, 24, "https://source.unsplash.com/random/200x200?sig=279", 24, 0, null }
                });
        }
    }
}
