using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErrataManager.Migrations
{
    public partial class NewRevisions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errors_Books_BookNameId",
                table: "Errors");

            migrationBuilder.RenameColumn(
                name: "Descision",
                table: "Errors",
                newName: "Decision");

            migrationBuilder.RenameColumn(
                name: "BookNameId",
                table: "Errors",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Errors_BookNameId",
                table: "Errors",
                newName: "IX_Errors_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Errors_Books_BookId",
                table: "Errors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errors_Books_BookId",
                table: "Errors");

            migrationBuilder.RenameColumn(
                name: "Decision",
                table: "Errors",
                newName: "Descision");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Errors",
                newName: "BookNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Errors_BookId",
                table: "Errors",
                newName: "IX_Errors_BookNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Errors_Books_BookNameId",
                table: "Errors",
                column: "BookNameId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
