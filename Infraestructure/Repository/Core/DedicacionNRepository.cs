using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;

namespace Infraestructure.Repository.Core
{
    public class DedicacionNRepository : GenericCoreRepository<DedicacionN>, IDedicacionNRepository
    {
        public DedicacionNRepository(ZeusCoreContext context) : base(context)
        {

        }
    }
}
