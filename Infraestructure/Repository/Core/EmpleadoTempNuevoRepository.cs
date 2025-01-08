using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
namespace Infraestructure.Repository.Core
{
    public class EmpleadoTempNuevoRepository : GenericCoreRepository<EmpleadoTempNuevo>, IEmpleadoTempNuevoRepository
    {
        public EmpleadoTempNuevoRepository(ZeusCoreContext context) : base(context)
        {
           
        }

        public bool EditEmpleadoTempNuevo(EmpleadoTempNuevoDto empleadoTempNuevoDto, int idEmpleadoNuevo)
        {
            bool response = false;

            string idTitularidad = "";

            if (empleadoTempNuevoDto.IdTitularidad == null)
            {
                idTitularidad = "null";
            }
            else
            {
                idTitularidad = empleadoTempNuevoDto.IdTitularidad.ToString();            
            }

            response = Conexion.ActualizarZeus("EMPLEADO_TEMP_NUEVO",
                
                //"ID_EMP_NUEVO= " +empleadoTempNuevoDto.IdEmpNuevo +"," +
                "TIPO_IDENTIFICACION= " +empleadoTempNuevoDto.TipoIdentificacion+"," +
                "IDENTIFICACION= '" +empleadoTempNuevoDto.Identificacion+"'," +
                "NOMBRE = '" +empleadoTempNuevoDto.Nombre+"'," +
                "APELLIDO = '" +empleadoTempNuevoDto.Apellido+"'," +
                "CELULAR = '" +empleadoTempNuevoDto.Celular+"'," +
                "EMAIL = '" +empleadoTempNuevoDto.Email+"'," +
                "ID_UNIDAD_EDUCATIVA = " +empleadoTempNuevoDto.IdUnidadEducativa+"," +
                "UNIDAD_EDUCATIVA = '" +empleadoTempNuevoDto.UnidadEducativa+"'," +
                "TITULO = '" +empleadoTempNuevoDto.Titulo+"'," +
                "ID_CAMPO_AMPLIO = " +empleadoTempNuevoDto.IdCampoAmplio+"," +
                "ID_CAMPO_ESPECIFICO = " +empleadoTempNuevoDto.IdCampoEspecifico+"," +
                "ID_FACULTAD = " +empleadoTempNuevoDto.IdFacultad+"," +
                "ID_TIPO_EMPLEADO = " +empleadoTempNuevoDto.IdTipoEmpleado+"," +
                "ID_TIPO_CONTRATO = " +empleadoTempNuevoDto.IdTipoContrato+"," +
                "ID_DEDICACION = " +empleadoTempNuevoDto.IdDedicacion+"," +
                "HORARIO =  '" +empleadoTempNuevoDto.Horario+"'," +
                "ID_TITULARIDAD = " + idTitularidad + "," +
                "ID_CATEGORIA = " +empleadoTempNuevoDto.IdCategoria+"," +
                "ID_FORMA_PAGO = " +empleadoTempNuevoDto.IdFormaPago+"," +
                "ID_ESTADO = " +empleadoTempNuevoDto.IdEstado+"," +
                "NIVEL = " +empleadoTempNuevoDto.Nivel+"," +
                "UA= '" +empleadoTempNuevoDto.UA+"'," +
                "FA = GETDATE()," +
                "ID_PERIODO = " +empleadoTempNuevoDto.IdPeriodo ,
                //"MOTIVO = '" +empleadoTempNuevoDto.Motivo+"'," +
                //"OBSERVACION = '" +empleadoTempNuevoDto.Observacion+"'",


                " Where ID_EMP_NUEVO = " + idEmpleadoNuevo);

            return response;
        }
    }
}
