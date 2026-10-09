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
    public partial class FRM_USER_ADD : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
       TB_User tb_user=new TB_User();
        BL.Methods methods = new BL.Methods();
        public int id;

        public FRM_USER_ADD()
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
                Dialog.txt_caption.Text = "اسم المستخدم مطلوب";
                Dialog.Show();


            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //add
                   

                    tb_user.User_Name=edit_name.Text;
                    tb_user.User_Pass=edit_pass.Text;
                    tb_user.User_Role = edit_role.Text;
                    tb_user.User_State = "False";
                    db.TB_User.Add(tb_user);
                    db.SaveChanges();
                    Toast.txt_caption.Text= "تم الاضافة مستخدم جديد";
                    Toast.Show();
                    db = new DB_SMPEntities();
                    this.Close();


                }
                else
                {
                    //edit
                   
                    tb_user.ID = id;
                    tb_user.User_Name = edit_name.Text;
                    tb_user.User_Pass = edit_pass.Text;
                    tb_user.User_Role = edit_role.Text;
                    tb_user.User_State = "False";
                    db.Entry(tb_user).State =EntityState.Modified;
                    db.SaveChanges();
                    Toast.txt_caption.Text = " تم تعديل المستخدم ";
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
    }
}
