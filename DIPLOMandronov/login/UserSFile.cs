using Npgsql;
using System;
using System.Windows.Forms;

namespace DIPLOMandronov
{
    public class User
    {
             
        
        public Boolean getBool(String lvlUser, String nickname, String password)
        {
            DB db = new DB();
           

            if (lvlUser == "Администратор")
            {
                String query = "SELECT * FROM user_admin WHERE nickname = '" + nickname + "' AND password = '" + password + "'";
                NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection());
                db.adapter.SelectCommand = command;
                db.adapter.Fill(db.table);
                if (db.table.Rows.Count > 0) return true;
            }
            else if(lvlUser == "Работник")
            {
                String query = "SELECT * FROM user_rabotnik WHERE nickname = '" + nickname + "' AND password = '" + password + "'";
                NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection());
                db.adapter.SelectCommand = command;
                db.adapter.Fill(db.table);
                if (db.table.Rows.Count > 0) return true;
            }
            else if(lvlUser == "Клиент")
            {
                String query = "SELECT * FROM user_client WHERE nickname = '" + nickname + "' AND password = '" + password + "'";
                NpgsqlCommand command = new NpgsqlCommand(query, db.getConnection());
                db.adapter.SelectCommand = command;
                db.adapter.Fill(db.table);
                if (db.table.Rows.Count > 0) return true;
            }
            return false;
        }


    }
    

}