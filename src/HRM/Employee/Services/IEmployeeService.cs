using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Services
{
    public interface IEmployeeService
    {
        Task<Employee.Model.Employee> Create(Employee.Model.Employee employee);
        Task<bool> Delete(DeleteVM deleteVM);
        IQueryable<Employee.Model.Employee> GetAll();
    }
}
