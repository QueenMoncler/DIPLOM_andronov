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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }
        private string kyzov;
        private string marka;
        private string model;
        private string color;
        private string car_power;
        private string year;
        private string gosNum;

        public void setEdit(string kyzov, string marka, string model, string color, string car_power, string year, string gosNum)
        {
            this.kyzov= kyzov;
            this.marka = marka;
            this.model= model;
            this.color = color;
            this.car_power = car_power;
            this.year = year;
            this.gosNum = gosNum;
        }


        private void label1_Click(object sender, EventArgs e)
        {

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
             

            if (!(kyzov == "Тип кузова" && marka == "Марка" && model == "" && color == "" && car_power == "" && year == "" && gosNum == "")){

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

        private void AddCar_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPower_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGosNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTypeKyzov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
