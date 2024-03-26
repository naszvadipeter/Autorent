using System;
using System.Collections.Generic;

namespace AutoRent.Models
{
    public partial class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
