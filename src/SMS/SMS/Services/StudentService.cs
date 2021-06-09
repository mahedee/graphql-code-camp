using Microsoft.EntityFrameworkCore;
using SMS.Database;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Services
{
    public class StudentService : IStudentService
    {
        private readonly SMSContext _dbContext;

        public StudentService(SMSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Student> GetAll()
        {
            return _dbContext.Students.AsQueryable();
        }

        public async Task<Student> AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student> GetStudent(int id)
        {
            var student = await _dbContext.Students.FindAsync(id);

            return student;
        }


        public async Task<Student> EditStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return null;
            }

            _dbContext.Entry(student).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return student;
        }

        private bool StudentExists(int id)
        {
            return _dbContext.Students.Any(e => e.Id == id);
        }

    }
}
