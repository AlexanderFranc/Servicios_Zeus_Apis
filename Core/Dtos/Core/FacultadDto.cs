using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class FacultadDto
    {
        public int IdFacultad { get; set; }

        public int? IdEstadoFacultad { get; set; }

        public int? IdCampus { get; set; }

        public string? NombreFacultad { get; set; }

        public string? DescripcionFacultad { get; set; }

        public string? CodigoFacultad { get; set; }

        public string? ResolucionFacultad { get; set; }

        public DateTime? FechacreaFacultad { get; set; }

        public DateTime? FechaactFacultad { get; set; }

        public DateTime? FechacierreFacultad { get; set; }

        public DateTime? FecharegistroFacultad { get; set; }

        public bool? ActivoFacultad { get; set; }
    }
}
