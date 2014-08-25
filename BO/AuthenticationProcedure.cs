using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BO
{
    public class AuthenticationProcedure
    {
        public Boolean authenticationCheck(string username, string pass)
        {
            Authintication au = new Authintication();

            return au.LoginConnection(username,pass);

        }
    }
}
