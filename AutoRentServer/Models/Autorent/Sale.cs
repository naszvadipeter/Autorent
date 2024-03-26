using System;
using System.Collections.Generic;

namespace AutoRentServer.Models.Autorent;

public partial class Sale
{
    public int Id { get; set; }

    public int? CarId { get; set; }

    public string? Description { get; set; }

    public int? Percent { get; set; }

    public virtual Car? Car { get; set; }
}
