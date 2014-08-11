using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BO
{
    public class Edit
    {

        public string editData(string username, string name, string designation, string email, string phoneno, string address, string dob, string gender)
        {
            EditProfile ep = new EditProfile();

            String result = ep.editInfo(username, name, designation, email, phoneno, address, dob, gender);

            return result;
        }
        
        public void changePassword(string username, string password)
        {
            EditProfile ep = new EditProfile();
            ep.editPassword(username, password);
        }
    }
}
