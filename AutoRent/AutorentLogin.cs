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
            // This will happen if login was successful :
            AutorentMain mainForm = new AutorentMain(this);
            this.Hide();
            mainForm.Show();
            mainForm.FormClosed += AutorentMain_FormClosed;
        }

        private void AutorentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
