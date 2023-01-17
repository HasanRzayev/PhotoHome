using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhotoHome.Migrations
{
    /// <inheritdoc />
    public partial class initisdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673643654783-262d176c86d4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHxwaG90by1vZi10aGUtZGF5fHx8fGVufDB8fHx8&amp;auto=format%2Ccompress&amp;fit=crop&amp;w=1000&amp;h=1000", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1668467927849-f770914911a4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDF8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673188796938-5975e079b68d?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDR8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673842449987-3c7d56e5b1cf?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDZ8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673842450064-e9a1197e1a66?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDd8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673643654783-262d176c86d4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEwfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673446932312-413e564c5640?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEzfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673380823385-75929e08ea89?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE1fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673350018635-72ce4469e0f6?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE3fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://plus.unsplash.com/premium_photo-1673264730462-6b4acadcab25?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDIwfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/profile-1604758536753-68fd6f23aaf7image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/profile-1593541755358-41ff2a4e41efimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/profile-1516997253075-2a25da8007e7?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/profile-1648828806223-1852f704c58aimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/profile-1635425197470-04119ef8fe14image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673359193906-b6694fdc0139?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDJ8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673050460660-2bd7b3bb25a4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDN8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://images.unsplash.com/photo-1673192573046-efc73501bd5d?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDV8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Description", "DownloadCount", "ImageUrl", "LikeCount", "Title", "catagory_id", "user_id", "user_id_liked" },
                values: new object[,]
                {
                    { 19, "Bomba", 24, "https://images.unsplash.com/photo-1673790120533-12697d88aa59?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDh8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 20, "Bomba", 24, "https://images.unsplash.com/photo-1673667617558-91300594284c?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDl8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 21, "Bomba", 24, "https://images.unsplash.com/photo-1673643203499-23c29eafead7?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDExfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 22, "Bomba", 24, "https://images.unsplash.com/photo-1673433107234-14d1a4424658?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEyfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 23, "Bomba", 24, "https://images.unsplash.com/photo-1673446932465-a67b5bdd3d4f?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE0fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 24, "Bomba", 24, "https://images.unsplash.com/photo-1673447111351-d83b5376a9d1?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE2fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 25, "Bomba", 24, "https://images.unsplash.com/photo-1673292480069-7ebbd87081f4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE4fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 26, "Bomba", 24, "https://images.unsplash.com/photo-1673126167141-3c3e59e99f54?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE5fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 27, "Bomba", 24, "https://images.unsplash.com/photo-1668467927849-f770914911a4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDF8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 28, "Bomba", 24, "https://images.unsplash.com/photo-1673842449987-3c7d56e5b1cf?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDZ8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 29, "Bomba", 24, "https://images.unsplash.com/photo-1673790120533-12697d88aa59?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDh8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 30, "Bomba", 24, "https://images.unsplash.com/photo-1673667617558-91300594284c?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDl8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 31, "Bomba", 24, "https://images.unsplash.com/photo-1673433107234-14d1a4424658?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEyfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 32, "Bomba", 24, "https://images.unsplash.com/photo-1673446932465-a67b5bdd3d4f?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE0fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 33, "Bomba", 24, "https://images.unsplash.com/photo-1673350018635-72ce4469e0f6?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE3fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 34, "Bomba", 24, "https://images.unsplash.com/photo-1673359193906-b6694fdc0139?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDJ8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 35, "Bomba", 24, "https://images.unsplash.com/photo-1673192573046-efc73501bd5d?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDV8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 36, "Bomba", 24, "https://images.unsplash.com/photo-1673643203499-23c29eafead7?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDExfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 37, "Bomba", 24, "https://images.unsplash.com/photo-1673446932312-413e564c5640?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEzfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 38, "Bomba", 24, "https://images.unsplash.com/photo-1673380823385-75929e08ea89?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE1fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 39, "Bomba", 24, "https://images.unsplash.com/photo-1673292480069-7ebbd87081f4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE4fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 40, "Bomba", 24, "https://plus.unsplash.com/premium_photo-1673264730462-6b4acadcab25?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDIwfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 41, "Bomba", 24, "https://images.unsplash.com/profile-1604758536753-68fd6f23aaf7image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 42, "Bomba", 24, "https://images.unsplash.com/profile-1593541755358-41ff2a4e41efimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 43, "Bomba", 24, "https://images.unsplash.com/profile-1516997253075-2a25da8007e7?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 44, "Bomba", 24, "https://images.unsplash.com/profile-1648828806223-1852f704c58aimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 45, "Bomba", 24, "https://images.unsplash.com/profile-1635425197470-04119ef8fe14image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 46, "Bomba", 24, "https://images.unsplash.com/photo-1673050460660-2bd7b3bb25a4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDN8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 47, "Bomba", 24, "https://images.unsplash.com/photo-1673188796938-5975e079b68d?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDR8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 48, "Bomba", 24, "https://images.unsplash.com/photo-1673842450064-e9a1197e1a66?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDd8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 49, "Bomba", 24, "https://images.unsplash.com/photo-1673643654783-262d176c86d4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEwfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 50, "Bomba", 24, "https://images.unsplash.com/photo-1673447111351-d83b5376a9d1?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE2fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 51, "Bomba", 24, "https://images.unsplash.com/photo-1673126167141-3c3e59e99f54?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE5fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 52, "Bomba", 24, "https://images.unsplash.com/profile-1642093962150-d1951187eb26image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 53, "Bomba", 24, "https://images.unsplash.com/photo-1668467927849-f770914911a4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDF8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 54, "Bomba", 24, "https://images.unsplash.com/profile-1664699035313-ecbbdcab73acimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 55, "Bomba", 24, "https://images.unsplash.com/photo-1673359193906-b6694fdc0139?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDJ8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 56, "Bomba", 24, "https://images.unsplash.com/profile-1604758536753-68fd6f23aaf7image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 57, "Bomba", 24, "https://images.unsplash.com/profile-1593541755358-41ff2a4e41efimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 58, "Bomba", 24, "https://images.unsplash.com/profile-1516997253075-2a25da8007e7?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 59, "Bomba", 24, "https://images.unsplash.com/profile-1648828806223-1852f704c58aimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 60, "Bomba", 24, "https://images.unsplash.com/profile-1635425197470-04119ef8fe14image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 61, "Bomba", 24, "https://images.unsplash.com/profile-1577555332996-ef4615422a5bimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 62, "Bomba", 24, "https://images.unsplash.com/photo-1673050460660-2bd7b3bb25a4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDN8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 63, "Bomba", 24, "https://images.unsplash.com/profile-1664463803851-04da02eaa782image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 64, "Bomba", 24, "https://images.unsplash.com/photo-1673188796938-5975e079b68d?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDR8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 65, "Bomba", 24, "https://images.unsplash.com/profile-1647285210525-979466ffc225image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 66, "Bomba", 24, "https://images.unsplash.com/photo-1673192573046-efc73501bd5d?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDV8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 67, "Bomba", 24, "https://images.unsplash.com/profile-1673842222975-f2873955e8d2image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 68, "Bomba", 24, "https://images.unsplash.com/photo-1673842449987-3c7d56e5b1cf?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDZ8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 69, "Bomba", 24, "https://images.unsplash.com/profile-1673842222975-f2873955e8d2image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 70, "Bomba", 24, "https://images.unsplash.com/photo-1673842450064-e9a1197e1a66?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDd8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 71, "Bomba", 24, "https://images.unsplash.com/profile-1604758536753-68fd6f23aaf7image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 72, "Bomba", 24, "https://images.unsplash.com/photo-1673790120533-12697d88aa59?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDh8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 73, "Bomba", 24, "https://images.unsplash.com/profile-1630067068170-6dc3b96f0f40?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 74, "Bomba", 24, "https://images.unsplash.com/photo-1673667617558-91300594284c?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDl8Ym84alFLVGFFMFl8fGVufDB8fHx8&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 75, "Bomba", 24, "https://images.unsplash.com/profile-1644497773238-4bfe9624f353image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 76, "Bomba", 24, "https://images.unsplash.com/photo-1673643654783-262d176c86d4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEwfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 77, "Bomba", 24, "https://images.unsplash.com/profile-1604758536753-68fd6f23aaf7image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 78, "Bomba", 24, "https://images.unsplash.com/photo-1673643203499-23c29eafead7?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDExfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 79, "Bomba", 24, "https://images.unsplash.com/profile-1662028865407-6df71fad63a3image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 80, "Bomba", 24, "https://images.unsplash.com/photo-1673433107234-14d1a4424658?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEyfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 81, "Bomba", 24, "https://images.unsplash.com/profile-1662762270762-06d6156dc577image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 82, "Bomba", 24, "https://images.unsplash.com/photo-1673446932312-413e564c5640?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDEzfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 83, "Bomba", 24, "https://images.unsplash.com/profile-1662762270762-06d6156dc577image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 84, "Bomba", 24, "https://images.unsplash.com/photo-1673446932465-a67b5bdd3d4f?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE0fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 85, "Bomba", 24, "https://images.unsplash.com/profile-1557995124272-d62d831ec026?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 86, "Bomba", 24, "https://images.unsplash.com/photo-1673380823385-75929e08ea89?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE1fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 87, "Bomba", 24, "https://images.unsplash.com/profile-1662762270762-06d6156dc577image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 88, "Bomba", 24, "https://images.unsplash.com/photo-1673447111351-d83b5376a9d1?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE2fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 89, "Bomba", 24, "https://images.unsplash.com/profile-1584911053267-6be58094ce41image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 90, "Bomba", 24, "https://images.unsplash.com/photo-1673350018635-72ce4469e0f6?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE3fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 91, "Bomba", 24, "https://images.unsplash.com/profile-1577555332996-ef4615422a5bimage?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 92, "Bomba", 24, "https://images.unsplash.com/photo-1673292480069-7ebbd87081f4?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE4fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 93, "Bomba", 24, "https://images.unsplash.com/profile-1660203829473-fcd6e34021b1image?auto=format&amp;fit=crop&amp;w=32&amp;h=32&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 94, "Bomba", 24, "https://images.unsplash.com/photo-1673126167141-3c3e59e99f54?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDE5fGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null },
                    { 95, "Bomba", 24, "https://images.unsplash.com/profile-1666172203856-ceab0ceadcb7image?auto=format&amp;fit=crop&amp;w=16&amp;h=16&amp;q=60&amp;crop=faces&amp;bg=fff", 24, "Super", 1, null, null },
                    { 96, "Bomba", 24, "https://plus.unsplash.com/premium_photo-1673264730462-6b4acadcab25?ixlib=rb-4.0.3&amp;ixid=MnwxMjA3fDB8MHx0b3BpYy1mZWVkfDIwfGJvOGpRS1RhRTBZfHxlbnwwfHx8fA%3D%3D&amp;w=1000&amp;q=80", 24, "Super", 1, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Wallpapers/647", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?3D Renders/333", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Travel/44", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Nature/617", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Street Photography/464", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Experimental/378", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Textures & Patterns/52", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Architecture & Interiors/920", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Fashion & Beauty/901", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Film/8", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Food & Drink/396", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?People/126", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Spirituality/193", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Business & Work/325", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Athletics/343", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Health & Wellness/586", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Current Events/36", null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "catagory_id" },
                values: new object[] { "https://source.unsplash.com/random/?Arts & Culture/392", null });
        }
    }
}
