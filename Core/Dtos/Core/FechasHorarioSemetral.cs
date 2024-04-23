using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class FechasHorarioSemetral
    {
        public string? dia { get; set; }//1-2-3-4-5-6-7
        public string? descripcion { get; set; }//ocupado por pepito
        public int tipoOcupado { get; set; }//0 desocupado,1 ocupado por alguien,2 ocupado por mi planificacion
        public bool estado { get; set; }//activa o no activa los checks
        public string? horaIF { get; set; }//08:00-09:00

        public bool habilitado  { get; set;}
    }
}
