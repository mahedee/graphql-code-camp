using SMS.Model;
using SMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.GraphQL
{
    public class Query
    {
        private readonly IStudentService _studentService;

        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IQueryable<Student> Students()
        {
            return _studentService.GetAll();
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _studentService.GetStudent(id);
        }
    }
}
