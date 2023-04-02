namespace CelilCavus.WebApi.Interface
{
    public interface IRepository<T> where T : class
    {
        Task Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetList();
        T GetById(int id);        
    
    }
}