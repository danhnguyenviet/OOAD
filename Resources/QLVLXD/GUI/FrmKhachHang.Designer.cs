namespace GUI_QLVLXD
{
    partial class FrmKhachHang
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControlWin641 = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.textSdt = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).BeginInit();
            this.splitContainerControlWin641.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSdt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textSdt);
            this.groupControl1.Controls.Add(this.textDiaChi);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtMaKhachHang);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(698, 191);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin khách hàng";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(281, 71);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(248, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(281, 37);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhachHang.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Họ tên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(197, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã khách hàng";
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(2, 21);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(694, 150);
            this.dgvDanhSachKhachHang.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDanhSachKhachHang);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(698, 173);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách khách hàng";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnSua);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 196);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(698, 67);
            this.groupControl3.TabIndex = 1;
            // 
            // splitContainerControlWin641
            // 
            this.splitContainerControlWin641.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlWin641.Horizontal = false;
            this.splitContainerControlWin641.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlWin641.Name = "splitContainerControlWin641";
            this.splitContainerControlWin641.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControlWin641.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControlWin641.Panel1.Text = "Panel1";
            this.splitContainerControlWin641.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControlWin641.Panel2.Text = "Panel2";
            this.splitContainerControlWin641.Size = new System.Drawing.Size(698, 441);
            this.splitContainerControlWin641.SplitterPosition = 263;
            this.splitContainerControlWin641.TabIndex = 2;
            this.splitContainerControlWin641.Text = "splitContainerControlWin641";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(197, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(197, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(281, 108);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(248, 20);
            this.textDiaChi.TabIndex = 1;
            // 
            // textSdt
            // 
            this.textSdt.Location = new System.Drawing.Point(281, 142);
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(248, 20);
            this.textSdt.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI_QLVLXD.Properties.Resources.File_Delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(423, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 37);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI_QLVLXD.Properties.Resources.Actions_document_edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(324, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 37);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI_QLVLXD.Properties.Resources.Button_Add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(214, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 441);
            this.Controls.Add(this.splitContainerControlWin641);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).EndInit();
            this.splitContainerControlWin641.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSdt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitContainerControlWin641;
        private DevExpress.XtraEditors.TextEdit textSdt;
        private DevExpress.XtraEditors.TextEdit textDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}