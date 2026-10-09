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
    public partial class FRM_USER : Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_User tb_user=new TB_User();
        BL.Methods methods = new BL.Methods();
         int id;
        public FRM_USER()
        {
            InitializeComponent();

           
            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_User.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_User.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_USER_ADD frm_add=new PL.FRM_USER_ADD();
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
                        tb_user = db.TB_User.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_user).State = EntityState.Deleted;
                        db.SaveChanges();
                        Toast.txt_caption.Text = "تم حذف المستخدم";
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
                Dialog.txt_caption.Text = "لا يوجد مستخدم لحذفه";
                Dialog.Width = this.Width;
                Dialog.Show();
            }









        }

        private void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_User.ToList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            PL.FRM_USER_ADD frm_add = new PL.FRM_USER_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_user = db.TB_User.Where(x => x.ID == id).FirstOrDefault();
            frm_add.edit_name.Text=tb_user.User_Name;
            frm_add.edit_pass.Text=tb_user.User_Pass;
            frm_add.edit_role.Text=tb_user.User_Role;
            frm_add.id = id;
            frm_add.btn_add.Text = "تعديل";
            frm_add.Show();


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edit_search.Text;
            gridControl1.DataSource=db.TB_User.Where(x=>x.User_Name.Contains(_search) || x.User_Pass.Contains(_search) ).ToList();
        }
    }
}
