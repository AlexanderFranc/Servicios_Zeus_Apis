using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
namespace Infraestructure.Repository.Core
{
    public class EmpleadoTempNuevoRepository : GenericCoreRepository<EmpleadoTempNuevo>, IEmpleadoTempNuevoRepository
    {
        public EmpleadoTempNuevoRepository(ZeusCoreContext context) : base(context)
        {
        }
    }
}
