using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class twelfth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pseudonym",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                oldDefaultValue: "02/06/2025 09:58:39");

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

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7026), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7031), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7037), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7041), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7045), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7049), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7051), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7055), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7059), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7062), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7067), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7071), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7075), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7081), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7085), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7089), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7092), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7098), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7102), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7105), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7108), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7219), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(7219) });

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
                columns: new[] { "BusinessId", "Created", "Experience", "Level", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("0a6e300a-6865-4e49-a2b7-1c4129a84fae"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8691), 0, 1, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8692), new byte[] { 232, 162, 202, 60, 39, 249, 151, 99, 122, 165, 70, 210, 199, 67, 112, 205, 5, 203, 50, 19, 43, 115, 131, 250, 172, 108, 31, 172, 21, 19, 207, 141, 92, 106, 157, 242, 1, 167, 167, 68, 210, 56, 55, 152, 145, 230, 154, 116, 97, 20, 220, 133, 163, 110, 128, 129, 116, 140, 18, 66, 91, 145, 203, 90 }, new byte[] { 255, 183, 122, 173, 171, 113, 249, 143, 5, 164, 90, 143, 176, 84, 217, 251, 148, 33, 14, 17, 101, 4, 78, 126, 180, 16, 222, 126, 161, 73, 152, 91, 190, 134, 237, 170, 247, 63, 243, 55, 7, 125, 91, 86, 132, 217, 126, 152, 246, 243, 71, 77, 129, 81, 50, 109, 214, 185, 133, 201, 175, 36, 32, 164, 155, 196, 128, 236, 19, 43, 187, 96, 252, 158, 181, 131, 81, 242, 244, 190, 244, 204, 189, 213, 64, 222, 175, 23, 7, 236, 123, 216, 76, 102, 7, 95, 82, 210, 129, 252, 130, 68, 67, 165, 159, 202, 164, 207, 162, 252, 106, 26, 252, 228, 78, 235, 237, 12, 192, 126, 37, 109, 174, 163, 188, 137, 152, 59 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Experience", "Level", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("26e43f61-040d-4ac7-94ed-7aa6056355be"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8774), 0, 1, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8774), new byte[] { 34, 20, 57, 5, 245, 42, 199, 219, 96, 213, 83, 42, 153, 130, 113, 78, 71, 157, 33, 88, 129, 60, 93, 233, 143, 250, 165, 222, 91, 73, 164, 149, 204, 102, 28, 0, 187, 5, 149, 252, 139, 119, 80, 94, 144, 117, 77, 188, 170, 204, 15, 136, 114, 15, 229, 103, 140, 124, 51, 221, 81, 132, 234, 51 }, new byte[] { 51, 168, 92, 171, 52, 154, 28, 138, 8, 94, 171, 158, 161, 211, 71, 218, 76, 237, 17, 103, 184, 30, 37, 20, 106, 212, 208, 35, 62, 184, 57, 183, 21, 173, 69, 16, 28, 242, 28, 134, 115, 30, 131, 180, 110, 128, 22, 209, 144, 252, 240, 63, 240, 35, 40, 249, 106, 105, 55, 135, 61, 166, 235, 89, 77, 201, 119, 203, 118, 4, 112, 227, 68, 134, 230, 107, 25, 235, 254, 140, 86, 201, 1, 79, 185, 53, 91, 163, 45, 231, 70, 144, 177, 27, 22, 94, 58, 214, 75, 54, 237, 83, 25, 17, 231, 48, 235, 189, 213, 75, 151, 99, 1, 1, 95, 123, 33, 32, 44, 11, 58, 167, 80, 187, 130, 244, 123, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Experience", "Level", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("769d970b-6ef9-422c-8fa6-c06510461a74"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8831), 0, 1, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8831), new byte[] { 204, 121, 123, 15, 40, 41, 230, 182, 19, 38, 63, 227, 89, 157, 134, 177, 10, 39, 113, 108, 234, 34, 150, 17, 185, 240, 21, 118, 53, 46, 93, 158, 168, 86, 70, 48, 228, 69, 183, 221, 122, 113, 200, 43, 251, 224, 226, 111, 249, 112, 20, 63, 67, 193, 155, 99, 154, 162, 82, 142, 222, 168, 166, 12 }, new byte[] { 235, 223, 30, 238, 45, 130, 249, 14, 96, 75, 199, 35, 186, 55, 13, 144, 173, 81, 73, 176, 186, 205, 127, 210, 164, 243, 124, 36, 184, 189, 224, 127, 14, 35, 78, 36, 39, 23, 137, 51, 168, 144, 6, 144, 116, 31, 222, 194, 189, 167, 255, 218, 179, 1, 254, 251, 233, 143, 137, 55, 109, 151, 189, 205, 175, 228, 159, 236, 248, 190, 55, 30, 121, 196, 17, 1, 209, 48, 60, 46, 97, 74, 230, 141, 211, 129, 37, 206, 135, 182, 155, 188, 186, 45, 123, 137, 72, 226, 150, 146, 167, 151, 153, 237, 22, 226, 206, 63, 200, 86, 213, 9, 131, 16, 86, 98, 112, 240, 156, 165, 86, 191, 119, 45, 158, 224, 89, 115 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Experience", "Level", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("a748fcb6-086e-4838-9467-9841b0a21a93"), new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8892), 0, 1, new DateTime(2025, 2, 6, 9, 10, 33, 28, DateTimeKind.Utc).AddTicks(8893), new byte[] { 166, 14, 102, 98, 220, 236, 64, 23, 136, 110, 223, 98, 54, 84, 85, 124, 107, 45, 214, 173, 233, 212, 79, 196, 75, 120, 187, 218, 123, 44, 95, 16, 156, 160, 3, 208, 156, 12, 82, 247, 9, 167, 231, 47, 8, 59, 173, 118, 50, 246, 106, 199, 74, 103, 135, 189, 248, 246, 168, 13, 77, 150, 160, 207 }, new byte[] { 239, 222, 113, 178, 29, 251, 194, 187, 125, 44, 28, 225, 253, 73, 34, 47, 122, 54, 137, 112, 194, 126, 228, 97, 243, 45, 127, 133, 135, 82, 136, 55, 250, 173, 25, 72, 5, 163, 150, 32, 137, 244, 158, 85, 30, 254, 46, 130, 13, 134, 109, 180, 73, 241, 36, 205, 61, 70, 74, 202, 110, 200, 165, 200, 69, 121, 148, 159, 130, 252, 165, 238, 113, 109, 17, 89, 185, 180, 226, 40, 97, 104, 142, 120, 210, 3, 181, 53, 196, 119, 206, 176, 105, 163, 9, 101, 246, 134, 196, 177, 51, 36, 24, 220, 50, 210, 44, 194, 121, 77, 110, 235, 255, 197, 171, 116, 145, 111, 142, 190, 167, 234, 70, 137, 6, 46, 79, 142 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Pseudonym");

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
                oldDefaultValue: "02/06/2025 10:10:33");

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
    }
}
