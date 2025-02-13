using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;

namespace Infraestructure.Repository.Core
{
    public class CategoriaEmpRepository : GenericCoreRepository<CategoriaEmp>, ICategoriaEmpRepository
    {
        public CategoriaEmpRepository(ZeusCoreContext context) : base(context)
        {

        }
    }
}
