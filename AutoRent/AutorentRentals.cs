using AutoRent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class AutorentRentals : Form
    {
        Connection connection = new Connection();

        public AutorentRentals()
        {
            InitializeComponent();

            User user = Connection.User;
            List<Rental> rentals = connection.GetRentals(user.Id);
            if (rentals == null)
            {
                MessageBox.Show("Failed to load rentals!");
                Application.Exit();
            }
            //this.label_carName.Text = rentals.Count.ToString();

            foreach (Rental rental in rentals)
            {
                RentalCard rentalCard = new RentalCard(rental);
                flowLayoutPanel_content.Controls.Add(rentalCard);
            }
        }
    }
}
