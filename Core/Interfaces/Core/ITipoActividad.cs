using Core.Entidades.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface ITipoActividadRepository : IGenericRepository<TipoActividad>
    {
        //Task<List<Capacitacion>> GetByCodeFacultadAsync(string cod);
    }
}
