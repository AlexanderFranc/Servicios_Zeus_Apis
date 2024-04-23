using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Repository.Core
{
    public class EstadoPeRepository : GenericCoreRepository<EstadoPe>, IEstadoPeRepository
    {
        public EstadoPeRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
        public override async Task<IEnumerable<EstadoPe>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.EstadoPes.AsNoTracking()
                       : _context.EstadoPes;
            return await query.ToListAsync();
        }
        public override async Task<EstadoPe> GetByIdAsync(int idestadope, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.EstadoPes.AsNoTracking()
                                   : _context.EstadoPes;

            return await query.FirstOrDefaultAsync(x => x.IdEstadoPe == idestadope);
        }
        public override async Task<(int totalRegistros, IEnumerable<EstadoPe> registros)> GetAllAsync(
        int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.EstadoPes.AsNoTracking()
                                  : _context.EstadoPes;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreEstadoPe.ToLower().Contains(search));
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
