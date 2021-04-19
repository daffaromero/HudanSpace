using Microsoft.EntityFrameworkCore.Migrations;

namespace HudanSpace.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "User",
                newName: "UserPhone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "Course",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserPhone",
                table: "User",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "Course",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
