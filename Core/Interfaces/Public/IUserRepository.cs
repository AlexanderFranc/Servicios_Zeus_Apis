using Core.Entidades.Public;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Public
{
    public interface IUserRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByUsernameAsync(string user);
        Task<Usuario> GetByRefreshTokenAsync(string refreshToken);
    }
}
