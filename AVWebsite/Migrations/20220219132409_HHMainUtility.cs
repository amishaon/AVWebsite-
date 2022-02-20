using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace AVWebsite.Migrations
{
    public partial class HHMainUtility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Subtitle = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Subtitle = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HHCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HHPackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Inclusion = table.Column<string>(type: "text", nullable: true),
                    Exclusion = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    UnitPrice = table.Column<float>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaximumPersion = table.Column<int>(type: "int", nullable: true),
                    MinimumPerson = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "text", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHPackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HHPackages_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HHTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HolidayHomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FeatureImage = table.Column<string>(type: "text", nullable: true),
                    FeaturePrice = table.Column<string>(type: "text", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true),
                    Hightlights = table.Column<string>(type: "text", nullable: true),
                    FullDescription = table.Column<string>(type: "text", nullable: true),
                    Lat = table.Column<float>(type: "float", nullable: true),
                    Long = table.Column<float>(type: "float", nullable: true),
                    AverageRating = table.Column<float>(type: "float", nullable: true),
                    PrimaryLocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayHomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HolidayHomes_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HolidayHomes_Locations_PrimaryLocationId",
                        column: x => x.PrimaryLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Inclusion = table.Column<string>(type: "text", nullable: true),
                    Exclusion = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    UnitPrice = table.Column<float>(type: "float", nullable: false),
                    RoomSize = table.Column<string>(type: "text", nullable: true),
                    Bed = table.Column<string>(type: "text", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaximumPersion = table.Column<int>(type: "int", nullable: false),
                    MinimumPerson = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HHPackages_GalleryId",
                table: "HHPackages",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHomes_GalleryId",
                table: "HolidayHomes",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHomes_PrimaryLocationId",
                table: "HolidayHomes",
                column: "PrimaryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_GalleryId",
                table: "Rooms",
                column: "GalleryId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "HHCategories");

            migrationBuilder.DropTable(
                name: "HHPackages");

            migrationBuilder.DropTable(
                name: "HHTypes");

            migrationBuilder.DropTable(
                name: "HolidayHomes");

            migrationBuilder.DropTable(
                name: "RoomAmenities");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
