using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BO
{
    public class To_Do_List
    {
        ToDoListFunction tf = new ToDoListFunction();

        public void addAssaignedWork(string username,string name, string todo,string date, string tablename)
        {
            String[] token = tablename.Split();
            string table = "";
            for (int k = 0; k < token.Length; k++)
            {
                table += token[k];
            }
            tf.addToDo(username, name, todo, date, table);
        }
    }
}
