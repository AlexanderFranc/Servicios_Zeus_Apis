using System.Linq.Expressions;
namespace Core.Interfaces.Generico
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id,bool noseguimiento=true);
        Task<IEnumerable<T>> GetAllAsync(bool noseguimiento = true);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, bool noseguimiento = true);
        Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search,bool noseguimiento=true);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        Task<int> SaveAsync();


    }
}
