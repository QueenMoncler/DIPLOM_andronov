using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOMandronov.admin
{
    internal class DeleteCar
    {
        public bool delete(int row)
        {
            String query = $"DELETE FROM car_admin WHERE id = {row}";
            string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";


            DB dB = new DB();

            NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Автомобиль успешно  удален!");
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка");
                return false;
            }


            connection.Close();
        }
    }
}
