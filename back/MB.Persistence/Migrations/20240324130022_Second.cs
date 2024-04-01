using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
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
                defaultValue: "03/24/2024 14:00:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "03/21/2024 09:49:44");

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
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fd7124e-ee87-4a49-a303-8f0f74a45083"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5327) });

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
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcb1aa41-83f5-436a-b9b5-b8205b6daa39"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5335), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5335) });

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
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3d5fc8d1-c139-4148-bdeb-890a0c4cd7bd"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5666), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(5667) });

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
                columns: new[] { "BusinessId", "Created", "Gender", "Modified" },
                values: new object[] { new Guid("76612249-b874-4c19-b070-d8be1c10b921"), new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6498), "M", new DateTime(2024, 3, 24, 13, 0, 20, 761, DateTimeKind.Utc).AddTicks(6498) });

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

            migrationBuilder.InsertData(
                table: "RMoodArtist",
                columns: new[] { "ArtistId", "MoodId" },
                values: new object[,]
                {
                    { 1, 55 },
                    { 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "RMoodModel",
                columns: new[] { "ModelId", "MoodId" },
                values: new object[,]
                {
                    { 1, 55 },
                    { 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "RMoodTag",
                columns: new[] { "MoodId", "TagId" },
                values: new object[,]
                {
                    { 55, 1 },
                    { 55, 15 },
                    { 55, 16 },
                    { 55, 43 },
                    { 85, 1 },
                    { 85, 15 },
                    { 85, 16 },
                    { 85, 43 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 43 });

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "03/21/2024 09:49:44",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "03/24/2024 14:00:20");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e383b699-f6a2-4e4f-a2de-21173fb97c98"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e15756e1-e8d9-4272-af8b-ac5ed206daef"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59be0e99-d273-460c-ad45-6d753c932aa3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1553), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3b33b5d9-4bf8-4cb0-a5e2-828d4b71155f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1556), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("25d6ffd6-7a71-4664-a7e1-0726f86618d2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6a28c59c-f426-44a8-bd40-6dd5813c1d8a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1562), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("909976da-8d93-457d-8791-730229bf1351"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1564), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("90ac487b-a002-48c4-9452-c5b50443b408"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1585), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7b5c41f1-7f5a-4883-9121-23c404fde1a6"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d7382c5-8c8d-4989-b09e-2c3695ba833c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1591), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff7006db-5469-44d4-bd59-e83cff684ae3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1594), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("afa21b70-c2cb-4f9c-8c73-38971b65fce7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("72986298-7e5c-4134-b98b-fca7d5e3bc7a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1598), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("34dcbd6a-3e2b-4759-ba89-1df8f3840d79"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09b58f76-ec8f-4c17-adaf-e0eeb28a69df"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1602), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53e17f9c-ad1c-4db0-b556-2866cfb7e7a2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3b74a17f-d93b-4ecd-a1c7-fa4e85432c14"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1610), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9b3ebf2d-a65f-499a-8a77-e285f2a5fce1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1613), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("109e353d-cdef-497a-aead-c140b423ab8c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1615), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("948fbd7c-bf85-403f-b104-c48b2edcb823"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1617), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7058678e-eda2-4eb3-8a92-0d8c5cd4721f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a5b4bae-c18d-4715-a8d9-c3cd277176b4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bc00bfa7-d7b6-4898-a806-1b0982852e2c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4ab296b-6f97-4f86-8987-beafdc5157f9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2059), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a8a7cc3-5137-4aa4-88b1-e04d97b42939"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2065), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a06dc8d4-516f-49b1-a8b0-9d9a6fcd4461"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2482), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("98c44e3b-5939-46e0-8b20-bcdaa68a29a7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2493), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea22795a-6c92-4a93-8a1d-543a96005ba4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2495), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("69102e0d-39ff-4875-a8a2-0238ee13c72d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2498), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a2335ff-3b73-4f34-b2fa-8159707040cb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d6c32070-abd1-42c8-ac28-3b9ecb37eda4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2503), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a532acf4-7c06-451d-8d89-59822a41c9c1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2505), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5906c907-f25d-4020-829e-9e3046c57180"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2507), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("af8354d5-7055-455f-b03c-a0eccda00628"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2509), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("07f47d10-bae9-4fe9-b859-0545ddb02758"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8ab6e2e-a8f1-489a-995f-fef34ad10c38"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("072a9638-3082-43f8-9f4b-c4a1e7bac7fd"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("451ba733-a232-4cad-a304-92d9f72a38a3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fa54db6-3ee0-41c7-befe-bc3c5c098fe8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2522), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c00240d-a6bd-4a45-ab35-ecad4c57b788"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2524), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62e89cd3-4f42-4285-be7e-ef7c6cd2aa73"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2249), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b8e8f968-caef-4ffb-b80c-90412c38eb10"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2255), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("80d73874-c11b-4fe5-9455-4b0085133c1c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2257), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("262dd72d-54e7-4ea9-8f3a-c71fd31432b9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2259), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01bd2d25-19cb-47b7-a033-df0665167e9a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2262), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bc22ed0c-b62e-4e16-a55c-5e6b23d3335a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2266), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8af1f90-737b-43c5-98e3-d4ccfc4a2e12"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2268), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d0a24dc-2606-4131-aafa-60f6c2f340ce"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2270), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b45c4d22-cab0-43c0-ae3c-9827d5bbd918"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e9364ae0-3a48-481a-9d63-d7bfefb28cc2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f0b27774-fe29-4929-adfa-1cc0046c38f7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("053c3f89-bcb6-4446-8e4d-888455308875"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("738ebe69-19e5-432a-ab0a-abb72f944928"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6664647c-cbc6-449e-83a7-9fd32ebeee7e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2288), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e384fc01-799c-460e-b582-a164f816c3c1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8cbc2eca-eb86-440d-8d66-4338490515c1"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e0eef0e7-10df-400e-8dc6-f91441b69de5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2296), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("45876011-2d59-4c03-af49-1a74b97c43e4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2299), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c09ebcf3-045f-40a1-8d9d-6ae15148b6e5"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2302), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("156f495a-0a7a-4045-beff-58db72b6adfe"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2304), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d3cf8758-02e4-4d02-b49b-d379a87f29d7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2306), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c15ea56-4583-4ff1-be8a-f9ff4d5a1b1f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c6ac596a-5520-4b88-aa9f-6fac91daceea"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("52056a47-93c1-46c9-81f1-2f2f9f97464e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2312), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d9f25f7f-4352-4176-b285-e65d6edfb7ca"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2317), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adc4f02a-9ad9-4750-a9f9-7d0a5b0b51e9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2388), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7eb87b6-f6ff-4c3c-9465-897704689aca"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2392), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02a81def-8d7a-4ebb-9092-ded5a71ba187"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2394), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("907a82de-7b05-4330-80b6-e7d8daf81faa"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2396), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fab8355b-0eeb-4926-90f8-f7082d083e66"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("190061c0-03a5-4ebe-b839-5440c7d675ae"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("785ba00a-06c0-456d-9d96-057e8c97a971"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2112), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24091556-02c1-490d-82c6-639e1d8955c9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2117), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1156f3f7-1368-4b21-bbdb-12ef7cf6ea75"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2119), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("096c2b88-d893-4964-afaf-2c1ff7e670fe"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2121), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b839c5d2-c67b-4312-9dc9-a7d4c264b39b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("042f3d54-bb9a-4534-9905-30c13684ebc9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2742), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Gender", "Modified" },
                values: new object[] { new Guid("789e4232-72d1-45df-9a84-d901f520e114"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2749), "", new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2801), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2817), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2821), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2825), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2828), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2833), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2836), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2839), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2841), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2844), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2849), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2852), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2854), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2857), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2860), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2863), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2866), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2868), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2871), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2874), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2876), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2943), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2989), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("902508ae-fa3b-4900-a8ce-1a009b0255c3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1797), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("37016e94-16c9-4e63-968c-f597218e05bf"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1804), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("599d18d1-5c06-4b91-bede-35a6af5ab582"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1806), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c775aa29-7869-408d-b57a-a6eacaef9f53"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6e5b584a-d17e-4759-b05a-5483db735d4d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5807a05-5be3-4c99-a61b-4b56864ca82a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1813), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7ee2504-2d50-4f80-9b70-d9327a5c3786"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1815), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("68919557-b8d9-474c-b961-aa4a210205be"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("660749cb-7731-463d-8b56-12b5ebcfbb35"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1918), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("da91b1c8-83f1-4b83-b8b1-08bfb10cf4a2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1922), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18219fe5-0212-4c57-8eb2-2cd4727e5456"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ec0f0e78-8a67-490a-aac4-a2584f2a45d2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3963), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c44c172f-77ee-462d-af1c-776f19ce04e4"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3965), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad6a3f33-87dc-422d-b8c1-79c68452d4e6"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3968), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("caef1766-457f-4a23-aecc-4a691460c880"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("677b5cfd-7f17-4d07-ac51-096261a9cb5b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3977), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8cc62e0f-c222-4a31-88b6-eb1833a58319"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9d9e72c7-e0b1-4617-90c0-e6f549c1de45"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3983), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a05fa12-da51-479e-b311-815f1a069512"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3985), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3fb825b-808e-471f-990f-b4de81c9f94b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3988), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("26ec2dff-dd5d-4727-b9e5-4d3adc788cce"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3990), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3bf85639-cae9-4036-82fb-278c0b3b6fb8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3993), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("64583ebc-1226-4eb1-b459-96a77eea0202"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3997), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6c46ca9-c4d7-494e-aff2-6420e4701deb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3999), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("163a0bca-ee4c-4a97-9af9-d7b19c0a77ab"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4001), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c10d31c1-6f6b-410e-a6e0-f028fbf32d80"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4003), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c95fd9c-6b89-401c-ab42-52921c05c72c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4006), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("89e2199e-5d7c-44b8-9c71-34bd80c8f3b7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3508), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cbccf4ec-b373-4423-9fa1-8e6a77598362"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3521), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d3d06de-91a2-485f-baa3-619fb15c45da"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3525), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2013dc0d-9c0e-4f92-a387-631134ce2742"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("84f37866-5100-40f3-a282-5de89e480bab"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3531), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4acb3aca-6ad0-4a8d-9a4c-1b5e4d39089c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3535), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ffa38f24-7f95-46d0-9037-944ec7b754d7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3538), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad9945ed-04c1-4111-a888-fa61845e7096"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20441e3f-fef2-418a-89b5-54fe68a8178d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3552), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c95e97b5-4afc-401b-9aab-1a54cec5a305"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3556), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1f44c1e-742d-4f54-bb0a-1ab846659fa2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3559), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d230abaf-7de3-4acc-ae60-5740708914d0"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3562), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("56eb5194-5c7d-4f57-a099-75e5f15baa2d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3565), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9b383f9-f9c7-41a7-8dfc-238a4745cb6c"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3569), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a2b4cdd-f6d7-4466-a2de-f6c4475dec9b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c5303420-43ca-4c14-919e-90eabc1a87e8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("71b62a96-e215-462c-a2fc-2d0650f06929"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3621), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e08e9b64-dacc-44f4-bf63-0aa0cef79495"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ea6cfc9-119d-480a-8559-41467265dcec"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3630), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b66bb294-70b3-415e-863a-8d14126afada"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3633), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1947acc9-d2ad-4c7c-a95e-7bc8fed634e7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f0f1756-fe39-4f33-8538-8ddbcf1fcb66"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97e85a4f-e96b-48b4-9b7a-4eeb83004169"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3644), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("abdfe398-c130-4034-8b19-1ff362071d61"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("535793d5-7d7a-4502-9e02-78cd01561317"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7b7cd8e6-37a9-40f4-9271-83badea811fa"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a9c97e4-78d6-40f8-93f0-74d2580c2b20"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2833a4fb-24cf-4971-8016-65fa98995d85"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3665), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("956b797f-96de-4ec8-8723-170256777f7d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be3e03a1-fd34-475a-9c26-bf633c766a6f"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3673), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88840673-ed11-4141-97df-c84c77619b0e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97aae5b6-bf43-4777-adf1-cf6e7694ed71"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3682), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9619da11-dfc6-4f0d-b078-84990316eacb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3745), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("927495f3-5296-43e2-8953-9786812013da"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3755), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bbdd2f2f-7a33-42c6-ba02-d31acaaf895d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3757), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7cf57d36-7567-4b52-810c-35ff3950eed0"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3759), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d9ebca09-8a6c-4a72-a8fa-38b6d7db972d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3761), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bdd50c2f-b55e-4887-b523-6d12dff01825"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cacba3e7-65ed-4e03-89f6-6724a799a404"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3766), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5268424a-b128-474c-b8b8-83190263178d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3771), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("50362678-9b52-4614-9783-0525c94805d8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3773), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e23ebd85-7ba1-4862-82aa-1345873bcda6"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3454498f-e8ff-4337-b4a5-c40dd3e5a9ce"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("955eb582-b588-4411-afb0-b38651fcdb2d"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3780), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("78dfc817-ac3e-475b-9423-8f955ab15f3e"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c365bf76-d8d4-42bf-93c2-b4ed0b62fd66"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3784), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a7b8c6b-1c68-4f4a-9184-a055110204da"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3786), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4180353-e558-40a4-8dd2-5a36845ee2bb"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("da0b062f-0a7b-4bf6-9257-605c442ca692"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3792), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d2f412a7-ce08-4299-9f67-ccd2c6743af9"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b7234de8-a67c-4f30-9ad2-c5587cd00aa0"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3797), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("797e8d6a-82c0-4da5-b64a-4d1a9d646bbc"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e3c4233-3bdc-481d-b9ba-d6d0455cc8ae"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3800), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82d585fd-f585-4a5d-a9b6-e804283b9110"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8055df22-21d7-4a25-acf2-c1b20b7ec12a"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c6888b52-b91c-4571-a3b1-68a2adab5e17"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a612ff00-53cb-4291-8336-f8005281f4b3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("50deb2cc-b0ac-4acb-835c-27ab3630c61b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c9e56404-7405-48cb-ba7c-586d2d538e07"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1333ac94-4237-4b5d-82a7-def1b60a14e2"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4121), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5644ca4b-7e59-4755-b95e-52dbe60c13f7"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4126), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("48ea6d94-8fef-46f1-917d-425d0f410798"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a9ffd174-4323-43a3-ad83-fee5ea428de8"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4135), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("371a782e-c47b-410f-bba9-f76160a061ed"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4137), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("727de44f-7a85-4e01-bb40-3cc000d1a926"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4193), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("bcebf0b4-be2a-484e-a879-1213820245a3"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4659), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4660), new byte[] { 94, 153, 33, 243, 195, 214, 53, 158, 171, 132, 147, 173, 53, 137, 227, 160, 169, 235, 28, 125, 46, 203, 19, 215, 165, 171, 84, 160, 246, 227, 85, 65, 20, 231, 35, 35, 71, 215, 144, 85, 241, 8, 77, 242, 131, 58, 202, 164, 211, 95, 254, 203, 43, 134, 212, 48, 230, 167, 74, 224, 252, 251, 128, 189 }, new byte[] { 59, 182, 133, 55, 8, 76, 62, 202, 140, 12, 177, 194, 178, 79, 218, 239, 12, 4, 98, 170, 40, 190, 181, 73, 117, 3, 176, 86, 245, 39, 218, 29, 12, 209, 116, 247, 46, 157, 139, 65, 173, 215, 251, 155, 14, 3, 21, 5, 254, 107, 223, 242, 177, 156, 186, 175, 90, 81, 212, 171, 166, 183, 215, 20, 227, 60, 107, 196, 83, 244, 158, 106, 98, 195, 130, 229, 175, 24, 127, 40, 161, 191, 17, 73, 34, 191, 84, 186, 112, 228, 70, 104, 33, 113, 70, 123, 89, 82, 47, 124, 17, 137, 143, 92, 187, 6, 18, 178, 53, 21, 64, 204, 123, 5, 179, 164, 156, 2, 30, 16, 4, 82, 186, 18, 106, 89, 248, 164 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("eab0637f-429b-4196-b0c1-10e42844f096"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4755), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4755), new byte[] { 177, 136, 167, 37, 175, 26, 54, 221, 67, 197, 90, 149, 142, 6, 46, 235, 169, 31, 69, 31, 4, 101, 167, 158, 215, 142, 84, 77, 190, 19, 11, 75, 178, 231, 194, 218, 225, 79, 97, 6, 0, 67, 49, 143, 164, 22, 70, 185, 189, 246, 220, 0, 25, 26, 117, 120, 111, 8, 96, 251, 40, 28, 182, 126 }, new byte[] { 0, 208, 46, 123, 11, 208, 186, 43, 50, 54, 142, 178, 87, 131, 167, 53, 225, 245, 200, 178, 199, 94, 225, 148, 0, 171, 114, 169, 115, 126, 87, 160, 1, 185, 209, 165, 210, 22, 174, 241, 179, 99, 94, 187, 249, 190, 215, 12, 50, 35, 116, 122, 209, 162, 55, 74, 177, 179, 186, 109, 215, 196, 240, 25, 126, 49, 44, 178, 62, 50, 192, 78, 75, 177, 237, 187, 243, 70, 209, 1, 82, 241, 35, 52, 111, 131, 155, 86, 246, 130, 84, 10, 57, 80, 156, 86, 206, 16, 65, 108, 191, 237, 29, 124, 91, 152, 194, 203, 36, 231, 243, 17, 188, 15, 10, 228, 126, 99, 132, 167, 13, 60, 177, 2, 210, 62, 139, 136 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("8008722d-26c2-4989-804a-5dbfc6ea291b"), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4828), new DateTime(2024, 3, 21, 8, 49, 44, 157, DateTimeKind.Utc).AddTicks(4828), new byte[] { 164, 119, 194, 82, 60, 84, 246, 141, 23, 42, 64, 150, 73, 107, 182, 56, 21, 229, 191, 100, 228, 248, 21, 231, 228, 19, 37, 142, 205, 69, 18, 26, 193, 100, 241, 142, 62, 192, 65, 252, 247, 184, 200, 52, 184, 217, 71, 31, 201, 248, 72, 15, 103, 139, 217, 181, 62, 163, 5, 48, 144, 218, 171, 51 }, new byte[] { 216, 139, 86, 187, 52, 56, 96, 0, 42, 145, 149, 255, 81, 158, 92, 151, 252, 147, 101, 220, 97, 191, 91, 200, 252, 239, 193, 100, 25, 242, 213, 105, 16, 48, 109, 185, 107, 116, 191, 55, 148, 86, 58, 26, 42, 49, 77, 132, 175, 132, 158, 195, 21, 27, 22, 15, 57, 165, 20, 99, 41, 84, 143, 161, 64, 119, 2, 44, 185, 126, 174, 95, 15, 36, 212, 77, 80, 229, 121, 37, 52, 88, 15, 104, 61, 131, 185, 80, 65, 233, 180, 110, 15, 186, 186, 129, 58, 124, 77, 253, 215, 168, 99, 128, 255, 239, 81, 254, 135, 19, 37, 41, 11, 152, 212, 225, 215, 218, 11, 114, 187, 51, 137, 149, 225, 117, 188, 118 } });
        }
    }
}
