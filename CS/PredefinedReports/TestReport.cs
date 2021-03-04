using System;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace ReportingAspNetCorePrintWithoutPreview.PredefinedReports
{
    public partial class TestReport
    {
        public TestReport()
        {
            InitializeComponent();
        }

        private void tableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRTableCell).Text += " Customized";
        }
    }
}
