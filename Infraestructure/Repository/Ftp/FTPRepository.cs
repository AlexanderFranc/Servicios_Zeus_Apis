using Core.Dtos.Ftp;
using Core.Interfaces.Ftp;
using Microsoft.AspNetCore.Http;
using Renci.SshNet;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Ftp
{
    public class FTPRepository : IFtpRepository
    {

        private FtpConfiguration _ftpConfiguration;
        public FTPRepository(FtpConfiguration ftpConfiguration)
        {
            _ftpConfiguration = ftpConfiguration;
        }
        public void subirArchivoFtp(IFormFile archivo, string pathremoto)
        {

            using (var client = new SftpClient(_ftpConfiguration.Server, _ftpConfiguration.Port, _ftpConfiguration.Username, _ftpConfiguration.Password))
            {
                client.Connect();

                if (archivo != null && archivo.Length > 0)
                {
                    string fileName = archivo.FileName;
                    using (var memoryStream = new MemoryStream())
                    {
                        archivo.CopyTo(memoryStream);
                        memoryStream.Position = 0;

                        bool existeDirectorio = verificarDirectorio(pathremoto);

                        //if (!existeDirectorio)
                        //{
                        //    client.CreateDirectory(pathremoto);
                        //}

                        client.UploadFile(memoryStream, Path.Combine(pathremoto, fileName));
                    }
                }
                else
                {
                    throw new Exception("No se proporcionó un archivo válido.");
                }
            }
        }

        public void SubirArchivoFtp(byte[] archivoBytes, string pathRemoto, string nombreArchivo)
        {
            try
            {
                using (var client = new SftpClient(_ftpConfiguration.Server, _ftpConfiguration.Port, _ftpConfiguration.Username, _ftpConfiguration.Password))
                {
                    client.Connect();

                    if (archivoBytes != null && archivoBytes.Length > 0)
                    {
                        try
                        {
                            bool existeDirectorio = verificarDirectorio(pathRemoto);
                            //if (!existeDirectorio)
                            //{
                            //    client.CreateDirectory(pathRemoto);
                            //}

                            using (var memoryStream = new MemoryStream(archivoBytes))
                            {
                                client.UploadFile(memoryStream, Path.Combine(pathRemoto, nombreArchivo));
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al cargar el archivo" + ex.Message);
                        }
                        finally
                        {
                            client.Disconnect();
                        }
                    }
                    else
                    {
                        throw new Exception("No se proporcionó un archivo válido.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar el archivo" + ex.Message);

            }
        }
        //metodo para descargar en una ruta absoluta
        public string descargararArchivoFtpAbsoluta(string pathremoto)
        {
            //ejemplo pathremoto: test/empleados/download2.pdf
            string carpetaDescarga = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";
            string nombreArchivo = Path.GetFileName(pathremoto);
            string archivoLocal = Path.Combine(carpetaDescarga, nombreArchivo);

            using (var client = new SftpClient(_ftpConfiguration.Server, _ftpConfiguration.Port, _ftpConfiguration.Username, _ftpConfiguration.Password))
            {
                client.Connect();

                try
                {
                    using (var fileStream = new FileStream(archivoLocal, FileMode.Create))
                    {
                        client.DownloadFile(pathremoto, fileStream);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al descargar el archivo" + ex.Message);
                }
                finally
                {
                    client.Disconnect();
                }

                return archivoLocal;
            }
        }
        public async Task<byte[]> descargarArchivoFtp(string pathremoto)
        {
            using (var client = new SftpClient(_ftpConfiguration.Server, 22, _ftpConfiguration.Username, _ftpConfiguration.Password))
            {
                client.Connect();

                using (var memoryStream = new MemoryStream())
                {
                    try
                    {
                        client.DownloadFile(Path.Combine(pathremoto), memoryStream);
                    }
                    catch (SshException ex)
                    {
                        throw new Exception("Error al descargar el archivo" + ex.Message);

                    }
                    finally
                    {
                        client.Disconnect();

                    }

                    return memoryStream.ToArray();
                }
            }
        }




        public bool verificarDirectorio(string pathremoto)
        {

            using (var client = new SftpClient(_ftpConfiguration.Server, _ftpConfiguration.Port, _ftpConfiguration.Username, _ftpConfiguration.Password))
            {
                client.Connect();
                try
                {
                    if (pathremoto[0] == '/')
                        pathremoto = pathremoto.Substring(1);

                    string[] directories = pathremoto.Split('/');
                    for (int i = 0; i < directories.Length; i++)
                    {
                        string dirName = string.Join("/", directories, 0, i + 1);
                        if (client.Exists(dirName))
                        {
                            SftpFileAttributes attrs = client.GetAttributes(dirName);
                            if (!attrs.IsDirectory)
                            {
                                throw new Exception("not directory");
                            }
                        }
                        else
                        {
                            client.CreateDirectory(dirName);
                        }
                    }
                }
                catch (SshException ex)
                {
                    throw new Exception("Error al descargar el archivo" + ex.Message);

                }
                finally
                {
                    client.Disconnect();
                }

                return true;
            }

        }
        public void eliminarArchivo(string pathremoto)
        {
            using (var client = new SftpClient(_ftpConfiguration.Server, _ftpConfiguration.Port, _ftpConfiguration.Username, _ftpConfiguration.Password))
            {
                client.Connect();
                try
                {

                    client.DeleteFile(Path.Combine(pathremoto));
                }
                catch (SshException ex)
                {
                    throw new Exception("Error al eliminar el archívo" + ex.Message);
                }
                finally
                {
                    client.Disconnect();
                }

            }
        }
        public bool verificarArchvo(string pahremoto)
        {
            using (var client = new SftpClient(_ftpConfiguration.Server, _ftpConfiguration.Port, _ftpConfiguration.Username, _ftpConfiguration.Password))
            {
                client.Connect();

                try
                {
                    var fileInfo = client.Get(pahremoto);
                    return fileInfo != null;
                }
                catch (SshException ex)
                {
                    throw new Exception("No se pudo verificar el archivo" + ex.Message);

                }
                finally
                {
                    client.Disconnect();
                }

            }
        }

    }
}