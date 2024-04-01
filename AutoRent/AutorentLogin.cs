using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class AutorentLogin : Form
    {
        public AutorentLogin()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Connection con= new Connection();
            if(textBox_username.TextLength==0 ||  textBox_password.TextLength==0)
            {
                MessageBox.Show("All fields are required!");
                return;
            }
            int? loginResult=con.Login(textBox_username.Text,textBox_password.Text);
            if(loginResult!=null)
            { 
            // This will happen if login was successful :
            AutorentMain mainForm = new AutorentMain(this);
            this.Hide();
            mainForm.Show();
            mainForm.FormClosed += AutorentMain_FormClosed;
            }
            else
            {
                MessageBox.Show("Invalid username and/or password!");
            }
        }

        private void AutorentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
