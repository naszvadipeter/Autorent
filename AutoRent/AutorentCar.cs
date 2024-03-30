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
    public partial class AutorentCar : Form
    {
        AutorentMain mainForm;

        Car car;

        public AutorentCar(Car car, AutorentMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.car = car;

            label_carName.Text = car.Name;
            label_carCategory.Text = car.Category.Name;
            label_carPriceOriginal.Text = car.DailyPrice + " Ft";
            label_carPriceSale.Text = car.RealPrice + " Ft";
            label_carSaleAmount.Text = "-" + car.Discount + "%";
            pictureBox_carImage.Image = car.CarImage;

            if (car.IsDiscounted)
            {
                label_carPriceSale.Visible = true;
                label_carSaleAmount.Visible = true;
                label_carPriceOriginal.Font = new Font(label_carPriceOriginal.Font, FontStyle.Strikeout);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
