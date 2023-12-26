using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Elibrary_API.Migrations
{
    public partial class fixResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Course_CourseId",
                table: "Resource");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Resource",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_CourseId",
                table: "Resource",
                newName: "IX_Resource_ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Classes_ClassId",
                table: "Resource",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Classes_ClassId",
                table: "Resource");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Resource",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_ClassId",
                table: "Resource",
                newName: "IX_Resource_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Course_CourseId",
                table: "Resource",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
