using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
namespace Infraestructure.Repository.Core
{
    public class EmpleadoTempNuevoRepository : GenericCoreRepository<EmpleadoTempNuevo>, IEmpleadoTempNuevoRepository
    {
        public EmpleadoTempNuevoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public bool SaveIdiomas(IdiomaDto idio)
        {
            bool response = false;
            string fechaInicioSQL = idio.FechaEmision != null ? "'" + Convert.ToDateTime(idio.FechaEmision).ToString("yyyy-MM-dd") + "'" : "null";

            if (idio.IdIdioma == 0)
            {
                response = Conexion.InsertarZeusCore("IDIOMA", "ID_EMP, IDIOMA, INSTITUCION, NIVEL, FECHA_EMISION, CERTIFICACION, CERTIFICADO",
                                           idio.IdEmp + ",'" + idio.Idioma1 + "','" + idio.Institucion + "','" + idio.Nivel + "'," +
                                           fechaInicioSQL + "," +
                                           Convert.ToInt32(idio.Certificacion) + ",'" + idio.Certificado + "'");
            }
            else
            {
                response = Conexion.ActualizarZeus("IDIOMA", "ID_EMP = " + idio.IdEmp + ", IDIOMA = '" + idio.Idioma1 + "', INSTITUCION = '" + idio.Institucion +
                    "', NIVEL = '" + idio.Nivel + "', FECHA_EMISION = " + fechaInicioSQL +
                    ", CERTIFICACION = " + Convert.ToInt32(idio.Certificacion) + ", CERTIFICADO = '" + idio.Certificado +
                    "'", " Where ID_IDIOMA = " + idio.IdIdioma);
            }


            return response;
        }
    }
}
