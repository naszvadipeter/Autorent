using AutoRent.Models;
using AutoRent.Properties;
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
    public partial class AutorentMain : Form
    {
        User user;
        Connection connection;

        bool showingDiscountedOnly;
        List<Category> categories;

        public AutorentMain(User loggedInUser)
        {
            InitializeComponent();
            connection = new Connection();
            this.user = loggedInUser;
            showingDiscountedOnly = false;

            categories = connection.GetAllCategories();
            comboBox_category.Items.Add("All");
            foreach (Category category in categories)
            {
                comboBox_category.Items.Add(category.Name);
            }
            comboBox_category.SelectedIndex = 0;

            PopulateCars(false);
        }

        private void PopulateCars(bool discountedOnly)
        {
            int filterID = comboBox_category.SelectedIndex;

            List<Car> cars = connection.GetAllCars();
            if (flowLayoutPanel_cars.Controls.Count > 0)
            {
                flowLayoutPanel_cars.Controls.Clear();
            }
            foreach (Car car in cars)
            {
                if (discountedOnly)
                {
                    if (car.IsDiscounted)
                    {
                        if (filterID == 0 || filterID == car.CategoryId)
                        {
                            CarCard carCard = new CarCard(car, this);
                            flowLayoutPanel_cars.Controls.Add(carCard);
                        }
                    }
                }
                else
                {
                    if (filterID == 0 || filterID == car.CategoryId)
                    {
                        CarCard carCard = new CarCard(car, this);
                        flowLayoutPanel_cars.Controls.Add(carCard);
                    }
                }
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void button_showAll_Click(object sender, EventArgs e)
        {
            showingDiscountedOnly = false;
            PopulateCars(false);
        }

        private void button_showSale_Click(object sender, EventArgs e)
        {
            showingDiscountedOnly = true;
            PopulateCars(true);
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCars(showingDiscountedOnly);
        }

        private void button_previousRents_Click(object sender, EventArgs e)
        {
            AutorentRentals rentals = new AutorentRentals();
            this.Hide();
            rentals.Show();
            rentals.FormClosed += AutorentRentals_FormClosed;
        }
        private void AutorentRentals_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
