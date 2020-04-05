using Microsoft.EntityFrameworkCore.Migrations;

namespace Kelasys.ESR.DataAccess.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sexe",
                table: "Professeurs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexe",
                table: "Professeurs");
        }
    }
}
