using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class CampoEspecificoRepository : GenericCoreRepository<CampoEspecifico>, ICampoEspecificoRepository
    {
        public CampoEspecificoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<CampoEspecifico>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.CampoEspecificos.AsNoTracking()
                    : _context.CampoEspecificos;

            return await query
                                //.Include(x => x.IdCa)
                                .ToListAsync();
        }

        public override async Task<CampoEspecifico> GetByIdAsync(int idcamp, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.CampoEspecificos.AsNoTracking()
                                   : _context.CampoEspecificos;

            return await query
                                //.Include(x => x.IdCa)
                                .FirstOrDefaultAsync(x => x.IdCe == idcamp);
        }

        public async  Task<List<CampoEspecifico>> GetByCampoAmplio(int idcamp) => await
            _context.CampoEspecificos.Where(x => x.IdCa == idcamp).ToListAsync();
    }
}
