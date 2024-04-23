using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class ContactoEmergenciaRepository : GenericCoreRepository<ContactoEmergencium>, IContactoEmergenciaRepository
    {
        public ContactoEmergenciaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<ContactoEmergencium>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.ContactoEmergencia.AsNoTracking()
                    : _context.ContactoEmergencia;

            return await query
                                .ToListAsync();
        }

        public override async Task<ContactoEmergencium> GetByIdAsync(int idcontacto, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.ContactoEmergencia.AsNoTracking()
                                   : _context.ContactoEmergencia;

            return await query
                                .FirstOrDefaultAsync(x => x.IdContactoEmergencia == idcontacto);
        }

        public async Task<List<ContactoEmergencium>> GetByIdEmpleado(int idEmpl) => await
            _context.ContactoEmergencia.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public bool SaveContactoEmergencia(ContactoEmergencium contacto)
        {
            bool response = false;

                if (contacto.IdContactoEmergencia == 0)
                {
                    response = Conexion.InsertarZeusCore("CONTACTO_EMERGENCIA", "ID_EMP, CONTACTO, TELEFONO, CELULAR, RELACION",
                                               contacto.IdEmp + ", '" + contacto.Contacto + "', '" + contacto.Telefono + "', '" + contacto.Celular + "', '" + contacto.Relacion + "'");
                }
                else
                {
                    response = Conexion.ActualizarZeus("CONTACTO_EMERGENCIA", "ID_EMP = " + contacto.IdEmp + ", CONTACTO = '" + contacto.Contacto + "', TELEFONO = '" + contacto.Telefono +
                                                "', CELULAR = '" + contacto.Celular + "', RELACION = '" + contacto.Relacion + "'", " WHERE ID_CONTACTO_EMERGENCIA = " + contacto.IdContactoEmergencia);
                }
            
            return response;
        }
    }
}
