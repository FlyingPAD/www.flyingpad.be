using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Ninth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_TagCategories_TagCategoryId",
                table: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_TagCategoryId",
                table: "Tags",
                newName: "IX_Tag_TagCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "09/13/2024 17:11:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "06/11/2024 14:37:44");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "VARCHAR(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tags",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53f62977-3455-409a-bab9-aed32ab9443a"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1654), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9088306d-6efd-4c23-846f-a18be0d103d8"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95184c3c-a73c-4598-af99-d14aa81fde9d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1666), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("467d6adb-1425-4ed1-aacf-763160427388"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1680), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7a9e7ccd-e073-40c4-99f5-99c00b709989"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("30b75b36-101e-4629-b029-6dc1b4758fc3"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1685), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9804634-97f7-4e4b-81fc-86de56798902"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1687), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e72dd1a0-0a8c-4301-820d-b1f40100dbb0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7c4e6ce8-a170-4e8d-8440-440d07d0eaac"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c5eea9ad-7116-48cb-b00b-bb2bd2b5b580"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1696), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93f75552-010e-4b0c-a5d5-ba2a6102694c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1697), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("54feba59-b6dd-49b3-8bde-75eda8be3349"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1701), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1402cdce-d789-4759-a16d-828adf5cd95b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0129e338-e9a4-4fab-81a2-0555268b6fac"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1705), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20df5854-6a97-4614-a747-b090cd6a12cc"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5ea740e3-d0c4-4200-a6f9-d9b447baca03"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("25e3e4f9-1733-480c-bd7a-e3acfbc68381"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1712), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("79042181-f236-48d9-83fe-de656a7bfab9"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1714), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94f738f5-f0fd-4f64-8f5f-92ed1c2f5a52"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d11c6073-60e7-424e-a3a2-4585f201d929"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1720), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03307d6d-3a8e-4f11-912c-78f18ef200ca"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1721), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99c6ee83-b137-4ae8-b4bb-ff3c38ad2053"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1723), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("00e7c1aa-28ea-4b2d-ba56-31c184055566"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7acbb15f-c9b4-4605-86f5-9eda17ab50bd"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1969), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e6ada32b-420d-41fa-8c73-cf59e96e97f6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1975), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("af6c1f1f-489c-4ada-a146-64edd466ba39"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1979), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a422669-f4e1-47ff-9cd6-06863b2bfbb6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2262), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f1af5d6c-41d2-48b2-98a8-8750c7c89603"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2266), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e987a1d-8a21-47ac-a5ab-12478f5760dd"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2269), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76f0f367-9a26-4cd0-9f43-33624b8b7998"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2272), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("becee09d-1daf-4dd8-a489-ae4cecdf3158"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2274), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5129ea1f-7dc4-4996-9e9b-a359baa1e367"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9fad52e4-139e-45c9-a5b7-5cf97a26ff96"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bea31d94-2a01-4f47-82f0-be81a1349ff1"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2be999e7-a0a9-4018-8add-a78e2b7ddf18"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f4d1a84-fbff-4215-9d8b-8b30d6d0fc85"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2286), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("becb9a90-1894-437a-aa1b-f75924a575f1"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2288), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fb3110a-107e-4b6f-8742-ee68ac564cfa"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dd33f9d9-535b-4764-bdf9-655cee5af242"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2294), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17d8106c-fbc4-4c80-959d-82d25723c3c6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2296), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c30851c-9638-4763-a6c7-b2c6ea6e69c9"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2297), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43fe22b5-3e34-4c5b-ae92-21aa440ab8de"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2113), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("510a12a8-2037-4f5b-a37e-f9053f09c5b3"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2117), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8595f370-94b8-489f-82e8-23c25f8773eb"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2121), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6c42aac0-bce3-497f-9de5-4993c7663252"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2123), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7ab0e251-b0e6-4b9e-a58a-82792fd62db0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2125), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5cee8d50-5f41-43dd-82e6-22328f01b994"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2128), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("17f164b5-e9ef-45e1-973f-fd941877b109"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2131), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ccc2de21-a7c8-4779-b638-c0d2f381c420"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2133), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d936d2a-abfe-4d63-8a3c-b88b9e13d733"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2135), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("021043bf-37c5-4049-8303-96d1bf5a9f01"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2138), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e6902b46-593a-4422-a232-23da75577456"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2141), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("624fbe3b-5e66-4155-9701-29f7be70fd63"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2143), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("22e7b57c-b507-4aa8-a71f-547454e902dd"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2145), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a6a9ee8a-69be-44c0-9234-48150dc91779"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2147), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("69c03122-bb61-48f7-b6af-7d6140097a44"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2181), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("257716e0-245a-4d15-b2eb-ea017b64377e"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2183), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("572da28e-211f-498f-bbb0-b271f4c79863"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2185), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3ec25e11-ee9b-449c-9123-ed24624b630a"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2188), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fbae02c2-7a48-4e7b-abe7-8c6bfe5ab5b5"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2191), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("291bbe77-0a98-43c0-be93-fac2ec5c3837"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2193), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("14b225f4-a2c5-4d0b-907d-48c86aafff1d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2195), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e247b038-ada2-47ba-848b-2a676c50b912"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2197), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e1242fe-2702-46d0-b69e-55708f396be0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2201), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("274d5623-6ad4-4fe5-89fb-3ac9a80dcf83"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d9d754b4-eb2f-4803-b47e-98a87c7ec5f5"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2205), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2c59f17-75e9-4791-8130-616cb1dc17f9"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d660d870-a14e-4853-b356-373c5d487071"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b80c4825-f619-4b90-b654-6cc03a847119"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2212), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("808054b4-a4de-450b-9632-05800213dc99"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2214), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3df261b3-743a-47a5-9c00-7b79683aa54e"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2216), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("db92d33f-2100-4589-bfad-3dbc736a8d67"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cfb11971-176c-4903-863e-d7965af0e5f4"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2006), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99be8eba-5347-4548-b8b9-428b841a674b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f9617260-118e-41de-84f4-cbd53f345960"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2012), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fe330e63-f1fd-458b-90ac-e1dcdbd27ed3"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2015), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18079ed6-b638-4f42-ad07-12e6f1bc536d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2017), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dfd4d6dc-cdfb-4aba-a748-9acc6a37b014"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c0acc85-50b3-4756-8a9c-8ebfd0e56aa7"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d6a125ea-c880-4219-a3ba-4c35c3085745"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2025), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fda6c7e7-f28e-4e26-8c50-8c04c8514e7f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2027), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a9bbb142-cc1f-4c18-a1d4-553cc5f10c76"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b4f8104d-ca8c-4899-a942-39c487b8c457"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2433), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a083939-8d25-4666-a65d-b1557ea3ec66"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2435), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2465), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2484), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2493), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2495), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2501), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2506), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2509), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2521), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2523), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2526), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2528), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2531), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2535), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2613), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("345831cf-a781-4487-ad94-c541105bb5eb"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1fed2344-5a01-488d-8103-ba53b94555b6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1841), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6579120f-4a7f-4f35-8e54-1db1eb251149"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5be612cf-fef8-4716-99a3-6accc8770507"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1876), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("df4be2b8-47cb-4be2-b457-91974bfadfe6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("80f3a489-7cbd-4cf4-8691-ee076425a54d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1883), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08a829f5-6a94-4b7a-b723-6638b7c3a999"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1885), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b52cd2f5-136d-4b65-9e03-74eab3c28991"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1887), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e0a8b3b3-f3b4-42ca-bc04-df07654af5d0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1890), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("544c31c1-8e62-4e75-8a72-0849a6314225"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7313ab3d-e714-4f7c-858e-3b57f93dda9c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3966), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8be7e9a7-2f4c-4433-915c-cc66356915ac"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5efb3fe1-8439-4019-818e-91e4529204b9"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63f1e416-3540-467d-a79b-b42818d8c016"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3980), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b44718ff-b126-4c4d-bf9e-8af38735fd07"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3982), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9bb6d642-b8a2-4494-8fe7-e3770069d95f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c2babefe-1c68-4db8-96ea-3b981ed72f74"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4265), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c26b011-6329-4791-b93e-af9417f22d6b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4267), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2659002d-b3ce-49a7-9129-a1ee4b3e8622"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("769c545e-3d0f-4cec-9e08-604ee9f58ba0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ad4943b-4f91-4167-a803-929d52a5130f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("115a3856-2428-4f01-b0c2-97e6c8215090"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("85579e22-8f4e-4384-8663-aaf478b5489d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("669105ce-bb07-4a4f-9052-a1b07e533d01"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4282), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d5d635ce-d70e-4f57-975f-819b009d43d3"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4286), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5f6cdba1-294d-4af0-a359-6a8c6b7f03c8"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4288), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01d557b7-588e-4976-b08f-efcb4ed76a8f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4290), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4946064-d47e-4b18-9f42-6ed116cec55a"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3466), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c8cf948b-c590-4ca6-91f4-9d94ae629004"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3476), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2fe5b87a-047a-41f6-ba12-dc44b36107a9"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3479), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9989232e-a659-4022-ace1-d1b7d26421c7"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3481), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb836165-b0e2-4079-b85b-43ad9b2a9310"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3482), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("efdda2d4-1a14-41bf-8ff8-f0a9ee950ca4"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3487), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b89ebe42-cbdc-487b-bd12-b59f1d0db83d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3489), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11989239-85ce-44d5-a763-7f981f48d409"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3490), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2f62caf2-e274-410e-be09-b0197308f5c6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3492), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("03e633cc-e21c-4e97-adfd-12d5c8622781"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3496), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99d5f279-afa3-4eb6-a3dc-12230aa1b621"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3498), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("29111868-fb28-4cce-86c8-af127784e1ff"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3500), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f7a58e6-68df-4655-8f09-ec54eb00e397"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3502), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de3e77ce-d16f-4a91-944d-f349659abdf0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("20930795-d2a3-4d0c-8db9-050017205c16"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3785), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("080187da-9897-407f-9cf6-ba17b3ff42ef"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3788), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a4f62ac-cf43-4d6a-b937-d0cbf9527585"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70e4158d-a08d-4699-b2e4-702f9bb91a4d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3802), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("240fda89-9600-45b4-8d99-1fccc2082ddb"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("62d32b1f-0d9e-40b4-ba6f-0732a92b8a96"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d6beabcc-7909-47dd-986e-e6bb0a7c882c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e741620-5823-469f-8f79-44820f522a86"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7c40d51e-c46c-42ad-93c5-4729afc0473f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f3a0b64a-d27b-4352-8cce-9f5a0868d207"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("408f4a01-4f79-4b42-a0c2-03a25b1e6124"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f07814df-3717-46fe-83b4-e624695b8314"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3820), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9fc383e8-c1fa-4c32-8b3e-7df6091ac45c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3822), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11281bbf-96aa-4092-bd0e-582e50d942b4"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("adf3bab7-c718-40dd-8822-46306ef5680a"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3825), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e6472ce3-680a-453c-999b-e61c346d0cfa"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3829), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dcb186cc-2fd8-44c7-8fd4-7378a0605c8e"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3830), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("31db1094-e395-4cd5-9e88-766003d5cd96"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3a623696-1269-4cac-8645-a6e361b0f4c2"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3834), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2c7b53da-39cf-44e8-9132-4a149bc4113d"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("237d1e98-8452-416e-9217-6ddd606f503c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bf4c1c35-1020-4773-8c08-3db61ae3b730"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3842), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08449830-3526-404b-93de-12a5c3012c2b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3844), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0916dac0-453e-4dd7-81b4-f84e48d85d6c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3847), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("358f9b4c-b067-45d2-be5d-89a3edb49b5c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3849), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("01bdbb35-dba1-47bc-bb06-10735f86102e"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3851), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("419ff308-13fc-4d03-bd61-5401f251b076"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3853), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("abe64b38-22b8-4142-80b2-e19408eec375"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3856), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35e1b047-3020-460e-9b3c-dec1727d76ce"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3858), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9040f1e4-b465-4a6a-a0e2-b070531c96d7"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3860), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("33d41440-2af7-4ae1-91ca-b51e59b4e13b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3862), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cacc3c4c-b1a7-4857-a743-6e343edfafe6"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3865), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("76642100-8e21-4562-80c0-8bcffff041fa"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3867), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2f384b82-cee0-4b12-af72-0dea229bce82"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3869), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f6ff0a7-470b-4425-9de0-f90b3b9d016e"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3870), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("14996b98-ce85-49a9-8b17-c0b6b1d73c9f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3874), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3bc3aee6-995e-46f3-8ed6-7b662192d421"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3875), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff57910b-0410-43b9-bec5-26fb2594bddb"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3877), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1864effc-a6c6-4e36-b440-60515f128418"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3879), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("78c47913-cb92-488c-adeb-0b22cd06296b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3882), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6a21f50f-d055-498e-8314-01c3941763a7"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3884), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d47b8e3d-7fae-4a91-81f6-4e14987fc52f"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3886), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2016f7a1-b139-4813-beb4-3e74531bca0a"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("35eb4ae3-4395-40c1-b56d-56c0dda81e43"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f482da0b-5162-481c-8d2d-05376b7e3a4e"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5fddb189-2e9e-4489-83bd-d33fd7501b07"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c3587ed9-1490-4ca7-9ce4-9fd5deac8445"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4349), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("804e07dd-1627-49f4-ab39-db069ef585ed"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4351), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3173e70-1a46-42ba-a326-405aae114c29"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4353), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1d51157-38df-4384-9741-4bec46b3bf75"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4355), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("7d550861-6ef9-4194-ac08-be08ad96d430"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4385), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4384), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("4957456e-5540-46a8-a1aa-cccce08d0a98"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4894), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4895), new byte[] { 103, 86, 32, 171, 226, 35, 239, 246, 244, 201, 228, 238, 44, 136, 64, 249, 0, 103, 172, 93, 129, 45, 158, 16, 158, 69, 79, 20, 76, 182, 27, 92, 8, 231, 99, 217, 75, 193, 1, 77, 134, 204, 83, 183, 61, 150, 66, 188, 236, 226, 146, 178, 223, 206, 170, 152, 216, 125, 108, 110, 246, 104, 7, 102 }, new byte[] { 207, 9, 214, 169, 146, 168, 105, 239, 245, 5, 57, 135, 133, 184, 182, 26, 180, 150, 227, 207, 160, 137, 185, 45, 66, 20, 108, 77, 227, 50, 124, 213, 66, 153, 67, 97, 58, 155, 44, 138, 147, 61, 4, 25, 190, 149, 97, 241, 4, 214, 88, 234, 251, 46, 124, 228, 205, 61, 184, 53, 239, 215, 143, 163, 238, 145, 28, 196, 64, 57, 205, 0, 18, 97, 137, 80, 174, 247, 189, 136, 94, 25, 230, 187, 108, 156, 190, 233, 88, 158, 17, 95, 110, 131, 16, 128, 92, 12, 55, 181, 210, 9, 183, 204, 223, 190, 103, 16, 203, 156, 118, 181, 248, 208, 188, 142, 38, 172, 27, 162, 199, 238, 188, 189, 33, 226, 71, 225 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("acd5074f-e109-435b-86e3-82c0c3bf1b0c"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4932), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4932), new byte[] { 193, 70, 73, 157, 41, 138, 53, 128, 219, 130, 189, 116, 40, 117, 68, 229, 156, 130, 207, 35, 226, 66, 142, 142, 133, 35, 193, 48, 230, 245, 129, 103, 93, 255, 88, 30, 57, 182, 131, 126, 227, 252, 111, 24, 169, 22, 85, 63, 219, 205, 182, 127, 70, 34, 178, 11, 59, 15, 244, 137, 35, 104, 63, 60 }, new byte[] { 78, 67, 103, 64, 79, 180, 87, 131, 118, 50, 173, 245, 53, 151, 80, 232, 210, 207, 190, 26, 28, 205, 116, 153, 77, 52, 200, 21, 177, 92, 21, 199, 204, 10, 215, 193, 191, 7, 15, 187, 233, 66, 159, 226, 86, 161, 66, 50, 239, 160, 102, 252, 82, 230, 222, 252, 173, 62, 183, 187, 142, 216, 217, 187, 215, 93, 140, 80, 205, 241, 10, 162, 44, 186, 29, 98, 85, 240, 182, 61, 213, 184, 17, 205, 112, 34, 222, 56, 232, 97, 216, 213, 225, 139, 122, 28, 134, 79, 105, 164, 169, 49, 101, 158, 63, 199, 23, 120, 136, 53, 123, 139, 76, 212, 114, 130, 190, 5, 105, 39, 204, 129, 14, 209, 12, 153, 108, 135 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("48e76674-e194-40a9-b4d0-4458602ab7f0"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4961), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(4961), new byte[] { 140, 21, 149, 153, 92, 59, 48, 251, 144, 216, 147, 183, 166, 200, 21, 136, 45, 101, 135, 7, 117, 124, 147, 87, 239, 108, 234, 51, 237, 151, 161, 54, 47, 62, 145, 56, 133, 97, 121, 74, 3, 254, 50, 210, 113, 230, 210, 253, 98, 235, 18, 254, 67, 19, 39, 164, 247, 66, 15, 73, 236, 246, 29, 27 }, new byte[] { 68, 88, 203, 76, 75, 161, 22, 216, 85, 104, 81, 142, 0, 211, 89, 112, 142, 171, 30, 186, 110, 218, 24, 67, 243, 0, 174, 132, 121, 15, 198, 234, 83, 56, 143, 75, 158, 153, 65, 138, 186, 53, 174, 203, 19, 87, 113, 252, 56, 62, 49, 130, 176, 202, 75, 214, 102, 136, 223, 86, 9, 162, 15, 23, 138, 197, 208, 33, 208, 0, 165, 171, 138, 238, 34, 218, 48, 164, 194, 14, 6, 109, 101, 138, 115, 230, 53, 31, 164, 168, 52, 171, 220, 46, 35, 111, 237, 211, 60, 76, 208, 103, 7, 251, 128, 178, 189, 55, 225, 35, 185, 74, 115, 89, 14, 67, 130, 227, 165, 54, 181, 20, 217, 150, 90, 247, 224, 116 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("098df21c-3435-4d1e-b35f-1ab00773509b"), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(5027), new DateTime(2024, 9, 13, 15, 11, 10, 311, DateTimeKind.Utc).AddTicks(5028), new byte[] { 73, 55, 64, 54, 62, 253, 147, 253, 247, 225, 103, 244, 8, 81, 251, 129, 207, 213, 206, 120, 184, 225, 168, 146, 122, 114, 115, 146, 125, 180, 188, 204, 247, 76, 209, 174, 103, 109, 162, 201, 209, 213, 152, 163, 123, 249, 15, 241, 37, 178, 144, 16, 47, 116, 104, 31, 31, 79, 203, 236, 219, 10, 137, 196 }, new byte[] { 19, 167, 117, 10, 253, 23, 168, 215, 202, 85, 68, 20, 139, 175, 167, 231, 249, 245, 178, 60, 237, 185, 47, 39, 111, 220, 213, 110, 169, 212, 159, 51, 214, 2, 216, 253, 63, 0, 88, 137, 43, 130, 12, 198, 49, 211, 150, 58, 177, 43, 108, 251, 124, 80, 167, 163, 139, 73, 170, 41, 34, 150, 167, 119, 206, 196, 163, 31, 243, 26, 27, 154, 118, 122, 176, 48, 127, 64, 135, 0, 79, 24, 229, 114, 74, 218, 75, 144, 224, 120, 213, 107, 186, 119, 190, 156, 196, 90, 83, 21, 68, 221, 176, 206, 202, 240, 189, 8, 197, 230, 79, 184, 6, 7, 247, 187, 106, 153, 139, 194, 220, 176, 10, 8, 103, 86, 254, 110 } });

            migrationBuilder.CreateIndex(
                name: "IX_Tag_BusinessId",
                table: "Tags",
                column: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_TagCategories_TagCategoryId",
                table: "Tags",
                column: "TagCategoryId",
                principalTable: "TagCategories",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_TagCategories_TagCategoryId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tag_BusinessId",
                table: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_TagCategoryId",
                table: "Tags",
                newName: "IX_Tags_TagCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "06/11/2024 14:37:44",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "09/13/2024 17:11:10");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tags",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7ccdd2fa-7d01-408c-a8b9-535ccf3f5817"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("47c9f5c5-eb25-4a33-aa2f-39429cacc4e7"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6924), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("fa8a10fb-5e1b-4ed7-afff-68d07cb2a6ef"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6927), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e08ca57d-f336-43d8-b516-f35713df856e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6930), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3497a2f1-bf76-4ed3-92c0-c46baac80e59"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("745374b5-66f8-4958-bc9b-99ced1fbe4be"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8a47e260-e57a-4221-a0e5-b7deeb90c164"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("05360fe3-f823-4a2e-b3b3-d30170b18690"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d6ef8d5-9d77-4b49-8f8a-c4416ec44bcf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("80c56f5f-f66a-4de0-9b0d-e51d671925ab"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f2501ff-9c3b-4d3a-ab11-18fa0241d38e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("15f5b8f1-12fd-481e-bdce-20eeea0db205"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4fd394e8-7eb4-4073-8143-80c722be9cbc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce63d747-09d6-49e9-a629-a534e4eb2887"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("82c17f29-e010-44cc-b5f3-7edb14a6424b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7032), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8c1f8546-824f-44bf-a8cc-492b1e2b91bc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b8e04a0b-39ea-489a-ae99-a93e4e7205c1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("be6b99b7-2bed-4d87-92c1-a587b0e01b40"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce684293-bdc1-434d-9446-ed4d605c3a4f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("024e1852-becd-4108-a997-47b38b8cb7fe"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e7aa0691-0144-404b-af23-c515682ef43a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0444e7a4-0370-4196-a22f-4752a1c8a9f3"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e56e271b-2fa9-4e84-bc0a-5db1187f539f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("691c0b84-8319-405f-b21c-38f0d55a3863"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7471), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2816ce50-fb09-4e11-9251-c465c1c40406"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7475), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf5b28bd-1b2c-4912-a2b5-b4c0e606fc77"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7478), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70eb41bf-a3f2-4586-b357-385408f72d95"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8fd5f220-c616-4042-a0bd-5c336cda9025"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7930), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f59cc250-15f0-42ec-8892-1499603f0248"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7933), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ac06bbf3-d23a-42bf-9664-df7856068370"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7936), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d73af9d5-45af-4006-b13b-8cd8194d7af3"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7939), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b90e82d0-d321-4c13-b34a-c5347d036149"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7953e451-4411-48a8-935f-a7355dc30f8f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6ef51581-9957-45ae-9500-10627dcc4c90"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5e822b30-ed3b-4717-b110-e0e1f987300c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("674bcded-28d5-493a-82ac-074810683155"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7990), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8959e4c8-80bd-4bb0-a10f-c8dd65f48baf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7993), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("95c61da0-c691-429f-8aba-7f0cd2b029d7"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("42fa1627-ab06-4484-8afe-a7162fed92a7"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e347d844-fec4-4f10-a36c-7bf521e7e6aa"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8002), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("36ccee98-9ba2-49b3-86a6-4f468d041296"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8005), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1d7c0942-5557-4983-a5da-68daaf394e74"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f98503c0-969a-4c8a-9f98-87299d4cab7d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7762), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4d1ebc8-9317-4441-a190-e980dadf48e3"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7764), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e09caf96-0e48-4ba1-a2e7-7660b1a39f9d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7767), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1c466b8a-1939-42aa-97be-48d78b4d5609"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7772), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("96e72593-3e57-4be9-bceb-84e8169fe1bd"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2d080e5d-6e4d-484d-83e4-39c845a8734f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bd51c397-1b01-4277-8c0e-8ceef439c31b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7781), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("73f8fbe9-0105-470e-8f06-ebecb00bc785"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("97afbc6f-4f31-48a3-aa1f-e350c11b5b04"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("99406cfb-276a-4608-a809-27a8d4f887d8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d84a6b4-6257-443f-b919-bf77bcc787dc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9962e05d-0d81-42b4-adb3-54a8199b9abd"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("70c7f2e0-21fc-4754-9ddd-438c8e46b919"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7801), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5a6614d2-4c36-4df0-a5ae-7367c5e94211"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ee5f993d-ce9b-4fdb-a17f-77410cf75d97"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7807), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d245e5d0-94fe-432a-955c-2c14d5de1782"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7812), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5ce956b3-6014-42dc-bc11-2d9918c23487"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7815), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5b2fbc81-07d0-40b3-ac67-2ca6ce648974"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("452d62eb-2c45-4403-887f-529661b72943"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7820), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("554bbb31-fb5d-4dc1-93f6-d262f36a9093"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7825), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0e9dc69d-b790-49f1-8646-67d20851004c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7827), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("aaab73bf-aa5b-40ff-a5ed-ae69447311b8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("448fda35-a1a9-452e-9df7-95ececb62e6d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7832), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("18436d3c-54c2-4a45-91c4-9c8b699c6c21"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("de425b9a-d142-475b-a327-d9f99cb1ba93"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5313b918-0abd-44bc-8956-d89425321c25"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7842), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e78acc9b-c853-464d-923b-8d12fa319ce1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("75d6d2ab-c1a9-429f-8571-8b28474a8906"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ce27c661-c737-474b-9bae-987cdb5029c6"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("116cb20d-08f2-4ff1-bed5-3ab193e0d1de"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ef64c20-88f6-4380-8e57-9eb9a4c39c49"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c44d4c9b-aae2-46eb-969c-cf6a70e99110"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f4919d6c-5f59-499c-b902-8eb720d9e651"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("7347c632-7626-4639-8f42-4d0ae12ff876"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1a646501-8fe3-4d27-91da-8d52b169bddf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("14c73d84-a4a5-4b32-b9ae-99319020c61e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7549), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4ca9ce92-c4a0-41c6-8974-124c8806069f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7604), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d37e276f-a8aa-41e6-8c68-a1f65ba80d2b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7607), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("40d26052-44f6-40ee-a2f2-b4d5067a2171"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7610), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9299102c-8108-405c-8fe4-8ff65db071a8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d4426b59-eb60-4d5d-ba9c-06824c11a6ca"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8156), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0bdfb4af-ed39-4c10-a986-5840bccc3f18"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8162), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8211), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8229), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8241), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8244), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8252), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8256), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8262), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8348), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8352), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8359), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8366), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8374), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8381), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8481), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8539), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("afc90a0c-7a36-4f80-8a39-f1f18a93b735"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8472c4ce-2f2d-4144-99d6-bd6c16430983"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3d53fc06-8c18-4932-aa11-41ab858b6e5e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("edbe7767-906f-426e-b5a8-3a70d9148ac5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7324), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("247bae8b-356a-4850-802f-2cd56cf5de2a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7326), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c72c0c76-2a64-4053-ad1f-c37ef4b4d114"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0da60357-704b-40fc-88d3-8472f651a03b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7335), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8deed359-6d10-45bb-908e-13cdc2a688e9"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("63de03fe-3944-43b0-a3f7-8117e00b8d18"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("5556265a-b582-4119-9c05-52cfcb5e2b7e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7343), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2850bb3a-6297-4d31-8478-0d40866c4a57"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ea89f995-e61f-4e0f-b6ab-148c2066e3f1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8009ae51-6a45-466b-b79b-0867109e405d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ca542795-319d-4310-a679-2185e31fd319"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a62c6acb-c291-4a63-8fa8-a8c6a02cd00c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9389), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e8ce58ba-cf4f-4cc8-9d2a-82b237b9e761"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("80828076-73b5-4975-87e8-8c10afda0983"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f228f852-c17e-4f35-9d8e-f06d8ce18e6c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b5022900-0b6f-4e3e-9803-ad4b85c80fbb"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1bdd0e32-4dd3-456c-a892-de8661a81484"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ff9bd06a-83e2-431e-9011-b5209be13a4b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4f897e4-98b3-4cfc-a30c-59640f00ff79"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("943c37be-587e-49ad-9b1c-d04b2f7e7b16"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ae3afa31-f734-4cd9-9403-72f7f3201479"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8df38f78-99db-4ec3-9a5b-5053cfa8e06d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("382fefc4-4ee4-417e-950c-2c76d330210f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9424), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8d26f261-d9d4-4065-a51d-05a2f8fdac95"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("207815b3-62ea-49c9-84f4-ee6386f4b46d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9046), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3ccd4cb-e71d-403a-a90c-9be85cd8ee26"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9052), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("43bb6992-eb5a-4582-a3c1-80d2c9546923"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9058), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("16aac054-c5ed-4d95-881e-e00cdf349231"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a7edd5ab-32a9-4cff-829e-d987e8249edf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9063), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e3acd550-a287-461c-9dcd-725d3a872466"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9066), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("063eb61d-e592-4f61-88e7-afd9ad631d31"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("016a26bd-573c-4248-a899-10e96adae30c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9073), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("28565e0a-d5a8-4abc-958f-2309f264616f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9075), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("858ddee5-9f04-427a-964d-04f1927afc3d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9078), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8752f321-6f9d-466f-a58b-e579a4024dbf"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9083), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("2e54cd12-61b2-49d7-a04e-656aacf99bce"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9085), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e4cabb31-8123-4879-9f3f-a0ae5acfe05f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9088), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("371acea0-d6ab-4340-a5cf-ea65e2c42ecc"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9090), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("cf0ad7e8-e105-4685-950f-c0346aa2fd1a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9095), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4f807341-568e-469d-98d5-ba3ad87bdac6"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9097), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("4e8b7c47-e6c6-4051-8252-7101f51e2ae2"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a2469dca-12eb-4357-99cb-8c7526f9fe6a"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9103), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("245e9e2d-baf0-4227-bafe-2ae5fc9b3f8f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9108), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("94f6f38e-8a19-4d23-a73e-3a34b9f332fe"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9111), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b055f823-789a-450d-b78f-f4394c82a0f1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9113), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("e917ba79-b2ea-4236-a1c0-ccc7f2519d7b"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9115), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c9fe0d0f-3578-43d0-9375-ee8548c4d2d5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9cfeb419-488f-418b-9917-b33277083df5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9122), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("77178ee2-b586-42f1-b867-c2c8d01fadd2"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9125), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("c890f1ac-e5c7-4ff0-8e0e-42a05fcb16db"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9127), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b9158afe-2728-48db-8e6e-61f0317ee9ce"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9132), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d7dd942d-f139-4ef8-8a74-3263f867e572"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9134), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a4b62fb0-9164-4ba6-95c3-544179fd790c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9137), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("bb4c9ceb-6d89-4ee8-9d0f-f51fbf8f9f57"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9139), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3c5d9650-60da-46af-b90e-f806cde9204d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9144), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dcc6e551-9417-4c63-856e-5748e28c592f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("f69f1a80-896f-49f8-be55-b0b17128c785"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9148), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a52c8e70-9ea6-4434-9d96-9fa4ca07e7ef"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6cbf52c6-58d5-44a7-92ac-ecea088788e8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9156), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("02d985ae-009f-492f-8516-a2153af3f950"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("6d808b91-f3aa-4919-af90-a1c0c7d30df2"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9161), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("117da4fa-32ef-4762-a56a-727f0e14853e"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9164), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("277303b9-e449-472d-9fd7-560702bfac56"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9169), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("93b7febe-6671-45c8-ba98-4857fc2cbcf6"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9172), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3c1036d-35fc-4eaa-aefc-c80b4def2239"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9174), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1f7e86b0-1920-48ad-8b2f-d53cac869f80"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9176), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("277bae86-a481-469e-bc13-f23ad47934f9"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9181), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("368d6614-f2c5-4ada-8b83-2f0094065258"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9226), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("dca4cc8d-c892-4041-a8f8-48c1dfd6156c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9229), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("b30f4c4e-a047-4ebf-8703-fb5c64e3f6b4"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9231), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("0584c1e4-93d9-4d3b-a402-a6ee51d61f80"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9236), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("3af6f82e-9ab3-4748-a39c-da71109d12b1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9239), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("ec2de1b3-6a53-435c-9437-9b6f1b2e168d"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9241), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("08a2829e-92d2-4c40-bcfc-f3581aaaa794"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9244), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9ea52a12-a7ce-48ab-ba8a-4280884c6335"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("1996f0d3-b094-4a59-8934-5fc8152c8ae8"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9251), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("53efcdc8-6070-4dc5-9262-c1cb29e80f79"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("9773b096-714d-4e22-8c36-eb15f6abaede"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("969b2dcf-a213-4233-9552-5e2e63c3b908"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9260), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("608cd796-289d-4792-9e29-bf1a993d89a1"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("d1132d62-0996-48d2-b0a5-c30265efe1a5"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9265), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("11c13252-f45a-492f-9b4c-2c634a32815f"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9267), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("053d5412-4fe6-4f57-a232-1db1df540e6c"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9272), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("a3e4b57a-d153-4de5-b597-2b90d5562390"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9489), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("8974e4b1-ac04-475a-a568-423cdea60210"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9494), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("009cec29-9427-4d00-ba85-ef0da6486057"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9499), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("13cfa2f0-0ccb-437d-a9c9-b5a2f510bf27"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "BusinessId", "Created", "Modified" },
                values: new object[] { new Guid("24cce47c-3c8e-4b20-a9ad-ee9f4a853541"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9504), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new Guid("a0d58b1e-a6d6-4c9e-adba-f33d5c0efe71"), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9554), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 12, 37, 44, 683, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("470ab25d-e803-4a76-b0b0-d67d9ec72622"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(71), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(72), new byte[] { 224, 75, 101, 183, 124, 16, 85, 65, 3, 75, 141, 54, 171, 179, 12, 243, 84, 196, 75, 180, 47, 135, 109, 62, 103, 113, 82, 134, 5, 57, 157, 56, 197, 140, 65, 49, 17, 180, 98, 253, 171, 51, 40, 52, 155, 183, 74, 249, 141, 16, 183, 229, 64, 48, 175, 215, 118, 39, 179, 179, 186, 163, 55, 164 }, new byte[] { 40, 21, 85, 85, 117, 226, 82, 67, 95, 28, 192, 255, 168, 65, 241, 12, 112, 118, 69, 29, 190, 97, 30, 81, 63, 222, 233, 239, 150, 37, 189, 150, 188, 237, 64, 215, 128, 11, 132, 4, 96, 218, 194, 128, 60, 105, 57, 112, 122, 53, 142, 35, 36, 100, 154, 206, 156, 219, 165, 45, 230, 120, 76, 178, 168, 118, 209, 92, 68, 123, 215, 34, 198, 224, 178, 239, 187, 248, 171, 10, 51, 104, 64, 224, 241, 2, 111, 171, 138, 211, 235, 14, 155, 215, 200, 114, 241, 235, 170, 139, 168, 102, 222, 43, 70, 153, 191, 10, 131, 157, 145, 44, 85, 240, 179, 35, 116, 142, 126, 169, 250, 196, 217, 63, 238, 9, 221, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("e76130ea-7ff4-420c-8951-017cbd30b077"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(180), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(180), new byte[] { 52, 21, 59, 133, 50, 143, 118, 242, 195, 200, 47, 233, 239, 174, 125, 95, 45, 223, 119, 75, 85, 169, 235, 33, 179, 245, 190, 195, 243, 43, 73, 103, 138, 218, 243, 254, 208, 111, 253, 136, 116, 105, 202, 85, 216, 174, 168, 92, 75, 75, 69, 38, 39, 211, 60, 184, 82, 82, 156, 64, 68, 215, 240, 159 }, new byte[] { 93, 208, 37, 208, 50, 99, 220, 175, 218, 249, 216, 222, 102, 137, 134, 217, 239, 175, 30, 181, 71, 168, 164, 60, 164, 101, 224, 92, 230, 134, 197, 19, 191, 20, 255, 158, 151, 65, 137, 140, 202, 43, 65, 42, 219, 9, 238, 233, 58, 0, 2, 176, 177, 72, 221, 243, 152, 12, 108, 89, 252, 238, 138, 254, 166, 156, 169, 108, 60, 169, 194, 45, 193, 15, 158, 56, 5, 63, 190, 2, 11, 209, 217, 182, 182, 104, 180, 208, 106, 95, 227, 29, 45, 161, 92, 195, 183, 219, 237, 231, 253, 171, 138, 85, 53, 163, 44, 42, 15, 119, 107, 195, 92, 120, 220, 25, 22, 106, 79, 141, 224, 137, 174, 237, 24, 89, 204, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("cde59053-f9c5-450c-b5f0-93536e8cb416"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(249), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(250), new byte[] { 123, 170, 197, 156, 225, 39, 134, 4, 102, 94, 189, 158, 55, 3, 230, 168, 135, 81, 237, 62, 254, 157, 226, 206, 211, 248, 247, 152, 112, 177, 193, 92, 147, 135, 127, 88, 74, 108, 75, 219, 243, 56, 211, 104, 109, 116, 118, 172, 105, 27, 19, 109, 40, 193, 189, 68, 81, 52, 66, 174, 223, 18, 139, 97 }, new byte[] { 139, 24, 251, 128, 83, 59, 83, 141, 162, 201, 147, 148, 198, 70, 48, 0, 20, 131, 69, 154, 20, 3, 38, 156, 134, 198, 225, 85, 33, 171, 192, 85, 87, 242, 224, 246, 120, 30, 20, 8, 215, 66, 238, 105, 132, 219, 82, 116, 115, 52, 106, 137, 74, 227, 14, 96, 77, 160, 129, 73, 97, 220, 219, 154, 29, 14, 2, 163, 98, 217, 233, 149, 7, 252, 150, 184, 139, 42, 86, 24, 238, 17, 51, 90, 62, 182, 7, 59, 163, 91, 222, 224, 239, 0, 22, 18, 172, 126, 73, 250, 0, 148, 182, 194, 197, 227, 130, 152, 214, 238, 217, 154, 112, 253, 143, 64, 149, 206, 9, 133, 222, 195, 144, 175, 107, 58, 151, 249 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("e128655e-8e27-4ea4-9404-ed947ca3fab6"), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(339), new DateTime(2024, 6, 11, 12, 37, 44, 684, DateTimeKind.Utc).AddTicks(339), new byte[] { 179, 247, 229, 113, 166, 108, 80, 142, 125, 195, 216, 241, 169, 143, 200, 160, 115, 33, 143, 125, 204, 55, 240, 64, 245, 101, 201, 54, 136, 177, 24, 146, 219, 37, 144, 11, 172, 97, 167, 204, 86, 80, 235, 72, 162, 146, 213, 119, 188, 138, 135, 57, 225, 86, 242, 169, 163, 111, 34, 126, 135, 152, 202, 229 }, new byte[] { 157, 46, 140, 10, 232, 114, 24, 94, 208, 215, 69, 73, 176, 124, 12, 240, 41, 58, 135, 192, 103, 231, 175, 123, 51, 230, 191, 185, 113, 68, 59, 88, 43, 252, 75, 32, 236, 209, 81, 229, 91, 36, 156, 187, 244, 135, 192, 91, 48, 205, 180, 89, 225, 200, 175, 151, 108, 211, 126, 135, 57, 10, 26, 35, 212, 43, 63, 86, 56, 112, 56, 108, 68, 191, 97, 85, 10, 212, 87, 208, 124, 137, 108, 140, 184, 213, 166, 184, 39, 221, 83, 232, 132, 121, 105, 81, 255, 66, 0, 192, 215, 1, 215, 228, 20, 191, 177, 22, 160, 117, 200, 67, 231, 138, 30, 124, 154, 198, 81, 67, 93, 196, 236, 130, 55, 165, 160, 130 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_TagCategories_TagCategoryId",
                table: "Tags",
                column: "TagCategoryId",
                principalTable: "TagCategories",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
