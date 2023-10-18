namespace WinFormApp
{
    partial class ReportForm
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
            docViewerReport = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // docViewerReport
            // 
            docViewerReport.Dock = System.Windows.Forms.DockStyle.Right;
            docViewerReport.IsMetric = false;
            docViewerReport.Location = new System.Drawing.Point(141, 0);
            docViewerReport.Name = "docViewerReport";
            docViewerReport.Size = new System.Drawing.Size(1319, 944);
            docViewerReport.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Location = new System.Drawing.Point(12, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(112, 70);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1460, 944);
            Controls.Add(btnPrint);
            Controls.Add(docViewerReport);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer docViewerReport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}