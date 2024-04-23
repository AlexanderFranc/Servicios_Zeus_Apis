using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Public
{
    public class ItemMenuDto
    {
        public ItemDto ItemDTO { get; set; }
        public virtual ICollection<ItemDto> ItemsDTO { get; set; } = new List<ItemDto>();
    }
}
