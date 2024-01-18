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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DIPLOMandronov.admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadData();
        }

        private void admin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            
            AddCar addCar = new AddCar();
            addCar.Show();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewCar_Click(object sender, EventArgs e)
        {
            /*
            carView carView = new carView();
            carView.Show();
            */
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                    if (task == "delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            string cellValue = dataGridView1[0, rowIndex].Value.ToString();
                         

                            DeleteCar deleteCar = new DeleteCar();
                            if (deleteCar.delete(Int32.Parse(cellValue))) dataGridView1.Rows.RemoveAt(rowIndex);

                        }
                    }
                }
                if (e.ColumnIndex == 10)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

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
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void LoadData()
        {
            try
            {
                string vStrConnection = "Server=localhost; port=1625; user id=postgres; password=2402; database=DiplomAndronov ;";
                string query = "select *, 'delete' AS delete, 'update' AS update from car_admin";
                NpgsqlConnection connection = new NpgsqlConnection(vStrConnection);
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "car_admin");
                dataGridView1.DataSource = dataSet.Tables["car_admin"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[10, i] = linkCell;
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
