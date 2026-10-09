namespace SMP.PL
{
    partial class FRM_PUR_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PUR_ADD));
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_det = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_supp = new System.Windows.Forms.ComboBox();
            this.edit_cat = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edit_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edit_gt = new DevExpress.XtraEditors.SpinEdit();
            this.edit_sell = new System.Windows.Forms.TextBox();
            this.edit_buy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edit_trev = new System.Windows.Forms.Label();
            this.edit_tsell = new System.Windows.Forms.Label();
            this.edit_tbuy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_gt.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(1105, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 6;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(537, 208);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(83, 36);
            this.lb_titlepage.TabIndex = 10;
            this.lb_titlepage.Text = "المورد";
            this.lb_titlepage.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // edit_name
            // 
            this.edit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_name.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name.Location = new System.Drawing.Point(26, 26);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(339, 41);
            this.edit_name.TabIndex = 11;
            this.edit_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(88, 667);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(183, 67);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "اضافة ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(534, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "الصنف";
            // 
            // edit_det
            // 
            this.edit_det.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_det.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_det.Location = new System.Drawing.Point(26, 268);
            this.edit_det.Multiline = true;
            this.edit_det.Name = "edit_det";
            this.edit_det.Size = new System.Drawing.Size(463, 93);
            this.edit_det.TabIndex = 17;
            this.edit_det.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(483, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "اسم المادة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edit_supp);
            this.groupBox1.Controls.Add(this.edit_cat);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edit_type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edit_det);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_titlepage);
            this.groupBox1.Controls.Add(this.edit_name);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(501, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(639, 367);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات اساسية";
            // 
            // edit_supp
            // 
            this.edit_supp.FormattingEnabled = true;
            this.edit_supp.Location = new System.Drawing.Point(26, 208);
            this.edit_supp.Name = "edit_supp";
            this.edit_supp.Size = new System.Drawing.Size(339, 44);
            this.edit_supp.TabIndex = 23;
            // 
            // edit_cat
            // 
            this.edit_cat.FormattingEnabled = true;
            this.edit_cat.Location = new System.Drawing.Point(26, 147);
            this.edit_cat.Name = "edit_cat";
            this.edit_cat.Size = new System.Drawing.Size(339, 44);
            this.edit_cat.TabIndex = 22;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(371, 208);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(83, 36);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(371, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 36);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edit_type
            // 
            this.edit_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_type.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_type.Location = new System.Drawing.Point(26, 86);
            this.edit_type.Name = "edit_type";
            this.edit_type.Size = new System.Drawing.Size(339, 41);
            this.edit_type.TabIndex = 19;
            this.edit_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(524, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "تفاصيل";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(548, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "النوع";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edit_gt);
            this.groupBox2.Controls.Add(this.edit_sell);
            this.groupBox2.Controls.Add(this.edit_buy);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(511, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(620, 236);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيع و الشراء";
            // 
            // edit_gt
            // 
            this.edit_gt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edit_gt.Location = new System.Drawing.Point(7, 161);
            this.edit_gt.Name = "edit_gt";
            this.edit_gt.Properties.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_gt.Properties.Appearance.Options.UseFont = true;
            this.edit_gt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edit_gt.Size = new System.Drawing.Size(339, 42);
            this.edit_gt.TabIndex = 22;
            this.edit_gt.EditValueChanged += new System.EventHandler(this.edit_gt_EditValueChanged);
            // 
            // edit_sell
            // 
            this.edit_sell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_sell.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_sell.Location = new System.Drawing.Point(7, 103);
            this.edit_sell.Name = "edit_sell";
            this.edit_sell.Size = new System.Drawing.Size(339, 41);
            this.edit_sell.TabIndex = 21;
            this.edit_sell.Text = "0";
            this.edit_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_sell.TextChanged += new System.EventHandler(this.edit_sell_TextChanged);
            // 
            // edit_buy
            // 
            this.edit_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_buy.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_buy.Location = new System.Drawing.Point(7, 42);
            this.edit_buy.Name = "edit_buy";
            this.edit_buy.Size = new System.Drawing.Size(339, 41);
            this.edit_buy.TabIndex = 20;
            this.edit_buy.Text = "0";
            this.edit_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edit_buy.TextChanged += new System.EventHandler(this.edit_buy_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(409, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "سعر البيع (مفرد) ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(396, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "سعر الشراء (مفرد) ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(523, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 14;
            this.label9.Text = "الكمية";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.edit_trev);
            this.groupBox3.Controls.Add(this.edit_tsell);
            this.groupBox3.Controls.Add(this.edit_tbuy);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(466, 311);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("LBC", 16F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(152, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 41);
            this.label11.TabIndex = 26;
            this.label11.Text = "الارباح الكلية";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LBC", 16F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(85, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 41);
            this.label10.TabIndex = 25;
            this.label10.Text = "المبيعات (السعر الكلي)";
            // 
            // edit_trev
            // 
            this.edit_trev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_trev.AutoSize = true;
            this.edit_trev.Font = new System.Drawing.Font("LBC", 16F);
            this.edit_trev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit_trev.Location = new System.Drawing.Point(228, 260);
            this.edit_trev.Name = "edit_trev";
            this.edit_trev.Size = new System.Drawing.Size(37, 41);
            this.edit_trev.TabIndex = 24;
            this.edit_trev.Text = "0";
            // 
            // edit_tsell
            // 
            this.edit_tsell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_tsell.AutoSize = true;
            this.edit_tsell.Font = new System.Drawing.Font("LBC", 16F);
            this.edit_tsell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit_tsell.Location = new System.Drawing.Point(228, 178);
            this.edit_tsell.Name = "edit_tsell";
            this.edit_tsell.Size = new System.Drawing.Size(37, 41);
            this.edit_tsell.TabIndex = 23;
            this.edit_tsell.Text = "0";
            // 
            // edit_tbuy
            // 
            this.edit_tbuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_tbuy.AutoSize = true;
            this.edit_tbuy.Font = new System.Drawing.Font("LBC", 16F);
            this.edit_tbuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit_tbuy.Location = new System.Drawing.Point(228, 83);
            this.edit_tbuy.Name = "edit_tbuy";
            this.edit_tbuy.Size = new System.Drawing.Size(37, 41);
            this.edit_tbuy.TabIndex = 22;
            this.edit_tbuy.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 16F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(75, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 41);
            this.label6.TabIndex = 19;
            this.label6.Text = "المشتريات (السعر الكلي)";
            // 
            // FRM_PUR_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 746);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PUR_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_PUR_ADD_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_gt.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.Label lb_titlepage;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edit_det;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox edit_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox edit_sell;
        public System.Windows.Forms.TextBox edit_buy;
        public System.Windows.Forms.Label edit_trev;
        public System.Windows.Forms.Label edit_tsell;
        public System.Windows.Forms.Label edit_tbuy;
        public System.Windows.Forms.ComboBox edit_supp;
        public System.Windows.Forms.ComboBox edit_cat;
        public DevExpress.XtraEditors.SpinEdit edit_gt;
    }
}