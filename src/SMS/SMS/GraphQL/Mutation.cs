using SMS.Model;
using SMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.GraphQL
{
    public class Mutation
    {
        private readonly IStudentService _studentService;

        public Mutation(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<Student> AddStudent(Student student)
        {
            return await _studentService.AddStudent(student);
        }
    }
}
