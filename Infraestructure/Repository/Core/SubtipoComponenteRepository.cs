using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class SubtipoComponenteRepository : GenericCoreRepository<SubtipoComponente>, ISubtipoComponenteRepository
    {
        public SubtipoComponenteRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<SubtipoComponente>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.SubtipoComponentes.AsNoTracking()
                       : _context.SubtipoComponentes;
            return await query.ToListAsync();
        }
        public override async Task<SubtipoComponente> GetByIdAsync(int idsubcomponent, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.SubtipoComponentes.AsNoTracking()
                                   : _context.SubtipoComponentes;

            return await query.FirstOrDefaultAsync(x => x.IdSubtipoComponente == idsubcomponent);
        }
        public override async Task<(int totalRegistros, IEnumerable<SubtipoComponente> registros)> GetAllAsync(
        int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.SubtipoComponentes.AsNoTracking()
                                  : _context.SubtipoComponentes;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.DescripcionSubtipoComponente.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
