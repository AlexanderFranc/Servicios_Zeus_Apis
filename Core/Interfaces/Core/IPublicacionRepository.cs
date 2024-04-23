using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IPublicacionRepository : IGenericRepository<Publicacion>
    {
        Task<List<Publicacion>> GetByIdEmpleado(int idEmpl);

        bool SavePublicacion(List<PublicacionDto> lstPublicacionDto);

        //bool EditPublicacion(List<PublicacionDto> lstPublicacionDto, int id);

    }
}
