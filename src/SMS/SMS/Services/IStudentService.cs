using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Services
{
    public interface IStudentService
    {
        IQueryable<Student> GetAll();
        Task<Student> AddStudent(Student student);
        Task<Student> GetStudent(int id);
        Task<Student> EditStudent(int id, Student student);
    }
}
