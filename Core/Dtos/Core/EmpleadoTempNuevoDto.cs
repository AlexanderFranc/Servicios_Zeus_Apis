namespace Core.Dtos.Core
{
    public class EmpleadoTempNuevoDto
    {
        public int IdEmpNuevo { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? Celular { get; set; }
        public string Email { get; set; } = null!;
        public int IdUnidadEducativa { get; set; }
        public string UnidadEducativa { get; set; }
        public string Titulo { get; set; } = null!;
        public int IdCampoAmplio { get; set; }
        public int IdCampoEspecifico { get; set; }
        public int IdFacultad { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdDedicacion { get; set; }
        public string Horario { get; set; } = null!;
        public int IdTitularidad { get; set; }
        public int IdCategoria { get; set; }
        public int IdFormaPago { get; set; }
        public int IdEstado { get; set; }
        public int Nivel { get; set; }
        public string? UC { get; set; } = null!;
        public DateTime? FC { get; set; } 
        public string? UA { get; set; } = null!;
        public DateTime? FA { get; set; } 
    }
}
