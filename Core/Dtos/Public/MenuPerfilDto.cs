using Core.Entidades.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Public
{
    public class MenuPerfilDto
    {
        public int Id { get; set; }

        public int? IdMenu { get; set; }

        public int? IdAplicacion { get; set; }

        public int? IdPerfil { get; set; }

        public string? PermisosAutorizacion { get; set; }

        public virtual MenuDto? IdMenuNavigation { get; set; }
    }
}
