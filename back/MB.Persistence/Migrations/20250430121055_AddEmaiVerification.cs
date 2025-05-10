using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddEmaiVerification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmailVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "04/30/2025 14:10:52",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/24/2025 10:44:58");

            migrationBuilder.CreateTable(
                name: "EmailVerificationTokens",
                columns: table => new
                {
                    TokenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExpiresAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailVerificationTokens", x => x.TokenId);
                    table.ForeignKey(
                        name: "FK_EmailVerificationTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ebaf98a7-4467-40a3-a85d-de4545cfbfb2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4963), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e969e3ca-1fa1-4540-a466-28e913c1d109"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4975), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5fcd5207-2502-4054-bc0c-a511528ed492"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4977), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ef8bdda-a72e-4124-ba1e-3cb8f1b25889"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("307be23a-5728-44cd-86ff-8d0f26d34884"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4999), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9a25710-ea8f-4750-b557-eb0f6e6607ec"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("345b784f-86fb-4327-a589-41b09adffefb"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5006), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bf654060-e680-42de-9aec-35169353c26f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5011), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0179f86a-09f8-46ab-9f2f-ff1102166471"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("232153f3-38c7-43b7-b069-86bc65d0f948"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5017), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17bd1b78-adcc-4e99-bb03-dd1485f2dd92"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5019), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9067fc89-245f-4a97-9eec-3457ce3cad70"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5024), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f2f6f368-338d-418b-b151-cca396e0ca0d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5026), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1ae25e6b-83cd-4cee-acae-f9ee5333a02c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5039), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("761794b0-28fb-41f9-888a-3658e247d229"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5049), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e20b07ee-68f6-4aa3-aee9-391baff7cbfd"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5053), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9701327d-f5e3-4234-98e2-dea1c8844ef0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5056), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("61eec827-8c7f-45b8-938f-2785cd05c98b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5059), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0639529c-d836-4cbb-8b5e-80f7ba819e64"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5062), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("44822889-0676-4ed7-9c7d-415b9bad8f73"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5066), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2605bf1-4d88-4b9f-b101-b3e953e66642"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5068), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99fc4192-ae48-45d1-b2e0-3089998e8812"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5071), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6a5f61ef-0b2b-4305-915f-b9e74694e3b7"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0a3cf2fc-d88a-4c01-9029-a46a9f6f81a5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5486), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("45cb54e2-cbba-4c3b-8a36-a76fb56608cf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5493), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b91e90a0-1d80-4bd6-94f7-694ba3f4081d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5548), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6494cb9f-81e0-4bd5-ab33-0546ebe42910"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6102), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5f5e0cdd-8df7-4638-a03c-7a5dce1679da"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6109), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e0658f12-8326-491f-bf26-c9d40e374390"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d8d7276e-7d9f-4ce1-8d76-9144174fdb2d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6118), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b1bd3297-9cfd-42c5-8332-91fa9ab8fa8b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8bd9fca3-a6da-4d57-a4ce-35aefdd18e74"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6124), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de20f5ea-bbd9-4473-bb0f-d85053a62071"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6126), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20d5cf3a-e4af-43bd-b40d-b21708d9acb4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6130), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f83cd95-a4c1-4f73-9ad9-ef63d6e2fbfc"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6133), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7c571268-8386-4c2d-986e-8a1d68e0edac"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6136), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("266e032e-e01b-418b-be0c-8438eb955603"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6138), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8df7311-020e-4871-a1df-7d70d8d4732a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6142), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f042609-f59f-4bf8-9296-78c11b849f9b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6145), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("edecf290-9f5b-428a-9466-07bafef39de8"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6147), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43832c4b-a273-4947-b694-8bc1dd87fdc9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6149), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("017b8836-4064-4671-b997-d89e395f3c60"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5864), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88e8b749-9256-4d33-94d2-d8e957c53c32"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5871), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ad94a6e0-20cf-4411-a2ec-fcbe15b36a8c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5877), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("046ad1f9-a16d-447d-b7e3-6cdab3a764df"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5879), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a6e2b824-f39a-4bfd-adbf-145962b4892c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2feb45b5-75bc-47cd-b483-4a24bf09a4e0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb87ba9d-5dae-4942-bec9-2a065bf044cf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3802d4b-884e-44e0-b080-bb44c30f357b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01cb67b1-6d49-4923-9991-95ab642e6e35"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5896), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fd2ed02d-1d03-4e11-931b-6c3e0c00a035"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d8efef12-ba07-4350-a5d5-29561617f753"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4d52e83e-9d6b-4176-aa8a-a834d84120e4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c0f6e3b2-7bdf-4f2a-823f-6d5f26d57fe3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5829e1e8-9cd8-4e1d-87e2-d3b17ea9db64"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b3e73fcd-52da-4cd3-9993-ee5108b6050a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7db42c0d-3410-4a4d-9ab0-47c5aa8f071c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2ebe5aa4-8aba-4dae-9e08-d9f5138b909e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("145d4b6e-f7e5-4c33-98cd-c6f5da8d5cdb"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5923), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("67645337-c66c-4746-a0b4-d77c93504763"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5928), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0712b32a-2a4f-4b9a-862f-6e3ea8af3a1d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5930), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a61b1fa7-688d-4377-8de3-77ac5f7154ec"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5933), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a86a1197-bc04-46d1-84cf-e08f8e7b30d1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5935), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de099225-3f62-43e6-bf99-62f86d0a3778"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("04191d65-dc86-462f-88d3-ad98656f3781"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5942), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e2be0724-fb74-43fa-889b-206e3fe06bd1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea6cc5bd-4f13-48a1-8ba4-fb5948554cc3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5947), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb850514-8f18-457a-9159-d25cccc63ada"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5952), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3883a284-18b1-4b54-9d88-a48a97887f80"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5954), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c133fb44-1c05-45fd-b9bc-be520c99f26e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5957), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b2fa80ae-d59e-4927-9c88-fec4cbf15f06"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5960), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d76bb936-adf0-4667-90be-f609f26b7fc6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5965), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("122921ca-c747-4648-9ff7-66fb5e6a020b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5629), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2bd2e43f-2af9-4cc1-a0dd-c5a8c67f5cb2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bba6c7e1-c4cc-4e94-8fcc-e79a2588a00e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5637), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03a598b3-21a5-4e9b-b929-dc02c30cfa9e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5643), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5bf6093a-7f31-40b0-a778-d1792bcc529e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5646), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("baa90002-2cd2-4454-b9bd-8451d0c20520"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5650), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6aca3308-8e6e-4ea1-8ed9-366be6b00d69"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5652), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("89d91921-3571-44b1-931b-51372aa5aa06"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5656), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0c7f0510-8912-45b5-9441-eae79b599d9f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5659), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63e1981b-1a37-4fd2-a28e-f60cb3f89142"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6359), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f509e20f-261f-4e41-8b88-aed26edc2acf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6366), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87cab1d4-5cd9-40fa-8518-98931ca8007c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6369), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6432), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6455), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6461), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6464), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6468), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6516), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6521), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6524), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6528), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6536), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6540), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6544), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6547), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6551), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6555), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6568), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6572), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6574), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6577), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6580), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6583), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6692), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6771), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a49abb93-b691-473f-bc92-9bdf6129c10c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e321ca1e-4c98-4904-8318-5dd586208b55"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5296), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("84b0d32f-d6ac-4823-9a88-d834ac47b83e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5299), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8f1cf5b2-ef0d-4958-9894-32919b681f71"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5301), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd92cbca-14e8-4d85-b05f-b8ab4c1d80c3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5307), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02ba23e0-4e24-4c6a-b530-3e39a607fc2b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5310), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24d52a54-17f4-45c3-b57d-0cd6ae71f673"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5313), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("87493f45-017c-4249-a669-d8ff322883bf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5315), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3d6643a1-7e73-4804-bc75-d2b1424a4d40"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5319), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("614b8193-a6ff-46d3-91ac-1aaa4a18aba1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5323), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e746816-97ee-49f5-9a52-819b998e6bfe"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1c0e61cd-7a58-446a-b5a5-86a3f1dd39bc"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8ba1e26e-da85-49a3-96f3-7534561ddc12"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7774), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9e325fa5-4e0f-4eca-af3b-ebef9001c54d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35458084-ec33-4b05-ae1c-9fc04ca9524e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7779), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b44040b1-0ec3-45cb-bf93-b504cbc587db"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7785), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fa24bfdd-e589-4b39-b5e3-46fcb2fb20f9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7787), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4c9cdef-88f3-42ec-9009-c6db6596fd8d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7789), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96bc8164-62b0-4310-89e4-5b29b21ef61c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7792), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("694174c2-3266-4894-bd6e-a47a3cb930ae"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae176893-ec6b-40fd-9c0d-8d7b62aa54a4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("16cc55eb-50a7-49a2-a895-ec91870b1bef"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7803), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03469936-70ef-4e4b-bc9c-517f753efd2f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1cc3e413-03d9-4b7d-b42e-35d56d959f9e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0aaea2ab-0768-4426-ba09-187ba9b6c4e3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6996a956-a4d4-4939-83a0-a590e146794e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7815), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aa677a45-4c0c-44de-a901-16a17493b5b7"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("294878f6-d163-4563-91a7-3762478c42d1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7405), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4c44ef84-e05a-41cd-b8f9-a1db2fa31d13"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7412), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9f2f256e-e6fa-4165-83bb-d3eccba45d40"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7415), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("27ccde90-29ee-443f-8161-f31f4797c342"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7417), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("67127fd2-8ca3-495b-a1ff-300786b272c9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7422), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2dc49cae-4f61-471c-868b-b145287d7e55"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7425), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18d5f67e-7016-4cc0-9bff-56caf0854d5c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7428), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7444f73-9deb-4905-96c2-d48af89d1344"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7430), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be37b8fb-ef4f-418a-98b4-0421541ef37e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7435), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b50677a9-5303-4b30-a146-c568a6ba4f64"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7439), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b1491f7a-39ce-494a-8c42-bd2cee250866"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7442), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4732c0a-4970-403d-ae04-4330d2c542f6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7445), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("128fd1ab-8427-41c2-b833-035c6e1c842f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7449), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6312124e-6f31-4b7a-b6c9-6830661b231c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7451), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a38d0044-9c3f-4cf2-8095-a7352949bc83"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7454), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9c3b66b8-4463-4f37-8278-23012face1cf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7456), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c19543b6-3fe3-445d-b31d-0abdc553eded"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7460), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4c8cf567-1e5a-4ba3-bd0d-119b40145768"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7464), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9fe01c43-2e57-4415-9205-e4b57cabfb43"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7466), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a0256c0-fd84-4960-8662-a8e8da9e3334"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7468), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dbb91a12-a5a2-4e2b-9990-189df67269fd"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3d5b6c4-0586-432b-9ed3-f4ea3431685b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7475), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("672ba361-7f17-4607-9951-d66dabe9717f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ece3ed27-2c5b-453d-ae62-653048e88ac6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7480), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43bffd5f-9243-4225-89bc-e3d09eadc3d7"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7484), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("34e4b75f-a38c-47ae-a1d8-1499d9caa55d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7487), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43318f5f-d63a-4099-be15-e771dc38f5d6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7489), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("23389ffe-4c14-43aa-a65b-6e9fc5a32b67"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7491), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ecfe55a6-af0b-4676-9a19-682c77d533f8"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7496), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("815bd7c9-1946-4545-8911-a491ab82d79d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7498), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31be778a-bdb0-4b59-9421-e0cc806791d0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7501), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3f7c3e44-fa84-4337-ad16-ca84bded3057"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7504), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("64c3e5b3-c0d8-4bf8-9681-59610af71130"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7508), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("88e8e37c-823a-4b84-a853-cdf6f8f3136a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c89aac88-222f-4caa-8386-96f06a738a1b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3761de3f-cacd-4606-8355-c3bea4c55c3c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7571), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ba1b30e7-02a3-47bd-b003-45a51dae5ef9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7576), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3cb10245-2308-40f1-b5ae-02f35826507a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7578), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bee6e8d6-f32b-42db-a179-91c6d5d6a58a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7581), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2c756784-6877-4ae2-98ca-909df575e7e0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7583), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("161b1cb2-ab05-46d9-822a-17778cdb42a0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7587), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5c4da291-70a3-4426-9b44-fe826bb9cfe1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7590), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("32295705-b2dc-4d02-971f-a375cdadcb08"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7592), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0538bb72-944c-4058-b9ed-0bf9b58deae9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7594), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("75cb6e5e-3b03-43a6-bca0-ead160f1df44"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7599), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("304a9b6f-01ce-45c9-b30e-9de823c888c2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7601), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("83b6049b-5509-4b98-8cff-104c0bebfe79"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8d9d544-0d58-4127-8a80-ce2ae2b4b0c4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ed3a7f3d-f3d0-423d-9458-bfa59f561250"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7610), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05a5b11d-06cc-473e-841f-766af9e7eb28"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7612), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7f3c3a8b-6ffe-4616-b91c-b17e732d8934"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7615), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9af66a4e-3f0a-46b0-9412-7a961391f52f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7617), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c2e1e0bb-169c-40ba-8117-3a73b62a0dc4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7623), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a8248b19-b88c-45df-979e-f8677479b6c9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7626), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a8cfc70-95c1-443d-b86e-8c0d5dbd1601"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7628), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d829399b-a731-4623-b2dd-d8bbe36bce05"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7630), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("771f6090-6501-4e1b-89de-3340a172b4d0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7635), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e1c882bc-70fd-4d1a-b2c8-dfae21c7a7c0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7637), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f647235b-73af-473a-ab67-4d066a90409d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7639), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ac7e1f7-c5b6-4c88-b320-bf0bac4b7c5f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7898), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("69741af4-f72d-4f43-a0a7-493ea6ab0435"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d678fa1f-6d3c-46ea-a7cc-762071ef9c58"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7950), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22b5a7ce-df7d-4d62-874a-4d9231de2cc1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7953), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e9a20f4b-c623-4438-8a2d-1bddec6bfd0f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("72c6094c-99e7-4ff5-a1d5-3fbf8f43d918"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8037), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8034), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8032), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "IsEmailVerified", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("09a4d57a-ec9e-4e0a-926a-df492cac8520"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8545), false, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8547), new byte[] { 37, 110, 206, 90, 139, 85, 200, 57, 180, 250, 148, 94, 25, 164, 7, 113, 100, 222, 64, 83, 207, 162, 0, 57, 213, 26, 122, 55, 6, 55, 3, 3, 56, 173, 128, 132, 90, 4, 2, 39, 151, 203, 74, 45, 237, 124, 17, 102, 209, 36, 231, 99, 254, 174, 180, 86, 253, 12, 252, 112, 95, 135, 137, 229 }, new byte[] { 189, 34, 18, 113, 248, 103, 113, 157, 225, 82, 10, 115, 13, 134, 96, 27, 89, 123, 198, 241, 227, 64, 233, 1, 171, 233, 46, 255, 134, 156, 182, 30, 248, 235, 146, 189, 93, 214, 84, 87, 122, 216, 4, 232, 227, 75, 132, 105, 210, 20, 181, 110, 35, 146, 16, 226, 55, 3, 139, 91, 212, 241, 198, 135, 35, 246, 185, 3, 71, 12, 66, 175, 206, 27, 245, 184, 122, 72, 153, 238, 10, 130, 120, 25, 240, 202, 220, 90, 118, 113, 48, 195, 183, 88, 62, 195, 189, 26, 45, 105, 41, 128, 203, 143, 125, 155, 93, 22, 4, 189, 110, 187, 37, 218, 132, 179, 247, 46, 86, 232, 165, 249, 236, 129, 150, 241, 162, 16 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "IsEmailVerified", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("0dc9665f-58a5-432a-a663-dda1e991cef2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8651), false, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8651), new byte[] { 49, 153, 240, 253, 109, 70, 9, 215, 50, 221, 46, 244, 237, 110, 187, 173, 145, 252, 81, 62, 222, 204, 153, 50, 103, 136, 127, 245, 2, 0, 241, 29, 104, 115, 109, 172, 232, 85, 145, 127, 11, 16, 101, 233, 61, 232, 40, 250, 149, 148, 34, 221, 117, 55, 49, 245, 246, 178, 189, 14, 28, 17, 123, 170 }, new byte[] { 1, 75, 177, 2, 44, 210, 236, 55, 162, 98, 209, 193, 210, 185, 69, 175, 138, 229, 159, 146, 60, 213, 133, 65, 65, 236, 238, 203, 86, 207, 64, 77, 22, 1, 198, 56, 191, 247, 225, 108, 108, 245, 98, 38, 55, 169, 171, 85, 90, 214, 87, 226, 233, 21, 51, 74, 23, 56, 27, 32, 52, 248, 199, 0, 238, 31, 89, 46, 194, 122, 60, 165, 189, 234, 61, 6, 231, 21, 48, 182, 220, 237, 172, 198, 60, 223, 242, 104, 18, 171, 124, 44, 57, 211, 182, 7, 83, 242, 50, 191, 37, 29, 253, 179, 75, 107, 38, 215, 171, 24, 50, 54, 22, 70, 113, 205, 137, 182, 101, 16, 103, 10, 1, 136, 11, 129, 59, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "IsEmailVerified", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("c955d393-acb9-41b1-a642-9b78ce0e97ff"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8738), false, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8738), new byte[] { 75, 15, 75, 114, 10, 156, 93, 226, 131, 140, 222, 144, 35, 22, 63, 6, 192, 158, 101, 185, 51, 4, 163, 94, 63, 128, 123, 200, 204, 170, 189, 246, 160, 29, 5, 111, 36, 138, 85, 237, 106, 223, 13, 149, 64, 29, 93, 251, 202, 25, 66, 231, 211, 156, 62, 101, 243, 31, 37, 55, 73, 232, 137, 112 }, new byte[] { 201, 87, 241, 108, 194, 65, 210, 58, 172, 94, 186, 189, 183, 213, 31, 154, 158, 113, 18, 249, 220, 197, 50, 112, 3, 159, 118, 18, 162, 136, 224, 48, 110, 241, 203, 116, 120, 61, 114, 220, 227, 55, 140, 136, 168, 168, 80, 62, 155, 33, 18, 117, 212, 72, 167, 188, 41, 72, 110, 187, 178, 252, 255, 115, 246, 173, 194, 222, 49, 170, 22, 59, 105, 217, 182, 122, 168, 93, 211, 42, 54, 242, 243, 134, 10, 72, 81, 27, 122, 196, 187, 204, 191, 40, 69, 142, 253, 174, 198, 10, 177, 76, 247, 214, 188, 190, 87, 80, 8, 192, 33, 86, 167, 77, 166, 86, 152, 77, 166, 123, 230, 156, 172, 77, 9, 175, 208, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "IsEmailVerified", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("c16594ac-2bb5-4d5d-a477-ce342cddd7b5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8821), false, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8821), new byte[] { 26, 205, 151, 164, 64, 60, 163, 48, 27, 212, 232, 4, 192, 110, 134, 189, 131, 29, 247, 94, 236, 90, 248, 206, 199, 126, 102, 62, 141, 107, 159, 106, 173, 199, 207, 25, 103, 118, 254, 184, 114, 147, 206, 81, 162, 82, 17, 64, 23, 139, 210, 243, 200, 242, 238, 105, 26, 34, 169, 94, 228, 179, 187, 227 }, new byte[] { 179, 64, 32, 168, 240, 181, 158, 114, 154, 215, 169, 209, 161, 241, 246, 201, 164, 156, 205, 33, 200, 126, 51, 141, 186, 41, 217, 80, 188, 109, 30, 159, 27, 187, 184, 138, 205, 86, 180, 219, 227, 208, 66, 223, 216, 215, 169, 5, 10, 223, 170, 117, 47, 151, 6, 141, 231, 155, 98, 200, 57, 108, 141, 54, 28, 26, 189, 123, 74, 207, 210, 142, 197, 151, 45, 45, 53, 20, 35, 117, 113, 179, 202, 48, 4, 39, 140, 192, 40, 40, 58, 58, 67, 32, 62, 222, 92, 28, 132, 153, 235, 216, 5, 13, 98, 88, 249, 36, 202, 113, 59, 71, 134, 153, 116, 151, 211, 87, 135, 66, 167, 253, 187, 29, 238, 110, 213, 19 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerificationTokens_ExpiresAt",
                table: "EmailVerificationTokens",
                column: "ExpiresAt");

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerificationTokens_Token",
                table: "EmailVerificationTokens",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerificationTokens_UserId",
                table: "EmailVerificationTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailVerificationTokens");

            migrationBuilder.DropColumn(
                name: "IsEmailVerified",
                table: "Users");

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
                oldDefaultValue: "04/30/2025 14:10:52");

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
    }
}
