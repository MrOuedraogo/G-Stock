namespace WindowsFormsApplication1
{
    partial class Etat
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdgestionDataSet1 = new WindowsFormsApplication1.bdgestionDataSet1();
            this.ProduitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProduitsTableAdapter = new WindowsFormsApplication1.bdgestionDataSet1TableAdapters.ProduitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdgestionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProduitsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1022, 459);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bdgestionDataSet1
            // 
            this.bdgestionDataSet1.DataSetName = "bdgestionDataSet1";
            this.bdgestionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProduitsBindingSource
            // 
            this.ProduitsBindingSource.DataMember = "Produits";
            this.ProduitsBindingSource.DataSource = this.bdgestionDataSet1;
            // 
            // ProduitsTableAdapter
            // 
            this.ProduitsTableAdapter.ClearBeforeFill = true;
            // 
            // Etat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 459);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Etat";
            this.Text = "Etat";
            this.Load += new System.EventHandler(this.Etat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgestionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProduitsBindingSource;
        private bdgestionDataSet1 bdgestionDataSet1;
        private bdgestionDataSet1TableAdapters.ProduitsTableAdapter ProduitsTableAdapter;
    }
}