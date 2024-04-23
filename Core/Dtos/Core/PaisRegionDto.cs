
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class PaisRegionDto
    {
        public int IdPais { get; set; }

        public string? CodigoPais { get; set; }

        public string? NombrePais { get; set; }

        public bool? ActivoPais { get; set; }

        public virtual ICollection<Region> Regions { get; } = new List<Region>();
    }
}
