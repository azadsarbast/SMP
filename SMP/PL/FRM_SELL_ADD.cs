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
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using SMP.EPL;
namespace SMP.PL
{
    public partial class FRM_SELL_ADD : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Pur tb_pur=new TB_Pur();
       TB_Sell tb_sell=new TB_Sell();
        BL.Methods methods = new BL.Methods();
        double qtp, qtn, qtr ;
        public int id;

        public FRM_SELL_ADD()
        {
            InitializeComponent();
        }

        // add or edit 
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast Toast = new Toast();
            Dialog Dialog = new Dialog();
            // check if add or edit
            qtp=Convert.ToDouble(txt_qt.Text);
            qtn=Convert.ToDouble(edit_gt.Text);
            qtr=qtp-qtn;

            if (edit_name.Text == "")
            {
                Dialog.Width = this.Width;
                Dialog.txt_caption.Text = "اسم المادة مطلوب";
                Dialog.Show();


            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    if(qtr>=0)
                    {
                        //add
                        tb_sell.Sell_Name = edit_name.Text;
                        tb_sell.Sell_Cus=edit_cust.Text;
                        tb_sell.Sell_Price = Convert.ToDouble(edit_sell.Text);
                        tb_sell.Sell_Qt = Convert.ToDouble(edit_gt.Text);
                        tb_sell.Sell_TPrice = (Convert.ToDouble(edit_gt.Text))* Convert.ToDouble(edit_sell.Text);
                        tb_sell.Sell_TDate = DateTime.Now;
                        db.TB_Sell.Add(tb_sell);
                        tb_pur.Pur_Qt = qtr;
                       // db.Entry(tb_sell).State=EntityState.Modified;
                        db.SaveChanges();
                        Toast.txt_caption.Text = "تم اجراء العملية بنجاح";
                        Toast.Show();
                        db = new DB_SMPEntities();
                        this.Close();

                    }
                    else
                    {
                        Dialog.Width = this.Width;
                        Dialog.txt_caption.Text = "الكمية غير كافية ";
                        Dialog.Show();

                    }
                       








                }
                else
                {
                    //edit
                    tb_pur.ID = id;
                    tb_pur.Pur_Name = edit_name.Text;
                   // tb_pur.Pur_Type = edit_type.Text;
                    tb_pur.Pur_Cat = edit_name.Text;
                    tb_pur.Pur_Supp = edit_cust.Text;
                   // tb_pur.Pur_Det = edit_det.Text;
                    //tb_pur.Pur_Buy = Convert.ToDouble(edit_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edit_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edit_gt.Text);
                    tb_pur.Pur_TBuy = Convert.ToDouble(txt_buy.Text);
                    tb_pur.Pur_TSell = Convert.ToDouble(txt_sell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(txt_qt.Text);
                    db.Entry(tb_pur).State=EntityState.Modified;
                    db.SaveChanges();
                    Toast.txt_caption.Text = "تم تعديل العملية بنجاح";
                    Toast.Show();
                    db = new DB_SMPEntities();
                    this.Close();



                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {

        }

        private void edit_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edit_sell_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edit_gt_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edit_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.TB_Pur.Where(x => x.Pur_Name == edit_name.Text).FirstOrDefault();
            txt_buy.Text = tb_pur.Pur_Buy.ToString();
            txt_sell.Text = tb_pur.Pur_Sell.ToString();
            txt_qt.Text = tb_pur.Pur_Qt.ToString();
            edit_sell.Text=tb_pur.Pur_Sell.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            var rs1 = db.TB_Pur.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_Cus.Select(x => x.Cus_Name).ToList();

            edit_name.DataSource= rs1;
            edit_cust.DataSource= rs2;

            AutoCompleteStringCollection ACSC1=new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2=new AutoCompleteStringCollection();

            ACSC1.AddRange(rs1.ToArray());
            ACSC2.AddRange(rs2.ToArray());

            edit_name.AutoCompleteCustomSource= ACSC1;
            edit_cust.AutoCompleteCustomSource= ACSC2;

         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_PUR_ADD frm_add = new PL.FRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_CUST_ADD frm_add = new PL.FRM_CUST_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }


        private void pro_cal()
        {
            //sell=Convert.ToDouble(edit_sell.Text);
            ////buy=Convert.ToDouble(edit_buy.Text);
            //qt=Convert.ToDouble(edit_gt.Value);
            //tsell = sell * qt;
            //tbuy=buy * qt;
            //trev = tsell - tbuy;
            //txt_sell.Text = tsell.ToString();
            //txt_buy.Text = tbuy.ToString();
            //txt_qt.Text = trev.ToString();
        }
    }
}
