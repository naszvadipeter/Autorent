using AutoRent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class RentalCard : UserControl
    {
        private AutorentMain mainForm;
        Connection connection = new Connection();

        public RentalCard(Rental rental)
        {
            InitializeComponent();
            this.car = rental.Car;
            this.sale = car.Sale;
            //this.car = connection.GetCar(rental.CarId);
            //this.sale = connection.GetSale(car.saleId);

            //DateTime startDate = DateTime.ParseExact(rental.FromDate.Year + "-" + rental.FromDate.Month + "-" + rental.FromDate.Day, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime toDate = DateTime.ParseExact(rental.ToDate.Year + "-" + rental.ToDate.Month + "-" + rental.ToDate.Day, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //TimeSpan difference = toDate - startDate;
            //int numberOfDays = (int)difference.TotalDays;

            label_carName.Text = car.Name;
            label_fromDate.Text = rental.FromDate.Year + "-" + rental.FromDate.Month + "-" + rental.FromDate.Day;
            label_toDate.Text = rental.ToDate.Year + "-" + rental.ToDate.Month + "-" + rental.ToDate.Day;
            label_totalCost.Text = car.RealPrice * ((rental.ToDate - rental.FromDate).TotalDays + 1) + " Ft";
        }

        #region Properties

        private Car car;
        private Sale sale;

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
    }
}
