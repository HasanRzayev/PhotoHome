using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class ininin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_user_id_liked",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_user_id_liked",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "user_id_liked",
                table: "Images");

            migrationBuilder.CreateTable(
                name: "İmage_Like",
                columns: table => new
                {
                    userid = table.Column<string>(name: "user_id", type: "nvarchar(450)", nullable: false),
                    ImageId = table.Column<int>(name: "Image_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İmage_Like", x => new { x.ImageId, x.userid });
                    table.ForeignKey(
                        name: "FK_İmage_Like_AspNetUsers_user_id",
                        column: x => x.userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_İmage_Like_Images_Image_Id",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/beauty-product-flatlay.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/double-pearl-earrings.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/tent-at-fields-edge.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fitness-band-womens.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/feet-splash-in-pool.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/beauty-product-flatlay.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 467,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 468,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 469,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 470,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 471,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 472,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 473,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 474,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/commuter-waiting-for-subway.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fashion-toronto-watch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 478,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 479,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 480,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 481,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 482,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 483,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 484,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 485,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 486,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 487,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 488,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 489,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 490,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 491,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 492,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 493,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 494,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 495,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 496,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 497,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 498,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 499,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 500,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 501,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 502,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 503,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 504,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 505,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 506,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 507,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 508,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 509,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 510,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 511,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 512,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 513,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 514,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 515,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 516,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 517,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 518,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 519,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 520,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 521,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 522,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 523,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 524,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 525,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 526,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 527,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/red-lips-and-skirt-summer-fashion.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 531,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 532,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 533,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 534,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 535,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 536,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 537,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 538,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 539,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 540,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 541,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 542,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 543,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 544,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 545,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 546,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 547,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 548,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 549,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 550,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 551,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 552,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 553,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 554,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 555,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 556,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 557,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 558,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 559,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 560,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 561,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 562,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 563,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 564,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 565,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 566,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 567,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 568,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 569,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 570,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 571,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 572,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 573,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 574,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 575,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 576,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 577,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 578,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 579,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 580,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/commuter-waiting-for-subway.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 584,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 585,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 586,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 587,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 588,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 589,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 590,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 591,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 592,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 593,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 594,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 595,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 596,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 597,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 598,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 599,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 600,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 601,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 602,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 603,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 604,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 605,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 606,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 607,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 608,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 609,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 610,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 611,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 612,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 613,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 614,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 615,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 616,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 617,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 618,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 619,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 620,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 621,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 622,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 623,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 624,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 625,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 626,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 627,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 628,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 629,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 630,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 631,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 632,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 633,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 635,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 636,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 637,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 638,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 639,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 640,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 641,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 642,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 643,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 644,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 645,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 646,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 647,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 648,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 649,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 650,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 651,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 652,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 653,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 654,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 655,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 656,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 657,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 658,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 659,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 660,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 661,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 662,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 663,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 664,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 665,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 666,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 667,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 668,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 669,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 670,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 671,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 672,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 673,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 674,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 675,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 676,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 677,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 678,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 679,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 680,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 681,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 682,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 683,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 684,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 685,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 686,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/closeup-iphone-cases.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fitness-band-womens.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/afternoon-tea.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 690,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 691,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 692,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 693,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 694,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 695,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 696,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 697,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 698,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 699,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 700,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 701,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 702,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 703,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 704,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 705,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 706,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 707,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 708,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 709,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 710,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 711,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 712,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 713,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 714,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 715,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 716,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 717,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 718,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 719,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 720,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 721,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/beauty-product-flatlay.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 725,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 726,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 727,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 728,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 729,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 730,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 731,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 732,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 733,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 734,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 735,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 736,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 737,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 738,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 739,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 740,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 741,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 742,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 743,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 744,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 745,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 746,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 747,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 748,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 749,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 750,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 751,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 752,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 753,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 754,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 755,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 756,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 757,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 758,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 759,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 760,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 761,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 762,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 763,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 764,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 765,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 766,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 767,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 768,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 769,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 770,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 771,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 772,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 773,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 774,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 778,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 779,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 780,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 781,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 782,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 783,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 784,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 785,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 786,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 787,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 788,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 789,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 790,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 791,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 792,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 793,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 794,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 795,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 796,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 797,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 798,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 799,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 800,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 801,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 802,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 803,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 804,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 805,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 806,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 807,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 808,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 809,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 810,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 811,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 812,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 813,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 814,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 815,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 816,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 817,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 818,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 819,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 820,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 821,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 822,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 823,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 824,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 825,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 826,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 827,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/beauty-product-flatlay.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/red-lips-and-skirt-summer-fashion.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 831,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 832,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 833,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 834,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 835,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 836,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 837,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 838,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 839,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 840,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 841,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 842,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 843,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 844,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 845,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 846,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 847,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 848,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 849,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 850,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 851,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 852,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 853,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 854,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 855,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 856,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 857,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 858,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 859,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 860,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 861,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 862,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 863,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 864,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 865,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 866,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 867,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 868,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 869,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 870,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 871,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 872,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 873,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 874,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 875,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 876,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 877,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 878,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 879,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 880,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 884,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 885,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 886,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 887,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 888,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 889,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 890,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 891,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 892,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 893,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 894,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 895,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 896,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 897,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 898,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 899,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 900,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 901,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 902,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 903,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 904,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 905,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 906,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 907,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 908,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 909,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 910,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 911,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 912,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 913,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 914,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 915,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 916,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 917,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 918,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 919,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 920,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 921,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 922,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 923,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 924,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 925,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 926,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 927,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 928,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 929,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 930,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 931,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 932,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 933,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/closeup-iphone-cases.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/leather-anchor-bracelet-for-men.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 937,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 938,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 939,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 940,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 941,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 942,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 943,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 944,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 945,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 946,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 947,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 948,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 949,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 950,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 951,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 952,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 953,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 954,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 955,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 956,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 957,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 958,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 959,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 960,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 961,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 962,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 963,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 964,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 965,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 966,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 967,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 968,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 969,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 970,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 971,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 972,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 973,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 974,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 975,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 976,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 977,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 978,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 979,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 980,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 981,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 982,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 983,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 984,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 985,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 986,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 990,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 991,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 992,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 993,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 994,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 995,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 996,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 997,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 998,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 999,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1000,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1001,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1002,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1003,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1004,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1005,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1006,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1007,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1008,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1009,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1010,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1011,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1012,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1013,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1014,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1015,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1016,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1017,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1018,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1019,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1020,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1021,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1022,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1023,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1024,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1025,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1026,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1027,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1028,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1029,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1030,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1031,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1032,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1033,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1034,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1035,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1036,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1037,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1038,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1039,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/leather-anchor-bracelet-for-men.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/commuter-waiting-for-subway.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/double-pearl-earrings.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1043,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1044,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1045,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1046,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1047,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1048,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1049,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1050,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1051,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1052,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1053,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1054,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1055,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1056,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1057,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1058,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1059,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1060,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1061,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1062,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1063,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1064,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1065,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1066,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1067,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1068,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1069,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1070,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1071,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1072,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1073,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1074,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1075,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1076,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1077,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1078,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1079,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1080,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1081,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1082,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1083,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1084,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1085,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1086,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1087,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1088,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1089,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1090,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1091,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1092,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1096,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1097,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1098,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1099,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1100,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1101,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1102,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1103,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1104,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1105,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1106,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1107,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1108,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1109,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1110,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1111,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1112,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1113,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1114,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1115,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1116,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1117,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1118,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1119,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1120,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1121,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1122,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1123,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1124,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1125,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1126,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1127,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1128,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1129,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1130,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1131,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1132,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1133,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1134,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1135,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1136,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1137,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1138,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1139,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1140,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1141,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1142,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1143,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1144,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1145,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/dad-at-the-park.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/feet-splash-in-pool.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1149,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1150,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1151,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1152,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1153,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1154,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1155,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1156,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1157,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1158,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1159,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1160,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1161,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1162,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1163,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1164,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1165,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1166,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1167,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1168,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1169,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1170,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1171,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1172,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1173,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1174,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1175,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1176,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1177,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1178,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1179,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1180,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1181,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1182,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1183,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1184,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1185,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1186,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1187,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1188,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1189,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1190,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1191,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1192,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1193,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1194,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1195,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1196,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1197,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1198,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fitness-band-womens.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1202,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1203,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1204,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1205,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1206,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1207,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1208,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1209,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1210,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1211,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1212,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1213,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1214,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1215,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1216,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1217,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1218,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1219,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1220,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1221,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1222,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1223,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1224,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1225,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1226,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1227,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1228,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1229,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1230,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1231,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1232,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1233,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1234,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1235,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1236,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1237,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1238,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1239,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1240,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1241,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1242,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1243,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1244,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1245,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1246,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1247,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1248,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1249,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1250,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1251,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1252,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/pouring-hot-coffee.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1253,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1255,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1256,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1257,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1258,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1259,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1260,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1261,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1262,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1263,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1264,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1265,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1266,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1267,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1268,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1269,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1270,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1271,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1272,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1273,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1274,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1275,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1276,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1277,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1278,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1279,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1280,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1281,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1282,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1283,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1284,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1285,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1286,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1287,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1288,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1289,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1290,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1291,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1292,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1293,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1294,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1295,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1296,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1297,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1298,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1299,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1300,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1301,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1302,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1303,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1304,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/leather-anchor-bracelet-for-men.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1308,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1309,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1310,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1311,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1312,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1313,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1314,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1315,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1316,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1317,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1318,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1319,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1320,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1321,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1322,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1323,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1324,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1325,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1326,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1327,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1328,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1329,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1330,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1331,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1332,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1333,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1334,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1335,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1336,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1337,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1338,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1339,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1340,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1341,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1342,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1343,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1344,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1345,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1346,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1347,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1348,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1349,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1350,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1351,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1352,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1353,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1354,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1355,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1356,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1357,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1361,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1362,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1363,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1364,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1365,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1366,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1367,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1368,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1369,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1370,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1371,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1372,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1373,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1374,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1375,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1376,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1377,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1378,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1379,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1380,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1381,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1382,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1383,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1384,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1385,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1386,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1387,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1388,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1389,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1390,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1391,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1392,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1393,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1394,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1395,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1396,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1397,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1398,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1399,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1400,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1401,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1402,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1403,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1404,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1405,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1406,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1407,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1408,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1409,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1410,
                column: "catagory_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/tent-at-fields-edge.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/beauty-product-flatlay.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://burst.shopifycdn.com/photos/closeup-iphone-cases.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_İmage_Like_user_id",
                table: "İmage_Like",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "İmage_Like");

            migrationBuilder.AddColumn<string>(
                name: "user_id_liked",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fashion-toronto-watch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/afternoon-tea.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/double-pearl-earrings.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/red-lips-and-skirt-summer-fashion.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/double-pearl-earrings.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/pouring-hot-coffee.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/hotdog-pin-man-jean-jacket.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fitness-band-womens.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/double-pearl-earrings.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/double-pearl-earrings.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/tent-at-fields-edge.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/beauty-product-flatlay.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/hotdog-pin-man-jean-jacket.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/red-lips-and-skirt-summer-fashion.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/tent-at-fields-edge.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/red-lips-and-skirt-summer-fashion.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/leather-anchor-bracelet-for-men.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/candle-burning.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/closeup-iphone-cases.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fitness-band-womens.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fashion-toronto-watch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mini-kitchen-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/pouring-hot-coffee.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/rack-of-blank-tshirts.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/afternoon-tea.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/feet-splash-in-pool.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/businessman-leg-crossed.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1187,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1188,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1189,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1190,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1191,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1192,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/leather-anchor-bracelet-for-men.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/fashion-toronto-watch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1202,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1203,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1204,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1205,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1206,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1207,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1208,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1209,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1210,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1211,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1212,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1213,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1214,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1215,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1216,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1217,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1218,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1219,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1220,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1221,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1222,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1223,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1224,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1225,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1226,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1227,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1228,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1229,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1230,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1231,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1232,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1233,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1234,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1235,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1236,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1237,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1238,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1239,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1240,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1241,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1242,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1243,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1244,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1245,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1246,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1247,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1248,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1249,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1250,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1251,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1252,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/tent-at-fields-edge.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1253,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/black-bag-over-the-shoulder.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1255,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1256,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1257,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1258,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1259,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1260,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1261,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1262,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1264,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1265,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1266,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1267,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1268,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1269,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1270,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1271,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1272,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1273,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1274,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1275,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1276,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1277,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1278,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1279,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1280,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1281,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1282,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1283,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1284,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1285,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1286,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1287,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1288,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1289,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1290,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1291,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1292,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1293,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1294,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1295,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1296,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1297,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1298,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1299,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1300,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1301,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1302,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/mens-watch-and-ring.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/afternoon-tea.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1308,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1309,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1310,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1311,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1312,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1313,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1314,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1315,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1316,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1317,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1318,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1319,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1320,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1321,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1322,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1323,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1324,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1325,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1326,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1327,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1328,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1329,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1330,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1331,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1332,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1333,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1334,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1335,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1336,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1338,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1339,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1340,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1341,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1342,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1343,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1344,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1345,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1346,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1347,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1348,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1349,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1350,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1351,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1352,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1353,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1354,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1355,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1356,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/crescent-moon-pose-side-stretch.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/feet-splash-in-pool.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1365,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1366,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1367,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1368,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1369,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1371,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1373,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1374,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1375,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1377,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1379,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1380,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1381,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1382,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1383,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1386,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1388,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1389,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "catagory_id", "user_id_liked" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/applying-lip-balm.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://burst.shopifycdn.com/photos/a-hand-holds-four-coloured-markers.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Images_user_id_liked",
                table: "Images",
                column: "user_id_liked");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_user_id_liked",
                table: "Images",
                column: "user_id_liked",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
