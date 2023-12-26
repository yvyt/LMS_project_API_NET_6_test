using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Elibrary_API.Migrations
{
    public partial class addExamQuestionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamQuestion",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    QuestionId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ExamId = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamQuestion_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestion_ExamId",
                table: "ExamQuestion",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestion_QuestionId",
                table: "ExamQuestion",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamQuestion");
        }
    }
}
