using System;
using System.Collections.Generic;

namespace AutoRentServer.Models.Autorent;

public partial class Rental
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? CarId { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public DateTime Created { get; set; }

    public virtual Car? Car { get; set; }

    public virtual User? User { get; set; }
}
