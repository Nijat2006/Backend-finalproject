using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendFinal.Migrations
{
    public partial class dsaasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Work",
                table: "Event");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Event",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Event",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Work",
                table: "Event",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);
        }
    }
}
