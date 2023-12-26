using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS_Elibrary_API.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Private_File",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Private_File",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Resource",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Lesson",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Lesson",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NumberQuestion",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Exam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Classes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "NumberQuestion",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Private_File",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Private_File",
                newName: "created_at");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
