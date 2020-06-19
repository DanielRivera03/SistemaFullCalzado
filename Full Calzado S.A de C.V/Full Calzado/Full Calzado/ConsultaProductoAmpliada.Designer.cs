namespace Full_Calzado
{
    partial class ConsultaProductoAmpliada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProductoAmpliada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContenedorVista = new System.Windows.Forms.TableLayoutPanel();
            this.EncabezadoProducto = new System.Windows.Forms.TableLayoutPanel();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.ContenedorConsulta = new System.Windows.Forms.TableLayoutPanel();
            this.DetallesSimplesProducto = new System.Windows.Forms.DataGridView();
            this.ContenedorConsultaAvanzada = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAyuda = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.Separador1 = new System.Windows.Forms.PictureBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.ContenedorVista.SuspendLayout();
            this.EncabezadoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.ContenedorConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSimplesProducto)).BeginInit();
            this.ContenedorConsultaAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorVista
            // 
            this.ContenedorVista.ColumnCount = 1;
            this.ContenedorVista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorVista.Controls.Add(this.EncabezadoProducto, 0, 0);
            this.ContenedorVista.Controls.Add(this.ContenedorConsulta, 0, 1);
            this.ContenedorVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorVista.Location = new System.Drawing.Point(0, 0);
            this.ContenedorVista.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorVista.Name = "ContenedorVista";
            this.ContenedorVista.RowCount = 2;
            this.ContenedorVista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777778F));
            this.ContenedorVista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.ContenedorVista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorVista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorVista.Size = new System.Drawing.Size(900, 450);
            this.ContenedorVista.TabIndex = 1;
            // 
            // EncabezadoProducto
            // 
            this.EncabezadoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.EncabezadoProducto.ColumnCount = 4;
            this.EncabezadoProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.59364F));
            this.EncabezadoProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.406365F));
            this.EncabezadoProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.EncabezadoProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.EncabezadoProducto.Controls.Add(this.IconMinimizar, 1, 0);
            this.EncabezadoProducto.Controls.Add(this.IconCerrar, 3, 0);
            this.EncabezadoProducto.Controls.Add(this.lbMensaje, 0, 0);
            this.EncabezadoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoProducto.Location = new System.Drawing.Point(0, 0);
            this.EncabezadoProducto.Margin = new System.Windows.Forms.Padding(0);
            this.EncabezadoProducto.Name = "EncabezadoProducto";
            this.EncabezadoProducto.RowCount = 1;
            this.EncabezadoProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncabezadoProducto.Size = new System.Drawing.Size(900, 43);
            this.EncabezadoProducto.TabIndex = 0;
            this.EncabezadoProducto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(804, 0);
            this.IconMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(37, 43);
            this.IconMinimizar.TabIndex = 1;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(849, 0);
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(51, 43);
            this.IconCerrar.TabIndex = 3;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Nasalization Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.White;
            this.lbMensaje.Location = new System.Drawing.Point(20, 15);
            this.lbMensaje.Margin = new System.Windows.Forms.Padding(20, 15, 3, 0);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(300, 18);
            this.lbMensaje.TabIndex = 8;
            this.lbMensaje.Text = "Vista y Consulta Avanzada Producto";
            // 
            // ContenedorConsulta
            // 
            this.ContenedorConsulta.ColumnCount = 1;
            this.ContenedorConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorConsulta.Controls.Add(this.DetallesSimplesProducto, 0, 1);
            this.ContenedorConsulta.Controls.Add(this.ContenedorConsultaAvanzada, 0, 0);
            this.ContenedorConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorConsulta.Location = new System.Drawing.Point(0, 43);
            this.ContenedorConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorConsulta.Name = "ContenedorConsulta";
            this.ContenedorConsulta.RowCount = 2;
            this.ContenedorConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.44472F));
            this.ContenedorConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.55528F));
            this.ContenedorConsulta.Size = new System.Drawing.Size(900, 407);
            this.ContenedorConsulta.TabIndex = 1;
            // 
            // DetallesSimplesProducto
            // 
            this.DetallesSimplesProducto.AllowUserToAddRows = false;
            this.DetallesSimplesProducto.AllowUserToDeleteRows = false;
            this.DetallesSimplesProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesSimplesProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesSimplesProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DetallesSimplesProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesSimplesProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesSimplesProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSimplesProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesSimplesProducto.ColumnHeadersHeight = 35;
            this.DetallesSimplesProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesSimplesProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesSimplesProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallesSimplesProducto.EnableHeadersVisualStyles = false;
            this.DetallesSimplesProducto.GridColor = System.Drawing.Color.Black;
            this.DetallesSimplesProducto.Location = new System.Drawing.Point(3, 74);
            this.DetallesSimplesProducto.Name = "DetallesSimplesProducto";
            this.DetallesSimplesProducto.ReadOnly = true;
            this.DetallesSimplesProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSimplesProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.DetallesSimplesProducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesSimplesProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesSimplesProducto.Size = new System.Drawing.Size(894, 330);
            this.DetallesSimplesProducto.TabIndex = 4;
            // 
            // ContenedorConsultaAvanzada
            // 
            this.ContenedorConsultaAvanzada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContenedorConsultaAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ContenedorConsultaAvanzada.Controls.Add(this.label1);
            this.ContenedorConsultaAvanzada.Controls.Add(this.lbAyuda);
            this.ContenedorConsultaAvanzada.Controls.Add(this.lbID);
            this.ContenedorConsultaAvanzada.Controls.Add(this.Separador1);
            this.ContenedorConsultaAvanzada.Controls.Add(this.txtIdProducto);
            this.ContenedorConsultaAvanzada.Location = new System.Drawing.Point(3, 3);
            this.ContenedorConsultaAvanzada.Name = "ContenedorConsultaAvanzada";
            this.ContenedorConsultaAvanzada.Size = new System.Drawing.Size(894, 64);
            this.ContenedorConsultaAvanzada.TabIndex = 0;
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
            this.lbID.Size = new System.Drawing.Size(250, 18);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "Por Favor, Ingrese ID Producto";
            // 
            // Separador1
            // 
            this.Separador1.BackColor = System.Drawing.Color.White;
            this.Separador1.Location = new System.Drawing.Point(284, 46);
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
            this.txtIdProducto.Location = new System.Drawing.Point(284, 18);
            this.txtIdProducto.MaxLength = 50;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(76, 22);
            this.txtIdProducto.TabIndex = 4;
            this.txtIdProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdProducto_KeyUp);
            // 
            // ConsultaProductoAmpliada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.ContenedorVista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaProductoAmpliada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaProductoAmpliada";
            this.ContenedorVista.ResumeLayout(false);
            this.EncabezadoProducto.ResumeLayout(false);
            this.EncabezadoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.ContenedorConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSimplesProducto)).EndInit();
            this.ContenedorConsultaAvanzada.ResumeLayout(false);
            this.ContenedorConsultaAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorVista;
        private System.Windows.Forms.TableLayoutPanel EncabezadoProducto;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TableLayoutPanel ContenedorConsulta;
        private System.Windows.Forms.DataGridView DetallesSimplesProducto;
        private System.Windows.Forms.Panel ContenedorConsultaAvanzada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAyuda;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox Separador1;
        private System.Windows.Forms.TextBox txtIdProducto;
    }
}