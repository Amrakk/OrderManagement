﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DevExpress.DataAccess.Native;
using WinFormApp;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new MainContent());
        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainContent());
        }

        private void reportOnCurrentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null && currentChildForm is MainContent && (currentChildForm as MainContent).CurrentOrderID != null)
                OpenChildForm(new ReportForm((currentChildForm as MainContent).CurrentOrderID));
            else
                XtraMessageBox.Show("Please select an order first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}