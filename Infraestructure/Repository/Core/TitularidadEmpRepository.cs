using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class TitularidadEmpRepository : GenericCoreRepository<TitularidadEmp>, ITitularidadEmpRepository
    {
        public TitularidadEmpRepository(ZeusCoreContext context) : base(context)
        {

        }
    }
}
