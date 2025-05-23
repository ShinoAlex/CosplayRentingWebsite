using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string? ServiceType { get; set; }

    public virtual ICollection<CosOrder> CosOrders { get; set; } = new List<CosOrder>();
}
