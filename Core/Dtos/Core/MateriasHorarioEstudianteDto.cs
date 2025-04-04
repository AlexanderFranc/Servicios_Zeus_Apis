using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class MateriasHorarioEstudianteDto
    {
            public int IdPlanificacion { get; set; }
            public string CodigoPeriodo { get; set; }
            public int IdPeriodo { get; set; }
            public int IdMalla { get; set; }
            public string CodigoCarrera { get; set; }
            public string CodigoPlanEstudioMalla { get; set; }
            public string ModPlan { get; set; }
            public string CodigoMateria { get; set; }
            public string NombreMateria { get; set; }
            public int NivelMateria { get; set; }
            public string DniProfesor { get; set; }
            public string Profesor { get; set; }
            public string Paralelo { get; set; }
            public int Cupo { get; set; }
            public int Matriculados { get; set; }
            public int Disponible { get; set; }
            public bool Habilitado { get; set; }
            public int IdTipoComponente { get; set; }
            public string CodigoSubtipoComponente { get; set; }
            public decimal CreditosMateria { get; set; }
            public string Lunes { get; set; }
            public string Martes { get; set; }
            public string Miercoles { get; set; }
            public string Jueves { get; set; }
            public string Viernes { get; set; }
            public string Sabado { get; set; }
            public string Domingo { get; set; }
            public bool Seleccionado { get; set; }
        }

    
}
