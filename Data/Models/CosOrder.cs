using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CosOrder
{
    public int CosOrderId { get; set; }

    public string? Description { get; set; }

    public string? Address { get; set; }

    public decimal? Deposit { get; set; }

    public DateTime? SlotDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public int? UserId { get; set; }

    public int? FeedbackId { get; set; }

    public int? ServiceId { get; set; }

    public int? CostumeId { get; set; }

    public bool? Status { get; set; }

    public virtual Costume? Costume { get; set; }

    public virtual Feedback? Feedback { get; set; }

    public virtual Service? Service { get; set; }

    public virtual ApplicationUser? ApplicationUser { get; set; }
}
