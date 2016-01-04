namespace GUI_QLVLXD
{
    partial class FrmPhieuNhap
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colMaLH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.loHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VLXDDataSetChung = new GUI_QLVLXD.QL_VLXDDataSetChung();
            this.layoutViewField_colMaLH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.nhaCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colThoiGianLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.loHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.PhieuNhapTableAdapter();
            this.nhanVienTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.NhanVienTableAdapter();
            this.nhaCCTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.NhaCCTableAdapter();
            this.chiTietPhieuNhapTableAdapter1 = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.ChiTietPhieuNhapTableAdapter();
            this.loHangTableAdapter = new GUI_QLVLXD.QL_VLXDDataSetChungTableAdapters.LoHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSetChung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMaLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutView1
            // 
            this.layoutView1.CardCaptionFormat = "Lô hàng";
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colMaLH});
            this.layoutView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsLayout.Columns.AddNewColumns = false;
            this.layoutView1.OptionsLayout.Columns.RemoveOldColumns = false;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colMaLH
            // 
            this.colMaLH.Caption = "Lô hàng";
            this.colMaLH.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colMaLH.FieldName = "MaLH";
            this.colMaLH.LayoutViewField = this.layoutViewField_colMaLH;
            this.colMaLH.Name = "colMaLH";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.loHangBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "MaLH";
            this.repositoryItemLookUpEdit3.ImmediatePopup = true;
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "MaLH";
            // 
            // loHangBindingSource
            // 
            this.loHangBindingSource.DataMember = "LoHang";
            this.loHangBindingSource.DataSource = this.qL_VLXDDataSetChung;
            // 
            // qL_VLXDDataSetChung
            // 
            this.qL_VLXDDataSetChung.DataSetName = "QL_VLXDDataSetChung";
            this.qL_VLXDDataSetChung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutViewField_colMaLH
            // 
            this.layoutViewField_colMaLH.EditorPreferredWidth = 153;
            this.layoutViewField_colMaLH.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colMaLH.Name = "layoutViewField_colMaLH";
            this.layoutViewField_colMaLH.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colMaLH.TextSize = new System.Drawing.Size(42, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.phieuNhapBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.layoutView1;
            gridLevelNode1.RelationName = "FK_ChiTietPhieuNhap_PhieuNhap";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(803, 419);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1});
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qL_VLXDDataSetChung;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPN,
            this.colMaNV,
            this.colMaNCC,
            this.colThoiGianLap});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm phiếu nhập";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaPN
            // 
            this.colMaPN.Caption = "Mã phiếu nhập";
            this.colMaPN.FieldName = "MaPN";
            this.colMaPN.Name = "colMaPN";
            this.colMaPN.Visible = true;
            this.colMaPN.VisibleIndex = 1;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Nhân viên";
            this.colMaNV.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.nhanVienBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "TenNV";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ShowNullValuePromptWhenFocused = true;
            this.repositoryItemLookUpEdit1.ValueMember = "MaNV";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qL_VLXDDataSetChung;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Nhà cung cấp";
            this.colMaNCC.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.nhaCCBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "TenNCC";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "MaNCC";
            // 
            // nhaCCBindingSource
            // 
            this.nhaCCBindingSource.DataMember = "NhaCC";
            this.nhaCCBindingSource.DataSource = this.qL_VLXDDataSetChung;
            // 
            // colThoiGianLap
            // 
            this.colThoiGianLap.FieldName = "ThoiGianLap";
            this.colThoiGianLap.Name = "colThoiGianLap";
            this.colThoiGianLap.Visible = true;
            this.colThoiGianLap.VisibleIndex = 4;
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
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xóa";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
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
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(803, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 49);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colMaLH});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // loHangBindingSource1
            // 
            this.loHangBindingSource1.DataMember = "LoHang";
            this.loHangBindingSource1.DataSource = this.qL_VLXDDataSetChung;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PhieuNhap";
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhaCCTableAdapter
            // 
            this.nhaCCTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietPhieuNhapTableAdapter1
            // 
            this.chiTietPhieuNhapTableAdapter1.ClearBeforeFill = true;
            // 
            // loHangTableAdapter
            // 
            this.loHangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 491);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmPhieuNhap";
            this.Text = "FrmPhieuNhap";
            this.Load += new System.EventHandler(this.FrmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VLXDDataSetChung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMaLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QL_VLXDDataSetChung qL_VLXDDataSetChung;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QL_VLXDDataSetChungTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianLap;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QL_VLXDDataSetChungTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhaCCBindingSource;
        private QL_VLXDDataSetChungTableAdapters.NhaCCTableAdapter nhaCCTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private System.Windows.Forms.BindingSource loHangBindingSource;
        private QL_VLXDDataSetChungTableAdapters.ChiTietPhieuNhapTableAdapter chiTietPhieuNhapTableAdapter1;
        private QL_VLXDDataSetChungTableAdapters.LoHangTableAdapter loHangTableAdapter;
        private System.Windows.Forms.BindingSource loHangBindingSource1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMaLH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMaLH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}