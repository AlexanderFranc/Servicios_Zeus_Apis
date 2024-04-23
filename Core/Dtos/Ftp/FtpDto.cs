using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Ftp
{
    internal class FtpDto
    {
        public string LocalFilePath { get; set; } // Ruta del archivo en el cliente
        public string RemoteFilePath { get; set; } // Ruta del archivo en el servidor FTP
    }
}
