using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace AVWebsite.Migrations
{
    public partial class ToursAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FeatureImage = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    TourCategoryId = table.Column<int>(type: "int", nullable: true),
                    TourTypeId = table.Column<int>(type: "int", nullable: true),
                    FeaturePrice = table.Column<int>(type: "int", nullable: false),
                    FeaturePriceText = table.Column<string>(type: "text", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true),
                    Inclusions = table.Column<string>(type: "text", nullable: true),
                    Exclusion = table.Column<string>(type: "text", nullable: true),
                    Highlightis = table.Column<string>(type: "text", nullable: true),
                    FullDescription = table.Column<string>(type: "text", nullable: true),
                    MapLong = table.Column<float>(type: "float", nullable: true),
                    MapLat = table.Column<float>(type: "float", nullable: true),
                    AverageRating = table.Column<float>(type: "float", nullable: true),
                    MaximumPerson = table.Column<int>(type: "int", nullable: true),
                    MinimumPersion = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tours_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tours_TourCategories_TourCategoryId",
                        column: x => x.TourCategoryId,
                        principalTable: "TourCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tours_TourTypes_TourTypeId",
                        column: x => x.TourTypeId,
                        principalTable: "TourTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "About_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AboutId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_About_Tours_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_About_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalService_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdditionalServiceId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalService_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalService_Tours_AdditionalServices_AdditionalService~",
                        column: x => x.AdditionalServiceId,
                        principalTable: "AdditionalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalService_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Tours_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Tours_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TourFaq_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TourFaqId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourFaq_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourFaq_Tours_TourFaqs_TourFaqId",
                        column: x => x.TourFaqId,
                        principalTable: "TourFaqs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourFaq_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TourPackage_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TourPackageId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourPackage_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourPackage_Tours_TourPackages_TourPackageId",
                        column: x => x.TourPackageId,
                        principalTable: "TourPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourPackage_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WhatToExpect_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    WhatToExpectId = table.Column<int>(type: "int", nullable: true),
                    ToursId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatToExpect_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhatToExpect_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WhatToExpect_Tours_WhatToExpects_WhatToExpectId",
                        column: x => x.WhatToExpectId,
                        principalTable: "WhatToExpects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_About_Tours_AboutId",
                table: "About_Tours",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_About_Tours_ToursId",
                table: "About_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalService_Tours_AdditionalServiceId",
                table: "AdditionalService_Tours",
                column: "AdditionalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalService_Tours_ToursId",
                table: "AdditionalService_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Tours_LocationId",
                table: "Location_Tours",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Tours_ToursId",
                table: "Location_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_Tours_ReviewId",
                table: "Review_Tours",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_Tours_ToursId",
                table: "Review_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_TourFaq_Tours_TourFaqId",
                table: "TourFaq_Tours",
                column: "TourFaqId");

            migrationBuilder.CreateIndex(
                name: "IX_TourFaq_Tours_ToursId",
                table: "TourFaq_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_TourPackage_Tours_TourPackageId",
                table: "TourPackage_Tours",
                column: "TourPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TourPackage_Tours_ToursId",
                table: "TourPackage_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GalleryId",
                table: "Tours",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_LocationId",
                table: "Tours",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourCategoryId",
                table: "Tours",
                column: "TourCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourTypeId",
                table: "Tours",
                column: "TourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatToExpect_Tours_ToursId",
                table: "WhatToExpect_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_WhatToExpect_Tours_WhatToExpectId",
                table: "WhatToExpect_Tours",
                column: "WhatToExpectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About_Tours");

            migrationBuilder.DropTable(
                name: "AdditionalService_Tours");

            migrationBuilder.DropTable(
                name: "Location_Tours");

            migrationBuilder.DropTable(
                name: "Review_Tours");

            migrationBuilder.DropTable(
                name: "TourFaq_Tours");

            migrationBuilder.DropTable(
                name: "TourPackage_Tours");

            migrationBuilder.DropTable(
                name: "WhatToExpect_Tours");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
