using Core.Dtos.Core;
using Core.Dtos.Public;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IMateriaComponenteRepository : IGenericRepository<MateriaComponenteDto>
    {
        Task<ICollection<MateriaComponenteDto>> getAllMateriaComponentes();
        Task<ICollection<MateriaComponenteDto>> getAllMateriaComponentesByPlan(string codplan, int id);
        void updatehorasComponente(ComponenteMateriaMallaDto[] componente);

        Task<List<ComponenteMateriaMallaDto>> getComponenteSinPlanificar(int idPlanEstudio, int idMateria, int idPeriodo);
        Task<List<ComponenteMateriaMallaDto>> getAllComponenteSinPlanificar(int idPlanEstudio, int idPeriodo);
        Task<(int totalRegistros, IEnumerable<MateriaComponenteDto> registros)> GetAllPagingAsync(
            int pageIndex, int pageSize, string search
            );
    }
}
