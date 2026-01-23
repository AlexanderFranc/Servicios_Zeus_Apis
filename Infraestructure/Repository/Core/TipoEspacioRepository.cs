using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class TipoEspacioRepository : GenericCoreRepository<TipoEspacio>, ITipoEspacioRepository
    {
        public TipoEspacioRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TipoEspacio>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.TipoEspacios.AsNoTracking()
                    : _context.TipoEspacios;

            return await query.ToListAsync();
        }
    }
}
