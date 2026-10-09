namespace SMP.PL
{
    partial class FRM_REPORT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_REPORT));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sell = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pur = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cust = new DevExpress.XtraEditors.SimpleButton();
            this.btn_supp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users = new DevExpress.XtraEditors.SimpleButton();
            this.dBSMPEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_cat.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMPEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.flowLayoutPanel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_sell);
            this.flowLayoutPanel1.Controls.Add(this.btn_pur);
            this.flowLayoutPanel1.Controls.Add(this.btn_cust);
            this.flowLayoutPanel1.Controls.Add(this.btn_supp);
            this.flowLayoutPanel1.Controls.Add(this.btn_users);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 720);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_sell
            // 
            this.btn_sell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sell.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sell.Appearance.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.Appearance.Options.UseBackColor = true;
            this.btn_sell.Appearance.Options.UseFont = true;
            this.btn_sell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sell.ImageOptions.Image")));
            this.btn_sell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_sell.Location = new System.Drawing.Point(35, 35);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(20);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(441, 259);
            this.btn_sell.TabIndex = 14;
            this.btn_sell.Text = "تقرير المبيعات";
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_pur
            // 
            this.btn_pur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_pur.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pur.Appearance.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pur.Appearance.Options.UseBackColor = true;
            this.btn_pur.Appearance.Options.UseFont = true;
            this.btn_pur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pur.ImageOptions.Image")));
            this.btn_pur.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_pur.Location = new System.Drawing.Point(516, 35);
            this.btn_pur.Margin = new System.Windows.Forms.Padding(20);
            this.btn_pur.Name = "btn_pur";
            this.btn_pur.Size = new System.Drawing.Size(441, 259);
            this.btn_pur.TabIndex = 15;
            this.btn_pur.Text = "تقرير المشتريات";
            this.btn_pur.Click += new System.EventHandler(this.btn_pur_Click);
            // 
            // btn_cust
            // 
            this.btn_cust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cust.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_cust.Appearance.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cust.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_cust.Appearance.Options.UseBackColor = true;
            this.btn_cust.Appearance.Options.UseFont = true;
            this.btn_cust.Appearance.Options.UseForeColor = true;
            this.btn_cust.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cust.ImageOptions.Image")));
            this.btn_cust.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_cust.Location = new System.Drawing.Point(35, 334);
            this.btn_cust.Margin = new System.Windows.Forms.Padding(20);
            this.btn_cust.Name = "btn_cust";
            this.btn_cust.Size = new System.Drawing.Size(441, 259);
            this.btn_cust.TabIndex = 16;
            this.btn_cust.Text = "تقرير العملاء";
            this.btn_cust.Click += new System.EventHandler(this.btn_cust_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_supp.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_supp.Appearance.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp.Appearance.Options.UseBackColor = true;
            this.btn_supp.Appearance.Options.UseFont = true;
            this.btn_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_supp.ImageOptions.Image")));
            this.btn_supp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_supp.Location = new System.Drawing.Point(516, 334);
            this.btn_supp.Margin = new System.Windows.Forms.Padding(20);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(441, 259);
            this.btn_supp.TabIndex = 17;
            this.btn_supp.Text = "تقرير الموردين";
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btn_users
            // 
            this.btn_users.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_users.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_users.Appearance.Font = new System.Drawing.Font("LBC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_users.Appearance.Options.UseBackColor = true;
            this.btn_users.Appearance.Options.UseFont = true;
            this.btn_users.Appearance.Options.UseForeColor = true;
            this.btn_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.ImageOptions.Image")));
            this.btn_users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_users.Location = new System.Drawing.Point(35, 633);
            this.btn_users.Margin = new System.Windows.Forms.Padding(20);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(441, 259);
            this.btn_users.TabIndex = 18;
            this.btn_users.Text = "تقرير المستخدمين";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // dBSMPEntitiesBindingSource
            // 
            this.dBSMPEntitiesBindingSource.DataSource = typeof(SMP.DB_SMPEntities);
            // 
            // tBCATBindingSource
            // 
            this.tBCATBindingSource.DataSource = typeof(SMP.TB_CAT);
            // 
            // FRM_REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_REPORT";
            this.Text = "FRM_CAT";
            this.pn_cat.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBSMPEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cat;
        private System.Windows.Forms.BindingSource dBSMPEntitiesBindingSource;
        private System.Windows.Forms.BindingSource tBCATBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public DevExpress.XtraEditors.SimpleButton btn_sell;
        public DevExpress.XtraEditors.SimpleButton btn_pur;
        public DevExpress.XtraEditors.SimpleButton btn_cust;
        public DevExpress.XtraEditors.SimpleButton btn_supp;
        public DevExpress.XtraEditors.SimpleButton btn_users;
    }
}