namespace SMP.PL
{
    partial class FRM_PUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PUR));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPur_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Supp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TRev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.dBSMPEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMPEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Controls.Add(this.panel1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP.TB_Pur);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 620);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPur_Name,
            this.colPur_Type,
            this.colPur_Cat,
            this.colPur_Supp,
            this.colPur_Det,
            this.colPur_Buy,
            this.colPur_Sell,
            this.colPur_Qt,
            this.colPur_TBuy,
            this.colPur_TSell,
            this.colPur_TRev});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPur_Name
            // 
            this.colPur_Name.Caption = "اسم المادة";
            this.colPur_Name.FieldName = "Pur_Name";
            this.colPur_Name.MinWidth = 30;
            this.colPur_Name.Name = "colPur_Name";
            this.colPur_Name.OptionsColumn.AllowEdit = false;
            this.colPur_Name.Visible = true;
            this.colPur_Name.VisibleIndex = 0;
            this.colPur_Name.Width = 112;
            // 
            // colPur_Type
            // 
            this.colPur_Type.Caption = "النوع";
            this.colPur_Type.FieldName = "Pur_Type";
            this.colPur_Type.MinWidth = 30;
            this.colPur_Type.Name = "colPur_Type";
            this.colPur_Type.OptionsColumn.AllowEdit = false;
            this.colPur_Type.Visible = true;
            this.colPur_Type.VisibleIndex = 1;
            this.colPur_Type.Width = 112;
            // 
            // colPur_Cat
            // 
            this.colPur_Cat.Caption = "الصنف";
            this.colPur_Cat.FieldName = "Pur_Cat";
            this.colPur_Cat.MinWidth = 30;
            this.colPur_Cat.Name = "colPur_Cat";
            this.colPur_Cat.OptionsColumn.AllowEdit = false;
            this.colPur_Cat.Visible = true;
            this.colPur_Cat.VisibleIndex = 2;
            this.colPur_Cat.Width = 112;
            // 
            // colPur_Supp
            // 
            this.colPur_Supp.Caption = "المورد";
            this.colPur_Supp.FieldName = "Pur_Supp";
            this.colPur_Supp.MinWidth = 30;
            this.colPur_Supp.Name = "colPur_Supp";
            this.colPur_Supp.OptionsColumn.AllowEdit = false;
            this.colPur_Supp.Visible = true;
            this.colPur_Supp.VisibleIndex = 3;
            this.colPur_Supp.Width = 112;
            // 
            // colPur_Det
            // 
            this.colPur_Det.Caption = "تفاصيل";
            this.colPur_Det.FieldName = "Pur_Det";
            this.colPur_Det.MinWidth = 30;
            this.colPur_Det.Name = "colPur_Det";
            this.colPur_Det.OptionsColumn.AllowEdit = false;
            this.colPur_Det.Visible = true;
            this.colPur_Det.VisibleIndex = 4;
            this.colPur_Det.Width = 112;
            // 
            // colPur_Buy
            // 
            this.colPur_Buy.Caption = "سعر الشراء";
            this.colPur_Buy.FieldName = "Pur_Buy";
            this.colPur_Buy.MinWidth = 30;
            this.colPur_Buy.Name = "colPur_Buy";
            this.colPur_Buy.OptionsColumn.AllowEdit = false;
            this.colPur_Buy.Visible = true;
            this.colPur_Buy.VisibleIndex = 5;
            this.colPur_Buy.Width = 112;
            // 
            // colPur_Sell
            // 
            this.colPur_Sell.Caption = "سعر البيع";
            this.colPur_Sell.FieldName = "Pur_Sell";
            this.colPur_Sell.MinWidth = 30;
            this.colPur_Sell.Name = "colPur_Sell";
            this.colPur_Sell.OptionsColumn.AllowEdit = false;
            this.colPur_Sell.Visible = true;
            this.colPur_Sell.VisibleIndex = 6;
            this.colPur_Sell.Width = 112;
            // 
            // colPur_Qt
            // 
            this.colPur_Qt.Caption = "الكمية";
            this.colPur_Qt.FieldName = "Pur_Qt";
            this.colPur_Qt.MinWidth = 30;
            this.colPur_Qt.Name = "colPur_Qt";
            this.colPur_Qt.OptionsColumn.AllowEdit = false;
            this.colPur_Qt.Visible = true;
            this.colPur_Qt.VisibleIndex = 7;
            this.colPur_Qt.Width = 112;
            // 
            // colPur_TBuy
            // 
            this.colPur_TBuy.Caption = "البيع الكلي";
            this.colPur_TBuy.FieldName = "Pur_TBuy";
            this.colPur_TBuy.MinWidth = 30;
            this.colPur_TBuy.Name = "colPur_TBuy";
            this.colPur_TBuy.OptionsColumn.AllowEdit = false;
            this.colPur_TBuy.Visible = true;
            this.colPur_TBuy.VisibleIndex = 8;
            this.colPur_TBuy.Width = 112;
            // 
            // colPur_TSell
            // 
            this.colPur_TSell.Caption = "الشراء الكلي";
            this.colPur_TSell.FieldName = "Pur_TSell";
            this.colPur_TSell.MinWidth = 30;
            this.colPur_TSell.Name = "colPur_TSell";
            this.colPur_TSell.OptionsColumn.AllowEdit = false;
            this.colPur_TSell.Visible = true;
            this.colPur_TSell.VisibleIndex = 9;
            this.colPur_TSell.Width = 112;
            // 
            // colPur_TRev
            // 
            this.colPur_TRev.Caption = "الارباح";
            this.colPur_TRev.FieldName = "Pur_TRev";
            this.colPur_TRev.MinWidth = 30;
            this.colPur_TRev.Name = "colPur_TRev";
            this.colPur_TRev.OptionsColumn.AllowEdit = false;
            this.colPur_TRev.Visible = true;
            this.colPur_TRev.VisibleIndex = 10;
            this.colPur_TRev.Width = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.edit_search);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 100);
            this.panel1.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(948, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 67);
            this.btn_search.TabIndex = 9;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(145, 20);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(128, 67);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(285, 20);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 67);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(428, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(142, 67);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // edit_search
            // 
            this.edit_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_search.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_search.Location = new System.Drawing.Point(649, 24);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(286, 56);
            this.edit_search.TabIndex = 5;
            this.edit_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(5, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(128, 67);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FRM_PUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PUR";
            this.Text = "FRM_CAT";
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMPEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private System.Windows.Forms.TextBox edit_search;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.BindingSource dBSMPEntitiesBindingSource;
        private System.Windows.Forms.BindingSource tBCATBindingSource;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Supp;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Buy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Sell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TSell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TRev;
    }
}