using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Init_Fix_3 : Migration
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
                defaultValue: "05/09/2025 21:37:14",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:35:09");

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
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 5, 9, 19, 37, 14, 932, DateTimeKind.Utc).AddTicks(1082) });

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
                columns: new[] { "Created", "Modified", "TagCategoryId" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4624), 1 });

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
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4646), new DateTime(2025, 5, 9, 19, 37, 14, 933, DateTimeKind.Utc).AddTicks(4646) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/09/2025 21:35:09",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:37:14");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4454), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4457), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4460), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4485), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4488), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4490), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4492), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4495), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4497), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4499), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4501), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4506), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4508), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4511), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4446), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4450), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4516), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4518), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4520), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4522), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4527), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4529), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4532), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4534), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4540), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4542), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4544), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4548), new DateTime(2025, 5, 9, 19, 35, 9, 468, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 469, DateTimeKind.Utc).AddTicks(1741), new DateTime(2025, 5, 9, 19, 35, 9, 469, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7046), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7061), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7065), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7069), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7072), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7094), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7096), new DateTime(2025, 5, 9, 19, 35, 9, 479, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(435), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(442), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(444), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(447), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(451), new DateTime(2025, 5, 9, 19, 35, 9, 480, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7728), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 5, 9, 19, 35, 9, 503, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3894), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified", "TagCategoryId" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3901), 2 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3907), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3909), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3911), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3921), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3924), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3926), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3928), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3935), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3943), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3946), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3948), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3952), new DateTime(2025, 5, 9, 19, 35, 9, 504, DateTimeKind.Utc).AddTicks(3953) });
        }
    }
}
