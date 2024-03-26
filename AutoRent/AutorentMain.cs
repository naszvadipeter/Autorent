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

        public AutorentMain(AutorentLogin loginForm)
        {
            InitializeComponent();
            PopulateCars();
            //var con = new Connection();
            comboBox_category.SelectedIndex = 0;
            this.loginForm = loginForm;
        }

        private void PopulateCars()
        {
            CarCard[] carCards = new CarCard[10];
            if (flowLayoutPanel_cars.Controls.Count > 0)
            {
                flowLayoutPanel_cars.Controls.Clear();
            }
            for (int i = 0; i < carCards.Length; i++)
            {
                carCards[i] = new CarCard(this);
                carCards[i].CarName = "Ford Mustang";
                carCards[i].CarCategory = "Petrol";
                carCards[i].CarPriceOriginal = "50.000,-";
                carCards[i].CarPriceSale = "35.000,-";
                carCards[i].CarSaleAmount = "-30%";
                carCards[i].CarImage = Resources.ford_mustang;
                flowLayoutPanel_cars.Controls.Add(carCards[i]);
            }
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
