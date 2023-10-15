namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            customersBindingSource = new System.Windows.Forms.BindingSource(components);
            itemsBindingSource = new System.Windows.Forms.BindingSource(components);
            ordersBindingSource = new System.Windows.Forms.BindingSource(components);
            panelMain = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mainToolStripMenuItem
            // 
            mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            mainToolStripMenuItem.Text = "Main";
            mainToolStripMenuItem.Click += mainToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mainToolStripMenuItem, reportToolStripMenuItem, filterToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1460, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // customersBindingSource
            // 
            customersBindingSource.DataSource = typeof(Models.Customer);
            // 
            // itemsBindingSource
            // 
            itemsBindingSource.DataSource = typeof(Models.Item);
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataSource = typeof(Models.Order);
            // 
            // panelMain
            // 
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 24);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1460, 944);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1460, 968);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Panel panelMain;
    }
}