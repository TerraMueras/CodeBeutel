using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Codebeutel.API.Migrations
{
    public partial class FirstEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dispenser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    IsEmpty = table.Column<bool>(type: "boolean", nullable: false),
                    IsDefect = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispenser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewDispenser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewDispenser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuggestedDispenser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedDispenser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogFriendlyPlace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogFriendlyPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogFriendlyPlace_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DispenserId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Dispenser_DispenserId",
                        column: x => x.DispenserId,
                        principalTable: "Dispenser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewDispenserApproval",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NewDispenserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewDispenserApproval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewDispenserApproval_NewDispenser_NewDispenserId",
                        column: x => x.NewDispenserId,
                        principalTable: "NewDispenser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuggestedDispenserApproval",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SuggestedDispensersId = table.Column<int>(type: "integer", nullable: false),
                    SuggestedDispenserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedDispenserApproval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuggestedDispenserApproval_SuggestedDispenser_SuggestedDisp~",
                        column: x => x.SuggestedDispenserId,
                        principalTable: "SuggestedDispenser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogFriendlyPlace_CategoryId",
                table: "DogFriendlyPlace",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewDispenserApproval_NewDispenserId",
                table: "NewDispenserApproval",
                column: "NewDispenserId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_DispenserId",
                table: "Report",
                column: "DispenserId");

            migrationBuilder.CreateIndex(
                name: "IX_SuggestedDispenserApproval_SuggestedDispenserId",
                table: "SuggestedDispenserApproval",
                column: "SuggestedDispenserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogFriendlyPlace");

            migrationBuilder.DropTable(
                name: "NewDispenserApproval");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "SuggestedDispenserApproval");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "NewDispenser");

            migrationBuilder.DropTable(
                name: "Dispenser");

            migrationBuilder.DropTable(
                name: "SuggestedDispenser");
        }
    }
}
