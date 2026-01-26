using Core.Dtos.Core;
using Core.Interfaces.Generico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IMateriaEquivalenteGestionRepository : IGenericRepository<MateriaEquivalenteGestionDto>
    {
        List<MateriaEquivalenteGestionDto> getPlanificacionEquivalente(string periodo, int idMallaEquiv);
        Task<bool> CrearMateriaEquivalente(MateriaEquivalenteInputDto input);
        Task<bool> EditarMateriaEquivalente(MateriaEquivalenteInputDto input);
    }
}