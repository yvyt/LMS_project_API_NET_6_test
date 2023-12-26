using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Elibrary_API.Migrations
{
    public partial class fixExam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Exam");
        }
    }
}
