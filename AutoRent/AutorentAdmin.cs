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
        }

        private void button_showAllUsers_Click(object sender, EventArgs e)
        {
            List<User> users = connection.GetAllUsers();

            dataGridView_AllUsers.DataSource = users.Select(x => new 
            {
                x.Id, 
                x.Username,
                x.Name,
                x.Password,
                x.Role,
                Rentals = x.Rentals.Count,
            }).ToList();
        }
    }
}
