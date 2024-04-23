using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class CarreraDto
    {
        public int IdCarrera { get; set; }

        public int? IdFacultad { get; set; }

        public int? IdEstadoCarrera { get; set; }

        public string? CodigoCarrera { get; set; }

        public string? NombreCarrera { get; set; }

        public string? SiglasCarrera { get; set; }

        public string? TituloCarrera { get; set; }

        public string? MencionCarrera { get; set; }

        public string? PathdecretoAprobacionCarrera { get; set; }

        public DateTime? FechacreaCarrera { get; set; }

        public DateTime? FechaactCarrera { get; set; }

        public DateTime? FechacierraCarrera { get; set; }

        public bool? ActivoCarrera { get; set; }

        //public virtual EstadoCarrera? IdEstadoCarreraNavigation { get; set; }

        //public virtual Facultad? IdFacultadNavigation { get; set; }
    }
}
