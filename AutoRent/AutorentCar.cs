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

        private string carName;
        private string carCategory;
        private string carPriceOriginal;
        private string carPriceSale;
        private string carSaleAmount;
        private Image carImage;

        public AutorentCar(string carName, string carCategory, string carPriceOriginal, 
            string carPriceSale, string carSaleAmount, Image carImage, AutorentMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            this.carName = carName;
            this.carCategory = carCategory;
            this.carPriceOriginal = carPriceOriginal;
            this.carPriceSale = carPriceSale;
            this.carSaleAmount = carSaleAmount;
            this.carImage = carImage;

            label_carName.Text = carName;
            label_carCategory.Text = carCategory;
            label_carPriceOriginal.Text = carPriceOriginal;
            label_carPriceSale.Text = carPriceSale;
            label_carSaleAmount.Text = carSaleAmount;
            pictureBox_carImage.Image = carImage;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
