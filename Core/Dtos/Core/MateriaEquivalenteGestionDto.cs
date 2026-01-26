using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Core.Dtos.Core
{
    public class MateriaEquivalenteGestionDto
    {
        [JsonPropertyName("idMateriaEquivalente")]
        public int IdMateriaEquivalente { get; set; }

        [JsonPropertyName("porcEquiv")]
        public decimal PorcEquiv { get; set; }

        [JsonPropertyName("activoMateriaEquivalente")]
        public bool? ActivoMateriaEquivalente { get; set; }

        // Datos de la Materia Origen (X)
        [JsonPropertyName("idFacultad")]
        public int IdFacultad { get; set; }

        [JsonPropertyName("idCarrera")]
        public int IdCarrera { get; set; }

        [JsonPropertyName("idMalla")]
        public int IdMalla { get; set; }

        [JsonPropertyName("idMateria")]
        public int IdMateria { get; set; }

        [JsonPropertyName("codigoFacultad")]
        public string CodigoFacultad { get; set; } = null!;

        [JsonPropertyName("nombreFacultad")]
        public string NombreFacultad { get; set; } = null!;

        [JsonPropertyName("codigoCarrera")]
        public string CodigoCarrera { get; set; } = null!;

        [JsonPropertyName("nombreCarrera")]
        public string NombreCarrera { get; set; } = null!;

        [JsonPropertyName("codigoPlanEstudioMalla")]
        public string CodigoPlanEstudioMalla { get; set; } = null!;

        [JsonPropertyName("codigoModalidadPe")]
        public string CodigoModalidadPe { get; set; } = null!;

        [JsonPropertyName("nombreModalidadPe")]
        public string NombreModalidadPe { get; set; } = null!;

        [JsonPropertyName("codigoMateria")]
        public string CodigoMateria { get; set; } = null!;

        [JsonPropertyName("nombreMateria")]
        public string NombreMateria { get; set; } = null!;

        // Datos de la Materia Equivalente (Y)
        [JsonPropertyName("idFacultadEq")]
        public int IdFacultadEq { get; set; }

        [JsonPropertyName("idCarreraEq")]
        public int IdCarreraEq { get; set; }

        [JsonPropertyName("idMallaEq")]
        public int IdMallaEq { get; set; }

        [JsonPropertyName("idMateriaEq")]
        public int IdMateriaEq { get; set; }

        [JsonPropertyName("codigoFacultadEq")]
        public string CodigoFacultadEq { get; set; } = null!;

        [JsonPropertyName("nombreFacultadEq")]
        public string NombreFacultadEq { get; set; } = null!;

        [JsonPropertyName("codigoCarreraEq")]
        public string CodigoCarreraEq { get; set; } = null!;

        [JsonPropertyName("nombreCarreraEq")]
        public string NombreCarreraEq { get; set; } = null!;

        [JsonPropertyName("codigoPlanEstudioMallaEq")]
        public string CodigoPlanEstudioMallaEq { get; set; } = null!;

        [JsonPropertyName("codigoModalidadPeEq")]
        public string CodigoModalidadPeEq { get; set; } = null!;

        [JsonPropertyName("nombreModalidadPeEq")]
        public string NombreModalidadPeEq { get; set; } = null!;

        [JsonPropertyName("codigoMateriaEq")]
        public string CodigoMateriaEq { get; set; } = null!;

        [JsonPropertyName("nombreMateriaEq")]
        public string NombreMateriaEq { get; set; } = null!;

        [JsonPropertyName("observacionesMateriaEquivalente")]
        public string? ObservacionesMateriaEquivalente { get; set; }

        [JsonPropertyName("pathautorizacionMateriaEquivalente")]
        public string? PathAutorizacionMateriaEquivalente { get; set; }

        [JsonPropertyName("autorizacionMateriaEquivalente")]
        public bool? AutorizacionMateriaEquivalente { get; set; }

        [JsonPropertyName("creditosMateria")]
        public decimal? CreditosMateria { get; set; }

        [JsonPropertyName("horasSemestralesMateria")]
        public int? HorasSemestralesMateria { get; set; }

        [JsonPropertyName("creditosMateriaEq")]
        public decimal? CreditosMateriaEq { get; set; }

        [JsonPropertyName("horasSemestralesMateriaEq")]
        public int? HorasSemestralesMateriaEq { get; set; }
    }
}
