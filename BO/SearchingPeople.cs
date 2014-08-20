using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
namespace BO
{
    public class SearchingPeople
    {
        string[] name = new string[100000];
        string[] uname = new string[1000000];

        public int searchResult(string searchkey)
        {
            SearchPeople sp = new SearchPeople(name, uname);
            int rows = 0;
            rows = sp.nameCheck(searchkey);
            return rows;
        }
        
        public string[] peopleDisplay(string searchkey,int flag)
        {
            SearchPeople sp = new SearchPeople(name, uname);
            int rows = 0;
            rows=searchResult(searchkey);

            if (rows != 0)
            {
                if (flag == 1)
                {
                    return name = sp.showingData(searchkey, flag);
                }

                else
                {
                    return uname = sp.showingData(searchkey, flag);
                }
            }

            else
            {
                MessageBox.Show("No Person Found!!!");
                return null;
            }
        }
    }
}
