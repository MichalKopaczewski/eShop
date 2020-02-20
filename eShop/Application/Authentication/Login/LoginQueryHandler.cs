using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace eShop.Application.Authentication.Login
{
    public class LoginQueryHandler : BaseRequestHandler, IRequestHandler<LoginQuery, JwtToken>
    {
        public LoginQueryHandler()
        {
        }

        public async Task<JwtToken> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            return new JwtToken()
            {
                Token = ""
            };
        }
    }
}
