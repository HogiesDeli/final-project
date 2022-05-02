using Microsoft.EntityFrameworkCore.Migrations;

namespace final_project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    ArmorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Aname = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.ArmorID);
                });

            migrationBuilder.CreateTable(
                name: "Heavy",
                columns: table => new
                {
                    HeavyID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hname = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heavy", x => x.HeavyID);
                });

            migrationBuilder.CreateTable(
                name: "Primary",
                columns: table => new
                {
                    PrimaryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pname = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Primary", x => x.PrimaryID);
                });

            migrationBuilder.CreateTable(
                name: "Secondary",
                columns: table => new
                {
                    SecondaryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sname = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secondary", x => x.SecondaryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Heavy");

            migrationBuilder.DropTable(
                name: "Primary");

            migrationBuilder.DropTable(
                name: "Secondary");
        }
    }
}
