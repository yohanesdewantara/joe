namespace pakaian
{
    partial class FormLaporan
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
            this.jenisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utspakaianDataSet = new pakaian.utspakaianDataSet();
            this.jenisTableAdapter = new pakaian.utspakaianDataSetTableAdapters.jenisTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utspakaianDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // jenisBindingSource
            // 
            this.jenisBindingSource.DataMember = "jenis";
            this.jenisBindingSource.DataSource = this.utspakaianDataSet;
            // 
            // utspakaianDataSet
            // 
            this.utspakaianDataSet.DataSetName = "utspakaianDataSet";
            this.utspakaianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisTableAdapter
            // 
            this.jenisTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetJenis";
            reportDataSource1.Value = this.jenisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pakaian.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 357);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jenisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utspakaianDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource jenisBindingSource;
        private utspakaianDataSet utspakaianDataSet;
        private utspakaianDataSetTableAdapters.jenisTableAdapter jenisTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}