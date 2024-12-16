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
        public string NombreUnidadEducativa { get; set; }
        public string UnidadEducativa { get; set; }
        public string Titulo { get; set; } = null!;
        public int IdCampoAmplio { get; set; }
        public string CampoAmplio { get; set; } = null!;
        public int IdCampoEspecifico { get; set; }
        public string CampoEspecifico { get; set; } = null!;
        public int IdFacultad { get; set; }
        public string CodigoFacultad { get; set; } = null!;
        public string NombreFacultad { get; set; } = null!;
        public int IdTipoContrato { get; set; }
        public string TipoContrato { get; set; } = null!;
        public int IdDedicacion { get; set; }
        public string Dedicacion { get; set; } = null!;
        public string Horario { get; set; } = null!;
        public int IdTitularidad { get; set; }
        public string Titularidad { get; set; } = null!;
        public int IdCategoria { get; set; }
        public string Categoria { get; set; } = null!;
        public int IdFormaPago { get; set; }
        public string FPago { get; set; } = null!;
        public int IdEstado { get; set; }
        public string Estado { get; set; } = null!;
        public int Nivel { get; set; }
        public string? UC { get; set; } = null!;
        public DateTime? FC { get; set; } 
        public string? UA { get; set; } = null!;
        public DateTime? FA { get; set; }
        public int IdPeriodo { get; set; }
        public string? Periodo { get; set; } = null!;
        public string? Motivo { get; set; } = null!;
        public string? Observacion { get; set; } = null!;
    }
}
