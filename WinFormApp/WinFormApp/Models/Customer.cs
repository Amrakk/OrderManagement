using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GUI.Models;

public partial class Customer
{
    public string CustId { get; set; }

    public string CustName { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public virtual BindingList<Order> Orders { get; set; } = new BindingList<Order>();

    public override string ToString()
    {
        return "Customer{" +
                "custId='" + CustId + '\'' +
                ", custName='" + CustName + '\'' +
                ", email='" + Email + '\'' +
                ", address='" + Address + '\'' +
                '}';
    }
}
