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

        public CarCard(AutorentMain main)
        {
            InitializeComponent();
            this.mainForm = main;
        }

        #region Properties

        private string carName;
        private string carCategory;
        private string carPriceOriginal;
        private string carPriceSale;
        private string carSaleAmount;
        private Image carImage;

        [Category("Car properties")]
        public string CarName
        {
            get { return carName; }
            set { carName = value; label_carName.Text = value; }
        }

        [Category("Car properties")]
        public string CarCategory
        {
            get { return carCategory; }
            set { carCategory = value; label_carCategory.Text = value; }
        }

        [Category("Car properties")]
        public string CarPriceOriginal
        {
            get { return carPriceOriginal; }
            set { carPriceOriginal = value; label_carPriceOriginal.Text = value; }
        }

        [Category("Car properties")]
        public string CarPriceSale
        {
            get { return carPriceSale; }
            set { carPriceSale = value; label_carPriceSale.Text = value; }
        }

        [Category("Car properties")]
        public string CarSaleAmount
        {
            get { return carSaleAmount; }
            set { carSaleAmount = value; label_carSaleAmount.Text = value; }
        }

        [Category("Car properties")]
        public Image CarImage
        {
            get { return carImage; }
            set { carImage = value; pictureBox_carImage.Image = value; }
        }

        #endregion

        private void button_seeAvailability_Click(object sender, EventArgs e)
        {
            AutorentCar autorentCarForm = new AutorentCar(carName, carCategory, carPriceOriginal, carPriceSale, carSaleAmount, carImage, mainForm);
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
