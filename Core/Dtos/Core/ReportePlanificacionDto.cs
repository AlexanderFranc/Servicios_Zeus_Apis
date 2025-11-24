using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ReportePlanificacionDto
    {
        public string CodigoPeriodo { get; set; } = null!;
        public string CodigoTextoPeriodo { get; set; } = null!;
        public string CodigoFacultad { get; set; } = null!;
        public string NombreFacultad { get; set; } = null!;
        public string CodigoCarrera { get; set; } = null!;
        public string NombreCarrera { get; set; } = null!;
        public string CodigoPlanEstudioMalla { get; set; } = null!;
        public string ModalidadPlane { get; set; } = null!;
        public string ModalidadPlanificacion { get; set; } = null!;
        public string PeriodicidadPlanificacion { get; set; } = null!;
        public int NivelMateria { get; set; }
        public string CodigoMateria { get; set; } = null!;
        public string NombreMateria { get; set; } = null!;
        public string Paralelo { get; set; } = null!;
        public double CreditosMateria { get; set; }
        public int HorasSemestralesMateria { get; set; }
        public string DniProfesorc { get; set; } = null!;
        public string Profesor { get; set; } = null!;
        public int PlanificacionCupo { get; set; }
        public string CodigoSubtipoComponente { get; set; } = null!;
        public int HorasComponente { get; set; }

    }
}
