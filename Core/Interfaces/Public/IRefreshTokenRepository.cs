using Core.Dtos.Public;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Public
{
    public interface IRefreshTokenRepository: IGenericRepository<RefreshTokenDto>
    {
         Task<ICollection<RefreshTokenDto>> GetRefreshToken(string nombreusuario);
    }
}
