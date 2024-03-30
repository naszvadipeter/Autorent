using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace AutoRent.Models
{
    public partial class Car
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int DailyPrice { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

        public virtual Sale Sale { get; set; }

        // Plus field (for Image) [not in database]
        public byte[] ByteImage { get; set; }

        #region Properties
        public string Name => $"{Brand} {Model}";

        public Image CarImage
        {
            get
            {
                using (MemoryStream ms = new MemoryStream(this.ByteImage))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
        }

        public bool IsDiscounted => this.Sale != null;

        public int? Discount => this.Sale != null ? this.Sale.Percent : 0;

        public int RealPrice => this.Sale != null ? (int)Math.Round(1.0 * (DailyPrice * (1 - (1.0 * Sale.Percent / 100))), 0) : DailyPrice;

        public List<string> UnavailablePeriods => Rentals.Select(x => $"{x.FromDate.ToString("yyy.MM.dd")} - {x.ToDate.ToString("yyyy.MM.dd")}").ToList();

        public List<string> UnavailableDates
        {
            get
            {
                List<string> allDates = new List<string>();
                foreach (Rental r in Rentals)
                    for (DateTime date = r.FromDate; date <= r.ToDate; date = date.AddDays(1))
                        allDates.Add(date.ToString("yyy.MM.dd"));
                return allDates;
            }
        }
        #endregion

        #region Methods
        public bool IsPeriodAvailable(DateTime fromDate, DateTime toDate)
        {
            List<string> allDates = new List<string>();
            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(1))
                allDates.Add(date.ToString("yyy.MM.dd"));

            return !allDates.Any(x => UnavailableDates.Contains(x));
        }

        public bool IsPeriodAvailable(string fromDate, string toDate)
        {
            return IsPeriodAvailable(DateTime.Parse(fromDate), DateTime.Parse(toDate));
        }
        #endregion
    }
}
