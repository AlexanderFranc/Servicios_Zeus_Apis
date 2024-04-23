using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Ftp
{
    public class SubirArchivoRequestDto
    {
        public string ArchivoBase64 { get; set; }
        public string PathRemoto { get; set; }
        public string NombreArchivo { get; set; }
    }
}
