using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class EstadoEspacioRepository : GenericCoreRepository<EstadoEspacio>, IEstadoEspacioRepository
    {
        public EstadoEspacioRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<EstadoEspacio>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.EstadoEspacios.AsNoTracking()
                    : _context.EstadoEspacios;

            return await query.ToListAsync();
        }
    }
}
