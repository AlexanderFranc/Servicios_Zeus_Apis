
using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class HorarioRepository : GenericCoreRepository<Horario>, IHorario
    {
        public HorarioRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
       

    }
}
