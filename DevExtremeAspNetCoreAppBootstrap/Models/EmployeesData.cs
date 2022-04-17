using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreAppBootstrap.Models
{
    public partial class SampleData
    {
        EmployeeDbContext _context;

        public SampleData(EmployeeDbContext context)
        {
            _context = context;
        }

        public static IEnumerable<Employee> EmployeesData = new[]
        {
            new Employee
            {
                Id = 1,
                Name = "John Cena",
                Gender = "Male",
                Age = 25,
                Salary = 25000
            },
            new Employee
            {
                Id = 2,
                Name = "Charley Cox",
                Gender = "Male",
                Age = 23,
                Salary = 32000
            },
            new Employee
            {
                Id = 3,
                Name = "Mila Kunis",
                Gender = "Female",
                Age = 20,
                Salary = 30000
            },
            new Employee
            {
                Id = 4,
                Name = "Tom Holland",
                Gender = "Male",
                Age = 19,
                Salary = 38000
            },
            new Employee
            {
                Id = 5,
                Name = "Nataly Portman",
                Gender = "Female",
                Age = 26,
                Salary = 26000
            }
        };
    }
}
