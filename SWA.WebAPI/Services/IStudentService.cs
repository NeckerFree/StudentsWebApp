using SWA.DataAccess.Models;

namespace SWA.WebAPI.Services
{
    public interface IStudentService
    {
        ValueTask<Student?> Get(int id);
        
        Task<List<Student>> GetAll();

        Task Add(Student student);

        Task Update(Student student);

        Task Remove(int id);

    }
}