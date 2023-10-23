using DIPLOMandronov.admin;
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


namespace DIPLOMandronov
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String password = textBox2.Text;
            String lvl = comboBox1.Text;
            
            User user = new User();
         
           
                if (lvl == null || lvl == "" || login == "" || password == "")
                {
                    MessageBox.Show("Поле не заполнено");
                }
                else if(user.getBool(lvl, login, password))
                {
                //MessageBox.Show("Выполнено успешно!");
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
          
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
