using AutoRent.Models;
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
    public partial class AutorentAdmin : Form
    {
        User user;
        Connection connection;

        public AutorentAdmin(User loggedInUser)
        {
            InitializeComponent();

            connection = new Connection();
            this.user = loggedInUser;

            LoadAllUsers();
        }

        private async void LoadAllUsers()
        {
            await new ConnectionWebSocket(ref dataGridView_AllUsers).ConnectWebSocketAsync();
        }

        private async void button_addNewUser_Click(object sender, EventArgs e)
        {
            // Get data from inputs
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string name = textBox_name.Text;
            string role = comboBox_role.SelectedItem?.ToString() ?? null;

            // Check data
            if(username.Equals(string.Empty) || password.Equals(string.Empty) ||  name.Equals(string.Empty) || role == null)
            {
                MessageBox.Show("Fill all form inputs!");
                return;
            }
            
            // Add new user
            await new ConnectionWebSocket(ref dataGridView_AllUsers).SendMessageAsync(username, password, name, role);

            // Reset inputs
            textBox_username.Text = string.Empty;
            textBox_password.Text = string.Empty;
            textBox_name.Text = string.Empty;
            comboBox_role.SelectedItem = null;
        }
    }
}
