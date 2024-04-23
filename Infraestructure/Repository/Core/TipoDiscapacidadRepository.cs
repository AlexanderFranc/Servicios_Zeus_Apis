using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class TipoDiscapacidadRepository : GenericCoreRepository<TipoDiscapacidad>, ITipoDiscapacidadRepository
    {
        public TipoDiscapacidadRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TipoDiscapacidad>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.TipoDiscapacidads.AsNoTracking()
                    : _context.TipoDiscapacidads;

            return await query
                                .ToListAsync();
        }

        public override async Task<TipoDiscapacidad> GetByIdAsync(int idtipoDisc, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.TipoDiscapacidads.AsNoTracking()
                                   : _context.TipoDiscapacidads;

            return await query
                                .FirstOrDefaultAsync(x => x.IdTipoDiscapacidad == idtipoDisc);
        }

        public override async Task<(int totalRegistros, IEnumerable<TipoDiscapacidad> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.TipoDiscapacidads.AsNoTracking()
                                  : _context.TipoDiscapacidads;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.TipoDiscapacidad1.ToLower().Contains(search));
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
