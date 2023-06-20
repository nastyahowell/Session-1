using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vstrechashop.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Адрес = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Телефон = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
