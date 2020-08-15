namespace GeradorComRelatorio
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
            this.DadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosDataSet = new GeradorComRelatorio.dadosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DadosTableAdapter = new GeradorComRelatorio.dadosDataSetTableAdapters.DadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DadosBindingSource
            // 
            this.DadosBindingSource.DataMember = "Dados";
            this.DadosBindingSource.DataSource = this.dadosDataSet;
            // 
            // dadosDataSet
            // 
            this.dadosDataSet.DataSetName = "dadosDataSet";
            this.dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GeradorComRelatorio.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(551, 314);
            this.reportViewer1.TabIndex = 0;
            // 
            // DadosTableAdapter
            // 
            this.DadosTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 314);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DadosBindingSource;
        private dadosDataSet dadosDataSet;
        private dadosDataSetTableAdapters.DadosTableAdapter DadosTableAdapter;
    }
}