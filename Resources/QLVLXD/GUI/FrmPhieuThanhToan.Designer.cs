namespace GUI_QLVLXD
{
    partial class FrmPhieuThanhToan
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
            this.dateNgayNop = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPhieuThanhToan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoTienNop = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuPhieuThanhToan = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbTenNhanVien = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbMaHoaDon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControlWin641 = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtConNo = new DevExpress.XtraEditors.TextEdit();
            this.lbMaNv = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbConNo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).BeginInit();
            this.splitContainerControlWin641.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNgayNop
            // 
            this.dateNgayNop.EditValue = null;
            this.dateNgayNop.Location = new System.Drawing.Point(548, 40);
            this.dateNgayNop.Name = "dateNgayNop";
            this.dateNgayNop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNop.Size = new System.Drawing.Size(138, 20);
            this.dateNgayNop.TabIndex = 1;
            // 
            // txtMaPhieuThanhToan
            // 
            this.txtMaPhieuThanhToan.Location = new System.Drawing.Point(215, 40);
            this.txtMaPhieuThanhToan.Name = "txtMaPhieuThanhToan";
            this.txtMaPhieuThanhToan.Size = new System.Drawing.Size(188, 20);
            this.txtMaPhieuThanhToan.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(486, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Mã hóa đơn";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(486, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Ngày nộp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(110, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số tiền nộp";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(110, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu thanh toán";
            // 
            // txtSoTienNop
            // 
            this.txtSoTienNop.Location = new System.Drawing.Point(215, 109);
            this.txtSoTienNop.Name = "txtSoTienNop";
            this.txtSoTienNop.Size = new System.Drawing.Size(138, 20);
            this.txtSoTienNop.TabIndex = 4;
            this.txtSoTienNop.EditValueChanged += new System.EventHandler(this.txtSoTienNop_EditValueChanged);
            this.txtSoTienNop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienNop_KeyPress);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnThoat);
            this.groupControl2.Controls.Add(this.btnLuuPhieuThanhToan);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(847, 72);
            this.groupControl2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::GUI_QLVLXD.Properties.Resources.Folders_OS_Exit_Full_Screen_Metro_icon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(735, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 37);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuuPhieuThanhToan
            // 
            this.btnLuuPhieuThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuThanhToan.Image = global::GUI_QLVLXD.Properties.Resources.Save_icon;
            this.btnLuuPhieuThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhieuThanhToan.Location = new System.Drawing.Point(244, 24);
            this.btnLuuPhieuThanhToan.Name = "btnLuuPhieuThanhToan";
            this.btnLuuPhieuThanhToan.Size = new System.Drawing.Size(206, 37);
            this.btnLuuPhieuThanhToan.TabIndex = 6;
            this.btnLuuPhieuThanhToan.Text = "Lưu phiếu thanh toán";
            this.btnLuuPhieuThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuPhieuThanhToan.UseVisualStyleBackColor = true;
            this.btnLuuPhieuThanhToan.Click += new System.EventHandler(this.btnLuuPhieuThanhToan_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.lbMaNv);
            this.groupControl1.Controls.Add(this.cbTenNhanVien);
            this.groupControl1.Controls.Add(this.cbMaHoaDon);
            this.groupControl1.Controls.Add(this.dateNgayNop);
            this.groupControl1.Controls.Add(this.txtConNo);
            this.groupControl1.Controls.Add(this.txtSoTienNop);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtMaPhieuThanhToan);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.lbConNo);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(847, 158);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // cbTenNhanVien
            // 
            this.cbTenNhanVien.Location = new System.Drawing.Point(215, 66);
            this.cbTenNhanVien.Name = "cbTenNhanVien";
            this.cbTenNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTenNhanVien.Size = new System.Drawing.Size(188, 20);
            this.cbTenNhanVien.TabIndex = 2;
            this.cbTenNhanVien.Leave += new System.EventHandler(this.cbTenNhanVien_Leave);
            // 
            // cbMaHoaDon
            // 
            this.cbMaHoaDon.Location = new System.Drawing.Point(548, 66);
            this.cbMaHoaDon.Name = "cbMaHoaDon";
            this.cbMaHoaDon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMaHoaDon.Size = new System.Drawing.Size(138, 20);
            this.cbMaHoaDon.TabIndex = 3;
            this.cbMaHoaDon.SelectedValueChanged += new System.EventHandler(this.cbMaHoaDon_SelectedValueChanged);
            this.cbMaHoaDon.Leave += new System.EventHandler(this.cbMaHoaDon_Leave);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(110, 69);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(68, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Tên nhân viên";
            // 
            // splitContainerControlWin641
            // 
            this.splitContainerControlWin641.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlWin641.Horizontal = false;
            this.splitContainerControlWin641.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlWin641.Name = "splitContainerControlWin641";
            this.splitContainerControlWin641.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControlWin641.Panel1.Text = "Panel1";
            this.splitContainerControlWin641.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControlWin641.Panel2.Text = "Panel2";
            this.splitContainerControlWin641.Size = new System.Drawing.Size(847, 236);
            this.splitContainerControlWin641.SplitterPosition = 159;
            this.splitContainerControlWin641.TabIndex = 3;
            this.splitContainerControlWin641.Text = "splitContainerControlWin641";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(486, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Còn nợ";
            // 
            // txtConNo
            // 
            this.txtConNo.Enabled = false;
            this.txtConNo.Location = new System.Drawing.Point(548, 109);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(138, 20);
            this.txtConNo.TabIndex = 1;
            // 
            // lbMaNv
            // 
            this.lbMaNv.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNv.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbMaNv.Location = new System.Drawing.Point(215, 90);
            this.lbMaNv.Name = "lbMaNv";
            this.lbMaNv.Size = new System.Drawing.Size(35, 13);
            this.lbMaNv.TabIndex = 4;
            this.lbMaNv.Text = "Mã NV";
            this.lbMaNv.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(359, 112);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(7, 13);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "đ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(692, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(7, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "đ";
            // 
            // lbConNo
            // 
            this.lbConNo.Location = new System.Drawing.Point(705, 112);
            this.lbConNo.Name = "lbConNo";
            this.lbConNo.Size = new System.Drawing.Size(34, 13);
            this.lbConNo.TabIndex = 0;
            this.lbConNo.Text = "Còn nợ";
            this.lbConNo.Visible = false;
            // 
            // FrmPhieuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 236);
            this.Controls.Add(this.splitContainerControlWin641);
            this.Name = "FrmPhieuThanhToan";
            this.Text = "Phiếu thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).EndInit();
            this.splitContainerControlWin641.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateNgayNop;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuThanhToan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoTienNop;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuuPhieuThanhToan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbMaHoaDon;
        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitContainerControlWin641;
        private DevExpress.XtraEditors.ComboBoxEdit cbTenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtConNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbMaNv;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lbConNo;
    }
}