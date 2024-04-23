
using System.Linq.Expressions;
using Core.Entidades.Public;
using Core.Interfaces;
using Core.Interfaces.Public;
using Infraestructure.Configuration.Zeus.Public;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
namespace Infraestructure.Repository.Public
{
    public class UsuarioPerfilRepository : GenericPublicRepository<UsuarioPerfil>, IUsuarioPerfilRepository
    {
        public UsuarioPerfilRepository(Configuration.Zeus.Public.ZeusPublicContext context) : base(context)
        {
        }
    }
}
