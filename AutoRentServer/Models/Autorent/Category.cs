using System;
using System.Collections.Generic;

namespace AutoRentServer.Models.Autorent;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
