using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class bbbbbbinit : Migration
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
                    MyProperty = table.Column<int>(type: "int", nullable: false),
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
                    userid = table.Column<string>(name: "user_id", type: "nvarchar(450)", nullable: false),
                    catagoryid = table.Column<int>(name: "catagory_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_user_id",
                        column: x => x.userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_Catagories_catagory_id",
                        column: x => x.catagoryid,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MyProperty", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "7e2bca6c-6e7d-4875-9bb4-59737e5dfc19", null, false, false, null, 0, null, null, "boss", null, false, "c25226d4-fc2d-41c8-9410-a27b8af70b55", false, "Boss" });

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
                columns: new[] { "Id", "DownloadCount", "ImageUrl", "LikeCount", "catagory_id", "user_id" },
                values: new object[,]
                {
                    { 1, 24, "https://source.unsplash.com/random/200x200?sig=730", 24, 1, "1" },
                    { 2, 24, "https://source.unsplash.com/random/200x200?sig=889", 24, 1, "1" },
                    { 3, 24, "https://source.unsplash.com/random/200x200?sig=140", 24, 1, "1" },
                    { 4, 24, "https://source.unsplash.com/random/200x200?sig=632", 24, 1, "1" },
                    { 5, 24, "https://source.unsplash.com/random/200x200?sig=755", 24, 1, "1" },
                    { 6, 24, "https://source.unsplash.com/random/200x200?sig=285", 24, 1, "1" },
                    { 7, 24, "https://source.unsplash.com/random/200x200?sig=34", 24, 1, "1" },
                    { 8, 24, "https://source.unsplash.com/random/200x200?sig=857", 24, 1, "1" },
                    { 9, 24, "https://source.unsplash.com/random/200x200?sig=955", 24, 1, "1" },
                    { 10, 24, "https://source.unsplash.com/random/200x200?sig=621", 24, 1, "1" },
                    { 11, 24, "https://source.unsplash.com/random/200x200?sig=717", 24, 1, "1" },
                    { 12, 24, "https://source.unsplash.com/random/200x200?sig=114", 24, 1, "1" },
                    { 13, 24, "https://source.unsplash.com/random/200x200?sig=257", 24, 1, "1" },
                    { 14, 24, "https://source.unsplash.com/random/200x200?sig=762", 24, 1, "1" },
                    { 15, 24, "https://source.unsplash.com/random/200x200?sig=956", 24, 1, "1" },
                    { 16, 24, "https://source.unsplash.com/random/200x200?sig=750", 24, 1, "1" },
                    { 17, 24, "https://source.unsplash.com/random/200x200?sig=698", 24, 1, "1" },
                    { 18, 24, "https://source.unsplash.com/random/200x200?sig=916", 24, 1, "1" },
                    { 19, 24, "https://source.unsplash.com/random/200x200?sig=486", 24, 1, "1" },
                    { 20, 24, "https://source.unsplash.com/random/200x200?sig=763", 24, 1, "1" },
                    { 21, 24, "https://source.unsplash.com/random/200x200?sig=455", 24, 1, "1" },
                    { 22, 24, "https://source.unsplash.com/random/200x200?sig=695", 24, 1, "1" },
                    { 23, 24, "https://source.unsplash.com/random/200x200?sig=542", 24, 1, "1" },
                    { 24, 24, "https://source.unsplash.com/random/200x200?sig=558", 24, 1, "1" },
                    { 25, 24, "https://source.unsplash.com/random/200x200?sig=435", 24, 1, "1" },
                    { 26, 24, "https://source.unsplash.com/random/200x200?sig=309", 24, 1, "1" },
                    { 27, 24, "https://source.unsplash.com/random/200x200?sig=531", 24, 1, "1" },
                    { 28, 24, "https://source.unsplash.com/random/200x200?sig=394", 24, 1, "1" },
                    { 29, 24, "https://source.unsplash.com/random/200x200?sig=769", 24, 1, "1" },
                    { 30, 24, "https://source.unsplash.com/random/200x200?sig=32", 24, 1, "1" },
                    { 31, 24, "https://source.unsplash.com/random/200x200?sig=517", 24, 1, "1" },
                    { 32, 24, "https://source.unsplash.com/random/200x200?sig=479", 24, 1, "1" },
                    { 33, 24, "https://source.unsplash.com/random/200x200?sig=693", 24, 1, "1" },
                    { 34, 24, "https://source.unsplash.com/random/200x200?sig=398", 24, 1, "1" },
                    { 35, 24, "https://source.unsplash.com/random/200x200?sig=925", 24, 1, "1" },
                    { 36, 24, "https://source.unsplash.com/random/200x200?sig=24", 24, 1, "1" },
                    { 37, 24, "https://source.unsplash.com/random/200x200?sig=113", 24, 1, "1" },
                    { 38, 24, "https://source.unsplash.com/random/200x200?sig=403", 24, 1, "1" },
                    { 39, 24, "https://source.unsplash.com/random/200x200?sig=237", 24, 1, "1" },
                    { 40, 24, "https://source.unsplash.com/random/200x200?sig=702", 24, 1, "1" },
                    { 41, 24, "https://source.unsplash.com/random/200x200?sig=159", 24, 1, "1" },
                    { 42, 24, "https://source.unsplash.com/random/200x200?sig=682", 24, 1, "1" },
                    { 43, 24, "https://source.unsplash.com/random/200x200?sig=110", 24, 1, "1" },
                    { 44, 24, "https://source.unsplash.com/random/200x200?sig=679", 24, 1, "1" },
                    { 45, 24, "https://source.unsplash.com/random/200x200?sig=268", 24, 1, "1" },
                    { 46, 24, "https://source.unsplash.com/random/200x200?sig=810", 24, 1, "1" },
                    { 47, 24, "https://source.unsplash.com/random/200x200?sig=546", 24, 1, "1" },
                    { 48, 24, "https://source.unsplash.com/random/200x200?sig=755", 24, 1, "1" },
                    { 49, 24, "https://source.unsplash.com/random/200x200?sig=918", 24, 1, "1" },
                    { 50, 24, "https://source.unsplash.com/random/200x200?sig=454", 24, 1, "1" },
                    { 51, 24, "https://source.unsplash.com/random/200x200?sig=111", 24, 1, "1" },
                    { 52, 24, "https://source.unsplash.com/random/200x200?sig=305", 24, 1, "1" },
                    { 53, 24, "https://source.unsplash.com/random/200x200?sig=573", 24, 1, "1" },
                    { 54, 24, "https://source.unsplash.com/random/200x200?sig=197", 24, 1, "1" },
                    { 55, 24, "https://source.unsplash.com/random/200x200?sig=332", 24, 1, "1" },
                    { 56, 24, "https://source.unsplash.com/random/200x200?sig=95", 24, 1, "1" },
                    { 57, 24, "https://source.unsplash.com/random/200x200?sig=553", 24, 1, "1" },
                    { 58, 24, "https://source.unsplash.com/random/200x200?sig=190", 24, 1, "1" },
                    { 59, 24, "https://source.unsplash.com/random/200x200?sig=277", 24, 1, "1" },
                    { 60, 24, "https://source.unsplash.com/random/200x200?sig=531", 24, 1, "1" },
                    { 61, 24, "https://source.unsplash.com/random/200x200?sig=266", 24, 1, "1" },
                    { 62, 24, "https://source.unsplash.com/random/200x200?sig=19", 24, 1, "1" },
                    { 63, 24, "https://source.unsplash.com/random/200x200?sig=7", 24, 1, "1" },
                    { 64, 24, "https://source.unsplash.com/random/200x200?sig=765", 24, 1, "1" },
                    { 65, 24, "https://source.unsplash.com/random/200x200?sig=475", 24, 1, "1" },
                    { 66, 24, "https://source.unsplash.com/random/200x200?sig=693", 24, 1, "1" },
                    { 67, 24, "https://source.unsplash.com/random/200x200?sig=598", 24, 1, "1" },
                    { 68, 24, "https://source.unsplash.com/random/200x200?sig=408", 24, 1, "1" },
                    { 69, 24, "https://source.unsplash.com/random/200x200?sig=321", 24, 1, "1" },
                    { 70, 24, "https://source.unsplash.com/random/200x200?sig=620", 24, 1, "1" },
                    { 71, 24, "https://source.unsplash.com/random/200x200?sig=456", 24, 1, "1" },
                    { 72, 24, "https://source.unsplash.com/random/200x200?sig=614", 24, 1, "1" },
                    { 73, 24, "https://source.unsplash.com/random/200x200?sig=26", 24, 1, "1" },
                    { 74, 24, "https://source.unsplash.com/random/200x200?sig=334", 24, 1, "1" },
                    { 75, 24, "https://source.unsplash.com/random/200x200?sig=761", 24, 1, "1" },
                    { 76, 24, "https://source.unsplash.com/random/200x200?sig=837", 24, 1, "1" },
                    { 77, 24, "https://source.unsplash.com/random/200x200?sig=987", 24, 1, "1" },
                    { 78, 24, "https://source.unsplash.com/random/200x200?sig=386", 24, 1, "1" },
                    { 79, 24, "https://source.unsplash.com/random/200x200?sig=11", 24, 1, "1" },
                    { 80, 24, "https://source.unsplash.com/random/200x200?sig=436", 24, 1, "1" },
                    { 81, 24, "https://source.unsplash.com/random/200x200?sig=435", 24, 1, "1" },
                    { 82, 24, "https://source.unsplash.com/random/200x200?sig=666", 24, 1, "1" },
                    { 83, 24, "https://source.unsplash.com/random/200x200?sig=768", 24, 1, "1" },
                    { 84, 24, "https://source.unsplash.com/random/200x200?sig=331", 24, 1, "1" },
                    { 85, 24, "https://source.unsplash.com/random/200x200?sig=884", 24, 1, "1" },
                    { 86, 24, "https://source.unsplash.com/random/200x200?sig=14", 24, 1, "1" },
                    { 87, 24, "https://source.unsplash.com/random/200x200?sig=54", 24, 1, "1" },
                    { 88, 24, "https://source.unsplash.com/random/200x200?sig=384", 24, 1, "1" },
                    { 89, 24, "https://source.unsplash.com/random/200x200?sig=981", 24, 1, "1" },
                    { 90, 24, "https://source.unsplash.com/random/200x200?sig=245", 24, 1, "1" },
                    { 91, 24, "https://source.unsplash.com/random/200x200?sig=162", 24, 1, "1" },
                    { 92, 24, "https://source.unsplash.com/random/200x200?sig=704", 24, 1, "1" },
                    { 93, 24, "https://source.unsplash.com/random/200x200?sig=605", 24, 1, "1" },
                    { 94, 24, "https://source.unsplash.com/random/200x200?sig=147", 24, 1, "1" },
                    { 95, 24, "https://source.unsplash.com/random/200x200?sig=152", 24, 1, "1" },
                    { 96, 24, "https://source.unsplash.com/random/200x200?sig=41", 24, 1, "1" },
                    { 97, 24, "https://source.unsplash.com/random/200x200?sig=199", 24, 1, "1" },
                    { 98, 24, "https://source.unsplash.com/random/200x200?sig=82", 24, 1, "1" },
                    { 99, 24, "https://source.unsplash.com/random/200x200?sig=612", 24, 1, "1" },
                    { 100, 24, "https://source.unsplash.com/random/200x200?sig=600", 24, 1, "1" },
                    { 101, 24, "https://source.unsplash.com/random/200x200?sig=79", 24, 1, "1" },
                    { 102, 24, "https://source.unsplash.com/random/200x200?sig=340", 24, 1, "1" },
                    { 103, 24, "https://source.unsplash.com/random/200x200?sig=451", 24, 1, "1" },
                    { 104, 24, "https://source.unsplash.com/random/200x200?sig=383", 24, 1, "1" },
                    { 105, 24, "https://source.unsplash.com/random/200x200?sig=884", 24, 1, "1" },
                    { 106, 24, "https://source.unsplash.com/random/200x200?sig=800", 24, 1, "1" },
                    { 107, 24, "https://source.unsplash.com/random/200x200?sig=847", 24, 1, "1" },
                    { 108, 24, "https://source.unsplash.com/random/200x200?sig=777", 24, 1, "1" },
                    { 109, 24, "https://source.unsplash.com/random/200x200?sig=340", 24, 1, "1" },
                    { 110, 24, "https://source.unsplash.com/random/200x200?sig=640", 24, 1, "1" },
                    { 111, 24, "https://source.unsplash.com/random/200x200?sig=409", 24, 1, "1" },
                    { 112, 24, "https://source.unsplash.com/random/200x200?sig=337", 24, 1, "1" },
                    { 113, 24, "https://source.unsplash.com/random/200x200?sig=377", 24, 1, "1" },
                    { 114, 24, "https://source.unsplash.com/random/200x200?sig=870", 24, 1, "1" },
                    { 115, 24, "https://source.unsplash.com/random/200x200?sig=56", 24, 1, "1" },
                    { 116, 24, "https://source.unsplash.com/random/200x200?sig=151", 24, 1, "1" },
                    { 117, 24, "https://source.unsplash.com/random/200x200?sig=690", 24, 1, "1" },
                    { 118, 24, "https://source.unsplash.com/random/200x200?sig=499", 24, 1, "1" },
                    { 119, 24, "https://source.unsplash.com/random/200x200?sig=4", 24, 1, "1" },
                    { 120, 24, "https://source.unsplash.com/random/200x200?sig=479", 24, 1, "1" },
                    { 121, 24, "https://source.unsplash.com/random/200x200?sig=843", 24, 1, "1" },
                    { 122, 24, "https://source.unsplash.com/random/200x200?sig=916", 24, 1, "1" },
                    { 123, 24, "https://source.unsplash.com/random/200x200?sig=611", 24, 1, "1" },
                    { 124, 24, "https://source.unsplash.com/random/200x200?sig=42", 24, 1, "1" },
                    { 125, 24, "https://source.unsplash.com/random/200x200?sig=861", 24, 1, "1" },
                    { 126, 24, "https://source.unsplash.com/random/200x200?sig=314", 24, 1, "1" },
                    { 127, 24, "https://source.unsplash.com/random/200x200?sig=695", 24, 1, "1" },
                    { 128, 24, "https://source.unsplash.com/random/200x200?sig=628", 24, 1, "1" },
                    { 129, 24, "https://source.unsplash.com/random/200x200?sig=588", 24, 1, "1" },
                    { 130, 24, "https://source.unsplash.com/random/200x200?sig=533", 24, 1, "1" },
                    { 131, 24, "https://source.unsplash.com/random/200x200?sig=435", 24, 1, "1" },
                    { 132, 24, "https://source.unsplash.com/random/200x200?sig=849", 24, 1, "1" },
                    { 133, 24, "https://source.unsplash.com/random/200x200?sig=65", 24, 1, "1" },
                    { 134, 24, "https://source.unsplash.com/random/200x200?sig=266", 24, 1, "1" },
                    { 135, 24, "https://source.unsplash.com/random/200x200?sig=851", 24, 1, "1" },
                    { 136, 24, "https://source.unsplash.com/random/200x200?sig=26", 24, 1, "1" },
                    { 137, 24, "https://source.unsplash.com/random/200x200?sig=623", 24, 1, "1" },
                    { 138, 24, "https://source.unsplash.com/random/200x200?sig=784", 24, 1, "1" },
                    { 139, 24, "https://source.unsplash.com/random/200x200?sig=621", 24, 1, "1" },
                    { 140, 24, "https://source.unsplash.com/random/200x200?sig=291", 24, 1, "1" },
                    { 141, 24, "https://source.unsplash.com/random/200x200?sig=659", 24, 1, "1" },
                    { 142, 24, "https://source.unsplash.com/random/200x200?sig=333", 24, 1, "1" },
                    { 143, 24, "https://source.unsplash.com/random/200x200?sig=962", 24, 1, "1" },
                    { 144, 24, "https://source.unsplash.com/random/200x200?sig=13", 24, 1, "1" },
                    { 145, 24, "https://source.unsplash.com/random/200x200?sig=131", 24, 1, "1" },
                    { 146, 24, "https://source.unsplash.com/random/200x200?sig=693", 24, 1, "1" },
                    { 147, 24, "https://source.unsplash.com/random/200x200?sig=545", 24, 1, "1" },
                    { 148, 24, "https://source.unsplash.com/random/200x200?sig=678", 24, 1, "1" },
                    { 149, 24, "https://source.unsplash.com/random/200x200?sig=463", 24, 1, "1" },
                    { 150, 24, "https://source.unsplash.com/random/200x200?sig=736", 24, 1, "1" }
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
