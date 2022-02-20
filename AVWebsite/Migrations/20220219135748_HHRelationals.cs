using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace AVWebsite.Migrations
{
    public partial class HHRelationals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AboutId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_About_HHs_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_About_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalService_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdditionalServiceId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalService_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalService_HHs_AdditionalServices_AdditionalServiceId",
                        column: x => x.AdditionalServiceId,
                        principalTable: "AdditionalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalService_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facility_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FacilityId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facility_HHs_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facility_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faq_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TourFaqId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faq_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faq_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faq_HHs_TourFaqs_TourFaqId",
                        column: x => x.TourFaqId,
                        principalTable: "TourFaqs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Features_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FeaturesId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_HHs_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Features_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HHCategory_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HHCategoryId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHCategory_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HHCategory_HHs_HHCategories_HHCategoryId",
                        column: x => x.HHCategoryId,
                        principalTable: "HHCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HHCategory_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HHPackage_Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoomAmenitiesId = table.Column<int>(type: "int", nullable: true),
                    HHPackageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHPackage_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HHPackage_Amenities_HHPackages_HHPackageId",
                        column: x => x.HHPackageId,
                        principalTable: "HHPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HHPackage_Amenities_RoomAmenities_RoomAmenitiesId",
                        column: x => x.RoomAmenitiesId,
                        principalTable: "RoomAmenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HHPackage_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HHPackageId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHPackage_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HHPackage_HHs_HHPackages_HHPackageId",
                        column: x => x.HHPackageId,
                        principalTable: "HHPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HHPackage_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HHType_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HHTypeId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HHType_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HHType_HHs_HHTypes_HHTypeId",
                        column: x => x.HHTypeId,
                        principalTable: "HHTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HHType_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_HHs_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_HHs_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room_HHs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    HolidayHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_HHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_HHs_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_HHs_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room_RoomAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    RoomAmenitiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_RoomAmenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_RoomAmenities_RoomAmenities_RoomAmenitiesId",
                        column: x => x.RoomAmenitiesId,
                        principalTable: "RoomAmenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_RoomAmenities_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_About_HHs_AboutId",
                table: "About_HHs",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_About_HHs_HolidayHomeId",
                table: "About_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalService_HHs_AdditionalServiceId",
                table: "AdditionalService_HHs",
                column: "AdditionalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalService_HHs_HolidayHomeId",
                table: "AdditionalService_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_HHs_FacilityId",
                table: "Facility_HHs",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_HHs_HolidayHomeId",
                table: "Facility_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Faq_HHs_HolidayHomeId",
                table: "Faq_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Faq_HHs_TourFaqId",
                table: "Faq_HHs",
                column: "TourFaqId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_HHs_FeaturesId",
                table: "Features_HHs",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_HHs_HolidayHomeId",
                table: "Features_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HHCategory_HHs_HHCategoryId",
                table: "HHCategory_HHs",
                column: "HHCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HHCategory_HHs_HolidayHomeId",
                table: "HHCategory_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HHPackage_Amenities_HHPackageId",
                table: "HHPackage_Amenities",
                column: "HHPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_HHPackage_Amenities_RoomAmenitiesId",
                table: "HHPackage_Amenities",
                column: "RoomAmenitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_HHPackage_HHs_HHPackageId",
                table: "HHPackage_HHs",
                column: "HHPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_HHPackage_HHs_HolidayHomeId",
                table: "HHPackage_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HHType_HHs_HHTypeId",
                table: "HHType_HHs",
                column: "HHTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HHType_HHs_HolidayHomeId",
                table: "HHType_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_HHs_HolidayHomeId",
                table: "Location_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_HHs_LocationId",
                table: "Location_HHs",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_HHs_HolidayHomeId",
                table: "Review_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_HHs_ReviewId",
                table: "Review_HHs",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HHs_HolidayHomeId",
                table: "Room_HHs",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HHs_RoomId",
                table: "Room_HHs",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomAmenities_RoomAmenitiesId",
                table: "Room_RoomAmenities",
                column: "RoomAmenitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomAmenities_RoomId",
                table: "Room_RoomAmenities",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About_HHs");

            migrationBuilder.DropTable(
                name: "AdditionalService_HHs");

            migrationBuilder.DropTable(
                name: "Facility_HHs");

            migrationBuilder.DropTable(
                name: "Faq_HHs");

            migrationBuilder.DropTable(
                name: "Features_HHs");

            migrationBuilder.DropTable(
                name: "HHCategory_HHs");

            migrationBuilder.DropTable(
                name: "HHPackage_Amenities");

            migrationBuilder.DropTable(
                name: "HHPackage_HHs");

            migrationBuilder.DropTable(
                name: "HHType_HHs");

            migrationBuilder.DropTable(
                name: "Location_HHs");

            migrationBuilder.DropTable(
                name: "Review_HHs");

            migrationBuilder.DropTable(
                name: "Room_HHs");

            migrationBuilder.DropTable(
                name: "Room_RoomAmenities");
        }
    }
}
