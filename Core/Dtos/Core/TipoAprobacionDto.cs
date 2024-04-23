using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoAprobacionDto
    {
        public int IdTipoAprobacion { get; set; }

        public string? NombreTipoAprobacion { get; set; }

        public string? CodigoTipoAprobacion { get; set; }

        public string? ObservacionesTipoAprobacion { get; set; }

        public bool? ActivoTipoAprobacion { get; set; }

        public virtual ICollection<Correquisito> Correquisitos { get; } = new List<Correquisito>();

        public virtual ICollection<Materium> Materia { get; } = new List<Materium>();

        public virtual ICollection<Prerrequisito> Prerrequisitos { get; } = new List<Prerrequisito>();
    }
}
