using GraphQLApplication.EmployeeService;
using GraphQLApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApplication.GraphQL
{
    public class Mutuation
    {
        private readonly IEmployeeService _employeeService;
        public Mutuation(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<Employee> Create(Employee employee)
                    => await _employeeService.Create(employee);
        public async Task<bool> Delete(DeleteVM deleteVM) 
                    => await _employeeService.Delete(deleteVM);
    }
}
