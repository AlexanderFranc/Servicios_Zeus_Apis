namespace Core.Dtos.Core
{
    public class SaveSolicitudPlanEmpDto
    {
        public List<SolicitudDto> lstSolicitudDto { get; set; }
        public int idEmpleadoNuevo { get; set; }
        public List<ProfesorSDto> lstProfesorSDto { get; set; }
    }
}
