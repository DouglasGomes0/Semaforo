namespace Semaforo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timTemporizador = new System.Windows.Forms.Timer(this.components);
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.pibVerde = new System.Windows.Forms.PictureBox();
            this.pibAmarelo = new System.Windows.Forms.PictureBox();
            this.pibVermelho = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timTemporizador
            // 
            this.timTemporizador.Enabled = true;
            this.timTemporizador.Interval = 30000;
            this.timTemporizador.Tick += new System.EventHandler(this.timTemporizador_Tick);
            // 
            // btnLigar
            // 
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigar.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(246, 86);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(149, 56);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(440, 86);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(151, 56);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // pibVerde
            // 
            this.pibVerde.BackColor = System.Drawing.Color.Black;
            this.pibVerde.Image = global::Semaforo.Properties.Resources.Green_Circle;
            this.pibVerde.Location = new System.Drawing.Point(363, 331);
            this.pibVerde.Name = "pibVerde";
            this.pibVerde.Size = new System.Drawing.Size(111, 80);
            this.pibVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibVerde.TabIndex = 5;
            this.pibVerde.TabStop = false;
            this.pibVerde.Visible = false;
            // 
            // pibAmarelo
            // 
            this.pibAmarelo.BackColor = System.Drawing.Color.Black;
            this.pibAmarelo.Image = global::Semaforo.Properties.Resources.Yellow_circle;
            this.pibAmarelo.Location = new System.Drawing.Point(363, 243);
            this.pibAmarelo.Name = "pibAmarelo";
            this.pibAmarelo.Size = new System.Drawing.Size(111, 79);
            this.pibAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibAmarelo.TabIndex = 4;
            this.pibAmarelo.TabStop = false;
            this.pibAmarelo.Visible = false;
            // 
            // pibVermelho
            // 
            this.pibVermelho.BackColor = System.Drawing.Color.Black;
            this.pibVermelho.Image = global::Semaforo.Properties.Resources.Red_Circle;
            this.pibVermelho.Location = new System.Drawing.Point(363, 165);
            this.pibVermelho.Name = "pibVermelho";
            this.pibVermelho.Size = new System.Drawing.Size(111, 73);
            this.pibVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibVermelho.TabIndex = 3;
            this.pibVermelho.TabStop = false;
            this.pibVermelho.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Semaforo.Properties.Resources.semaforo;
            this.pictureBox1.Location = new System.Drawing.Point(247, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Subheading", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, -6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 78);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Semáforo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibVerde);
            this.Controls.Add(this.pibAmarelo);
            this.Controls.Add(this.pibVermelho);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "semáforo";
            ((System.ComponentModel.ISupportInitialize)(this.pibVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timTemporizador;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.PictureBox pibVermelho;
        private System.Windows.Forms.PictureBox pibAmarelo;
        private System.Windows.Forms.PictureBox pibVerde;
        private System.Windows.Forms.Label lblTitulo;
    }
}

