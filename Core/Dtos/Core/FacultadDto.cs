﻿﻿﻿﻿﻿﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Core.Dtos.Core
{
    public class FacultadDto
    {
        [JsonPropertyName("idFacultad")]
        public int IdFacultad { get; set; }

        [JsonPropertyName("idEstadoFacultad")]
        public int? IdEstadoFacultad { get; set; }

        [JsonPropertyName("idCampus")]
        public int? IdCampus { get; set; }

        [JsonPropertyName("nombreFacultad")]
        public string? NombreFacultad { get; set; }

        [JsonPropertyName("descripcionFacultad")]
        public string? DescripcionFacultad { get; set; }

        [JsonPropertyName("codigoFacultad")]
        public string? CodigoFacultad { get; set; }

        [JsonPropertyName("resolucionFacultad")]
        public string? ResolucionFacultad { get; set; }

        [JsonPropertyName("fechacreaFacultad")]
        public DateTime? FechacreaFacultad { get; set; }

        [JsonPropertyName("fechaactFacultad")]
        public DateTime? FechaactFacultad { get; set; }

        [JsonPropertyName("fechacierreFacultad")]
        public DateTime? FechacierreFacultad { get; set; }

        [JsonPropertyName("fecharegistroFacultad")]
        public DateTime? FecharegistroFacultad { get; set; }

        [JsonPropertyName("activoFacultad")]
        public bool? ActivoFacultad { get; set; }
    }
}
