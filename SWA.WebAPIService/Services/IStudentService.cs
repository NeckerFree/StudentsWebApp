using SWA.DataAccess.Models;

namespace SWA.WebAPIServices.Services
{
    public interface IStudentService
    {
        Task<Student?> Get(long id);

        Task<IEnumerable<Student>> GetAll();

        Task Add(Student student);

        Task Update(Student student);

        Task Remove(long id);

    }
}