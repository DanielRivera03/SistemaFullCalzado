namespace Full_Calzado
{
    partial class ConsultaFacturacionAmpliada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFacturacionAmpliada));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EncabezadoFactura = new System.Windows.Forms.TableLayoutPanel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DetallesSimplesFacturacion = new System.Windows.Forms.DataGridView();
            this.ContenedorConsultaAvanzada = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAyuda = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.Separador1 = new System.Windows.Forms.PictureBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.EncabezadoFactura.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSimplesFacturacion)).BeginInit();
            this.ContenedorConsultaAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EncabezadoFactura, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EncabezadoFactura
            // 
            this.EncabezadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.EncabezadoFactura.ColumnCount = 4;
            this.EncabezadoFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.59364F));
            this.EncabezadoFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.406365F));
            this.EncabezadoFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.EncabezadoFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.EncabezadoFactura.Controls.Add(this.lbMensaje, 0, 0);
            this.EncabezadoFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoFactura.Location = new System.Drawing.Point(0, 0);
            this.EncabezadoFactura.Margin = new System.Windows.Forms.Padding(0);
            this.EncabezadoFactura.Name = "EncabezadoFactura";
            this.EncabezadoFactura.RowCount = 1;
            this.EncabezadoFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncabezadoFactura.Size = new System.Drawing.Size(900, 45);
            this.EncabezadoFactura.TabIndex = 1;
            this.EncabezadoFactura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.White;
            this.lbMensaje.Location = new System.Drawing.Point(20, 15);
            this.lbMensaje.Margin = new System.Windows.Forms.Padding(20, 15, 3, 0);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(324, 18);
            this.lbMensaje.TabIndex = 8;
            this.lbMensaje.Text = "Vista y Consulta Avanzada Facturacion";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DetallesSimplesFacturacion, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ContenedorConsultaAvanzada, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33668F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.66331F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(894, 399);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // DetallesSimplesFacturacion
            // 
            this.DetallesSimplesFacturacion.AllowUserToAddRows = false;
            this.DetallesSimplesFacturacion.AllowUserToDeleteRows = false;
            this.DetallesSimplesFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesSimplesFacturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesSimplesFacturacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DetallesSimplesFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesSimplesFacturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesSimplesFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSimplesFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesSimplesFacturacion.ColumnHeadersHeight = 35;
            this.DetallesSimplesFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesSimplesFacturacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesSimplesFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallesSimplesFacturacion.EnableHeadersVisualStyles = false;
            this.DetallesSimplesFacturacion.GridColor = System.Drawing.Color.Black;
            this.DetallesSimplesFacturacion.Location = new System.Drawing.Point(3, 72);
            this.DetallesSimplesFacturacion.Name = "DetallesSimplesFacturacion";
            this.DetallesSimplesFacturacion.ReadOnly = true;
            this.DetallesSimplesFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSimplesFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.DetallesSimplesFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesSimplesFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesSimplesFacturacion.Size = new System.Drawing.Size(888, 324);
            this.DetallesSimplesFacturacion.TabIndex = 5;
            // 
            // ContenedorConsultaAvanzada
            // 
            this.ContenedorConsultaAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ContenedorConsultaAvanzada.Controls.Add(this.label1);
            this.ContenedorConsultaAvanzada.Controls.Add(this.lbAyuda);
            this.ContenedorConsultaAvanzada.Controls.Add(this.lbID);
            this.ContenedorConsultaAvanzada.Controls.Add(this.Separador1);
            this.ContenedorConsultaAvanzada.Controls.Add(this.txtIdProducto);
            this.ContenedorConsultaAvanzada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorConsultaAvanzada.Location = new System.Drawing.Point(3, 3);
            this.ContenedorConsultaAvanzada.Name = "ContenedorConsultaAvanzada";
            this.ContenedorConsultaAvanzada.Size = new System.Drawing.Size(888, 63);
            this.ContenedorConsultaAvanzada.TabIndex = 1;
            this.ContenedorConsultaAvanzada.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContenedorConsultaAvanzada_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nasalization Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(577, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Importante Tomar En Cuenta:";
            // 
            // lbAyuda
            // 
            this.lbAyuda.AutoSize = true;
            this.lbAyuda.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAyuda.ForeColor = System.Drawing.Color.Red;
            this.lbAyuda.Location = new System.Drawing.Point(465, 34);
            this.lbAyuda.Name = "lbAyuda";
            this.lbAyuda.Size = new System.Drawing.Size(407, 18);
            this.lbAyuda.TabIndex = 8;
            this.lbAyuda.Text = "* Únicamente Procesamos Búsquedas Númericas";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(19, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(274, 18);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "Por Favor, Ingrese ID Facturacion";
            // 
            // Separador1
            // 
            this.Separador1.BackColor = System.Drawing.Color.White;
            this.Separador1.Location = new System.Drawing.Point(299, 47);
            this.Separador1.Name = "Separador1";
            this.Separador1.Size = new System.Drawing.Size(76, 5);
            this.Separador1.TabIndex = 5;
            this.Separador1.TabStop = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProducto.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.Color.White;
            this.txtIdProducto.Location = new System.Drawing.Point(299, 19);
            this.txtIdProducto.MaxLength = 50;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(76, 22);
            this.txtIdProducto.TabIndex = 4;
            this.txtIdProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdProducto_KeyUp);
            // 
            // ConsultaFacturacionAmpliada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaFacturacionAmpliada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaFacturacionAmpliada";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EncabezadoFactura.ResumeLayout(false);
            this.EncabezadoFactura.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSimplesFacturacion)).EndInit();
            this.ContenedorConsultaAvanzada.ResumeLayout(false);
            this.ContenedorConsultaAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel EncabezadoFactura;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel ContenedorConsultaAvanzada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAyuda;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox Separador1;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DataGridView DetallesSimplesFacturacion;
    }
}