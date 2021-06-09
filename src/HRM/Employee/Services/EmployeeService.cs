using Employee.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly DatabaseContext _dbContext;
        #endregion

        #region Constructor
        public EmployeeService(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }
        #endregion

        public async Task<Employee.Model.Employee> Create(Employee.Model.Employee employee)
        {
            var data = new Employee.Model.Employee
            {
                Name = employee.Name,
                Designation = employee.Designation
            };
            await _dbContext.Employees.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<bool> Delete(DeleteVM deleteVM)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(c => c.Id == deleteVM.Id);
            if (employee is not null)
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public IQueryable<Employee.Model.Employee> GetAll()
        {
            return _dbContext.Employees.AsQueryable();
        }
     
    }

    public class DeleteVM
    {
        public int Id { get; set; }
    }
}
