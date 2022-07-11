// See https://aka.ms/new-console-template for more information
using For_Learning_EF;
using For_Learning_EF.Models;
using Microsoft.EntityFrameworkCore;

string connectionString = $"Server=localhost\\MSSQLSERVER01;Database=CreatedByEF;Trusted_Connection=True;";
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder
    .UseSqlServer(connectionString)
    .Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    Console.WriteLine("Database created");
    
    var oldEmployees = db.Employees.Where(x => x.Age > 25)?.Include(x => x.DepartmentEmployee).ThenInclude(de => de.Department).ToList();
    foreach (var oldEmployee in oldEmployees)
    {
        //var deps = db.Departments.Where(x => oldEmployee.DepartmentEmployee.FirstOrDefault(de => de.EmployeeId == oldEmployee.Id) != null).ToList();
        foreach (var dep in oldEmployee.DepartmentEmployee)
        {
            Console.WriteLine(dep.Department.Name);
        }
    }

    var somequery = db.Departments.Where(x => !String.IsNullOrEmpty(x.Description)).ToList();
    foreach (var dep in somequery)
    {
        Console.WriteLine(somequery.First().Name);
    }

    var newUser = new User()
    {
        UserName = "Leonid",
    };

    db.Users.Add(newUser);

    db.SaveChanges();

    var userForDelete = new User()
    {
        UserName = "Should Not Exist"
    };

    Console.WriteLine($"Created user {userForDelete.Id}");
    db.Users.Add(userForDelete);

    db.SaveChanges();

    var foundUser = db.Users.FirstOrDefault(x => x.UserName == "Should Not Exist");
    if (foundUser != null)
    {
        Console.WriteLine($"Deleting User: {foundUser.Id}");
        db.Users.Remove(foundUser);
    }

    db.SaveChanges();
}

Console.WriteLine("Changes saved");