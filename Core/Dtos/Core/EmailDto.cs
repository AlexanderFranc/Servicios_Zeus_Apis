namespace Core.Dtos.Core
{
    public class EmailDto
    {
        public string toEmail { get; set; }
        public string? cc { get; set; }
        public string subject { get; set; }
        public string title { get; set; }
        public string nombreCoordinador { get; set; }
        public string cedulaDocente { get; set; }
        public string nombreDocente { get; set; }
        public string nombreFacultad { get; set; }
        //public string tipoContrato { get; set; }
        public string periodo { get; set; }
        public string estadoSolicitud { get; set; }
        public string observacionSolicitud { get; set; }
        public int idDedicacion { get; set; }
        public string tipoUsuario { get; set; }

    }
}
