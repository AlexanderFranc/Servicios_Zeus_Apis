using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Public
{
    public class PerfilDto
    {
        public int IdPerfil { get; set; }

        public string? NombrePerfil { get; set; }

        public string? DescripcionPerfil { get; set; }

        public bool? ActivoPerfil { get; set; }

        public virtual ICollection<AutorizacionDto> AutorizacionsDto { get; } = new List<AutorizacionDto>();

        public virtual ICollection<UsuarioPerfilDto2> UsuarioPerfilsDto { get; } = new List<UsuarioPerfilDto2>();
    }
}
