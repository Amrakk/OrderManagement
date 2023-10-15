using System;
using System.Collections.Generic;

namespace GUI.Models;

public partial class OrderDetail
{
    public string Id { get; set; }

    public string OrderId { get; set; }

    public string ItemId { get; set; }

    public int? Quantity { get; set; }

    public int? UnitAmount { get; set; }

    public virtual Item Item { get; set; }

    public virtual Order Order { get; set; }
}
