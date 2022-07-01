using GraphQLApplication.EmployeeService;
using GraphQLApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApplication.GraphQL
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;
        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IQueryable<Employee> Employees => _employeeService.GetAll();
    }
}
