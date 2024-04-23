using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class EtniaRepository : GenericCoreRepository<Etnium>, IEtniaRepository
    {
        public EtniaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Etnium>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Etnia.AsNoTracking()
                    : _context.Etnia;

            return await query
                                .ToListAsync();
        }

        public override async Task<Etnium> GetByIdAsync(int idetnia, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Etnia.AsNoTracking()
                                   : _context.Etnia;

            return await query
                                .FirstOrDefaultAsync(x => x.IdEtnia == idetnia);
        }

        public override async Task<(int totalRegistros, IEnumerable<Etnium> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Etnia.AsNoTracking()
                                  : _context.Etnia;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Etnia.ToLower().Contains(search));
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
