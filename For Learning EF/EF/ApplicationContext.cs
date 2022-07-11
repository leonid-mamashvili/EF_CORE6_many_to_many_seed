using For_Learning_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Learning_EF
{
    public class ApplicationContext : DbContext
    {
        private string connectionString = $"Server=localhost\\MSSQLSERVER01;Database=CreatedByEF;Trusted_Connection=True;";

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<DepartmentEmployee> DepartmentEmployees { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentEmployee>()
            .HasKey(t => new { t.DepartmentId, t.EmployeeId });

            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        void SeedData(ModelBuilder modelBuilder)
        {
            if (!Employees.Any())
            {
                var employees = new List<Employee>()
            {
                new Employee() { FullName = "Director 1", Age = 25, CreatedDate = DateTime.Now },
                new Employee() { FullName = "Employee 1", Age = 25, CreatedDate = DateTime.Now },
                new Employee() { FullName = "Employee 2", Age = 39, CreatedDate = DateTime.Now },
                new Employee() { FullName = "Director 2", Age = 66, CreatedDate = DateTime.Now },
                new Employee() { FullName = "Employee 3", Age = 33, CreatedDate = DateTime.Now },
                new Employee() { FullName = "Employee 4", Age = 23, CreatedDate = DateTime.Now },
            };

                var deps = new List<Department>()
            {
                new Department() { Name = "Dep 1" },
                new Department() { Name = "Dep 2" },
                new Department() { Name = "young Dep", Description = "Young department" }
            };

                var relation = new List<DepartmentEmployee>()
            {
                new DepartmentEmployee() { DepartmentId = deps[0].Id, EmployeeId = employees[0].Id },
                new DepartmentEmployee() { DepartmentId = deps[0].Id, EmployeeId = employees[1].Id },
                new DepartmentEmployee() { DepartmentId = deps[0].Id, EmployeeId = employees[2].Id },
                new DepartmentEmployee() { DepartmentId = deps[1].Id, EmployeeId = employees[3].Id },
                new DepartmentEmployee() { DepartmentId = deps[1].Id, EmployeeId = employees[4].Id },
                new DepartmentEmployee() { DepartmentId = deps[1].Id, EmployeeId = employees[5].Id },
                new DepartmentEmployee() { DepartmentId = deps[2].Id, EmployeeId = employees[0].Id },
                new DepartmentEmployee() { DepartmentId = deps[2].Id, EmployeeId = employees[1].Id },
                new DepartmentEmployee() { DepartmentId = deps[2].Id, EmployeeId = employees[5].Id },
            };

                modelBuilder.Entity<Employee>().HasData(employees);
                modelBuilder.Entity<Department>().HasData(deps);
                modelBuilder.Entity<DepartmentEmployee>().HasData(relation);
            }
        }
    }
}
