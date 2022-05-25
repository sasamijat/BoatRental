using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoatsMontenegro.AuthenticationAndAuthorization
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}