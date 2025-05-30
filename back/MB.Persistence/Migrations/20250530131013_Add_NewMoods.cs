using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_NewMoods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/30/2025 15:10:11",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/14/2025 12:16:18");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Moods",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "Moods",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Moods",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Moods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Moods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1124), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1153), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1155), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1159), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1181), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1184), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1186), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1189), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1191), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1193), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1215), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1217), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1220), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1223), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1143), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1149), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1225), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1228), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1231), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1234), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1239), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1243), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1267), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1270), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1273), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1276), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1278), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1281), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1285), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1288), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1245), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1248), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1250), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1252), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1255), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1257), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1262), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1264), new DateTime(2025, 5, 30, 13, 10, 11, 180, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5283), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5297), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5301), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5304), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5307), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5309), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5336), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5339), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8651), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8660), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8668), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8697), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8699), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8702), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8704), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8707), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8709), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8714), new DateTime(2025, 5, 30, 13, 10, 11, 190, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9888), new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9899), new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9902), new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9905), new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9908), new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9911), new DateTime(2025, 5, 30, 13, 10, 11, 212, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5790), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5808), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5811), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5814), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5817), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5819), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5821), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5823), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5826), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5831), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5834), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5837), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5839), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5842), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5844), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5846), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5849), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5854), new DateTime(2025, 5, 30, 13, 10, 11, 213, DateTimeKind.Utc).AddTicks(5854) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Moods");

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
                oldDefaultValue: "05/30/2025 15:10:11");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Moods",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Moods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

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
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2545), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2545) });

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
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2549), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2554), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "TagCategoryId" },
                values: new object[] { 2, new Guid("b4c3d2e1-5f6a-4b7c-8d9e-0a1b2c3d4e5f"), new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2498), "Administrator", "", new DateTime(2025, 5, 14, 10, 16, 18, 371, DateTimeKind.Utc).AddTicks(2498), "Administrator", "New Files", 1 });
        }
    }
}
