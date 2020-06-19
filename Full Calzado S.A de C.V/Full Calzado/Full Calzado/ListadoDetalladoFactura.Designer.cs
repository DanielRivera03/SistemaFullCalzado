namespace Full_Calzado
{
    partial class ListadoDetalladoFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDetalladoFactura));
            this.ContenedorPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorListado = new System.Windows.Forms.Panel();
            this.DetallesSimpleFactura = new System.Windows.Forms.DataGridView();
            this.ContenedorSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.lbTextoPrincipal = new System.Windows.Forms.Label();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.IconMaximizar = new System.Windows.Forms.PictureBox();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.ContenedorPrincipal.SuspendLayout();
            this.ContenedorListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSimpleFactura)).BeginInit();
            this.ContenedorSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.ColumnCount = 1;
            this.ContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorPrincipal.Controls.Add(this.ContenedorListado, 0, 1);
            this.ContenedorPrincipal.Controls.Add(this.ContenedorSuperior, 0, 0);
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContenedorPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.RowCount = 2;
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.285714F));
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.71429F));
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContenedorPrincipal.Size = new System.Drawing.Size(918, 622);
            this.ContenedorPrincipal.TabIndex = 1;
            // 
            // ContenedorListado
            // 
            this.ContenedorListado.Controls.Add(this.DetallesSimpleFactura);
            this.ContenedorListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorListado.Location = new System.Drawing.Point(3, 48);
            this.ContenedorListado.Name = "ContenedorListado";
            this.ContenedorListado.Size = new System.Drawing.Size(912, 571);
            this.ContenedorListado.TabIndex = 0;
            // 
            // DetallesSimpleFactura
            // 
            this.DetallesSimpleFactura.AllowUserToAddRows = false;
            this.DetallesSimpleFactura.AllowUserToDeleteRows = false;
            this.DetallesSimpleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetallesSimpleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetallesSimpleFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DetallesSimpleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetallesSimpleFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetallesSimpleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSimpleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallesSimpleFactura.ColumnHeadersHeight = 35;
            this.DetallesSimpleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallesSimpleFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallesSimpleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallesSimpleFactura.EnableHeadersVisualStyles = false;
            this.DetallesSimpleFactura.GridColor = System.Drawing.Color.Black;
            this.DetallesSimpleFactura.Location = new System.Drawing.Point(0, 0);
            this.DetallesSimpleFactura.Name = "DetallesSimpleFactura";
            this.DetallesSimpleFactura.ReadOnly = true;
            this.DetallesSimpleFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallesSimpleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.DetallesSimpleFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetallesSimpleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetallesSimpleFactura.Size = new System.Drawing.Size(912, 571);
            this.DetallesSimpleFactura.TabIndex = 4;
            // 
            // ContenedorSuperior
            // 
            this.ContenedorSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ContenedorSuperior.ColumnCount = 5;
            this.ContenedorSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.90499F));
            this.ContenedorSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.09501F));
            this.ContenedorSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.ContenedorSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.ContenedorSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.ContenedorSuperior.Controls.Add(this.lbTextoPrincipal, 0, 0);
            this.ContenedorSuperior.Controls.Add(this.IconCerrar, 4, 0);
            this.ContenedorSuperior.Controls.Add(this.IconMaximizar, 3, 0);
            this.ContenedorSuperior.Controls.Add(this.IconMinimizar, 2, 0);
            this.ContenedorSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorSuperior.Location = new System.Drawing.Point(3, 3);
            this.ContenedorSuperior.Name = "ContenedorSuperior";
            this.ContenedorSuperior.RowCount = 1;
            this.ContenedorSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorSuperior.Size = new System.Drawing.Size(912, 39);
            this.ContenedorSuperior.TabIndex = 1;
            this.ContenedorSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContenedorSuperior_MouseDown);
            // 
            // lbTextoPrincipal
            // 
            this.lbTextoPrincipal.AutoSize = true;
            this.lbTextoPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPrincipal.ForeColor = System.Drawing.Color.White;
            this.lbTextoPrincipal.Location = new System.Drawing.Point(3, 8);
            this.lbTextoPrincipal.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbTextoPrincipal.Name = "lbTextoPrincipal";
            this.lbTextoPrincipal.Size = new System.Drawing.Size(470, 20);
            this.lbTextoPrincipal.TabIndex = 9;
            this.lbTextoPrincipal.Text = "Listado Completo de Facturas Registradas En El Sistema";
            // 
            // IconCerrar
            // 
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(860, 2);
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(34, 37);
            this.IconCerrar.TabIndex = 8;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // IconMaximizar
            // 
            this.IconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMaximizar.Image")));
            this.IconMaximizar.Location = new System.Drawing.Point(809, 2);
            this.IconMaximizar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.IconMaximizar.Name = "IconMaximizar";
            this.IconMaximizar.Size = new System.Drawing.Size(34, 37);
            this.IconMaximizar.TabIndex = 7;
            this.IconMaximizar.TabStop = false;
            this.IconMaximizar.Click += new System.EventHandler(this.IconMaximizar_Click);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(762, 2);
            this.IconMinimizar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(33, 37);
            this.IconMinimizar.TabIndex = 6;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // ListadoDetalladoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(918, 622);
            this.Controls.Add(this.ContenedorPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoDetalladoFactura";
            this.Text = "ListadoDetalladoFactura";
            this.ContenedorPrincipal.ResumeLayout(false);
            this.ContenedorListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesSimpleFactura)).EndInit();
            this.ContenedorSuperior.ResumeLayout(false);
            this.ContenedorSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorPrincipal;
        private System.Windows.Forms.Panel ContenedorListado;
        private System.Windows.Forms.DataGridView DetallesSimpleFactura;
        private System.Windows.Forms.TableLayoutPanel ContenedorSuperior;
        private System.Windows.Forms.Label lbTextoPrincipal;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.PictureBox IconMaximizar;
        private System.Windows.Forms.PictureBox IconMinimizar;
    }
}