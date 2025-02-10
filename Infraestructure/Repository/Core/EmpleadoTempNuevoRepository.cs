using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System.Data;
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
            int residente = empleadoTempNuevoDto.Residente == false ? 0 : 1;
            if (empleadoTempNuevoDto.IdTitularidad == null)
            {
                idTitularidad = "null";
            }
            else
            {
                idTitularidad = empleadoTempNuevoDto.IdTitularidad.ToString();            
            }
            string ID_NIVEL_ACAD_TIT2 = empleadoTempNuevoDto.IdNivelAcadTit2 == null ? "null" : empleadoTempNuevoDto.IdNivelAcadTit2.ToString();
            string ID_UNIDAD_EDUCATIVA2 = empleadoTempNuevoDto.IdUnidadEducativa2 == null ? "null" : empleadoTempNuevoDto.IdUnidadEducativa2.ToString();
            string ID_CAMPO_AMPLIO2 = empleadoTempNuevoDto.IdCampoAmplio2 == null ? "null" : empleadoTempNuevoDto.IdCampoAmplio2.ToString();
            string ID_CAMPO_ESPECIFICO2 = empleadoTempNuevoDto.IdCampoEspecifico2 == null ? "null" : empleadoTempNuevoDto.IdCampoEspecifico2.ToString();
            string ID_FORMA_PAGO = empleadoTempNuevoDto.IdFormaPago == null ? "null" : empleadoTempNuevoDto.IdFormaPago.ToString();
            string ID_PAIS_RESIDENCIA = empleadoTempNuevoDto.IdPaisResidencia == null ? "null" : empleadoTempNuevoDto.IdPaisResidencia.ToString();


            var campos = "TIPO_IDENTIFICACION= " + empleadoTempNuevoDto.TipoIdentificacion + "," +
                "IDENTIFICACION= '" + empleadoTempNuevoDto.Identificacion + "'," +
                "NOMBRE = '" + empleadoTempNuevoDto.Nombre + "'," +
                "APELLIDO = '" + empleadoTempNuevoDto.Apellido + "'," +
                "CELULAR = '" + empleadoTempNuevoDto.Celular + "'," +
                "EMAIL = '" + empleadoTempNuevoDto.Email + "'," +
                "ID_NIVEL_ACAD_TIT = " + empleadoTempNuevoDto.IdNivelAcadTit + "," +
                "ID_UNIDAD_EDUCATIVA = " + empleadoTempNuevoDto.IdUnidadEducativa + "," +
                "UNIDAD_EDUCATIVA = '" + empleadoTempNuevoDto.UnidadEducativa + "'," +
                "TITULO = '" + empleadoTempNuevoDto.Titulo + "'," +
                "ID_CAMPO_AMPLIO = " + empleadoTempNuevoDto.IdCampoAmplio + "," +
                "ID_CAMPO_ESPECIFICO = " + empleadoTempNuevoDto.IdCampoEspecifico + "," +

                "ID_NIVEL_ACAD_TIT2 = " + ID_NIVEL_ACAD_TIT2 + "," +
                "ID_UNIDAD_EDUCATIVA2 = " + ID_UNIDAD_EDUCATIVA2 + "," +
                "UNIDAD_EDUCATIVA2 = '" + empleadoTempNuevoDto.UnidadEducativa2 + "'," +
                "TITULO2 = '" + empleadoTempNuevoDto.Titulo2 + "'," +
                "ID_CAMPO_AMPLIO2 = " + ID_CAMPO_AMPLIO2 + "," +
                "ID_CAMPO_ESPECIFICO2 = " + ID_CAMPO_ESPECIFICO2 + "," +

                "ID_FACULTAD = " + empleadoTempNuevoDto.IdFacultad + "," +
                "ID_TIPO_EMPLEADO = " + empleadoTempNuevoDto.IdTipoEmpleado + "," +
                "ID_TIPO_CONTRATO = " + empleadoTempNuevoDto.IdTipoContrato + "," +
                "ID_DEDICACION = " + empleadoTempNuevoDto.IdDedicacion + "," +
                "HORARIO =  '" + empleadoTempNuevoDto.Horario + "'," +
                "ID_TITULARIDAD = " + idTitularidad + "," +
                "ID_CATEGORIA = " + empleadoTempNuevoDto.IdCategoria + "," +
                "ID_FORMA_PAGO = " + ID_FORMA_PAGO + "," +   //recibir nulos
                "ID_ESTADO = " + empleadoTempNuevoDto.IdEstado + "," +
                "NIVEL = " + empleadoTempNuevoDto.Nivel + "," +
                "UA= '" + empleadoTempNuevoDto.UA + "'," +
                "FA = GETDATE()," +
                "ID_PERIODO = " + empleadoTempNuevoDto.IdPeriodo + "," +
                //"MOTIVO = '" +empleadoTempNuevoDto.Motivo+"'," +
                //"OBSERVACION = '" +empleadoTempNuevoDto.Observacion+"'",

                "RESIDENTE = " + residente + "," +
                "ID_PAIS_RESIDENCIA = " + ID_PAIS_RESIDENCIA;

            response = Conexion.ActualizarZeus("EMPLEADO_TEMP_NUEVO",
                
                campos,

                " Where ID_EMP_NUEVO = " + idEmpleadoNuevo);

            return response;
        }
        
        public bool ExisteEmpleadoTemp(string identificacion)
        {
            bool response = false;

            DataSet ds_empl_nuevo = Conexion.BuscarZEUS_ds(
                "EMPLEADO_TEMP_NUEVO a\r\ninner join ESTADO_SOLICITUD b\r\non a.ID_ESTADO = b.ID_ESTADO",
                "ID_EMP_NUEVO",
                "where a.IDENTIFICACION='" + identificacion + "' and b.ESTADO<>'RECHAZADO'"
                );

            if (ds_empl_nuevo.Tables[0].Rows.Count > 0) 
            { 
                response = true; 
            }


            return response;
        }

        public bool EditEmpleadoTempNuevoTH(EmpleadoTempNuevoDto empleadoTempNuevoDto, int idEmpleadoNuevo)
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

                
                "ID_TIPO_CONTRATO = " + empleadoTempNuevoDto.IdTipoContrato + "," +                
                "ID_TITULARIDAD = " + idTitularidad + "," +
                "ID_CATEGORIA = " + empleadoTempNuevoDto.IdCategoria + "," +                
                "UA= '" + empleadoTempNuevoDto.UA + "'," +
                "FA = GETDATE()," ,

                " Where ID_EMP_NUEVO = " + idEmpleadoNuevo);

            return response;
        }

    }
}
