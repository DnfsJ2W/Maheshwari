using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRS_DAL;

namespace RRS_REPO
{
   public class LoginRepo : ILogin
    {
        SecurityDBEntities db = new SecurityDBEntities();
        public Login vaildateUser(string username, string password)
        {
            Login login = db.Logins.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return login;
        }
    }
}
