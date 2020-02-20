using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Application.Authentication.Login
{
    public class LoginQuery : IRequest<JwtToken>
    {
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
