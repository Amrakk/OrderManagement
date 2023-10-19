using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class ReportForm : XtraForm
    {
        private string orderID;
        private OrderReport report;

        public ReportForm(string orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            report = new OrderReport(orderID);
            report.CreateDocument();
            docViewerReport.DocumentSource = report;
            docViewerReport.CreateControl();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string pdfFilePath = ".\\PDF\\OrderReport.pdf";

            report.ExportToPdf(pdfFilePath);
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = pdfFilePath,
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(startInfo);
        }
    }
}