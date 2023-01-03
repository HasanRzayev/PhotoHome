using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=365", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=983", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=890", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=752", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=857", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=948", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=150", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=529", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=754", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=408", 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=538", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=249", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=67", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=601", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=124", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=597", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=379", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=913", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=101", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=502", null, null });
        }
    }
}
