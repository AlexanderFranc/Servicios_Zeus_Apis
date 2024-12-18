using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class EmpleadoTempArchivoRepository : GenericCoreRepository<EmpleadoTempArchivo>, IEmpleadoTempArchivoRepository
    {
        public EmpleadoTempArchivoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public async Task<List<EmpleadoTempArchivo>> GetfindByIdEmpN(int idEmpl) => await
           _context.EmpleadoTempArchivos.Where(x => x.IdEmpNuevo == idEmpl).ToListAsync();
    }
}
