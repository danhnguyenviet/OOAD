namespace GUI_QLVLXD
{
    partial class FrmBaoCaoTonKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BaoCaoTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoTonKho = new GUI_QLVLXD.BaoCaoTonKho();
            this.datetimeTo = new DevExpress.XtraEditors.DateEdit();
            this.datetimeFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaoCaoTonKhoBindingSource
            // 
            this.BaoCaoTonKhoBindingSource.DataMember = "BaoCaoTonKho";
            this.BaoCaoTonKhoBindingSource.DataSource = this.BaoCaoTonKho;
            // 
            // BaoCaoTonKho
            // 
            this.BaoCaoTonKho.DataSetName = "BaoCaoTonKho";
            this.BaoCaoTonKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datetimeTo
            // 
            this.datetimeTo.EditValue = new System.DateTime(2016, 1, 1, 20, 46, 56, 0);
            this.datetimeTo.Location = new System.Drawing.Point(493, 12);
            this.datetimeTo.Name = "datetimeTo";
            this.datetimeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datetimeTo.Size = new System.Drawing.Size(134, 20);
            this.datetimeTo.TabIndex = 6;
            this.datetimeTo.EditValueChanged += new System.EventHandler(this.FrmBaoCaoTonKho_Load);
            // 
            // datetimeFrom
            // 
            this.datetimeFrom.EditValue = new System.DateTime(2016, 1, 1, 20, 45, 34, 0);
            this.datetimeFrom.Location = new System.Drawing.Point(216, 12);
            this.datetimeFrom.Name = "datetimeFrom";
            this.datetimeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datetimeFrom.Size = new System.Drawing.Size(134, 20);
            this.datetimeFrom.TabIndex = 5;
            this.datetimeFrom.EditValueChanged += new System.EventHandler(this.FrmBaoCaoTonKho_Load);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(154, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Từ Ngày:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(435, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Đến Ngày:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.datetimeFrom);
            this.panel1.Controls.Add(this.datetimeTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 47);
            this.panel1.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BaoCaoTonKhoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLVLXD.BaoCaoTonKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(844, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoTonKho";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBaoCaoTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BaoCaoTonKhoBindingSource;
        private BaoCaoTonKho BaoCaoTonKho;
        private DevExpress.XtraEditors.DateEdit datetimeTo;
        private DevExpress.XtraEditors.DateEdit datetimeFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}