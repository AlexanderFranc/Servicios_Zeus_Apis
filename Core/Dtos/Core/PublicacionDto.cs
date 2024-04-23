using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PublicacionDto
    {
        public int IdPublicacion { get; set; }

        public int? IdEmp { get; set; }

        public int? IdTipoPublicacion { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Isbn { get; set; }

        public string? Issn { get; set; }

        public string? Editorial { get; set; }

        public string? RegPropiedadIntelectual { get; set; }

        public string? Revista { get; set; }

        public string? Referencia { get; set; }

        public int Ano { get; set; }

        public string BaseDatos { get; set; } = null!;

        public string? Url { get; set; }

    }
}
