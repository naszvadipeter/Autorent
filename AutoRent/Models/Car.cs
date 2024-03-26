using System;
using System.Collections.Generic;

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

        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
