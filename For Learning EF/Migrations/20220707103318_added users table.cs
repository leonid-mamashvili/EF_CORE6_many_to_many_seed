using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace For_Learning_EF.Migrations
{
    public partial class addeduserstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), new Guid("045dc21a-742e-424b-96e5-494731c62e14") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), new Guid("3f158b22-7515-48e6-83d5-80845c4da485") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"), new Guid("b6108a5c-c1ec-4596-a0f8-dca2c0091b15") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), new Guid("3f158b22-7515-48e6-83d5-80845c4da485") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), new Guid("a927cf54-4e87-4d67-b691-0842ec7e265e") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"), new Guid("b4d43fe8-adf2-4523-8e17-5a1d640031a8") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), new Guid("950ae4e7-dfff-4b22-9e32-32889e08f8c0") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), new Guid("a927cf54-4e87-4d67-b691-0842ec7e265e") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"), new Guid("b4d43fe8-adf2-4523-8e17-5a1d640031a8") });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c8159cc4-8b93-4549-92bc-5ce24008c77e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e5373e9f-f56c-48e4-b277-8c88405744fb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f0ab57f0-82ea-4010-92c8-1a480c7ee977"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("045dc21a-742e-424b-96e5-494731c62e14"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3f158b22-7515-48e6-83d5-80845c4da485"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("950ae4e7-dfff-4b22-9e32-32889e08f8c0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a927cf54-4e87-4d67-b691-0842ec7e265e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b4d43fe8-adf2-4523-8e17-5a1d640031a8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b6108a5c-c1ec-4596-a0f8-dca2c0091b15"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), null, "Dep 1" },
                    { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), "Young department", "young Dep" },
                    { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), null, "Dep 2" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CreatedDate", "FullName" },
                values: new object[,]
                {
                    { new Guid("41e39972-46a7-473a-8820-d9b5fb3707a4"), 25, new DateTime(2022, 7, 7, 13, 33, 17, 855, DateTimeKind.Local).AddTicks(2879), "Director 1" },
                    { new Guid("428c08f1-a1aa-4333-8e7e-9a8c508625e5"), 23, new DateTime(2022, 7, 7, 13, 33, 17, 855, DateTimeKind.Local).AddTicks(2931), "Employee 4" },
                    { new Guid("7a4924bc-acce-4ac1-9c98-cc573bfac8a4"), 33, new DateTime(2022, 7, 7, 13, 33, 17, 855, DateTimeKind.Local).AddTicks(2926), "Employee 3" },
                    { new Guid("be9d8f7f-b019-4fb5-b77c-5c372c30b4f0"), 25, new DateTime(2022, 7, 7, 13, 33, 17, 855, DateTimeKind.Local).AddTicks(2912), "Employee 1" },
                    { new Guid("c63d0514-7181-437f-ab3e-404f39d1133d"), 66, new DateTime(2022, 7, 7, 13, 33, 17, 855, DateTimeKind.Local).AddTicks(2924), "Director 2" },
                    { new Guid("d6fbeb1f-94cf-4fa2-b98c-65721d81eac1"), 39, new DateTime(2022, 7, 7, 13, 33, 17, 855, DateTimeKind.Local).AddTicks(2914), "Employee 2" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentEmployees",
                columns: new[] { "DepartmentId", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), new Guid("41e39972-46a7-473a-8820-d9b5fb3707a4") },
                    { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), new Guid("be9d8f7f-b019-4fb5-b77c-5c372c30b4f0") },
                    { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), new Guid("d6fbeb1f-94cf-4fa2-b98c-65721d81eac1") },
                    { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), new Guid("41e39972-46a7-473a-8820-d9b5fb3707a4") },
                    { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), new Guid("428c08f1-a1aa-4333-8e7e-9a8c508625e5") },
                    { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), new Guid("be9d8f7f-b019-4fb5-b77c-5c372c30b4f0") },
                    { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), new Guid("428c08f1-a1aa-4333-8e7e-9a8c508625e5") },
                    { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), new Guid("7a4924bc-acce-4ac1-9c98-cc573bfac8a4") },
                    { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), new Guid("c63d0514-7181-437f-ab3e-404f39d1133d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), new Guid("41e39972-46a7-473a-8820-d9b5fb3707a4") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), new Guid("be9d8f7f-b019-4fb5-b77c-5c372c30b4f0") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"), new Guid("d6fbeb1f-94cf-4fa2-b98c-65721d81eac1") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), new Guid("41e39972-46a7-473a-8820-d9b5fb3707a4") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), new Guid("428c08f1-a1aa-4333-8e7e-9a8c508625e5") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("4db666da-c835-4b2f-8e38-78790be4162d"), new Guid("be9d8f7f-b019-4fb5-b77c-5c372c30b4f0") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), new Guid("428c08f1-a1aa-4333-8e7e-9a8c508625e5") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), new Guid("7a4924bc-acce-4ac1-9c98-cc573bfac8a4") });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployees",
                keyColumns: new[] { "DepartmentId", "EmployeeId" },
                keyValues: new object[] { new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"), new Guid("c63d0514-7181-437f-ab3e-404f39d1133d") });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0f57b376-cbe3-416f-ab94-1af2eab768aa"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4db666da-c835-4b2f-8e38-78790be4162d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d14b8914-9040-4091-8feb-451c04f6fb07"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("41e39972-46a7-473a-8820-d9b5fb3707a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("428c08f1-a1aa-4333-8e7e-9a8c508625e5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7a4924bc-acce-4ac1-9c98-cc573bfac8a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("be9d8f7f-b019-4fb5-b77c-5c372c30b4f0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c63d0514-7181-437f-ab3e-404f39d1133d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d6fbeb1f-94cf-4fa2-b98c-65721d81eac1"));

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
        }
    }
}
