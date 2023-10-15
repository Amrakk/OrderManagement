using System;
using System.Collections.Generic;

namespace GUI.Models;

public partial class Item
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string Color { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
