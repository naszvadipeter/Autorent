using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

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

        // Plus field (for Image) [not in database]
        public byte[] ByteImage { get; set; }

        // Property
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
    }
}
