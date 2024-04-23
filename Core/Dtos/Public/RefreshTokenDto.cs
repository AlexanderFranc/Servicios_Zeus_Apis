using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Public
{
    public class RefreshTokenDto
    {
        public DateTime Expira { get; set; }

        public string Token { get; set; } = null!;

        public long Id { get; set; }
    }
}
