using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class DatosGeneralesSilaboDto
    {
        public int IdCarrera { get; set; } 
        public int IdFacultad { get; set; } 
        public string? CodigoCarrera { get; set; } 
        public string? NombreCarrera { get; set; } 
        public string? CodigoFacultad { get; set; }
        public string? NombreFacultad { get; set; }
        public int IdMateria { get; set; }
        public string? CodigoMateria { get; set; }
        public string? NombreMateria { get; set; }
        public double? CreditosMateria { get; set; }
        public int? HorasSemestralesMateria { get; set; }
        public int IdPlanEstudio { get; set; }
        public string? TipoComponente {  get; set; }
        public int? HorasComponente { get; set; }
        public string? Modalidad { get; set; }
        public string? UnidadCurricular { get; set; }
        public int? AA { get; set; }
        public int? APE { get; set; }
        public int? AC { get; set; }


    }
}
