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
    public partial class FRM_LOGIN : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_User tb_user=new TB_User();
        Main main = new Main();
        

        public FRM_LOGIN()
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
                
                     tb_user=db.TB_User.Where(x=>x.User_Name== edit_name.Text && x.User_Pass==edit_pass.Text).FirstOrDefault();
                if (tb_user != null)
                {
                    tb_user.User_State = "True";
                    db.Entry(tb_user).State=EntityState.Modified;
                    main.lb_username.Text = tb_user.User_Name;
                    main.lb_role.Text = tb_user.User_Role;
                    main.Enabled= true;
                    db.SaveChanges();
                    main.Show();
                    this.Close();
                    

                }
                else
                {
                    MessageBox.Show("فشل تسجيل الدخول");
                }
                    
                   

                   


               
               
            }
        }

        

        private void lb_titlepage_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            
        }
    }
}
