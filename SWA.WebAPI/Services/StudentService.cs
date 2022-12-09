using Microsoft.EntityFrameworkCore;
using SWA.DataAccess.Data;
using SWA.DataAccess.Models;
using static SWA.WebAPI.Services.StudentService;

namespace SWA.WebAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentsContext _dbContext;

        public StudentService(StudentsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Student student)
        {
            return _dbContext.Students.Add(student);
        }

        public ValueTask<Student?> Get(int id)
        {
            return _dbContext.Students.FindAsync(id);
        }

        public Task<List<Student>> GetAll()
        {
            return _dbContext.Students.ToListAsync();
        }

        public async Task Remove(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChangesAsync();
        }

        public Task Update(Student student)
        {
           _dbContext.Students.Update(student);
            _dbContext.SaveChangesAsync();
        }
       

            
        }

    }
}
