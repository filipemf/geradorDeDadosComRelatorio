namespace GeradorComRelatorio
{
    partial class Form3
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
            this.dadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosDataSet = new GeradorComRelatorio.dadosDataSet();
            this.dadosTableAdapter = new GeradorComRelatorio.dadosDataSetTableAdapters.DadosTableAdapter();
            this.tableAdapterManager = new GeradorComRelatorio.dadosDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dadosBindingSource
            // 
            this.dadosBindingSource.DataMember = "Dados";
            this.dadosBindingSource.DataSource = this.dadosDataSet;
            // 
            // dadosDataSet
            // 
            this.dadosDataSet.DataSetName = "dadosDataSet";
            this.dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosTableAdapter
            // 
            this.dadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DadosTableAdapter = this.dadosTableAdapter;
            this.tableAdapterManager.UpdateOrder = GeradorComRelatorio.dadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GeradorComRelatorio.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(763, 496);
            this.reportViewer1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 496);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dadosDataSet dadosDataSet;
        private System.Windows.Forms.BindingSource dadosBindingSource;
        private dadosDataSetTableAdapters.DadosTableAdapter dadosTableAdapter;
        private dadosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}