using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Util.Auth
{
    public static class GettersAuthenticatedUser
    {
        public static string GetCompanyId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentException(nameof(principal));
            }

            var claim = principal.FindFirst("EMPRESAID");
            return claim?.Value;
        }

        public static string GetId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentException(nameof(principal));
            }

            var claim = principal.FindFirst("Id");
            return claim?.Value;
        }

    }
}
