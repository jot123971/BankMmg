using Microsoft.EntityFrameworkCore.Migrations;

namespace BankMmg.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_Name = table.Column<string>(nullable: true),
                    employee_Position = table.Column<string>(nullable: true),
                    employee_Email = table.Column<string>(nullable: true),
                    employee_Contact = table.Column<string>(nullable: true),
                    employee_Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankSystem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankSystem");
        }
    }
}
