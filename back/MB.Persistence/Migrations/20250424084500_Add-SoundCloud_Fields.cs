using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSoundCloud_Fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "04/24/2025 10:44:58",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/21/2025 16:16:48");

            migrationBuilder.AddColumn<string>(
                name: "EmbedUrl",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("23634c00-0f27-4c04-b718-dfdb53dd816e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2160), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81b6c740-fef2-466f-90a6-c72dfa71ba04"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2173), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77d698b1-3827-456b-927a-0a1f8670e4e3"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2176), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9e193544-1848-452c-baeb-79a06984c2c2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2188), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b01adbf-db05-4dd0-a057-bba299161a19"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("db4d2212-915f-4b26-9a63-4d1d35d13d83"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2195), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96064b9e-a4a2-4f2a-a33a-8f438e0be4c5"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2197), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5638f60e-f3c5-44eb-b5fe-f9b8931c14ba"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2203), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4cca8438-0ef4-4b68-b7a6-03c924ec9d25"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2205), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dbd9037f-a61b-40d1-a4da-68638151411c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2268), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6895c468-fed3-47ee-ad41-65f272847835"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2271), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a003728a-4b12-40a6-80bf-4d4c4de0bcd2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2277), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d2b5b00b-a954-484b-ad14-45d1173051ad"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2279), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c31da3de-9c8a-413b-9c23-2d661c10a9a7"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2283), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("07a56128-bcad-428f-b5e5-016fb7daa6d8"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2285), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6280eae7-b5df-42fe-b491-04882d8acf30"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2289), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3be949fe-a042-4837-8f75-31947210348e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2292), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8598e498-173d-4fb2-baa0-fee7518f6881"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2296), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f8ce9ea5-c4b4-4ccd-b2d6-86b06c334c64"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2298), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b8125c7a-07f0-45ba-9d09-191abb9dd06a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2303), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2abb33d3-81b2-4009-a2ba-9763f3c5a96d"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2305), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fb0bc4b5-ea29-4929-a9b9-9b21abaadc22"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2307), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99053aa3-a858-4025-a35c-a6128e785ce8"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2310), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3d9df420-caad-4bd8-9144-1d581091e7a8"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2639), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a14042a-d2e2-4823-b5a7-8ffdbfe17e3c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2644), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4d76b86-ada7-4a5b-85e6-ac8ec48dd65b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2649), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c6e464f-9a14-4ccc-924c-d2997950271a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3088), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fbc6305e-9159-4ec8-8422-e1b349638ee1"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3093), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f0624200-fb41-418d-b5c5-935b90527fcd"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3132), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("49b6db68-2cfd-4d5a-9783-e8e8ce5c4611"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3138), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dcc93e92-7314-4a96-9e4b-5976be846b0e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3141), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77227a03-2928-4285-95f1-62efb778b650"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3144), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("454a2bc4-ecea-448e-ad9a-24e501fe3edf"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3147), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("819ad20c-6346-42f7-8a30-872eee7c5e0b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3151), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c683db1a-9ebc-4994-a408-5c81969827ac"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3153), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bfaa9362-9b62-4e3a-86c7-a2cda683a0e6"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3156), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("55b5d5ea-917a-41f0-87bf-bd3b636236b2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3158), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a125f5b-1f22-4ce6-ae56-4f5301b2f839"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce724c95-7d51-4996-9e74-a6c0179c789f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("707c2cdb-1c83-47ab-b4ee-4db060ab6d37"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3169), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a7bb10c5-f1b4-4a3a-b94d-f0dcb41fa9df"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca741a2a-919b-42a9-9eeb-97f837439cf9"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2917), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70681449-7eb8-4f0f-8c46-209a0fc89219"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2925), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c0d735ff-623b-44ec-9807-b4f48b650d08"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2930), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3cc80bd3-ffeb-40f4-ae6d-a5e0cc0fdcad"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2933), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b0388f7-aaeb-4303-a10f-46522176f993"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ceed271-65fa-4dd1-9629-c0fb248350df"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2939), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17274de1-f108-4336-a1cb-47376479e93a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2943), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("592f80c5-9fd5-4172-9ab8-05b95519799d"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2946), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a799c33-9f0c-45a3-b769-0a386d521fab"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2948), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8d984da3-625f-4820-87e4-0000b40403f7"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2951), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b8c08634-c3b3-4553-a5a9-a478c90bebd8"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2956), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81efb30f-aa02-4efd-a646-20beb7fd6f74"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2958), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("71920522-b6e4-4d39-b7be-499637dad71b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2961), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("570b1871-347e-45c9-beaf-3e596d173d17"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2963), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a63aec48-b186-4c8d-8eb2-997d89fe7106"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2968), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ec9de15b-dda5-4040-8ecd-ced7269467c6"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2970), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4051d780-02bb-43f6-942b-977a2a23dd94"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2973), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b0ed9832-e26a-4c31-8ebd-9b3e4ef92834"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2976), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d90d5040-5d96-4244-a21d-b2929b2f12cb"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2981), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2f865c3-f63d-4d3a-b5d3-ca5c22b17fa2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2983), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb287194-da83-480b-9629-0294b38f6b5b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2986), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cd21a953-1b95-4b8b-b757-77e965a1ec38"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7cb6d232-ab55-4ab0-915e-c7b2f20039e4"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2993), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a574956f-5b4a-40a1-945e-a4891262bf16"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2996), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6e8f3a7-0fd2-4f4c-a5c5-bde78fb06207"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2998), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("720fb265-0d40-488c-b038-710512ad23bd"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3001), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8f60b402-7312-4c19-9329-747301754b61"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3005), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ba52e800-d10f-4429-ace9-714528d938ce"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3007), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9d81f256-ec32-40f7-9c3f-c88d7ff9e2fb"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1c83ecb-b2fd-46dc-8d47-c6b2a806d80c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3012), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6a3c7fc5-bb07-49c2-92af-b4871c909a0f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3017), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3e8c1e8d-2957-461d-91a1-beb2c19743de"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2692), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dd2c823f-4e09-45da-b47f-5259206892fc"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2697), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a829941-14fe-4eee-a1d7-144371e9a69f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2700), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00e5e24e-17dc-42d9-b8fb-73e95c982916"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6cbe5093-4ed1-4cd1-8792-04c6a32165b1"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2036d956-c6ee-4b6c-8560-f3fea090aa67"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2710), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c0b3c55-a3ed-444e-bf14-32fa19e68a88"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4b4de85-8e2d-40ce-a064-d58ee0fc7d22"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63c718f0-a2ae-442d-bbeb-82d8160a5e41"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2719), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d9438d5f-25f8-4191-a8de-62a0642180f0"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3379), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("83c326d5-d072-42b9-968d-73f039713c26"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3386), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a90e7069-48d2-4ca8-a86b-b325494f335c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3389), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3438), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3453), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3460), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3464), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3468), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3472), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3479), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3482), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3486), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3491), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3578), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3583), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3585), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3588), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3593), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3599), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3603), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3606), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3609), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3612), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3690), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3744), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5b989d1a-f171-462b-a8a7-648bde0003e6"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2490), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("64e06971-c76d-4312-9e99-130a5515e270"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2495), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5ab648a-7189-4e3c-a5d6-1f944a30f636"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96149b1d-116f-4fa9-b351-562523f8ba63"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2500), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("71232b0e-02af-4c24-a36c-6e0c00d8e21f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("799fa29d-0b28-4147-8109-ae9c48d766e0"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2508), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3131628-f64d-4208-b4a8-9b45d8dc22d1"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2510), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e52e936b-7cdf-4fda-9bb6-70520d0d4982"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2512), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("49d4bc46-22c6-4b98-845a-04c2848ce27f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5cdedabc-df80-4770-8626-56e375766901"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d08b4b21-785b-4e55-9b27-c315283feb41"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4600), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2321e961-8757-452f-bf21-698c0bbb863e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4607), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82a732e1-1cb8-46a8-b14c-a665e80e4f6d"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("78a092e4-6465-4b96-b8a5-b1006c0bbc4e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4614), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c4eb791-915e-4109-8034-100701c582d4"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cd312d6c-67f3-4407-8371-716702acf62b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4620), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8397efdb-8311-4b92-a0d7-20f7e084bbeb"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4626), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf922d24-6e80-41bc-a9a3-60e3e8d553ac"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4628), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cc273871-b34d-4111-8632-01b495644eb4"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4631), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("28865d46-352f-4f76-bab5-abf752c1dbed"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4634), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5f1bed83-6cf5-4af3-97b1-a050ec43fef1"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4639), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("26a5a218-6bf9-447b-b1dd-9a8e62583ca2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4641), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("caf90c9d-7ee7-4f5d-9db3-b46269bb2608"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4643), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94a7b6ab-99fe-4038-8f76-27e101dda00f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4646), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02ded629-49bc-47ed-88e0-12b611db3c3c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4651), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d03dd0d-87fc-42ca-9ac7-6d9d190fac6e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4653), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("000ae114-dc42-4e8d-9589-524d36ffb58c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4655), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb656a8a-0972-4ed8-aeb0-87bf56f824e2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4207), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09aa0a97-0983-404f-bafb-a19e8b2ec178"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4218), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("da68c81a-f319-468e-825b-d6aac7540e9a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4221), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("33a1f2af-75cb-4170-8397-7dd038d18290"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4223), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8b1aa0ed-dbdb-45b3-900c-424625ee1d55"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4226), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2dd7585b-2972-4d04-8165-9128553df506"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4231), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7c9574a0-efb9-409a-b830-a33257504f73"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4233), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d116ccdf-fb00-4156-86f2-48e92156322a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4236), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ee02b79-de3c-4919-afb8-47bf1dbdac38"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4238), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b8791ff-3a37-4d8f-9194-4641bf986ee2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4243), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("643c040b-d538-4eb8-bd27-d1adf36eb181"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4246), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15d531d4-3ca1-4bf8-9394-f97896a1c126"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4248), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("51d49ff8-a31e-465d-ab90-58e6d5ceffc9"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4251), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f4cb11d7-12ee-409e-abf3-f9d2679175ba"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4255), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb1d3c38-c6a9-4724-875d-1798b2e3d7bb"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4257), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("260775a7-3899-4a58-85d9-77bf5a60f2de"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4260), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d6b518ff-6b90-4d84-9e63-89ebd66d66f1"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4262), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9da91bff-9e22-478b-aa6b-30728ffbeb59"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4268), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cff5430d-da46-4930-b80d-934da9c0a189"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4270), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("66ded92c-c9a3-43d1-8c5a-9a82ced7226f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b2f2c60d-d005-4cd9-9bae-be50ea83cf2b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4275), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7472dafa-5b64-4604-9a1a-fcad42ba1542"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4279), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b36ab372-8cd1-4705-8599-6d765ec1bf7a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4281), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5bed9cbc-bb50-412e-b325-f6e3e647509d"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4285), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31bc935a-a3b7-4521-a3fa-82f5ff3bb4ce"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4287), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("28bac22e-1c41-41f4-8f59-638bc9f1df85"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4292), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0fa361ed-b032-4980-9fff-efbc12e11ff1"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4294), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("07a72665-d8c0-4ed3-b7ca-2e3db3e17dd7"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4296), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d8d6fde5-2a2b-423c-ac9d-ce5207fe1679"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4299), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4db7c0f2-7bfb-4b26-8908-8d4dc10df3de"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4303), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9cbf44de-136b-4422-bc88-5e2a54210fdc"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4306), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("304875a0-f51c-44c3-b00f-75f664793235"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fe97ee2b-ccd9-4d26-959f-ff5be83d17b6"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4310), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8621e027-5182-4b5e-8850-9e2733330167"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4316), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4565b5e-ce34-49aa-804a-1927c045701f"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4318), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("54f47692-f5bb-4709-870e-4ed243cfda67"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d7ceda2-03da-400c-ba6d-cb109dfc9681"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("053e7267-e0e5-429e-be21-750d70606f7e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4327), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adfb882c-1e1a-427f-a048-7f1639ef4e65"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("23623b28-1cce-4fda-9604-ddec25ae0ba5"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4332), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6406e42e-e421-4028-8ba1-4332275d79f5"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09133f61-f5ad-4a6f-a12e-e19a0b905588"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4339), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("927de08c-3aa0-4bc7-8461-b460f3c703c0"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c90230ff-91f3-40d0-b994-a9e5b157a79b"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5bca56af-f462-46cd-b4ac-151d36c59ee2"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4346), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05d07f11-8120-4a0d-a986-67335b6efd7d"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4351), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2b7d330e-001f-4961-80c8-c32ff51fce8d"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4353), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4849a34f-2371-4e60-a36d-96db6695f446"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4356), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3e5f2db1-1112-4dae-a063-08b558bfcb51"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4358), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a0f80636-4aa8-4553-9e34-9452decea625"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4403), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f3ec88d5-f487-45d6-b909-743e806f1ab4"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4405), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22ab11cf-a6ff-437e-891d-1f31e0e1e8fc"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4408), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("57cc5463-146f-4244-a154-8f8cc3cbd5e9"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4410), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5c59dcf6-7b0e-454a-ac94-d17c09ab10ed"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4415), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a8bb82f-3365-4e61-81ad-3c4df9bf7d7a"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4417), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2620c882-2e53-4442-a1c1-86dc8e700aea"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4420), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4cb0209f-8aec-4b01-9a35-b66b49f45d74"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4422), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("67a9b41b-737b-4079-b80f-53a22c089e8c"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4426), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c3fa9fcf-4d20-4488-9b43-2127f4b8bddd"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("602e3935-99de-4470-97fd-9b823c762f8e"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76a68f58-82d8-4c61-8203-ccb627d7ec48"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4730), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4cc9246-55c2-466a-ab81-9afae206daad"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4732), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f17d8e54-d19b-427e-9510-1a53cbf672ae"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("75973724-a35f-4efe-beb7-7235de02d9ed"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4737), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("548c2b42-75c8-4d40-80c8-475e2124d981"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4785), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4784), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4781), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("73c753ea-c51c-43fe-8dcc-b0b67745cb60"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5251), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5252), new byte[] { 243, 228, 235, 35, 205, 245, 188, 17, 157, 47, 36, 244, 11, 173, 131, 92, 204, 155, 1, 255, 175, 53, 75, 134, 0, 36, 95, 12, 180, 243, 231, 59, 62, 247, 253, 64, 203, 253, 9, 87, 51, 166, 240, 151, 164, 132, 15, 66, 60, 101, 7, 232, 124, 104, 6, 174, 133, 107, 217, 36, 51, 238, 164, 228 }, new byte[] { 206, 7, 56, 139, 252, 107, 81, 81, 44, 205, 218, 22, 12, 110, 132, 113, 51, 23, 158, 108, 86, 2, 213, 180, 246, 135, 175, 155, 100, 41, 20, 185, 72, 230, 42, 178, 123, 210, 218, 144, 231, 57, 129, 156, 12, 9, 87, 216, 202, 239, 39, 237, 14, 117, 62, 183, 117, 194, 184, 114, 212, 210, 88, 183, 111, 208, 1, 251, 79, 222, 71, 253, 78, 193, 251, 236, 35, 6, 59, 5, 174, 25, 206, 182, 228, 237, 35, 60, 230, 71, 152, 234, 254, 205, 78, 48, 104, 213, 201, 191, 250, 16, 143, 132, 234, 184, 201, 141, 211, 40, 180, 34, 226, 128, 127, 167, 177, 9, 28, 146, 114, 5, 72, 0, 176, 28, 194, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("4e5cd7d5-eb50-496d-8875-e2c6cbc14f27"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5334), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5335), new byte[] { 112, 68, 175, 62, 138, 60, 111, 184, 234, 159, 234, 231, 36, 30, 191, 105, 124, 220, 121, 173, 32, 99, 31, 86, 40, 159, 69, 174, 234, 254, 73, 135, 136, 192, 86, 205, 126, 226, 158, 231, 178, 96, 92, 76, 26, 132, 159, 47, 95, 77, 79, 91, 54, 148, 108, 228, 199, 90, 38, 146, 189, 233, 111, 64 }, new byte[] { 9, 99, 205, 193, 197, 100, 143, 206, 177, 196, 70, 92, 109, 146, 203, 198, 223, 32, 221, 74, 147, 218, 167, 211, 18, 59, 84, 78, 188, 155, 187, 42, 56, 237, 186, 55, 34, 13, 113, 209, 11, 109, 87, 172, 53, 185, 73, 14, 75, 227, 38, 57, 211, 148, 129, 8, 115, 252, 132, 133, 223, 249, 10, 86, 126, 110, 165, 154, 96, 222, 22, 243, 236, 178, 112, 222, 142, 129, 181, 7, 162, 129, 109, 76, 201, 184, 165, 0, 247, 85, 178, 194, 3, 18, 101, 199, 190, 123, 193, 62, 230, 211, 3, 38, 227, 98, 228, 145, 100, 227, 179, 92, 70, 169, 123, 169, 46, 42, 78, 208, 112, 81, 164, 28, 53, 252, 139, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("57c88f72-3e65-45e1-92cc-42d2c645efac"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5393), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5394), new byte[] { 39, 221, 85, 88, 104, 188, 92, 205, 247, 120, 202, 27, 15, 12, 45, 122, 95, 55, 253, 42, 217, 196, 207, 50, 175, 222, 248, 15, 202, 86, 111, 40, 67, 117, 254, 192, 142, 190, 233, 48, 170, 247, 47, 173, 76, 46, 171, 41, 114, 89, 172, 240, 216, 5, 48, 41, 90, 72, 250, 5, 32, 156, 24, 243 }, new byte[] { 160, 92, 221, 137, 91, 227, 204, 183, 239, 188, 157, 38, 86, 153, 38, 116, 97, 249, 123, 207, 207, 105, 246, 58, 246, 58, 169, 1, 151, 115, 185, 106, 77, 216, 50, 171, 206, 161, 109, 151, 38, 87, 8, 192, 116, 230, 148, 118, 235, 221, 72, 80, 243, 80, 184, 106, 144, 3, 235, 50, 161, 146, 248, 235, 3, 168, 84, 212, 17, 229, 114, 93, 165, 183, 213, 122, 70, 114, 244, 183, 121, 15, 109, 77, 23, 43, 182, 200, 142, 91, 203, 113, 103, 58, 44, 65, 105, 198, 74, 15, 130, 59, 6, 242, 99, 97, 100, 128, 239, 134, 255, 142, 239, 215, 55, 20, 120, 83, 158, 113, 216, 52, 106, 151, 95, 246, 148, 237 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("ba32d4d1-8536-4a4c-a5e3-68e0c55e8374"), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5450), new DateTime(2025, 4, 24, 8, 44, 58, 242, DateTimeKind.Utc).AddTicks(5450), new byte[] { 166, 72, 153, 81, 137, 54, 48, 190, 44, 46, 160, 127, 45, 24, 90, 145, 68, 62, 19, 182, 53, 29, 38, 233, 176, 217, 33, 93, 194, 104, 62, 194, 172, 71, 17, 172, 246, 143, 231, 222, 18, 128, 161, 153, 9, 45, 226, 77, 169, 157, 27, 238, 207, 214, 134, 228, 47, 203, 45, 141, 127, 111, 95, 70 }, new byte[] { 131, 154, 24, 55, 92, 120, 88, 5, 149, 135, 99, 30, 27, 99, 92, 134, 223, 14, 3, 173, 216, 234, 142, 97, 149, 170, 116, 110, 203, 252, 91, 21, 232, 142, 74, 102, 242, 162, 145, 29, 197, 25, 218, 7, 14, 108, 72, 86, 176, 7, 75, 213, 142, 203, 119, 252, 102, 22, 94, 241, 172, 20, 102, 49, 56, 152, 81, 248, 150, 165, 223, 143, 39, 76, 242, 82, 89, 18, 93, 98, 36, 48, 126, 216, 58, 175, 206, 165, 12, 104, 81, 58, 45, 214, 63, 83, 249, 0, 21, 26, 229, 173, 53, 1, 204, 165, 65, 131, 13, 52, 30, 56, 61, 45, 94, 186, 146, 190, 191, 26, 1, 195, 111, 5, 236, 41, 223, 21 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmbedUrl",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Moods");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "04/21/2025 16:16:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/24/2025 10:44:58");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("146cf1e9-2426-4282-9da4-68bc006c8e74"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1238), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("170ef61e-7c45-41d3-945d-193cbf25bdc1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1252), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fe105f22-e819-41b2-8130-2ef294c95878"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1255), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aa08397c-13e6-4c3f-8dc7-bc4787819518"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1258), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8f9bff5a-d72b-47aa-81ea-8628c869fdb1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1264), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8e7fefea-3aab-4382-adb9-4e0cacafa905"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1269), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("efb4d174-4631-4830-8681-cecaac64929d"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1271), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7d418d2f-60af-448f-a4a4-b83030da3d64"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1274), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40ab667c-bfa2-4ef6-bc21-acd0085d116e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1279), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2bba982d-4f4a-4150-a8c5-c8ea941fa23f"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1283), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cac5e592-f7d0-4fb1-a6b8-109ef8a94a99"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1286), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("78f2bbca-945d-4d88-a588-966ea2cddca2"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("21dc4cbf-5b9b-42a1-a332-74d1d390ae38"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1293), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf3a7701-c45e-44c2-bab2-0ff4cf6e3107"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1295), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("021944ea-f19e-4703-b83f-868069eb42fe"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1298), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a0ba59ce-4988-4d0f-991c-a2f86f4f20c0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1300), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7c9c44f-57ef-4487-af3f-5290dc29f8c6"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1305), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("633baf0e-0634-4f5d-9c70-0e18562fa94b"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1376), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e358ed8e-02cc-4016-8efb-5e9f0cc50cae"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1380), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4db5d504-7fbf-412b-b9fa-e50319c3b9b3"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1382), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a015ceb7-4520-4275-85b1-67b5e63f52a1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1388), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b194e7e3-33d0-4e96-8376-11d21dd55650"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1390), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1799729a-5e71-4010-a8d1-11ddde9fc055"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1392), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("922543b2-09fc-47dd-9368-02a790c463dc"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1803), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99db88b3-e269-40a6-b6d1-eee504015da4"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1809), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca6646a8-4f2a-438f-be2d-2ca137618ba5"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1813), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca44e74c-9a47-4932-88da-944a26f0bbe0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2294), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f3bca58-3fc3-40ac-87a1-1c2fd68015eb"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2301), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("42926187-e86d-48de-9910-45b52bb7bfea"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2303), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88210f2b-f385-4b4d-9c97-b1debc3d3630"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2306), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40c4d3f2-deb8-4716-925d-0dbabf996fbe"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2310), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4541aee-d8b2-472f-8485-f2696688c4a9"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2314), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8e55d966-8e05-4d47-b536-97477cb2d8ef"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2316), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a0be2dae-8258-4e49-b967-1a98eeb101ae"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2319), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("12a901ca-190b-466a-877f-54132f607b12"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31eb18a2-c98e-43c0-9b5f-e05377edb516"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2327), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fa13f53b-b4ad-4ad4-a7c7-7bfed049e7cf"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2330), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("884e6dd2-4672-4b60-bb62-6c932741e502"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2332), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f4080549-69a6-488c-836b-8e36024e3bf3"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2337), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("907b6da8-47e2-4172-bb2e-5d5eee576d1e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2339), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d1ee3c8-a8be-4bd7-88a7-b1b2934a2484"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2342), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("92c535ab-b245-45ab-9f30-f79ef97c20d3"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2103), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("963a71d9-17b3-4053-9a30-8409166e00c0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2108), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("66d140c5-e068-4376-bfe4-23de6f7bbf90"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2111), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f97061d7-f972-48ab-b65d-710d4aae287e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2118), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e1d816b-1ca6-448b-9422-a8352a957cf4"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2121), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a79c6948-bd5f-4d38-b88e-61f754777317"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2125), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fa08be28-8a3d-4ba8-aa1b-fe56ec61810a"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2128), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("120a1a43-9d9e-4db2-88cf-3b8332d6e5f8"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2133), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e68cba04-a16f-4d7b-a607-a91ef20e6371"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2135), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9ee6ea79-8f52-4e7d-af0b-497bc1f2db10"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2139), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97e05b7c-164d-4289-8ba9-bdb6be2d7e4e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2141), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4843ee50-b9aa-4215-ba0e-12e0355add68"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8f177cd-d51d-4fbb-81e2-0340088be630"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2149), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8b23cd8-a9f5-410e-b565-03add719f870"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2151), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c05a5c4f-a78c-44c7-a7f1-60e29536662a"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2154), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("df455711-6a8b-46df-b79f-3e182611b4d5"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2158), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0fb11071-0508-4cca-acb7-0bc7d7d31b2e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2161), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1c3056b0-0266-4916-abe8-0fd4224f06ae"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2164), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e404d4b-ad66-4eef-ab74-f50fe4e3fded"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2168), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("84b11926-8add-4abf-99dc-7a0d5f52a441"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2173), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01fb8fe3-c596-429d-97f4-c78a9d5e28e2"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2175), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b03e20fa-999f-4bac-a05d-865c88981149"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2178), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0a65719a-ce29-4ba1-a6bc-f78121f0989b"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2180), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3169b4fa-d31d-4f29-a192-cc039e7a1c77"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2185), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d6ba1a79-f462-48ab-8e5d-c6f9cb0fb4fe"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2187), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d908ca64-669d-4670-acca-61e437e21958"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94a6a584-3d54-472a-8c5a-3cfaad2515f9"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2193), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("189050d0-c7db-4142-b195-5202d3c16345"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2197), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d699acd8-bd20-40d6-b042-50c82b548bc2"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2200), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("183906ba-4035-4c9f-826f-da8585483914"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2202), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("956298b0-9fe5-4e2b-8512-f6c75cb1bfc9"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2205), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1226dcba-a2e7-4ef1-80cf-791bbd7470e7"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1863), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("353ba6d1-36cc-4060-8ac5-1d8073d545c7"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1868), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("32025ef8-98d1-4175-b98a-b7a5674d2b55"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1871), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("702e9c52-793a-419f-b30b-f96b43e55e03"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1875), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6b0ea01a-9c35-4a5b-893e-3a1e5b1e1ece"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1880), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77881dbd-b1cd-4a9d-9b5d-ee39ff53e832"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1884), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c00c7468-8fc4-409f-9fbe-1bf999604e7a"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1887), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("26b4f8f7-2202-4d51-8239-bad55e5926b1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1890), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31eda03c-4483-4198-b76f-1defbd44588e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("051bd2d2-386a-41c8-a68b-8fb2fb6107f8"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9e8be2ca-8890-4628-b69a-bb664aeac37c"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2730), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f931276a-7788-4c01-b62f-f291d93d4306"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2734), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2831), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2849), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2857), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2863), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2875), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2885), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2892), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2899), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2913), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2919), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2925), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2936), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2941), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2948), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2955), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2962), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2970), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2980), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2985), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3076), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3085), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3092), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3252), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3360), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d502dae3-6fd8-4969-a66c-58c316d7cbaf"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1624), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("312b346f-bf8e-4ccf-aff0-7c133db9e5b1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("056570ae-d8ae-4dd4-a346-213ceea3929a"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1638), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e2def073-6391-4840-ae3f-1a7ef4084024"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1641), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1c2d57ec-2fb4-41d5-8c63-b861c108f6eb"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1643), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e48abdc-e2b9-4c79-88bc-d45720edd1ba"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1650), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("271d6073-a1b5-4dca-85d5-5b3f55e239fa"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1652), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6e941a8c-3ad4-4fe4-9cd4-84fd35622bce"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1655), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f799b33d-2e31-4d02-952d-fa089aca44dc"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1657), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("21ab1bd2-cf7f-4340-8587-6548c41b018f"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1663), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ec9a7bbc-6d7e-4b85-9711-0cb1ba9fd84d"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4354), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4cae43f-ade2-4146-948e-56e3b4596fc4"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("33d3b5ee-5ae9-4b17-9396-385b5cb4fc19"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4363), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2acfe1cc-8885-460a-9ea2-235896c4a444"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53c2cb84-5d81-47f4-bde1-3de6a2a68805"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4374), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("07d4cfeb-275e-4359-a904-7b94c4422b99"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4379), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f35aad2-d3af-4f64-812d-4a607880f256"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4382), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0dc01a5b-5ebe-4445-ad07-e921db5e5697"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4387), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("961d58a8-5b6a-4a8f-8e21-50ff1e579832"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("affa2a8f-1e25-4ee9-a4f9-9a4a3a299ddc"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4394), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("807dce70-3cbb-4fbd-8125-85f50c509957"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e482498-f196-428d-9626-801804879738"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4403), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0cf69978-c6e8-485f-b3da-ff6eab735ed6"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4406), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3682bb09-1174-4384-bdf4-36a27c5a5a71"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4409), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0d1930bc-562c-448a-9e04-6cd5b0ed1a35"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4412), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8eebf040-ca0c-4d75-8168-6ecbfc63c3b0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4417), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8f83fa0f-ee53-4d3e-a451-612c7ffb28fa"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4420), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a805c62c-f0dd-411d-990e-b520497d499d"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e5e85de0-b7fe-42dd-b9b2-4bee21edfe0b"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4023), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7bb2772c-27d2-4385-b605-0cdf59dff443"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4031), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c5273aff-12f9-40c4-adc8-fe0ce01c5c70"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4033), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("89f57d6b-38d9-4e58-8618-ab5624b67740"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c59b2485-771d-4eeb-916e-7e6678aa202e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9398a88-2de9-4585-a672-4b2fe867319d"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4044), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fa2591e-6c91-4af2-88e1-f57ea1d3f09d"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6384f85-658e-47ea-8f68-738621418548"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f34cf5b8-0c61-4995-aeb6-bdb076527001"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4052), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ba51ce48-d19e-45c5-928f-f175bc8ce3d0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4057), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6b2d1f62-682f-481c-9245-ccf5373c16f4"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4060), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fd25b95b-4ecd-41a7-88dd-8b75d29325dd"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4062), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6aed2d3-be42-4095-8544-3cded57feba3"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4064), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d19f62ac-9a3c-4389-830a-68d12c20bc61"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4069), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3964e69-c1e4-4a8e-bc0e-309860c3c052"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4071), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("730c393a-fa9f-4551-99c7-760e130bbc10"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8797dc74-e414-44c3-a954-7f96c472d179"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4077), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bbf01adf-b1a1-4cb4-9c52-9d25aac08986"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4082), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5c12951-b91c-4299-9f7e-38c9ac407f5c"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4084), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f1343f49-5632-4f8e-96e1-5a247983dfbe"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4088), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("141c255c-6639-43f6-ab43-d37b48a65101"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4090), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ef1a9fe7-86ed-4f1d-b3d9-fdb902bb8bb0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4095), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a29d4f64-da45-4c9e-899d-667e64d31f14"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4097), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b1e7510-cd02-4a3d-ad2a-04390d9172ff"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4100), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("acf52c3a-a69c-4971-80b9-1b67d3d9c0ae"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4102), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3370ef82-bafb-4240-9851-60b45941c816"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4107), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82308f0c-9529-48db-938f-be0edd97726a"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4109), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81d8bf48-abe4-4fef-874a-e4978d612770"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4112), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4eea340d-7220-4548-91f9-2be60eab516e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4114), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8d8c221-0cad-4e39-ab80-68fd6fe95663"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4119), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("edf08791-daa8-4de8-8056-4f8fe2cef4a8"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4121), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3adf28d9-a9da-4dfe-acb0-345887ab0686"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4124), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("27d5df6c-3cd4-4195-a152-d8e7815f0e00"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4127), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("812d8fec-0286-4431-914f-5fec018ea760"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4132), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d438812c-f950-40f1-8b72-49527096fa3c"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4134), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c28ba68-de0c-4c27-a216-4fa665f4a42e"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4137), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c42be781-4a81-4744-a3c7-582208a71eec"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4139), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f83d78e1-dc53-42f5-8810-57cfdcd8bf02"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4144), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e20bf3a6-69de-49b8-9b32-cf3e59ed7204"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4146), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("39a03afb-54a4-4f69-b46d-99a6b4a93f02"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4149), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35f6de74-3d5f-4704-91bf-67ea94dc6d16"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4151), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("84527b62-283c-41cf-b401-2e395706994b"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4157), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cd6b1fba-ae17-4911-a157-f672d98ad368"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4159), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c3474d63-cea5-4dbf-a691-8c02a4bc54dc"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4162), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("493c0120-956a-44fc-ad34-84de4e31d98a"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4164), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c6405e42-343c-4fb1-8ade-5d2c81b338b6"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4169), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fb9b46a9-5885-4c41-9845-43c5df7502a3"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4171), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3862bc8f-87bb-49b1-91ad-881385ae553f"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4174), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62fc554e-58ec-4c3b-b258-175b2a63b1b1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4176), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3fa18361-cf38-4023-ba8b-cb4f19133bf7"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4181), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d0d841dd-1a2b-48a9-80cd-58e03ed3e129"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4183), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5bcae623-fee0-4925-9d79-56d71e738b1d"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4186), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("83f241f4-abd6-45c6-ab7e-7d818f5d37d5"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4188), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("da969a41-6cf1-4270-8273-91a2368c03fb"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4193), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95c2a62f-0021-4c06-9a88-dd0726e32495"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4195), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae4ffe14-bc18-42b8-b1f9-14380cdba0d7"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4198), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b481d28-b524-40b6-ab46-d9f8552c31f8"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4200), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb6f70b0-00cb-4f38-b102-ab592dc9768f"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4205), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("afd568a8-ff56-4d48-a2e0-0f0367bb9f26"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4481), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87eb1767-5f6b-4449-ab0c-6e39de623d07"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4487), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf42e875-f35e-4778-8ae4-e81b0743aff4"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4493), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("072e8b8f-17cb-48b4-b3f8-5aac2eca4586"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4496), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f0293ff-34fc-4eb4-bf87-0670b5efd2e1"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4499), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("0b71aa0f-d9d9-485b-9c3d-44755d6d0cf2"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4548), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4544), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("dfae075f-b927-4adc-8dd2-abb4882c854c"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4965), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(4966), new byte[] { 105, 241, 128, 147, 125, 180, 119, 119, 221, 9, 200, 142, 210, 17, 55, 212, 47, 51, 17, 23, 147, 183, 188, 30, 171, 151, 210, 228, 106, 46, 172, 135, 71, 105, 101, 37, 99, 215, 179, 249, 237, 189, 97, 200, 55, 128, 116, 244, 55, 10, 77, 132, 154, 179, 169, 220, 17, 176, 137, 185, 244, 191, 112, 98 }, new byte[] { 250, 228, 219, 255, 108, 7, 32, 2, 226, 215, 96, 160, 48, 166, 84, 90, 180, 12, 211, 9, 26, 163, 173, 95, 194, 207, 57, 131, 50, 106, 252, 58, 3, 121, 32, 3, 111, 129, 102, 218, 242, 194, 236, 7, 135, 27, 152, 8, 18, 109, 26, 239, 146, 12, 0, 101, 136, 100, 77, 74, 4, 89, 251, 59, 205, 37, 254, 170, 54, 163, 118, 171, 154, 46, 243, 156, 136, 218, 133, 70, 52, 244, 78, 12, 37, 146, 48, 200, 162, 132, 113, 151, 215, 202, 233, 147, 141, 167, 232, 23, 99, 179, 189, 191, 85, 151, 240, 170, 82, 151, 54, 153, 133, 79, 18, 46, 213, 21, 197, 147, 244, 240, 121, 86, 80, 229, 53, 141 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("ac7932ab-38ff-457f-bfb0-a5474e587af0"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(5102), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(5102), new byte[] { 245, 51, 66, 4, 91, 162, 86, 229, 94, 43, 141, 139, 72, 61, 97, 225, 149, 247, 92, 34, 167, 10, 102, 22, 231, 132, 150, 14, 231, 195, 33, 126, 218, 8, 167, 122, 29, 123, 0, 22, 201, 41, 229, 56, 77, 225, 34, 81, 154, 224, 220, 56, 210, 176, 204, 157, 154, 242, 33, 208, 53, 156, 145, 88 }, new byte[] { 254, 39, 182, 131, 64, 147, 112, 37, 72, 175, 245, 48, 112, 39, 19, 161, 125, 74, 249, 5, 231, 100, 136, 67, 14, 212, 30, 7, 101, 164, 23, 4, 10, 63, 98, 246, 14, 207, 228, 165, 119, 194, 77, 17, 83, 10, 157, 44, 62, 91, 253, 165, 227, 15, 218, 144, 73, 30, 79, 103, 187, 93, 191, 198, 178, 148, 2, 214, 64, 76, 209, 85, 85, 143, 63, 103, 198, 206, 103, 163, 221, 217, 163, 71, 16, 249, 170, 57, 241, 175, 81, 139, 246, 100, 173, 81, 160, 5, 133, 74, 79, 45, 176, 195, 208, 98, 191, 189, 15, 205, 59, 83, 116, 141, 219, 211, 56, 155, 154, 209, 212, 207, 43, 192, 151, 77, 230, 1 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("5745e0df-8a00-4bd1-ae96-d7096b1f0024"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(5170), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(5170), new byte[] { 19, 208, 216, 56, 128, 104, 62, 215, 0, 15, 103, 147, 191, 184, 254, 97, 9, 130, 98, 110, 231, 253, 31, 207, 238, 188, 197, 134, 140, 195, 148, 123, 128, 195, 111, 37, 61, 228, 88, 63, 233, 5, 80, 8, 208, 141, 144, 171, 235, 158, 201, 12, 246, 47, 218, 59, 140, 226, 55, 240, 25, 176, 213, 112 }, new byte[] { 142, 114, 244, 246, 61, 58, 88, 5, 215, 158, 249, 18, 155, 193, 173, 189, 254, 123, 212, 37, 69, 143, 20, 215, 76, 40, 56, 231, 117, 73, 219, 53, 87, 208, 159, 254, 93, 9, 79, 221, 88, 125, 254, 46, 117, 54, 17, 180, 80, 1, 33, 116, 36, 178, 226, 65, 46, 91, 106, 45, 89, 192, 73, 202, 243, 156, 160, 125, 70, 231, 49, 109, 163, 38, 15, 92, 122, 218, 60, 136, 220, 159, 131, 236, 139, 172, 129, 182, 237, 54, 48, 139, 39, 20, 88, 65, 131, 197, 205, 71, 2, 32, 100, 8, 139, 254, 1, 245, 24, 127, 213, 144, 126, 188, 249, 144, 239, 232, 221, 14, 140, 93, 184, 184, 80, 11, 36, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("23a92409-11b7-42e6-81d1-1c0712185c14"), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(5233), new DateTime(2025, 4, 21, 14, 16, 48, 471, DateTimeKind.Utc).AddTicks(5233), new byte[] { 239, 14, 153, 84, 15, 181, 27, 14, 87, 218, 160, 155, 209, 179, 125, 183, 217, 246, 195, 17, 109, 236, 243, 199, 61, 161, 238, 189, 38, 188, 213, 17, 148, 204, 90, 83, 190, 206, 119, 116, 135, 168, 30, 7, 245, 133, 208, 212, 87, 198, 74, 55, 118, 155, 247, 223, 249, 185, 66, 166, 176, 22, 109, 4 }, new byte[] { 13, 85, 49, 207, 138, 15, 248, 216, 241, 203, 218, 18, 154, 62, 248, 110, 170, 215, 228, 62, 86, 13, 2, 148, 29, 193, 74, 225, 158, 69, 113, 208, 168, 134, 152, 207, 249, 132, 205, 48, 138, 53, 146, 161, 241, 79, 251, 12, 37, 223, 35, 178, 26, 219, 22, 24, 201, 54, 14, 50, 97, 83, 99, 143, 34, 166, 141, 132, 226, 18, 232, 254, 201, 47, 196, 6, 57, 24, 137, 251, 125, 65, 244, 106, 189, 101, 249, 30, 99, 219, 59, 158, 177, 164, 211, 73, 254, 100, 130, 30, 165, 98, 242, 139, 162, 43, 97, 237, 179, 225, 153, 131, 248, 133, 79, 225, 210, 230, 98, 30, 103, 97, 0, 235, 200, 255, 136, 109 } });
        }
    }
}
