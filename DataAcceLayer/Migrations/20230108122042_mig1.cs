using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcceLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "announcements",
                columns: table => new
                {
                    AnnouncementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementTitle = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AnnouncementDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnouncementStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_announcements", x => x.AnnouncementID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactCompanyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactSubject = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContacMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "ourServices",
                columns: table => new
                {
                    OurServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OurServiceName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OurServiceDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurServiceimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurServiceStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ourServices", x => x.OurServiceID);
                });

            migrationBuilder.CreateTable(
                name: "ourTeams",
                columns: table => new
                {
                    OurTeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OurTeamStatus = table.Column<bool>(type: "bit", nullable: false),
                    OurTeamName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OurTeamJob = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OurTeamImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamLinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamInstagram = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ourTeams", x => x.OurTeamID);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkStatus = table.Column<bool>(type: "bit", nullable: true),
                    WorkTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkID);
                    table.ForeignKey(
                        name: "FK_Works_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Works_CategoryID",
                table: "Works",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "announcements");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "ourServices");

            migrationBuilder.DropTable(
                name: "ourTeams");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
