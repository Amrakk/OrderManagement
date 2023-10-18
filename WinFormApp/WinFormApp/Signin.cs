using GUI;
using GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Signin : DevExpress.XtraEditors.XtraForm
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            using (OrderManagementContext dbContext = new OrderManagementContext())
            {
                User user = dbContext.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Email or password is incorrect");
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

    }
}
