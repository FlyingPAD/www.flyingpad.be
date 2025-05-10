using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Init_Fix_4 : Migration
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
                defaultValue: "05/09/2025 21:41:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:37:14");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6430), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6463), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6466), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6469), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6472), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6477), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6480), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6482), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6486), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6488), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6490), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6492), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6495), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6499), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6501), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6457), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6504), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6507), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6509), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6511), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6514), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6516), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6521), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6524), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6526), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6529), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6531), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6533), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6536), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6538), new DateTime(2025, 5, 9, 19, 41, 48, 864, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 865, DateTimeKind.Utc).AddTicks(4911), new DateTime(2025, 5, 9, 19, 41, 48, 865, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8293), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8300), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 5, 9, 19, 41, 48, 877, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1920), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1924), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1926), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1928), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1931), new DateTime(2025, 5, 9, 19, 41, 48, 878, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8156), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8179), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8186), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8187), "# File ext. | Audio" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8193), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8199), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 5, 9, 19, 41, 48, 926, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(161), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(203), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(207), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(213), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(218), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(219), "*.mp3" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(224), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(240), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(246), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(252), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(258), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(268), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(276), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(285), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(294), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 5, 9, 19, 41, 48, 928, DateTimeKind.Utc).AddTicks(298) });
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
                defaultValue: "05/09/2025 21:37:14",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:41:48");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9117), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9145), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9148), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9168), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9171), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9174), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9177), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9180), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9182), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9184), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9187), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9192), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9194), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9197), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9199), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9201), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9136), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9140), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9204), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9206), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9208), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9213), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9216), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9218), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9221), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9224), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9226), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9229), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9232), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9237), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9239), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9242), new DateTime(2025, 5, 9, 19, 37, 14, 878, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 879, DateTimeKind.Utc).AddTicks(6537), new DateTime(2025, 5, 9, 19, 37, 14, 879, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(46), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(57), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(61), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(64), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(77), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(80), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(82), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(84), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3191), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3195), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3199), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3212), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3216), new DateTime(2025, 5, 9, 19, 37, 14, 890, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1056), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1077), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1082), "# File ext. | Doc." });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1085), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1110), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1114), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4630), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4636), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4641), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4646), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4646), "*.txt" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4651), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4670), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4683), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4687), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4692), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4696), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4709), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4718), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4719) });
        }
    }
}
