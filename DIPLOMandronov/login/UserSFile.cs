using Npgsql;
using Npgsql.Schema;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace DIPLOMandronov
{
    public class User
    {

        public Boolean getBool(String lvlUser, String nickname, String password)
        {
            DB db = new DB();
            string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";

            if (lvlUser == "Администратор")
            {
                md5 md = new md5();
                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                //MessageBox.Show($"SELECT (password = crypt('{password}', password)) AS password FROM user_admin where nickname = '{nickname} '");
                //String query = $"INSERT INTO user_admin(nickname, password) VALUES ('{nickname}', '{md5.hashPassword(password)}');";
                String query = $"SELECT * FROM user_admin WHERE nickname = '{nickname}' AND password = '{md5.hashPassword(password)}'";
                 //String query = $"SELECT (password = crypt('{password}', password)) AS password FROM user_admin where nickname = '{nickname} '";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                db.adapter.SelectCommand = command;
                db.adapter.Fill(db.table);
                if (db.table.Rows.Count > 0)
                {
                   db.closeConnection();
                   return true;
                }
                connection.Close();
            }
            


            else if (lvlUser == "Работник")
            {
                md5 md = new md5();
                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                //MessageBox.Show($"SELECT (password = crypt('{password}', password)) AS password FROM user_admin where nickname = '{nickname} '");
                //String query = $"INSERT INTO user_rabotnik(nickname, password) VALUES ('{nickname}', '{md5.hashPassword(password)}');";
                String query = $"SELECT * FROM user_admin WHERE nickname = '{nickname}' AND password = '{md5.hashPassword(password)}'";
                 //String query = $"SELECT (password = crypt('{password}', password)) AS password FROM user_admin where nickname = '{nickname} '";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();

                //command.ExecuteNonQuery();
                db.adapter.SelectCommand = command;
                db.adapter.Fill(db.table);
                if (db.table.Rows.Count > 0)
                {
                   db.closeConnection();
                   return true;
                }
               
                connection.Close();
            }
            else if (lvlUser == "Клиент")
            {
                md5 md = new md5();
                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                //MessageBox.Show($"SELECT (password = crypt('{password}', password)) AS password FROM user_admin where nickname = '{nickname} '");
                //String query = $"INSERT INTO user_client(nickname, password) VALUES ('{nickname}', '{md5.hashPassword(password)}');";
                String query = $"SELECT * FROM user_admin WHERE nickname = '{nickname}' AND password = '{md5.hashPassword(password)}'";
                //String query = $"SELECT (password = crypt('{password}', password)) AS password FROM user_admin where nickname = '{nickname} '";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                //command.ExecuteNonQuery();
                 db.adapter.SelectCommand = command;
                 db.adapter.Fill(db.table);
                 if (db.table.Rows.Count > 0)
                 {
                    db.closeConnection();
                    return true;
                 }
                
                connection.Close();
            }
            
            //db.closeConnection();
            return false;
        }


    }
    

}