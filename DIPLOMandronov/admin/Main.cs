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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dataGridDBView.Visible = true;
        }

        private void buttonDataGridDBView_Click(object sender, EventArgs e)
        {
            dataGridDBView.Visible = true;
            addNewCar.Visible = false;
            addRabotnik.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridDBView.Visible = false;
            addNewCar.Visible = true;
            addRabotnik.Visible = false;
        }

        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            dataGridDBView.Visible = false;
            addNewCar.Visible = false;
            addRabotnik.Visible = true;
        }
    }
}
