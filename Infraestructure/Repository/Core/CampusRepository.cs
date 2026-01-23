using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class CampusRepository : GenericCoreRepository<Campus>, ICampusRepository
    {
        public CampusRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Campus>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Campuses.AsNoTracking()
                    : _context.Campuses;

            return await query.ToListAsync();
        }
    }
}
