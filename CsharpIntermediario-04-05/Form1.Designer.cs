namespace CsharpIntermediario_04_05
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
            this.lblQuadrado = new System.Windows.Forms.Label();
            this.btnCalcularQuadrado = new System.Windows.Forms.Button();
            this.txtQuadrado = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuadrado
            // 
            this.lblQuadrado.AutoSize = true;
            this.lblQuadrado.Location = new System.Drawing.Point(440, 166);
            this.lblQuadrado.Name = "lblQuadrado";
            this.lblQuadrado.Size = new System.Drawing.Size(105, 13);
            this.lblQuadrado.TabIndex = 6;
            this.lblQuadrado.Text = "Resultado Quadrado";
            // 
            // btnCalcularQuadrado
            // 
            this.btnCalcularQuadrado.Location = new System.Drawing.Point(453, 109);
            this.btnCalcularQuadrado.Name = "btnCalcularQuadrado";
            this.btnCalcularQuadrado.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularQuadrado.TabIndex = 7;
            this.btnCalcularQuadrado.Text = "button2";
            this.btnCalcularQuadrado.UseVisualStyleBackColor = true;
            this.btnCalcularQuadrado.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuadrado
            // 
            this.txtQuadrado.Location = new System.Drawing.Point(410, 64);
            this.txtQuadrado.Name = "txtQuadrado";
            this.txtQuadrado.Size = new System.Drawing.Size(135, 20);
            this.txtQuadrado.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(111, 60);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(131, 20);
            this.txtBase.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(51, 84);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(54, 19);
            this.txtAltura.TabIndex = 0;
            this.txtAltura.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(131, 166);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(102, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado Triângulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 230);
            this.Controls.Add(this.txtQuadrado);
            this.Controls.Add(this.btnCalcularQuadrado);
            this.Controls.Add(this.lblQuadrado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuadrado;
        private System.Windows.Forms.Button btnCalcularQuadrado;
        public System.Windows.Forms.TextBox txtQuadrado;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
    }
}

