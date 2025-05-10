using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Gamification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "RArtistStyle",
                keyColumns: new[] { "ArtistId", "StyleId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "RFranchiseMedia",
                keyColumns: new[] { "FranchiseId", "MediaId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RFranchiseMedia",
                keyColumns: new[] { "FranchiseId", "MediaId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "RFranchiseMedia",
                keyColumns: new[] { "FranchiseId", "MediaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RFranchiseModel",
                keyColumns: new[] { "FranchiseId", "ModelId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RFranchiseModel",
                keyColumns: new[] { "FranchiseId", "ModelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 17 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 24 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 25 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 14, 26 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 27 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 13, 27 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 28 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "RLinkCategory",
                keyColumns: new[] { "LinkCategoryId", "LinkId" },
                keyValues: new object[] { 12, 31 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RMoodArtist",
                keyColumns: new[] { "ArtistId", "MoodId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RMoodModel",
                keyColumns: new[] { "ModelId", "MoodId" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 6, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 7, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 8, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 9, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 10, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 11, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 12, 34 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 13, 58 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 14, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 16, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 17, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 20, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 21, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 22, 59 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 11 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 55, 43 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 15 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 16 });

            migrationBuilder.DeleteData(
                table: "RMoodTag",
                keyColumns: new[] { "MoodId", "TagId" },
                keyValues: new object[] { 85, 43 });

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LinkCategories",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "EntityId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "EntityId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TaskCategories",
                keyColumn: "EntityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "LeagueDefinitionId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeasonId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/06/2025 07:00:23",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "04/30/2025 14:10:52");

            migrationBuilder.CreateTable(
                name: "AchievementDefinitions",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoneMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    XpReward = table.Column<int>(type: "int", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementDefinitions", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "LevelDefinitions",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelNumber = table.Column<int>(type: "int", nullable: false),
                    MinExperience = table.Column<int>(type: "int", nullable: false),
                    MaxExperience = table.Column<int>(type: "int", nullable: true),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelDefinitions", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AchievementDefinitionId = table.Column<int>(type: "int", nullable: false),
                    UnlockedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_UserAchievements_AchievementDefinitions_AchievementDefinitionId",
                        column: x => x.AchievementDefinitionId,
                        principalTable: "AchievementDefinitions",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeagueDefinitions",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinExperience = table.Column<int>(type: "int", nullable: false),
                    MaxExperience = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IconCssClass = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SeasonId = table.Column<int>(type: "int", nullable: true),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueDefinitions", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_LeagueDefinitions_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AchievementDefinitions",
                columns: new[] { "EntityId", "BusinessId", "Category", "Created", "CreatedBy", "DoneMessage", "Goal", "IconUrl", "Modified", "ModifiedBy", "Title", "XpReward" },
                values: new object[,]
                {
                    { 1, new Guid("20000000-0000-0000-0000-000000000001"), "standard", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6222), "", "You created an account :)", "Create an account", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6225), "", "Official Member", 50 },
                    { 2, new Guid("20000000-0000-0000-0000-000000000002"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6251), "", "You lasted 10 sec. !!", "Survive 10 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6251), "", "Novice (bass)", 50 },
                    { 3, new Guid("20000000-0000-0000-0000-000000000003"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6255), "", "You lasted 20 sec. !!", "Survive 20 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6255), "", "Intermediate (bass)", 50 },
                    { 4, new Guid("20000000-0000-0000-0000-000000000004"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6258), "", "You lasted 30 sec. !!", "Survive 30 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6258), "", "Advanced (bass)", 50 },
                    { 5, new Guid("20000000-0000-0000-0000-000000000005"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6279), "", "You lasted 40 sec. !!", "Survive 40 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6279), "", "Expert (bass)", 50 },
                    { 6, new Guid("20000000-0000-0000-0000-000000000006"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6283), "", "You lasted 50 sec. !!", "Survive 50 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6283), "", "Master (bass)", 50 },
                    { 7, new Guid("20000000-0000-0000-0000-000000000007"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6286), "", "You lasted 10 sec. !!", "Survive 10 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6286), "", "Novice (alto)", 50 },
                    { 8, new Guid("20000000-0000-0000-0000-000000000008"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6290), "", "You lasted 20 sec. !!", "Survive 20 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6290), "", "Intermediate (alto)", 50 },
                    { 9, new Guid("20000000-0000-0000-0000-000000000009"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6292), "", "You lasted 30 sec. !!", "Survive 30 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6292), "", "Advanced (alto)", 50 },
                    { 10, new Guid("20000000-0000-0000-0000-000000000010"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6295), "", "You lasted 40 sec. !!", "Survive 40 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6295), "", "Expert (alto)", 50 },
                    { 11, new Guid("20000000-0000-0000-0000-000000000011"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6297), "", "You lasted 50 sec. !!", "Survive 50 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6297), "", "Master (alto)", 50 },
                    { 12, new Guid("20000000-0000-0000-0000-000000000012"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6301), "", "You lasted 10 sec. !!", "Survive 10 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6301), "", "Novice (treble)", 50 },
                    { 13, new Guid("20000000-0000-0000-0000-000000000013"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6306), "", "You lasted 20 sec. !!", "Survive 20 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6306), "", "Intermediate (treble)", 50 },
                    { 14, new Guid("20000000-0000-0000-0000-000000000014"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6308), "", "You lasted 30 sec. !!", "Survive 30 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6309), "", "Advanced (treble)", 50 },
                    { 15, new Guid("20000000-0000-0000-0000-000000000015"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6408), "", "You lasted 40 sec. !!", "Survive 40 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6408), "", "Expert (treble)", 50 },
                    { 16, new Guid("20000000-0000-0000-0000-000000000016"), "note-master", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6411), "", "You lasted 50 sec. !!", "Survive 50 seconds.", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6411), "", "Master (treble)", 50 },
                    { 17, new Guid("20000000-0000-0000-0000-000000000017"), "standard", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6243), "", "Your email is verified!", "Verify your email address", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6243), "", "Email Verified", 50 },
                    { 18, new Guid("20000000-0000-0000-0000-000000000018"), "standard", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6247), "", "Your profile is complete!", "Complete your profile (add name, birthdate, avatar)", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6248), "", "Profile Completed", 75 },
                    { 19, new Guid("20000000-0000-0000-0000-000000000019"), "level", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6413), "", "You reached level 2!", "Reach level 2", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6414), "", "Level 2 Achieved", 100 },
                    { 20, new Guid("20000000-0000-0000-0000-000000000020"), "level", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6416), "", "You reached level 3!", "Reach level 3", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6416), "", "Level 3 Achieved", 150 },
                    { 21, new Guid("20000000-0000-0000-0000-000000000021"), "level", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6418), "", "You reached level 4!", "Reach level 4", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6418), "", "Level 4 Achieved", 200 },
                    { 22, new Guid("20000000-0000-0000-0000-000000000022"), "level", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6420), "", "You reached level 5!", "Reach level 5", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6421), "", "Level 5 Achieved", 250 },
                    { 23, new Guid("20000000-0000-0000-0000-000000000023"), "level", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6425), "", "You reached level 6!", "Reach level 6", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6426), "", "Level 6 Achieved", 300 },
                    { 24, new Guid("20000000-0000-0000-0000-000000000024"), "level", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6428), "", "You reached level 7!", "Reach level 7", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6428), "", "Level 7 Achieved", 350 },
                    { 25, new Guid("20000000-0000-0000-0000-000000000025"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6430), "", "You’re now in Wood league!", "Be promoted to Wood league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6431), "", "Wood League", 50 },
                    { 26, new Guid("20000000-0000-0000-0000-000000000026"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6433), "", "You’re now in Stone league!", "Be promoted to Stone league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6433), "", "Stone League", 100 },
                    { 27, new Guid("20000000-0000-0000-0000-000000000027"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6436), "", "You’re now in Bronze league!", "Be promoted to Bronze league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6437), "", "Bronze League", 150 },
                    { 28, new Guid("20000000-0000-0000-0000-000000000028"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6439), "", "You’re now in Silver league!", "Be promoted to Silver league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6440), "", "Silver League", 200 },
                    { 29, new Guid("20000000-0000-0000-0000-000000000029"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6442), "", "You’re now in Crystal league!", "Be promoted to Crystal league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6442), "", "Crystal League", 250 },
                    { 30, new Guid("20000000-0000-0000-0000-000000000030"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6445), "", "You’re now in Elite league!", "Be promoted to Elite league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6445), "", "Elite League", 300 },
                    { 31, new Guid("20000000-0000-0000-0000-000000000031"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6450), "", "You’re now in Champion league!", "Be promoted to Champion league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6450), "", "Champion League", 350 },
                    { 32, new Guid("20000000-0000-0000-0000-000000000032"), "league", new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6453), "", "You’re now in Legend league!", "Be promoted to Legend league", null, new DateTime(2025, 5, 6, 5, 0, 23, 341, DateTimeKind.Utc).AddTicks(6453), "", "Legend League", 400 }
                });

            migrationBuilder.InsertData(
                table: "LeagueDefinitions",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "IconCssClass", "MaxExperience", "MinExperience", "Modified", "ModifiedBy", "Name", "Order", "SeasonId" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000101"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7176), "", "league-wood", 99, 0, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7180), "", "Wood", 1, null },
                    { 2, new Guid("00000000-0000-0000-0000-000000000102"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7194), "", "league-stone", 199, 100, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7194), "", "Stone", 2, null },
                    { 3, new Guid("00000000-0000-0000-0000-000000000103"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7198), "", "league-bronze", 299, 200, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7198), "", "Bronze", 3, null },
                    { 4, new Guid("00000000-0000-0000-0000-000000000104"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7201), "", "league-silver", 399, 300, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7201), "", "Silver", 4, null },
                    { 5, new Guid("00000000-0000-0000-0000-000000000105"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7204), "", "league-crystal", 499, 400, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7204), "", "Crystal", 5, null },
                    { 6, new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7206), "", "league-elite", 599, 500, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7206), "", "Elite", 6, null },
                    { 7, new Guid("00000000-0000-0000-0000-000000000107"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7226), "", "league-champion", 699, 600, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7226), "", "Champion", 7, null },
                    { 8, new Guid("00000000-0000-0000-0000-000000000108"), new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7228), "", "league-legend", null, 700, new DateTime(2025, 5, 6, 5, 0, 23, 351, DateTimeKind.Utc).AddTicks(7229), "", "Legend", 8, null }
                });

            migrationBuilder.InsertData(
                table: "LevelDefinitions",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "LevelNumber", "MaxExperience", "MinExperience", "Modified", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1108), "", 1, 99, 0, new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1109), "" },
                    { 2, new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1117), "", 2, 199, 100, new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1117), "" },
                    { 3, new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1120), "", 3, 399, 200, new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1121), "" },
                    { 4, new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1123), "", 4, 699, 400, new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1124), "" },
                    { 5, new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1126), "", 5, 999, 700, new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1126), "" },
                    { 6, new Guid("10000000-0000-0000-0000-000000000006"), new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1128), "", 6, null, 1000, new DateTime(2025, 5, 6, 5, 0, 23, 352, DateTimeKind.Utc).AddTicks(1128), "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LeagueDefinitionId",
                table: "Users",
                column: "LeagueDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SeasonId",
                table: "Users",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueDefinitions_SeasonId",
                table: "LeagueDefinitions",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementDefinitionId",
                table: "UserAchievements",
                column: "AchievementDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_UserId",
                table: "UserAchievements",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_LeagueDefinitions_LeagueDefinitionId",
                table: "Users",
                column: "LeagueDefinitionId",
                principalTable: "LeagueDefinitions",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Seasons_SeasonId",
                table: "Users",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_LeagueDefinitions_LeagueDefinitionId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Seasons_SeasonId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "LeagueDefinitions");

            migrationBuilder.DropTable(
                name: "LevelDefinitions");

            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "AchievementDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_Users_LeagueDefinitionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SeasonId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LeagueDefinitionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SeasonId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "04/30/2025 14:10:52",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/06/2025 07:00:23");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Pseudonym" },
                values: new object[,]
                {
                    { 1, new Guid("ebaf98a7-4467-40a3-a85d-de4545cfbfb2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4963), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4964), "", "# Unknown Artist", "" },
                    { 2, new Guid("e969e3ca-1fa1-4540-a466-28e913c1d109"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4975), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4975), "", "/ Unknown 2D Animator", "" },
                    { 3, new Guid("5fcd5207-2502-4054-bc0c-a511528ed492"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4977), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4978), "", "/ Unknown 2D Illustrator", "" },
                    { 4, new Guid("6ef8bdda-a72e-4124-ba1e-3cb8f1b25889"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4997), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4997), "", "/ Unknown 3D Animator", "" },
                    { 5, new Guid("307be23a-5728-44cd-86ff-8d0f26d34884"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(4999), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5000), "", "/ Unknown 3D Sculptor", "" },
                    { 6, new Guid("f9a25710-ea8f-4750-b557-eb0f6e6607ec"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5004), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5004), "", "/ Unknown A.I. User", "" },
                    { 7, new Guid("345b784f-86fb-4327-a589-41b09adffefb"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5006), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5007), "", "/ Unknown Musician", "" },
                    { 8, new Guid("bf654060-e680-42de-9aec-35169353c26f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5011), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5012), "", "/ Unknown Photographer", "" },
                    { 9, new Guid("0179f86a-09f8-46ab-9f2f-ff1102166471"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5014), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5014), "", "/ Unknown Sculptor", "" },
                    { 10, new Guid("232153f3-38c7-43b7-b069-86bc65d0f948"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5017), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5017), "", "/ Unknown Videast", "" },
                    { 11, new Guid("17bd1b78-adcc-4e99-bb03-dd1485f2dd92"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5019), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5019), "", "/ Unknown Writer", "" },
                    { 12, new Guid("9067fc89-245f-4a97-9eec-3457ce3cad70"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5024), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5024), "", "Flying PAD", "" },
                    { 13, new Guid("f2f6f368-338d-418b-b151-cca396e0ca0d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5026), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5026), "", "Soën9048", "" },
                    { 14, new Guid("1ae25e6b-83cd-4cee-acae-f9ee5333a02c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5039), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5040), "", "CohesivePanda", "" },
                    { 15, new Guid("761794b0-28fb-41f9-888a-3658e247d229"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5049), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5049), "", "Nobuo Uematsu", "" },
                    { 16, new Guid("e20b07ee-68f6-4aa3-aee9-391baff7cbfd"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5053), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5054), "", "Eichiro Oda", "" },
                    { 17, new Guid("9701327d-f5e3-4234-98e2-dea1c8844ef0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5056), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5056), "", "Masashi Kishimoto", "" },
                    { 18, new Guid("61eec827-8c7f-45b8-938f-2785cd05c98b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5059), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5060), "", "Dali", "" },
                    { 19, new Guid("0639529c-d836-4cbb-8b5e-80f7ba819e64"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5062), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5062), "", "Yoko Shimomura", "" },
                    { 20, new Guid("44822889-0676-4ed7-9c7d-415b9bad8f73"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5066), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5066), "", "Michael Jackson", "" },
                    { 21, new Guid("a2605bf1-4d88-4b9f-b101-b3e953e66642"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5068), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5069), "", "CG5", "" },
                    { 22, new Guid("99fc4192-ae48-45d1-b2e0-3089998e8812"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5071), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5071), "", "TryHardNinja", "" },
                    { 23, new Guid("6a5f61ef-0b2b-4305-915f-b9e74694e3b7"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5074), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5074), "", "Jacob Collier", "" }
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("0a3cf2fc-d88a-4c01-9029-a46a9f6f81a5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5486), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5487), "", "Flying PAD" },
                    { 2, new Guid("45cb54e2-cbba-4c3b-8a36-a76fb56608cf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5493), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5494), "", "Street Fighter" },
                    { 3, new Guid("b91e90a0-1d80-4bd6-94f7-694ba3f4081d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5548), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5549), "", "# Unrelated Franchise" }
                });

            migrationBuilder.InsertData(
                table: "LinkCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("6494cb9f-81e0-4bd5-ab33-0546ebe42910"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6102), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6103), "", "Audio" },
                    { 2, new Guid("5f5e0cdd-8df7-4638-a03c-7a5dce1679da"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6109), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6109), "", "Audio | Mix & Master" },
                    { 3, new Guid("e0658f12-8326-491f-bf26-c9d40e374390"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6111), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6112), "", "Audio | Sound Design" },
                    { 4, new Guid("d8d7276e-7d9f-4ce1-8d76-9144174fdb2d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6118), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6118), "", "Books" },
                    { 5, new Guid("b1bd3297-9cfd-42c5-8332-91fa9ab8fa8b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6120), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6120), "", "Books | Harmony" },
                    { 6, new Guid("8bd9fca3-a6da-4d57-a4ce-35aefdd18e74"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6124), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6124), "", "Software" },
                    { 7, new Guid("de20f5ea-bbd9-4473-bb0f-d85053a62071"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6126), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6126), "", "Software | D.A.W." },
                    { 8, new Guid("20d5cf3a-e4af-43bd-b40d-b21708d9acb4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6130), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6131), "", "Software | V.S.T." },
                    { 9, new Guid("3f83cd95-a4c1-4f73-9ad9-ef63d6e2fbfc"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6133), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6133), "", "Software | Music Notation" },
                    { 10, new Guid("7c571268-8386-4c2d-986e-8a1d68e0edac"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6136), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6136), "", "Tools" },
                    { 11, new Guid("266e032e-e01b-418b-be0c-8438eb955603"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6138), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6138), "", "Tools | Global" },
                    { 12, new Guid("e8df7311-020e-4871-a1df-7d70d8d4732a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6142), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6143), "", "YouTube" },
                    { 13, new Guid("1f042609-f59f-4bf8-9296-78c11b849f9b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6145), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6145), "", "YouTube | Artists" },
                    { 14, new Guid("edecf290-9f5b-428a-9466-07bafef39de8"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6147), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6147), "", "YouTube | Audio" },
                    { 15, new Guid("43832c4b-a273-4947-b694-8bc1dd87fdc9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6149), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6149), "", "YouTube | Piano & Keys" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("017b8836-4064-4671-b997-d89e395f3c60"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5864), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5865), "", "KVR", "https://www.kvraudio.com/" },
                    { 2, new Guid("88e8b749-9256-4d33-94d2-d8e957c53c32"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5871), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5872), "", "MuseScore", "https://musescore.com/" },
                    { 3, new Guid("ad94a6e0-20cf-4411-a2ec-fcbe15b36a8c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5877), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5877), "", "Native Instruments", "https://www.native-instruments.com" },
                    { 4, new Guid("046ad1f9-a16d-447d-b7e3-6cdab3a764df"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5879), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5880), "", "Steinberg", "https://www.steinberg.net/" },
                    { 5, new Guid("a6e2b824-f39a-4bfd-adbf-145962b4892c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5882), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5882), "", "Clés pour l'harmonie", "http://www.jo-anger-weller.com/102/cles-pour-lharmonie/" },
                    { 6, new Guid("2feb45b5-75bc-47cd-b483-4a24bf09a4e0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5886), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5886), "", "Google | Metronome", "https://www.google.com/search?q=metronome" },
                    { 7, new Guid("bb87ba9d-5dae-4942-bec9-2a065bf044cf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5890), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5891), "", "Google | Stopwatch", "https://www.google.com/search?q=stopwatch" },
                    { 8, new Guid("e3802d4b-884e-44e0-b080-bb44c30f357b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5894), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5894), "", "Google | Timer", "https://www.google.com/search?q=timer" },
                    { 9, new Guid("01cb67b1-6d49-4923-9991-95ab642e6e35"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5896), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5896), "", "Mangold Project", "https://www.youtube.com/@MangoldProject" },
                    { 10, new Guid("fd2ed02d-1d03-4e11-931b-6c3e0c00a035"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5899), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5899), "", "# YouTube", "https://www.youtube.com" },
                    { 11, new Guid("d8efef12-ba07-4350-a5d5-29561617f753"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5904), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5904), "", "Piano Jazz Concept", "https://www.youtube.com/@Pianojazzconcept" },
                    { 12, new Guid("4d52e83e-9d6b-4176-aa8a-a834d84120e4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5906), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5906), "", "Rick Beato", "https://www.youtube.com/@RickBeato" },
                    { 13, new Guid("c0f6e3b2-7bdf-4f2a-823f-6d5f26d57fe3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5909), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5909), "", "Pianote", "https://www.youtube.com/@PianoteOfficial" },
                    { 14, new Guid("5829e1e8-9cd8-4e1d-87e2-d3b17ea9db64"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5911), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5911), "", "TryHardNinja", "https://www.youtube.com/@TryHardNinja" },
                    { 15, new Guid("b3e73fcd-52da-4cd3-9993-ee5108b6050a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5916), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5916), "", "Kyle Allen Music", "https://www.youtube.com/@KyleAllenMusic" },
                    { 16, new Guid("7db42c0d-3410-4a4d-9ab0-47c5aa8f071c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5918), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5918), "", "Ableton", "https://www.youtube.com/@Ableton" },
                    { 17, new Guid("2ebe5aa4-8aba-4dae-9e08-d9f5138b909e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5920), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5920), "", "La Machine à Mixer", "https://www.youtube.com/@lamachineamixer" },
                    { 18, new Guid("145d4b6e-f7e5-4c33-98cd-c6f5da8d5cdb"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5923), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5924), "", "Audiofanzine", "https://www.youtube.com/@audiofanzine" },
                    { 19, new Guid("67645337-c66c-4746-a0b4-d77c93504763"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5928), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5928), "", "Cubase", "https://www.youtube.com/@Cubase" },
                    { 20, new Guid("0712b32a-2a4f-4b9a-862f-6e3ea8af3a1d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5930), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5931), "", "Ten Second Songs", "https://www.youtube.com/@TenSecondSongs" },
                    { 21, new Guid("a61b1fa7-688d-4377-8de3-77ac5f7154ec"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5933), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5933), "", "The Piano Guys", "https://www.youtube.com/@thepianoguys" },
                    { 22, new Guid("a86a1197-bc04-46d1-84cf-e08f8e7b30d1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5935), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5935), "", "CG5", "https://www.youtube.com/@CG5" },
                    { 23, new Guid("de099225-3f62-43e6-bf99-62f86d0a3778"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5940), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5940), "", "Native Instruments", "https://www.youtube.com/@NativeInstruments" },
                    { 24, new Guid("04191d65-dc86-462f-88d3-ad98656f3781"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5942), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5942), "", "Ken Tamplin Vocal Academy", "https://www.youtube.com/@kentamplin" },
                    { 25, new Guid("e2be0724-fb74-43fa-889b-206e3fe06bd1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5944), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5945), "", "Pentatonix", "https://www.youtube.com/@PTXofficial" },
                    { 26, new Guid("ea6cc5bd-4f13-48a1-8ba4-fb5948554cc3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5947), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5947), "", "Recording Revolution", "https://www.youtube.com/@recordingrevolution" },
                    { 27, new Guid("bb850514-8f18-457a-9159-d25cccc63ada"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5952), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5952), "", "Jacob Collier", "https://www.youtube.com/@jacobcollier" },
                    { 28, new Guid("3883a284-18b1-4b54-9d88-a48a97887f80"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5954), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5954), "", "Orchestration Online", "https://www.youtube.com/@OrchestrationOnline" },
                    { 29, new Guid("c133fb44-1c05-45fd-b9bc-be520c99f26e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5957), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5957), "", "Nuendo", "https://www.youtube.com/@Nuendo" },
                    { 30, new Guid("b2fa80ae-d59e-4927-9c88-fec4cbf15f06"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5960), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5960), "", "reFX", "https://www.youtube.com/@reFXaudio" },
                    { 31, new Guid("d76bb936-adf0-4667-90be-f609f26b7fc6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5965), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5965), "", "Steinberg", "https://www.youtube.com/@steinberg" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("122921ca-c747-4648-9ff7-66fb5e6a020b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5629), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5630), "", "# Unrelated" },
                    { 2, new Guid("2bd2e43f-2af9-4cc1-a0dd-c5a8c67f5cb2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5635), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5635), "", "# Unknown" },
                    { 3, new Guid("bba6c7e1-c4cc-4e94-8fcc-e79a2588a00e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5637), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5638), "", "# Super Franchise" },
                    { 4, new Guid("03a598b3-21a5-4e9b-b929-dc02c30cfa9e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5643), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5644), "", "TV" },
                    { 5, new Guid("5bf6093a-7f31-40b0-a778-d1792bcc529e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5646), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5646), "", "Radio" },
                    { 6, new Guid("baa90002-2cd2-4454-b9bd-8451d0c20520"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5650), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5650), "", "YouTube" },
                    { 7, new Guid("6aca3308-8e6e-4ea1-8ed9-366be6b00d69"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5652), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5652), "", "Capcom" },
                    { 8, new Guid("89d91921-3571-44b1-931b-51372aa5aa06"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5656), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5657), "", "Square-Enix" },
                    { 9, new Guid("0c7f0510-8912-45b5-9441-eae79b599d9f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5659), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5659), "", "Flying PAD" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "FirstName", "Gender", "LastName", "Modified", "ModifiedBy", "Pseudonym" },
                values: new object[,]
                {
                    { 1, new Guid("63e1981b-1a37-4fd2-a28e-f60cb3f89142"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6359), "", "", "", "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6360), "", "# Unknown Model" },
                    { 2, new Guid("f509e20f-261f-4e41-8b88-aed26edc2acf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6366), "", "", "", "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6366), "", "# Unrelated Model" },
                    { 3, new Guid("87cab1d4-5cd9-40fa-8518-98931ca8007c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6369), "", "", "Tony", "M", "Van Langenhove", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6370), "", "Flying PAD" }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Extension", "Height", "Modified", "ModifiedBy", "Name", "Score", "Size", "Type", "Width" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6432), "", "In Chords Chart", "jpg", 510, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6433), "", " Major Key Notes", 0, 61206, 1, 359 },
                    { 2, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6455), "", "7 Notes, 7 Positions", "jpg", 940, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6456), "", "Major Diatonic Scales", 0, 136462, 1, 700 },
                    { 3, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6461), "", "Fundamental Positions", "jpg", 1361, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6461), "", "Piano Chords", 0, 562138, 1, 868 },
                    { 4, new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6464), "", "5 Notes, 5 Positions", "jpg", 524, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6464), "", "Pentatonic Scales", 0, 74358, 1, 250 },
                    { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6468), "", "Color Measure", "png", 844, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6468), "", "Intervals", 0, 56324, 1, 556 },
                    { 6, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6516), "", "Absolute Basics", "png", 255, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6517), "", "Time Measure", 0, 8992, 1, 400 },
                    { 7, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6521), "", "Natural Order", "webp", 226, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6522), "", "Harmonics", 0, 30964, 1, 600 },
                    { 8, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6524), "", "Communication is important", "png", 705, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6525), "", "Guitar Vocabulary", 0, 99994, 1, 512 },
                    { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6528), "", "Diatonic Chords in C Major", "jpg", 1317, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6529), "", "Piano Chords", 0, 204898, 1, 1199 },
                    { 10, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6536), "", "Mmm... You can tell, right ?", "jpg", 900, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6536), "", "Piano Scales", 0, 91482, 1, 695 },
                    { 11, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6540), "", "Overview", "gif", 709, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6540), "", "Tessitures", 0, 62391, 1, 1026 },
                    { 12, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6544), "", "Circle of Life", "png", 950, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6544), "", "Chord Wheel", 0, 663017, 1, 950 },
                    { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6547), "", " ... ", "jpeg", 480, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6548), "", "The Mix is Almost Perfect", 0, 45254, 1, 640 },
                    { 14, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6551), "", "Basic Chords / Different Keys", "jpg", 690, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6552), "", "Guitar Progressions", 0, 167969, 1, 552 },
                    { 15, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6555), "", "Les 3, c'est NON !", "jpeg", 960, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6555), "", "Vous le voulez comment votre projet ?", 0, 205144, 1, 720 },
                    { 16, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6558), "", "1, 2, 3, 4, 5", "jpg", 233, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6558), "", "Fingers Numerotation", 0, 24030, 1, 350 },
                    { 17, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6560), "", "My actual Keyboard", "jpg", 368, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6561), "", "Roland FP-30", 0, 87596, 1, 1680 },
                    { 18, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6568), "", "How to build a chord", "jpg", 1109, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6569), "", "Chord Formula's", 0, 221030, 1, 1080 },
                    { 19, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6572), "", "Valeurs de Temps", "webp", 530, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6572), "", "Time Values", 0, 21922, 1, 640 },
                    { 20, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6574), "", "Fundamental Positions", "jpg", 909, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6575), "", "Guitar Chords ( B )", 0, 57447, 1, 640 },
                    { 21, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6577), "", "Primary Modes", "jpg", 1552, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6577), "", "Modes starting in C", 0, 111187, 1, 1199 },
                    { 22, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6580), "", "Good luck finding the good one ...", "jpg", 1913, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6580), "", "Guitar Chords", 0, 633229, 1, 1200 },
                    { 23, new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6583), "", "Une approche parmis tant d'autres", "png", 971, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6583), "", "Intervalles", 0, 69313, 1, 692 }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Duration", "Extension", "Video_Height", "Modified", "ModifiedBy", "Name", "Score", "Video_Size", "Type", "Video_Width" },
                values: new object[] { 55, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc55"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6692), "", " Bendy & The Ink Machine ", 64, "mp4", 360, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6693), "", "BATIM - Build our Machine", 0, 5091239, 2, 640 });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Extension", "Modified", "ModifiedBy", "Name", "Score", "Type", "Url" },
                values: new object[] { 85, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc85"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6771), "", "...", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(6772), "", "Mario Bros 3 Cover", 0, 4, "WWUxrTdjqg0" });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("a49abb93-b691-473f-bc92-9bdf6129c10c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5290), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5290), "", "2D" },
                    { 2, new Guid("e321ca1e-4c98-4904-8318-5dd586208b55"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5296), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5296), "", "2D Animation" },
                    { 3, new Guid("84b0d32f-d6ac-4823-9a88-d834ac47b83e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5299), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5299), "", "3D" },
                    { 4, new Guid("8f1cf5b2-ef0d-4958-9894-32919b681f71"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5301), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5301), "", "3D Animation" },
                    { 5, new Guid("bd92cbca-14e8-4d85-b05f-b8ab4c1d80c3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5307), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5307), "", "Architecture" },
                    { 6, new Guid("02ba23e0-4e24-4c6a-b530-3e39a607fc2b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5310), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5310), "", "Writer" },
                    { 7, new Guid("24d52a54-17f4-45c3-b57d-0cd6ae71f673"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5313), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5313), "", "Music" },
                    { 8, new Guid("87493f45-017c-4249-a669-d8ff322883bf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5315), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5315), "", "Photo" },
                    { 9, new Guid("3d6643a1-7e73-4804-bc75-d2b1424a4d40"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5319), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5320), "", "Video" },
                    { 10, new Guid("614b8193-a6ff-46d3-91ac-1aaa4a18aba1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5323), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(5323), "", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "TagCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("4e746816-97ee-49f5-9a52-819b998e6bfe"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7762), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7763), "", "#" },
                    { 2, new Guid("1c0e61cd-7a58-446a-b5a5-86a3f1dd39bc"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7771), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7771), "", "# File" },
                    { 3, new Guid("8ba1e26e-da85-49a3-96f3-7534561ddc12"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7774), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7774), "", "# File ext. | Doc." },
                    { 4, new Guid("9e325fa5-4e0f-4eca-af3b-ebef9001c54d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7776), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7777), "", "# File ext. | Image" },
                    { 5, new Guid("35458084-ec33-4b05-ae1c-9fc04ca9524e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7779), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7779), "", "# File ext. | Video" },
                    { 6, new Guid("b44040b1-0ec3-45cb-bf93-b504cbc587db"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7785), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7785), "", "# File Format" },
                    { 7, new Guid("fa24bfdd-e589-4b39-b5e3-46fcb2fb20f9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7787), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7787), "", "# File Render" },
                    { 8, new Guid("b4c9cdef-88f3-42ec-9009-c6db6596fd8d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7789), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7790), "", "Music Genre" },
                    { 9, new Guid("96bc8164-62b0-4310-89e4-5b29b21ef61c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7792), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7792), "", "Music Theory" },
                    { 10, new Guid("694174c2-3266-4894-bd6e-a47a3cb930ae"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7797), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7798), "", "Keys" },
                    { 11, new Guid("ae176893-ec6b-40fd-9c0d-8d7b62aa54a4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7800), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7800), "", "Brass" },
                    { 12, new Guid("16cc55eb-50a7-49a2-a895-ec91870b1bef"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7803), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7803), "", "Strings" },
                    { 13, new Guid("03469936-70ef-4e4b-bc9c-517f753efd2f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7805), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7805), "", "Percussions" },
                    { 14, new Guid("1cc3e413-03d9-4b7d-b42e-35d56d959f9e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7810), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7810), "", "Woodwinds" },
                    { 15, new Guid("0aaea2ab-0768-4426-ba09-187ba9b6c4e3"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7812), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7812), "", "Audio" },
                    { 16, new Guid("6996a956-a4d4-4939-83a0-a590e146794e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7815), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7815), "", "Fun" },
                    { 17, new Guid("aa677a45-4c0c-44de-a901-16a17493b5b7"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7817), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7817), "", "Guitar" }
                });

            migrationBuilder.InsertData(
                table: "TaskCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("6ac7e1f7-c5b6-4c88-b320-bf0bac4b7c5f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7898), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7899), "", "PAD Mobile" },
                    { 2, new Guid("69741af4-f72d-4f43-a0a7-493ea6ab0435"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7904), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7904), "", "PAD Cave" },
                    { 3, new Guid("d678fa1f-6d3c-46ea-a7cc-762071ef9c58"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7950), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7950), "", "PAD Kids" },
                    { 4, new Guid("22b5a7ce-df7d-4d62-874a-4d9231de2cc1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7953), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7953), "", "Shopping" },
                    { 5, new Guid("e9a20f4b-c623-4438-8a2d-1bddec6bfd0f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7958), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7959), "", "Work" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EntityId", "Birthdate", "BusinessId", "Created", "CreatedBy", "Email", "Experience", "FirstName", "IsEmailVerified", "LastName", "Level", "Modified", "ModifiedBy", "PasswordHash", "PasswordSalt", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1982, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("09a4d57a-ec9e-4e0a-926a-df492cac8520"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8545), "", "tonyvan@live.fr", 0, "Tony", false, "Van Langenhove", 1, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8547), "", new byte[] { 37, 110, 206, 90, 139, 85, 200, 57, 180, 250, 148, 94, 25, 164, 7, 113, 100, 222, 64, 83, 207, 162, 0, 57, 213, 26, 122, 55, 6, 55, 3, 3, 56, 173, 128, 132, 90, 4, 2, 39, 151, 203, 74, 45, 237, 124, 17, 102, 209, 36, 231, 99, 254, 174, 180, 86, 253, 12, 252, 112, 95, 135, 137, 229 }, new byte[] { 189, 34, 18, 113, 248, 103, 113, 157, 225, 82, 10, 115, 13, 134, 96, 27, 89, 123, 198, 241, 227, 64, 233, 1, 171, 233, 46, 255, 134, 156, 182, 30, 248, 235, 146, 189, 93, 214, 84, 87, 122, 216, 4, 232, 227, 75, 132, 105, 210, 20, 181, 110, 35, 146, 16, 226, 55, 3, 139, 91, 212, 241, 198, 135, 35, 246, 185, 3, 71, 12, 66, 175, 206, 27, 245, 184, 122, 72, 153, 238, 10, 130, 120, 25, 240, 202, 220, 90, 118, 113, 48, 195, 183, 88, 62, 195, 189, 26, 45, 105, 41, 128, 203, 143, 125, 155, 93, 22, 4, 189, 110, 187, 37, 218, 132, 179, 247, 46, 86, 232, 165, 249, 236, 129, 150, 241, 162, 16 }, 2, "" },
                    { 2, new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0dc9665f-58a5-432a-a663-dda1e991cef2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8651), "", "floppy@gmail.com", 0, "Floppy", false, "Disk", 1, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8651), "", new byte[] { 49, 153, 240, 253, 109, 70, 9, 215, 50, 221, 46, 244, 237, 110, 187, 173, 145, 252, 81, 62, 222, 204, 153, 50, 103, 136, 127, 245, 2, 0, 241, 29, 104, 115, 109, 172, 232, 85, 145, 127, 11, 16, 101, 233, 61, 232, 40, 250, 149, 148, 34, 221, 117, 55, 49, 245, 246, 178, 189, 14, 28, 17, 123, 170 }, new byte[] { 1, 75, 177, 2, 44, 210, 236, 55, 162, 98, 209, 193, 210, 185, 69, 175, 138, 229, 159, 146, 60, 213, 133, 65, 65, 236, 238, 203, 86, 207, 64, 77, 22, 1, 198, 56, 191, 247, 225, 108, 108, 245, 98, 38, 55, 169, 171, 85, 90, 214, 87, 226, 233, 21, 51, 74, 23, 56, 27, 32, 52, 248, 199, 0, 238, 31, 89, 46, 194, 122, 60, 165, 189, 234, 61, 6, 231, 21, 48, 182, 220, 237, 172, 198, 60, 223, 242, 104, 18, 171, 124, 44, 57, 211, 182, 7, 83, 242, 50, 191, 37, 29, 253, 179, 75, 107, 38, 215, 171, 24, 50, 54, 22, 70, 113, 205, 137, 182, 101, 16, 103, 10, 1, 136, 11, 129, 59, 129 }, 1, "" },
                    { 3, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c955d393-acb9-41b1-a642-9b78ce0e97ff"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8738), "", "vincent.megag@gmail.com", 0, "Vincent", false, "Megag", 1, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8738), "", new byte[] { 75, 15, 75, 114, 10, 156, 93, 226, 131, 140, 222, 144, 35, 22, 63, 6, 192, 158, 101, 185, 51, 4, 163, 94, 63, 128, 123, 200, 204, 170, 189, 246, 160, 29, 5, 111, 36, 138, 85, 237, 106, 223, 13, 149, 64, 29, 93, 251, 202, 25, 66, 231, 211, 156, 62, 101, 243, 31, 37, 55, 73, 232, 137, 112 }, new byte[] { 201, 87, 241, 108, 194, 65, 210, 58, 172, 94, 186, 189, 183, 213, 31, 154, 158, 113, 18, 249, 220, 197, 50, 112, 3, 159, 118, 18, 162, 136, 224, 48, 110, 241, 203, 116, 120, 61, 114, 220, 227, 55, 140, 136, 168, 168, 80, 62, 155, 33, 18, 117, 212, 72, 167, 188, 41, 72, 110, 187, 178, 252, 255, 115, 246, 173, 194, 222, 49, 170, 22, 59, 105, 217, 182, 122, 168, 93, 211, 42, 54, 242, 243, 134, 10, 72, 81, 27, 122, 196, 187, 204, 191, 40, 69, 142, 253, 174, 198, 10, 177, 76, 247, 214, 188, 190, 87, 80, 8, 192, 33, 86, 167, 77, 166, 86, 152, 77, 166, 123, 230, 156, 172, 77, 9, 175, 208, 224 }, 2, "" },
                    { 4, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16594ac-2bb5-4d5d-a477-ce342cddd7b5"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8821), "", "test@test.com", 0, "Admin", false, "...", 1, new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8821), "", new byte[] { 26, 205, 151, 164, 64, 60, 163, 48, 27, 212, 232, 4, 192, 110, 134, 189, 131, 29, 247, 94, 236, 90, 248, 206, 199, 126, 102, 62, 141, 107, 159, 106, 173, 199, 207, 25, 103, 118, 254, 184, 114, 147, 206, 81, 162, 82, 17, 64, 23, 139, 210, 243, 200, 242, 238, 105, 26, 34, 169, 94, 228, 179, 187, 227 }, new byte[] { 179, 64, 32, 168, 240, 181, 158, 114, 154, 215, 169, 209, 161, 241, 246, 201, 164, 156, 205, 33, 200, 126, 51, 141, 186, 41, 217, 80, 188, 109, 30, 159, 27, 187, 184, 138, 205, 86, 180, 219, 227, 208, 66, 223, 216, 215, 169, 5, 10, 223, 170, 117, 47, 151, 6, 141, 231, 155, 98, 200, 57, 108, 141, 54, 28, 26, 189, 123, 74, 207, 210, 142, 197, 151, 45, 45, 53, 20, 35, 117, 113, 179, 202, 48, 4, 39, 140, 192, 40, 40, 58, 58, 67, 32, 62, 222, 92, 28, 132, 153, 235, 216, 5, 13, 98, 88, 249, 36, 202, 113, 59, 71, 134, 153, 116, 151, 211, 87, 135, 66, 167, 253, 187, 29, 238, 110, 213, 19 }, 2, "" }
                });

            migrationBuilder.InsertData(
                table: "RArtistStyle",
                columns: new[] { "ArtistId", "StyleId" },
                values: new object[,]
                {
                    { 12, 7 },
                    { 12, 9 },
                    { 13, 9 },
                    { 14, 9 },
                    { 15, 9 },
                    { 16, 6 },
                    { 17, 6 },
                    { 18, 1 },
                    { 19, 2 },
                    { 20, 7 },
                    { 21, 7 },
                    { 22, 7 },
                    { 23, 7 }
                });

            migrationBuilder.InsertData(
                table: "RFranchiseMedia",
                columns: new[] { "FranchiseId", "MediaId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 2, 7 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "RFranchiseModel",
                columns: new[] { "FranchiseId", "ModelId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "RLinkCategory",
                columns: new[] { "LinkCategoryId", "LinkId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 8, 1 },
                    { 6, 2 },
                    { 9, 2 },
                    { 6, 3 },
                    { 8, 3 },
                    { 6, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 12, 9 },
                    { 15, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 15, 11 },
                    { 12, 12 },
                    { 12, 13 },
                    { 12, 14 },
                    { 13, 14 },
                    { 12, 15 },
                    { 12, 16 },
                    { 12, 17 },
                    { 12, 18 },
                    { 12, 19 },
                    { 12, 20 },
                    { 12, 21 },
                    { 12, 22 },
                    { 12, 23 },
                    { 12, 24 },
                    { 12, 25 },
                    { 1, 26 },
                    { 2, 26 },
                    { 12, 26 },
                    { 14, 26 },
                    { 12, 27 },
                    { 13, 27 },
                    { 12, 28 },
                    { 12, 29 },
                    { 12, 30 },
                    { 12, 31 }
                });

            migrationBuilder.InsertData(
                table: "RMoodArtist",
                columns: new[] { "ArtistId", "MoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 12, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 55 },
                    { 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "RMoodModel",
                columns: new[] { "ModelId", "MoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 3, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 55 },
                    { 1, 85 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "TagCategoryId" },
                values: new object[,]
                {
                    { 1, new Guid("294878f6-d163-4563-91a7-3762478c42d1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7405), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7407), "", "# All Files", 1 },
                    { 2, new Guid("4c44ef84-e05a-41cd-b8f9-a1db2fa31d13"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7412), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7412), "", "Audio", 2 },
                    { 3, new Guid("9f2f256e-e6fa-4165-83bb-d3eccba45d40"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7415), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7415), "", "Document", 2 },
                    { 4, new Guid("27ccde90-29ee-443f-8161-f31f4797c342"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7417), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7417), "", "Image", 2 },
                    { 5, new Guid("67127fd2-8ca3-495b-a1ff-300786b272c9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7422), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7422), "", "Video", 2 },
                    { 6, new Guid("2dc49cae-4f61-471c-868b-b145287d7e55"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7425), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7426), "", "*.txt", 3 },
                    { 7, new Guid("18d5f67e-7016-4cc0-9bff-56caf0854d5c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7428), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7428), "", "*.bmp", 4 },
                    { 8, new Guid("e7444f73-9deb-4905-96c2-d48af89d1344"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7430), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7430), "", "*.gif", 4 },
                    { 9, new Guid("be37b8fb-ef4f-418a-98b4-0421541ef37e"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7435), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7435), "", "*.jpeg", 4 },
                    { 10, new Guid("b50677a9-5303-4b30-a146-c568a6ba4f64"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7439), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7440), "", "*.jpg", 4 },
                    { 11, new Guid("b1491f7a-39ce-494a-8c42-bd2cee250866"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7442), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7442), "", "*.png", 4 },
                    { 12, new Guid("a4732c0a-4970-403d-ae04-4330d2c542f6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7445), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7445), "", "*.webp", 4 },
                    { 13, new Guid("128fd1ab-8427-41c2-b833-035c6e1c842f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7449), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7449), "", "*.mp4", 5 },
                    { 14, new Guid("6312124e-6f31-4b7a-b6c9-6830661b231c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7451), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7452), "", "*.webm", 5 },
                    { 15, new Guid("a38d0044-9c3f-4cf2-8095-a7352949bc83"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7454), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7454), "", "Landscape", 6 },
                    { 16, new Guid("9c3b66b8-4463-4f37-8278-23012face1cf"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7456), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7456), "", "Landscape ( 16:9 )", 6 },
                    { 17, new Guid("c19543b6-3fe3-445d-b31d-0abdc553eded"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7460), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7461), "", "Portrait", 6 },
                    { 18, new Guid("4c8cf567-1e5a-4ba3-bd0d-119b40145768"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7464), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7464), "", "Portrait ( 16:9 )", 6 },
                    { 19, new Guid("9fe01c43-2e57-4415-9205-e4b57cabfb43"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7466), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7466), "", "Square", 6 },
                    { 20, new Guid("7a0256c0-fd84-4960-8662-a8e8da9e3334"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7468), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7469), "", "2D", 7 },
                    { 21, new Guid("dbb91a12-a5a2-4e2b-9990-189df67269fd"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7473), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7473), "", "2D | Anim", 7 },
                    { 22, new Guid("a3d5b6c4-0586-432b-9ed3-f4ea3431685b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7475), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7475), "", "3D", 7 },
                    { 23, new Guid("672ba361-7f17-4607-9951-d66dabe9717f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7478), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7478), "", "3D | Anim", 7 },
                    { 24, new Guid("ece3ed27-2c5b-453d-ae62-653048e88ac6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7480), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7480), "", "Photo", 7 },
                    { 25, new Guid("43bffd5f-9243-4225-89bc-e3d09eadc3d7"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7484), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7485), "", "Photo | Anim", 7 },
                    { 26, new Guid("34e4b75f-a38c-47ae-a1d8-1499d9caa55d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7487), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7487), "", "E.D.M.", 8 },
                    { 27, new Guid("43318f5f-d63a-4099-be15-e771dc38f5d6"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7489), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7489), "", "Jazz", 8 },
                    { 28, new Guid("23389ffe-4c14-43aa-a65b-6e9fc5a32b67"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7491), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7492), "", "Metal", 8 },
                    { 29, new Guid("ecfe55a6-af0b-4676-9a19-682c77d533f8"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7496), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7496), "", "Orchestral", 8 },
                    { 30, new Guid("815bd7c9-1946-4545-8911-a491ab82d79d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7498), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7498), "", "Pop Music", 8 },
                    { 31, new Guid("31be778a-bdb0-4b59-9421-e0cc806791d0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7501), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7501), "", "Rap", 8 },
                    { 32, new Guid("3f7c3e44-fa84-4337-ad16-ca84bded3057"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7504), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7504), "", "Rock", 8 },
                    { 33, new Guid("64c3e5b3-c0d8-4bf8-9681-59610af71130"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7508), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7508), "", "Traditional", 8 },
                    { 34, new Guid("88e8e37c-823a-4b84-a853-cdf6f8f3136a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7566), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7566), "", "# Music Theory", 9 },
                    { 35, new Guid("c89aac88-222f-4caa-8386-96f06a738a1b"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7569), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7569), "", "# Harmony", 9 },
                    { 36, new Guid("3761de3f-cacd-4606-8355-c3bea4c55c3c"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7571), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7571), "", "Chords", 9 },
                    { 37, new Guid("ba1b30e7-02a3-47bd-b003-45a51dae5ef9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7576), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7576), "", "Harmonics", 9 },
                    { 38, new Guid("3cb10245-2308-40f1-b5ae-02f35826507a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7578), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7579), "", "Intervals", 9 },
                    { 39, new Guid("bee6e8d6-f32b-42db-a179-91c6d5d6a58a"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7581), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7581), "", "Rythm", 9 },
                    { 40, new Guid("2c756784-6877-4ae2-98ca-909df575e7e0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7583), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7583), "", "Scales", 9 },
                    { 41, new Guid("161b1cb2-ab05-46d9-822a-17778cdb42a0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7587), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7588), "", "Modes", 9 },
                    { 42, new Guid("5c4da291-70a3-4426-9b44-fe826bb9cfe1"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7590), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7590), "", "# Keys", 10 },
                    { 43, new Guid("32295705-b2dc-4d02-971f-a375cdadcb08"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7592), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7592), "", "Piano", 10 },
                    { 44, new Guid("0538bb72-944c-4058-b9ed-0bf9b58deae9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7594), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7595), "", "# Brass", 11 },
                    { 45, new Guid("75cb6e5e-3b03-43a6-bca0-ead160f1df44"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7599), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7599), "", "Trombone", 11 },
                    { 46, new Guid("304a9b6f-01ce-45c9-b30e-9de823c888c2"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7601), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7601), "", "# Strings", 12 },
                    { 47, new Guid("83b6049b-5509-4b98-8cff-104c0bebfe79"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7604), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7604), "", "Violin", 12 },
                    { 48, new Guid("a8d9d544-0d58-4127-8a80-ce2ae2b4b0c4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7606), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7606), "", "# Percussions", 13 },
                    { 49, new Guid("ed3a7f3d-f3d0-423d-9458-bfa59f561250"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7610), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7610), "", "Drums", 13 },
                    { 50, new Guid("05a5b11d-06cc-473e-841f-766af9e7eb28"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7612), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7613), "", "# Woodwinds", 14 },
                    { 51, new Guid("7f3c3a8b-6ffe-4616-b91c-b17e732d8934"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7615), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7615), "", "Clarinet", 14 },
                    { 52, new Guid("9af66a4e-3f0a-46b0-9412-7a961391f52f"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7617), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7617), "", "# Audio", 15 },
                    { 53, new Guid("c2e1e0bb-169c-40ba-8117-3a73b62a0dc4"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7623), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7624), "", "Mixing", 15 },
                    { 54, new Guid("a8248b19-b88c-45df-979e-f8677479b6c9"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7626), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7626), "", "Mastering", 15 },
                    { 55, new Guid("8a8cfc70-95c1-443d-b86e-8c0d5dbd1601"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7628), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7628), "", "Recording", 15 },
                    { 56, new Guid("d829399b-a731-4623-b2dd-d8bbe36bce05"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7630), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7631), "", "Production", 15 },
                    { 57, new Guid("771f6090-6501-4e1b-89de-3340a172b4d0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7635), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7635), "", "Sound Design", 15 },
                    { 58, new Guid("e1c882bc-70fd-4d1a-b2c8-dfae21c7a7c0"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7637), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7637), "", "Memes", 16 },
                    { 59, new Guid("f647235b-73af-473a-ab67-4d066a90409d"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7639), "", "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(7640), "", "# Guitar", 17 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "DateEnd", "DateStart", "Description", "Modified", "ModifiedBy", "Name", "TaskCategoryId" },
                values: new object[] { 1, new Guid("72c6094c-99e7-4ff5-a1d5-3fbf8f43d918"), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8037), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8034), new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8032), "", new DateTime(2025, 4, 30, 12, 10, 52, 893, DateTimeKind.Utc).AddTicks(8037), "", "Check Mails", 5 });

            migrationBuilder.InsertData(
                table: "RMoodTag",
                columns: new[] { "MoodId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 1, 10 },
                    { 1, 17 },
                    { 1, 34 },
                    { 2, 1 },
                    { 2, 4 },
                    { 2, 10 },
                    { 2, 17 },
                    { 2, 34 },
                    { 2, 59 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 10 },
                    { 3, 17 },
                    { 3, 34 },
                    { 3, 43 },
                    { 4, 1 },
                    { 4, 4 },
                    { 4, 10 },
                    { 4, 17 },
                    { 4, 34 },
                    { 4, 59 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 11 },
                    { 5, 17 },
                    { 5, 34 },
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 11 },
                    { 6, 15 },
                    { 6, 34 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 12 },
                    { 7, 15 },
                    { 7, 34 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 11 },
                    { 8, 17 },
                    { 8, 34 },
                    { 8, 59 },
                    { 9, 1 },
                    { 9, 4 },
                    { 9, 10 },
                    { 9, 17 },
                    { 9, 34 },
                    { 9, 43 },
                    { 10, 1 },
                    { 10, 4 },
                    { 10, 10 },
                    { 10, 17 },
                    { 10, 34 },
                    { 10, 43 },
                    { 11, 1 },
                    { 11, 4 },
                    { 11, 8 },
                    { 11, 15 },
                    { 11, 34 },
                    { 12, 1 },
                    { 12, 4 },
                    { 12, 11 },
                    { 12, 19 },
                    { 12, 34 },
                    { 13, 1 },
                    { 13, 4 },
                    { 13, 9 },
                    { 13, 15 },
                    { 13, 58 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 10 },
                    { 14, 17 },
                    { 14, 59 },
                    { 15, 1 },
                    { 15, 4 },
                    { 15, 9 },
                    { 15, 17 },
                    { 16, 1 },
                    { 16, 4 },
                    { 16, 10 },
                    { 16, 15 },
                    { 16, 43 },
                    { 17, 1 },
                    { 17, 4 },
                    { 17, 10 },
                    { 17, 15 },
                    { 17, 43 },
                    { 18, 1 },
                    { 18, 4 },
                    { 18, 10 },
                    { 18, 17 },
                    { 19, 1 },
                    { 19, 4 },
                    { 19, 12 },
                    { 19, 15 },
                    { 20, 1 },
                    { 20, 4 },
                    { 20, 10 },
                    { 20, 17 },
                    { 20, 59 },
                    { 21, 1 },
                    { 21, 4 },
                    { 21, 10 },
                    { 21, 15 },
                    { 22, 1 },
                    { 22, 4 },
                    { 22, 10 },
                    { 22, 17 },
                    { 22, 59 },
                    { 23, 1 },
                    { 23, 4 },
                    { 23, 11 },
                    { 23, 17 },
                    { 55, 1 },
                    { 55, 15 },
                    { 55, 16 },
                    { 55, 43 },
                    { 85, 1 },
                    { 85, 15 },
                    { 85, 16 },
                    { 85, 43 }
                });
        }
    }
}
