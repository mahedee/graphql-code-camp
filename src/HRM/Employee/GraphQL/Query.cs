using Employee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.GraphQL
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;

        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IQueryable<Employee.Model.Employee> Employees => _employeeService.GetAll();
    }
}
