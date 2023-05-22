using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_app.Migrations
{
    public partial class intit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Empno = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
