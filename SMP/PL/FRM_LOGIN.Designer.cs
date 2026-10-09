namespace SMP.PL
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.lb_username = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.edit_pass = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.Gray;
            this.lb_username.Location = new System.Drawing.Point(447, 387);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(261, 51);
            this.lb_username.TabIndex = 10;
            this.lb_username.Text = "اسم المستخدم";
            this.lb_username.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // edit_name
            // 
            this.edit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_name.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name.Location = new System.Drawing.Point(50, 387);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(382, 56);
            this.edit_name.TabIndex = 11;
            this.edit_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(200, 108);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(291, 246);
            this.pic_cover.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(12, 603);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(706, 79);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "تسجيل الدخول";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // edit_pass
            // 
            this.edit_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_pass.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_pass.Location = new System.Drawing.Point(50, 467);
            this.edit_pass.Name = "edit_pass";
            this.edit_pass.Size = new System.Drawing.Size(382, 56);
            this.edit_pass.TabIndex = 15;
            this.edit_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_pass
            // 
            this.lb_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.Gray;
            this.lb_pass.Location = new System.Drawing.Point(510, 467);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(198, 51);
            this.lb_pass.TabIndex = 14;
            this.lb_pass.Text = "كلمة المرور";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(188, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 72);
            this.label3.TabIndex = 18;
            this.label3.Text = "تسجيل الدخول";
            // 
            // btn_close
            // 
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(652, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(66, 64);
            this.btn_close.TabIndex = 6;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 694);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit_pass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_LOGIN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_username;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edit_name;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox edit_pass;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_close;
    }
}