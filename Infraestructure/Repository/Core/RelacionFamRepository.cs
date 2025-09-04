using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;

namespace Infraestructure.Repository.Core
{
    public class RelacionFamRepository : GenericCoreRepository<RelacionFam>, IRelacionFamRepository
    {
        public RelacionFamRepository(ZeusCoreContext context) : base(context)
        {
        }     
    }
}
