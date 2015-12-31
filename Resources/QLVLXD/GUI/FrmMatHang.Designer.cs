namespace GUI_QLVLXD
{
    partial class frmMatHang
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
            this.splitContainerControlWin641 = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VLXDDataSet = new GUI_QLVLXD.QL_VLXDDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VLXDDataSet1 = new GUI_QLVLXD.QL_VLXDDataSet1();
            this.colThueVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.matHangTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetTableAdapters.MatHangTableAdapter();
            this.qLVLXDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhTableAdapter = new GUI_QLVLXD.QL_VLXDDataSet1TableAdapters.DonViTinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).BeginInit();
            this.splitContainerControlWin641.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControlWin641
            // 
            this.splitContainerControlWin641.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlWin641.Horizontal = false;
            this.splitContainerControlWin641.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlWin641.Name = "splitContainerControlWin641";
            this.splitContainerControlWin641.Panel1.Text = "Panel1";
            this.splitContainerControlWin641.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControlWin641.Panel2.Text = "Panel2";
            this.splitContainerControlWin641.Size = new System.Drawing.Size(709, 454);
            this.splitContainerControlWin641.SplitterPosition = 33;
            this.splitContainerControlWin641.TabIndex = 0;
            this.splitContainerControlWin641.Text = "splitContainerControlWin641";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(709, 416);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách mặt hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.matHangBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(705, 393);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.qL_VLXDDataSet;
            // 
            // qL_VLXDDataSet
            // 
            this.qL_VLXDDataSet.DataSetName = "QL_VLXDDataSet";
            this.qL_VLXDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colTenNSX,
            this.colMaDVT,
            this.colThueVAT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colMaMH
            // 
            this.colMaMH.Caption = "Mã";
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 0;
            // 
            // colTenMH
            // 
            this.colTenMH.Caption = "Tên mặc hàng";
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 1;
            // 
            // colTenNSX
            // 
            this.colTenNSX.Caption = "Nhà sản xuất";
            this.colTenNSX.FieldName = "TenNSX";
            this.colTenNSX.Name = "colTenNSX";
            this.colTenNSX.Visible = true;
            this.colTenNSX.VisibleIndex = 2;
            // 
            // colMaDVT
            // 
            this.colMaDVT.Caption = "Đơn vị tính";
            this.colMaDVT.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colMaDVT.FieldName = "MaDVT";
            this.colMaDVT.Name = "colMaDVT";
            this.colMaDVT.Visible = true;
            this.colMaDVT.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.donViTinhBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "TenDVT";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "MaDVT";
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "DonViTinh";
            this.donViTinhBindingSource.DataSource = this.qL_VLXDDataSet1;
            // 
            // qL_VLXDDataSet1
            // 
            this.qL_VLXDDataSet1.DataSetName = "QL_VLXDDataSet1";
            this.qL_VLXDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colThueVAT
            // 
            this.colThueVAT.Caption = "VAT";
            this.colThueVAT.FieldName = "ThueVAT";
            this.colThueVAT.Name = "colThueVAT";
            this.colThueVAT.Visible = true;
            this.colThueVAT.VisibleIndex = 4;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // qLVLXDDataSetBindingSource
            // 
            this.qLVLXDDataSetBindingSource.DataSource = this.qL_VLXDDataSet;
            this.qLVLXDDataSetBindingSource.Position = 0;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 454);
            this.Controls.Add(this.splitContainerControlWin641);
            this.Name = "frmMatHang";
            this.Text = "Mặt hàng";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).EndInit();
            this.splitContainerControlWin641.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitContainerControlWin641;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QL_VLXDDataSet qL_VLXDDataSet;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private QL_VLXDDataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNSX;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colThueVAT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource qLVLXDDataSetBindingSource;
        private QL_VLXDDataSet1 qL_VLXDDataSet1;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private QL_VLXDDataSet1TableAdapters.DonViTinhTableAdapter donViTinhTableAdapter;
    }
}