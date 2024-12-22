namespace Ders56
{
    partial class Form2
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
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personelveritabaniDataSet = new Ders56.PersonelveritabaniDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter1 = new Ders56.PersonelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "Ders56.Report1.rdlc";
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.ServerReport.BearerToken = null;
            this.ReportViewer1.Size = new System.Drawing.Size(620, 507);
            this.ReportViewer1.TabIndex = 0;
            // 
            // personelveritabaniDataSet
            // 
            this.personelveritabaniDataSet.DataSetName = "PersonelveritabaniDataSet";
            this.personelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Tbl_Personel";
            this.bindingSource1.DataSource = this.personelveritabaniDataSet;
            // 
            // tbl_PersonelTableAdapter1
            // 
            this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(620, 507);
            this.Controls.Add(this.ReportViewer1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
        private PersonelveritabaniDataSet1 personelveritabaniDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelveritabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private PersonelveritabaniDataSet personelveritabaniDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private PersonelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
    }
}