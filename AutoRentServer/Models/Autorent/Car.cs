using System;
using System.Collections.Generic;

namespace AutoRentServer.Models.Autorent;

public partial class Car
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public int? DailyPrice { get; set; }

    public int? SaleId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public virtual Sale? Sale { get; set; }
}
