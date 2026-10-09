using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL
{
    public partial class FRM_HOME : Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        public FRM_HOME()
        {
            InitializeComponent();
            List<TB_CAT> list_cat =db.TB_CAT.ToList();
            List<TB_Supp> list_supp =db.TB_Supp.ToList();
            List<TB_Cus> list_cust =db.TB_Cus.ToList();
            List<TB_Pur> list_pur =db.TB_Pur.ToList();
            List<TB_Sell> list_sell =db.TB_Sell.ToList();


            lb_cat.Text= list_cat.Count.ToString();
            lb_supp.Text= list_supp.Count.ToString();
            lb_cust.Text= list_cust.Count.ToString();
            lb_pur.Text= list_pur.Count.ToString();
            lb_sell.Text= list_sell.Count.ToString();


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.FRM_SELL_ADD frm_add = new PL.FRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.FRM_CAT_ADD frm_add = new PL.FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PL.FRM_CUST_ADD frm_add = new PL.FRM_CUST_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.FRM_SUPP_ADD frm_add = new PL.FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PL.FRM_PUR_ADD frm_add = new PL.FRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }
    }
}
