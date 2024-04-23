using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IIdiomaRepository : IGenericRepository<Idioma>
    {
        Task<List<Idioma>> GetByIdEmpleado(int idEmpl);
        bool SaveIdiomas(IdiomaDto lstIdiomaDto);
        bool EditIdiomas(IdiomaDto lstIdiomaDto, int idIdioma);
    }
}