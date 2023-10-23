using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOMandronov
{
    internal class DB
    {
        static String vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";
        NpgsqlConnection vConnection = new NpgsqlConnection(vStrConnection);
  
        
        public DataTable table = new DataTable();
        public NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();


        public void openConnection()
        {
            if (vConnection.State == System.Data.ConnectionState.Open)
            {
                vConnection.Close();
            }
        }
        public void closeConnection()
        {
            if (vConnection.State == System.Data.ConnectionState.Closed)
            {
                vConnection.Open();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return vConnection;
        }

    }
}
