using DevExpress.XtraEditors;
using GUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainContent : DevExpress.XtraEditors.XtraForm
    {
        public MainContent()
        {
            InitializeComponent();
        }

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

            dbContext.Orders.LoadAsync().ContinueWith(loadTask =>
            {
                ordersBindingSource.DataSource = dbContext.Orders.Local.ToBindingList();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void gridOrderDetail_Load(object sender, EventArgs e)
        {
            //OrderManagementContext dbContext = new OrderManagementContext();

            //dbContext.OrderDetails.LoadAsync().ContinueWith(loadTask =>
            //{
            //    orderDetailsBindingSource.DataSource = dbContext.OrderDetails.Local.ToBindingList();
            //}, TaskScheduler.FromCurrentSynchronizationContext());
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
            gridItem_Load(sender, e);
            XtraMessageBox.Show("Item Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void btnOrderItemDelete_Click(object sender, EventArgs e)
        {

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

        #endregion

    }
}