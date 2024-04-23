using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class CantonRepository : GenericCoreRepository<Canton>, ICantonRepository
    {
        public CantonRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Canton>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Cantons.AsNoTracking()
                    : _context.Cantons;

            return await query
                                .Include(x => x.IdProvinciaNavigation)
                                .ToListAsync();
        }

        public override async Task<Canton> GetByIdAsync(int idcanton, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Cantons.AsNoTracking()
                                   : _context.Cantons;

            return await query
                                .Include(a => a.IdProvinciaNavigation)
                                .FirstOrDefaultAsync(x => x.IdCanton == idcanton);
        }

        public async Task<List<Canton>> GetByCodCanton(string cod)
        {
            return await _context.Cantons
                                    .Where(x => x.CodigoCanton == cod)
                                    .ToListAsync();
        }

        public async Task<List<Canton>> GetByIdProvincia(int id)
        {
            return await _context.Cantons
                                    .Where(x => x.IdProvincia == id)
                                    .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Canton> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Cantons.AsNoTracking()
                                  : _context.Cantons;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoCanton.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdProvinciaNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
