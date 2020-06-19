namespace Full_Calzado
{
    partial class ReporteVentasCCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasCCF));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosfactura = new Full_Calzado.datosfactura();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorInfoBotones = new System.Windows.Forms.Panel();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarMes = new System.Windows.Forms.Button();
            this.Separador2 = new System.Windows.Forms.PictureBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable4TableAdapter = new Full_Calzado.datosfacturaTableAdapters.DataTable4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosfactura)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContenedorInfoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable4BindingSource
            // 
            this.DataTable4BindingSource.DataMember = "DataTable4";
            this.DataTable4BindingSource.DataSource = this.datosfactura;
            // 
            // datosfactura
            // 
            this.datosfactura.DataSetName = "datosfactura";
            this.datosfactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ContenedorInfoBotones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 524F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContenedorInfoBotones
            // 
            this.ContenedorInfoBotones.Controls.Add(this.IconMinimizar);
            this.ContenedorInfoBotones.Controls.Add(this.IconCerrar);
            this.ContenedorInfoBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorInfoBotones.Location = new System.Drawing.Point(0, 0);
            this.ContenedorInfoBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorInfoBotones.Name = "ContenedorInfoBotones";
            this.ContenedorInfoBotones.Size = new System.Drawing.Size(695, 39);
            this.ContenedorInfoBotones.TabIndex = 4;
            this.ContenedorInfoBotones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContenedorInfoBotones_MouseDown);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(619, 0);
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
            this.IconCerrar.Location = new System.Drawing.Point(652, 0);
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(34, 37);
            this.IconCerrar.TabIndex = 5;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscarMes);
            this.panel1.Controls.Add(this.Separador2);
            this.panel1.Controls.Add(this.txtmes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 50);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Good Times Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Digite Solamente el Numero del Mes:";
            // 
            // btnBuscarMes
            // 
            this.btnBuscarMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnBuscarMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMes.FlatAppearance.BorderSize = 0;
            this.btnBuscarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMes.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMes.Location = new System.Drawing.Point(590, 10);
            this.btnBuscarMes.Name = "btnBuscarMes";
            this.btnBuscarMes.Size = new System.Drawing.Size(90, 34);
            this.btnBuscarMes.TabIndex = 71;
            this.btnBuscarMes.Text = "BUSCAR";
            this.btnBuscarMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarMes.UseVisualStyleBackColor = false;
            this.btnBuscarMes.Click += new System.EventHandler(this.btnBuscarMes_Click);
            // 
            // Separador2
            // 
            this.Separador2.BackColor = System.Drawing.Color.White;
            this.Separador2.Location = new System.Drawing.Point(420, 39);
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
            this.txtmes.Location = new System.Drawing.Point(420, 9);
            this.txtmes.MaxLength = 50;
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(126, 24);
            this.txtmes.TabIndex = 46;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Full_Calzado.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 518);
            this.reportViewer1.TabIndex = 7;
            // 
            // DataTable4TableAdapter
            // 
            this.DataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentasCCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(695, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentasCCF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVentasCCF";
            this.Load += new System.EventHandler(this.ReporteVentasCCF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosfactura)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContenedorInfoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ContenedorInfoBotones;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarMes;
        private System.Windows.Forms.PictureBox Separador2;
        private System.Windows.Forms.TextBox txtmes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable4BindingSource;
        private datosfactura datosfactura;
        private datosfacturaTableAdapters.DataTable4TableAdapter DataTable4TableAdapter;
        private System.Windows.Forms.Label label1;
    }
}