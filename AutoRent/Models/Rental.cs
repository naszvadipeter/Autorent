using System;
using System.Collections.Generic;

namespace AutoRent.Models
{
    public partial class Rental
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CarId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime Created { get; set; }

        public virtual Car Car { get; set; }

        public virtual User User { get; set; }
    }
}
