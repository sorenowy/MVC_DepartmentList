using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DepartmentApplication.Models
{
    public class EmployeeInitializer : DropCreateDatabaseAlways<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            var departments = new List<Department>
            {
                new Department { DepartmentName = "Electrical Department" },
                new Department { DepartmentName = "Civil Department" },
                new Department { DepartmentName = "Bio science Department" },
            };
            departments.ForEach(x => context.Departments.Add(x));
            context.SaveChanges();
            var employees = new List<Employee>
            {
                new Employee { Name = "John", Age = 21, DepartmentId = 1 },
                new Employee { Name = "May", Age = 22, DepartmentId = 1 },
                new Employee { Name = "Harry", Age = 23, DepartmentId = 2 },
                new Employee { Name = "Alice", Age = 41, DepartmentId = 3 },
                new Employee { Name = "Felix", Age = 31, DepartmentId = 2 },
                new Employee { Name = "Steve", Age = 19, DepartmentId = 3 },
            };
            employees.ForEach(x => context.Employees.Add(x));
            context.SaveChanges();
        }
    }
}