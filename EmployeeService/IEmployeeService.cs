using GraphQLApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApplication.EmployeeService
{
    public interface IEmployeeService
    {
        Task<Employee> Create(Employee employee);
        Task<bool> Delete(DeleteVM deleteVM);
        IQueryable<Employee> GetAll();
    }
}
