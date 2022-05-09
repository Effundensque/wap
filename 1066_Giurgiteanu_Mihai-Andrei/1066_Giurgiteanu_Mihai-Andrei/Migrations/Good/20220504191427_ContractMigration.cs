using Microsoft.EntityFrameworkCore.Migrations;

namespace _1066_Giurgiteanu_Mihai_Andrei.Migrations.Good
{
    public partial class ContractMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoodId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    finalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nameGood = table.Column<string>(type: "TEXT", nullable: true),
                    pricePerGood = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });
        }
    }
}
