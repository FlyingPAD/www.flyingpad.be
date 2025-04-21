using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DropMoodDiscriminator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
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
                oldDefaultValue: "02/06/2025 10:10:33");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "02/06/2025 10:10:33",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/21/2025 16:16:48");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Moods",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6474aa79-7d0d-470b-b2e9-78c736150223"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5319), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d4c789b-9cf2-4036-b0b4-c6791cf7b6bc"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5332), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae49deb7-51a9-41ae-9443-207ab1f3f2c9"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5335), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac5dd538-0a72-4ccf-b3bd-526ebc7feb48"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5337), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("caaf6d01-fae6-4b86-a6ad-5e7553001ca7"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5352), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4c9dcd10-9012-4caa-a574-acc69856a107"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5357), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("74b5e98f-1059-49dd-896a-268168d7446e"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5359), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("474df0a0-e2e9-4c31-9ce3-1836b2846403"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5362), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e75999d-056b-45b6-bc0a-2f6d18852e61"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5367), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1001dcf2-23c5-4774-9f1f-8b46d3072b70"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5371), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f67291f-f96c-4150-a9bb-336efc0c43b5"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5373), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("efb78ded-55b4-4771-87ef-e4f2786bdf7c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5375), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea9e4c61-c699-4027-acf2-43c8484b4d2b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5380), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94ab930c-8c6f-4b1f-8f82-df61e992490c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5383), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("12b9b48d-c95e-4684-b65b-2b45aac4b9fe"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5385), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea38f327-b7bd-483f-a6e4-75852918e1a8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5389), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4a4f6e77-81fd-438a-9b95-fc0872c94da0"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5393), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1167acee-f7aa-4bc0-919e-ff0bc7318d0b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5397), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a7ac7882-7623-4f00-9aff-0464bbe4f023"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5399), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fcf34677-6e2e-48b0-af05-f5efd89c9ed5"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5402), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("13c8768f-639d-4bcd-aea2-4868a916ece1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad3aeaa2-8563-4f2d-aafc-ec9d15dee9f1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5409), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3429aa84-0691-467f-808a-e3599e532a99"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5412), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("12e05c53-3909-4a94-a959-0e4b3aa4352c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6004), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("57c8c81b-c722-46c3-9157-cefa1c0a4b0e"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6009), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae6dda27-b4c7-4180-818c-494ac20b3659"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d7e86fb3-0464-4058-a672-2013c8a44d60"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6700), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4b834e67-4f30-420d-9a0e-d752634b7909"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6705), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("edadfed7-1c9f-4225-98e1-2c97f550ac45"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6708), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("55968b21-09b9-4299-9223-5f187c4ea5b1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6710), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6fcfed49-729f-419c-9590-2fc14a6a07f9"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6715), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("41825bff-f0e7-4956-92ea-c2e2f8ff3256"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6718), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f40b9139-74f8-4878-8e2c-f8a08c4df854"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6721), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("502e4eac-e81a-421c-8da8-5217c5104bd9"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6723), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("85a4bc76-4700-4470-a240-ea1f0f49895c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d0b85ba7-1e1a-4bd0-9e4c-3a33088163d7"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6731), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ee07143b-4ec4-4d73-8cdc-97ee6683e180"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6733), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3bbefcf6-4d42-441d-af47-d9e5b53b7b5e"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6736), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("67e67ff8-feed-4c67-a6c1-8dc818831d1b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6741), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("741b1697-e70f-40b1-b1d9-10baa20c75c6"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6744), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aea868e4-b24f-4f62-9eef-f3724d8d3051"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6747), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("087e1528-4d31-4bb4-8a25-0b89b85e7446"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6432), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("47f91262-1374-4501-a36d-9bb73979958e"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6439), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cccd10fb-2176-4261-8610-9e5b3e4db3e4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6442), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6953123c-737f-4297-835f-deba47a427c9"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6448), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62a2d810-f056-4999-8df5-668ba402fa14"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6450), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c422575-f5c5-4d68-a814-ebcf3f27311e"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ee4fea2-96f6-4b19-8660-9d4c0639d2eb"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6457), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e2efa77b-6e90-4759-b6b8-23ffba223914"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6462), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a82becbf-fd14-456f-a309-770d5295865b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6464), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("309171ce-045e-4111-a960-cc1b65ffd4d1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6468), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2276790e-1f0d-48d3-bca7-5c000cb8b166"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6470), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2307bedd-500c-40f8-8c8e-f01810878d38"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6475), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fdd917c-76c8-4691-818c-26c746f754a8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6477), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6451f38f-c82c-43ac-ad59-fd67ad8961ee"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6480), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b14c54ef-56ca-4a8a-ad98-539c1fef0790"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6482), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24c8c5cc-e2d9-4310-9103-b9becd0a2c53"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6487), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e3c4bc7-45d7-4b37-903c-68e30dde3c00"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6489), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("26e12197-b17b-4bea-aac4-88e0f8411687"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6493), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca214cda-976d-4830-a6cf-571fb0f2804d"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6495), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a7711324-8092-4a0d-8b78-dac4ab11a1a7"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6500), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7310fd2a-a1e3-4def-a6fc-d7d48962692d"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6503), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0789db51-2a84-4cad-9da1-a11831583d45"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6585), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb4fe7bd-0486-4cd9-82d4-ca7413e627c1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6590), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8ede7d47-4823-4727-afc8-d4fb0a84af4a"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6595), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e623e89e-c14c-4548-bd0c-19d5036e303a"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6598), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("69e1f32e-14dd-4612-b1b0-81f896506b72"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6600), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ef50bc3-3359-4f1b-b3e3-c69126625c8f"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6602), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6cab3d6d-e43d-464b-a320-bca5288c60f3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6607), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31b48e63-66f8-41c7-a6f4-b45244230891"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6610), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae771762-8a67-489e-ab13-d05a2fb652d3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6612), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35c54110-69cf-4a01-8c58-7bae813ad09b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6615), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ae3670b-ccfd-4074-a73a-66c52dbc2102"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6064), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3674240e-1dda-4532-b39e-4369e62b8a01"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6069), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce7f0bc3-1a35-41b8-bb38-1a52c24ac1b0"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0943e04a-2520-453a-80bc-2094e720fa23"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fa774ecf-8dc9-4a2b-ba08-b4609d49b623"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6079), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("92c12bdf-b096-41af-85d6-7900aede5742"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6083), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fd62d13-465d-4ba3-85df-09e8422d87fc"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6131), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2a47996c-23b8-438e-bacd-207949017c07"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6135), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a74bf801-f339-4a15-a99c-2f85ca0de97f"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6144), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a22e068a-7bca-4ee5-a340-293ca2941707"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6952), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93d3d076-bcbd-4f58-82ac-d17b1300d124"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6962), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("db028903-5ffc-4a2d-b556-b1513077f1b1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6964), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Discriminator", "Extension", "Height", "Modified", "ModifiedBy", "Name", "Score", "Size", "Type", "Width" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7010), "", "In Chords Chart", "Image", "jpg", 510, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7010), "", " Major Key Notes", 0, 61206, 1, 359 },
                    { 2, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7026), "", "7 Notes, 7 Positions", "Image", "jpg", 940, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7026), "", "Major Diatonic Scales", 0, 136462, 1, 700 },
                    { 3, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7031), "", "Fundamental Positions", "Image", "jpg", 1361, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7031), "", "Piano Chords", 0, 562138, 1, 868 },
                    { 4, new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7037), "", "5 Notes, 5 Positions", "Image", "jpg", 524, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7037), "", "Pentatonic Scales", 0, 74358, 1, 250 },
                    { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7041), "", "Color Measure", "Image", "png", 844, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7041), "", "Intervals", 0, 56324, 1, 556 },
                    { 6, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7045), "", "Absolute Basics", "Image", "png", 255, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7046), "", "Time Measure", 0, 8992, 1, 400 },
                    { 7, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7049), "", "Natural Order", "Image", "webp", 226, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7049), "", "Harmonics", 0, 30964, 1, 600 },
                    { 8, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7051), "", "Communication is important", "Image", "png", 705, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7052), "", "Guitar Vocabulary", 0, 99994, 1, 512 },
                    { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7055), "", "Diatonic Chords in C Major", "Image", "jpg", 1317, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7055), "", "Piano Chords", 0, 204898, 1, 1199 },
                    { 10, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7059), "", "Mmm... You can tell, right ?", "Image", "jpg", 900, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7059), "", "Piano Scales", 0, 91482, 1, 695 },
                    { 11, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7062), "", "Overview", "Image", "gif", 709, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7062), "", "Tessitures", 0, 62391, 1, 1026 },
                    { 12, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7067), "", "Circle of Life", "Image", "png", 950, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7068), "", "Chord Wheel", 0, 663017, 1, 950 },
                    { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7071), "", " ... ", "Image", "jpeg", 480, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7071), "", "The Mix is Almost Perfect", 0, 45254, 1, 640 },
                    { 14, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7075), "", "Basic Chords / Different Keys", "Image", "jpg", 690, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7075), "", "Guitar Progressions", 0, 167969, 1, 552 },
                    { 15, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7078), "", "Les 3, c'est NON !", "Image", "jpeg", 960, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7078), "", "Vous le voulez comment votre projet ?", 0, 205144, 1, 720 },
                    { 16, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7081), "", "1, 2, 3, 4, 5", "Image", "jpg", 233, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7082), "", "Fingers Numerotation", 0, 24030, 1, 350 },
                    { 17, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7085), "", "My actual Keyboard", "Image", "jpg", 368, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7085), "", "Roland FP-30", 0, 87596, 1, 1680 },
                    { 18, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7089), "", "How to build a chord", "Image", "jpg", 1109, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7090), "", "Chord Formula's", 0, 221030, 1, 1080 },
                    { 19, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7092), "", "Valeurs de Temps", "Image", "webp", 530, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7092), "", "Time Values", 0, 21922, 1, 640 },
                    { 20, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7098), "", "Fundamental Positions", "Image", "jpg", 909, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7098), "", "Guitar Chords ( B )", 0, 57447, 1, 640 },
                    { 21, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7102), "", "Primary Modes", "Image", "jpg", 1552, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7102), "", "Modes starting in C", 0, 111187, 1, 1199 },
                    { 22, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7105), "", "Good luck finding the good one ...", "Image", "jpg", 1913, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7105), "", "Guitar Chords", 0, 633229, 1, 1200 },
                    { 23, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc5"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7108), "", "Une approche parmis tant d'autres", "Image", "png", 971, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7108), "", "Intervalles", 0, 69313, 1, 692 }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Discriminator", "Duration", "Extension", "Video_Height", "Modified", "ModifiedBy", "Name", "Score", "Video_Size", "Type", "Video_Width" },
                values: new object[] { 55, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc55"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7171), "", " Bendy & The Ink Machine ", "Video", 64, "mp4", 360, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7172), "", "BATIM - Build our Machine", 0, 5091239, 2, 640 });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Discriminator", "Extension", "Modified", "ModifiedBy", "Name", "Score", "Type", "Url" },
                values: new object[] { 85, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc85"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7219), "", "...", "VideoYouTube", "", new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7219), "", "Mario Bros 3 Cover", 0, 4, "WWUxrTdjqg0" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("72704b8b-bc47-43ce-b406-9fdba9e581e8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5653), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c385c04f-d112-4364-888b-d091af445b5d"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("71025cd2-e032-4bbe-b4ea-140e8ac19dbc"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5678), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("56ccb58f-a9f5-4ee1-a23a-09e17284b8fa"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5681), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("52e6821e-3b8a-4f1b-83ad-d6ed50236238"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5683), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ab6a9af-e986-4200-a4ae-312cf80a6ba8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5689), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3dd51a94-eeaf-43c9-a956-ed952db3a917"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5692), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b83ef4b9-d55e-418b-95ee-cc2224419761"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5694), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b346cf13-8c3b-4554-8faa-0a3e8d495fa9"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5696), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40a11fa8-7a82-44bf-aaf2-9a7370339d18"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5702), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("54e69ca1-4496-48e5-b915-d8f3bd521762"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1cf814a4-fb51-471f-be51-1ae1a7bf2991"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8030), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3ae3bfe0-941f-47e4-bfa5-0eca15cfa7ee"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8036), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4ffe766-83a4-4899-91f8-2925d93578be"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8038), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("92eaa16f-3b25-4766-969b-22fc9faa6ecb"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8041), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb6df9b2-cfd2-4486-8c53-d18cbabc684c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8044), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f426ab3b-78be-489e-92f1-b86a0468db0c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8049), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17c18b0a-de9d-488b-a00d-3638bbec3fea"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8052), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0442e7dc-43af-4204-98fa-fa3b540396b1"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8055), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c01d1ab8-6df8-4e88-93b0-e647a5265be3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("382d4ffe-fe2e-4f92-b8fa-04a9bcfdec29"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8064), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c7595837-4670-4d28-b94b-2a441be805c7"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8066), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fc42134d-83e3-4f09-b98f-d3765e610ef3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8069), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ead8e75b-10d4-49c4-af09-f9de208d6eed"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8071), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("436dd40b-9865-47a4-a8b1-936462238188"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8076), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3ceebad9-8a3f-43d2-8795-a72af9a2c5ab"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8079), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ecb0cb6-8910-4bd1-b94f-89703e0ff235"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8132), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fc4a6764-068f-43cf-92ef-df5b0b8e5f4f"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7699), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c67ea4fa-8f9b-4fa9-bcdd-68be47d2d6dd"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9dacf778-8b69-491f-8782-85ca99727bc8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c16882ad-6fb7-44f1-9fd6-b18aed640c0b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5e3b098-ae6e-40cb-8ebb-ab4ad20f0580"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7717), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8997bb74-b640-4ed1-94e7-cd5d24e7e5fd"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7722), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9eafe9be-034d-4115-b427-d74a278ddfc6"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a26c8682-d2c7-47ef-b344-82d5fab671a8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d115ea6d-f75f-4db6-81fc-c10e2bebe704"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5641be90-130e-42de-96f5-e4d4dcf6aee6"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("942e4ca9-4cca-49de-a0d0-5c4cb8bd6a0d"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cebb5a5d-09c6-4ced-8695-781d01a0b239"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b3147945-1cd5-44a8-a339-859d79a2db28"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1237e4a1-b5a6-4dd1-bf61-319ffa81a253"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff6f1a45-4af8-45a4-a131-ad0f895dbfae"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7750), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cd931e81-ad11-4b61-842d-6287cfe071a5"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d479486b-cb23-4270-abd2-10d30227b500"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7755), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c9e04048-220b-462a-aca3-f5ad93a030c4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7761), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94681ea2-fc59-460f-af3c-d72feb45bfad"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7763), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1380df3-636f-4753-9b7f-346682875b81"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9d934316-7619-473a-8807-eec8d4461981"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7768), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ecf618e-6490-4dd4-a1ac-6f95545a69ef"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7773), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("68531915-7c03-44f1-a04f-d47a7ff740cd"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7775), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3ecec5e-d6e2-44a6-89a5-532ab7e2e504"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7e3bcd2e-ba46-4bd3-82ce-12156b257e48"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62e18619-44eb-4048-95ce-88bad44f5be0"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7832), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fca0dc3-8bc1-4db2-ade0-7a6c88aae392"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7835), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8af16353-550f-4717-a9c5-e32ac14169fc"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7837), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b2fee316-0fb7-4382-bb59-9c897c5dcf99"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7840), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bbea7209-7045-4ec9-8d72-c47991c7a724"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7844), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b153e640-58a2-454c-b059-eb1309fff275"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7847), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("abd7e6bc-967c-4d84-a7c1-ff262001cc5c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7849), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1075dbb-2795-407e-8346-99918dd7cbef"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7852), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4b136590-e529-41d1-8074-937b431b673f"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3fe867aa-d428-4c90-98ed-b556f0f85f34"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7860), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c7a478cc-ca22-4226-a910-a41d26fcd534"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a752f99c-3540-483e-a0ac-65a6b06fb1c4"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcccb0cc-33a2-4629-86e7-2a5ba3140dde"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7869), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59c128a7-dc3f-4164-8e42-cd6d2d97f770"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7872), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eca2002c-e286-4515-bab4-5a2c7c2b32eb"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("74da3d2c-6e91-4203-a417-aa1c03fc2838"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7877), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb8bb9a8-b973-46b6-b8d6-bc8d7707f45f"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7881), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8cda5df4-6f05-4d30-9a42-21ecfae51401"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7884), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8cc1d0a3-9c58-4e93-bd29-1a9da90e4a28"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7886), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("511bb77b-4217-43b5-89d6-ef48f47e7f11"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c15920a2-9a83-499e-94f8-ed7446a303d6"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7893), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9d8b91e5-28dc-4485-91d9-d0e5b3707eee"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7897), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("58ab8c99-6dcc-4696-ba94-8caac54dee9b"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7899), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("015bbdc3-ab12-4bc7-946e-63d884614142"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7902), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6cfaec0b-c239-4cf4-8c05-346ff5dbafc8"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7906), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("702a5398-b551-455e-9626-10d42608185c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7909), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81f77883-f662-4929-8ad2-affd64d8a907"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7911), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09506f47-c606-44a1-895b-1af28ddc75c6"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de7382f6-1166-4b2d-9f67-cc179532399d"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7918), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("421c2f9d-160b-4b65-bb81-2f8132f5e548"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7921), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4428165c-9848-4017-906e-8caf6ddbca43"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7923), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3615dab6-ed6c-4961-8e3c-c5d4cefb0e9a"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7925), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1dd5ed59-4506-4f3b-97cb-e11d1b93551d"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c6291096-f342-40ab-9d1b-a35d5491caa3"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09d6240d-1999-45c8-9d39-b7d7440cfaae"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8195), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fb78a808-d9de-44cd-be1d-2bee5d345576"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8204), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("693ed30f-fd38-476c-9699-4e1f17481056"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8207), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9e465935-83c0-49c1-8da6-d2cda1d23fb0"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8210), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c94e728-62de-4e73-9fd5-af56622e1b6c"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8212), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("1104e0d4-ff7a-42e4-811e-ddca85ceab63"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8258), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("0a6e300a-6865-4e49-a2b7-1c4129a84fae"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8692), new byte[] { 232, 162, 202, 60, 39, 249, 151, 99, 122, 165, 70, 210, 199, 67, 112, 205, 5, 203, 50, 19, 43, 115, 131, 250, 172, 108, 31, 172, 21, 19, 207, 141, 92, 106, 157, 242, 1, 167, 167, 68, 210, 56, 55, 152, 145, 230, 154, 116, 97, 20, 220, 133, 163, 110, 128, 129, 116, 140, 18, 66, 91, 145, 203, 90 }, new byte[] { 255, 183, 122, 173, 171, 113, 249, 143, 5, 164, 90, 143, 176, 84, 217, 251, 148, 33, 14, 17, 101, 4, 78, 126, 180, 16, 222, 126, 161, 73, 152, 91, 190, 134, 237, 170, 247, 63, 243, 55, 7, 125, 91, 86, 132, 217, 126, 152, 246, 243, 71, 77, 129, 81, 50, 109, 214, 185, 133, 201, 175, 36, 32, 164, 155, 196, 128, 236, 19, 43, 187, 96, 252, 158, 181, 131, 81, 242, 244, 190, 244, 204, 189, 213, 64, 222, 175, 23, 7, 236, 123, 216, 76, 102, 7, 95, 82, 210, 129, 252, 130, 68, 67, 165, 159, 202, 164, 207, 162, 252, 106, 26, 252, 228, 78, 235, 237, 12, 192, 126, 37, 109, 174, 163, 188, 137, 152, 59 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("26e43f61-040d-4ac7-94ed-7aa6056355be"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8774), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8774), new byte[] { 34, 20, 57, 5, 245, 42, 199, 219, 96, 213, 83, 42, 153, 130, 113, 78, 71, 157, 33, 88, 129, 60, 93, 233, 143, 250, 165, 222, 91, 73, 164, 149, 204, 102, 28, 0, 187, 5, 149, 252, 139, 119, 80, 94, 144, 117, 77, 188, 170, 204, 15, 136, 114, 15, 229, 103, 140, 124, 51, 221, 81, 132, 234, 51 }, new byte[] { 51, 168, 92, 171, 52, 154, 28, 138, 8, 94, 171, 158, 161, 211, 71, 218, 76, 237, 17, 103, 184, 30, 37, 20, 106, 212, 208, 35, 62, 184, 57, 183, 21, 173, 69, 16, 28, 242, 28, 134, 115, 30, 131, 180, 110, 128, 22, 209, 144, 252, 240, 63, 240, 35, 40, 249, 106, 105, 55, 135, 61, 166, 235, 89, 77, 201, 119, 203, 118, 4, 112, 227, 68, 134, 230, 107, 25, 235, 254, 140, 86, 201, 1, 79, 185, 53, 91, 163, 45, 231, 70, 144, 177, 27, 22, 94, 58, 214, 75, 54, 237, 83, 25, 17, 231, 48, 235, 189, 213, 75, 151, 99, 1, 1, 95, 123, 33, 32, 44, 11, 58, 167, 80, 187, 130, 244, 123, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("769d970b-6ef9-422c-8fa6-c06510461a74"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8831), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8831), new byte[] { 204, 121, 123, 15, 40, 41, 230, 182, 19, 38, 63, 227, 89, 157, 134, 177, 10, 39, 113, 108, 234, 34, 150, 17, 185, 240, 21, 118, 53, 46, 93, 158, 168, 86, 70, 48, 228, 69, 183, 221, 122, 113, 200, 43, 251, 224, 226, 111, 249, 112, 20, 63, 67, 193, 155, 99, 154, 162, 82, 142, 222, 168, 166, 12 }, new byte[] { 235, 223, 30, 238, 45, 130, 249, 14, 96, 75, 199, 35, 186, 55, 13, 144, 173, 81, 73, 176, 186, 205, 127, 210, 164, 243, 124, 36, 184, 189, 224, 127, 14, 35, 78, 36, 39, 23, 137, 51, 168, 144, 6, 144, 116, 31, 222, 194, 189, 167, 255, 218, 179, 1, 254, 251, 233, 143, 137, 55, 109, 151, 189, 205, 175, 228, 159, 236, 248, 190, 55, 30, 121, 196, 17, 1, 209, 48, 60, 46, 97, 74, 230, 141, 211, 129, 37, 206, 135, 182, 155, 188, 186, 45, 123, 137, 72, 226, 150, 146, 167, 151, 153, 237, 22, 226, 206, 63, 200, 86, 213, 9, 131, 16, 86, 98, 112, 240, 156, 165, 86, 191, 119, 45, 158, 224, 89, 115 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("a748fcb6-086e-4838-9467-9841b0a21a93"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8893), new byte[] { 166, 14, 102, 98, 220, 236, 64, 23, 136, 110, 223, 98, 54, 84, 85, 124, 107, 45, 214, 173, 233, 212, 79, 196, 75, 120, 187, 218, 123, 44, 95, 16, 156, 160, 3, 208, 156, 12, 82, 247, 9, 167, 231, 47, 8, 59, 173, 118, 50, 246, 106, 199, 74, 103, 135, 189, 248, 246, 168, 13, 77, 150, 160, 207 }, new byte[] { 239, 222, 113, 178, 29, 251, 194, 187, 125, 44, 28, 225, 253, 73, 34, 47, 122, 54, 137, 112, 194, 126, 228, 97, 243, 45, 127, 133, 135, 82, 136, 55, 250, 173, 25, 72, 5, 163, 150, 32, 137, 244, 158, 85, 30, 254, 46, 130, 13, 134, 109, 180, 73, 241, 36, 205, 61, 70, 74, 202, 110, 200, 165, 200, 69, 121, 148, 159, 130, 252, 165, 238, 113, 109, 17, 89, 185, 180, 226, 40, 97, 104, 142, 120, 210, 3, 181, 53, 196, 119, 206, 176, 105, 163, 9, 101, 246, 134, 196, 177, 51, 36, 24, 220, 50, 210, 44, 194, 121, 77, 110, 235, 255, 197, 171, 116, 145, 111, 142, 190, 167, 234, 70, 137, 6, 46, 79, 142 } });
        }
    }
}
