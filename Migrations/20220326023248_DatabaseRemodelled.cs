using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErrataManager.Migrations
{
    public partial class DatabaseRemodelled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errors_Books_BookId",
                table: "Errors");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Errors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId1",
                table: "Errors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Errors_BookId1",
                table: "Errors",
                column: "BookId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Errors_Books_BookId",
                table: "Errors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Errors_Books_BookId1",
                table: "Errors",
                column: "BookId1",
                principalTable: "Books",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errors_Books_BookId",
                table: "Errors");

            migrationBuilder.DropForeignKey(
                name: "FK_Errors_Books_BookId1",
                table: "Errors");

            migrationBuilder.DropIndex(
                name: "IX_Errors_BookId1",
                table: "Errors");

            migrationBuilder.DropColumn(
                name: "BookId1",
                table: "Errors");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Errors",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Errors_Books_BookId",
                table: "Errors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
