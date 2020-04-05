using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kelasys.ESR.DataAccess.Migrations {
    public partial class Initial : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Sigle = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table => { 
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professeurs",
                columns: table => new {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Postnom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TitreFormation = table.Column<string>(nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Professeurs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(name: "Institutions");
            migrationBuilder.DropTable(name: "Professeurs");
        }
    }
}
