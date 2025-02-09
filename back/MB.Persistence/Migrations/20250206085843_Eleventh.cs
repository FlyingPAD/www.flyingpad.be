using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Eleventh : Migration
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
                defaultValue: "02/06/2025 09:58:39",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "12/23/2024 14:41:11");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31f409c2-16ac-47ca-a236-1ca6b91fdd75"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b21d1308-e111-4583-8615-254b86d8ab2a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02983444-328e-4f25-9f99-935c6e33fb9b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("90a4306d-1f4c-4ef6-a14f-de111260769a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cfd95414-33f6-40db-9956-154ef4e44b05"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7204), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("21330a5f-64e1-474a-a0b0-c27a31956c72"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7211), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7e470a7a-5237-4b7d-a309-64403f086eaa"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7215), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("df419347-499a-4f1b-8df9-4ae8522cf13f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dde6def6-e56f-468a-8bf7-47359062c216"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7229), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("09d88514-ded7-4289-8e1e-6d72bc9c0d64"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7235), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3e625470-7427-4ec0-b224-b34f23460cf8"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7243), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("928a2633-26f9-48d8-ba1e-f1e87836ec1f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("895fdc2c-f35e-4d97-95ec-9ef6a1aa3a94"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7251), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73f2d011-cad8-4094-b4f4-7d5d93b2d805"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7254), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2962d7ac-5fa8-47be-8577-8364230a9afe"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("86ce7399-79d8-4e32-a0e3-b1c71f3c4bb9"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7258), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7b71d41f-31a9-49b5-bae2-c339e5d97540"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7264), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4bd9a3a3-9439-4a79-bd42-45b4c4a382fd"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7267), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("98d1d8bd-92bb-4205-ba0e-e25e20a1809b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7269), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dc6f876b-a11f-4b88-988b-124d80d8eb5d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ca66e2b-e3d6-4fad-99dc-441de83f0d5b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a63bbfcd-0338-441d-ad67-606640d7cc8d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7279), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aac86187-4be1-4cae-99c7-8f432ad8e953"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7282), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("402660d5-16d6-43da-86e6-42a457e6ec86"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7792), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("49397148-445e-49a7-9dcb-3923c9a2436e"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01d2f07d-215c-48d4-aa9f-8b591dec7723"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7799), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11921380-c8b7-4d0d-a6ee-047b135d42c3"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8430), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("410038bd-be84-4402-9bdc-e3f0f76aa2db"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8435), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("68d18ba9-44a7-47d9-8ffc-a3fa20113f1d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8439), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8dcf4854-bd2f-4cb7-a91b-0dddda67e956"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8442), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b758a89f-46ca-448a-82fb-a1ed7849f922"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8448), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00b3dbb7-31e7-4a4d-8c6a-0ccd0df50376"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8451), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("350974c1-5975-4af5-a287-bcf6faed5cc5"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8453), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("538ccf98-004b-4904-b5aa-5972f40ff9ab"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8455), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7b147391-572a-4917-baf6-1449b14ef0aa"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8460), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63479ed7-52f8-465a-a1ea-1e4af760422f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8463), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d2bbdb1a-b612-4417-81c6-23a7d962e516"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8466), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8e924ce-faf5-4e60-abe8-42a67bbd017c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8468), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3e6764a5-eb64-4111-9e01-36ecef8a0afb"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8473), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("33635739-a0e5-4bd2-9bfa-4c8c08c82652"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8475), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dc67d58a-b443-4cbe-933f-6ae63f2ef3f2"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99df0416-9c26-4bea-bb81-cd3af2b2ef6d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8188), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("207bea84-a7ea-44cb-8b66-c9ef0bfd6acd"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8192), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("81453cd8-6370-497e-b989-f47801a2d75d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8194), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e918652-1645-4f24-9017-3d3e12122a9e"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8202), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac96af68-dd20-4e3c-87ad-16735b48e9c4"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8204), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d130669d-ed44-4a9c-aeaf-13377cd068ca"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8208), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59b038e2-d867-43fe-b441-67dc7340ca0f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8210), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("939c81f4-c06f-4893-abd8-b81c677ba42f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4d54b9cc-4fad-4077-add4-83c4c3e313ef"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8217), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70a75f98-551b-49db-a7f6-21869a02644d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2339c833-9c63-4ee8-8697-68c01149fe1d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15309ada-8eee-473a-a2e2-f17581c07029"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8284), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("244988bc-84cb-471a-8b97-921411612f44"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cc06fb6c-39fe-41bf-81fa-60b8abd6cbb4"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("765b1c63-cfc0-4f0c-be92-f4b123c64227"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8291), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d4d7ad8-be35-4bcd-a18e-07138c8e788f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8296), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0f8edcde-fdd7-4a8a-8748-0450176cce23"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8299), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0a0113fc-40ef-4bfe-bb16-375999cbfd4d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8304), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f3bf982-fbea-4bd7-9531-84f6516c2182"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8307), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e2f8ebe3-39c2-41ed-ad92-146a1504a59c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d4b88b6-f4a8-46e5-900e-fa5ce473aa33"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8314), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce172938-09b3-4753-bacf-fc8f3e13a826"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05120f96-ec91-4102-9cd0-1a8073af205b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8319), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40eaf94c-a8b2-4916-bb61-c9d56cf4b902"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8324), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3eb54358-53de-4a48-a29b-c6b3f7882eec"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8326), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea8654f3-7820-457b-b080-9a490da514df"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8329), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("259825a0-eef4-4d07-a6b8-00414e58285b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8331), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70602a30-184a-424a-9e15-916ceaf0491f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8336), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("201d3135-30f0-4539-b90a-8ac1bbd5581c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8339), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e4b3f961-da70-418e-8adc-62dee281a40d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8341), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4b59c897-23a4-447d-a8f3-5747b2c4915f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8343), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ef951cf-fb96-4a47-9b0a-aa5c9df075a5"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7859), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("358c339f-ada4-4d66-8f12-d7dbe03596f5"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7863), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b3416243-4746-4dca-be51-cbeb83f0e672"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("350d2af3-41fb-4643-9365-841bd2164918"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7869), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("738d17c8-8689-41e1-829f-898b266c9d3a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ca4d0c7-1752-4bd7-a19a-f7c3657d5fe5"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7877), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ce0c9d8-80d0-4b85-9f9c-b823c418e8ca"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7880), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6b70f37f-47d0-4139-8c29-e243cb1fa718"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7882), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a392adad-5d8a-454c-bed1-e5f7c1851797"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7887), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f633e1d-b2a8-43a9-b692-8938aef94138"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8685), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("19a3bd72-e432-4648-8ba1-b15c5f3b582f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9e5b392-d3a3-48c7-ab6f-dda9be9653f7"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8697), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8749), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8773), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8778), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8785), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8789), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8794), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8801), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8808), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8811), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8817), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8821), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8825), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8830), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8835), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8839), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8843), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8847), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8853), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8856), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8860), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8933), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9035), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6dcaea94-f933-4e27-8c60-82d1e11d3d31"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4818e127-01d6-4d9d-8133-d17bb57df92a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7587), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("897d1873-cdbd-4544-b939-a315c6b4f663"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7591), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02d7f815-dd6b-40d3-af7b-0e95b653c69d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7593), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("898a8628-f1c3-4996-b8d6-92e0802b3ea6"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7596), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9374910d-3dcb-4c3e-9abd-ea79a4682d74"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7601), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4d24a8fe-ae43-43c1-a660-b3f88003e91c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("798497c7-8663-4a05-9a61-3fdf4d4a758c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24f171a9-f040-4fc4-baec-6e281158aad6"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7608), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce9692ab-c952-4d03-95c7-b3b4d6611177"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7614), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2cc4993a-cb7a-4ed5-8b4f-0043674555e0"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9797), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59275259-6614-4a3a-8692-1290ce0c3a01"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9802), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f1e192d7-d47a-451a-acae-e30348dc48af"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9808), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2f1f02c7-06c0-43d3-a150-f70c49c46aa0"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("daa09d74-4eb7-457a-91b1-3f54c6bfb74b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9cf4b186-24bd-40e9-ba63-9cd6f2eff89f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9902), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("680f6edc-aaaf-4fa7-b13d-bc54e86bcde8"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9907), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("04c18fa9-99ed-4539-a796-af5a19b28eb8"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9910), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("65510fba-38b3-4980-801c-a9b7e31cbcce"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9912), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d0c7e44-9df5-4338-91f9-98ae46c2fd00"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9916), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dc9e0f31-43db-4af1-bf5a-ef850b17c188"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9920), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e62b5884-fdbb-4e7a-97c6-38365e4fdb31"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9923), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("105198d3-621f-4112-ac8d-7b490c9055b9"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9925), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0ead4007-559a-4023-91e6-8fdbf9635528"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9928), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("824dc6bf-0f4d-4ed9-83ee-791a529c2cc4"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9932), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb4e18b5-616e-49d0-933a-24f53bef7c6f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9935), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7696d5a1-4ea7-4760-b99a-87c37beb818b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b2478453-a9d7-4b9f-8e45-2d36d7932608"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9480), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("60a61a29-43c7-47a1-b715-034fbed5529c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9488), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a9e065f-8056-4c80-8e73-fb6672294424"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9491), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("51b58139-7f1a-4b4a-97ea-8dd9b01b006c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9493), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a64868eb-af73-4f48-b65b-09590a672c13"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9496), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96a60598-4a3b-479b-b0a6-36381695a3cd"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9501), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("991ac963-def1-4270-acad-07523e40c8fa"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9503), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15d15126-4c91-4912-afa4-43e2dccce93b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9506), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08a2e8e7-72ad-44ae-ac44-07e1d386c88f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9508), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d0ddd05-836d-4066-92f6-54096d16f388"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95384ae9-0770-4bb0-91a5-7fafce08f1bf"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9516), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ffbafc42-c322-4389-a228-fc8eff77522b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9549), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be07ad61-3303-41f5-9f0c-24fcc48c2c50"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9552), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03be0741-5e5e-4ba9-873d-1aa425a1df48"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9558), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f8c59e5b-4022-4a1b-863e-7a3a69743ca5"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9561), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05064333-2bd3-48b5-b1e8-b1ca87891a02"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9563), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e674d232-1e92-4a6f-8d09-88bfda56043e"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9566), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9a4353d9-1fcd-4fef-9669-e6766e3eff66"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9572), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("df8a1dbe-1e38-44b8-8da1-b354615a6113"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9574), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05bc2aca-3832-4547-b5d1-5a755f6ca3c1"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9577), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad8c7885-d8d4-48e4-9ef3-01c8b882694c"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9579), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("19eb17a6-a09f-4045-901f-af5ba3baa673"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9584), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6487b7ce-b529-413a-ab45-bb131ef85970"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9586), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("824247dc-53b5-4140-8976-f351f89353d8"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9589), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e25da35-f215-4630-8efa-e3058277692d"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9591), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d8d72f8-8159-4280-96c7-27e75fee8374"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9596), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("521eaf2e-15cf-4ee3-a72b-3144cfc98135"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9598), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5422811f-0c5e-492d-adb9-e72d5aef0663"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9600), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("559188bd-e042-4ef9-99b7-2788006bba59"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9603), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70652e59-f4a6-459b-a2de-5abfb443f10a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9607), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3399506-ee1d-4e93-81e4-36aca245fe63"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9610), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4ff4863-9a2e-4a49-b064-5bdb8e8ebfe0"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9612), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("325105b0-a212-41e5-9877-4601f03509ad"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9615), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("508488d5-8292-46c1-b53a-b25693341831"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9620), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a28b5fc8-7c90-4caa-9cd9-e7356704f26a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9623), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("41ed3a9e-cd8b-4dcc-87c7-b32573799cfe"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9626), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5053164a-1eb0-41ae-b7b5-a3757ec8dd08"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9628), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6f382eb4-d1d5-41e7-8a35-9bdd848f0fc1"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9633), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dd71c5bc-9af7-4a9c-aed3-f0647f21653b"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9636), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("704b9b07-2c37-4161-a378-778516b4238f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9638), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53c37e14-833c-40ad-8519-ee0a49212e12"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9641), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ce6010b-1aad-483e-bc23-934267ec0007"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9645), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("161f7a34-ecd4-4e42-8484-d9f571ccea8e"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9648), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("eb412164-487d-4456-a37d-9b14567c3d67"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62736bfe-1c9b-40e5-8172-e3a30579b997"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5d01be0f-d9df-4637-a1d7-0ccad13d3fe7"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9657), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76836861-6d41-4be8-951b-c84bec995e8a"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("244ac104-783a-48b2-ba32-817f69059db8"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9662), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a83ede42-d17f-40e2-a998-54691b2a76dd"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9664), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2a30adfe-e124-4214-b465-006ca3dde899"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9669), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ba29cf39-7dc5-4e53-8999-ada1694241e3"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9672), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8f3ab12-b2a5-49e7-b49c-b63ec31cd2f4"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9674), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("821cfeb0-c8f3-4a34-9394-702dc6fcd089"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9676), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a1081c52-8aee-43ac-a75e-5f6cd9391acf"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9681), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8138dab3-8f2e-4d45-aa5c-3420b627902f"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9683), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fdac8e43-7f45-41db-8c58-60ed00e57ece"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9686), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9b2d857-965c-45a3-b976-946f138be6a8"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9689), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f34e3d7b-9153-4e7b-b678-ad1c69ee8612"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9694), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("72c79f5c-95c3-4c0d-9cd2-9c805cdcbaae"), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9696), new DateTime(2025, 2, 6, 8, 58, 39, 417, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5659f320-ffb9-4536-a8f0-d3c941e9e0a1"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(9), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f111533f-625c-4abe-aac4-94f8ae5fe056"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(18), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c41f6938-aa38-4eea-aa1b-d48ef444261d"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(21), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18466369-6cda-41d3-8115-b24835717b3e"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(23), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a85c062-6f58-41c6-9d90-c8ef0570a96c"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(26), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("d771bf99-ecc6-4584-bce7-15861c2593a3"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(77), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("eb6a40bc-6356-4ee2-8118-da7d8ab98e91"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(572), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(572), new byte[] { 174, 162, 3, 75, 43, 158, 5, 85, 203, 115, 184, 50, 89, 34, 79, 190, 115, 106, 106, 132, 95, 222, 31, 14, 53, 134, 113, 55, 129, 22, 174, 80, 114, 19, 196, 177, 185, 52, 167, 196, 111, 165, 45, 150, 162, 207, 240, 192, 217, 73, 122, 183, 100, 10, 68, 54, 252, 253, 34, 127, 183, 198, 64, 31 }, new byte[] { 163, 141, 216, 156, 27, 222, 241, 246, 138, 50, 46, 78, 147, 204, 238, 26, 84, 249, 175, 27, 166, 246, 193, 163, 226, 237, 60, 121, 130, 88, 45, 81, 66, 232, 248, 231, 180, 62, 16, 58, 221, 117, 44, 50, 233, 15, 29, 191, 136, 83, 219, 129, 229, 228, 76, 108, 81, 227, 80, 229, 150, 53, 245, 124, 98, 73, 69, 176, 61, 63, 109, 8, 255, 214, 222, 79, 193, 144, 207, 254, 206, 146, 137, 80, 41, 158, 28, 162, 146, 201, 46, 105, 160, 249, 224, 88, 57, 80, 199, 59, 142, 86, 105, 9, 71, 151, 247, 85, 202, 133, 28, 49, 88, 252, 242, 69, 30, 80, 24, 197, 77, 79, 10, 72, 207, 91, 72, 164 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("5b824412-7084-435e-bada-3a593ba1bd75"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(698), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(699), new byte[] { 172, 160, 240, 214, 191, 43, 115, 167, 85, 188, 211, 254, 111, 138, 167, 224, 84, 76, 82, 135, 248, 65, 252, 107, 133, 99, 98, 204, 92, 167, 131, 232, 19, 113, 20, 48, 157, 30, 90, 253, 236, 18, 23, 29, 207, 161, 183, 126, 38, 201, 221, 204, 231, 4, 235, 217, 17, 74, 59, 83, 64, 126, 95, 236 }, new byte[] { 47, 37, 196, 108, 187, 169, 72, 75, 98, 195, 41, 63, 49, 54, 142, 144, 45, 247, 98, 249, 77, 194, 95, 10, 229, 252, 3, 183, 58, 50, 104, 214, 157, 170, 206, 86, 211, 179, 111, 154, 233, 187, 43, 60, 90, 13, 137, 166, 113, 243, 184, 218, 85, 20, 201, 190, 11, 210, 107, 192, 111, 128, 135, 174, 159, 57, 204, 228, 61, 47, 206, 216, 54, 100, 94, 161, 93, 216, 232, 178, 156, 96, 126, 114, 99, 152, 207, 34, 1, 202, 205, 42, 49, 230, 2, 199, 235, 193, 88, 177, 97, 211, 73, 89, 139, 233, 202, 82, 198, 90, 1, 222, 85, 140, 99, 125, 68, 214, 8, 208, 29, 48, 247, 54, 123, 210, 254, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("d80be11f-273c-4314-8708-7f3b991c1dd5"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(853), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(854), new byte[] { 150, 20, 193, 57, 237, 112, 206, 19, 128, 111, 103, 173, 173, 62, 192, 200, 88, 169, 157, 39, 220, 38, 114, 120, 68, 8, 240, 0, 157, 131, 84, 114, 99, 184, 171, 94, 140, 243, 214, 53, 200, 202, 217, 73, 254, 24, 177, 72, 183, 59, 217, 230, 46, 132, 250, 159, 137, 250, 70, 203, 148, 61, 11, 125 }, new byte[] { 111, 180, 156, 16, 173, 99, 56, 171, 15, 140, 166, 184, 255, 134, 172, 6, 225, 147, 152, 168, 112, 230, 218, 96, 32, 171, 142, 14, 185, 50, 124, 121, 168, 128, 30, 74, 145, 197, 24, 19, 94, 244, 96, 142, 173, 108, 229, 25, 160, 167, 90, 104, 55, 72, 214, 111, 93, 115, 99, 126, 138, 252, 245, 196, 84, 184, 101, 55, 179, 177, 33, 70, 177, 224, 62, 42, 158, 211, 206, 74, 69, 54, 38, 253, 172, 201, 245, 36, 193, 84, 176, 123, 253, 158, 193, 194, 198, 23, 170, 102, 207, 233, 61, 228, 161, 124, 185, 115, 197, 67, 192, 103, 255, 37, 90, 26, 71, 205, 12, 254, 25, 156, 217, 54, 61, 52, 89, 87 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("f1e176ef-34c0-4c6d-bd63-f70530d534cf"), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(942), new DateTime(2025, 2, 6, 8, 58, 39, 418, DateTimeKind.Utc).AddTicks(942), new byte[] { 229, 153, 195, 90, 26, 141, 119, 174, 193, 178, 156, 50, 31, 71, 58, 0, 246, 245, 111, 93, 95, 99, 169, 26, 99, 97, 71, 176, 232, 232, 222, 165, 251, 119, 87, 100, 224, 86, 0, 43, 41, 227, 208, 84, 94, 207, 103, 143, 58, 185, 111, 6, 103, 138, 202, 22, 124, 197, 123, 192, 227, 188, 77, 140 }, new byte[] { 124, 75, 4, 77, 179, 185, 228, 233, 125, 54, 45, 154, 4, 27, 17, 187, 180, 112, 142, 254, 67, 114, 75, 238, 96, 236, 204, 22, 54, 180, 187, 238, 166, 44, 2, 61, 182, 71, 141, 247, 51, 47, 142, 0, 44, 119, 160, 39, 204, 8, 41, 7, 231, 226, 234, 206, 233, 1, 242, 39, 94, 33, 130, 23, 99, 8, 224, 190, 46, 55, 174, 232, 7, 2, 40, 141, 23, 99, 113, 34, 35, 110, 229, 202, 40, 4, 100, 53, 162, 180, 207, 251, 75, 145, 168, 70, 242, 131, 118, 188, 135, 248, 89, 226, 214, 142, 247, 227, 171, 186, 96, 66, 153, 65, 211, 43, 16, 34, 200, 252, 127, 226, 13, 215, 128, 22, 226, 208 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "12/23/2024 14:41:11",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "02/06/2025 09:58:39");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ed305ccd-a20f-4cd6-86eb-67b9e1fc1123"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3492), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("634c3110-df80-4e3c-9eac-6f951185c591"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3502), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ba4125c3-3358-42db-b79b-9cfb4240cc9d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3504), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0a7aa9f2-69ca-4ee4-bb6c-ca90312f39e3"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73bc95e1-e9ff-47a6-87ba-01b443e28c38"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3531), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("13d42c87-43a9-41ad-8046-726a0dc2abe2"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3536), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2174fa4b-57ed-4c7c-9813-d6111a7de224"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3538), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f55702c7-d988-4991-b905-331e5ee8d0e8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("abc50c92-7eea-4290-a035-b11fba5118b0"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3547), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("58f09e0d-72ce-4a92-955c-8b8bf6486571"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3604), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7b464c3c-8846-485a-b50a-c607392b04ce"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3607), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2efc106-0147-4f5f-94d0-559e897b3cfe"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3612), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fab40098-bb42-4291-9e0c-9419360f6dce"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3614), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a8e3439-546a-493f-a725-6f429e2555b8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3617), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("16c1aa87-f5c9-4758-87a5-835df2cd8923"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3625), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b92cad49-615b-41e2-8794-058089202e49"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fd7fc73c-0b84-4a48-bb18-fa966691f2ae"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9f5b6c4-67da-46f0-a61d-4f3717bb5d72"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3643), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3910f519-e7ee-44c3-a431-a0fba1cbef1d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a45cced-8840-47e0-b8ae-2af162443886"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e5a59e2f-aa52-454e-a6da-90da3a02edef"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1bc36a60-af26-495d-9dfc-8980a41ff2b3"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e92397d-4aa5-4b35-a40d-26411f7e6161"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b26c6350-3e41-4292-bf33-79ad249fc4b5"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4358), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a47c67a-7b9d-4416-b3d2-a7b79097ae54"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4364), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63dac342-a3e1-433d-8c7f-e7ab4db56876"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4370), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0718dc76-d029-4ae2-aa27-713bdda46aac"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5314), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e984970-7df4-41d7-a50f-998e293bfa97"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5321), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("deba71b0-abc8-4859-ba68-1f9a521bcb32"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5323), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2233af1c-c46b-40a8-86b7-cb64ff178160"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5329), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("91f2a803-a16d-46aa-8d68-133299772fd8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5331), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("56030d3d-7dba-4a4a-88a9-f8c12affe59e"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5335), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcaf15c8-c32f-49cb-8094-f34b23950055"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5337), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b844c591-a9d5-41f5-854d-1b9601948634"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5342), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("57714521-2e0a-4e67-bc21-d64d8e457ce3"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5344), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("485eab0e-beb7-46b7-acd8-d1c493faba8d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5347), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fddeb02d-2b6a-4e9d-b8a4-a800d54158df"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5350), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dae25751-95c0-4190-a434-81755c030e1c"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5354), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fc099f6b-365c-45c7-8908-841405ef93f3"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5357), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e5521785-abf7-4ff2-8a99-f8e8624aeff4"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5359), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6443c171-4d5d-4022-beec-e8d00fda5715"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5362), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad98a3eb-28a5-4954-9bac-c70672e3011b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4834), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ddeeb2d2-6c22-447b-aab2-6ea60c664ecf"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4839), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05cc8061-e839-4958-9664-b4652a18c223"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8195753a-e63d-4687-b9b1-33800e8c00a2"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4848), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6154addc-fe61-4897-a6ef-345add5a945a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4851), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("51624d89-acd8-44a5-b098-aec864344687"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4855), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2a20e03f-28c6-40fc-842b-ad2927626f66"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4860), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("46cd21c5-4e7d-417b-bc9f-90110cf9ab74"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4863), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4dbaec5f-6cc9-4a43-a507-b616c0ce75f5"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4865), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("59b35f1a-d33e-412c-a915-912b456de8ad"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4869), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3125f519-781a-4bdf-928a-ab22364350f4"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4961), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fb8125b-3929-4e07-9716-ade297dd215c"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dac82349-f89e-45fb-be90-bfd12926b5a4"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4969), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("087f4dcf-9530-4c36-9520-4686d916d66b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4972), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("91caba08-79f2-4ac8-9888-c8d09b4e941e"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d7a25edb-311f-4ae0-94c9-872fee738c3a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8cd3b14-16e8-4289-a0a7-1b309045d192"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4981), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e67cbbb-68a8-480f-9b5b-2950d48bfac5"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4986), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77e8fd98-deeb-4181-bb01-be31e7b3c427"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5b8f6045-c4b4-420f-a62f-dde5a886fc00"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5159), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9117b54a-8cda-4ff2-b7e7-d0dcc0afed3a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5162), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("222b62ec-c335-4423-a535-5e7a41412b25"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5165), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4247480e-e311-4e62-9841-6511ca186407"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5170), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7fcaf30f-c3bc-43de-93c5-3ad4ce7c4f5c"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5172), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2564958f-f98c-4a64-b52d-4092140a4b1f"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5175), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73085834-04f9-449d-98b9-dc8b0a3a3fcd"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("51d3f43c-4ff4-47e0-8bb8-97a15b6b56b7"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c02f11eb-6859-4a27-8d0f-b372625bd53a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5185), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4233ebfd-5639-4b25-81c9-0faa5e76ccbb"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5187), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c25f804-48bd-411f-b1cd-0a3acefdf537"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e10cedf5-2de9-431d-a54d-4645b67192a8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5194), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("44905ab2-02d1-4219-900d-4e212c43ecff"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2eef1be7-9958-4149-b3b0-24ba3bd44b11"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4531), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e36c114-30e8-4ba7-b3b7-c59aaee6465f"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fe3987f3-d5eb-4b50-a2f4-17ff3e0b8aa6"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fd0b7efb-9380-48fe-9794-7d9053d0a4d7"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d11a566f-f258-4361-a2e3-ee69bdb5fa99"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bfa9a3b0-5a21-48df-b2c1-2a6118a426fd"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4878429-99fb-4c02-9e74-f85857d6149b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a41184e6-9683-4c65-8c1c-ba78f05b227d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c615d532-fd9e-4965-b10c-e797180d5279"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5959), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7ebfe731-a8a3-4c93-9138-c54c5f58101c"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5966), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("41ab6f76-2add-4548-a3c1-376f4b548a80"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6068), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6072), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6086), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6089), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6093), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6098), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6101), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6104), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6107), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6110), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6146), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6150), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6162), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6165), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6169), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6172), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6399), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6468), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("002d4123-cd86-4a9a-a355-30827182895a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4060), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b04eb020-92e3-4cfa-8420-fad543c7d5af"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4065), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("47f7cd28-df38-42bc-94c4-a90394573250"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4067), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7cb3e838-be2a-4aae-8178-e9e9cd97f3ae"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4071), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fc6ed00d-8e25-4cd7-a43b-b153b3e074aa"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4075), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b02404a9-0fc9-4f12-a42f-0ad3d921c20b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7265771d-5c20-447e-8247-ea7bee8587fe"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e25e8f17-c705-44d8-b5a8-ec055195073b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4084), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fc27811-bc4e-45bc-acf2-f292470a3087"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c33533b5-52a1-4f58-930d-6116c2630855"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4093), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c2e899d-27af-48ed-9c52-5e396bd9457c"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7447), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cbf341bd-43ff-4d5f-8726-1cdc440ad8be"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7452), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ca4dad9-ded9-44e7-804e-3d77d1562576"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d2e50e96-c18f-4b5b-b237-fbaeb70cf048"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7461), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4acb7182-b340-480f-aaa0-563cd2826752"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9adc67e8-ac7e-42f7-b498-420bf824bdef"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("728ab7c7-f5eb-46b0-a3dd-d2101d64c90f"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("52c1b6dd-5b1f-4610-9775-a479477158c8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7474), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f0e4cc1c-7112-489b-ad46-53af4990ac96"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7477), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d675561-829d-4187-8b4e-4db7defdf2a9"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7480), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3edcb1ac-0bd3-44b8-8830-f0b1f226bd77"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7486), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d02caded-71d4-480e-85ed-d30821765eac"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ace9749-a861-4b8f-9248-6a8fec30fc70"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7491), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4be0983-717f-403f-aac6-2f425cc207fa"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7493), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03643a28-634b-4087-ae16-eacfc38fa687"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7498), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6c2aba3-cee8-4c03-b24e-ed5e51b96fc2"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7501), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd9b8763-e15c-4461-b75e-cb3ccccf50da"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7503), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e58fa6b8-737e-4fcb-a24d-c9ff5078e4bf"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7096), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("af41d900-cd26-479d-8c12-abba3db622a1"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7108), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4923f7ee-5651-482d-8c92-fa90429c800b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7111), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8f19854-93f9-4421-a3fb-01532b6108bb"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7113), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2721b9e4-e3fc-44dd-85e4-eecc410c5af8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7116), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36817148-4c01-4976-82ca-26795f6ad06a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7121), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2bb04308-c7ee-4e7b-be7e-e681186f16b9"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7124), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11fcce29-4647-430d-81fb-f37796fdf526"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7126), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1de126e0-90c2-4ba7-83f4-71a0bcb3e9ef"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97c53558-d337-4e47-b99b-e93072bd53c9"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0434da26-88af-415e-aa75-e6470d0fdd3d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7137), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("45766385-d9c7-4a67-ad92-a4b86e4bdd33"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7139), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7b16f67e-6186-45f9-b159-07b95a750f45"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7142), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94e1e79e-de0b-420f-8856-cde4b97b79c8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7147), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c1c97ebf-1103-48a1-b5b5-3779c1788bb1"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a801c890-4f11-462b-b3f7-09be125c0ee1"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7153), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("30704053-1918-4636-9d58-ac4e98e9df34"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7155), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6f282791-fd2c-4758-92b8-50e86a25dded"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7161), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f6ce0ab3-f4e5-42a6-bbc3-d34180b91838"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("974f0f6d-8f6d-4fa1-86e4-b9c90193550c"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c9f26fe-17c4-4fa7-b294-9ceac752a0f7"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7168), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7bdc0ff9-0a0d-4a48-976b-d225e453e432"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7173), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("af3d7102-6e1e-4863-9056-f8b3a5965e4a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7175), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ffba7dcd-4587-4844-bb19-1d3305b1449d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7178), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7c0f8497-82a7-48b3-a4b4-7b498b08ab4d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de0854cd-a7ef-43dd-9924-6850eda7a968"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7185), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e91fa8c0-b4f8-43ac-806d-53fdb196931b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7fbe35d8-acf5-4aa8-a1cc-8ee61deed650"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7190), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd908bd3-f511-4faf-ae3f-cb8b3ac5d40a"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7192), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c734d65b-4972-45f1-a37c-2a2b1274fdcd"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7197), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f44690ee-64a7-4d92-9fab-baeb97d58fe4"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7200), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("965c50d8-3790-471c-96af-f83dc1920c71"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7202), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("743a7fee-3e53-485f-9e7b-bbb17112bdad"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7205), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c191aa53-7193-4e52-8228-b13537e8a80e"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c7a0ad09-f019-4d14-9ac1-a8e709ef3c3b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7213), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b1e63f63-2b7b-4585-a273-3adaa837f5d0"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7216), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3b1039fe-a816-46b5-bef0-41294f2a6054"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7219), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31ad7cc3-2934-4a3d-9d1b-a115e023d549"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("691db1a2-0433-402b-8884-556c756f7d8e"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("27bfcfcf-5fb4-419a-8860-fee0273c6dd4"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7229), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6002325f-4e3a-4e42-9872-3fa105eb7038"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7231), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1c2f7c8-a118-4785-b735-8c8d19bbd3f8"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8040ae8-8118-4077-88ad-39b2f97f5bbc"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7239), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("363d47c0-f0f3-4c54-b38c-4072b27f2176"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7241), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3298533-013f-4a8e-8c58-89456a7c0552"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7244), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("19a43ecb-eb0a-4ae3-a68a-e68b7e04091e"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7248), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("60699e77-0228-4940-bdb9-c55df2359f0f"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7251), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d3d4076-ad29-470b-88f3-054507fe906d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7253), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bcccb715-5fb9-475a-a8c0-0cf7ee9e0c9b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7256), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3ac9321f-2c4a-4f85-957f-f971e01ac0ba"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7299), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e9be50b2-0582-4ede-b987-c076f9e7f049"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7302), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1e0eec3f-c997-4e73-b485-bdd15ddbae05"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7305), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fccb3b70-6fe0-402a-aedd-5325cbd7c3a4"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11b42501-fbf6-4349-9709-36c5bc008b45"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ae02f67-6990-49c3-b3e7-e4449ccf9a19"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7dec1ffe-463f-450d-8263-484debb322f6"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7317), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7875417f-e61f-4892-8c51-a90bdf2d75cb"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7319), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ecee3308-7210-4f7c-9256-92adcc2d1a9f"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7326), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("151748e1-c2d7-4af8-8951-d5f627d31c0d"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f7e1a4d-d50b-42ec-8f1c-00fdb0febc6b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7580), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f0ac7953-3b96-425a-8600-6958640d12ff"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1fba525e-0ce5-449e-8736-bf954aef5752"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ab1cc6b3-fe8a-4674-8e47-b5a00896ea36"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7593), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c659c798-ac21-482c-943e-fa49a52c6990"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7595), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("549e8c5d-f796-4c3f-95cf-7a6fa6ecdefe"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7658), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7658), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("9e9ab3d9-5cba-48bb-9252-1cdb6e5b4cdf"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8338), new byte[] { 137, 206, 253, 149, 155, 42, 123, 142, 19, 248, 92, 69, 145, 163, 210, 52, 187, 246, 54, 127, 169, 11, 174, 121, 170, 160, 72, 80, 16, 157, 19, 172, 184, 193, 250, 250, 218, 86, 83, 73, 57, 249, 154, 152, 110, 145, 150, 234, 73, 177, 246, 85, 247, 82, 98, 9, 181, 84, 179, 93, 93, 223, 75, 95 }, new byte[] { 120, 22, 129, 127, 107, 22, 113, 43, 88, 8, 20, 13, 13, 23, 56, 178, 132, 114, 34, 96, 178, 140, 173, 203, 173, 232, 211, 33, 221, 21, 66, 76, 221, 216, 110, 222, 164, 99, 78, 181, 61, 36, 38, 66, 239, 61, 135, 1, 6, 173, 161, 223, 216, 29, 243, 116, 186, 122, 5, 198, 25, 118, 72, 62, 97, 210, 192, 22, 156, 160, 124, 0, 237, 181, 172, 226, 29, 179, 229, 62, 30, 17, 253, 15, 26, 166, 137, 146, 58, 155, 134, 211, 142, 79, 72, 90, 171, 59, 202, 246, 116, 137, 10, 103, 124, 233, 226, 133, 145, 245, 209, 174, 44, 117, 31, 222, 11, 254, 236, 44, 216, 35, 112, 189, 54, 173, 210, 153 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("db6b520c-4515-4076-a139-c22713e42513"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8451), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8451), new byte[] { 25, 198, 82, 208, 180, 146, 152, 104, 185, 22, 87, 157, 213, 138, 24, 16, 44, 101, 211, 32, 72, 190, 178, 236, 134, 184, 41, 199, 163, 8, 171, 156, 50, 42, 165, 127, 194, 155, 130, 84, 69, 79, 94, 67, 233, 44, 194, 135, 71, 10, 142, 235, 219, 99, 67, 154, 18, 8, 238, 27, 109, 70, 44, 143 }, new byte[] { 32, 17, 196, 218, 72, 149, 10, 211, 75, 64, 42, 153, 51, 90, 84, 45, 33, 234, 170, 226, 190, 97, 144, 158, 5, 186, 104, 31, 189, 179, 168, 180, 89, 198, 102, 182, 97, 50, 225, 184, 77, 155, 42, 15, 152, 225, 23, 194, 44, 210, 24, 167, 160, 46, 21, 212, 206, 82, 138, 133, 9, 19, 206, 237, 41, 60, 78, 193, 161, 187, 1, 201, 15, 203, 103, 138, 107, 98, 181, 118, 17, 194, 234, 118, 199, 110, 85, 169, 105, 206, 26, 122, 211, 114, 232, 23, 156, 85, 43, 36, 229, 99, 244, 36, 247, 141, 53, 251, 168, 74, 166, 253, 48, 72, 254, 72, 67, 10, 150, 169, 254, 151, 43, 23, 121, 111, 157, 202 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("2a216d26-b09b-422e-b0ef-04e98f48b91b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8535), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8535), new byte[] { 88, 203, 50, 175, 106, 165, 108, 84, 226, 179, 174, 18, 234, 13, 53, 176, 84, 97, 167, 231, 86, 151, 108, 71, 34, 89, 238, 159, 165, 162, 67, 239, 4, 229, 218, 141, 244, 122, 131, 89, 207, 78, 123, 114, 245, 16, 79, 195, 182, 33, 53, 51, 50, 85, 188, 197, 179, 127, 140, 101, 229, 113, 23, 74 }, new byte[] { 238, 93, 9, 80, 130, 159, 118, 25, 32, 188, 140, 196, 231, 17, 249, 243, 174, 113, 28, 100, 7, 176, 107, 10, 160, 244, 183, 22, 132, 167, 34, 115, 24, 210, 146, 241, 189, 187, 98, 192, 27, 167, 165, 97, 111, 95, 250, 228, 166, 221, 194, 147, 233, 244, 208, 17, 128, 241, 127, 137, 166, 13, 55, 119, 94, 74, 83, 183, 14, 89, 185, 151, 204, 173, 7, 83, 169, 194, 232, 252, 64, 11, 93, 113, 10, 230, 80, 131, 108, 101, 169, 238, 118, 106, 148, 129, 163, 95, 95, 65, 88, 181, 72, 172, 14, 65, 143, 83, 140, 5, 245, 218, 170, 26, 249, 100, 95, 54, 158, 66, 77, 142, 203, 153, 98, 127, 179, 99 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("3497ed51-e927-4cc4-9d84-254eeb9ca199"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8618), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8618), new byte[] { 243, 47, 194, 245, 115, 41, 23, 57, 133, 222, 220, 172, 95, 42, 141, 127, 104, 152, 188, 33, 104, 121, 68, 87, 16, 7, 58, 80, 223, 52, 87, 245, 193, 57, 162, 21, 48, 76, 204, 15, 142, 194, 126, 123, 14, 76, 235, 0, 128, 221, 136, 216, 196, 21, 227, 182, 218, 215, 234, 252, 37, 177, 207, 161 }, new byte[] { 102, 144, 18, 60, 150, 39, 5, 7, 143, 25, 125, 104, 61, 254, 115, 23, 233, 233, 108, 135, 15, 28, 9, 220, 50, 190, 134, 64, 207, 80, 91, 35, 66, 174, 192, 60, 254, 253, 115, 202, 33, 103, 169, 147, 58, 153, 44, 221, 40, 118, 176, 62, 185, 43, 188, 31, 85, 139, 243, 177, 108, 21, 106, 132, 93, 91, 146, 181, 40, 191, 47, 253, 130, 108, 21, 82, 234, 123, 23, 171, 25, 4, 70, 5, 28, 75, 134, 70, 201, 113, 0, 153, 9, 24, 75, 132, 12, 94, 85, 205, 25, 185, 103, 3, 217, 159, 144, 164, 89, 105, 194, 13, 255, 68, 167, 243, 162, 72, 179, 225, 139, 138, 151, 204, 109, 238, 102, 245 } });
        }
    }
}
