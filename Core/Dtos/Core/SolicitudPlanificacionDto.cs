using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class SolicitudPlanificacionDto
    {
        public int idNivelEstudio { get; set; }
        public int idMalla { get; set; }
        public int horasSemestralesMateria { get; set; }
        public float creditosMateria { get; set; }
        public int idPlanificacion { get; set; }
        public int idPeriodo { get; set; }
        public string codigoPeriodo { get; set; }
        public int idMateria { get; set; }
        public string codigoMateria { get; set; }
        public string nombreMateria { get; set; }
        public string paralelo { get; set; }
        public int cupo { get; set; }
        public string dniProfesorc { get; set; }
        public string nombresEmp { get; set; }
        public string apellidoEmp { get; set; }
        public int idModalidadPlanificacion { get; set; }
        public string NombreModalidadPe { get; set; }
        public string NombreModalidadp { get; set; }
        public string codigoEspaciosFisicos { get; set; }
        public int idPlanEstudio { get; set; }
        public string CODIGO_PLAN_ESTUDIO_MALLA { get; set; }
        public int idTipoComponente { get; set; }
        public int idPeriodicidad { get; set; }
        public int idEspaciosFisicos { get; set; }
        public int idModalidad { get; set; }
        public int IdEstadoPeriodo { get; set; }
        public int IdNivelInfraestructura { get; set; }
        public int? IdInfraestructura { get; set; }
        public string CodigoSubtipoComponente { get; set; }
        public bool activo { get; set; }
        public string? TipoSolicitud { get; set; }
        public string? FechaSolicitud { get; set; }
        public string? Estado { get; set; }

        //public string? CodigoFacultad { get; set; }
        //public string? NombreFacultad { get; set; }
        //public string? CodigoCarrera { get; set; }
        //public string? NombreCarrera { get; set; }
        //public string? CodigoMalla { get; set; }
        //public string? CodigoMateria { get; set; }
        //public string? NombreMaterias { get; set; }
        //public string? DNIProfesor { get; set; }
        //public string? Profesor { get; set; }
        //public string? Paralelo { get; set; }
        //public int? IdSolicitud { get; set; }
        //public int? IdPlanificacion { get; set; }
        //public string? DNIUsuario { get; set; }
        //public string? Usuario { get; set; }
        //public string? TipoSolicitud { get; set; }
        //public DateTime? FechaSolicitud { get; set; }
        //public string? Estado { get; set; }

    }
}
