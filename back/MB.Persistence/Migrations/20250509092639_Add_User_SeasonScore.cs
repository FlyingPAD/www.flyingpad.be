using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_User_SeasonScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Experience",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SeasonScore",
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
                defaultValue: "05/09/2025 11:26:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/08/2025 09:08:40");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2274), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2311), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2316), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2321), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2345), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2350), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2356), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2360), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2372), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2377), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2382), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2392), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2398), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2404), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2409), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2306), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2414), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2419), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2423), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2428), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2437), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2445), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2450), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2455), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2460), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2472), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2477), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2487), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2492), new DateTime(2025, 5, 9, 9, 26, 36, 898, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1646), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1655), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1660), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1664), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1667), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1670), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1683), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1686), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1689), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1692), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1694), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1697), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1700), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1703), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1721), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1725), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1728), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1731), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1734), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1737), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1740), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1743), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1748), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1926), new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1944), new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1949), new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5681), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5685), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5689), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5692), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5702), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5705), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5708), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8921), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8931), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8934), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8937), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8953), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8963), new DateTime(2025, 5, 9, 9, 26, 36, 910, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3470), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3478), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3482), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3491), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3516), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3518), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3535), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3538), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3540), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(943), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(954), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(958), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(961), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(966), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(969), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(972), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(975), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(980), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(983), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1005), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1008), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1011), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1020), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1026), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1029), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1031), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1034), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1037), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1040), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1048), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1051), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1054), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1057), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1060), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1063), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5648), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5652), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5655), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5661), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5664), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5667), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5673), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3903), new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3907), new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7058), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7083), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7113), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7124), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7130), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7134), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7143), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7150), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7156), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7163), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7172), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7176), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(6038), new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(9182), new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3784), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3803), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3810), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3815), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3822), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3827), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3831), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3836), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3846), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3852), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3805), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3818), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3825), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3832), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3838), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3845), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3859), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3866), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3870), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3875), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3880), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3886), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3890), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3896), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3906), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3912), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3916), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4003), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4018), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4024), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4041), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4046), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4059), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4063), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4067), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4071), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4084), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4089), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4093), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4098), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4103), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4108), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4113), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4124), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4129), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4133), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4139), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4143), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4149), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4154), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4159), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4167), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4191), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4196), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4201), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4205), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4209), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4215), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4220), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4227), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4231), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4235), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4240), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4245), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4249), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4261), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4270), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4275), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4279), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4283), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4292), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4296), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4307), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4312), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4316), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(960), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(970), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(983), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1005), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1010), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7278), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7263), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7261), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7278) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeasonScore",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Experience",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/08/2025 09:08:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 11:26:36");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8039), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8065), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8070), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8072), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8075), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8078), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8083), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8085), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8090), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8093), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8098), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8100), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8105), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8107), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8058), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8061), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8109), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8112), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8114), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8118), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8121), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8125), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8128), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8130), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8132), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8134), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8137), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8139), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8142), new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7623), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7635), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7642), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7669), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7685), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7690), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7705), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7710), new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7101), new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7115), new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3599), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3611), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3616), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3619), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3622), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3625), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3638), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3641), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7757), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7760), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7763), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2917), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2925), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2932), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2938), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2941), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2943), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2949), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2951), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2954), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2957), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2960), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2963), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2965), new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(557), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(574), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(579), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(583), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(586), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(589), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(592), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(594), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(597), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(603), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(605), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(608), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(612), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(615), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(618), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(621), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(624), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(630), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(632), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(635), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(637), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(640), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(643), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(645), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(648), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(654), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(656), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(662), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(665), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(667), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5641), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5651), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5662), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5665), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5668), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5673), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5678), new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4379), new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4401), new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3733), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3748), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3752), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3759), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3772), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3776), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3780), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3783), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3787), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3793), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3797), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3803), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3807), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3811), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3814), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3818), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3822), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3825), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3829), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3836), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3839), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3843), new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(2652), new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(5527), new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6277), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6294), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6297), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6300), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6303), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6315), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6317), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6319), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6322), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6324), new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3579), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3593), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3597), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3610), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3614), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3617), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3622), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3626), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3628), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3631), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3635), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3641), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3644), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3647), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3650), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3653), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3657), new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(367), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(380), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(391), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(394), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(396), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(399), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(402), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(405), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(408), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(410), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(415), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(417), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(420), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(423), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(426), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(428), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(430), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(432), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(438), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(440), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(445), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(447), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(451), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(453), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(458), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(474), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(477), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(479), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(481), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(484), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(487), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(489), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(495), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(501), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(503), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(505), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(508), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(512), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(521), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(523), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(526), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(528), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(530), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(538), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(540), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(542), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(544), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(547), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(549), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(551), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(553), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(558), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5285), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5296), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5300), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5304), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "DateEnd", "DateStart", "Modified" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9809), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9792), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9790), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9809) });
        }
    }
}
