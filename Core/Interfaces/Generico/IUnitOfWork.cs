using Core.Interfaces.Public;

namespace Core.Interfaces.Generico
{
    public interface IUnitOfWork
    {
        //IPaisRepository Paises { get; set; }
        //IRegionRepository Region { get; set; }
        IUserRepository Usuario { get; set; }
        //IUsuarioPerfilRepository UsuarioPerfil { get; set; }
        Task<int> SaveAsync();
    }
}
