using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PlanificacionMallaDto
    {
     
        public int ID_PLANIFICACION {get;set;}
        public int ID_MALLA { get; set; }
        public int ID_MATERIA { get; set; }
        public int ID_NIVEL_ESTUDIO { get; set; }
        public int ID_PLAN_ESTUDIO { get; set; }
        public int ID_PERIODO { get; set; }
        public int ID_PERIODICIDAD { get; set; }
        public int ID_TIPO_PERIODO { get; set; }
        public int ID_MODALIDAD { get; set; }
        public int ID_ESTADO_PERIODO { get; set; }
        public int ID_MODALIDAD_PLANIFICACION { get; set; }
        public int ID_PERIODICIDAD_PLANIFICACION { get; set; }
        public string DNI_PROFESORC { get; set; }
        public int ID_TIPO_COMPONENTE { get; set; }
        public string PARALELO { get; set; }
        public int ID_ESPACIOS_FISICOS { get; set; }
        public int CUPO { get; set; }

    }
}
