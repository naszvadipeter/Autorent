﻿using System;
using System.Collections.Generic;

namespace AutoRent.Models
{
    public partial class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
