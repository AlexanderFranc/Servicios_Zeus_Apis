using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class ProvinciaRepository : GenericCoreRepository<Provincium>, IProvinciaRepository
    {
        public ProvinciaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Provincium>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Provincia.AsNoTracking()
                    : _context.Provincia;

            return await query
                                .Include(x => x.IdPaisNavigation)
                                .ToListAsync();
        }

        public override async Task<Provincium> GetByIdAsync(int idprovincia, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Provincia.AsNoTracking()
                                   : _context.Provincia;

            return await query
                                .Include(a => a.IdPaisNavigation)
                                .FirstOrDefaultAsync(x => x.IdProvincia == idprovincia);
        }

        public async Task<List<Provincium>> GetByIdPaisAsync(int id) => await 
            _context.Provincia.Where(x => x.IdPais == id).ToListAsync();

        public async Task<List<Provincium>> GetByCodProvincia(string cod) => await
            _context.Provincia.Where(x => x.CodigoProvincia == cod).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Provincium> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Provincia.AsNoTracking()
                                  : _context.Provincia;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoProvincia.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdPaisNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public async Task<List<Provincium>> GetAllByProvincia()
        {
            return await _context.Provincia.
                            Include(x => x.Cantons).
                            ThenInclude(x => x.Parroquia).
                            ToListAsync();
        }
    }
}
