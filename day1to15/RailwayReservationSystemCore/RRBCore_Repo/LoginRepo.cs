using RRBCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRBCore_Repo
{
    public class LoginRepo : ILogin
    {
        SecurityDBContext db = new SecurityDBContext();
        public Login validateuser(string username, string password)
        {
            Login login = db.Logins.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return login;
        }
    }
}
