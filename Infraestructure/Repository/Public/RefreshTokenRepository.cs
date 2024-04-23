using AutoMapper;
using Core.Dtos.Public;
using Core.Entidades.Public;
using Core.Interfaces.Public;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Public
{
    public class RefreshTokenRepository : GenericPublicRepository<RefreshTokenDto>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(Configuration.Zeus.Public.ZeusPublicContext context) : base(context)
        {

        }

        public async Task<ICollection<RefreshTokenDto>> GetRefreshToken(string nombreusuario)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RefreshToken, RefreshTokenDto>();
            });


            var mapper = new Mapper(config);

            var query =  from c in _context.RefreshTokens.AsQueryable()
                        where c.NombreUsuario == nombreusuario
                        select mapper.Map<RefreshTokenDto>(c);

            return await query.ToListAsync();
        }
    }
}
