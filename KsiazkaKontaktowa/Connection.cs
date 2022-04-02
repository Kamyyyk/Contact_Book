using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace KsiazkaKontaktowa
{
    internal class Connection
    {
        public SQLiteConnection myConnection;
        public Connection()
        {
            myConnection = new SQLiteConnection("Data Source=C:/Users/Kamyk/source/repos/KsiazkaKontaktowa/KsiazkaKontaktowa/ContactBook.sqlite");
        }

        public void Open()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void Close()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

    }
}

