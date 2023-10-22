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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }
    }
}
