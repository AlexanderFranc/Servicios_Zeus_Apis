using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Ftp
{
    public interface IFtpRepository
    {
        public void subirArchivoFtp(IFormFile archivo,  string pathRemoto);
        public void SubirArchivoFtp(byte[] archivoBytes, string pathRemoto, string nombreArchivo);
        public string descargararArchivoFtpAbsoluta(string pathremoto);
        //public byte[] descargarArchivoFtp(string pathRemoto);
        public Task<byte[]> descargarArchivoFtp(string pathremoto);
        public bool verificarDirectorio(string pathremoto);
        public void eliminarArchivo(string pathremoto);
        public bool verificarArchvo(string pahremoto);



    }
}
