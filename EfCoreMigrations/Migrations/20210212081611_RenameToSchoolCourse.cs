using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreMigrations.Migrations
{
    public partial class RenameToSchoolCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_CourseID",
                table: "Enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "SchoolCourseID",
                table: "Enrollment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolCourseID",
                table: "Course",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "SchoolCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_SchoolCourseID",
                table: "Enrollment",
                column: "SchoolCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_SchoolCourseID",
                table: "Enrollment",
                column: "SchoolCourseID",
                principalTable: "Course",
                principalColumn: "SchoolCourseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_SchoolCourseID",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_SchoolCourseID",
                table: "Enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SchoolCourseID",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "SchoolCourseID",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Enrollment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseID",
                table: "Enrollment",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
