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
    public partial class AddRabotnik : UserControl
    {
        public AddRabotnik()
        {
            InitializeComponent();
           
            LoadData(querySelectTable);
        }
        private string querySelectTable = "Select id,name,surname,login from user_rabotnik";
        private md5 md5;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string nickname = textBoxNickname.Text;
            string password = textBoxPassword.Text;


            if (!(name == "" && surname == "" && nickname == "" && password == ""))
            {

                string query = $"INSERT INTO user_rabotnik(name, surname, login, password) VALUES('{name}', '{surname}', '{nickname}','{md5.hashPassword(password)}');";
                string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";


                DB dB = new DB();

                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Работник успешно добавлен!");
                    LoadData(querySelectTable);
                    textBoxName.Text = null;
                    textBoxSurname.Text = null;
                    textBoxNickname.Text = null;
                    textBoxPassword.Text = null;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddRabotnik_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadData(string query)
        {
            try
            {
                string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";

                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "user_rabotnik");
                dataGridView.DataSource = dataSet.Tables["user_rabotnik"];

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView[3, i] = linkCell;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
