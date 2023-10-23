using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DIPLOMandronov.admin
{
    public partial class carView : Form
    {
        public carView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";
                string query = "select *, 'delete' AS delete, 'update' AS update from car";
                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "car");
                dataGridView1.DataSource = dataSet.Tables["car"];

                for(int i = 0; i<dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[8, i] = linkCell;
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carView_Load(object sender, EventArgs e)
        {

            LoadData();
        }
    }
}
