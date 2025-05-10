using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Some_Fixes : Migration
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
                defaultValue: "05/08/2025 09:08:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/06/2025 19:45:51");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8039), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8043), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8065), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8066), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8070), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8070), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8072), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8072), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8075), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8075), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8078), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8078), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8083), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8083), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8085), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8085), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8087), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8088), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8090), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8090), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8093), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8093), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8096), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8096), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8098), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8098), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8100), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8100), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8105), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8105), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8107), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8107), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8058), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8058), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8061), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8062), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8109), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8110), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8112), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8112), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8114), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8114), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8116), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8116), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8118), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8119), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8121), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8121), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8125), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8125), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8128), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8128), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8130), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8130), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8132), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8132), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8134), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8134), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8137), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8137), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8139), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8140), "Administrator" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8142), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 275, DateTimeKind.Utc).AddTicks(8142), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7623), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7625), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7635), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7635), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7638), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7639), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7642), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7642), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7645), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7645), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7648), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7648), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7661), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7661), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7664), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7664), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7666), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7667), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7669), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7669), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7672), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7672), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7674), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7674), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7677), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7677), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7679), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7679), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7685), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7685), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7687), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7687), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7690), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7690), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7693), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7693), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7695), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7696), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7698), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7699), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7701), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7702), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7705), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7705), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7710), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 276, DateTimeKind.Utc).AddTicks(7710), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7101), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7103), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7115), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7117), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7120), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 283, DateTimeKind.Utc).AddTicks(7121), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3599), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3601), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3611), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3612), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3616), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3616), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3619), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3619), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3622), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3623), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3625), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3625), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3638), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3638), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3641), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(3641), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7744), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7746), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7753), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7753), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7757), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7757), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7760), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7760), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7763), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7763), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7765), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 288, DateTimeKind.Utc).AddTicks(7765), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2917), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2919), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2925), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2926), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2929), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2929), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2932), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2932), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2935), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2936), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2938), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2939), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2941), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2941), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2943), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2944), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2949), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2949), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2951), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2951), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2954), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2955), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2957), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2958), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2960), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2961), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2963), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2963), "Administrator" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2965), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 289, DateTimeKind.Utc).AddTicks(2966), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(557), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(558), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(574), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(575), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(579), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(579), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(583), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(583), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(586), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(586), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(589), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(589), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(592), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(592), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(594), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(595), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(597), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(597), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(603), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(603), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(605), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(606), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(608), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(609), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(612), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(612), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(615), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(615), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(618), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(618), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(621), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(621), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(624), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(624), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(630), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(630), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(632), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(633), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(635), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(635), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(637), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(638), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(640), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(640), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(643), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(643), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(645), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(646), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(648), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(648), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(654), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(654), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(656), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(657), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(659), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(660), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(662), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(662), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(665), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(665), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(667), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(668), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5641), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5642), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5651), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5651), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5662), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5662), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5665), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5665), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5668), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5668), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5670), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5671), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5673), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5673), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5675), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5676), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5678), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 290, DateTimeKind.Utc).AddTicks(5678), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4379), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4380), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4397), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4398), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4401), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 291, DateTimeKind.Utc).AddTicks(4401), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3733), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3736), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3748), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3748), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3752), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3753), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3759), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3759), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3772), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3773), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3776), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3776), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3780), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3780), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3783), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3783), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3787), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3787), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3790), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3790), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3793), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3793), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3797), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3797), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3803), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3804), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3807), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3807), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3811), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3811), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3814), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3815), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3818), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3818), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3822), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3822), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3825), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3826), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3829), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3829), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3836), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3836), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3839), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3840), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3843), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 287, DateTimeKind.Utc).AddTicks(3843), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(2652), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(2654), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(5527), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 320, DateTimeKind.Utc).AddTicks(5528), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6277), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6280), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6294), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6294), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6297), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6297), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6300), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6300), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6303), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6303), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6315), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6315), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6317), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6317), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6319), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6320), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6322), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6322), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6324), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 315, DateTimeKind.Utc).AddTicks(6324), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3579), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3582), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3593), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3594), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3597), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3597), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3610), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3610), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3614), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3614), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3617), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3618), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3622), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3622), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3626), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3626), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3628), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3629), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3631), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3632), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3635), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3635), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3641), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3641), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3644), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3644), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3647), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3647), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3650), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3650), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3653), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3654), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3657), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 316, DateTimeKind.Utc).AddTicks(3657), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(367), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(370), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(380), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(381), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(391), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(392), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(394), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(394), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(396), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(396), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(399), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(399), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(402), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(403), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(405), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(405), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(408), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(408), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(410), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(410), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(415), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(415), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(417), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(417), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(420), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(420), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(423), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(423), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(426), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(426), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(428), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(428), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(430), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(431), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(432), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(433), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(438), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(438), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(440), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(440), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(442), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(443), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(445), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(445), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(447), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(447), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(449), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(449), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(451), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(451), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(453), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(453), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(458), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(458), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(474), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(475), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(477), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(477), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(479), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(479), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(481), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(481), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(484), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(484), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(487), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(487), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(489), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(490), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(495), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(495), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(498), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(499), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(501), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(501), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(503), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(503), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(505), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(506), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(508), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(508), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(510), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(510), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(512), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(512), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(517), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(517), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(519), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(519), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(521), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(521), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(523), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(524), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(526), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(526), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(528), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(528), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(530), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(530), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(532), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(532), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(538), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(538), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(540), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(540), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(542), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(542), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(544), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(545), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(547), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(547), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(549), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(549), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(551), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(551), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(553), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(553), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(558), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(558), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5285), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5288), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5296), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5297), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5300), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5300), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5302), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5302), "Administrator" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5304), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(5304), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "DateEnd", "DateStart", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9809), "Administrator", new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9792), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9790), new DateTime(2025, 5, 8, 7, 8, 40, 317, DateTimeKind.Utc).AddTicks(9809), "Administrator" });
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
                defaultValue: "05/06/2025 19:45:51",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/08/2025 09:08:40");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2654), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2657), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2680), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2680), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2684), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2684), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2688), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2688), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2711), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2711), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2714), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2715), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2717), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2718), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2720), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2720), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2723), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2723), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2726), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2726), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2728), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2729), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2732), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2732), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2737), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2738), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2740), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2740), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2743), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2743), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2746), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2746), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2672), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2672), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2676), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2676), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2749), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2749), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2751), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2752), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2754), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2755), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2757), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2758), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2762), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2763), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2765), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2765), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2768), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2769), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2772), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2772), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2775), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2775), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2778), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2778), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2792), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2792), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2795), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2795), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2800), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2800), "" });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2803), "", new DateTime(2025, 5, 6, 17, 45, 51, 311, DateTimeKind.Utc).AddTicks(2804), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(433), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(434), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(440), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(440), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(444), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(444), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(448), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(448), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(451), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(452), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(454), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(455), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(463), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(464), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(466), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(467), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(469), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(470), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(472), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(472), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(475), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(475), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(478), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(478), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(481), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(481), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(483), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(484), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(488), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(488), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(491), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(491), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(493), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(494), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(496), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(496), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(498), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(499), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(501), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(501), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(503), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(504), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(506), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(506), "" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(511), "", new DateTime(2025, 5, 6, 17, 45, 51, 312, DateTimeKind.Utc).AddTicks(511), "" });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6478), "", new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6481), "" });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6498), "", new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6498), "" });

            migrationBuilder.UpdateData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6502), "", new DateTime(2025, 5, 6, 17, 45, 51, 319, DateTimeKind.Utc).AddTicks(6503), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3250), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3251), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3259), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3259), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3263), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3263), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3267), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3267), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3270), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3271), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3280), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3280), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3283), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3283), "" });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3286), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(3286), "" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6882), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6883), "" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6891), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6891), "" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6895), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6895), "" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6898), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6898), "" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6901), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6901), "" });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6910), "", new DateTime(2025, 5, 6, 17, 45, 51, 324, DateTimeKind.Utc).AddTicks(6910), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1586), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1588), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1594), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1595), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1598), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1598), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1602), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1602), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1605), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1605), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1608), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1608), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1624), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1624), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1633), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1633), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1636), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1636), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1639), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1639), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1642), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1642), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1645), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1645), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1648), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1648), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1651), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1651), "" });

            migrationBuilder.UpdateData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1653), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(1653), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8785), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8786), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8807), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8807), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8811), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8811), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8814), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8814), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8817), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8817), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8820), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8821), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8824), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8824), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8827), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8828), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8833), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8833), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8837), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8838), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8840), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8841), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8843), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8843), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8846), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8846), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8849), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8849), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8852), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8852), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8855), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8855), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8860), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8860), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8863), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8863), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8865), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8866), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8868), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8868), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8871), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8871), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8874), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8874), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8877), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8877), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8879), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8880), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8884), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8884), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8887), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8887), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8890), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8891), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8894), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8894), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8897), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8897), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8900), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8900), "" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8903), "", new DateTime(2025, 5, 6, 17, 45, 51, 325, DateTimeKind.Utc).AddTicks(8903), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3381), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3382), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3394), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3394), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3398), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3398), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3401), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3401), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3404), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3405), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3407), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3408), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3410), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3411), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3413), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3413), "" });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3416), "", new DateTime(2025, 5, 6, 17, 45, 51, 326, DateTimeKind.Utc).AddTicks(3416), "" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1872), "", new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1873), "" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1881), "", new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1881), "" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1884), "", new DateTime(2025, 5, 6, 17, 45, 51, 327, DateTimeKind.Utc).AddTicks(1884), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5218), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5219), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5229), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5229), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5233), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5234), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5238), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5238), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5259), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5259), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5263), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5263), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5266), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5266), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5269), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5270), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5273), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5273), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5276), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5276), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5279), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5279), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5283), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5283), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5289), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5289), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5292), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5292), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5295), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5295), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5298), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5299), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5302), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5302), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5305), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5306), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5309), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5309), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5312), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5312), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5318), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5318), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5321), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5322), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5325), "", new DateTime(2025, 5, 6, 17, 45, 51, 323, DateTimeKind.Utc).AddTicks(5325), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(6830), "", new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(6831), "" });

            migrationBuilder.UpdateData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(9005), "", new DateTime(2025, 5, 6, 17, 45, 51, 356, DateTimeKind.Utc).AddTicks(9006), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8872), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8875), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8888), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8889), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8893), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8893), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8910), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8911), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8914), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8915), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8937), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8938), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8941), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8942), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8945), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8945), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8948), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8949), "" });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8952), "", new DateTime(2025, 5, 6, 17, 45, 51, 351, DateTimeKind.Utc).AddTicks(8952), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6188), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6189), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6200), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6200), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6204), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6204), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6216), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6216), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6220), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6220), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6224), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6225), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6229), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6229), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6233), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6233), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6237), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6237), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6240), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6240), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6244), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6244), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6251), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6251), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6254), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6254), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6258), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6258), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6262), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6262), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6265), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6266), "" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6269), "", new DateTime(2025, 5, 6, 17, 45, 51, 352, DateTimeKind.Utc).AddTicks(6269), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3176), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3177), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3184), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3185), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3195), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3195), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3198), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3199), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3201), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3202), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3204), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3205), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3208), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3208), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3211), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3211), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3214), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3214), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3216), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3217), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3222), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3223), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3225), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3226), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3228), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3229), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3231), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3231), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3235), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3235), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3238), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3238), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3241), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3241), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3244), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3244), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3249), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3250), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3253), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3253), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3256), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3257), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3260), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3260), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3263), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3263), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3267), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3267), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3270), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3271), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3274), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3274), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3280), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3280), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3283), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3283), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3285), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3286), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3288), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3289), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3291), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3292), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3294), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3294), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3297), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3297), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3301), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3301), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3306), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3306), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3309), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3309), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3312), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3312), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3315), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3315), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3317), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3318), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3320), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3321), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3323), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3323), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3326), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3326), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3331), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3332), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3334), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3334), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3337), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3337), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3340), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3340), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3342), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3343), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3345), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3346), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3348), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3348), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3351), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3351), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3356), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3356), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3359), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3359), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3362), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3362), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3365), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3366), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3369), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3369), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3371), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3372), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3374), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3374), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3377), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3377), "" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3382), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(3382), "" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8008), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8009), "" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8015), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8015), "" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8019), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8019), "" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8022), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8022), "" });

            migrationBuilder.UpdateData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8025), "", new DateTime(2025, 5, 6, 17, 45, 51, 353, DateTimeKind.Utc).AddTicks(8026), "" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "DateEnd", "DateStart", "Modified", "ModifiedBy" },
                values: new object[] { new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2449), "", new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2439), new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2438), new DateTime(2025, 5, 6, 17, 45, 51, 354, DateTimeKind.Utc).AddTicks(2450), "" });
        }
    }
}
