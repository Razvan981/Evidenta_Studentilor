using Microsoft.EntityFrameworkCore.Migrations;

namespace GASF.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAttendances_Students_StudentId1",
                table: "CourseAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseGrades_Students_StudentId1",
                table: "CourseGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseGrades_StudentId1",
                table: "CourseGrades");

            migrationBuilder.DropIndex(
                name: "IX_CourseAttendances_StudentId1",
                table: "CourseAttendances");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "CourseGrades");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "CourseAttendances");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherId",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "CourseGrades",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "CourseAttendances",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGrades_StudentId",
                table: "CourseGrades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAttendances_StudentId",
                table: "CourseAttendances",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAttendances_Students_StudentId",
                table: "CourseAttendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseGrades_Students_StudentId",
                table: "CourseGrades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAttendances_Students_StudentId",
                table: "CourseAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseGrades_Students_StudentId",
                table: "CourseGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseGrades_StudentId",
                table: "CourseGrades");

            migrationBuilder.DropIndex(
                name: "IX_CourseAttendances_StudentId",
                table: "CourseAttendances");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherId1",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "CourseGrades",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "CourseGrades",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "CourseAttendances",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "CourseAttendances",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId1",
                table: "Courses",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGrades_StudentId1",
                table: "CourseGrades",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAttendances_StudentId1",
                table: "CourseAttendances",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAttendances_Students_StudentId1",
                table: "CourseAttendances",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseGrades_Students_StudentId1",
                table: "CourseGrades",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId1",
                table: "Courses",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
