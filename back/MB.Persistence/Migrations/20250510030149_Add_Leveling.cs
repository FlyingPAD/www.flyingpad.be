using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Leveling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/10/2025 05:01:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 22:07:43");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5158), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5183), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5186), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5206), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5210), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5212), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5215), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5218), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5220), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5222), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5226), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5232), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5234), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5236), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5238), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5241), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5174), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5179), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5243), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5243), 0 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5245), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5246), 0 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5248), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5249), 0 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5254), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5254), 0 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5257), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5258), 0 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5260), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5260), 0 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5262), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5278), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5281), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5286), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5291), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5296), new DateTime(2025, 5, 10, 3, 1, 48, 357, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(767), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(794), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(801), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(841), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6644), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6672), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6676), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6681), new DateTime(2025, 5, 10, 3, 1, 48, 375, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3434), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3452), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3456), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3459), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3462), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3465), new DateTime(2025, 5, 10, 3, 1, 48, 410, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(244), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(275), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(278), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(281), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(285), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(288), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(290), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(292), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(295), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(300), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(305), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(308), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(310), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(313), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(315), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(318), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(324), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(327), new DateTime(2025, 5, 10, 3, 1, 48, 411, DateTimeKind.Utc).AddTicks(327) });
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
                defaultValue: "05/09/2025 22:07:43",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/10/2025 05:01:48");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9768), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9811), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9814), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9820), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9823), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9826), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9831), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9834), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9840), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9847), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9805), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9808), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9855), 100 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9857), 150 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9859), 200 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9862), 250 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9864), 300 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified", "XpReward" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9916), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9916), 350 });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9919), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9925), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9928), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9931), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9934), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9936), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9938), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9940), new DateTime(2025, 5, 9, 20, 7, 43, 214, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Pseudonym" },
                values: new object[] { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000001"), new DateTime(2025, 5, 9, 20, 7, 43, 215, DateTimeKind.Utc).AddTicks(7171), "Administrator", "", new DateTime(2025, 5, 9, 20, 7, 43, 215, DateTimeKind.Utc).AddTicks(7172), "Administrator", "# Unknown Artist", "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(361), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(381), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(386), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(389), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(392), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(395), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(397), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(417), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3870), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3877), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3881), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3883), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3885), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3887), new DateTime(2025, 5, 9, 20, 7, 43, 236, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4570), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4573), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4576), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4579), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 5, 9, 20, 7, 43, 260, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(762), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(769), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(771), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(781), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(784), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(787), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(789), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(791), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(793), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(795), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(797), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(802), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(807), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(809), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 5, 9, 20, 7, 43, 261, DateTimeKind.Utc).AddTicks(831) });
        }
    }
}
