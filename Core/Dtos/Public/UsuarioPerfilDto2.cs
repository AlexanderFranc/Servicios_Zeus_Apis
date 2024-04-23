using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Public
{
    public class UsuarioPerfilDto2
    {
        public string NombreUsuario { get; set; } = null!;

        public int IdPerfil { get; set; }

        public bool? ActivoPerfilUsuario { get; set; }

        public virtual PerfilDto perfilDto { get; set; } = null!;

        public virtual UsuarioPerfilDto2 usuarioPerfilDto { get; set; } = null!;
    }
}
