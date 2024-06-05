using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mysql.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Qas",
                columns: table => new
                {
                    QaId = table.Column<int>(type: "int(11)", nullable: false),
                    Quest = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Answ = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    Hyper = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true),
                    UserMessage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: true),
                    StatusMessage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<int>(type: "int", nullable: false),
                    Org = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qas", x => x.QaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Qas");
        }
    }
}
