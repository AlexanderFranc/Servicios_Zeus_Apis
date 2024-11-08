using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;

namespace Infraestructure.Repository.Core
{
    public class TipoContratoNRepository : GenericCoreRepository<TipoContratoN>, ITipoContratoNRepository
    {
        public TipoContratoNRepository(ZeusCoreContext context) : base(context)
        {
            
        }
    }
}
