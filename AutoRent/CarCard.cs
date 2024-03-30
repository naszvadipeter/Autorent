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
    public partial class CarCard : UserControl
    {
        private AutorentMain mainForm;

        public CarCard(Car car, AutorentMain main)
        {
            InitializeComponent();
            this.car = car;
            this.mainForm = main;

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

        #region Properties

        private Car car;

        [Category("Car properties")]
        public string CarName
        {
            get { return car.Name; }
        }

        [Category("Car properties")]
        public string CarCategory
        {
            get { return car.Category.Name; }
        }

        [Category("Car properties")]
        public string CarPriceOriginal
        {
            get { return car.DailyPrice + " Ft"; }
        }

        [Category("Car properties")]
        public string CarPriceSale
        {
            get { return car.RealPrice + " Ft"; }
        }

        [Category("Car properties")]
        public string CarSaleAmount
        {
            get { return car.Discount + "%"; }
        }

        [Category("Car properties")]
        public Image CarImage
        {
            get { return car.CarImage; }
        }

        #endregion

        private void button_seeAvailability_Click(object sender, EventArgs e)
        {
            AutorentCar autorentCarForm = new AutorentCar(car, mainForm);
            mainForm.Hide();
            autorentCarForm.Show();
            autorentCarForm.FormClosed += AutorentCar_FormClosed;
        }

        private void AutorentCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
