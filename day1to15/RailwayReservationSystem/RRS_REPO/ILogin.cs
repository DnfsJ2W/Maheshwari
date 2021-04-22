using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRS_DAL;

namespace RRS_REPO
{
    public interface ILogin
    {
        Login vaildateUser(string username, string password);
    }
}
