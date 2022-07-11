using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace For_Learning_EF.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEmployees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployees", x => new { x.DepartmentId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), null, "Dep 2" },
                    { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), "Young department", "young Dep" },
                    { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), null, "Dep 1" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CreatedDate", "FullName" },
                values: new object[,]
                {
                    { new Guid("045dc21a-742e-424b-96e5-494731c62e14"), 66, new DateTime(2022, 7, 7, 13, 21, 29, 932, DateTimeKind.Local).AddTicks(5602), "Director 2" },
                    { new Guid("3f158b22-7515-48e6-83d5-80845c4da485"), 23, new DateTime(2022, 7, 7, 13, 21, 29, 932, DateTimeKind.Local).AddTicks(5621), "Employee 4" },
                    { new Guid("950ae4e7-dfff-4b22-9e32-32889e08f8c0"), 39, new DateTime(2022, 7, 7, 13, 21, 29, 932, DateTimeKind.Local).AddTicks(5600), "Employee 2" },
                    { new Guid("a927cf54-4e87-4d67-b691-0842ec7e265e"), 25, new DateTime(2022, 7, 7, 13, 21, 29, 932, DateTimeKind.Local).AddTicks(5597), "Employee 1" },
                    { new Guid("b4d43fe8-adf2-4523-8e17-5a1d640031a8"), 25, new DateTime(2022, 7, 7, 13, 21, 29, 932, DateTimeKind.Local).AddTicks(5593), "Director 1" },
                    { new Guid("b6108a5c-c1ec-4596-a0f8-dca2c0091b15"), 33, new DateTime(2022, 7, 7, 13, 21, 29, 932, DateTimeKind.Local).AddTicks(5605), "Employee 3" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentEmployees",
                columns: new[] { "DepartmentId", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), new Guid("045dc21a-742e-424b-96e5-494731c62e14") },
                    { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), new Guid("3f158b22-7515-48e6-83d5-80845c4da485") },
                    { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), new Guid("b6108a5c-c1ec-4596-a0f8-dca2c0091b15") },
                    { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), new Guid("3f158b22-7515-48e6-83d5-80845c4da485") },
                    { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), new Guid("a927cf54-4e87-4d67-b691-0842ec7e265e") },
                    { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), new Guid("b4d43fe8-adf2-4523-8e17-5a1d640031a8") },
                    { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), new Guid("950ae4e7-dfff-4b22-9e32-32889e08f8c0") },
                    { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), new Guid("a927cf54-4e87-4d67-b691-0842ec7e265e") },
                    { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), new Guid("b4d43fe8-adf2-4523-8e17-5a1d640031a8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployees_EmployeeId",
                table: "DepartmentEmployees",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentEmployees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
