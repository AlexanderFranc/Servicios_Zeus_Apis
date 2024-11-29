using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;

namespace Infraestructure.Repository.Core
{
    public class FormaPagoEmpRepository : GenericCoreRepository<FormaPagoEmp>, IFormaPagoEmpRepository
    {
        public FormaPagoEmpRepository(ZeusCoreContext context) : base(context)
        {

        }
    }
}
