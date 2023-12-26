using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Elibrary_API.Migrations
{
    public partial class fixExamDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Course_CourseId",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Exam",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_CourseId",
                table: "Exam",
                newName: "IX_Exam_ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Classes_ClassId",
                table: "Exam",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Classes_ClassId",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Exam",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_ClassId",
                table: "Exam",
                newName: "IX_Exam_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Course_CourseId",
                table: "Exam",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
