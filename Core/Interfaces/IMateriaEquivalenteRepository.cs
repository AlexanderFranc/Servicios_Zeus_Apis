using Core.Dtos.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMateriaEquivalenteRepository : IGenericRepository<MateriaEquivalenteDto>
    {
        List<MateriaEquivalenteDto> getPlanificacionEquivalente(string periodo, int idMallaEquiv);
        List<ComponentesPlanificacionDto> getPlanificacionE(string periodo, int idMallaEquiv);
    }
}
