﻿using Npgsql;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kyzov = comboBoxTypeKyzov.Text;
            String marka = comboBoxMarka.Text;
            String model = textBoxModel.Text;
            String year = textBoxYear.Text;
            String gosNum = textBoxGosNum.Text;

            String query = $"INSERT INTO car(kyzov, marka, model, year, gos_num) VALUES('{kyzov}', '{marka}', '{model}', '{year}','{gosNum}');";
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
                textBoxModel.Text = null;
                textBoxYear.Text = null;
                textBoxGosNum.Text = null;
            }
            else
                MessageBox.Show("Ошибка");
            

            connection.Close();
        }
    }
}
