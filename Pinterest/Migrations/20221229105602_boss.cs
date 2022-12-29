using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class boss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26feee12-af80-447a-aaf0-64543e8dd70b", "1723e416-8432-45dc-9a57-c1e082885a96" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=31", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=332", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=911", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=607", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=186", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=920", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=708", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=680", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=783", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=951", 1, "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=136", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=125", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=385", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=130", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=59", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=307", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=265", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=462", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=212", 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=517", 0, null });
        }
    }
}
