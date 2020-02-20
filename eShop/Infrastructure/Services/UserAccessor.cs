using eShop.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Services
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _accessor;

        public UserAccessor(IHttpContextAccessor accessor)
        {
            _accessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
        }

        public IEnumerable<string> UserRoles()
        {
            var roles = User.Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value);
            return roles;
        }

        public bool UserInRole(string role)
        {
            return UserRoles().Any(item => item.Equals(role, StringComparison.InvariantCultureIgnoreCase));
        }


        public ClaimsPrincipal User => _accessor.HttpContext.User;
    }
}
