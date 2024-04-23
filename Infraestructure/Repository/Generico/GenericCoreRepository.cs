using System.Linq.Expressions;
using Core.Interfaces;
using Core.Interfaces.Generico;
using Infraestructure.Configuration.Zeus.Core;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Generico
{
    public class GenericCoreRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ZeusCoreContext _context;
        public GenericCoreRepository(ZeusCoreContext context)
        {
            _context = context;
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, bool noseguimiento = true)
        {
            return noseguimiento ? _context.Set<T>().AsNoTracking().Where(expression)
                                : _context.Set<T>().Where(expression);

        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(bool noseguimiento = true)
        {
            return noseguimiento? await _context.Set<T>().AsNoTracking().ToListAsync()
                                : await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id, bool noseguimiento = true)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (noseguimiento)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }
        public virtual async Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Set<T>().AsNoTracking().AsQueryable()
                                    : _context.Set<T>().AsQueryable();

            var totalRegistros = await query
                                .CountAsync();

            var registros = await query
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);

        }
        public virtual void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
