using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dtos.Public;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Public
{
    public interface IMenuRepository : IGenericRepository<MenuDto>
    {
        Task<ICollection<MenuDto>> menuUsername(string username, string nameaplication);
        Task<ICollection<ItemMenuDto>> findMenuItems(string username, string nameaplication);
    }
}
