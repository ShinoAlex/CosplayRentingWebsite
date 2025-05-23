using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Costume
{
    public int CostumeId { get; set; }

    public string? CostumeName { get; set; }

    public byte[]? Sample { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public int? FeedbackId { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<CosOrder> CosOrders { get; set; } = new List<CosOrder>();

    public virtual Feedback? Feedback { get; set; }
}
