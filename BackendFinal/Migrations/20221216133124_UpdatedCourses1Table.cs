using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendFinal.Migrations
{
    public partial class UpdatedCourses1Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Courses",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "Courses",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "Courses");
        }
    }
}
