namespace AgenciaDeAutos.GUI.Reports
{
    partial class frm_entrega_unidades
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
            this.listaEntregas = new AgenciaDeAutos.Reportes.DataSets.ListaEntregas();
            this.listaEntregasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listaEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEntregasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListadoEntregasUnidades";
            reportDataSource1.Value = this.listaEntregasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AgenciaDeAutos.Reportes.ListaEntregas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // listaEntregas
            // 
            this.listaEntregas.DataSetName = "ListaEntregas";
            this.listaEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaEntregasBindingSource
            // 
            this.listaEntregasBindingSource.DataSource = this.listaEntregas;
            this.listaEntregasBindingSource.Position = 0;
            // 
            // frm_entrega_unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_entrega_unidades";
            this.Text = "frm_entrega_unidades";
            this.Load += new System.EventHandler(this.frm_entrega_unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEntregasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listaEntregasBindingSource;
        private Reportes.DataSets.ListaEntregas listaEntregas;
    }
}