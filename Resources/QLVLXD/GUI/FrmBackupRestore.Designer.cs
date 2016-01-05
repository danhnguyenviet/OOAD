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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
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
            this.groupControl1.Controls.Add(this.btnBackup);
            this.groupControl1.Controls.Add(this.txtThuMucLuu);
            this.groupControl1.Controls.Add(this.btnChonThuMuc);
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
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBackupRestore";
            this.Text = "FrmBackupRestore";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMucLuu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.TextEdit txtThuMucLuu;
        private DevExpress.XtraEditors.SimpleButton btnChonThuMuc;
        private DevExpress.XtraEditors.SimpleButton btnChonThuMucRestore;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.TextEdit txtThuMucLuuRestore;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbxCoSoDuLieu;
    }
}