using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Tenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pseudonym",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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
                oldDefaultValue: "09/13/2024 17:11:10");

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
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt", "Pseudonym" },
                values: new object[] { new Guid("9e9ab3d9-5cba-48bb-9252-1cdb6e5b4cdf"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8338), new byte[] { 137, 206, 253, 149, 155, 42, 123, 142, 19, 248, 92, 69, 145, 163, 210, 52, 187, 246, 54, 127, 169, 11, 174, 121, 170, 160, 72, 80, 16, 157, 19, 172, 184, 193, 250, 250, 218, 86, 83, 73, 57, 249, 154, 152, 110, 145, 150, 234, 73, 177, 246, 85, 247, 82, 98, 9, 181, 84, 179, 93, 93, 223, 75, 95 }, new byte[] { 120, 22, 129, 127, 107, 22, 113, 43, 88, 8, 20, 13, 13, 23, 56, 178, 132, 114, 34, 96, 178, 140, 173, 203, 173, 232, 211, 33, 221, 21, 66, 76, 221, 216, 110, 222, 164, 99, 78, 181, 61, 36, 38, 66, 239, 61, 135, 1, 6, 173, 161, 223, 216, 29, 243, 116, 186, 122, 5, 198, 25, 118, 72, 62, 97, 210, 192, 22, 156, 160, 124, 0, 237, 181, 172, 226, 29, 179, 229, 62, 30, 17, 253, 15, 26, 166, 137, 146, 58, 155, 134, 211, 142, 79, 72, 90, 171, 59, 202, 246, 116, 137, 10, 103, 124, 233, 226, 133, 145, 245, 209, 174, 44, 117, 31, 222, 11, 254, 236, 44, 216, 35, 112, 189, 54, 173, 210, 153 }, "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt", "Pseudonym" },
                values: new object[] { new Guid("db6b520c-4515-4076-a139-c22713e42513"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8451), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8451), new byte[] { 25, 198, 82, 208, 180, 146, 152, 104, 185, 22, 87, 157, 213, 138, 24, 16, 44, 101, 211, 32, 72, 190, 178, 236, 134, 184, 41, 199, 163, 8, 171, 156, 50, 42, 165, 127, 194, 155, 130, 84, 69, 79, 94, 67, 233, 44, 194, 135, 71, 10, 142, 235, 219, 99, 67, 154, 18, 8, 238, 27, 109, 70, 44, 143 }, new byte[] { 32, 17, 196, 218, 72, 149, 10, 211, 75, 64, 42, 153, 51, 90, 84, 45, 33, 234, 170, 226, 190, 97, 144, 158, 5, 186, 104, 31, 189, 179, 168, 180, 89, 198, 102, 182, 97, 50, 225, 184, 77, 155, 42, 15, 152, 225, 23, 194, 44, 210, 24, 167, 160, 46, 21, 212, 206, 82, 138, 133, 9, 19, 206, 237, 41, 60, 78, 193, 161, 187, 1, 201, 15, 203, 103, 138, 107, 98, 181, 118, 17, 194, 234, 118, 199, 110, 85, 169, 105, 206, 26, 122, 211, 114, 232, 23, 156, 85, 43, 36, 229, 99, 244, 36, 247, 141, 53, 251, 168, 74, 166, 253, 48, 72, 254, 72, 67, 10, 150, 169, 254, 151, 43, 23, 121, 111, 157, 202 }, "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt", "Pseudonym" },
                values: new object[] { new Guid("2a216d26-b09b-422e-b0ef-04e98f48b91b"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8535), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8535), new byte[] { 88, 203, 50, 175, 106, 165, 108, 84, 226, 179, 174, 18, 234, 13, 53, 176, 84, 97, 167, 231, 86, 151, 108, 71, 34, 89, 238, 159, 165, 162, 67, 239, 4, 229, 218, 141, 244, 122, 131, 89, 207, 78, 123, 114, 245, 16, 79, 195, 182, 33, 53, 51, 50, 85, 188, 197, 179, 127, 140, 101, 229, 113, 23, 74 }, new byte[] { 238, 93, 9, 80, 130, 159, 118, 25, 32, 188, 140, 196, 231, 17, 249, 243, 174, 113, 28, 100, 7, 176, 107, 10, 160, 244, 183, 22, 132, 167, 34, 115, 24, 210, 146, 241, 189, 187, 98, 192, 27, 167, 165, 97, 111, 95, 250, 228, 166, 221, 194, 147, 233, 244, 208, 17, 128, 241, 127, 137, 166, 13, 55, 119, 94, 74, 83, 183, 14, 89, 185, 151, 204, 173, 7, 83, 169, 194, 232, 252, 64, 11, 93, 113, 10, 230, 80, 131, 108, 101, 169, 238, 118, 106, 148, 129, 163, 95, 95, 65, 88, 181, 72, 172, 14, 65, 143, 83, 140, 5, 245, 218, 170, 26, 249, 100, 95, 54, 158, 66, 77, 142, 203, 153, 98, 127, 179, 99 }, "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "BusinessId", "Created", "Modified", "PasswordHash", "PasswordSalt", "Pseudonym" },
                values: new object[] { new Guid("3497ed51-e927-4cc4-9d84-254eeb9ca199"), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8618), new DateTime(2024, 12, 23, 13, 41, 11, 719, DateTimeKind.Utc).AddTicks(8618), new byte[] { 243, 47, 194, 245, 115, 41, 23, 57, 133, 222, 220, 172, 95, 42, 141, 127, 104, 152, 188, 33, 104, 121, 68, 87, 16, 7, 58, 80, 223, 52, 87, 245, 193, 57, 162, 21, 48, 76, 204, 15, 142, 194, 126, 123, 14, 76, 235, 0, 128, 221, 136, 216, 196, 21, 227, 182, 218, 215, 234, 252, 37, 177, 207, 161 }, new byte[] { 102, 144, 18, 60, 150, 39, 5, 7, 143, 25, 125, 104, 61, 254, 115, 23, 233, 233, 108, 135, 15, 28, 9, 220, 50, 190, 134, 64, 207, 80, 91, 35, 66, 174, 192, 60, 254, 253, 115, 202, 33, 103, 169, 147, 58, 153, 44, 221, 40, 118, 176, 62, 185, 43, 188, 31, 85, 139, 243, 177, 108, 21, 106, 132, 93, 91, 146, 181, 40, 191, 47, 253, 130, 108, 21, 82, 234, 123, 23, 171, 25, 4, 70, 5, 28, 75, 134, 70, 201, 113, 0, 153, 9, 24, 75, 132, 12, 94, 85, 205, 25, 185, 103, 3, 217, 159, 144, 164, 89, 105, 194, 13, 255, 68, 167, 243, 162, 72, 179, 225, 139, 138, 151, 204, 109, 238, 102, 245 }, "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pseudonym",
                table: "Users");

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
                oldDefaultValue: "12/23/2024 14:41:11");

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
        }
    }
}
