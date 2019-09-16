using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClient.Models
{
    public class TokenModel
    {
        public JwtSecurityToken Token { get; set; }
    }
}
