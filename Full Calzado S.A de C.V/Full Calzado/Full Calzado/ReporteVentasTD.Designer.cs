namespace Full_Calzado
{
    partial class ReporteVentasTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasTD));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosfactura = new Full_Calzado.datosfactura();
            this.ContendorReportes = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorInfoBotones = new System.Windows.Forms.Panel();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.Separador2 = new System.Windows.Forms.PictureBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.DataTable1TableAdapter = new Full_Calzado.datosfacturaTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosfactura)).BeginInit();
            this.ContendorReportes.SuspendLayout();
            this.ContenedorInfoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.datosfactura;
            // 
            // datosfactura
            // 
            this.datosfactura.DataSetName = "datosfactura";
            this.datosfactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContendorReportes
            // 
            this.ContendorReportes.ColumnCount = 1;
            this.ContendorReportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContendorReportes.Controls.Add(this.ContenedorInfoBotones, 0, 0);
            this.ContendorReportes.Controls.Add(this.reportViewer1, 0, 2);
            this.ContendorReportes.Controls.Add(this.panel1, 0, 1);
            this.ContendorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContendorReportes.Location = new System.Drawing.Point(0, 0);
            this.ContendorReportes.Name = "ContendorReportes";
            this.ContendorReportes.RowCount = 3;
            this.ContendorReportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.659794F));
            this.ContendorReportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.ContendorReportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.34021F));
            this.ContendorReportes.Size = new System.Drawing.Size(695, 619);
            this.ContendorReportes.TabIndex = 0;
            // 
            // ContenedorInfoBotones
            // 
            this.ContenedorInfoBotones.Controls.Add(this.IconMinimizar);
            this.ContenedorInfoBotones.Controls.Add(this.IconCerrar);
            this.ContenedorInfoBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorInfoBotones.Location = new System.Drawing.Point(0, 0);
            this.ContenedorInfoBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorInfoBotones.Name = "ContenedorInfoBotones";
            this.ContenedorInfoBotones.Size = new System.Drawing.Size(695, 48);
            this.ContenedorInfoBotones.TabIndex = 3;
            this.ContenedorInfoBotones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContenedorInfoBotones_MouseDown);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(605, 0);
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
            this.IconCerrar.Location = new System.Drawing.Point(649, 0);
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Full_Calzado.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 509);
            this.reportViewer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscarCodigo);
            this.panel1.Controls.Add(this.Separador2);
            this.panel1.Controls.Add(this.txtmes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 50);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Good Times Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Digite Solamente el Numero del Mes:";
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnBuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCodigo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCodigo.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCodigo.Location = new System.Drawing.Point(590, 8);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(90, 34);
            this.btnBuscarCodigo.TabIndex = 71;
            this.btnBuscarCodigo.Text = "BUSCAR";
            this.btnBuscarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodigo.UseVisualStyleBackColor = false;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarMes_Click);
            // 
            // Separador2
            // 
            this.Separador2.BackColor = System.Drawing.Color.White;
            this.Separador2.Location = new System.Drawing.Point(392, 37);
            this.Separador2.Name = "Separador2";
            this.Separador2.Size = new System.Drawing.Size(126, 5);
            this.Separador2.TabIndex = 47;
            this.Separador2.TabStop = false;
            // 
            // txtmes
            // 
            this.txtmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtmes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmes.Font = new System.Drawing.Font("Russo One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.ForeColor = System.Drawing.Color.White;
            this.txtmes.Location = new System.Drawing.Point(392, 12);
            this.txtmes.MaxLength = 50;
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(126, 24);
            this.txtmes.TabIndex = 46;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentasTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(695, 619);
            this.Controls.Add(this.ContendorReportes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentasTD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVentasTD";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosfactura)).EndInit();
            this.ContendorReportes.ResumeLayout(false);
            this.ContenedorInfoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContendorReportes;
        private System.Windows.Forms.Panel ContenedorInfoBotones;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Separador2;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private datosfactura datosfactura;
        private datosfacturaTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Label label1;
    }
}