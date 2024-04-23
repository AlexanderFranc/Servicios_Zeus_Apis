using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class NivelEstudioRepository: GenericCoreRepository<NivelEstudio>, INivelEstudioRepository
    
    {
        public NivelEstudioRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
        public override async Task<IEnumerable<NivelEstudio>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.NivelEstudios.AsNoTracking()
                       : _context.NivelEstudios;
            return await query.ToListAsync();
        }
        public override async Task<NivelEstudio> GetByIdAsync(int id, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.NivelEstudios.AsNoTracking()
                                   : _context.NivelEstudios;

            return await query.FirstOrDefaultAsync(x => x.IdNivelEstudio == id);
        }
        public override async Task<(int totalRegistros, IEnumerable<NivelEstudio> registros)> GetAllAsync(
        int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.NivelEstudios.AsNoTracking()
                                  : _context.NivelEstudios;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreNivelEstudio.ToLower().Contains(search));
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
