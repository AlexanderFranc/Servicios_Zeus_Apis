using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class TitulosAcademicosRepository : GenericCoreRepository<InfoAcademicaNew>, ITitulosAcademicosRepository
    {
        public TitulosAcademicosRepository(ZeusCoreContext context) : base(context)
        {
        }

        public async Task<List<TitulosAcademicosDto>> getByDni(string identificacion)
        {
            var query = await _context.Empleados.AsNoTracking()
                .Include(x => x.InfoAcademicaNews)
                .ThenInclude(x => x.IdNivelAcademicoNavigation)
                .Include(x => x.InfoAcademicaNews)
                .ThenInclude(x => x.IdUnidadEducativaNavigation)
                .Where(x => x.IdentificacionEmp == identificacion)
                 // Ordenar por FechaEmsision
                .SelectMany(e => e.InfoAcademicaNews.Select(x => new TitulosAcademicosDto
                {
                    Identificacion = e.IdentificacionEmp,
                    IdInfoAcademica = x.IdInfoAcademica,
                    IdNivelAcademico = x.IdNivelAcademico,
                    Institucion = !string.IsNullOrEmpty(x.Institucion) ? x.Institucion : (x.IdUnidadEducativaNavigation != null ? x.IdUnidadEducativaNavigation.NombreUnidadEducativa : null),
                    Titulo = x.Titulo,
                    FechaEmsision = x.FechaEmsision,
                    FechaRegSenecyt = x.FechaRegSenecyt,
                    CertificadoTitulo = x.CertificadoTitulo,
                    CertificadoSenecyt = x.CertificadoSenecyt,
                    Ciudad = x.Ciudad,
                    NivelAcademico1 = x.IdNivelAcademicoNavigation != null ? x.IdNivelAcademicoNavigation.NivelAcademico1 : null
                }))
                .OrderByDescending(x => x.FechaEmsision)
                .ToListAsync();

            return  query;
        }
    }
}