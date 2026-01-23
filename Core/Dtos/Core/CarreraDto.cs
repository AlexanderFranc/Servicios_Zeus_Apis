using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Core.Dtos.Core
{
    public  class CarreraDto
    {
        [JsonPropertyName("idCarrera")]
        public int IdCarrera { get; set; }

        [JsonPropertyName("idFacultad")]
        public int? IdFacultad { get; set; }

        [JsonPropertyName("idEstadoCarrera")]
        public int? IdEstadoCarrera { get; set; }

        [JsonPropertyName("codigoCarrera")]
        public string? CodigoCarrera { get; set; }

        [JsonPropertyName("nombreCarrera")]
        public string? NombreCarrera { get; set; }

        [JsonPropertyName("siglasCarrera")]
        public string? SiglasCarrera { get; set; }

        [JsonPropertyName("tituloCarrera")]
        public string? TituloCarrera { get; set; }

        [JsonPropertyName("mencionCarrera")]
        public string? MencionCarrera { get; set; }

        [JsonPropertyName("pathdecretoAprobacionCarrera")]
        public string? PathdecretoAprobacionCarrera { get; set; }

        [JsonPropertyName("fechacreaCarrera")]
        public DateTime? FechacreaCarrera { get; set; }

        [JsonPropertyName("fechaactCarrera")]
        public DateTime? FechaactCarrera { get; set; }

        [JsonPropertyName("fechacierraCarrera")]
        public DateTime? FechacierraCarrera { get; set; }

        [JsonPropertyName("activoCarrera")]
        public bool? ActivoCarrera { get; set; }

        //public virtual EstadoCarrera? IdEstadoCarreraNavigation { get; set; }

        //public virtual Facultad? IdFacultadNavigation { get; set; }
    }
}
