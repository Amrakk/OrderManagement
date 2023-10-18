using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using GUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainContent : DevExpress.XtraEditors.XtraForm
    {
        private Order currentOrder;
        private List<string> newOrderDetailID = new List<string>();
        public MainContent()
        {
            InitializeComponent();
        }

        public string CurrentOrderID { get { return currentOrder?.OrderId; } }

        #region Load Data
        private void gridItem_Load(object sender, EventArgs e)
        {
            OrderManagementContext dbContext = new OrderManagementContext();

            dbContext.Items.LoadAsync().ContinueWith(loadTask =>
            {
                itemsBindingSource.DataSource = dbContext.Items.Local.ToBindingList();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridCustomer_Load(object sender, EventArgs e)
        {
            OrderManagementContext dbContext = new OrderManagementContext();

            dbContext.Customers.LoadAsync().ContinueWith(loadTask =>
            {
                customersBindingSource.DataSource = dbContext.Customers.Local.ToBindingList();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridOrder_Load(object sender, EventArgs e)
        {
            OrderManagementContext dbContext = new OrderManagementContext();

            dbContext.Orders
                .Include(o => o.Cust)
                .Include(o => o.OrderDetails)
                .LoadAsync()
                .ContinueWith(loadTask =>
                    {
                        ordersBindingSource.DataSource = dbContext.Orders.Local.ToBindingList();
                    }, TaskScheduler.FromCurrentSynchronizationContext()
                );

        }

        #endregion

        #region Clear Btn
        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerAddress.Clear();
            txtCustomerEmail.Clear();
        }
        private void btnItemClear_Click(object sender, EventArgs e)
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtItemColor.Clear();
        }

        private void btnOrderClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtOrderCustomerID.Clear();
            txtOrderDate.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            gridOrderDetail.DataSource = new BindingList<OrderDetail>();
        }

        #endregion

        #region Add Btn
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            var id = txtCustomerID.Text;
            var name = txtCustomerName.Text;
            var address = txtCustomerAddress.Text;
            var email = txtCustomerEmail.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                XtraMessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                if (dbContext.Customers.Find(id) != null)
                {
                    XtraMessageBox.Show("Customer ID already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (email.Contains("@") == false)
            {
                XtraMessageBox.Show("Please enter a valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customer = new Customer()
            {
                CustId = id,
                CustName = name,
                Address = address,
                Email = email
            };

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
            btnCustomerClear_Click(sender, e);
            gridCustomer_Load(sender, e);
            XtraMessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            var id = txtItemID.Text;
            var name = txtItemName.Text;
            var color = txtItemColor.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(color))
            {
                XtraMessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                if (dbContext.Items.Find(id) != null)
                {
                    XtraMessageBox.Show("Item ID already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Item item = new Item()
            {
                ItemId = id,
                ItemName = name,
                Color = color
            };

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                dbContext.Items.Add(item);
                dbContext.SaveChanges();
            }
            btnItemClear_Click(sender, e);
            gridItem_Load(sender, e);
            XtraMessageBox.Show("Item Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            var orderDetails = gridOrderDetail.DataSource as BindingList<OrderDetail>;
            var orderID = txtOrderID.Text;
            var customerID = txtOrderCustomerID.EditValue?.ToString();
            var orderDate = txtOrderDate.Text;

            if (string.IsNullOrEmpty(orderID) || string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(orderDate.ToString()))
            {
                XtraMessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (orderDetails == null || orderDetails.Count == 0)
            {
                XtraMessageBox.Show("Please add at least one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                if (dbContext.Orders.Find(orderID) != null)
                {
                    XtraMessageBox.Show("Order ID already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string latestOrderDetail = newOrderDetailID.Count() > 0 ? newOrderDetailID.ElementAt(newOrderDetailID.Count - 1) : null;
                int latestDbNumber = latestOrderDetail != null ? int.Parse(latestOrderDetail.Substring("detail".Length)) : 0;

                foreach (var item in orderDetails)
                {
                    latestDbNumber++;
                    item.Id = "detail" + latestDbNumber;
                    item.OrderId = orderID;
                }

                Order order = new Order()
                {
                    OrderId = orderID,
                    CustId = customerID,
                    OrderDate = DateTime.ParseExact(orderDate.ToString(), "MM/dd/yyyy", new CultureInfo("en-US")),
                    OrderDetails = orderDetails
                };

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
            }

            gridOrder_Load(sender, e);
            btnOrderClear_Click(sender, e);
            XtraMessageBox.Show("Order Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Edit Btn
        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            var id = txtCustomerID.Text;
            var name = txtCustomerName.Text;
            var address = txtCustomerAddress.Text;
            var email = txtCustomerEmail.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                XtraMessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email.Contains("@") == false)
            {
                XtraMessageBox.Show("Please enter a valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customer = new Customer()
            {
                CustId = id,
                CustName = name,
                Address = address,
                Email = email
            };

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                var customerEdit = dbContext.Customers.Find(id);
                if (customerEdit == null)
                {
                    XtraMessageBox.Show("Customer ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customerEdit.CustName = name;
                customerEdit.Address = address;
                customerEdit.Email = email;
                dbContext.SaveChanges();
            }
            btnCustomerClear_Click(sender, e);
            gridCustomer_Load(sender, e);
            XtraMessageBox.Show("Customer Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            var id = txtItemID.Text;
            var name = txtItemName.Text;
            var color = txtItemColor.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(color))
            {
                XtraMessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Item item = new Item()
            {
                ItemId = id,
                ItemName = name,
                Color = color
            };

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                var itemEdit = dbContext.Items.Find(id);
                if (itemEdit == null)
                {
                    XtraMessageBox.Show("Item ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                itemEdit.ItemName = name;
                itemEdit.Color = color;
                dbContext.SaveChanges();
            }
            btnItemClear_Click(sender, e);
            gridItem_Load(sender, e);
            XtraMessageBox.Show("Item Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            var orderID = txtOrderID.Text;
            var orderDate = txtOrderDate.Text;
            var customerID = txtOrderCustomerID.EditValue?.ToString();

            if (string.IsNullOrEmpty(orderID) || string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(orderDate.ToString()))
            {
                XtraMessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                var orderEdit = dbContext.Orders.Find(orderID);
                if (orderEdit == null)
                {
                    XtraMessageBox.Show("Order ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                orderEdit.CustId = customerID;
                orderEdit.OrderDate = DateTime.ParseExact(orderDate.ToString(), "MM/dd/yyyy", new CultureInfo("en-US"));
                dbContext.SaveChanges();
            }

            gridOrder_Load(sender, e);
            btnOrderClear_Click(sender, e);
            XtraMessageBox.Show("Order Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Delete Btn
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"Are you sure want to delete {(gridViewCustomer.GetFocusedRow() as Customer).CustName}?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (OrderManagementContext dbContext = new OrderManagementContext())
                {
                    var customer = dbContext.Customers.Find((gridViewCustomer.GetFocusedRow() as Customer).CustId);
                    dbContext.Customers.Remove(customer);
                    dbContext.SaveChanges();
                }
                gridCustomer_Load(sender, e);
                XtraMessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"Are you sure want to delete {(gridViewItem.GetFocusedRow() as Item).ItemName}?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (OrderManagementContext dbContext = new OrderManagementContext())
                {
                    var item = dbContext.Items.Find((gridViewItem.GetFocusedRow() as Item).ItemId);
                    dbContext.Items.Remove(item);
                    dbContext.SaveChanges();
                }
                gridItem_Load(sender, e);
                XtraMessageBox.Show("Item Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"Are you sure want to delete {(gridViewOrder.GetFocusedRow() as Order).OrderId}?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (OrderManagementContext dbContext = new OrderManagementContext())
                {
                    var order = dbContext.Orders.Find((gridViewOrder.GetFocusedRow() as Order).OrderId);

                    if (order != null)
                    {
                        var orderDetails = dbContext.OrderDetails.Where(od => od.OrderId == order.OrderId).ToList();
                        dbContext.OrderDetails.RemoveRange(orderDetails);

                        dbContext.Orders.Remove(order);
                        dbContext.SaveChanges();
                    }
                }
                gridOrder_Load(sender, e);
                XtraMessageBox.Show("Order Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrderItemDelete_Click(object sender, EventArgs e)
        {
            gridViewOrderDetail.DeleteSelectedRows();
        }
        #endregion

        #region Focused Row
        private void gridViewCustomer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridview = sender as GridView;
            if (gridview.IsDataRow(e.FocusedRowHandle))
            {
                var customer = gridview.GetFocusedRow() as Customer;
                txtCustomerID.Text = customer.CustId;
                txtCustomerName.Text = customer.CustName;
                txtCustomerAddress.Text = customer.Address;
                txtCustomerEmail.Text = customer.Email;
            }
        }

        private void gridViewItem_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridview = sender as GridView;
            if (gridview.IsDataRow(e.FocusedRowHandle))
            {
                var item = gridview.GetFocusedRow() as Item;
                txtItemID.Text = item.ItemId;
                txtItemName.Text = item.ItemName;
                txtItemColor.Text = item.Color;
            }
        }

        private void gridViewOrder_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridview = sender as GridView;
            if (gridview.IsDataRow(e.FocusedRowHandle))
            {
                var order = gridview.GetFocusedRow() as Order;

                currentOrder = order;
                txtOrderID.Text = order.OrderId;
                txtOrderCustomerID.Text = order.Cust.CustId;
                txtOrderDate.EditValue = order.OrderDate.ToString("MM/dd/yyyy");
                gridOrderDetail.DataSource = order.OrderDetails;
            }
        }

        #endregion


        private void gridViewOrderDetail_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView grid = sender as GridView;
            OrderDetail newOrderDetail = (grid.GetRow(e.RowHandle) as OrderDetail);

            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                var orderDetailsQuery = dbContext.OrderDetails.Select(o => o.Id);
                int latestDbNumber = 0;

                if (orderDetailsQuery.Any())
                {
                    latestDbNumber = orderDetailsQuery
                        .AsEnumerable()
                        .Select(id => int.TryParse(id.Substring("detail".Length), out int number) ? number : (int?)null)
                        .Where(number => number.HasValue)
                        .Max() ?? 0;
                }

                int latestGridNumber = 0;

                if (gridViewOrderDetail.DataRowCount > 0)
                {
                    int gridNumber;
                    string currentId = (gridViewOrderDetail.GetRow(gridViewOrderDetail.DataRowCount - 1) as OrderDetail).Id;
                    if (int.TryParse(currentId.Substring("detail".Length)?.ToString(), out gridNumber))
                        latestGridNumber = gridNumber;
                }

                int newNumber = Math.Max(latestDbNumber, latestGridNumber) + 1;
                newOrderDetail.Id = "detail" + newNumber;
                newOrderDetailID.Add(newOrderDetail.Id);
            }

            newOrderDetail.Quantity = 0;
            newOrderDetail.UnitAmount = 0;
        }



    }

}
