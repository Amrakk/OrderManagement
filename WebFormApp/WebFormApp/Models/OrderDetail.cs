using System;
using System.Collections.Generic;

namespace WebFormApp.Models;

public partial class OrderDetail
{
    public string Id { get; set; } = null!;

    public string? OrderId { get; set; }

    public string? ItemId { get; set; }

    public int? Quantity { get; set; }

    public int? UnitAmount { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Order? Order { get; set; }
}
