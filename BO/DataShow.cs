using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BO
{
    public class DataShow
    {
        public string[] datashow(string username)
        {
            ShowData sd = new ShowData(username);

            String[] result = new String[20];


            result = sd.showingName();

            return result;
        }


    }
}
