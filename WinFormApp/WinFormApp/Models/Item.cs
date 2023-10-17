using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GUI.Models;

public partial class Item
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string Color { get; set; }

    public virtual BindingList<OrderDetail> OrderDetails { get; set; } = new BindingList<OrderDetail>();

    public override string ToString()
    {
        return "Item{" +
                "itemId='" + ItemId + '\'' +
                ", itemName='" + ItemName + '\'' +
                ", color='" + Color + '\'' +
                '}';
    }
}
