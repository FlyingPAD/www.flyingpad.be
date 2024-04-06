using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
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
                defaultValue: "04/06/2024 13:31:29",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "03/24/2024 14:00:20");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8ed60d79-2ac7-48eb-a5fd-9458e8682e14"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be53838e-dd2e-4dbc-b573-4bac4ed28917"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(262), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4c216d62-5928-41a9-a2d3-da63c701d2b0"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("61627f8f-f0ae-4919-bad6-334a74f04c94"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b0a35e7d-4994-460c-8c32-a8bd15176ac8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7bffe96f-da50-4871-ba5c-089fc1897a8e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("030ab34b-ba56-46a5-928e-11b346206815"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(285), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("04c00af3-971e-4195-b43d-537a81e83cb3"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(290), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1cff4163-ae5b-49a7-bfbe-7fae03078af6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(291), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dbb51a55-c98e-4bc9-bdc8-b7956856dc87"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(294), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1dea18fc-1330-4294-8b35-6cc2fdbb8301"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f3345717-52dc-440f-84f6-89d2bf502da1"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(299), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f930197d-2c07-491e-beb9-f70016bb7a4e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(301), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a476fc1-cfa1-481d-bee0-4af370b17a8a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("22412c75-7d7b-4e96-b400-91d56b173956"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(305), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(305), "Nobuo Uematsu" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adec451c-509c-440e-9e37-d7159fbd2d3d"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(308), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("16e0dce1-8e42-424f-abb4-7912ffb0e2e2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36e98b29-a932-4f72-8b84-eab08ffef188"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(312), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("13aab240-2aaa-44dd-916e-38c51edbbbdb"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(314), "Yoko Shimomura" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("697b2675-46d8-478b-86bb-650ed7a16dad"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(317), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("583cf76e-2825-4fed-bc0b-c30152c2bec6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(318), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b52730da-57b4-4289-bcce-b584aca8b30b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95198e92-2b29-4b2f-8467-9655c0608644"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d53cc831-1214-4e96-91dc-3233e52456cb"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("c8403f4f-631c-4b02-9e9b-ebb982579a06"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(567), "Street Fighter" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a798f918-3a41-4a13-b09f-bb2683df2dc4"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f0732f0a-6590-4edb-98d0-5f95c6050eea"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(836), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("30fe06d2-9504-4e7f-ada9-aa8f4b25d38b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("972a279f-9ce9-488b-bb90-d2e2f437b178"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(841), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a40d8da-1a9d-4f00-a7ae-a0196366e12c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8f484a0-e0de-4ca2-9b75-fc6b73fe8ebe"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(845), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9bd3fafa-976c-4764-893e-93f72db3d3dd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(847), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4984d831-4d77-41ac-b5a8-b81a8b36bdad"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(850), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2633b494-c92a-428d-a70f-34b47eac630d"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(852), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94f99ec9-e074-4441-9cd6-77384a46427c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(854), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c17e0e7f-aa62-4e9c-835a-51f5d2ce2b40"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(856), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c76a4a1b-6547-48d0-a473-3d24c7eb5370"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(859), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09224533-fc6e-4cb8-87de-15bb8b2d0d48"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9ca4da26-b2fd-438e-9187-9f0ce9223b41"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(862), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("85f50cbf-f025-4261-8b79-2625db1308e9"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(863), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4497d3e1-646f-4e8e-beaa-c46b631c678b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(693), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("304f2d35-1468-4ab1-bb39-91b8c2d050e6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("13602224-73cc-4d05-99fd-24b6f9514281"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40be5835-5fdf-4e8d-a557-d70ebb2f110e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("79a0e0d2-53ae-42fa-a384-7d4e206e1fbc"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(706), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("49f19fd8-6ccd-4de7-8562-0021f80b6db5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b2e0d50-6380-47f6-a3c1-88bcc80b806c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("50b1074e-e80e-4772-9b11-f17e66aa2809"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24316e18-3129-42d3-b2c5-1179cd869e2a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a80e5c6b-927f-4f43-8544-50caaae27362"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(717), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f664c9c5-4495-4f8f-94be-6c57e94c713f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(721), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4659192-1a25-4c4a-b81c-ecc8f2b90297"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(723), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("92b7e8e7-b2fa-480c-8549-0348cf393cd6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(724), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cb4667ce-6e5f-4e94-a2c4-0c3cf1175f68"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99e4dc1d-19a1-4d6b-bfb5-34573c147859"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca6c040c-6522-41fc-92c8-538671fd1273"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(731), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("af973d27-c784-4239-ac7b-a10f6d9e4631"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(733), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("69a8bfcb-c0ae-4751-b07d-ac2bd0697fa0"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(735), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4dfbab3b-c690-4eda-a189-20bc48055010"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(738), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40ee16b8-67c7-4019-a5eb-0107133d3d23"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81c21734-da4a-4243-a112-0add75618152"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(742), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4cc7b18-5024-4666-9dbc-e8a576010ee2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b6fb58dc-4f62-4813-a9b3-8f55ff5c1c68"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8cce2af9-1bf5-4f2a-b50c-50c7a44c0879"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31152f17-047a-4173-a195-6800aa986b9e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e4fde121-b9e0-4ca8-bb9a-6681554a8961"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(752), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7d040b11-7ec9-48c0-9837-92899d27b309"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3e1e7d86-6c54-433a-8c28-9a21b9707427"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1aca0aa1-fe29-4ae4-baa5-9749f93b18dc"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(759), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca92ba23-dc79-40e1-a443-3148a1ef6dc9"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("494066cd-3476-4f80-bd5c-357a29fac954"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(764), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a98eba3-72d1-4580-b6f7-49136e2297ab"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("126068c1-869d-4b6e-80f6-7d4470bd9e45"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f7b1889e-e441-4340-847f-701ba5af50ce"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95dae497-5a1c-481e-8bc7-2f2a605ed73e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 5, new Guid("d3ba1937-228e-484e-a9c9-af7a16f0c7d2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(606), "", "", new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(606), "", "Capcom" },
                    { 6, new Guid("97b47065-c471-4761-9675-cbe801217905"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(608), "", "", new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(608), "", "Square-Enix" }
                });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d810e7b8-d276-4bab-a780-2d8fdca7d9fd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d85a4a75-1554-4157-bab1-b2a901efe158"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("224f1e6c-e919-4b9e-bea5-04c4fe8da061"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1049), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1052), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1054), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1056), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1063), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1068), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1070), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1072), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1074), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1081), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1083), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1089), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1091), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1093), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1129), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4245265b-67d5-42ac-a6d5-a91c096acb30"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("db901a0f-27f0-43a2-a574-1729cd3d9dc5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9b7f985-47d2-40d5-87cc-2ad7547026c5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("490545e4-fa37-44e4-83fe-a3de3ea26118"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(437), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("007d2387-2ce1-44a8-9cf0-27d6077e3594"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(441), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("48183059-8e8d-4219-a2f4-5eac01c49ea5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("13418ede-a6c3-4168-a974-a5d82489d72b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("60c27473-1cd3-4304-8c63-78788e0bba3a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(446), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e52df9a4-d4dd-44a9-b02e-2692ea28e5b1"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c04ada94-08f0-4d3c-bed4-8def697d426b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(452), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f2c50ae2-e448-4529-a4f9-1af9e571d479"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1696), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a966a306-918d-452c-90f2-76579cc6a99d"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f358b44-b82c-46f3-b1db-6c79815d7529"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("da3f0778-4999-476d-b257-9c1f33829da7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1704), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a54e1b4-6120-4e2d-b871-16ca33872080"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6492544c-c442-482b-aab5-7b4b49e49725"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1709), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ddff9f13-abd1-4d1b-a1ee-3e58826f393a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1713), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ced923c-ceaf-4d00-be8d-9628b2f7b4b7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1715), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a357aa49-36e9-4f0c-892a-e9d0baceec94"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9198a499-eca0-4c43-a7b8-7f3927529e48"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1720), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("daa11680-74e6-4e38-a61a-263e78ad0a13"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1722), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8616949f-e47d-4d89-b08b-26d420a54831"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d111e0a3-8db9-4dee-b29b-df8abac554dc"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1426243e-83b5-4f16-8b3b-d6594a94e009"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1729), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("657e04cd-8087-47d3-b9e0-a4494d69964e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d6b409e5-6f07-4ab7-a8cd-ca5dae730cea"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("64c36060-b375-4ed4-b98d-26dabdf89f88"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1734), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8f93d106-ead1-4413-af45-2de0ae75725b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("deb80b0c-3363-46a1-aafd-808f0efcdf39"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f4bc9ca9-5a21-49b6-ab17-0c6adc847a47"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6e9aa355-08df-42dc-a2ee-987c73bff61f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("30863b64-ca97-422f-9050-031480caafcb"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01554cde-fb57-4fc8-8215-148d8918df6e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3700724-4713-4e02-bc15-db3e017539e6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a3199a3-8cb8-4514-b8d2-728b9d34eebf"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a6ec3b2-962c-4fb3-a733-d71391b9f71e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3ca846f-0f45-49f3-abf7-26a68aa287f2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea802b5a-c340-41cf-892f-4203e805c81c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1517), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c9857c7d-b2f0-4b47-8dbf-fe53603924f7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f45e5598-3e37-4c0b-8b64-a5649ed12b96"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f64a1d95-fdad-4a13-8efd-67e39af73e4a"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c12eadf4-9591-42c9-86cd-739983ecfb59"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("55be5989-6467-4c79-8e53-03ddd72e5032"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1526), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fc1533c-3563-4c62-8220-187bd59edb08"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1530), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f3cdd03e-61ae-416b-95f6-a1f01ea265d7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1532), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("396b74cd-59c9-4da5-a6ff-2ecb07808f38"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1534), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("346301d6-1ded-410b-a687-e7b06f57f88f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1535), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f5c65bfc-2992-481d-9cab-9e44accd3850"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1539), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0fe26d2e-d5ec-4c73-a9d8-248bd6140517"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("85361032-424f-48db-8b6e-1d3a6a0b7c0e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1542), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d2cc46d9-6629-4deb-9cd0-37576799e369"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("74ca2c79-acb4-435a-9c16-b6a44f3083b0"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c2a53ec1-cebe-48a6-9930-ab905ba38084"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("54f385ad-c2c8-4e3c-83af-d8c5b6425f65"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9dec9230-97da-441d-b882-cda37c109f24"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c4421d89-f0ca-4fe8-ba98-3a0fe037a1c4"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ec403fe9-7975-4cb5-9b16-814e90d83ea6"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1557), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15b1bb7e-b11d-4be0-b4c4-34e954815e83"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e42bdb67-4216-4749-806f-d156e3c29d69"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1581), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("312e17cd-3a35-4c28-8bc4-78170888fa86"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1584), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ccf89b4-2fe5-425d-ac68-c2e2f6bd9efd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6de6987a-8dab-4844-9669-f6cd0435651f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1589), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fe78da1-0d02-4441-84f7-c446fabb15c3"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3eeeff71-8592-402e-874e-a2dd502e8869"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1594), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f907bf8-a3ed-4044-9193-7f15e81f4c5f"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10a0150b-50d2-47ae-ad5b-37fe45ac4c1c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1598), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("921bf06f-8144-40db-aa8c-3014e71a3d95"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8ce1228-7a97-455c-8e5a-1a59cfc18645"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99892c91-7ee0-40cf-a7d8-adf814a2fbac"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1604), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c772f7ea-9d15-41d2-bc33-34404fe5d79e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0dde932c-02b5-4871-a6f5-b1d96f1a84a7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("737903de-e8be-4ea1-8ce4-d3c41fa176c8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5fff6825-9834-4343-9df1-c04eb247b33e"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1612), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("789e9d63-5ea7-46dc-b7ce-cbe611d3ea79"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1614), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a059724-962b-4eb0-82a6-aa93390ce70b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1616), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcd6a455-f6d4-47c2-9134-a18c5507d2e5"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6f08331d-f399-4532-beaa-3c7f8a3cc7c2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c60c00eb-fc40-45e4-ae05-8d212d820e5c"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1622), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73f038e1-1cee-4d97-9a18-e01ea5ee7e11"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("172e9710-b18c-4eb7-8a6e-f787e9fe0afd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1627), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8cfd769-3cf9-4089-bca2-f32f7236bcfa"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f09e9a6f-a07d-404e-b548-c70988358cf7"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c62c2566-acaf-40b9-8332-fb05a17f434b"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c76b5ede-cb31-4312-a5bf-cbee334ea855"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1635), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("79cf17f0-04d5-49d6-a1fa-0aec52f16ada"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1637), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca9c6a1c-645a-4338-a4ba-e41f3d7e8a08"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97f78e79-205e-4abb-9356-7fb40d9c26d2"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1802), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6b949d09-98cc-43b4-b654-9613c146dd42"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1804), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aad9a93d-69e0-47c4-b8ca-4b674b27e9c8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1806), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca4f09c3-967a-47e3-8c78-402d73862992"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6bcaa7a4-5d6c-4d84-b457-7ea90d0fefbd"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1811), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e898bc83-f993-4c66-9f4d-4e3240a09067"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("3d47edda-8256-42e6-8dcf-a190e011e121"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2308), new byte[] { 137, 218, 71, 40, 62, 55, 248, 147, 190, 238, 234, 72, 149, 246, 60, 242, 127, 184, 177, 212, 55, 113, 146, 95, 153, 90, 141, 3, 58, 223, 225, 130, 114, 211, 157, 6, 104, 151, 116, 90, 140, 55, 123, 34, 17, 167, 72, 38, 32, 67, 54, 235, 75, 120, 178, 123, 107, 133, 192, 243, 100, 154, 136, 5 }, new byte[] { 52, 176, 70, 168, 171, 250, 192, 42, 203, 219, 62, 149, 231, 233, 168, 113, 95, 89, 20, 18, 189, 148, 12, 101, 148, 149, 104, 60, 167, 192, 135, 44, 229, 43, 67, 65, 65, 196, 18, 237, 66, 231, 160, 24, 215, 141, 175, 228, 9, 140, 179, 148, 88, 115, 109, 242, 171, 164, 67, 211, 211, 11, 223, 26, 213, 165, 210, 61, 130, 53, 28, 7, 47, 92, 181, 144, 175, 228, 36, 154, 162, 161, 180, 138, 213, 16, 210, 34, 69, 28, 45, 171, 52, 166, 71, 145, 253, 252, 171, 92, 189, 84, 154, 177, 40, 246, 10, 211, 79, 183, 48, 184, 103, 178, 122, 105, 195, 119, 124, 86, 147, 50, 5, 233, 107, 84, 253, 32 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("5100986e-42a0-4291-8f4d-d9636b3a8e25"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2348), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2348), new byte[] { 183, 192, 43, 209, 252, 108, 72, 200, 3, 121, 139, 83, 56, 175, 136, 47, 254, 41, 132, 146, 252, 46, 190, 181, 149, 6, 46, 240, 172, 116, 188, 35, 87, 173, 16, 130, 136, 88, 231, 198, 152, 210, 111, 33, 157, 98, 98, 38, 86, 176, 146, 137, 11, 11, 225, 55, 43, 215, 239, 7, 157, 112, 80, 106 }, new byte[] { 198, 243, 58, 199, 180, 158, 133, 249, 121, 173, 27, 199, 187, 65, 56, 133, 3, 155, 184, 240, 46, 238, 29, 167, 196, 6, 67, 144, 89, 45, 105, 158, 64, 14, 97, 204, 188, 149, 195, 238, 227, 9, 177, 28, 236, 147, 127, 248, 98, 28, 42, 218, 69, 237, 128, 187, 120, 61, 85, 246, 222, 227, 81, 82, 247, 7, 144, 157, 190, 252, 76, 128, 67, 1, 224, 110, 238, 141, 139, 175, 107, 75, 0, 227, 75, 77, 103, 32, 3, 108, 215, 152, 19, 189, 173, 116, 6, 201, 27, 242, 49, 11, 111, 164, 5, 234, 0, 48, 197, 30, 250, 136, 72, 240, 156, 209, 32, 232, 219, 230, 125, 117, 216, 26, 157, 136, 119, 237 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("2bd90384-7fac-4fd8-91c7-76e31d7ddcc8"), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 4, 6, 11, 31, 29, 377, DateTimeKind.Utc).AddTicks(2376), new byte[] { 31, 101, 110, 7, 238, 11, 34, 124, 133, 201, 26, 221, 92, 139, 135, 85, 198, 6, 168, 51, 165, 29, 129, 83, 146, 208, 229, 37, 163, 157, 32, 112, 115, 12, 236, 173, 88, 114, 77, 123, 35, 173, 42, 41, 75, 228, 12, 231, 254, 106, 155, 226, 159, 54, 5, 28, 24, 109, 186, 236, 103, 136, 25, 20 }, new byte[] { 106, 198, 128, 83, 166, 228, 191, 33, 233, 175, 15, 86, 55, 55, 50, 139, 149, 204, 106, 173, 78, 227, 161, 161, 150, 146, 242, 56, 182, 252, 13, 92, 67, 49, 23, 138, 237, 150, 13, 237, 192, 155, 64, 90, 148, 117, 224, 237, 111, 126, 26, 185, 221, 127, 159, 6, 247, 194, 199, 248, 27, 28, 109, 49, 38, 84, 121, 237, 15, 233, 26, 180, 54, 75, 110, 7, 11, 225, 142, 168, 254, 136, 23, 218, 232, 156, 91, 22, 131, 102, 168, 182, 101, 247, 84, 87, 237, 211, 1, 146, 66, 73, 113, 206, 155, 186, 25, 143, 48, 146, 54, 210, 96, 31, 111, 104, 255, 38, 137, 75, 178, 56, 228, 250, 32, 26, 35, 81 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "03/24/2024 14:00:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/06/2024 13:31:29");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5c62b4f0-730f-4699-ab7b-eb1450f8243e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5245), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad6b806d-34fa-4cf5-a0bc-e78a82f8948f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5277), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fb08fc5b-c75c-4211-b5e7-9a0c705cafea"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5279), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("168a9730-08cc-42e8-b6b9-ca1ddaabc31f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5282), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a24104dc-cc53-4bef-af4f-b41dd32e3cb1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5283), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c5c6109-c79a-47ff-a721-c090449032b2"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5287), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("913381fd-f48b-465b-9fdd-d3205d0b8d99"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5308), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a0df995d-0902-4412-b431-bbd320e61f32"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2a9e1a9e-0efd-497b-bcc9-6b164f7ccb9f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5312), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5c79a6a-8926-43df-a654-d41f96bd6430"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5315), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("90828503-967c-4bef-8d14-9914928328c5"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b18d849a-943a-4272-8095-370334883165"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5318), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1708583-c913-4186-b78d-7e00111e70fb"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d64a525d-1fa2-4984-b2b4-f7af026faf6b"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5322), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("2fd7124e-ee87-4a49-a303-8f0f74a45083"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5327), "Fanny tyler" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9ad13f6-a970-4e2f-9562-c8187d70d5f8"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5328), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb8aea07-3aba-489b-992b-5c705288d015"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d2dde48-87a3-4a73-9eeb-5cf3e7023b25"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5332), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("bcb1aa41-83f5-436a-b9b5-b8205b6daa39"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5335), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5335), "Van Gogh" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6e2c2a9b-5156-4c68-adcc-9c67d3f7a6e5"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5336), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b59bd491-6366-4b4c-99f8-fac29d3c53e7"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5338), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22bfca66-210f-4af7-b212-265ddcd7e092"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5340), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f46552bd-1697-4d68-b024-7fb72f85f7b9"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5344), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4d10f658-9e44-4e95-8f7e-74ca85b4aa8d"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5661), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "Name" },
                values: new object[] { new Guid("3d5fc8d1-c139-4148-bdeb-890a0c4cd7bd"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5666), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5667), "Best of You" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ad46a84-61ef-4a70-b725-4cc03e7ee426"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6222), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a14b8404-24a2-4082-8692-caeb3104f8e1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6230), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5255681a-2158-4c04-8a67-70b8c72875c1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6232), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("529a5082-5449-405a-8cde-2e9b3cf21fd6"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6233), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("643db36a-b23f-4206-95ef-4869bfa7682b"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6235), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("496b1850-abc0-437b-8d56-1c3592607387"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ee578f6c-cfd9-4f9c-8d48-bfec62cf7cb9"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6329), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("479c5938-5b34-424f-a2eb-85293439039f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6331), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5018167-a0b9-401b-bd53-1e336b1167a8"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6336), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36f25528-3050-49a4-8110-03e49ec9f482"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d60e34e8-7d17-48ac-9e9d-eab2e1af2108"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cfee8fb1-e980-4124-9d32-2bb702ce2841"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6342), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("650e23a5-f945-4de5-8ddb-7145f9f61993"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a939f7f4-eda0-42f9-9574-cd2bec10c604"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6346), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c69a623-1db9-4c85-a64f-8ff747372247"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6347), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce4f4372-d911-47e3-9f28-d495300a09ff"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05cc0996-70e8-4040-9d87-b9e0ad978440"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18a6070e-7e10-440a-9761-c7d98adf3abf"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5819), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3f4ec63-e79c-4cb9-8d08-1cc5a8c26737"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5821), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("114b921d-2904-4b94-b92e-4c7c3cc2b139"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5823), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("700f1028-26ed-487c-90b2-2781a22012f1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76df4373-caf4-42cf-a42f-d72efe64db32"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f7d71f3-f313-4a5c-ad1a-2a66b8fd7f94"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("525b8f61-697f-450a-88fa-9acfd95601bd"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5835), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("64a68446-e378-4713-a1e4-66d9000e6c4b"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5838), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d9cc3d19-3f2b-452d-ae50-e234147a405f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5841), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("237efb23-efbb-4a0c-aa74-d574b7a9b68b"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e8267a4-df8b-4ef7-846b-c3334a30b697"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5845), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2beac5d4-bd70-4086-ba6c-2eabca708b0e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0b0c148e-895f-4dbf-b0d1-c3ee162783bb"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5849), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eda1df9c-f07e-4a89-b16f-57eb4946dd59"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5854), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("431a8dd4-a813-4339-94d3-08f9e6f5a669"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5855), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8e5edced-78f8-4dcd-b62e-0959287d4f92"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ebbbfcaf-9fa9-40de-b662-528381f1fc2f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5891), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("79afbad5-e4eb-4d46-9c83-9b1424448536"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5893), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81fa52b0-3f38-4e2c-bb51-f744f4cdad0e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5241010-1f84-4256-8269-70231c15a5be"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5897), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1b30822b-a9ff-4a98-aab5-7cd30a85e37f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c692e97f-b626-4d88-bec7-3b26973b484c"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5903), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9e324a69-122e-41a0-b36a-7333505104f6"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5905), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ef094760-cff2-4628-9bf0-c582e94fc646"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5906), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3d65ca79-bedc-4bb5-b33e-e2fc513f5348"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5908), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3d667e6-0757-4fd0-abfe-7bc7a5b0bfa9"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac08de2e-4a38-46f2-a7f3-26131d6e47e6"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5912), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2cf3ba36-1964-4b24-a7c3-9ffe913ddcc3"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7272d47a-1d18-41e0-a43d-ee55a0a2dcbb"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2f5b7598-e770-443b-9143-da51e96b573c"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62ebac28-6906-47e9-8557-bc24a5115a05"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5709), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9b549f1-340f-4237-9958-ebf467773e90"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("506258cd-af99-4012-9353-e2b2a550b581"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f86a663b-42c0-4f2f-86a5-85e2efd32ec8"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6487), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22060f72-3317-4492-bfe4-699f9c06dbb6"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76612249-b874-4c19-b070-d8be1c10b921"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6592), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6611), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6618), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6713), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6715), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6720), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6723), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6725), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6727), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6734), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6737), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6739), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6742), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6745), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6747), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6749), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6752), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6754), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6757), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6823), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0adafe09-6864-403f-af43-ec41a570f13a"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5475), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e282c6d6-04a6-4d32-a2ef-281e82b2a170"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dbdbc6b1-a59e-4d99-bb89-d16ebb41a521"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5484), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("272747a6-2bb3-4662-87b7-dbaa893325b1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43d3e8fb-4836-4052-9b41-89ce429fe05b"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5488), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2cdbc398-17d3-43d6-a38a-9fbb07798491"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a410260e-1e62-4ea9-8938-ea923b7e0865"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5492), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("005ac1ea-f420-45b4-ab70-c71f0ef80dfa"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5497), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c5c87bff-0dac-4951-8ee9-4c4991ae41a0"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ceeda50-f4f8-4eaa-8acb-f60de3d8af5f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d100b954-4da4-4827-a644-f690446a7645"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7611), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("549cdb6f-df8d-4e13-a60c-9e1ffdbfc2eb"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7617), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e109643-f30f-4a0f-80c3-b84747869b33"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8ae2b68-0d05-432a-b9f2-9d7275d3918f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7624), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eeb46859-98f5-4c48-98e4-f7be39a63148"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7626), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82af5b41-0fe6-4e37-a788-6985f9d9bd2e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31f93b0e-6f30-485e-9496-b49d5739a684"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7631), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("befb33a3-4ce5-4e6f-b6b8-fdeeb49a60bc"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7633), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f42e350-d4dc-494e-b78a-baeb9b782016"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7634), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("55d17732-8197-4009-a216-a860a032bdf9"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7637), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ba2770e2-17d7-492d-8141-061445813efa"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7639), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9141c771-4df8-40ee-9722-b2790b0b3c83"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1b0e028-2f12-4f39-a512-76c72c813b28"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7645), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b39604e0-c252-4015-9e36-d6f8731cada0"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7647), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4a4141f-aaf2-4202-83d8-2c62565bd075"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7649), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2f83e2f9-d65d-43cf-8ce8-927d8dec160e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7651), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("824ce79c-e6c7-4453-a25c-d55b34f63cd5"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7653), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("faffaf83-9626-4726-9add-75ea74316130"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7351), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95313241-8d54-4f64-a684-49e01ff7a710"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7361), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("69993aa0-b4a1-413f-b492-b82455af0f5c"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7364), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f60c7869-a279-46bc-bf76-86202efc7751"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd6c19f5-20e0-414d-83e1-8c542aad1d09"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7367), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11f6db8c-bc18-4212-838a-fad529a821ef"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7370), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("38d7938f-bc9e-49e7-95b4-e8b2b94c0497"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a251937-560e-4c23-8209-f93cd4d57ae3"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7379), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5831b9ce-ecf5-4cd8-a87f-3fb870191070"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7381), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62612ba8-6f01-44a8-915c-1d33eef3baa3"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7383), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8ba95f3f-b38d-42e1-ae37-6854a220e75f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7385), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7f4b268e-b3ab-485a-9b95-8d713658d954"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9792fe13-a1d4-4777-acf0-b3184accfbd0"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7389), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("702329a8-aad0-45d0-ac04-5f01f8bd0dcd"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7391), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("102fc508-6682-441d-83af-673c6440fbd3"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7395), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de8bc348-1f2e-4606-9261-40ef4c86d49d"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("64ce5668-2deb-4343-bfe5-f1c1e5d8ec4b"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7399), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("426b9e10-d4f6-427c-bbb3-798f627caf09"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7401), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d190ffba-abbe-44f6-8688-af8747ef211d"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7403), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11f5f98c-de29-456c-8019-c4e4241b31ca"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7405), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5652f558-24d2-4e9d-bf7a-ab0e93495066"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7406), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1f17a8b-788d-4ba6-a197-78df0b2663f3"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7408), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f738d65-2d69-4ec8-87d3-bfcc34b60fe5"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7412), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0cb5c692-30c9-40b5-b143-a4e9eabf20ce"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("381612c2-32eb-48f9-a719-9a14e57627c8"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7416), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88a41308-4a83-49ae-a97d-bcea4184432e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7417), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eb7d34e7-ebd3-4119-9820-c211adb1e580"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("831f4b9e-b761-43e2-a2b1-79470df60ada"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7421), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c2597f64-9a17-4bf9-a2e9-4b2b24694009"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7423), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9c1a961-0c11-4d3e-a3ee-dedd7ae7b237"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6682c4f2-906b-4014-9197-4a9967553ef7"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e09298f-e4be-4695-b9d9-167a9e274ab5"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a96c2f8a-41a5-4689-9485-b9bbf7797d99"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("30de459a-b3e5-444d-8d51-4671e9c3c171"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7474), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2e5093bb-0d55-4642-a9fa-59fb379d3c0c"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7477), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f66c28ee-31dc-4e0e-911d-f7023cefeca1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7479), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ed52fd7-3298-467c-9975-96bc7695ea3d"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7481), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("403cc041-e591-4a9b-ba43-a7b7434feae7"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d89aa65-4edc-465c-8112-c8e35c0e0b4e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a676da3-36ef-431e-aea7-0a574b077903"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6220ca90-548a-4069-9a21-481c389246dd"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7490), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5fb69ba0-54df-40af-9fba-4e0c9f1a5abf"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7492), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87e7cfe5-09a6-481a-98bc-47ca8c4f6cce"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a6a24de0-9d1f-4c8b-86bd-d4510ebb00a1"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7495), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5693ddab-6d7f-4446-bafe-bf67f3180e2d"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7497), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ffd45bd0-68d9-4044-8d66-dc49195d9594"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7499), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22e55e8c-9345-4308-88fb-f5dd2433044e"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7503), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3245ecc-5f3a-4652-a6d5-8172deb7af85"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("66ed0433-daf6-4c08-a58f-df1e733462f2"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("878461a6-a819-4153-bc2e-783c7a280bdd"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cdea1a2a-8d0c-435c-9b7e-1d97a6b73f48"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7510), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("10a3cdb4-3e68-4c44-a280-489ee82db6a6"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7511), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3c8ebac2-b2e3-45c4-b1f5-f1018fae286c"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7513), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24ad93de-a53b-4bdb-9351-29db324a1c55"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b89dcc5b-71ab-46c1-9db5-b5084ea6d13f"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("65c32e35-4b0b-4a0d-9cfc-95137da36369"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76842195-95e6-4811-ad49-812a69b3b520"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("41d16bc4-9d69-4421-accf-e6b6476e09c0"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7525), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("821fd0fd-7a07-45d1-9a8e-a123bbf55ce0"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ef01709c-b752-43aa-ab0b-7a588228abbf"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cfa647b4-4db1-4142-ba6c-317072d90af8"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7752), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c41ff36a-fd46-469d-a91c-26cb173505ef"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7757), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0958d2ac-9a0e-4144-95c2-648c3bc71d89"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7758), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2c412cd7-fce6-47cc-806d-679a3208b017"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2271c6e4-b9ab-425b-8bae-2d91cf7163b2"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("a4f62778-b1e0-4900-ad8f-87e7725950ee"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(8227), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(8228), new byte[] { 28, 90, 56, 172, 190, 57, 144, 95, 227, 41, 113, 15, 87, 99, 125, 245, 132, 167, 83, 86, 148, 161, 64, 149, 105, 52, 91, 192, 195, 234, 246, 132, 247, 240, 195, 123, 116, 24, 227, 166, 86, 115, 185, 65, 175, 150, 60, 78, 49, 19, 83, 225, 141, 186, 77, 37, 107, 155, 9, 214, 213, 174, 125, 225 }, new byte[] { 29, 199, 184, 215, 163, 65, 81, 128, 66, 138, 85, 214, 71, 98, 42, 173, 125, 69, 156, 173, 41, 112, 125, 4, 125, 194, 254, 221, 17, 88, 222, 49, 38, 109, 230, 134, 149, 60, 117, 178, 240, 151, 26, 170, 45, 155, 213, 171, 3, 212, 231, 8, 205, 251, 46, 232, 228, 79, 252, 139, 96, 206, 188, 225, 106, 143, 195, 27, 6, 81, 73, 162, 73, 249, 143, 57, 102, 193, 33, 66, 28, 160, 15, 65, 146, 134, 173, 85, 62, 246, 163, 196, 81, 81, 192, 94, 31, 39, 233, 126, 151, 42, 33, 206, 246, 74, 31, 196, 131, 141, 84, 186, 28, 46, 165, 243, 186, 197, 18, 125, 86, 8, 94, 166, 181, 148, 162, 71 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("63539e68-cb8e-4380-ac39-c0839a7151e7"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(8316), new byte[] { 38, 123, 186, 53, 229, 216, 240, 19, 12, 48, 110, 167, 187, 137, 142, 129, 229, 113, 140, 170, 222, 236, 158, 151, 98, 107, 21, 215, 181, 190, 171, 1, 218, 167, 187, 237, 104, 195, 218, 15, 56, 172, 241, 85, 169, 113, 16, 37, 148, 172, 38, 105, 78, 222, 32, 118, 65, 29, 199, 107, 123, 83, 189, 142 }, new byte[] { 227, 175, 52, 242, 98, 17, 69, 248, 189, 70, 183, 139, 156, 173, 83, 251, 142, 85, 242, 59, 29, 145, 214, 192, 140, 8, 161, 177, 247, 13, 34, 65, 143, 164, 222, 69, 113, 29, 243, 180, 14, 124, 84, 104, 143, 134, 132, 198, 188, 224, 69, 45, 21, 171, 158, 170, 147, 9, 79, 66, 76, 11, 212, 234, 67, 228, 229, 154, 97, 110, 80, 184, 201, 44, 145, 188, 170, 192, 103, 212, 198, 222, 71, 65, 37, 184, 95, 87, 92, 105, 132, 110, 8, 192, 56, 57, 68, 47, 244, 204, 231, 255, 100, 67, 231, 112, 43, 164, 49, 142, 232, 243, 112, 98, 32, 8, 160, 120, 223, 100, 154, 206, 138, 185, 211, 254, 198, 244 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("3094815d-e507-45ec-8237-b6dbcfcdaba2"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(8380), new byte[] { 128, 187, 80, 3, 236, 151, 87, 184, 92, 221, 227, 88, 235, 230, 4, 27, 38, 233, 79, 58, 143, 100, 193, 5, 141, 59, 98, 220, 69, 121, 156, 160, 240, 119, 46, 151, 232, 242, 231, 97, 33, 168, 182, 46, 81, 238, 192, 75, 20, 206, 244, 208, 74, 83, 124, 193, 20, 56, 41, 146, 151, 193, 237, 109 }, new byte[] { 66, 104, 112, 210, 117, 158, 60, 146, 132, 86, 242, 136, 117, 72, 98, 32, 105, 197, 173, 213, 247, 75, 5, 66, 201, 218, 169, 116, 104, 51, 35, 248, 69, 255, 142, 67, 5, 189, 139, 106, 91, 38, 185, 178, 118, 148, 152, 101, 46, 124, 191, 158, 150, 154, 238, 251, 170, 136, 49, 156, 1, 35, 52, 65, 134, 145, 199, 100, 189, 174, 131, 125, 55, 26, 203, 96, 151, 188, 18, 19, 145, 53, 142, 96, 180, 236, 98, 164, 76, 90, 124, 112, 124, 81, 85, 5, 122, 156, 212, 85, 237, 140, 234, 221, 95, 233, 0, 193, 198, 240, 232, 185, 39, 230, 103, 123, 188, 251, 34, 197, 151, 35, 235, 197, 252, 173, 197, 46 } });
        }
    }
}
