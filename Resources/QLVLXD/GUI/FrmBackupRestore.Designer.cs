namespace GUI_QLVLXD
{
    partial class FrmBackupRestore
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
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.txtThuMucLuu = new DevExpress.XtraEditors.TextEdit();
            this.btnChonThuMuc = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDangNhapByWindow = new DevExpress.XtraEditors.CheckButton();
            this.btnNgatKetNoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnKetNoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserid = new DevExpress.XtraEditors.TextEdit();
            this.txtDataSource = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnChonThuMucRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.txtThuMucLuuRestore = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.cbxCoSoDuLieu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMucLuu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMucLuuRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCoSoDuLieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbxDatabase);
            this.groupControl1.Controls.Add(this.btnBackup);
            this.groupControl1.Controls.Add(this.txtThuMucLuu);
            this.groupControl1.Controls.Add(this.btnChonThuMuc);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(12, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(551, 72);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(457, 34);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(83, 23);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtThuMucLuu
            // 
            this.txtThuMucLuu.Location = new System.Drawing.Point(122, 35);
            this.txtThuMucLuu.Name = "txtThuMucLuu";
            this.txtThuMucLuu.Size = new System.Drawing.Size(308, 20);
            this.txtThuMucLuu.TabIndex = 3;
            // 
            // btnChonThuMuc
            // 
            this.btnChonThuMuc.Location = new System.Drawing.Point(25, 34);
            this.btnChonThuMuc.Name = "btnChonThuMuc";
            this.btnChonThuMuc.Size = new System.Drawing.Size(83, 23);
            this.btnChonThuMuc.TabIndex = 5;
            this.btnChonThuMuc.Text = "Chọn Thư Mục";
            this.btnChonThuMuc.Click += new System.EventHandler(this.btnChonThuMuc_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnChonThuMucRestore);
            this.groupControl2.Controls.Add(this.btnRestore);
            this.groupControl2.Controls.Add(this.txtThuMucLuuRestore);
            this.groupControl2.Location = new System.Drawing.Point(12, 171);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(551, 67);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Restore";
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.btnDangNhapByWindow);
            this.groupControl3.Controls.Add(this.btnNgatKetNoi);
            this.groupControl3.Controls.Add(this.btnKetNoi);
            this.groupControl3.Controls.Add(this.txtPassword);
            this.groupControl3.Controls.Add(this.txtUserid);
            this.groupControl3.Controls.Add(this.txtDataSource);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(12, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(614, 133);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Thông Tin Dữ Liệu";
            // 
            // btnDangNhapByWindow
            // 
            this.btnDangNhapByWindow.Location = new System.Drawing.Point(131, 99);
            this.btnDangNhapByWindow.Name = "btnDangNhapByWindow";
            this.btnDangNhapByWindow.Size = new System.Drawing.Size(143, 23);
            this.btnDangNhapByWindow.TabIndex = 6;
            this.btnDangNhapByWindow.Text = "Đăng Nhập Bằng Window ";
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.Location = new System.Drawing.Point(487, 63);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(83, 23);
            this.btnNgatKetNoi.TabIndex = 5;
            this.btnNgatKetNoi.Text = "Ngắt Kết Nối";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(487, 30);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(83, 23);
            this.btnKetNoi.TabIndex = 5;
            this.btnKetNoi.Text = "Kết Nối";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(335, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(131, 66);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(125, 20);
            this.txtUserid.TabIndex = 4;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(131, 32);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(329, 20);
            this.txtDataSource.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(74, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "User Id:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(50, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Data Source:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(271, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Password:";
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.Location = new System.Drawing.Point(152, 36);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDatabase.Size = new System.Drawing.Size(308, 20);
            this.cbxDatabase.TabIndex = 6;
            // 
            // btnChonThuMucRestore
            // 
            this.btnChonThuMucRestore.Location = new System.Drawing.Point(25, 32);
            this.btnChonThuMucRestore.Name = "btnChonThuMucRestore";
            this.btnChonThuMucRestore.Size = new System.Drawing.Size(83, 23);
            this.btnChonThuMucRestore.TabIndex = 5;
            this.btnChonThuMucRestore.Text = "Chọn File";
            this.btnChonThuMucRestore.Click += new System.EventHandler(this.btnChonThuMucRestore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(457, 32);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(83, 23);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtThuMucLuuRestore
            // 
            this.txtThuMucLuuRestore.Location = new System.Drawing.Point(122, 33);
            this.txtThuMucLuuRestore.Name = "txtThuMucLuuRestore";
            this.txtThuMucLuuRestore.Size = new System.Drawing.Size(308, 20);
            this.txtThuMucLuuRestore.TabIndex = 3;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.cbxCoSoDuLieu);
            this.groupControl4.Controls.Add(this.labelControl5);
            this.groupControl4.Location = new System.Drawing.Point(12, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(551, 75);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Thông Tin Cơ Sở Dữ Liệu";
            // 
            // cbxCoSoDuLieu
            // 
            this.cbxCoSoDuLieu.Location = new System.Drawing.Point(122, 36);
            this.cbxCoSoDuLieu.Name = "cbxCoSoDuLieu";
            this.cbxCoSoDuLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCoSoDuLieu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxCoSoDuLieu.Size = new System.Drawing.Size(308, 20);
            this.cbxCoSoDuLieu.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(20, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tên Database:";
            // 
            // FrmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 245);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBackupRestore";
            this.Text = "FrmBackupRestore";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMucLuu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMucLuuRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCoSoDuLieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKetNoi;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserid;
        private DevExpress.XtraEditors.TextEdit txtDataSource;
        private DevExpress.XtraEditors.SimpleButton btnNgatKetNoi;
        private DevExpress.XtraEditors.CheckButton btnDangNhapByWindow;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.TextEdit txtThuMucLuu;
        private DevExpress.XtraEditors.SimpleButton btnChonThuMuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDatabase;
        private DevExpress.XtraEditors.SimpleButton btnChonThuMucRestore;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.TextEdit txtThuMucLuuRestore;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbxCoSoDuLieu;
    }
}