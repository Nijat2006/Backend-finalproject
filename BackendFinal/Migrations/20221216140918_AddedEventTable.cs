using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendFinal.Migrations
{
    public partial class AddedEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Sosialmedya",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UseFullink",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Work",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "information",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Work = table.Column<string>(maxLength: 2500, nullable: true),
                    Adress = table.Column<string>(maxLength: 2500, nullable: true),
                    information = table.Column<string>(maxLength: 2500, nullable: true),
                    UseFullink = table.Column<string>(maxLength: 2500, nullable: true),
                    Sosialmedya = table.Column<string>(maxLength: 2500, nullable: true),
                    Number = table.Column<string>(maxLength: 2500, nullable: true),
                    Lesson = table.Column<string>(maxLength: 255, nullable: true),
                    LessonTime = table.Column<string>(maxLength: 2500, nullable: true),
                    LessonLocation = table.Column<string>(maxLength: 2500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Courses",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Courses",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sosialmedya",
                table: "Courses",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UseFullink",
                table: "Courses",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Work",
                table: "Courses",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "information",
                table: "Courses",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "Courses",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
