using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PustokProject.Migrations
{
    public partial class init3333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BookImages");

            migrationBuilder.AddColumn<string>(
                name: "BackImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackImageUrl",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BookImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
