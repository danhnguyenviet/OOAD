namespace GUI_QLVLXD
{
    partial class FrmBaoCaoCongNoKH
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
            this.BaoCaoCongNoKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoCongNoKH = new GUI_QLVLXD.BaoCaoCongNoKH();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.datetimeFrom = new DevExpress.XtraEditors.DateEdit();
            this.datetimeTo = new DevExpress.XtraEditors.DateEdit();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNoKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNoKH)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BaoCaoCongNoKHBindingSource
            // 
            this.BaoCaoCongNoKHBindingSource.DataMember = "BaoCaoCongNoKH";
            this.BaoCaoCongNoKHBindingSource.DataSource = this.BaoCaoCongNoKH;
            // 
            // BaoCaoCongNoKH
            // 
            this.BaoCaoCongNoKH.DataSetName = "BaoCaoCongNoKH";
            this.BaoCaoCongNoKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.datetimeFrom);
            this.panel1.Controls.Add(this.datetimeTo);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 53);
            this.panel1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(561, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Đến Ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(280, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Từ Ngày:";
            // 
            // datetimeFrom
            // 
            this.datetimeFrom.EditValue = new System.DateTime(2016, 1, 1, 20, 45, 34, 0);
            this.datetimeFrom.Location = new System.Drawing.Point(342, 16);
            this.datetimeFrom.Name = "datetimeFrom";
            this.datetimeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datetimeFrom.Size = new System.Drawing.Size(134, 20);
            this.datetimeFrom.TabIndex = 9;
            this.datetimeFrom.TextChanged += new System.EventHandler(this.FrmBaoCaoCongNoKH_Load);
            // 
            // datetimeTo
            // 
            this.datetimeTo.EditValue = new System.DateTime(2016, 1, 1, 20, 46, 56, 0);
            this.datetimeTo.Location = new System.Drawing.Point(619, 16);
            this.datetimeTo.Name = "datetimeTo";
            this.datetimeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetimeTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datetimeTo.Size = new System.Drawing.Size(134, 20);
            this.datetimeTo.TabIndex = 10;
            this.datetimeTo.TextChanged += new System.EventHandler(this.FrmBaoCaoCongNoKH_Load);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BaoCaoCongNoKHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLVLXD.BaoCaoCongNoKH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 491);
            this.reportViewer1.TabIndex = 1;
            // 
            // FrmBaoCaoCongNoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 552);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBaoCaoCongNoKH";
            this.Text = "FrmBaoCaoCongNoKH";
            this.Load += new System.EventHandler(this.FrmBaoCaoCongNoKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNoKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNoKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit datetimeFrom;
        private DevExpress.XtraEditors.DateEdit datetimeTo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BaoCaoCongNoKHBindingSource;
        private BaoCaoCongNoKH BaoCaoCongNoKH;

    }
}