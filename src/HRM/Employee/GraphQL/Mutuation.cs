using Employee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.GraphQL
{
    public class Mutuation
    {
        private readonly IEmployeeService _employeeService;

        public Mutuation(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<Employee.Model.Employee> Create(Employee.Model.Employee employee) => await _employeeService.Create(employee);
        public async Task<bool> Delete(DeleteVM deleteVM) => await _employeeService.Delete(deleteVM);
    }
}
