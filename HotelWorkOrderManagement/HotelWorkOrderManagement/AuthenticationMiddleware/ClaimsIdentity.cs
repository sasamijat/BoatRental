using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.AuthenticationMiddleware
{
    public class ClaimsIdentity : System.Security.Principal.IIdentity
    {
        public string? AuthenticationType => throw new NotImplementedException();

        public bool IsAuthenticated => throw new NotImplementedException();

        public string? Name => throw new NotImplementedException();


    }
}
