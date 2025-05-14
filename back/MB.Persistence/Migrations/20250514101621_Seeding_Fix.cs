using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Fix : Migration
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
                defaultValue: "05/14/2025 12:16:18",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/12/2025 11:10:34");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5174), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5203), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5207), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5229), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5233), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5236), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5240), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5243), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5248), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5251), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5253), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5259), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5262), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5264), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5268), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5270), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5195), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5199), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5273), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5275), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5277), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5283), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5286), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5288), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5319), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5321), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5324), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5328), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5336), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5291), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5294), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5296), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5299), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5308), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5313), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5316), new DateTime(2025, 5, 14, 10, 16, 18, 308, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7642), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 5, 14, 10, 16, 18, 321, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1692), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1701), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1704), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1708), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1710), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1720), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1722), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1724), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1727), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1729), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1731), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1734), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1736), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1741), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1744), new DateTime(2025, 5, 14, 10, 16, 18, 322, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2889), new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2912), new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2914), new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2917), new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2921), new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2924), new DateTime(2025, 5, 14, 10, 16, 18, 370, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2488), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2498), "New Files" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2510), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2513), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2519), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2523), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2525), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2532), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2540), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2542), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2545), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2545), "Landscape ( 16:9 )" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2547), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2549), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2550), "Portrait ( 16:9 )" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2554), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2554), "Square ( 1:1 )" });
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
                defaultValue: "05/12/2025 11:10:34",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/14/2025 12:16:18");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4639), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4643), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4646), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4667), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4670), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4675), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4682), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4693), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4697), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4702), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4636), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4707), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4755), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4759), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4764), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4767), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4794), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4797), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4801), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4803), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4805), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4811), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4816), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4769), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4771), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4774), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4777), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4779), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4782), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4787), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 5, 12, 9, 10, 34, 948, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8778), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8795), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8799), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8820), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8823), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8826), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8829), new DateTime(2025, 5, 12, 9, 10, 34, 959, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2042), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2049), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2056), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2065), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2068), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2070), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2072), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2074), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2076), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2078), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2080), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2086), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2088), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2090), new DateTime(2025, 5, 12, 9, 10, 34, 960, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2551), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2568), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2572), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2603), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2607), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8698), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8705), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8705), "# New Files" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8708), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8711), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8714), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8717), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8727), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8729), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8731), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8734), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8736), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8738), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8741), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8743), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8748), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8750), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8750), "Landscape (16:9)" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8752), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8755), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8755), "Portrait (16:9)" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified", "Name" },
                values: new object[] { new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8757), new DateTime(2025, 5, 12, 9, 10, 34, 997, DateTimeKind.Utc).AddTicks(8757), "Square" });
        }
    }
}
