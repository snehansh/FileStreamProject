using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FileStreamProject.Migrations
{
    public partial class AddFSAttrib : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DurationInYears = table.Column<int>(nullable: false),
                    EmployeeGuid = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false),
                    Document = table.Column<byte[]>(type: "VARBINARY(MAX) FILESTREAM", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.UniqueConstraint("AK_Employees_EmployeeGuid", x => x.EmployeeGuid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
