using System;
using System.Collections.Generic;

namespace AutoRent.Models
{
    public partial class Sale
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int Percent { get; set; }

        public virtual Car Car { get; set; }
    }
}
