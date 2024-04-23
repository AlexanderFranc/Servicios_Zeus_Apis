using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class TipoMateriaCatalogoRepository : GenericCoreRepository<TipoMateriaCatalogo>, ITipoMateriaCatalogoRepository
    {
        public TipoMateriaCatalogoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TipoMateriaCatalogo>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.TipoMateriaCatalogos.AsNoTracking()
                                   : _context.TipoMateriaCatalogos;

            return await query.OrderBy(x => x.NombreTipoMateriaCatalogo).ToListAsync();
        }

        public async Task<TipoMateriaCatalogo> GetByIdAsync(int idtipomateriac)
        {
            return await _context.TipoMateriaCatalogos
                                //.Include(x => x.MateriaPrincipals)
                                .FirstOrDefaultAsync(x => x.IdTipoMateriaCatalogo == idtipomateriac);
        }

        public async Task<List<TipoMateriaCatalogo>> GetByNameTipoMateriaCatalogoAsync(string name) => await
            _context.TipoMateriaCatalogos.Where(x => x.NombreTipoMateriaCatalogo == name).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<TipoMateriaCatalogo> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {
           
            var query = noseguimiento ? _context.TipoMateriaCatalogos.AsNoTracking()
                      : _context.TipoMateriaCatalogos;
            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreTipoMateriaCatalogo.ToLower().Contains(search));
            }

            var totalRegistros = await query.CountAsync();

            var registros = await query
                                    //.Include(x => x.MateriaPrincipals)
                                    .Skip((pageIndex - 1) + pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

    }
}
