using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Core.Dtos.Core
{
    public class MateriaEquivalenteInputDto
    {
        [JsonPropertyName("idMateriaEquivalente")]
        public int IdMateriaEquivalente { get; set; }

        [JsonPropertyName("idMalla")]
        public int IdMalla { get; set; }

        [JsonPropertyName("idMallaEquiv")]
        public int IdMallaEquiv { get; set; }

        [JsonPropertyName("idMateria")]
        public int? IdMateria { get; set; }

        [JsonPropertyName("idMateriaEquiv")]
        public int? IdMateriaEquiv { get; set; }

        [JsonPropertyName("porcEquiv")]
        public decimal PorcEquiv { get; set; }

        [JsonPropertyName("observacionesMateriaEquivalente")]
        public string? ObservacionesMateriaEquivalente { get; set; }

        [JsonPropertyName("pathautorizacionMateriaEquivalente")]
        public string? PathautorizacionMateriaEquivalente { get; set; }

        [JsonPropertyName("autorizacionMateriaEquivalente")]
        public bool? AutorizacionMateriaEquivalente { get; set; }

        [JsonPropertyName("activoMateriaEquivalente")]
        public bool? ActivoMateriaEquivalente { get; set; }
    }
}
