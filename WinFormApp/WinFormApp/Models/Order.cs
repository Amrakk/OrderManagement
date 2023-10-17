using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GUI.Models;

public partial class Order
{
    public string OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public string CustId { get; set; }

    public virtual Customer Cust { get; set; }

    public virtual BindingList<OrderDetail> OrderDetails { get; set; } = new BindingList<OrderDetail>();

    public override string ToString()
    {
        return "Order{" +
                "orderId='" + OrderId + '\'' +
                ", orderDate=" + OrderDate +
                ", custId='" + CustId + '\'' +
                ", cust=" + Cust +
                ", orderDetails=" + OrderDetails.ToString() +
                '}';
    }
}
