using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SMP.PL;

namespace SMP
{
    public partial class Main : Form
    {
        //init forms 
        PL.FRM_CAT frm_cat=new PL.FRM_CAT();
        PL.FRM_HOME frm_home=new PL.FRM_HOME();
        PL.FRM_SUPP frm_supp=new PL.FRM_SUPP();
        PL.FRM_PUR frm_pur=new PL.FRM_PUR();
        PL.FRM_CUST frm_cust=new FRM_CUST();
        PL.FRM_SELL frm_sell=new FRM_SELL();
        PL.FRM_REPORT frm_report = new FRM_REPORT();
        PL.FRM_USER frm_user=new PL.FRM_USER();
        PL.FRM_SETTINGS frm_sett=new FRM_SETTINGS();
        DB_SMPEntities db=new DB_SMPEntities();


        public Main()
        {
            InitializeComponent();
        }

   
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if(pn_navbar.Width==250)
            {
                pn_navbar.Width = 50;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 200;
               

            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenav.Visible = true;
                pn_headernavbar.Height = 207;
               
          }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
            lb_titlepage.Text = "الرئيسة";

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();   
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الاصناف";
            frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
            if(lb_role.Text=="مدير")
            {
                btn_user.Enabled = true;
            }
            else
            {
                btn_user.Enabled = false;
            }


        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الموردين";
           
        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المشتريات";
        }

        private void btn_cust_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cust.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "العملاء";
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المبيعات";

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "التقارير";
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_user.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المستخدمين";
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sett.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الاعدادات";

        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGIN login=new FRM_LOGIN();
            TB_User tb_user=new TB_User();

            tb_user = db.TB_User.Where(x => x.User_State=="True").FirstOrDefault();
            tb_user.User_State = "False";
            db.Entry(tb_user).State = EntityState.Modified;
            db.SaveChanges();
            this.Enabled= false;
            login.Show();
            this.Hide();

        }
    }
}
