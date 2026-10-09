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
    public partial class FRM_SUPP_ADD : Form
    {
        // init
        DB_SMPEntities db = new DB_SMPEntities();
       TB_Supp tb_supp=new TB_Supp();
        BL.Methods methods = new BL.Methods();
        public int id;

        public FRM_SUPP_ADD()
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
                Dialog.txt_caption.Text = "اسم المورد مطلوب";
                Dialog.Show();


            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //add
                    pic_cover.Image.Save(methods.ma,System.Drawing.Imaging.ImageFormat.Png);

                    tb_supp.Supp_Name=edit_name.Text;
                    tb_supp.Supp_Email=edit_email.Text;
                    tb_supp.Supp_Phone=edit_phone.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.TB_Supp.Add(tb_supp);
                    db.SaveChanges();
                    Toast.txt_caption.Text="تم الاضافة مورد جديد";
                    Toast.Show();
                    db = new DB_SMPEntities();
                    this.Close();


                }
                else
                {
                    //edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = edit_name.Text;
                    tb_supp.Supp_Email = edit_email.Text;
                    tb_supp.Supp_Phone = edit_phone.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    db.Entry(tb_supp).State =EntityState.Modified;
                    db.SaveChanges();
                    Toast.txt_caption.Text = " تم تعديل مورد ";
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
