using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Public
{
    public class AutorizacionDto
    {
        public int IdAutorizacion { get; set; }

        public int? IdPerfil { get; set; }

        public int? IdMenu { get; set; }

        public int? IdMenus { get; set; }

        public int? IdPerfiles { get; set; }

        public string? PermisosAutorizacion { get; set; }

        public bool? ActivoAutorizacion { get; set; }

        public virtual MenuDto? IdMenuNavigation { get; set; }

    }
}
