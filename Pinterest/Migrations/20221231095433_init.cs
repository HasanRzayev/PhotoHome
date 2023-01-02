using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    DownloadCount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: true),
                    catagoryid = table.Column<int>(name: "catagory_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Catagories_catagory_id",
                        column: x => x.catagoryid,
                        principalTable: "Catagories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Users_user_id",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Kitab" },
                    { 2, " Kadin    " },
                    { 3, " Giyim " },
                    { 4, "Elbise    " }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "hsnrz2002@gmail.com", "Boss", "aaaaaaaaaaaaa", "boss" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Description", "DownloadCount", "ImageUrl", "LikeCount", "Title", "catagory_id", "user_id" },
                values: new object[,]
                {
                    { 1, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=519", 24, "Super", 1, 1 },
                    { 2, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=645", 24, "Super", 1, 1 },
                    { 3, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=872", 24, "Super", 1, 1 },
                    { 4, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=714", 24, "Super", 1, 1 },
                    { 5, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=876", 24, "Super", 1, 1 },
                    { 6, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=493", 24, "Super", 1, 1 },
                    { 7, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=453", 24, "Super", 1, 1 },
                    { 8, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=471", 24, "Super", 1, 1 },
                    { 9, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=917", 24, "Super", 1, 1 },
                    { 10, "Bomba", 24, "https://source.unsplash.com/random/200x200?sig=545", 24, "Super", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_catagory_id",
                table: "Images",
                column: "catagory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_user_id",
                table: "Images",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
