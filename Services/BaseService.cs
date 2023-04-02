using CelilCavus.WebApi.Context;
using CelilCavus.WebApi.Interface;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.WebApi.Service
{
    public class BaseService<T> : IRepository<T> where T : class
    {

        private readonly DbContext _context;
        private readonly DbSet<T> _set;

        public BaseService(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();

            context.ChangeTracker.LazyLoadingEnabled = false;
            // Nesnelerde, veri tabanına gitmeden önce herhangi bir değişim olup olmadığını kontrol eder.
            context.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public async Task Add(T item)
        {

            using var cont = _context;
            if (string.IsNullOrEmpty(item.ToString()))
            {
                await _set.AddAsync(item);
                cont.SaveChanges();
            }
            else throw new Exception("Değer Null Olabilir.");
        }

        public void Delete(T item)
        {

            using var cont = _context;
            if (string.IsNullOrEmpty(item.ToString()))
            {
                _set.Remove(item);
                cont.SaveChanges();
            }
            else throw new Exception("Değer Null Olabilir.");
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }

        public List<T> GetList()
        {
            return _set.AsNoTracking().ToList();
        }

        public void Update(T item)
        {
            using var cont = _context;
            if (string.IsNullOrEmpty(item.ToString()))
            {
                _set.Update(item);
                cont.SaveChanges();
            }
            else throw new Exception("Değer Null Olabilir.");
        }
    }
}