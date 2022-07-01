using GraphQLApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApplication.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbContext;
        public EmployeeService(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }
        public async Task<Employee> Create(Employee employee)
        {
            var data = new Employee
            {
                Name = employee.Name,
                Designation = employee.Designation
            };
            _dbContext.Employees.Add(data);
            //await _dbContext.Employees.AddAsync(data);
            //await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<bool> Delete(DeleteVM deleteVM)
        {
            var employee = _dbContext.Employees.Find(c => c.Id == deleteVM.Id);
            if (employee!=null)
            {
                _dbContext.Employees.Remove(employee);
                //_dbContext.Employees.Remove(employee);
                //await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public IQueryable<Employee> GetAll()
        {
            return _dbContext.Employees.AsQueryable();
        }
    }
    public class DeleteVM
    {
        public int Id { get; set; }
    }
}
