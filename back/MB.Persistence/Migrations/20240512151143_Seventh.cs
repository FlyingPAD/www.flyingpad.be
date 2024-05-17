using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations;

/// <inheritdoc />
public partial class Seventh : Migration
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
            defaultValue: "05/12/2024 17:11:42",
            oldClrType: typeof(string),
            oldType: "nvarchar(50)",
            oldMaxLength: 50,
            oldDefaultValue: "05/12/2024 16:37:51");

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b3298b07-a268-4ed7-8650-e5d151c9977c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2052) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("31d933b4-d303-42d9-921a-73bd0f28fa67"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2059), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2060) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("347fb103-2998-4a79-8eb0-6df9d5de0c80"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2081) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("99c501d7-1e10-437c-a11a-fd52ef458159"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2084), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2084) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("73ac5219-ba34-4b78-a85f-dc89f55a073d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2086), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2086) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6412f531-34cf-4202-926b-4a95e2bd7f24"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2091), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2092) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("60d302c3-92a1-47a3-8ce3-c8f0e5568d6c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2097) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fc0ffb5e-f2ac-466b-b3c1-e181df4e65c4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2099), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2099) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e5c011eb-15c0-4b8a-8421-866d9230c710"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2101), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2102) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("62682e99-eb8c-4b5a-a3c7-cb1aa0b56802"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2105), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2105) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("14400be5-693b-4ba1-9a3b-a9a2dc979d31"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2110), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2110) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bcaa58f1-df36-43fa-8adb-b7dc645ce1a9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2112), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2112) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9dd83f53-9e80-4e2f-b3b4-205e266f33e3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2115), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2115) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("62cf9345-6295-425f-b1e0-12d4c21dd3e1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2118), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2118) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a3a31702-0995-43c4-b890-b7f142484277"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2131), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2131) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d1fd37b8-44dd-4695-a6ab-22930a88baa7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2139), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2139) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("55e35651-9c10-4b0d-ba8e-59cad3564573"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2141), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2141) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3eea8526-bda2-41e3-88da-30d379179536"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2145), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2145) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("15029cdf-47ed-4341-87e6-fba6480155c1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2150), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2150) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e1b7eaae-1f21-4188-965e-e9d385f17ef1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2152), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2152) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d5c018b3-10b1-4ef6-bf2b-4267b28ecb6a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2154), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2155) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("db9dec69-627b-4b50-a428-a5e02f6f80c7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2157), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2157) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b4776570-a6ac-45a5-85bd-271173d878f4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2162), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2162) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9173954c-2e61-42d8-86c4-c4381da9303f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2599), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2600) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("49fe2b43-0a30-4ce5-b571-ae0fe2f5c283"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2608) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5b9b1b35-3b3c-4b8f-9747-94036e4206d0"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2611), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2611) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("47f7a956-20d6-4444-ae23-bad40e24ca3e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3098), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3098) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7220d844-818d-4668-a65e-5a6d1c1fa82b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3107), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3107) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("37531ffa-57de-41ed-82bb-433fec609960"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3113), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3113) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d71eeaf7-cad6-44d4-8ed1-d1f365b246b4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3115), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3115) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d4071dc1-00f9-4766-a511-8002bb0f9cb4"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3118), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3118) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b174a555-cd5c-45ee-a73b-3addfa732d0f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3121), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3121) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1e7c98ae-5688-4384-a372-154e068317c1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3126) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d0873cc0-a19f-4a13-b754-d477c9172c31"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3128) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4cf9717c-7c84-4644-9cd9-3628d009f95a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3131) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4f74982b-42ed-4d11-9739-454afccb3c91"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3134) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2dca5bb3-61b5-41ef-8113-930661c6733e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3139) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("83df39d4-5e88-4e0c-86a1-65b0f552b94a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3141) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2cb96481-280f-4dd1-a90e-4049c2796d1f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3143) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("06ea4b3d-4bcd-4e02-bc2d-b76b629de597"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3146), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3146) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("86cbebde-9663-4cdd-8fae-dc757dac6439"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3151) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6222729b-e13e-4d3b-8adf-47f1461db0ca"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2854), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2855) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("91ed2e5d-a65c-477d-a964-f12c4f29cc93"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2862) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ebebc216-4cc4-4135-a29c-5a4a500aab0a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2864), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2865) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("95ad96fa-1dca-40a2-9e52-67f3faeb5e45"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2867), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2867) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a445c1e8-4863-44b1-8625-1fce97f38a5f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2870), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2870) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9bfc6fdd-8aea-4a4c-b266-1218160896ce"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2876), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2876) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8ac9e511-ca52-42f5-babe-4a4c69077c3e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2879) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e8c52004-4642-4e33-a03a-572d8502deb1"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2881), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2882) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d84ad548-132a-4663-be79-a6770f4ab162"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2884), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2884) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8474db70-073e-4491-8c47-ddfe01c835b6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2890), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2890) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1a213fd2-bf92-4ac8-ba59-813b36be21bf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2893), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2893) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2638bbef-70c4-496c-99a0-18f3fb86f00e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2895), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2896) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4d8ebb45-0d54-46c7-864a-c622fba40902"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2899), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2899) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0755bcf8-285d-41c9-9a77-e42cb482a3f6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2904), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2904) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b85f06ee-9fdc-4f46-b6ad-12904165d1f5"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2907) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fde65f0f-ffd4-4ade-a16e-f288e16eddf3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2909) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e1e06cd7-e851-4d11-adb6-ee7ca6b37c63"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2912), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2912) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("eda2fd18-78fd-462f-b081-ea7ec075c385"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2918), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2918) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("68203fd4-f699-43a8-9517-66333a185bc9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2920) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5d6b00c2-e9b8-4253-8285-805c8878118c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2923), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2923) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("57cbdae6-b9b9-40e6-a857-5a12ad797610"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2925) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5216d239-7e49-4bec-b7fb-10fd21798c12"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2930) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("93cb12f0-fd82-4bc7-8fa4-cff71a42b74c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2933) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("05846865-a4d9-4ffe-ab12-4a52f20fda53"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2987) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("485e54df-2acd-4876-bcc4-80f6989f6b1a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2990) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("faf97024-f3d6-4fc3-b425-994e517f5cee"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2995), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2995) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0c9038c3-98a0-4904-8a63-f23a8c0fd045"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2998), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2998) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8c779978-2bda-4586-bc76-e8d9286acfa3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3000), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3000) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("27fceaae-8b4c-4549-8f15-3fa577e6a192"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3003), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3003) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2771034f-9e76-49ce-bc93-5e2dc6b22b8d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3008), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3008) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f280acf4-181f-430c-8ace-55a6fc1713a8"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3010), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3010) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("87b1758d-3c3d-478a-baf7-4d84d5489812"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2665), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2665) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e63e72bb-06ac-4fa5-b5b5-5a93a82a76b7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2670) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f84163e4-3299-417c-9df4-c71ffb170254"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2676) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e7716080-6346-4e1e-b13d-8184e0699972"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2679) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bb9aa620-433a-4f00-9978-97625810e8eb"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2682), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2682) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("493142f0-106d-4081-8b63-a9ff67ad722a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2686) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("808fad30-ea4d-435e-8315-9017fa29d082"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2691) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("27dd13f9-b079-4dbb-9420-defa530ecd2a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2694) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e58b6e70-e1ce-4265-a5ce-f2443529a472"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2696) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7efc2dab-185b-46d9-b39e-60b7af60b55d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3352), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3352) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f6c0b849-de21-492c-a6ff-4851db7b58fa"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3358), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3359) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f0306a36-3fe0-4e63-a94a-f619cd5c510e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3361), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3361) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3429), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3430) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3452) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3457) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3461), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3461) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3464), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3465) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3471), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3472) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3475) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3481), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3481) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3484), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3484) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3488), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3489) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3491), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3491) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3494), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3494) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3497), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3497) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3500), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3500) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3504), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3504) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3510), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3510) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3513), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3513) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3517), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3518) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3520), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3521) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3523), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3524) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3526), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3527) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3530), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3530) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3533) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3615), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3616) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 85,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3755), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(3756) });

        migrationBuilder.InsertData(
            table: "RFranchiseMedia",
            columns: new[] { "FranchiseId", "MediaId" },
            values: new object[] { 3, 1 });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("93eab10a-2197-4e3a-9c78-bdabb8d424ac"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2352), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2353) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("04516f01-eab8-45b0-9ba1-136fd39cc302"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2357), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2357) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("56ebd286-ecff-4395-af77-255e40580452"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2360) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a2a3ad1e-8b8a-437e-ba97-d5786f57623d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2367), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2367) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("50301ea8-c73b-4af9-b141-4993632a8880"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2369) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5b92b180-996f-4cb5-b8b2-75a839eef4e3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2373) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4ac85276-19c9-45da-bed8-ff29f4b3dd1b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2375), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2375) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b5d4ad54-78e9-4824-96d7-d9ab727ce68c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2380) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9f640b70-4bae-4745-9757-80933e128a59"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2383) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b23da1db-0020-4bef-a1d6-4299afb0c601"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(2386) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7ffe702a-76d9-4284-8c07-064ed097bf2c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4749), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4749) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e8bf6892-41a8-4ed4-a0a5-dea4929f1916"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4754) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("556a0f0b-efa6-47f5-85a8-c30db187ad62"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4756), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4757) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("eb944089-6c1c-4118-932f-12f590dfbe43"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4759) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9c9ac839-1009-487d-b1fb-540cdb16bde3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4764) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7ee3fd5e-c36d-4746-a8aa-3e6abf08fdad"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4768) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("be66656b-984a-4f8f-8f9a-3fd50f685a85"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4770) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("58044fbd-8a7d-446c-87b4-2f3b159275dc"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4773), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4773) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0077aa58-140b-4f3b-98ad-0ffc0f90f0cf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4778) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1a2f09c6-4629-42b3-8668-45f22559631a"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4782) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a50500af-ecc8-412f-a234-76d147941b05"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4784) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9c8ead9a-e2ca-43b8-9b10-3be3ad97a079"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4787), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4787) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5e747004-0d04-4ea4-88f0-8de412cf9ff3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4791), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4792) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("eec40e85-016b-4546-9c2b-46e5bb8d6bb9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4794), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4794) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0dcf8a9f-1604-45b0-89a5-b15b8c3aa3ce"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4797) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("81ae1758-db12-4f2b-8af9-106593bdd910"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4800) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8f1046e5-b42d-4bfb-a3ef-d6b5c1483553"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4853), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4854) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("18300afb-a944-4ac0-8188-77ba71bfc678"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4393) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2856d7f8-6c0f-4f3b-b6b8-43256253c3d3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4398) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("447bd929-be2d-4a82-8548-7137327df96c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4401), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4401) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a37d4196-ea55-4bb5-8627-2f823763c61e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4408), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4408) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9c8c1f53-b910-4a34-b37f-854f20591813"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4410) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d7372b9c-c611-4edb-8a88-476b443ecfad"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4414), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4414) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fde151ed-b365-4f50-a31c-ff136aab4f56"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4416), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4416) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e0dae36a-b3dc-4e4f-a701-6b0097cd4bbf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4421), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4421) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("905e9a60-f8c3-497a-908e-57416e08f0e8"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4423), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4424) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e3fa901d-3be7-469f-a71e-de3e4c2388a9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4427), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4427) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6c32dda5-69fe-4a86-b184-dd144dc54d60"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4430) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5ee80f1e-108b-468e-872d-fa080ee2664f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4434), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4435) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("061b8e60-96e1-487a-b522-21803e5c7524"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4437), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4437) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("98dce441-438a-48d7-97f2-3a195532ccf5"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4439), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4439) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5a024f8a-82ed-46c9-af29-30e08443fb40"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4442), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4443) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ab0a732a-0207-4b36-8c89-04d03cba6704"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4447), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4447) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bad5be4c-4906-4e70-8af1-bde123da7e4d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4450) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c92c55ed-e80c-47c3-9ff9-0882004e523c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4453) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("54b75ab5-0aeb-47e7-b117-d51f7e587853"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4456) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7e15a84f-fdd9-4d9a-8476-af04fbb17c68"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4460), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4460) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("23eed29f-1e78-4784-aa69-26e70874c6d5"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4463) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3a6b4af9-e475-4017-9997-b021e6b08ecf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4465) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3737b8b6-1efa-4f63-aa24-0670dbb3db89"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4468), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4468) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b3db5bbb-2801-495a-aea8-6671e200bb14"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4521), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4521) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bf151d2e-b45e-4bd1-b6f0-9d7eae392fd7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4524) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ab611273-fef3-4cd8-939e-93060f30ce68"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4526), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4527) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bd50549e-8910-40e5-ae06-7974fe0febec"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4529) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8e99f058-9284-4ff4-9fe1-a1514a89e3b6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4533), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4534) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("150cad84-ec06-448d-b7ca-ff1352cc22f7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4536) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("cb0b90d4-212f-49e1-9ea5-42b7a1ef0a54"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4538) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("eb37fffb-50c2-46c8-ac73-5b985f4d8ff6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4541) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 32,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1df9bf34-73eb-4217-95ba-8e4c16e34315"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4546) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 33,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("361328b0-c5e6-4c9f-8739-eefb3f4b86ae"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4548) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 34,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3657f45c-e073-4880-bf42-8d66278fe598"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4552) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 35,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f198a466-045c-48bd-9aa7-403f8dc99358"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4555) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 36,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f8e72661-d557-40dd-92a2-21dea9863314"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4561) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 37,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0cdf139d-0d40-4ed3-8e5d-c53df299f662"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4564) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 38,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9281d33e-8afd-4288-8b55-337066fa502e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4566) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 39,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("846777b5-a852-4e6f-9e1a-4359b11ea4c3"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4569) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 40,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4b5c1b82-81b1-435b-895d-172ad4dc83ad"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4574) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 41,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2df7d35b-353b-4c77-a4a1-bb8f86c96bcb"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4576), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4576) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 42,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("325ecf45-00f7-46d8-9086-e913a7e7fb05"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4578), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4578) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 43,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6bb96e72-e67c-4601-9ece-a5ede8bef8a8"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4581) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 44,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("38baf420-a8a0-41c7-8fe0-25460e453533"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4585), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4586) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 45,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2e932bdc-6bfc-402a-8e76-10b54e1cd423"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4588), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4588) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 46,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8c7bd863-8c93-4151-8647-9b0280546984"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4590), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4590) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 47,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9f4dbc61-3ab0-4568-b2e6-e8bdbce63ba6"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4593), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4593) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 48,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("318ca68f-06bf-49f5-a245-b8360558be9b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4597), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4597) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 49,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7d6c4320-88a9-4b90-b3ec-7a09f478823d"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4600), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4600) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 50,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f4ba3555-3743-4017-a386-db54d7d4de84"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4602), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4602) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 51,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0ff0b0c3-2146-4915-9076-51b2f041ec1f"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4604), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4605) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 52,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8a3e8db7-b4cf-4e87-bbf2-8eefb8045065"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4609), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4609) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 53,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4e41dc96-968a-4b2c-b4c6-6c51b8db8009"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4612) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 54,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("29c626ab-7b03-48a9-90e2-142f945c0deb"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4614), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4614) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("251cd4b2-6575-4bd3-a8b9-7e5503e3693e"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4616), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4617) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 56,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3c56129e-bf19-4fb6-be2c-09f167aa5019"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4621), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4621) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 57,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("53bcd0fe-4748-44a7-bd45-5cddcf899ced"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4623), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4624) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 58,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9c726a2d-3c80-45fc-b82b-126f1a065ea7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4627), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4627) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 59,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7d14c5e3-3a12-4d1e-b9b2-eebfe0311d24"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4629), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4630) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("72a5f069-aa42-4b7c-a4d6-bf9ccd52bbb7"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4936), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4936) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bb999f8b-1ae1-4e58-9801-272f9af9115b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4940), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4940) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("907fed9f-03b3-4a73-9e8e-2e51eb6b1fdc"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4942), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4943) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("29d7927c-2d1e-4fe9-950b-f362ccfa27cf"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4948), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4949) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6381b03f-ba04-4772-bdfd-5c2e69efdff9"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4951), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(4951) });

        migrationBuilder.UpdateData(
            table: "Tasks",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7fe9aa93-c52a-498b-9859-01908ff281ea"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5013), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5014) });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("c1990336-88a4-4d57-a5d2-b9232afaac2c"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5622), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5622), new byte[] { 165, 54, 209, 30, 39, 34, 16, 114, 181, 216, 155, 191, 214, 227, 188, 63, 175, 201, 64, 60, 128, 2, 245, 6, 230, 201, 251, 191, 67, 144, 170, 117, 146, 165, 104, 76, 47, 95, 253, 228, 93, 130, 242, 48, 33, 149, 126, 183, 154, 10, 20, 76, 71, 94, 219, 229, 5, 87, 140, 202, 26, 235, 134, 194 }, new byte[] { 201, 49, 78, 88, 161, 80, 15, 1, 254, 101, 131, 28, 89, 115, 111, 56, 6, 248, 149, 234, 251, 126, 18, 168, 132, 59, 210, 0, 140, 79, 119, 245, 201, 19, 86, 206, 24, 81, 130, 192, 149, 118, 5, 61, 147, 129, 216, 207, 229, 8, 180, 222, 8, 161, 200, 138, 139, 110, 21, 68, 248, 127, 238, 200, 185, 215, 4, 21, 226, 9, 35, 225, 52, 219, 228, 50, 34, 208, 185, 254, 73, 56, 2, 76, 39, 132, 119, 6, 117, 28, 214, 16, 20, 103, 107, 36, 234, 173, 69, 184, 35, 135, 239, 56, 213, 48, 117, 142, 122, 9, 72, 131, 231, 79, 246, 108, 18, 69, 162, 121, 31, 25, 142, 117, 101, 136, 111, 70 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("e080ba9b-d77b-4b09-bc1f-7631b484032b"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5748), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5749), new byte[] { 168, 19, 199, 167, 235, 39, 22, 129, 221, 2, 211, 145, 33, 86, 252, 215, 83, 12, 179, 185, 12, 117, 119, 93, 211, 184, 203, 195, 89, 254, 165, 72, 54, 95, 174, 1, 226, 114, 193, 148, 120, 147, 208, 186, 87, 204, 141, 146, 229, 255, 233, 107, 69, 255, 61, 80, 198, 17, 75, 63, 58, 125, 81, 135 }, new byte[] { 217, 155, 228, 154, 119, 40, 25, 54, 143, 157, 208, 162, 196, 12, 226, 161, 29, 35, 65, 77, 112, 188, 245, 218, 141, 11, 123, 219, 73, 190, 70, 194, 109, 51, 246, 141, 34, 193, 91, 35, 3, 90, 36, 227, 217, 100, 5, 212, 140, 227, 183, 140, 126, 246, 172, 252, 209, 149, 145, 31, 44, 169, 227, 245, 67, 218, 227, 13, 185, 253, 80, 115, 118, 144, 141, 8, 19, 147, 110, 222, 78, 40, 137, 1, 114, 229, 184, 57, 218, 226, 174, 208, 204, 151, 210, 188, 147, 168, 105, 44, 47, 101, 221, 47, 219, 121, 253, 137, 15, 251, 65, 67, 180, 154, 206, 170, 150, 146, 212, 107, 29, 69, 168, 137, 254, 196, 96, 212 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("30b7db03-6426-4940-8d1d-f0c6a4eefa01"), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 5, 12, 15, 11, 42, 177, DateTimeKind.Utc).AddTicks(5836), new byte[] { 151, 130, 254, 155, 82, 66, 24, 212, 61, 73, 22, 114, 113, 162, 142, 24, 26, 121, 240, 84, 204, 118, 182, 251, 212, 57, 231, 241, 151, 16, 220, 14, 201, 173, 37, 42, 198, 11, 140, 132, 7, 107, 173, 60, 44, 240, 27, 44, 35, 131, 123, 166, 253, 228, 103, 58, 253, 87, 120, 90, 205, 8, 102, 13 }, new byte[] { 13, 28, 39, 107, 42, 33, 159, 174, 87, 60, 74, 242, 164, 30, 50, 25, 143, 223, 193, 77, 212, 70, 2, 9, 151, 54, 217, 220, 183, 185, 8, 255, 160, 61, 133, 72, 139, 70, 149, 198, 40, 217, 126, 11, 97, 247, 245, 105, 180, 26, 168, 196, 250, 32, 171, 241, 98, 170, 167, 222, 186, 51, 151, 154, 125, 148, 43, 245, 94, 181, 1, 227, 235, 103, 88, 251, 230, 56, 237, 182, 29, 170, 254, 174, 182, 63, 168, 67, 124, 156, 129, 133, 95, 136, 43, 138, 103, 88, 65, 78, 152, 228, 90, 219, 57, 121, 130, 95, 238, 61, 106, 130, 136, 216, 6, 172, 8, 73, 64, 174, 238, 86, 96, 94, 60, 244, 130, 221 } });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "RFranchiseMedia",
            keyColumns: new[] { "FranchiseId", "MediaId" },
            keyValues: new object[] { 3, 1 });

        migrationBuilder.AlterColumn<string>(
            name: "Name",
            table: "Tasks",
            type: "nvarchar(50)",
            maxLength: 50,
            nullable: false,
            defaultValue: "05/12/2024 16:37:51",
            oldClrType: typeof(string),
            oldType: "nvarchar(50)",
            oldMaxLength: 50,
            oldDefaultValue: "05/12/2024 17:11:42");

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3c134d48-6d32-4c33-91df-44ef392a0337"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3217) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b728aca5-0d6b-45db-9cfd-395d1bb313f5"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3242) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("28682d89-384b-4bb2-a96a-e4f3d918ad8f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3245) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("90e49b2e-bf0f-4e0c-8a5b-d2c2304a5390"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3247) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9c1be931-fc51-4814-bc84-ce43efdad34c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3250) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("44fe90d5-988b-4b1c-97b3-c6f0912af24a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3257) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fb8134fe-650a-4268-899d-3b8740bf0fdb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3263) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5e16acfe-03ab-433e-8573-a37e1bef6326"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3265), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3265) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bcce6d44-1b3c-4b3d-afd3-3f7db44c9cfd"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3267), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3268) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("08494fee-25e5-44b2-8cbe-875eba392391"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3273), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3273) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0e3bb0d6-5370-4bcb-92de-68af4123529d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3276), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3276) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1aec38ff-e08a-4309-80fa-f3f1da98b6b8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3278) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1074e387-e915-4fa3-bcfd-fb65003ed69b"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3280) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("505f3247-026f-44a0-9a06-624ca140efdd"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3285), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3285) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f34f8db7-8683-4df0-8e7c-0cdabe5b312c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3287), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(3287) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3fbc55cd-638f-40eb-86ea-75216002a704"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4485), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4488) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1375d0bf-566c-43c6-8af9-53afa0e18c45"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4492) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("08f918b9-e200-4843-89e6-3cb577b8343a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4512) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("acb2cfe9-750d-45b0-b33f-a07a8d9d88db"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4514) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("92059cd6-88a8-4156-871b-5076d576e226"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4517) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("02394fda-a6c4-4187-b585-203e405d7b5d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4519), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4519) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("60186d1e-86c9-4999-a249-1735d3a5bb7a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4525) });

        migrationBuilder.UpdateData(
            table: "Artists",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("59e9ccb9-a917-4d4d-8330-bcf427b95a53"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4527) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fd4d52d6-cff2-421a-aca5-963cc605c72e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4994), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4994) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d5f25265-13e8-4a34-850c-099170ac9766"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4998), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4999) });

        migrationBuilder.UpdateData(
            table: "Franchises",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("651fda19-8d39-4b45-b915-a1ad0cf1b326"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5002), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5002) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("dc074700-9d7e-463f-8ff7-7ff06d866702"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5618), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5619) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("28fcd7b5-bbda-4fa5-9552-2a68683e33fd"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5625), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5626) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("748d5abd-0a03-49ed-bb39-be4108e33a71"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5628) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d315cd59-c663-4f1f-bdc7-fefd7287b4a3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5631), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5631) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fc701a06-8da3-4621-8abf-5b279755778a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5634) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a83a45e8-b510-44ea-845e-ee8adbc48474"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5677) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0f6eded7-6342-463d-9ca7-c59028a612ee"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5680) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("21615a21-6d0f-475d-a81b-48c6565335e1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5682), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5682) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1eb25c7e-d639-4f9e-98e3-7db056af1d9a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5685), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5685) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("dd79dd97-9756-4199-9b26-f6200164c05d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5691) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b7fe1245-ab91-4250-80b9-adc4c277ac7f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5693) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("adff573c-0f2a-4e98-9bd3-eb99e8151316"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5695), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5696) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("17d7bf8e-07a5-4153-8e35-e6c244b939d9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5698), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5698) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("25511e47-4d9b-45a2-9237-a2f67d37c7a6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5703) });

        migrationBuilder.UpdateData(
            table: "LinkCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6947d238-e28b-4b07-abe3-0a831411b8fe"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5705) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("17e398f1-aae3-47ac-99ed-4016ff163c51"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5445) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("83220ce9-90f0-4b18-8518-39be1613988b"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5450) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("eefb67d8-b3d3-4162-9cca-1564152df74e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5452), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5452) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("59657d14-c3e3-4a6b-876e-774e49f03173"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5455), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5456) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a746ee80-df2c-4e3c-8132-0be59c9e1197"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5460), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5461) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3bfc0335-9839-423d-9141-16fe1be6f046"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5464), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5464) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("eca46b8c-7a92-47ad-a914-f2fcf1ce37bf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5466), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5467) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1d6aa85f-6dc6-47ab-99cf-a241b822fff1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5469), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5469) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("aeb4bd51-79b1-461e-b519-9aac2e6f1b71"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5473), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5474) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1b9fef63-3919-4981-9d3e-c39539c12776"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5477) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("063e5a31-461f-4675-90d3-235cfccc1fc9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5479) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c44ed68e-3150-476d-a9c7-23b9b8461d88"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5482) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3420fc45-f13c-4365-a6ac-d346ce466dba"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5486) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("79b26276-2c3d-439d-9de6-b3970d805268"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5489) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f244825e-cbf1-46cd-af70-b241e8aa96eb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5492), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5492) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9cac8cd6-1ce3-4bbb-83e4-c4b0400f4370"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5494) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9ee09047-1030-4caa-bb9d-62beab147406"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5499) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("87d69469-41cf-4ec0-88ce-49b6c5812ff5"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5502) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9c10f280-7f1b-45f1-b41e-a652ecb1d448"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5505) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("225ba0aa-0e05-4883-8f78-378dd0967ada"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5507) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0e67c04b-22a2-4b52-92ff-66423e8d6eae"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5512), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5512) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bce2192f-c979-418f-936b-3861e79ae659"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5514) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0e4d15c0-0a52-4e4f-a09c-48c2d29c9d09"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5517) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e846d855-9292-4a8a-967f-c0ee6eb35af0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5519), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5519) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("de098873-6e6a-46b9-ae3a-4e9c6916cc81"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5525) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("96b6c838-3647-45a4-870f-1073695789a4"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5528) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("4b7011a6-ca99-4b67-8b79-84f881c739c1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5530) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b15ee5bf-e684-4d88-8684-54df4c39f445"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5533) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2579b4cf-3398-418e-8b82-028c89c54d18"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5537) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("96a7ad3a-ecd6-4013-8de2-630d8ebab0d0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5540) });

        migrationBuilder.UpdateData(
            table: "Links",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3f78b948-1645-49c8-b43a-c5c75db067b1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5542), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5542) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("35b58243-1b97-440c-ad47-896bdb87e54a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5067), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5068) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bb0ada47-6c56-4272-9df3-9792a593f41c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5222), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5223) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9e714daf-d6c7-4007-ad45-f788e603fb9f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5226) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("06b144fe-acf4-4a26-ad7a-5df50796fb2d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5229) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1e8a31d3-08a2-4caf-892d-a1ccdd66a6ed"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5231), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5231) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("19ac183c-75d4-40e9-86b3-63122113deea"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5239), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5239) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0604b565-c6ab-47dd-b824-3c058bd5fece"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5241), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5241) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5547be6f-d9ff-4c00-bd96-862b99ca97a4"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5244) });

        migrationBuilder.UpdateData(
            table: "Medias",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fdaad182-61dd-49ba-a410-017044dba588"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5246), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5246) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("769facf7-2226-48d2-b634-9acf3c706936"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5874), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5874) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6bc043bf-3dda-4ee8-a28b-131666addb6f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5880) });

        migrationBuilder.UpdateData(
            table: "Models",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("deb7d4b3-b33f-48d2-8e0f-bb668dad44f1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5886) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5939) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5958), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5958) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5963), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5963) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5967), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5967) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5971) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5976) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(5982) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6115), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6116) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6120), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6121) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6126) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6130), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6130) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6134) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6137), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6137) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6140), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6140) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6147), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6147) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6150), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6150) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6152), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6153) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6156) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6159), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6159) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6162), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6162) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6165), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6165) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6170), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6170) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6175), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6176) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6266), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6266) });

        migrationBuilder.UpdateData(
            table: "Moods",
            keyColumn: "EntityId",
            keyValue: 85,
            columns: new[] { "Created", "Modified" },
            values: new object[] { new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6327) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b9bb4a48-999a-4046-9c03-901c5c8394ee"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4793) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f9651d64-f663-4821-b036-95ebb96e9b70"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4798) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9a96d03c-930c-476f-b068-cc76db20b0b6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4806), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4806) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a1289ff2-487b-4586-9ac0-1913d65b2cfb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4809) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("72021ff2-4d5e-4b61-84a3-07557b844668"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4811), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4811) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("760bc876-2d5b-4e9a-9d2c-7102b0e4c5a7"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4814) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3a52c1bf-bc9b-447a-8a41-36dbb7f4d5c2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4819) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f24ad3f8-e949-4361-a41f-dd0876f29b92"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4822), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4822) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("dc39b8de-a1ee-49a8-b452-a5c1417289e3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4824), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4824) });

        migrationBuilder.UpdateData(
            table: "Styles",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c1475339-1fc9-4791-b82d-0838e0ea806e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(4828) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("aa07273e-b4fe-412e-b197-5e835831f8a0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7187) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5ae0b3ae-8c7f-4646-971e-e132a8112008"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7192) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9db080a8-3613-4ed2-ae24-951b64f376af"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7194) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0dbb4109-2e68-4fe9-9869-b2437f4fd3ee"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7197) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("00b2e272-6738-4af6-a4b5-601abf765c45"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7202), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7203) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5623ea2e-9252-4211-8ce8-846bc6a89122"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7205), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7205) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("45e4d9e2-efce-4992-ae4e-893b86e7f5cf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7208), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7208) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0ddece79-2637-41ce-9395-f5d1052cdddf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7210) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5f5021a1-5e0b-49ae-a5ac-c83557c49d4a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7215) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e3f074a8-9a0c-402b-85d5-662d81c7e1f1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7218) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a7d7b689-fe80-4a34-857d-81a95ac82740"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7220), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7220) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("adf64187-eabd-4edc-ae35-3cd1133bbe42"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7224) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("ea27cbd4-1a2e-4a50-9f9d-474a76163f03"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7228), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7229) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("89af7c08-323f-4c3c-9836-1a065c83c8c1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7231), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7231) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("de78ea7a-fdd6-4152-b265-3851c97ad499"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7233), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7234) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1390ce4a-405d-4c1c-b835-5db66bd96bb6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7236) });

        migrationBuilder.UpdateData(
            table: "TagCategories",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("03010dc8-bb27-4dbd-8f13-2cfdffe100df"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7241), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7241) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("10b32608-fb67-4094-9fe6-125957e5bb43"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6851), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6851) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("68c79998-3332-45b6-ba2d-9eb9c0a2168a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6857) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("3dc567db-a108-40c9-8c36-1d49b855f756"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6859), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6859) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("06dc2345-a591-4dbd-8b3b-1084820f471d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6866), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6866) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5bb58d96-7420-4ad0-a6e6-ccd9c7978b55"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6868), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6869) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 6,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("57a5f47f-7752-48ac-b84b-d8450cb574ec"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6872), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6873) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 7,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e1657dab-0d1e-4da5-bc25-fbca44dd84da"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6875), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6875) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 8,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("29434c51-2529-4f7a-b0f6-a9b34448eeae"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6880), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6880) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 9,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c5e3e443-7034-4052-99af-61eabbbe7824"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6882) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 10,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f446ce70-e85d-41d7-b424-c7c310444bdc"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6886) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 11,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("cf4decfe-66a4-4407-9ebe-c2541a84513c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6888), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6888) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 12,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("24b54c67-00d8-47eb-8248-c2a7ab80d932"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6893) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 13,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("faaed21c-8ea1-45a6-95ee-4f2b83a59c7f"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6895) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 14,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("582f3992-d6fd-4da5-aa17-041c7e65e6b8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6898) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 15,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bd056bbf-6150-43de-a282-ef7f3c64c49e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6900), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6900) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 16,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6fd8bee3-ec2e-4bfc-88cd-394b3572d42a"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6904), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6905) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 17,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a3b9ab00-452e-4d5e-b5a0-61d7545d7996"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6907), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6907) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 18,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0234938e-3a3e-42bf-b4c7-7ed93de2aec0"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6910), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6910) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 19,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1d6c83fd-8e2f-491c-b0d8-e06032088101"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6912), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6912) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 20,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bf79e660-bd49-48de-a6ac-771febe04d4b"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6917) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 21,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("7034da2a-2318-4677-bdef-23b392ebaba8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6919), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6920) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 22,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("858d7135-43f3-4c19-a4fc-9969951d931d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6922), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6922) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 23,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("24b89c45-9fba-4e1c-a3ec-44d1fe07f838"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6925) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 24,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0d4a698a-4f25-4302-a619-9e9eb86870e7"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6929) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 25,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6e71db85-ce61-4ec3-8c8d-ff9ed824d73e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6932) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 26,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("35699fd9-0804-4c2f-946f-e6196239d2c6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6934) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 27,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c0852fa2-80c6-4740-92fe-81d0a286d9ce"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6936) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 28,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("90247128-0904-4267-93b3-f713e75c2569"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6942), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6942) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 29,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2e145216-c24f-492a-9c93-9d330f46ec66"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6944), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6944) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 30,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("bd395746-7653-43cf-a8df-4bb2050570fa"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6947) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 31,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8a028ffc-1cc0-4690-b24b-0fc06d72e26e"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6949) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 32,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("58a94df2-b848-4303-80c5-4b026b73bee6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6953), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6954) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 33,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("cc0aa1ac-a86f-42e1-b4ae-fdfeb2378b98"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6956) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 34,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e5b6062e-bca5-4c73-a072-9aecfbb909d8"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6959), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6959) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 35,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0df21fcf-6a93-42ce-b099-c9a0dbf2a624"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6962) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 36,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("f3bdbe6e-5734-46b0-8189-9b756d3e4d4d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6966) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 37,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fdb63666-b78a-4f88-9cd4-a6f827cb87ba"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6969) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 38,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("0a4c1b03-6cc3-4805-b587-b88dc4620570"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6971) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 39,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("767effd8-8691-4745-9874-b59df8903722"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(6973) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 40,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d1d5bf84-3e8e-412d-8ffd-bbd1ed6e6903"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7025) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 41,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("823c96c4-0ef6-42df-aba0-4dfe180c0648"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7027) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 42,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("c36ccbc5-7a4c-407e-8c8d-35c4872df504"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7030) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 43,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("6827e155-4ed1-4054-94e8-3b20ebd8b6d3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7032), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7032) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 44,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("12667938-2be1-4044-9347-76d663fccf3d"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7037) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 45,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("049c35f0-87ce-428a-8515-7fd78fbf2210"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7040) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 46,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("142d77bf-162a-41c2-9219-0b9fec0a03d2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7042) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 47,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("679b7949-fe10-4f39-80b6-9d16e3ed7ca2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7044), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7045) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 48,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("287d3ad7-a9a6-4e3e-9b90-6596dffb2deb"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7050) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 49,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("fcf8c0a2-3821-4efb-95af-5ae818bf2868"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7053), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7053) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 50,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("770e91d4-659e-4c8c-baf0-f6eccd3b9130"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7056) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 51,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("531c756a-57c6-4ec4-8251-63db6fc1f055"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7058), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7058) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 52,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a0565146-ab1e-4a8e-a8f3-b2481cf667f2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7063) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 53,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("b28eabb5-d0b2-498a-989c-a03bae3dc83c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7065) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 54,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("5a0cffe6-7182-4a08-ac02-3874c237e1a9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7067), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7067) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 55,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("e23c56b8-2228-4209-8c39-0b277b298db2"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7070) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 56,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("8a8e5e23-a28d-4ddf-af8e-6771b66496e9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7075) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 57,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("be7f57cf-094f-4962-b9a6-da1b01e3c474"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7077), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7077) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 58,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9f73855f-3a01-4a7e-87c2-7935874b92f9"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7079) });

        migrationBuilder.UpdateData(
            table: "Tags",
            keyColumn: "EntityId",
            keyValue: 59,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d4142d4c-664a-4e56-82e0-74aea238f3df"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7082), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7082) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("2d33dbb0-5506-4c11-a95f-7bc94f10bbd6"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7314), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7315) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("a79ada2d-9e70-4888-bb43-8deea350fae3"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7319), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7319) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("9528f253-3e54-44ee-9927-49356f63ec2c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7322) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 4,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("1324480e-a4df-4f2b-8b09-8ccb4786c893"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7327) });

        migrationBuilder.UpdateData(
            table: "TaskCategories",
            keyColumn: "EntityId",
            keyValue: 5,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("50973ad8-29d5-4c43-b8bb-60d522132bbf"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7330) });

        migrationBuilder.UpdateData(
            table: "Tasks",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified" },
            values: new object[] { new Guid("d3cb03a7-49c8-4234-9451-238d76727607"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7441), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(7441) });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 1,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("914afd05-7c52-4835-9cc6-2982659ed8d1"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8037), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8038), new byte[] { 226, 64, 126, 14, 171, 205, 55, 55, 148, 245, 19, 201, 117, 73, 223, 52, 137, 24, 197, 52, 110, 2, 233, 25, 136, 202, 70, 171, 103, 223, 164, 118, 17, 102, 24, 74, 119, 154, 247, 34, 149, 200, 31, 4, 117, 186, 135, 29, 173, 140, 125, 126, 101, 22, 229, 32, 188, 70, 190, 146, 197, 141, 130, 12 }, new byte[] { 38, 173, 190, 86, 75, 221, 163, 110, 201, 118, 221, 65, 67, 74, 247, 161, 12, 26, 138, 163, 89, 228, 108, 249, 140, 6, 210, 232, 207, 226, 49, 41, 57, 214, 39, 69, 42, 208, 13, 192, 52, 11, 37, 97, 167, 185, 232, 144, 100, 80, 40, 207, 122, 103, 136, 214, 109, 180, 171, 55, 48, 77, 111, 7, 190, 147, 231, 158, 99, 165, 57, 113, 154, 94, 57, 63, 214, 172, 123, 25, 111, 231, 146, 153, 107, 146, 55, 41, 49, 119, 36, 159, 143, 66, 198, 4, 234, 70, 243, 232, 114, 60, 4, 11, 56, 6, 26, 129, 64, 139, 32, 210, 223, 196, 36, 157, 156, 95, 133, 98, 190, 159, 207, 16, 143, 208, 44, 203 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 2,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("3bf233fb-7136-4991-a220-01874f060c1c"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8147), new byte[] { 99, 203, 141, 13, 208, 111, 73, 109, 168, 91, 123, 191, 88, 174, 42, 106, 89, 19, 16, 160, 97, 68, 108, 225, 43, 74, 45, 173, 4, 86, 185, 179, 185, 21, 13, 129, 1, 77, 45, 108, 67, 54, 146, 133, 121, 242, 156, 252, 132, 178, 136, 83, 147, 110, 128, 244, 51, 59, 247, 250, 26, 74, 19, 1 }, new byte[] { 70, 221, 110, 76, 246, 60, 32, 50, 212, 132, 163, 98, 12, 228, 7, 23, 147, 61, 197, 197, 79, 6, 216, 216, 209, 151, 211, 154, 169, 221, 3, 149, 44, 225, 31, 122, 87, 85, 67, 234, 71, 41, 128, 22, 230, 219, 187, 168, 117, 54, 39, 144, 213, 96, 143, 231, 227, 58, 233, 181, 249, 252, 122, 119, 106, 34, 141, 208, 111, 198, 100, 112, 131, 36, 34, 90, 68, 11, 198, 175, 83, 79, 121, 108, 77, 236, 241, 3, 94, 79, 179, 228, 86, 214, 189, 102, 133, 215, 148, 229, 192, 72, 48, 102, 229, 198, 155, 25, 60, 126, 137, 178, 49, 37, 50, 159, 104, 12, 50, 193, 62, 79, 119, 23, 17, 6, 228, 156 } });

        migrationBuilder.UpdateData(
            table: "Users",
            keyColumn: "EntityId",
            keyValue: 3,
            columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
            values: new object[] { new Guid("6b4d0d01-3545-4f4f-b2e0-922c43318a83"), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 5, 12, 14, 37, 51, 291, DateTimeKind.Utc).AddTicks(8242), new byte[] { 70, 51, 153, 190, 125, 196, 221, 103, 185, 210, 46, 102, 156, 168, 46, 150, 172, 89, 244, 245, 107, 71, 64, 119, 224, 176, 142, 214, 230, 94, 50, 82, 91, 205, 223, 182, 232, 69, 201, 24, 226, 211, 20, 235, 38, 87, 212, 20, 183, 8, 49, 23, 92, 81, 53, 216, 158, 73, 180, 237, 191, 173, 249, 75 }, new byte[] { 136, 68, 34, 141, 53, 25, 254, 241, 101, 210, 8, 190, 143, 130, 8, 41, 227, 69, 58, 240, 67, 173, 113, 20, 60, 100, 80, 67, 121, 83, 213, 192, 174, 234, 163, 250, 208, 66, 74, 141, 107, 190, 237, 197, 191, 160, 127, 143, 24, 254, 105, 120, 230, 221, 236, 143, 114, 205, 116, 121, 214, 107, 118, 70, 85, 163, 182, 230, 7, 129, 129, 171, 32, 179, 22, 137, 61, 158, 2, 28, 48, 10, 240, 51, 228, 242, 247, 147, 95, 115, 7, 135, 125, 113, 109, 155, 229, 203, 202, 15, 67, 100, 86, 200, 203, 6, 6, 162, 235, 25, 130, 178, 136, 70, 158, 40, 60, 126, 230, 245, 78, 87, 20, 26, 191, 84, 121, 169 } });
    }
}
