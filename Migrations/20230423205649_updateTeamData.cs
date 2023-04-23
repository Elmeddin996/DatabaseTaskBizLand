using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseBizLand.Migrations
{
    public partial class updateTeamData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TeamMembers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TeamMembers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "TeamMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "TeamMembers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "TeamMembers");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TeamMembers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
