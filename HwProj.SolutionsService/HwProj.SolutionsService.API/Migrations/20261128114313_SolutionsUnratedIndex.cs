using Microsoft.EntityFrameworkCore.Migrations;

namespace HwProj.SolutionsService.API.Migrations
{
    public partial class SolutionsUnratedIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Solutions_TaskId",
                table: "Solutions");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Solutions",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_TaskId_StudentId_PublicationDate",
                table: "Solutions",
                columns: new[] { "TaskId", "StudentId", "PublicationDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Solutions_TaskId_StudentId_PublicationDate",
                table: "Solutions");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Solutions",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_TaskId",
                table: "Solutions",
                column: "TaskId");
        }
    }
}
