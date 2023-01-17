using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user_id_liked",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Wallpapers/647", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?3D Renders/333", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Travel/44", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Nature/617", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Street Photography/464", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Experimental/378", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Textures & Patterns/52", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Architecture & Interiors/920", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Fashion & Beauty/901", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Film/8", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Food & Drink/396", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?People/126", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Spirituality/193", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Business & Work/325", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Athletics/343", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Health & Wellness/586", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Current Events/36", 1, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "catagory_id", "user_id_liked" },
                values: new object[] { "https://source.unsplash.com/random/?Arts & Culture/392", 1, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Wallpapers/683", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?3D Renders/973", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Travel/357", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Nature/357", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Street Photography/830", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Experimental/6", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Textures & Patterns/604", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Architecture & Interiors/860", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Fashion & Beauty/966", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Film/896", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Food & Drink/83", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?People/734", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Spirituality/479", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Business & Work/709", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Athletics/346", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Health & Wellness/945", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Current Events/409", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Arts & Culture/281", null });
        }
    }
}
