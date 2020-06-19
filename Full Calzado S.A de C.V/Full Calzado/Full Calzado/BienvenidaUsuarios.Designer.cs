namespace Full_Calzado
{
    partial class BienvenidaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienvenidaUsuarios));
            this.ContenedorPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorIzq = new System.Windows.Forms.Panel();
            this.ContenedorDer = new System.Windows.Forms.Panel();
            this.LogoIMG = new System.Windows.Forms.PictureBox();
            this.Contador1 = new System.Windows.Forms.Timer(this.components);
            this.Contador2 = new System.Windows.Forms.Timer(this.components);
            this.ProgresoAnimacion = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContenedorPrincipal.SuspendLayout();
            this.ContenedorDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.ColumnCount = 2;
            this.ContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.125F));
            this.ContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.875F));
            this.ContenedorPrincipal.Controls.Add(this.ContenedorIzq, 0, 0);
            this.ContenedorPrincipal.Controls.Add(this.ContenedorDer, 1, 0);
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.RowCount = 1;
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenedorPrincipal.Size = new System.Drawing.Size(800, 400);
            this.ContenedorPrincipal.TabIndex = 0;
            // 
            // ContenedorIzq
            // 
            this.ContenedorIzq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContenedorIzq.BackgroundImage")));
            this.ContenedorIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorIzq.Location = new System.Drawing.Point(0, 0);
            this.ContenedorIzq.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorIzq.Name = "ContenedorIzq";
            this.ContenedorIzq.Size = new System.Drawing.Size(457, 400);
            this.ContenedorIzq.TabIndex = 0;
            // 
            // ContenedorDer
            // 
            this.ContenedorDer.Controls.Add(this.pictureBox1);
            this.ContenedorDer.Controls.Add(this.label1);
            this.ContenedorDer.Controls.Add(this.ProgresoAnimacion);
            this.ContenedorDer.Controls.Add(this.LogoIMG);
            this.ContenedorDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorDer.Location = new System.Drawing.Point(457, 0);
            this.ContenedorDer.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorDer.Name = "ContenedorDer";
            this.ContenedorDer.Size = new System.Drawing.Size(343, 400);
            this.ContenedorDer.TabIndex = 1;
            // 
            // LogoIMG
            // 
            this.LogoIMG.Image = ((System.Drawing.Image)(resources.GetObject("LogoIMG.Image")));
            this.LogoIMG.Location = new System.Drawing.Point(123, 12);
            this.LogoIMG.Name = "LogoIMG";
            this.LogoIMG.Size = new System.Drawing.Size(108, 88);
            this.LogoIMG.TabIndex = 0;
            this.LogoIMG.TabStop = false;
            // 
            // Contador1
            // 
            this.Contador1.Tick += new System.EventHandler(this.Contador1_Tick);
            // 
            // Contador2
            // 
            this.Contador2.Tick += new System.EventHandler(this.Contador2_Tick);
            // 
            // ProgresoAnimacion
            // 
            this.ProgresoAnimacion.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgresoAnimacion.AnimationSpeed = 500;
            this.ProgresoAnimacion.BackColor = System.Drawing.Color.Transparent;
            this.ProgresoAnimacion.Font = new System.Drawing.Font("New Athletic M54", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgresoAnimacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ProgresoAnimacion.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ProgresoAnimacion.InnerMargin = 2;
            this.ProgresoAnimacion.InnerWidth = -1;
            this.ProgresoAnimacion.Location = new System.Drawing.Point(96, 145);
            this.ProgresoAnimacion.MarqueeAnimationSpeed = 2000;
            this.ProgresoAnimacion.Name = "ProgresoAnimacion";
            this.ProgresoAnimacion.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ProgresoAnimacion.OuterMargin = -25;
            this.ProgresoAnimacion.OuterWidth = 26;
            this.ProgresoAnimacion.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.ProgresoAnimacion.ProgressWidth = 25;
            this.ProgresoAnimacion.SecondaryFont = new System.Drawing.Font("BatmanForeverAlternate", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgresoAnimacion.Size = new System.Drawing.Size(171, 164);
            this.ProgresoAnimacion.StartAngle = 270;
            this.ProgresoAnimacion.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgresoAnimacion.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ProgresoAnimacion.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgresoAnimacion.SubscriptText = "%";
            this.ProgresoAnimacion.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgresoAnimacion.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgresoAnimacion.SuperscriptText = "";
            this.ProgresoAnimacion.TabIndex = 1;
            this.ProgresoAnimacion.Text = "0";
            this.ProgresoAnimacion.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgresoAnimacion.Value = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Espere un momento...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BienvenidaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.ContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BienvenidaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciando Sesión, Espere Un Momento";
            this.Load += new System.EventHandler(this.BienvenidaUsuarios_Load);
            this.ContenedorPrincipal.ResumeLayout(false);
            this.ContenedorDer.ResumeLayout(false);
            this.ContenedorDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorPrincipal;
        private System.Windows.Forms.Panel ContenedorIzq;
        private System.Windows.Forms.Panel ContenedorDer;
        private CircularProgressBar.CircularProgressBar ProgresoAnimacion;
        private System.Windows.Forms.PictureBox LogoIMG;
        private System.Windows.Forms.Timer Contador1;
        private System.Windows.Forms.Timer Contador2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}