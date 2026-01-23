using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Core.Dtos.Core
{
    public class PlanEstudioDto
    {

        [JsonPropertyName("idPlanEstudio")]
        public int IdPlanEstudio { get; set; }

        [JsonPropertyName("idEstadoPe")]
        public int? IdEstadoPe { get; set; }

        [JsonPropertyName("idCarrera")]
        public int? IdCarrera { get; set; }

        [JsonPropertyName("idModalidadPe")]
        public int? IdModalidadPe { get; set; }

        [JsonPropertyName("codigoPlanEstudioMalla")]
        public string? CodigoPlanEstudioMalla { get; set; }

        [JsonPropertyName("numerodecretoCesMalla")]
        public string? NumerodecretoCesMalla { get; set; }

        [JsonPropertyName("pathdecretoCesMalla")]
        public string? PathdecretoCesMalla { get; set; }

        [JsonPropertyName("duracionSemestresMalla")]
        public int? DuracionSemestresMalla { get; set; }

        [JsonPropertyName("periodicidadMalla")]
        public int? PeriodicidadMalla { get; set; }

        [JsonPropertyName("cupoCesMalla")]
        public int? CupoCesMalla { get; set; }

        [JsonPropertyName("fechaAprobacionMalla")]
        public DateTime? FechaAprobacionMalla { get; set; }

        [JsonPropertyName("fechaVigenciaMalla")]
        public DateTime? FechaVigenciaMalla { get; set; }

        [JsonPropertyName("semestreInicioMalla")]
        public string? SemestreInicioMalla { get; set; }

        [JsonPropertyName("semestreFinMalla")]
        public string? SemestreFinMalla { get; set; }

        [JsonPropertyName("pathresolucionactivaMalla")]
        public string? PathresolucionactivaMalla { get; set; }

        [JsonPropertyName("pathresolucioncierreMalla")]
        public string? PathresolucioncierreMalla { get; set; }

        [JsonPropertyName("observacionesMalla")]
        public string? ObservacionesMalla { get; set; }

        [JsonPropertyName("activoMalla")]
        public bool? ActivoMalla { get; set; }

        [JsonPropertyName("componentes")]
        public virtual ICollection<ComponenteDto> Componentes { get; set; } = new List<ComponenteDto>();

        [JsonPropertyName("mallas")]
        public virtual ICollection<MallaDto> Mallas { get; set; } = new List<MallaDto>();

        [JsonPropertyName("idModalidadPeNavigation")]
        public virtual ModalidadPEDto IdModalidadPeNavigation { get; set; }
    }
}
