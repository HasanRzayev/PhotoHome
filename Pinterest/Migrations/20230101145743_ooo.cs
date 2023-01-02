using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class ooo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=538", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=249", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=67", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=601", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=124", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=597", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=379", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=913", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=101", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=502", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=519", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=645", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=872", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=714", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=876", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=493", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=453", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=471", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=917", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id" },
                values: new object[] { "https://source.unsplash.com/random/200x200?sig=545", null, null });
        }
    }
}
