using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.Data.ODataLinq.Helpers;
using SMP.EPL;
using DevExpress.XtraReports.UI;

namespace SMP.PL
{
    public partial class FRM_REPORT : Form
    {
       
        
        public FRM_REPORT()
        {
            InitializeComponent();
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            PL.SellReport report = new PL.SellReport();
            report.ShowPreviewDialog();
        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
            Report.PurReport report = new Report.PurReport();
            report.ShowPreviewDialog();
        }

        private void btn_cust_Click(object sender, EventArgs e)
        {
            Report.CustReport report = new Report.CustReport();
            report.ShowPreviewDialog();
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            Report.SuppReport report = new Report.SuppReport();
            report.ShowPreviewDialog();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            Report.UserReport report = new Report.UserReport();
            report.ShowPreviewDialog();
        }
    }
}
