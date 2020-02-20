using eShop.Application.Authentication.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class AuthController : BaseController
    {
        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<JwtToken>> Login(LoginQuery loginQuery)
        {
            return await Mediator.Send(loginQuery);
        } 
    }
}
