using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class MateriasMatriculadasEstudianteDto
    {
            public string Name { get; set; }
            public string Cedula { get; set; }
            public string NombreModalidadPe { get; set; } 
            public string Mallau { get; set; }
            public string CodCli { get; set; }
            public string CodAlumno { get; set; }
            public string CodCentro { get; set; }
            public int Nivel { get; set; }
            public string CodAsignatura { get; set; }
            public string NombreAsignatura { get; set; }
            public string CodEquivalente { get; set; }
            public decimal Creditos { get; set; }
            public string Seccion { get; set; }
            public string Estado { get; set; }
            public DateTime Fecha { get; set; }
            public int NFactura { get; set; }
            public bool MarcarEliminar { get; set; }
            public bool Marcada { get; set; }
            public string Semestre { get; set; }
            public string UserInsert { get; set; }
            public string NFacturaBorrado { get; set; }
            public string Origen { get; set; }
            public string UserFactura { get; set; }
            public string NuevoCursoNAV { get; set; }
            public bool AlumnoAntiguo { get; set; }
            public string Tipo { get; set; }
        

    }
}
