using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Register_Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsEmailVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/11/2025 08:16:01",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/10/2025 23:37:55");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2821), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2919), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2926), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2950), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2953), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2956), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2958), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2960), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2963), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2965), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2968), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2973), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2976), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2980), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2838), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2843), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2983), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2985), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2987), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2991), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2996), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2998), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3000), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3002), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3005), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3007), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3014), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3019), new DateTime(2025, 5, 11, 6, 16, 0, 972, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3319), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3338), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3343), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3346), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3350), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3353), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3355), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3377), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6687), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6690), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6693), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6697), new DateTime(2025, 5, 11, 6, 16, 0, 986, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4202), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4222), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4225), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4228), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4249), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4252), new DateTime(2025, 5, 11, 6, 16, 1, 35, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(492), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(504), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(507), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(510), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(520), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(525), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(527), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(529), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(532), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(535), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(537), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(542), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(544), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(547), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(549), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(551), new DateTime(2025, 5, 11, 6, 16, 1, 36, DateTimeKind.Utc).AddTicks(551) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsEmailVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                oldDefaultValue: "05/11/2025 08:16:01");

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
    }
}
