using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string? FeedbackName { get; set; }

    public double? Rating { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CosOrder> CosOrders { get; set; } = new List<CosOrder>();

    public virtual ICollection<Costume> Costumes { get; set; } = new List<Costume>();
}
