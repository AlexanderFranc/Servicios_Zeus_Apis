using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;

namespace Infraestructure.Repository.Core
{
    public class EmpleadoTempArchivoRepository : GenericCoreRepository<EmpleadoTempArchivo>, IEmpleadoTempArchivoRepository
    {
        public EmpleadoTempArchivoRepository(ZeusCoreContext context) : base(context)
        {
        }
    }
}
