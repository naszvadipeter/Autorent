﻿using AutoRent.Models;
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
        AutorentLogin loginForm;
        Connection connection;

        public AutorentMain(AutorentLogin loginForm)
        {
            InitializeComponent();
            connection = new Connection();

            comboBox_category.SelectedIndex = 0;
            this.loginForm = loginForm;

            PopulateCars();
        }

        private void PopulateCars()
        {
            List<Car> cars = connection.GetAllCars();
            if (flowLayoutPanel_cars.Controls.Count > 0)
            {
                flowLayoutPanel_cars.Controls.Clear();
            }
            foreach (Car car in cars)
            {
                CarCard carCard = new CarCard(car, this);
                flowLayoutPanel_cars.Controls.Add(carCard);
            }
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
