using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspcoredemo.Migrations
{
    public partial class addstudent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "studentname",
                table: "student",
                newName: "student_name");

            migrationBuilder.RenameColumn(
                name: "branch",
                table: "student",
                newName: "student_email");

            migrationBuilder.RenameColumn(
                name: "student_enroll",
                table: "student",
                newName: "student_id");

            migrationBuilder.AddColumn<string>(
                name: "student_branch",
                table: "student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "student_division",
                table: "student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "student_branch",
                table: "student");

            migrationBuilder.DropColumn(
                name: "student_division",
                table: "student");

            migrationBuilder.RenameColumn(
                name: "student_name",
                table: "student",
                newName: "studentname");

            migrationBuilder.RenameColumn(
                name: "student_email",
                table: "student",
                newName: "branch");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "student",
                newName: "student_enroll");
        }
    }
}
