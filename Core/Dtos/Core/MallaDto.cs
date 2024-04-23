using System;
using System.Collections.Generic;

namespace Core.Dtos.Core
{
    public partial class MallaDto
    {
        public int IdMalla { get; set; }

        public int IdMateria { get; set; }

        public int IdNivelEstudio { get; set; }

        public int IdPlanEstudio { get; set; }

        public int? OrdenMalla { get; set; }

        public DateTime? FecharegMalla { get; set; }

        public string? UsuarioregMalla { get; set; }

        public string? UsuarioactMalla { get; set; }

        public string? UsuarioelimMalla { get; set; }

        public bool? ActivoMalla { get; set; }

        public string? ObservacionMalla { get; set; }

        public virtual MateriaPrincipalDto IdMateriaNavigation { get; set; } = null!;

    }
}
