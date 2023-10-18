using System;
using System.Collections.Generic;

namespace WebFormApp.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string? CustId { get; set; }

    public virtual Customer? Cust { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
