using System;
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    userid = table.Column<string>(name: "user_id", type: "nvarchar(450)", nullable: true),
                    useridliked = table.Column<string>(name: "user_id_liked", type: "nvarchar(450)", nullable: true),
                    catagoryid = table.Column<int>(name: "catagory_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_user_id",
                        column: x => x.userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_user_id_liked",
                        column: x => x.useridliked,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Catagories_catagory_id",
                        column: x => x.catagoryid,
                        principalTable: "Catagories",
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
                table: "Images",
                columns: new[] { "Id", "Description", "DownloadCount", "ImageUrl", "LikeCount", "Title", "catagory_id", "user_id", "user_id_liked" },
                values: new object[,]
                {
                    { 1, "Bomba", 24, "https://burst.shopifycdn.com/photos/ripe-red-strawberries-in-a-white-bowl.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 2, "Bomba", 24, "https://burst.shopifycdn.com/photos/ripe-red-strawberries-against-pink.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 3, "Bomba", 24, "https://burst.shopifycdn.com/photos/deli-with-cured-meat-on-hooks-and-eggs-on-counter.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 4, "Bomba", 24, "https://burst.shopifycdn.com/photos/flatlay-iron-skillet-with-meat-and-other-food.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 5, "Bomba", 24, "https://burst.shopifycdn.com/photos/close-up-of-a-bao-bun-on-a-wooden-table.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 6, "Bomba", 24, "https://burst.shopifycdn.com/photos/camera-looks-down-on-wooden-table-with-two-bao-buns.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 7, "Bomba", 24, "https://burst.shopifycdn.com/photos/hands-slice-red-pepper-on-wooden-cutting-board.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 8, "Bomba", 24, "https://burst.shopifycdn.com/photos/shellfish-pasta-pizza-and-italian-food.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 9, "Bomba", 24, "https://burst.shopifycdn.com/photos/knife-slices-a-zucchini-in-half.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 10, "Bomba", 24, "https://burst.shopifycdn.com/photos/person-enjoys-lunch-alone-in-a-sunlit-restaurant.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 11, "Bomba", 24, "https://burst.shopifycdn.com/photos/hand-holds-up-a-two-scoop-ice-cream-cone.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 12, "Bomba", 24, "https://burst.shopifycdn.com/photos/close-up-of-seasoned-chickpeas.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 13, "Bomba", 24, "https://burst.shopifycdn.com/photos/biscotti-lays-in-a-monstera-leaf.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 14, "Bomba", 24, "https://burst.shopifycdn.com/photos/person-cuts-into-plate-of-pasta.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 15, "Bomba", 24, "https://burst.shopifycdn.com/photos/three-spanakopita-spirals-on-textured-plate.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 16, "Bomba", 24, "https://burst.shopifycdn.com/photos/two-red-cocktails-on-a-tray.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 17, "Bomba", 24, "https://burst.shopifycdn.com/photos/hand-holds-rainbow-carrots.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 18, "Bomba", 24, "https://burst.shopifycdn.com/photos/gourmet-pasta-in-white-bowl.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 19, "Bomba", 24, "https://burst.shopifycdn.com/photos/delicious-plate-of-pepperoni-pizza.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 20, "Bomba", 24, "https://burst.shopifycdn.com/photos/flat-lay-of-baked-bread-with-apples-and-oats.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 21, "Bomba", 24, "https://burst.shopifycdn.com/photos/freshly-baked-bread-in-hands.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 22, "Bomba", 24, "https://burst.shopifycdn.com/photos/scrumptious-brunch-setting.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 23, "Bomba", 24, "https://burst.shopifycdn.com/photos/bread-loaf-on-a-wooden-cutting-board.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 24, "Bomba", 24, "https://burst.shopifycdn.com/photos/its-pasta-night.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 25, "Bomba", 24, "https://burst.shopifycdn.com/photos/eggy-breakfast.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 26, "Bomba", 24, "https://burst.shopifycdn.com/photos/a-picture-of-a-produce-stall-through-a-camera-screen.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 27, "Bomba", 24, "https://burst.shopifycdn.com/photos/hand-holding-a-mushroom.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 28, "Bomba", 24, "https://burst.shopifycdn.com/photos/picking-strawberries.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 29, "Bomba", 24, "https://burst.shopifycdn.com/photos/healthy-breakfast-time.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 30, "Bomba", 24, "https://burst.shopifycdn.com/photos/two-pizzas-and-wine.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 31, "Bomba", 24, "https://burst.shopifycdn.com/photos/pizza-and-wine-dinner.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 32, "Bomba", 24, "https://burst.shopifycdn.com/photos/a-cocktail-with-a-touch-of-class.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 33, "Bomba", 24, "https://burst.shopifycdn.com/photos/fresh-thyme-and-kitchen-scissors.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 34, "Bomba", 24, "https://burst.shopifycdn.com/photos/berries-granola.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 35, "Bomba", 24, "https://burst.shopifycdn.com/photos/couple-on-coffee-date.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 36, "Bomba", 24, "https://burst.shopifycdn.com/photos/market-peppers.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 37, "Bomba", 24, "https://burst.shopifycdn.com/photos/healthy-breakfast.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 38, "Bomba", 24, "https://burst.shopifycdn.com/photos/table-for-two.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 39, "Bomba", 24, "https://burst.shopifycdn.com/photos/breakfast-from-above.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 40, "Bomba", 24, "https://burst.shopifycdn.com/photos/restaurant-breakfast.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 41, "Bomba", 24, "https://burst.shopifycdn.com/photos/hamburger-and-fries.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 42, "Bomba", 24, "https://burst.shopifycdn.com/photos/hotel-breakfast-room-service.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 43, "Bomba", 24, "https://burst.shopifycdn.com/photos/berry-cheesecake.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 44, "Bomba", 24, "https://burst.shopifycdn.com/photos/croissant-coffee.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 45, "Bomba", 24, "https://burst.shopifycdn.com/photos/pizza-dough-ready-to-roll.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 46, "Bomba", 24, "https://burst.shopifycdn.com/photos/cutting-board-with-veg.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 47, "Bomba", 24, "https://burst.shopifycdn.com/photos/half-of-an-avocado.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 48, "Bomba", 24, "https://burst.shopifycdn.com/photos/dinner-salad.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 49, "Bomba", 24, "https://burst.shopifycdn.com/photos/popcicle.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 50, "Bomba", 24, "https://burst.shopifycdn.com/photos/garden-carrots.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 51, "Bomba", 24, "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 24, "Super", 1, null, null },
                    { 52, "Bomba", 24, "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 24, "Super", 1, null, null },
                    { 53, "Bomba", 24, "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 24, "Super", 1, null, null },
                    { 54, "Bomba", 24, "https://burst.shopifycdn.com/photos/ripe-red-strawberries-in-a-white-bowl.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 55, "Bomba", 24, "https://burst.shopifycdn.com/photos/ripe-red-strawberries-against-pink.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 56, "Bomba", 24, "https://burst.shopifycdn.com/photos/deli-with-cured-meat-on-hooks-and-eggs-on-counter.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 57, "Bomba", 24, "https://burst.shopifycdn.com/photos/flatlay-iron-skillet-with-meat-and-other-food.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 58, "Bomba", 24, "https://burst.shopifycdn.com/photos/close-up-of-a-bao-bun-on-a-wooden-table.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 59, "Bomba", 24, "https://burst.shopifycdn.com/photos/camera-looks-down-on-wooden-table-with-two-bao-buns.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 60, "Bomba", 24, "https://burst.shopifycdn.com/photos/hands-slice-red-pepper-on-wooden-cutting-board.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 61, "Bomba", 24, "https://burst.shopifycdn.com/photos/shellfish-pasta-pizza-and-italian-food.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 62, "Bomba", 24, "https://burst.shopifycdn.com/photos/knife-slices-a-zucchini-in-half.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 63, "Bomba", 24, "https://burst.shopifycdn.com/photos/person-enjoys-lunch-alone-in-a-sunlit-restaurant.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 64, "Bomba", 24, "https://burst.shopifycdn.com/photos/hand-holds-up-a-two-scoop-ice-cream-cone.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 65, "Bomba", 24, "https://burst.shopifycdn.com/photos/close-up-of-seasoned-chickpeas.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 66, "Bomba", 24, "https://burst.shopifycdn.com/photos/biscotti-lays-in-a-monstera-leaf.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 67, "Bomba", 24, "https://burst.shopifycdn.com/photos/person-cuts-into-plate-of-pasta.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 68, "Bomba", 24, "https://burst.shopifycdn.com/photos/three-spanakopita-spirals-on-textured-plate.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 69, "Bomba", 24, "https://burst.shopifycdn.com/photos/two-red-cocktails-on-a-tray.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 70, "Bomba", 24, "https://burst.shopifycdn.com/photos/hand-holds-rainbow-carrots.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 71, "Bomba", 24, "https://burst.shopifycdn.com/photos/gourmet-pasta-in-white-bowl.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 72, "Bomba", 24, "https://burst.shopifycdn.com/photos/delicious-plate-of-pepperoni-pizza.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 73, "Bomba", 24, "https://burst.shopifycdn.com/photos/flat-lay-of-baked-bread-with-apples-and-oats.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 74, "Bomba", 24, "https://burst.shopifycdn.com/photos/freshly-baked-bread-in-hands.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 75, "Bomba", 24, "https://burst.shopifycdn.com/photos/scrumptious-brunch-setting.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 76, "Bomba", 24, "https://burst.shopifycdn.com/photos/bread-loaf-on-a-wooden-cutting-board.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 77, "Bomba", 24, "https://burst.shopifycdn.com/photos/its-pasta-night.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 78, "Bomba", 24, "https://burst.shopifycdn.com/photos/eggy-breakfast.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 79, "Bomba", 24, "https://burst.shopifycdn.com/photos/a-picture-of-a-produce-stall-through-a-camera-screen.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 80, "Bomba", 24, "https://burst.shopifycdn.com/photos/hand-holding-a-mushroom.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 81, "Bomba", 24, "https://burst.shopifycdn.com/photos/picking-strawberries.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 82, "Bomba", 24, "https://burst.shopifycdn.com/photos/healthy-breakfast-time.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 83, "Bomba", 24, "https://burst.shopifycdn.com/photos/two-pizzas-and-wine.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 84, "Bomba", 24, "https://burst.shopifycdn.com/photos/pizza-and-wine-dinner.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 85, "Bomba", 24, "https://burst.shopifycdn.com/photos/a-cocktail-with-a-touch-of-class.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 86, "Bomba", 24, "https://burst.shopifycdn.com/photos/fresh-thyme-and-kitchen-scissors.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 87, "Bomba", 24, "https://burst.shopifycdn.com/photos/berries-granola.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 88, "Bomba", 24, "https://burst.shopifycdn.com/photos/couple-on-coffee-date.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 89, "Bomba", 24, "https://burst.shopifycdn.com/photos/market-peppers.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 90, "Bomba", 24, "https://burst.shopifycdn.com/photos/healthy-breakfast.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 91, "Bomba", 24, "https://burst.shopifycdn.com/photos/table-for-two.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 92, "Bomba", 24, "https://burst.shopifycdn.com/photos/breakfast-from-above.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 93, "Bomba", 24, "https://burst.shopifycdn.com/photos/restaurant-breakfast.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 94, "Bomba", 24, "https://burst.shopifycdn.com/photos/hamburger-and-fries.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 95, "Bomba", 24, "https://burst.shopifycdn.com/photos/hotel-breakfast-room-service.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 96, "Bomba", 24, "https://burst.shopifycdn.com/photos/berry-cheesecake.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 97, "Bomba", 24, "https://burst.shopifycdn.com/photos/croissant-coffee.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 98, "Bomba", 24, "https://burst.shopifycdn.com/photos/pizza-dough-ready-to-roll.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 99, "Bomba", 24, "https://burst.shopifycdn.com/photos/cutting-board-with-veg.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 100, "Bomba", 24, "https://burst.shopifycdn.com/photos/half-of-an-avocado.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 101, "Bomba", 24, "https://burst.shopifycdn.com/photos/dinner-salad.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 102, "Bomba", 24, "https://burst.shopifycdn.com/photos/popcicle.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 103, "Bomba", 24, "https://burst.shopifycdn.com/photos/garden-carrots.jpg?width=1200&amp;format=pjpg&amp;exif=1&amp;iptc=1", 24, "Super", 1, null, null },
                    { 104, "Bomba", 24, "https://burst.shopifycdn.com/photos/black-hightop-LED-shoes.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 24, "Super", 1, null, null },
                    { 105, "Bomba", 24, "https://burst.shopifycdn.com/photos/spa-candle-towel-and-stones.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 24, "Super", 1, null, null },
                    { 106, "Bomba", 24, "https://burst.shopifycdn.com/photos/aliexpress-bluetooth-speaker.jpg?width=1200&amp;format=pjpg&amp;exif=0&amp;iptc=0", 24, "Super", 1, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_catagory_id",
                table: "Images",
                column: "catagory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_user_id",
                table: "Images",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_user_id_liked",
                table: "Images",
                column: "user_id_liked");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Catagories");
        }
    }
}
