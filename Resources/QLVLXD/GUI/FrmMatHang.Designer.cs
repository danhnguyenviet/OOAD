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
            this.splitContainerControlWin641 = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMatHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMatHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNhaSanXuat = new DevExpress.XtraEditors.TextEdit();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtVat = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDanhSachMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).BeginInit();
            this.splitContainerControlWin641.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhaSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControlWin641.Size = new System.Drawing.Size(709, 454);
            this.splitContainerControlWin641.SplitterPosition = 300;
            this.splitContainerControlWin641.TabIndex = 0;
            this.splitContainerControlWin641.Text = "splitContainerControlWin641";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtVat);
            this.groupControl1.Controls.Add(this.txtDonViTinh);
            this.groupControl1.Controls.Add(this.txtTenNhaSanXuat);
            this.groupControl1.Controls.Add(this.txtTenMatHang);
            this.groupControl1.Controls.Add(this.txtMaMatHang);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(709, 227);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin mặt hàng";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnSua);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 233);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(709, 67);
            this.groupControl3.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(197, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã mặt hàng";
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên mặt hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(197, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên nhà sản xuất";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(197, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Đơn vị tính";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(197, 177);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(19, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "VAT";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Location = new System.Drawing.Point(308, 37);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaMatHang.TabIndex = 1;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(308, 71);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(248, 20);
            this.txtTenMatHang.TabIndex = 1;
            // 
            // txtTenNhaSanXuat
            // 
            this.txtTenNhaSanXuat.Location = new System.Drawing.Point(308, 109);
            this.txtTenNhaSanXuat.Name = "txtTenNhaSanXuat";
            this.txtTenNhaSanXuat.Size = new System.Drawing.Size(248, 20);
            this.txtTenNhaSanXuat.TabIndex = 1;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(308, 141);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(100, 20);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(308, 174);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 20);
            this.txtVat.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDanhSachMatHang);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(709, 149);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách mặt hàng";
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachMatHang.Location = new System.Drawing.Point(2, 21);
            this.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang";
            this.dgvDanhSachMatHang.Size = new System.Drawing.Size(705, 126);
            this.dgvDanhSachMatHang.TabIndex = 0;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 454);
            this.Controls.Add(this.splitContainerControlWin641);
            this.Name = "frmMatHang";
            this.Text = "Mặt hàng";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlWin641)).EndInit();
            this.splitContainerControlWin641.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhaSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitContainerControlWin641;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.TextEdit txtVat;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.TextEdit txtTenNhaSanXuat;
        private DevExpress.XtraEditors.TextEdit txtTenMatHang;
        private DevExpress.XtraEditors.TextEdit txtMaMatHang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvDanhSachMatHang;
    }
}