using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErrataManager.Migrations
{
    public partial class ModelReupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Errors",
                newName: "ErrorName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ErrorName",
                table: "Errors",
                newName: "Name");
        }
    }
}
