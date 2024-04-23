using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Repository.Core
{
    public class ComponenteRepository : GenericCoreRepository<Componente>, IComponenteRepository
    {
        public ComponenteRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
        //CAMBIOS BY LUIS
        public async Task<List<Componente>> GetComponenteByMateriaAsync(int idSub, int idplan, int idmat) => await
            _context.Componentes.Where(x => x.IdPlanEstudio == idplan && x.IdSubtipoComponente == idSub && x.IdMateria == idmat).ToListAsync();

        public async Task<List<Componente>> GetAllComponentes(int idplan, int idmat) => await
            _context.Componentes.Where(x => x.IdPlanEstudio == idplan && x.IdMateria == idmat).ToListAsync();


    }
}
