using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Elibrary_API.Migrations
{
    public partial class addQuestionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ExamTypeId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    IsMultiple = table.Column<bool>(type: "bit", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_ClassId",
                table: "Question",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ExamTypeId",
                table: "Question",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_UserId",
                table: "Question",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
