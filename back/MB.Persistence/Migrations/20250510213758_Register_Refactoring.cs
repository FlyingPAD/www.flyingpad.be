using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Register_Refactoring : Migration
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
                defaultValue: "05/10/2025 23:37:55",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/10/2025 11:37:07");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8304), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8307), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8310), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8313), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8401), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8405), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8412), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8415), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8418), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8423), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8425), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8428), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8430), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8292), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8440), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8443), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8446), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8448), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8451), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8453), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8455), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8460), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8463), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8465), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8468), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8470), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8473), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 5, 10, 21, 37, 55, 62, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2723), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2760), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2763), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2767), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2770), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2773), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2775), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2778), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6077), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6094), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6097), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6100), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6103), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6105), new DateTime(2025, 5, 10, 21, 37, 55, 74, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8191), new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8208), new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8212), new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8234), new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8238), new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 5, 10, 21, 37, 55, 120, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5025), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5033), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5036), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5039), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5042), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5053), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5056), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5059), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5061), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5064), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5067), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5070), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5073), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5078), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5080), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5082), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5085), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5087), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5089), new DateTime(2025, 5, 10, 21, 37, 55, 121, DateTimeKind.Utc).AddTicks(5090) });
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
                defaultValue: "05/10/2025 11:37:07",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/10/2025 23:37:55");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8067), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8114), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8120), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8123), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8126), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8129), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8131), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8136), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8139), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8141), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8148), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8151), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8154), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8090), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8224), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8226), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8231), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8233), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8238), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8249), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 5, 10, 9, 37, 7, 78, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4217), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4236), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4260), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4263), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4266), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4268), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4271), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7337), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7355), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7418), new DateTime(2025, 5, 10, 9, 37, 7, 90, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9255), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9274), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9278), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9281), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9302), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9305), new DateTime(2025, 5, 10, 9, 37, 7, 165, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5874), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5885), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5889), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5905), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5908), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5910), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5919), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5927), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5929), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 5, 10, 9, 37, 7, 166, DateTimeKind.Utc).AddTicks(5934) });
        }
    }
}
