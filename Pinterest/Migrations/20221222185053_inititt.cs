using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class inititt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e619480-8742-4544-8a38-99e1b644d62f", "e3b1ecd1-c552-4dc4-b40b-667cab3acf72" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "catagory_id", "user_id" },
                values: new object[] { 1, "1" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "DownloadCount", "ImageUrl", "LikeCount", "catagory_id", "user_id" },
                values: new object[] { 2, 24, "https://i.pinimg.com/474x/16/fd/0d/16fd0d1a656ef785e6594e7f54e6a510.jpg", 24, 1, "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b166ac3-b2e6-400e-b3b6-cdd11c98499e", "aa65ff85-d522-438e-a302-fd82589a61a6" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "catagory_id", "user_id" },
                values: new object[] { 0, null });
        }
    }
}
