using Microsoft.EntityFrameworkCore.Migrations;

namespace _1066_Giurgiteanu_Mihai_Andrei.Migrations.Good
{
    public partial class GoodMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nameGood = table.Column<string>(nullable: true),
                    pricePerGood = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
