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
using SMP.EPL;
namespace SMP.PL
{
    public partial class FRM_PUR_ADD : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Pur tb_pur=new TB_Pur();
        BL.Methods methods = new BL.Methods();
        double buy, sell, qt, tbuy, tsell, trev;
        public int id;

        public FRM_PUR_ADD()
        {
            InitializeComponent();
        }

        // add or edit 
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast Toast = new Toast();
            Dialog Dialog = new Dialog();
            // check if add or edit
            if (edit_name.Text == "")
            {
                Dialog.Width = this.Width;
                Dialog.txt_caption.Text = "اسم الصنف مطلوب";
                Dialog.Show();


            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //add
                  tb_pur.Pur_Name=edit_name.Text;
                  tb_pur.Pur_Type=edit_type.Text;
                  tb_pur.Pur_Cat=edit_cat.Text;
                  tb_pur.Pur_Supp = edit_supp.Text;
                    tb_pur.Pur_Det = edit_det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edit_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edit_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edit_gt.Text);
                    tb_pur.Pur_TBuy = Convert.ToDouble(edit_tbuy.Text);
                    tb_pur.Pur_TSell = Convert.ToDouble(edit_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edit_trev.Text);
                    db.TB_Pur.Add(tb_pur);
                    db.SaveChanges();
                    Toast.txt_caption.Text = "تم اجراء العملية بنجاح";
                    Toast.Show();
                    db = new DB_SMPEntities();
                    this.Close();








                }
                else
                {
                    //edit
                    tb_pur.ID = id;
                    tb_pur.Pur_Name = edit_name.Text;
                    tb_pur.Pur_Type = edit_type.Text;
                    tb_pur.Pur_Cat = edit_cat.Text;
                    tb_pur.Pur_Supp = edit_supp.Text;
                    tb_pur.Pur_Det = edit_det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edit_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edit_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edit_gt.Text);
                    tb_pur.Pur_TBuy = Convert.ToDouble(edit_tbuy.Text);
                    tb_pur.Pur_TSell = Convert.ToDouble(edit_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edit_trev.Text);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            edit_cat.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            edit_supp.DataSource = db.TB_Supp.Select(x => x.Supp_Name).ToList();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_CAT_ADD frm_add = new PL.FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_SUPP_ADD frm_add = new PL.FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }


        private void pro_cal()
        {
            sell=Convert.ToDouble(edit_sell.Text);
          buy=Convert.ToDouble(edit_buy.Text);
            qt=Convert.ToDouble(edit_gt.Value);
            tsell = sell * qt;
            tbuy=buy * qt;
            trev = tsell - tbuy;
            edit_tsell.Text = tsell.ToString();
            edit_tbuy.Text = tbuy.ToString();
            edit_trev.Text = trev.ToString();
        }
    }
}
