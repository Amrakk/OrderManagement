using DevExpress.XtraReports.UI;
using GUI.Models;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class OrderReport : DevExpress.XtraReports.UI.XtraReport
    {
        private Order order;
        private BindingList<OrderDetail> orderDetails;
        private BindingList<Item> items;

        public OrderReport(string orderID)
        {
            InitializeComponent();
            using(OrderManagementContext dbContext = new OrderManagementContext())
            {
                order = dbContext.Orders.Find(orderID);
                dbContext.Entry(order).Reference(o => o.Cust).Load();
                dbContext.Entry(order).Collection(o => o.OrderDetails).Load();
                foreach (var orderDetail in order.OrderDetails)
                    dbContext.Entry(orderDetail).Reference(od => od.Item).Load();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = order;
                this.DataSource = bindingSource;
            }
        }
    }
}
