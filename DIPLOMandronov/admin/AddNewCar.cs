using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOMandronov.admin
{
    public partial class AddNewCar : UserControl
    {
        public AddNewCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kyzov = comboBoxTypeKyzov.Text;
            String marka = comboBoxMarka.Text;
            String model = textBoxModel.Text;
            String color = textBoxColor.Text;
            String car_power = textBoxPower.Text;
            String year = textBoxYear.Text;
            String gosNum = textBoxGosNum.Text;


            if (!(kyzov == "Тип кузова" && marka == "Марка" && model == "" && color == "" && car_power == "" && year == "" && gosNum == ""))
            {

                string query = $"INSERT INTO car_admin(kyzov, marka, model, color, car_power, year, gos_num) VALUES('{kyzov}', '{marka}', '{model}','{color}','{car_power}', '{year}','{gosNum}');";
                string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";


                DB dB = new DB();

                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Автомобиль успешно добавлен!");
                    comboBoxTypeKyzov.Text = "Тип кузова";
                    comboBoxMarka.Text = "Марка";
                    textBoxColor.Text = null;
                    textBoxPower.Text = null;
                    textBoxModel.Text = null;
                    textBoxYear.Text = null;
                    textBoxGosNum.Text = null;
                }
                else
                    MessageBox.Show("Ошибка");


                connection.Close();
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
        }
    }
    
}
