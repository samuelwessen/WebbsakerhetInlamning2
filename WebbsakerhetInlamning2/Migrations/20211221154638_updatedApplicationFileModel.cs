using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbsakerhetInlamning2.Migrations
{
    public partial class updatedApplicationFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "ApplicationFiles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "ApplicationFiles");
        }
    }
}
