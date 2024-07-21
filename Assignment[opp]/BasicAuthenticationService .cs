using Assignment_opp_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_opp_
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
         readonly string storedUsername = "bassim";
         readonly string storedPassword = "1234";
         readonly string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
