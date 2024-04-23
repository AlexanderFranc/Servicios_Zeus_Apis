using Core.Interfaces;
using System.Data;
using Infraestructure.Configuration.Conexion.LoginDB;
using Core.Entidades.Core;

namespace Infraestructure.Repository
{
    public class AsesorRepository : IAsesorRepository
    {
        public List<Asesor> getAsesor()
        {
            List<Asesor> listaAsesores = new List<Asesor>();
            Asesor asesor = new Asesor();            
            DataSet ds_asesor = Conexion.BuscarUISEKALUMNI_ds("info_asesor", "*", "");
            if (ds_asesor.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_asesor.Tables[0].Rows)
                {
                    asesor.ID = Convert.ToInt32(row["id"].ToString());
                    asesor.NOMBRE_ASESOR = row["nombre_asesor"].ToString();
                    asesor.CORREO_ASESOR = row["correo_asesor"].ToString();
                    asesor.ACTIVO = Convert.ToBoolean(row["activo"].ToString());
                    asesor.USUARIO_NAV = row["usuario_nav"].ToString();
                    listaAsesores.Add(asesor);
                    asesor = new Asesor();

                }
            }
            return listaAsesores;

        }
    }
}
