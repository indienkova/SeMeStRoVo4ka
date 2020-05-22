using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NETCoreWebApplication1.Data.Migrations
{
    public partial class changedMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isMine",
                table: "Messages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMine",
                table: "Messages");
        }
    }
}
