namespace Full_Calzado
{
    partial class ReporteVentasEmpelado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasEmpelado));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReporteVentasEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosEmpleadosFC = new Full_Calzado.DatosEmpleadosFC();
            this.ContenedorReporte = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorInfoBotones = new System.Windows.Forms.Panel();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteVentasEmpleadoTableAdapter = new Full_Calzado.DatosEmpleadosFCTableAdapters.ReporteVentasEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleadosFC)).BeginInit();
            this.ContenedorReporte.SuspendLayout();
            this.ContenedorInfoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteVentasEmpleadoBindingSource
            // 
            this.ReporteVentasEmpleadoBindingSource.DataMember = "ReporteVentasEmpleado";
            this.ReporteVentasEmpleadoBindingSource.DataSource = this.DatosEmpleadosFC;
            // 
            // DatosEmpleadosFC
            // 
            this.DatosEmpleadosFC.DataSetName = "DatosEmpleadosFC";
            this.DatosEmpleadosFC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContenedorReporte
            // 
            this.ContenedorReporte.ColumnCount = 1;
            this.ContenedorReporte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorReporte.Controls.Add(this.ContenedorInfoBotones, 0, 0);
            this.ContenedorReporte.Controls.Add(this.reportViewer1, 0, 1);
            this.ContenedorReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorReporte.Location = new System.Drawing.Point(0, 0);
            this.ContenedorReporte.Name = "ContenedorReporte";
            this.ContenedorReporte.RowCount = 2;
            this.ContenedorReporte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.946688F));
            this.ContenedorReporte.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.05331F));
            this.ContenedorReporte.Size = new System.Drawing.Size(691, 619);
            this.ContenedorReporte.TabIndex = 0;
            // 
            // ContenedorInfoBotones
            // 
            this.ContenedorInfoBotones.Controls.Add(this.IconMinimizar);
            this.ContenedorInfoBotones.Controls.Add(this.IconCerrar);
            this.ContenedorInfoBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorInfoBotones.Location = new System.Drawing.Point(0, 0);
            this.ContenedorInfoBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorInfoBotones.Name = "ContenedorInfoBotones";
            this.ContenedorInfoBotones.Size = new System.Drawing.Size(691, 42);
            this.ContenedorInfoBotones.TabIndex = 6;
            this.ContenedorInfoBotones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContenedorInfoBotones_MouseDown);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(595, 5);
            this.IconMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(33, 37);
            this.IconMinimizar.TabIndex = 4;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(639, 5);
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(34, 37);
            this.IconCerrar.TabIndex = 5;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteVentasEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Full_Calzado.VentasEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(685, 571);
            this.reportViewer1.TabIndex = 7;
            // 
            // ReporteVentasEmpleadoTableAdapter
            // 
            this.ReporteVentasEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentasEmpelado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(691, 619);
            this.Controls.Add(this.ContenedorReporte);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentasEmpelado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVentasEmpelado";
            this.Load += new System.EventHandler(this.ReporteVentasEmpelado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleadosFC)).EndInit();
            this.ContenedorReporte.ResumeLayout(false);
            this.ContenedorInfoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorReporte;
        private System.Windows.Forms.Panel ContenedorInfoBotones;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteVentasEmpleadoBindingSource;
        private DatosEmpleadosFC DatosEmpleadosFC;
        private DatosEmpleadosFCTableAdapters.ReporteVentasEmpleadoTableAdapter ReporteVentasEmpleadoTableAdapter;
    }
}