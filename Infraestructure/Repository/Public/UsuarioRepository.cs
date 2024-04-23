
using System.Linq.Expressions;
using Core.Entidades.Public;
using Core.Interfaces;
using Core.Interfaces.Public;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
//using Apis_Zeus.Dtos;
namespace Infraestructure.Repository.Public
{
    public class UsuarioRepository : GenericPublicRepository<Usuario>, IUserRepository
    {
        public UsuarioRepository(Configuration.Zeus.Public.ZeusPublicContext context) : base(context)
        {

        }
        public async Task<Usuario> GetByUsernameAsync(string username)
        {


            return await _context.Usuarios.Include(x => x.RefreshTokens)                     
                                .Include(x => x.UsuarioPerfils)
                                .FirstOrDefaultAsync(u => u.NombreUsuario.ToLower() == username.ToLower());
                                
        }
        public async Task<Usuario> GetByRefreshTokenAsync(string refreshToken)
        {
            return await _context.Usuarios.Include(x => x.RefreshTokens)//.FirstOrDefaultAsync(u => u.DniUsuario.ToLower() == username.ToLower());                      
                                 .Include(x => x.UsuarioPerfils)
                                 .FirstOrDefaultAsync(u => u.RefreshTokens.Any(x=>x.Token==refreshToken));
        }

    }
}
