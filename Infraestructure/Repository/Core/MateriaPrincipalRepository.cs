using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class MateriaPrincipalRepository: GenericCoreRepository<Materium>, IMateriaprincipalRepository
    {
        public MateriaPrincipalRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
        public override async Task<IEnumerable<Materium>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Materia.AsNoTracking()
                                   : _context.Materia;

            return await query.Include(x=>x.IdUocNavigation)
                              //.Include(x=>x.Componentes)
                              .Include(x => x.IdTipoMateriaCatalogoNavigation).OrderBy(x=>x.NombreMateria).ToListAsync();
        
        
        }


        public override async Task<Materium> GetByIdAsync(int idmateria, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Materia.AsNoTracking()
                                   : _context.Materia;

            return await query.Include(x => x.IdUocNavigation).Include(x => x.Componentes).Include(x=>x.IdTipoMateriaCatalogoNavigation).FirstOrDefaultAsync(x => x.IdMateria == idmateria);
        }
        public override async Task<(int totalRegistros, IEnumerable<Materium> registros)> GetAllAsync(
        int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Materia.AsNoTracking()
                                  : _context.Materia;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreMateria.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query.Include(x => x.Componentes).Include(x=>x.IdTipoMateriaCatalogoNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
