using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class PeriodicidadRepository : GenericCoreRepository<Periodicidad>, IPeriodicidadRepository
    {
        public PeriodicidadRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<Periodicidad>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Periodicidads.AsNoTracking()
                       : _context.Periodicidads;
            return await query.ToListAsync();
        }
        public override async Task<Periodicidad> GetByIdAsync(int idperiocidad, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Periodicidads.AsNoTracking()
                                   : _context.Periodicidads;

            return await query.FirstOrDefaultAsync(x => x.IdPeriodicidad == idperiocidad);
        }
        public override async Task<(int totalRegistros, IEnumerable<Periodicidad> registros)> GetAllAsync(
        int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Periodicidads.AsNoTracking()
                                  : _context.Periodicidads;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombrePeriodicidad.ToLower().Contains(search));
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
