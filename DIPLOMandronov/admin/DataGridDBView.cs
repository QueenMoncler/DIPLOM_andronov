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
    public partial class DataGridDBView : UserControl
    {
        public DataGridDBView()
        {
            InitializeComponent();
            string query = "select *, 'delete' AS delete, 'update' AS update from car_admin";
            LoadData(query);
        }

        private void buttonAllauto_Click(object sender, EventArgs e)
        {
            string query = "select *, 'delete' AS delete, 'update' AS update from car_admin";
            LoadData(query);
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
                adapter.Fill(dataSet, "car_admin");
                dataGridViewDB.DataSource = dataSet.Tables["car_admin"];

                for (int i = 0; i < dataGridViewDB.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewDB[10, i] = linkCell;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSedan_Click(object sender, EventArgs e)
        {
            string query = "select *, 'delete' AS delete, 'update' AS update from car_admin where kyzov='Седан'";
            LoadData(query);
        }

        private void buttonUni_Click(object sender, EventArgs e)
        {
            string query = "select *, 'delete' AS delete, 'update' AS update from car_admin where kyzov='Универсал'";
            LoadData(query);
        }

        private void buttonHatchback_Click(object sender, EventArgs e)
        {
            string query = "select *, 'delete' AS delete, 'update' AS update from car_admin where kyzov='Хетчбек'";
            LoadData(query);
        }
    }
}
