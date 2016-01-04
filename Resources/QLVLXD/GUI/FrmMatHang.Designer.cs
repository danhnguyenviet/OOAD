namespace GUI_QLVLXD
{
    partial class FrmMatHang
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
            this.gridControlMatHang = new DevExpress.XtraGrid.GridControl();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VLXDDataSetChung = new GUI_QLVLXD.QL_VLXDDataSetChung();
            this.gridViewMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colThueVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.matHangTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.MatHangTableAdapter();
            this.donViTinhTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.DonViTinhTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSetChung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMatHang
            // 
            this.gridControlMatHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMatHang.DataSource = this.matHangBindingSource;
            this.gridControlMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMatHang.Location = new System.Drawing.Point(0, 49);
            this.gridControlMatHang.MainView = this.gridViewMatHang;
            this.gridControlMatHang.Name = "gridControlMatHang";
            this.gridControlMatHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlMatHang.Size = new System.Drawing.Size(629, 242);
            this.gridControlMatHang.TabIndex = 1;
            this.gridControlMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMatHang});
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.qL_VLXDDataSetChung;
            // 
            // qL_VLXDDataSetChung
            // 
            this.qL_VLXDDataSetChung.DataSetName = "QL_VLXDDataSetChung";
            this.qL_VLXDDataSetChung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMatHang
            // 
            this.gridViewMatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colTenNSX,
            this.colMaDVT,
            this.colThueVAT});
            this.gridViewMatHang.GridControl = this.gridControlMatHang;
            this.gridViewMatHang.Name = "gridViewMatHang";
            this.gridViewMatHang.NewItemRowText = "Thêm mặt hàng mới";
            this.gridViewMatHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMatHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMatHang.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMatHang.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridViewMatHang.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMatHang.OptionsSelection.MultiSelect = true;
            this.gridViewMatHang.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewMatHang.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewMatHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colMaMH
            // 
            this.colMaMH.Caption = "Mã";
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 1;
            // 
            // colTenMH
            // 
            this.colTenMH.Caption = "Mặt hàng";
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 2;
            // 
            // colTenNSX
            // 
            this.colTenNSX.Caption = "Nhà sản xuất";
            this.colTenNSX.FieldName = "TenNSX";
            this.colTenNSX.Name = "colTenNSX";
            this.colTenNSX.Visible = true;
            this.colTenNSX.VisibleIndex = 3;
            // 
            // colMaDVT
            // 
            this.colMaDVT.Caption = "Đơn vị tính";
            this.colMaDVT.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colMaDVT.FieldName = "MaDVT";
            this.colMaDVT.Name = "colMaDVT";
            this.colMaDVT.Visible = true;
            this.colMaDVT.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.repositoryItemLookUpEdit1.DataSource = this.donViTinhBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "TenDVT";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "MaDVT";
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "DonViTinh";
            this.donViTinhBindingSource.DataSource = this.qL_VLXDDataSetChung;
            // 
            // colThueVAT
            // 
            this.colThueVAT.Caption = "VAT";
            this.colThueVAT.FieldName = "ThueVAT";
            this.colThueVAT.Name = "colThueVAT";
            this.colThueVAT.Visible = true;
            this.colThueVAT.VisibleIndex = 5;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(629, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 291);
            this.barDockControlBottom.Size = new System.Drawing.Size(629, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 242);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(629, 49);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 242);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xóa";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // FrmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 314);
            this.Controls.Add(this.gridControlMatHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmMatHang";
            this.Text = "FrmMatHang";
            this.Load += new System.EventHandler(this.FrmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSetChung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMatHang;
        private QL_VLXDDataSetChung qL_VLXDDataSetChung;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private QL_VLXDDataSetChungTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNSX;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colThueVAT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private QL_VLXDDataSetChungTableAdapters.DonViTinhTableAdapter donViTinhTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}