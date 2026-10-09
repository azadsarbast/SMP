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

namespace SMP.PL
{
    public partial class FRM_SELL : Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Sell tb_sell=new TB_Sell();
        BL.Methods methods = new BL.Methods();
         int id;
        public FRM_SELL()
        {
            InitializeComponent();


           
            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Sell.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Sell.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_SELL_ADD frm_add = new PL.FRM_SELL_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
            update_data();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast Toast = new Toast();
            Dialog Dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if(id>0)
            {
                try
                {

                    var rs = MessageBox.Show("هل انت متاكد من هذه العملية ؟", "عملية الحذف", MessageBoxButtons.YesNo);

                    if (rs == DialogResult.Yes)
                    {
                        tb_sell = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_sell).State = EntityState.Deleted;
                        db.SaveChanges();
                        Toast.txt_caption.Text = "تم حذف عملية البيع";
                        Toast.Show();
                        update_data();


                    }

                }
                catch
                {
                    


                }

            }
            else
            {
                Dialog.txt_caption.Text = "لا يوجد عملية بيع لحذفها";
                Dialog.Width = this.Width;
                Dialog.Show();
            }









        }

        private void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Sell.ToList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            PL.FRM_PUR_ADD frm_add = new PL.FRM_PUR_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            //tb_pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();
            //frm_add.edit_name.Text=tb_pur.Pur_Name;
            //frm_add.edit_type.Text=tb_pur.Pur_Type;
            //frm_add.edit_cat.Text=tb_pur.Pur_Cat;
            //frm_add.edit_supp.Text=tb_pur.Pur_Supp;
            //frm_add.edit_det.Text=tb_pur.Pur_Det;
            //frm_add.edit_sell.Text=tb_pur.Pur_Sell.ToString();
            //frm_add.edit_buy.Text=tb_pur.Pur_Buy.ToString();
            //frm_add.edit_gt.Text=tb_pur.Pur_Qt.ToString();
            //frm_add.edit_tsell.Text=tb_pur.Pur_TSell.ToString();
            //frm_add.edit_tbuy.Text=tb_pur.Pur_TBuy.ToString();
            //frm_add.edit_trev.Text=tb_pur.Pur_TRev.ToString();
            frm_add.id = id;
            frm_add.btn_add.Text = "تعديل";
            frm_add.Show();


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edit_search.Text;
            gridControl1.DataSource=db.TB_Sell.Where(x=>x.Sell_Name.Contains(_search) || x.Sell_Cus.Contains(_search) ).ToList();
        }

        private void FRM_SELL_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
