using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class EmpleadoTempArchivoRepository : GenericCoreRepository<EmpleadoTempArchivo>, IEmpleadoTempArchivoRepository
    {
        public EmpleadoTempArchivoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public async Task<List<EmpleadoTempArchivo>> GetfindByIdEmpN(int idEmpl) => await
           _context.EmpleadoTempArchivos.Where(x => x.IdEmpNuevo == idEmpl).ToListAsync();

        //public async Task<List<EmpleadoTempArchivo>> GetfindEmpArch(int idEmpl, int idTipoArchivo) => await
        //   _context.EmpleadoTempArchivos.Where(x => x.IdEmpNuevo == idEmpl && x.IdTipoArchivo == idTipoArchivo).ToListAsync();

        public async Task<EmpleadoTempArchivo> GetfindEmpArch(int idEmpl, int idTipoArchivo,bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.EmpleadoTempArchivos.AsNoTracking()
                                   : _context.EmpleadoTempArchivos;

            return await query

                                .FirstOrDefaultAsync(x => x.IdEmpNuevo == idEmpl && x.IdTipoArchivo == idTipoArchivo);
        }

        public bool SaveEmpleadoTempArchivo(EmpleadoTempArchivoDto emplTempArchivoDto)
        {
            bool response = false;
            //string fechaInicioSQL = idio.FechaEmision != null ? "'" + Convert.ToDateTime(idio.FechaEmision).ToString("yyyy-MM-dd") + "'" : "null";
            string ds_solicitud = "";

            try
            {
                ds_solicitud = Conexion.deleteZeus("EMPLEADO_TEMP_ARCHIVOS", "ID_EMP_NUEVO=" + emplTempArchivoDto.IdEmpNuevo + " and ID_TIPO_ARCHIVO=" + emplTempArchivoDto.IdTipoArchivo);
            }
            catch 
            { 
            }

            response = Conexion.InsertarZeusCore("EMPLEADO_TEMP_ARCHIVOS", "ID_EMP_NUEVO, ID_TIPO_ARCHIVO, PATH_ARCHIVO",
                                           emplTempArchivoDto.IdEmpNuevo + "," + emplTempArchivoDto.IdTipoArchivo + ",'" + emplTempArchivoDto.PathArchivo + "'");
            


            return response;
        }
    }
}
