using Microsoft.EntityFrameworkCore;
using SWA.DataAccess.Data;

namespace SWA.DataAccess.Repository
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private StudentsContext _context;
        private DbSet<T> table;
        
        public GenericRepository(StudentsContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public T GetById(object id)
        {
            return table.Find(id)!;
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
               

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id)!;
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
