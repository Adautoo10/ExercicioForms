namespace ExercicioForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.N1 = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.Somar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.BackColor = System.Drawing.Color.Black;
            this.N1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1.ForeColor = System.Drawing.Color.White;
            this.N1.Location = new System.Drawing.Point(65, 31);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(118, 22);
            this.N1.TabIndex = 0;
            this.N1.Text = "Número 1:";
            // 
            // N2
            // 
            this.N2.AutoSize = true;
            this.N2.BackColor = System.Drawing.Color.Black;
            this.N2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.ForeColor = System.Drawing.Color.White;
            this.N2.Location = new System.Drawing.Point(65, 114);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(118, 22);
            this.N2.TabIndex = 1;
            this.N2.Text = "Número 2:";
            // 
            // txtN1
            // 
            this.txtN1.BackColor = System.Drawing.Color.Black;
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.ForeColor = System.Drawing.Color.White;
            this.txtN1.Location = new System.Drawing.Point(198, 31);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(391, 26);
            this.txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            this.txtN2.BackColor = System.Drawing.Color.Black;
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.ForeColor = System.Drawing.Color.White;
            this.txtN2.Location = new System.Drawing.Point(198, 114);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(391, 26);
            this.txtN2.TabIndex = 3;
            // 
            // Somar
            // 
            this.Somar.BackColor = System.Drawing.Color.Lime;
            this.Somar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Somar.BackgroundImage")));
            this.Somar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somar.Location = new System.Drawing.Point(125, 213);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(152, 75);
            this.Somar.TabIndex = 4;
            this.Somar.Text = "Somar";
            this.Somar.UseVisualStyleBackColor = false;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.Cyan;
            this.Limpar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(328, 213);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(152, 75);
            this.Limpar.TabIndex = 5;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Fechar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Location = new System.Drawing.Point(542, 213);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(152, 75);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.Black;
            this.Resultado.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.White;
            this.Resultado.Location = new System.Drawing.Point(12, 351);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(101, 21);
            this.Resultado.TabIndex = 7;
            this.Resultado.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Black;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblResultado.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(119, 343);
            this.lblResultado.Multiline = true;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(67, 37);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblResultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Somar);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label N1;
        private System.Windows.Forms.Label N2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox lblResultado;
    }
}

