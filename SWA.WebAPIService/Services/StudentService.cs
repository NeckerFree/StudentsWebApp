using Microsoft.EntityFrameworkCore;
using SWA.DataAccess.Data;
using SWA.DataAccess.Models;

namespace SWA.WebAPIServices.Services
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
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Student?> Get(long id)
        {
            return await _dbContext.Students.FindAsync(id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task Remove(long id)
        {
            var existentStudent = _dbContext.Students.FirstOrDefault(student => student.Id == id);
            if (existentStudent != null)
            {
                _dbContext.Students?.Remove(existentStudent);
            }
            await _dbContext.SaveChangesAsync();
        }

        public Task Update(Student student)
        {
            _dbContext.Students.Update(student);
            return _dbContext.SaveChangesAsync();
        }



    }

}
