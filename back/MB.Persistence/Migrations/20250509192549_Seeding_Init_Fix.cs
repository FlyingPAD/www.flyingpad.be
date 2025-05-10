using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MB.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Init_Fix : Migration
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
                name: "Name",
                table: "Tasks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "05/09/2025 21:25:47",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 11:26:36");

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9810), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9848), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9863), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9871), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9873), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9801), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9805), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9881), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9886), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9888), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9891), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9893), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9895), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9901), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9903), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9913), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9925), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "AchievementDefinitions",
                keyColumn: "EntityId",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9927), new DateTime(2025, 5, 9, 19, 25, 47, 48, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 50, DateTimeKind.Utc).AddTicks(969), new DateTime(2025, 5, 9, 19, 25, 47, 50, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4638), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4662), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4779), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4784), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4787), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4793), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "LeagueDefinitions",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4815), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9059), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9069), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9072), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9077), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "LevelDefinitions",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9080), new DateTime(2025, 5, 9, 19, 25, 47, 65, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(196), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(219), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(223), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(227), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(230), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(234), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8295), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8299), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8308), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8311), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8314), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8333), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8337), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8340), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8343), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8345), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8349), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8352), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8355), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8360), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8363), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "EntityId",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8365), new DateTime(2025, 5, 9, 19, 25, 47, 105, DateTimeKind.Utc).AddTicks(8366) });
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
                defaultValue: "05/09/2025 11:26:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "05/09/2025 21:25:47");

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

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Pseudonym" },
                values: new object[,]
                {
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000002"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1655), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1656), "Administrator", "/ Unknown 2D Animator", "" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000003"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1660), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1660), "Administrator", "/ Unknown 2D Illustrator", "" },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000004"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1664), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1664), "Administrator", "/ Unknown 3D Animator", "" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000005"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1667), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1667), "Administrator", "/ Unknown 3D Sculptor", "" },
                    { 6, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000006"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1670), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1670), "Administrator", "/ Unknown A.I. User", "" },
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000007"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1683), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1683), "Administrator", "/ Unknown Musician", "" },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000008"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1686), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1686), "Administrator", "/ Unknown Photographer", "" },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000009"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1689), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1689), "Administrator", "/ Unknown Sculptor", "" },
                    { 10, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000010"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1692), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1692), "Administrator", "/ Unknown Videast", "" },
                    { 11, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000011"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1694), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1695), "Administrator", "/ Unknown Writer", "" },
                    { 12, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000012"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1697), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1697), "Administrator", "Flying PAD", "" },
                    { 13, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000013"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1700), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1700), "Administrator", "Soën9048", "" },
                    { 14, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000014"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1703), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1703), "Administrator", "CohesivePanda", "" },
                    { 15, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000015"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1721), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1722), "Administrator", "Nobuo Uematsu", "" },
                    { 16, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000016"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1725), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1725), "Administrator", "Eichiro Oda", "" },
                    { 17, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000017"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1728), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1728), "Administrator", "Masashi Kishimoto", "" },
                    { 18, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000018"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1731), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1731), "Administrator", "Dali", "" },
                    { 19, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000019"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1734), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1734), "Administrator", "Yoko Shimomura", "" },
                    { 20, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000020"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1737), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1737), "Administrator", "Michael Jackson", "" },
                    { 21, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000021"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1740), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1740), "Administrator", "CG5", "" },
                    { 22, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000022"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1743), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1743), "Administrator", "TryHardNinja", "" },
                    { 23, new Guid("aaaaaaaa-bbbb-cccc-dddd-000000000023"), new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1748), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 899, DateTimeKind.Utc).AddTicks(1748), "Administrator", "Jacob Collier", "" }
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1926), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1930), "Administrator", "Flying PAD" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1944), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1944), "Administrator", "Street Fighter" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1949), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 906, DateTimeKind.Utc).AddTicks(1949), "Administrator", "# Unrelated Franchise" }
                });

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

            migrationBuilder.InsertData(
                table: "LinkCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa32"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3470), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3471), "Administrator", "Audio" },
                    { 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa33"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3478), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3478), "Administrator", "Audio | Mix & Master" },
                    { 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa34"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3482), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3482), "Administrator", "Audio | Sound Design" },
                    { 4, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa35"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3487), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3487), "Administrator", "Books" },
                    { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa36"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3491), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3492), "Administrator", "Books | Harmony" },
                    { 6, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa37"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3494), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3494), "Administrator", "Software" },
                    { 7, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa38"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3497), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3497), "Administrator", "Software | D.A.W." },
                    { 8, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa39"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3507), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3507), "Administrator", "Software | V.S.T." },
                    { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa40"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3510), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3510), "Administrator", "Software | Music Notation" },
                    { 10, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa41"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3513), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3513), "Administrator", "Tools" },
                    { 11, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa42"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3516), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3516), "Administrator", "Tools | Global" },
                    { 12, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa43"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3518), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3519), "Administrator", "YouTube" },
                    { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa44"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3535), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3535), "Administrator", "YouTube | Artists" },
                    { 14, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa45"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3538), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3538), "Administrator", "YouTube | Audio" },
                    { 15, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa46"), new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3540), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 911, DateTimeKind.Utc).AddTicks(3541), "Administrator", "YouTube | Piano & Keys" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(943), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(945), "Administrator", "KVR", "https://www.kvraudio.com/" },
                    { 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(954), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(954), "Administrator", "MuseScore", "https://musescore.com/" },
                    { 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(958), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(958), "Administrator", "Native Instruments", "https://www.native-instruments.com" },
                    { 4, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(961), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(962), "Administrator", "Steinberg", "https://www.steinberg.net/" },
                    { 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(966), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(966), "Administrator", "Clés pour l'harmonie", "http://www.jo-anger-weller.com/102/cles-pour-lharmonie/" },
                    { 6, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa6"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(969), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(969), "Administrator", "Google | Metronome", "https://www.google.com/search?q=metronome" },
                    { 7, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa7"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(972), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(972), "Administrator", "Google | Stopwatch", "https://www.google.com/search?q=stopwatch" },
                    { 8, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa8"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(975), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(975), "Administrator", "Google | Timer", "https://www.google.com/search?q=timer" },
                    { 9, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa9"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(980), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(980), "Administrator", "Mangold Project", "https://www.youtube.com/@MangoldProject" },
                    { 10, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(983), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(983), "Administrator", "# YouTube", "https://www.youtube.com" },
                    { 11, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(986), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(986), "Administrator", "Piano Jazz Concept", "https://www.youtube.com/@Pianojazzconcept" },
                    { 12, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa12"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(989), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(989), "Administrator", "Rick Beato", "https://www.youtube.com/@RickBeato" },
                    { 13, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa13"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1005), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1005), "Administrator", "Pianote", "https://www.youtube.com/@PianoteOfficial" },
                    { 14, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa14"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1008), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1008), "Administrator", "TryHardNinja", "https://www.youtube.com/@TryHardNinja" },
                    { 15, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1011), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1012), "Administrator", "Kyle Allen Music", "https://www.youtube.com/@KyleAllenMusic" },
                    { 16, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa16"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1015), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1015), "Administrator", "Ableton", "https://www.youtube.com/@Ableton" },
                    { 17, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa17"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1020), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1020), "Administrator", "La Machine à Mixer", "https://www.youtube.com/@lamachineamixer" },
                    { 18, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa18"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1023), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1023), "Administrator", "Audiofanzine", "https://www.youtube.com/@audiofanzine" },
                    { 19, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa19"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1026), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1026), "Administrator", "Cubase", "https://www.youtube.com/@Cubase" },
                    { 20, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1029), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1029), "Administrator", "Ten Second Songs", "https://www.youtube.com/@TenSecondSongs" },
                    { 21, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1031), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1032), "Administrator", "The Piano Guys", "https://www.youtube.com/@thepianoguys" },
                    { 22, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa22"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1034), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1034), "Administrator", "CG5", "https://www.youtube.com/@CG5" },
                    { 23, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa23"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1037), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1038), "Administrator", "Native Instruments", "https://www.youtube.com/@NativeInstruments" },
                    { 24, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa24"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1040), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1040), "Administrator", "Ken Tamplin Vocal Academy", "https://www.youtube.com/@kentamplin" },
                    { 25, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa25"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1046), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1046), "Administrator", "Pentatonix", "https://www.youtube.com/@PTXofficial" },
                    { 26, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa26"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1048), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1049), "Administrator", "Recording Revolution", "https://www.youtube.com/@recordingrevolution" },
                    { 27, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa27"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1051), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1051), "Administrator", "Jacob Collier", "https://www.youtube.com/@jacobcollier" },
                    { 28, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa28"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1054), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1054), "Administrator", "Orchestration Online", "https://www.youtube.com/@OrchestrationOnline" },
                    { 29, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1057), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1057), "Administrator", "Nuendo", "https://www.youtube.com/@Nuendo" },
                    { 30, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa30"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1060), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1060), "Administrator", "reFX", "https://www.youtube.com/@reFXaudio" },
                    { 31, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa31"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1063), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(1064), "Administrator", "Steinberg", "https://www.youtube.com/@steinberg" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee4"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5635), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5636), "Administrator", "# Unrelated" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee5"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5648), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5649), "Administrator", "# Unknown" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee6"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5652), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5652), "Administrator", "# Super Franchise" },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee7"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5655), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5655), "Administrator", "TV" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee8"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5661), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5661), "Administrator", "Radio" },
                    { 6, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee9"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5664), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5664), "Administrator", "YouTube" },
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeea"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5667), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5667), "Administrator", "Capcom" },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeeb"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5670), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5670), "Administrator", "Square-Enix" },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeec"), new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5673), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 912, DateTimeKind.Utc).AddTicks(5673), "Administrator", "Flying PAD" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "FirstName", "Gender", "LastName", "Modified", "ModifiedBy", "Pseudonym" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee1"), new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3895), "Administrator", "", "", "", "", new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3896), "Administrator", "# Unknown Model" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee2"), new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3903), "Administrator", "", "", "", "", new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3904), "Administrator", "# Unrelated Model" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee3"), new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3907), "Administrator", "", "Tony", "M", "Van Langenhove", new DateTime(2025, 5, 9, 9, 26, 36, 913, DateTimeKind.Utc).AddTicks(3907), "Administrator", "Flying PAD" }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Extension", "Height", "Modified", "ModifiedBy", "Name", "Score", "Size", "Type", "Width" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-0000-0000-0000-000000000001"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7058), "Administrator", "In Chords Chart", "jpg", 510, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7061), "Administrator", "Major Key Notes", 0, 61206, 1, 359 },
                    { 2, new Guid("aaaaaaaa-0000-0000-0000-000000000002"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7074), "Administrator", "7 Notes, 7 Positions", "jpg", 940, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7074), "Administrator", "Major Diatonic Scales", 0, 136462, 1, 700 },
                    { 3, new Guid("aaaaaaaa-0000-0000-0000-000000000003"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7079), "Administrator", "Fundamental Positions", "jpg", 1361, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7079), "Administrator", "Piano Chords", 0, 562138, 1, 868 },
                    { 4, new Guid("aaaaaaaa-0000-0000-0000-000000000004"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7083), "Administrator", "5 Notes, 5 Positions", "jpg", 524, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7084), "Administrator", "Pentatonic Scales", 0, 74358, 1, 250 },
                    { 5, new Guid("aaaaaaaa-0000-0000-0000-000000000005"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7106), "Administrator", "Color Measure", "png", 844, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7106), "Administrator", "Intervals", 0, 56324, 1, 556 },
                    { 6, new Guid("aaaaaaaa-0000-0000-0000-000000000006"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7113), "Administrator", "Absolute Basics", "png", 255, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7113), "Administrator", "Time Measure", 0, 8992, 1, 400 },
                    { 7, new Guid("aaaaaaaa-0000-0000-0000-000000000007"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7117), "Administrator", "Natural Order", "webp", 226, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7117), "Administrator", "Harmonics", 0, 30964, 1, 600 },
                    { 8, new Guid("aaaaaaaa-0000-0000-0000-000000000008"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7120), "Administrator", "Communication is important", "png", 705, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7121), "Administrator", "Guitar Vocabulary", 0, 99994, 1, 512 },
                    { 9, new Guid("aaaaaaaa-0000-0000-0000-000000000009"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7124), "Administrator", "Diatonic Chords in C Major", "jpg", 1317, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7124), "Administrator", "Piano Chords (Diatonic C Major)", 0, 204898, 1, 1199 },
                    { 10, new Guid("aaaaaaaa-0000-0000-0000-00000000000a"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7127), "Administrator", "Mmm... You can tell, right ?", "jpg", 900, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7127), "Administrator", "Piano Scales", 0, 91482, 1, 695 },
                    { 11, new Guid("aaaaaaaa-0000-0000-0000-00000000000b"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7130), "Administrator", "Overview", "gif", 709, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7131), "Administrator", "Tessitures", 0, 62391, 1, 1026 },
                    { 12, new Guid("aaaaaaaa-0000-0000-0000-00000000000c"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7134), "Administrator", "Circle of Life", "png", 950, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7134), "Administrator", "Chord Wheel", 0, 663017, 1, 950 },
                    { 13, new Guid("aaaaaaaa-0000-0000-0000-00000000000d"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7140), "Administrator", "...", "jpeg", 480, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7140), "Administrator", "The Mix is Almost Perfect", 0, 45254, 1, 640 },
                    { 14, new Guid("aaaaaaaa-0000-0000-0000-00000000000e"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7143), "Administrator", "Basic Chords / Different Keys", "jpg", 690, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7143), "Administrator", "Guitar Progressions", 0, 167969, 1, 552 },
                    { 15, new Guid("aaaaaaaa-0000-0000-0000-00000000000f"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7147), "Administrator", "Les 3, c'est NON !", "jpeg", 960, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7147), "Administrator", "Vous le voulez comment votre projet ?", 0, 205144, 1, 720 },
                    { 16, new Guid("aaaaaaaa-0000-0000-0000-000000000010"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7150), "Administrator", "1, 2, 3, 4, 5", "jpg", 233, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7150), "Administrator", "Fingers Numerotation", 0, 24030, 1, 350 },
                    { 17, new Guid("aaaaaaaa-0000-0000-0000-000000000011"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7153), "Administrator", "My actual Keyboard", "jpg", 368, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7154), "Administrator", "Roland FP-30", 0, 87596, 1, 1680 },
                    { 18, new Guid("aaaaaaaa-0000-0000-0000-000000000012"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7156), "Administrator", "How to build a chord", "jpg", 1109, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7157), "Administrator", "Chord Formula's", 0, 221030, 1, 1080 },
                    { 19, new Guid("aaaaaaaa-0000-0000-0000-000000000013"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7160), "Administrator", "Valeurs de Temps", "webp", 530, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7160), "Administrator", "Time Values", 0, 21922, 1, 640 },
                    { 20, new Guid("aaaaaaaa-0000-0000-0000-000000000014"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7163), "Administrator", "Fundamental Positions", "jpg", 909, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7164), "Administrator", "Guitar Chords (B)", 0, 57447, 1, 640 },
                    { 21, new Guid("aaaaaaaa-0000-0000-0000-000000000015"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7169), "Administrator", "Primary Modes", "jpg", 1552, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7169), "Administrator", "Modes starting in C", 0, 111187, 1, 1199 },
                    { 22, new Guid("aaaaaaaa-0000-0000-0000-000000000016"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7172), "Administrator", "Good luck finding the good one ...", "jpg", 1913, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7173), "Administrator", "Guitar Chords", 0, 633229, 1, 1200 },
                    { 23, new Guid("aaaaaaaa-0000-0000-0000-000000000017"), new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7176), "Administrator", "Une approche parmi tant d'autres", "png", 971, new DateTime(2025, 5, 9, 9, 26, 36, 909, DateTimeKind.Utc).AddTicks(7177), "Administrator", "Intervalles", 0, 69313, 1, 692 }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Duration", "Extension", "Video_Height", "Modified", "ModifiedBy", "Name", "Score", "Video_Size", "Type", "Video_Width" },
                values: new object[] { 55, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc55"), new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(6038), "Administrator", "Bendy & The Ink Machine", 64, "mp4", 360, new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(6040), "Administrator", "BATIM - Build our Machine", 0, 5091239, 2, 640 });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Extension", "Modified", "ModifiedBy", "Name", "Score", "Type", "Url" },
                values: new object[] { 85, new Guid("cccccccc-cccc-cccc-cccc-cccccccccc85"), new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(9182), "Administrator", "...", "", new DateTime(2025, 5, 9, 9, 26, 36, 945, DateTimeKind.Utc).AddTicks(9184), "Administrator", "Mario Bros 3 Cover", 0, 4, "WWUxrTdjqg0" });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000001"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3784), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3788), "Administrator", "2D" },
                    { 2, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000002"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3803), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3804), "Administrator", "2D Animation" },
                    { 3, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000003"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3810), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3810), "Administrator", "3D" },
                    { 4, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000004"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3815), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3815), "Administrator", "3D Animation" },
                    { 5, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000005"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3822), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3822), "Administrator", "Architecture" },
                    { 6, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000006"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3827), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3827), "Administrator", "Writer" },
                    { 7, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000007"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3831), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3832), "Administrator", "Music" },
                    { 8, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000008"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3836), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3837), "Administrator", "Photo" },
                    { 9, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000009"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3846), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3847), "Administrator", "Video" },
                    { 10, new Guid("bbbbbbbb-bbbb-cccc-dddd-000000000010"), new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3852), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 938, DateTimeKind.Utc).AddTicks(3852), "Administrator", "Video Games" }
                });

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

            migrationBuilder.InsertData(
                table: "TagCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 7, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee7"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3859), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3860), "Administrator", "# File Render" },
                    { 8, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee8"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3866), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3866), "Administrator", "Music Genre" },
                    { 9, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee9"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3870), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3871), "Administrator", "Music Theory" },
                    { 10, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee10"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3875), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3875), "Administrator", "Keys" },
                    { 11, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee11"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3880), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3881), "Administrator", "Brass" },
                    { 12, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee12"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3886), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3886), "Administrator", "Strings" },
                    { 13, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee13"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3890), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3891), "Administrator", "Percussions" },
                    { 14, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee14"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3896), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3897), "Administrator", "Woodwinds" },
                    { 15, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee15"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3906), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3907), "Administrator", "Audio" },
                    { 16, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee16"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3912), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3912), "Administrator", "Fun" },
                    { 17, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee17"), new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3916), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 939, DateTimeKind.Utc).AddTicks(3917), "Administrator", "Guitar" }
                });

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

            migrationBuilder.InsertData(
                table: "TaskCategories",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee18"), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(960), "Administrator", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(961), "Administrator", "PAD Mobile" },
                    { 2, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee19"), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(970), "Administrator", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(970), "Administrator", "PAD Cave" },
                    { 3, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee20"), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(983), "Administrator", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(984), "Administrator", "PAD Kids" },
                    { 4, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee21"), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1005), "Administrator", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1006), "Administrator", "Shopping" },
                    { 5, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee22"), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1010), "Administrator", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(1010), "Administrator", "Work" }
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
                table: "RMoodTag",
                columns: new[] { "MoodId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 1, 10 },
                    { 1, 17 },
                    { 2, 1 },
                    { 2, 4 },
                    { 2, 10 },
                    { 2, 17 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 10 },
                    { 3, 17 },
                    { 4, 1 },
                    { 4, 4 },
                    { 4, 10 },
                    { 4, 17 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 11 },
                    { 5, 17 },
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 11 },
                    { 6, 15 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 12 },
                    { 7, 15 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 11 },
                    { 8, 17 },
                    { 9, 1 },
                    { 9, 4 },
                    { 9, 10 },
                    { 9, 17 },
                    { 10, 1 },
                    { 10, 4 },
                    { 10, 10 },
                    { 10, 17 },
                    { 11, 1 },
                    { 11, 4 },
                    { 11, 8 },
                    { 11, 15 },
                    { 12, 1 },
                    { 12, 4 },
                    { 12, 11 },
                    { 12, 19 },
                    { 13, 1 },
                    { 13, 4 },
                    { 13, 9 },
                    { 13, 15 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 10 },
                    { 14, 17 },
                    { 15, 1 },
                    { 15, 4 },
                    { 15, 9 },
                    { 15, 17 },
                    { 16, 1 },
                    { 16, 4 },
                    { 16, 10 },
                    { 16, 15 },
                    { 17, 1 },
                    { 17, 4 },
                    { 17, 10 },
                    { 17, 15 },
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
                    { 21, 1 },
                    { 21, 4 },
                    { 21, 10 },
                    { 21, 15 },
                    { 22, 1 },
                    { 22, 4 },
                    { 22, 10 },
                    { 22, 17 },
                    { 23, 1 },
                    { 23, 4 },
                    { 23, 11 },
                    { 23, 17 },
                    { 55, 1 },
                    { 55, 15 },
                    { 55, 16 },
                    { 85, 1 },
                    { 85, 15 },
                    { 85, 16 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name", "TagCategoryId" },
                values: new object[,]
                {
                    { 20, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee20"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4108), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4108), "Administrator", "2D", 7 },
                    { 21, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee21"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4113), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4113), "Administrator", "2D | Anim", 7 },
                    { 22, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee22"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4124), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4124), "Administrator", "3D", 7 },
                    { 23, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee23"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4129), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4129), "Administrator", "3D | Anim", 7 },
                    { 24, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee24"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4133), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4134), "Administrator", "Photo", 7 },
                    { 25, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee25"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4139), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4139), "Administrator", "Photo | Anim", 7 },
                    { 26, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee26"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4143), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4144), "Administrator", "E.D.M.", 8 },
                    { 27, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee27"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4149), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4150), "Administrator", "Jazz", 8 },
                    { 28, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee28"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4154), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4154), "Administrator", "Metal", 8 },
                    { 29, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee29"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4159), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4159), "Administrator", "Orchestral", 8 },
                    { 30, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee30"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4167), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4168), "Administrator", "Pop Music", 8 },
                    { 31, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee31"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4191), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4192), "Administrator", "Rap", 8 },
                    { 32, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee32"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4196), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4196), "Administrator", "Rock", 8 },
                    { 33, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee33"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4201), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4201), "Administrator", "Traditional", 8 },
                    { 34, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee34"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4205), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4206), "Administrator", "# Music Theory", 9 },
                    { 35, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee35"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4209), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4210), "Administrator", "# Harmony", 9 },
                    { 36, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee36"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4215), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4215), "Administrator", "Chords", 9 },
                    { 37, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee37"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4220), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4220), "Administrator", "Harmonics", 9 },
                    { 38, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee38"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4227), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4228), "Administrator", "Intervals", 9 },
                    { 39, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee39"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4231), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4232), "Administrator", "Rythm", 9 },
                    { 40, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee40"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4235), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4235), "Administrator", "Scales", 9 },
                    { 41, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee41"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4240), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4241), "Administrator", "Modes", 9 },
                    { 42, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee42"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4245), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4246), "Administrator", "# Keys", 10 },
                    { 43, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee43"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4249), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4249), "Administrator", "Piano", 10 },
                    { 44, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee44"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4256), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4256), "Administrator", "# Brass", 11 },
                    { 45, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee45"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4261), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4261), "Administrator", "Trombone", 11 },
                    { 46, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee46"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4270), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4270), "Administrator", "# Strings", 12 },
                    { 47, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee47"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4275), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4275), "Administrator", "Violin", 12 },
                    { 48, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee48"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4279), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4280), "Administrator", "# Percussions", 13 },
                    { 49, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee49"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4283), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4284), "Administrator", "Drums", 13 },
                    { 50, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee50"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4288), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4288), "Administrator", "# Woodwinds", 14 },
                    { 51, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee51"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4292), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4292), "Administrator", "Clarinet", 14 },
                    { 52, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee52"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4296), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4296), "Administrator", "# Audio", 15 },
                    { 53, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee53"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4300), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4300), "Administrator", "Mixing", 15 },
                    { 54, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee54"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4307), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4308), "Administrator", "Mastering", 15 },
                    { 55, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee55"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4312), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4312), "Administrator", "Recording", 15 },
                    { 56, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee56"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4316), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4317), "Administrator", "Production", 15 },
                    { 57, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee57"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4320), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4321), "Administrator", "Sound Design", 15 },
                    { 58, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee58"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4325), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4325), "Administrator", "Memes", 16 },
                    { 59, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee59"), new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4329), "Administrator", "", new DateTime(2025, 5, 9, 9, 26, 36, 940, DateTimeKind.Utc).AddTicks(4329), "Administrator", "# Guitar", 17 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "EntityId", "BusinessId", "Created", "CreatedBy", "DateEnd", "DateStart", "Description", "Modified", "ModifiedBy", "Name", "TaskCategoryId" },
                values: new object[] { 1, new Guid("aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeee23"), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7278), "Administrator", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7263), new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7261), "", new DateTime(2025, 5, 9, 9, 26, 36, 941, DateTimeKind.Utc).AddTicks(7278), "Administrator", "Check Mails", 5 });

            migrationBuilder.InsertData(
                table: "RMoodTag",
                columns: new[] { "MoodId", "TagId" },
                values: new object[,]
                {
                    { 1, 34 },
                    { 2, 34 },
                    { 2, 59 },
                    { 3, 34 },
                    { 3, 43 },
                    { 4, 34 },
                    { 4, 59 },
                    { 5, 34 },
                    { 6, 34 },
                    { 7, 34 },
                    { 8, 34 },
                    { 8, 59 },
                    { 9, 34 },
                    { 9, 43 },
                    { 10, 34 },
                    { 10, 43 },
                    { 11, 34 },
                    { 12, 34 },
                    { 13, 58 },
                    { 14, 59 },
                    { 16, 43 },
                    { 17, 43 },
                    { 20, 59 },
                    { 22, 59 },
                    { 55, 43 },
                    { 85, 43 }
                });
        }
    }
}
