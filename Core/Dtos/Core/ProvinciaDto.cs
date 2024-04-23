using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class ProvinciaDto
    {
        public int IdProvincia { get; set; }

        public int? IdPais { get; set; }

        public string CodigoProvincia { get; set; } = null!;

        public string? NombreProvincia { get; set; }

        public bool? ActivoProvincia { get; set; }

        //public virtual ICollection<Canton> Cantons { get; } = new List<Canton>();

        //public virtual Pai? IdPaisNavigation { get; set; }

    }
}
