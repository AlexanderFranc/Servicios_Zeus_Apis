
using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class PaisRepository : GenericCoreRepository<Pai>, IPaisRepository
    {
        public PaisRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
        public override async Task<IEnumerable<Pai>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Pais.AsNoTracking()
                       : _context.Pais;
            return await query
                                .Include(x => x.Provincia)
                                .ThenInclude(x => x.Cantons)
                                .ThenInclude(x=>x.Parroquia)
                                .ToListAsync();
        }


        public override async Task<Pai> GetByIdAsync(int idpais, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Pais.AsNoTracking()
                                   : _context.Pais;

            return await query

                                .Include(x => x.Provincia)
                                .ThenInclude(x => x.Cantons)
                                .ThenInclude(x => x.Parroquia)
                                .FirstOrDefaultAsync(x => x.IdPais == idpais);
        }

        public async Task<List<Pai>> GetByCodPaisAsync(string cod) => await
                _context.Pais.Where(x => x.CodigoPais == cod).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Pai> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Pais.AsNoTracking()
                                  : _context.Pais;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoPais.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.Provincia)
                                .ThenInclude(x => x.Cantons)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

    }
}
