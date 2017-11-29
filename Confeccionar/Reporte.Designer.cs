namespace Confeccionar
{
    partial class Reporte
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
            this.Datos = new Confeccionar.Datos();
            this.Consulta_ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Consulta_ventaTableAdapter = new Confeccionar.DatosTableAdapters.Consulta_ventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Datos";
            reportDataSource1.Value = this.Consulta_ventaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Confeccionar.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(974, 536);
            this.reportViewer1.TabIndex = 0;
            // 
            // Datos
            // 
            this.Datos.DataSetName = "Datos";
            this.Datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Consulta_ventaBindingSource
            // 
            this.Consulta_ventaBindingSource.DataMember = "Consulta_venta";
            this.Consulta_ventaBindingSource.DataSource = this.Datos;
            // 
            // Consulta_ventaTableAdapter
            // 
            this.Consulta_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 536);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Consulta_ventaBindingSource;
        private Datos Datos;
        private DatosTableAdapters.Consulta_ventaTableAdapter Consulta_ventaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}