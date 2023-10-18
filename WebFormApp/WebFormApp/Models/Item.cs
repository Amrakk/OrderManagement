using System;
using System.Collections.Generic;

namespace WebFormApp.Models;

public partial class Item
{
    public string ItemId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string? Color { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
