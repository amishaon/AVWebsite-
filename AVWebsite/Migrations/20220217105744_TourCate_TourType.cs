using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace AVWebsite.Migrations
{
    public partial class TourCate_TourType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            

            migrationBuilder.CreateTable(
                name: "TourCategory_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TourCategoryId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourCategory_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourCategory_Tours_TourCategories_TourCategoryId",
                        column: x => x.TourCategoryId,
                        principalTable: "TourCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourCategory_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TourType_Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TourTypeId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourType_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourType_Tours_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourType_Tours_TourTypes_TourTypeId",
                        column: x => x.TourTypeId,
                        principalTable: "TourTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TourCategory_Tours_TourCategoryId",
                table: "TourCategory_Tours",
                column: "TourCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TourCategory_Tours_ToursId",
                table: "TourCategory_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_TourType_Tours_ToursId",
                table: "TourType_Tours",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_TourType_Tours_TourTypeId",
                table: "TourType_Tours",
                column: "TourTypeId");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourCategory_Tours");

            migrationBuilder.DropTable(
                name: "TourType_Tours");

        }
    }
}
