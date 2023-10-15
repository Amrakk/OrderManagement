using System;
using System.Collections.Generic;

namespace GUI.Models;

public partial class Customer
{
    public string CustId { get; set; }

    public string CustName { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
