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
            try
            {
                if(e.ColumnIndex == 7)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    
                    if(task == "delete")
                    {
                        if(MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //int rowIndex = e.RowIndex;
                            //DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                           // string model = (string)selectedRows[rowIndex].Cells[2].Value;
                            //dataGridView1.Rows.RemoveAt(rowIndex);
                        }
                    }
                }
                if (e.ColumnIndex == 8)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                    if (task == "update")
                    {
                        if (MessageBox.Show("Отправить авто на ремонт?", "Ремонт", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                        }
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error");
            }
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

        private void buttoтDeleteCar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
