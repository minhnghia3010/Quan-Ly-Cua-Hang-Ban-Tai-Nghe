
namespace DoAnThucTap
{
    partial class FormInNhapHang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.INNHAPHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoAnThucTapDataSet1 = new DoAnThucTap.DoAnThucTapDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.INNHAPHANGTableAdapter = new DoAnThucTap.DoAnThucTapDataSet1TableAdapters.INNHAPHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.INNHAPHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnThucTapDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // INNHAPHANGBindingSource
            // 
            this.INNHAPHANGBindingSource.DataMember = "INNHAPHANG";
            this.INNHAPHANGBindingSource.DataSource = this.DoAnThucTapDataSet1;
            // 
            // DoAnThucTapDataSet1
            // 
            this.DoAnThucTapDataSet1.DataSetName = "DoAnThucTapDataSet1";
            this.DoAnThucTapDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.INNHAPHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnThucTap.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(914, 439);
            this.reportViewer1.TabIndex = 0;
            // 
            // INNHAPHANGTableAdapter
            // 
            this.INNHAPHANGTableAdapter.ClearBeforeFill = true;
            // 
            // FormInNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 439);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.FormInNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INNHAPHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnThucTapDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource INNHAPHANGBindingSource;
        private DoAnThucTapDataSet1 DoAnThucTapDataSet1;
        private DoAnThucTapDataSet1TableAdapters.INNHAPHANGTableAdapter INNHAPHANGTableAdapter;
    }
}