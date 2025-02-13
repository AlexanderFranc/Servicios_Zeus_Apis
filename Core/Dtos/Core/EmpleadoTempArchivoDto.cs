namespace Core.Dtos.Core
{
    public class EmpleadoTempArchivoDto
    {
        public int Id { get; set; }

        public int IdEmpNuevo { get; set; }

        public int IdTipoArchivo { get; set; }

        public string PathArchivo { get; set; } = null!;
    }
}
