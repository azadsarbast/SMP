using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraSplashScreen;
using System.Linq;

namespace SMP.PL
{
    public partial class FRM_START : SplashScreen
    {
        DB_SMPEntities db=new DB_SMPEntities();
        TB_User tb_user=new TB_User();
        Main main=new Main();
        PL.FRM_LOGIN login=new PL.FRM_LOGIN();

        public FRM_START()
        {
            InitializeComponent();
           
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_user=db.TB_User.Where(x => x.User_State == "True").FirstOrDefault();
            if(tb_user!=null)
            {
                main.lb_username.Text = tb_user.User_Name;
                main.lb_role.Text = tb_user.User_Role;
                main.Show();
            }
            else 
            {
            login.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }
    }
}