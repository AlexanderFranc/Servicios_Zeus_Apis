using Servicios_Zeus.Dtos;
using Core.Interfaces;
using Infraestructure.Configuration.Zeus.Public;

using Microsoft.EntityFrameworkCore;
using Core.Interfaces.Public;
using Infraestructure.Mappers;

namespace Infraestructure.Repository.Public
{
    public class RolesRepository : IRolesUserRepository
    {
        private readonly ZeusPublicContext _context;
        public RolesRepository(ZeusPublicContext context)
        {
            _context = context;

        }

        public async Task<ICollection<UsuarioPerfilDto>> GetRolesUsuario(string nombreperfil,string nombreaplicacion)
        {

            var collection = await _context.Perfils
                .Join(_context.UsuarioPerfils,a => a.IdPerfil,b => b.IdPerfil,
                (a, b) => new { a, b }).Join(_context.Aplicacions, d => d.b.IdAplicacion, c => c.IdAplicacion, (d, c) => new {d,c})
                .Select(y => new
                {
                    y.d.b.NombreUsuario,
                    y.d.a.IdPerfil,
                    y.d.b.ActivoPerfilUsuario,
                    y.d.a.NombrePerfil,
                    y.d.a.DescripcionPerfil,
                    y.c.NombreAplicacion,
                    y.c.ActivoAplicacion
                })
                .Where(x => x.NombreUsuario == nombreperfil && x.NombreAplicacion== nombreaplicacion && x.ActivoPerfilUsuario==true && x.ActivoAplicacion==true).OrderByDescending(x => x.IdPerfil).ToListAsync();

            return collection.MapTo<ICollection<UsuarioPerfilDto>>();

        }

    }
}
