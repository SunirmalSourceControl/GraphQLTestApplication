using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLApplication.Models;

namespace GraphQLApplication.Models
{
    public class DatabaseContext
    {
        public List<Employee> Employees;

        public DatabaseContext()
        {
            Employees = new List<Employee>
            {
                           new Employee
                {
                    Id = 1,
                    Name = "Jay krishna Reddy",
                    Designation = "Full Stack Developer"
                },
                new Employee
                {
                    Id = 2,
                    Name = "JK",
                    Designation = "SSE"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Jay",
                    Designation = "Software Engineer"
                },
                new Employee
                {
                    Id = 4,
                    Name = "krishna Reddy",
                    Designation = "Database Developer"
                },
                new Employee
                {
                    Id = 5,
                    Name = "Reddy",
                    Designation = "Cloud Engineer"
                }

            };

        }
    }
}
