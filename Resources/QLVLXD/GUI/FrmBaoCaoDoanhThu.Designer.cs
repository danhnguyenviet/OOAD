namespace GUI_QLVLXD
{
    partial class FrmBaoCaoDoanhThu
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
            this.BaoCaoDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoDoanhThu = new GUI_QLVLXD.BaoCaoDoanhThu();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.datetimeFrom = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BaoCaoDoanhThuBindingSource
            // 
            this.BaoCaoDoanhThuBindingSource.DataMember = "BaoCaoDoanhThu";
            this.BaoCaoDoanhThuBindingSource.DataSource = this.BaoCaoDoanhThu;
            // 
            // BaoCaoDoanhThu
            // 
            this.BaoCaoDoanhThu.DataSetName = "BaoCaoDoanhThu";
            this.BaoCaoDoanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLVLXD.BaoCaoDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 607);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.datetimeFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 47);
            this.panel1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(321, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Từ Ngày:";
            // 
            // datetimeFrom
            // 
            this.datetimeFrom.EditValue = new System.DateTime(2016, 1, 1, 20, 45, 34, 0);
            this.datetimeFrom.Location = new System.Drawing.Point(383, 12);
            this.datetimeFrom.Name = "datetimeFrom";
            this.datetimeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeFrom.Properties.Mask.EditMask = "MM/yyyy";
            this.datetimeFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.datetimeFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datetimeFrom.Size = new System.Drawing.Size(134, 20);
            this.datetimeFrom.TabIndex = 5;
            this.datetimeFrom.TextChanged += new System.EventHandler(this.FrmBaoCaoDoanhThu_Load);
            // 
            // FrmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaoCaoDoanhThu";
            this.Text = "Báo Cáo Doanh Thu Trong Tháng";
            this.Load += new System.EventHandler(this.FrmBaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BaoCaoDoanhThuBindingSource;
        private BaoCaoDoanhThu BaoCaoDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit datetimeFrom;
    }
}