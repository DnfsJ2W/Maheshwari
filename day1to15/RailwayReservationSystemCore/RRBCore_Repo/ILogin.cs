using RRBCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRBCore_Repo
{
 public   interface ILogin
    {
        Login validateuser(string username, string password);
    }
}
