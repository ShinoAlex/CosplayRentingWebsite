using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string? PaymentType { get; set; }

    public decimal? Deposit { get; set; }

    public bool? Status { get; set; }
}
