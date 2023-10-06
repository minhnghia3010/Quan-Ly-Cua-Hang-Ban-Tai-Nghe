
namespace DoAnThucTap
{
    partial class FormInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.INHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSHOPDataSet = new DoAnThucTap.QLSHOPDataSet();
            this.TONGHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.INHOADONTableAdapter = new DoAnThucTap.QLSHOPDataSetTableAdapters.INHOADONTableAdapter();
            this.TONGHOADONTableAdapter = new DoAnThucTap.QLSHOPDataSetTableAdapters.TONGHOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.INHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TONGHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // INHOADONBindingSource
            // 
            this.INHOADONBindingSource.DataMember = "INHOADON";
            this.INHOADONBindingSource.DataSource = this.QLSHOPDataSet;
            // 
            // QLSHOPDataSet
            // 
            this.QLSHOPDataSet.DataSetName = "QLSHOPDataSet";
            this.QLSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TONGHOADONBindingSource
            // 
            this.TONGHOADONBindingSource.DataMember = "TONGHOADON";
            this.TONGHOADONBindingSource.DataSource = this.QLSHOPDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.INHOADONBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TONGHOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnThucTap.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(904, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // INHOADONTableAdapter
            // 
            this.INHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // TONGHOADONTableAdapter
            // 
            this.TONGHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 495);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TONGHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource INHOADONBindingSource;
        private QLSHOPDataSet QLSHOPDataSet;
        private System.Windows.Forms.BindingSource TONGHOADONBindingSource;
        private QLSHOPDataSetTableAdapters.INHOADONTableAdapter INHOADONTableAdapter;
        private QLSHOPDataSetTableAdapters.TONGHOADONTableAdapter TONGHOADONTableAdapter;
    }
}