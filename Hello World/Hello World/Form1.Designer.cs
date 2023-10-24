namespace Hello_World
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.txbNumero3 = new System.Windows.Forms.TextBox();
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.btnImparPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(40, 81);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(15, 25);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 20);
            this.txbNumero1.TabIndex = 1;
            this.txbNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(142, 25);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(100, 20);
            this.txbNumero2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(99, 178);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(142, 81);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(40, 120);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(142, 120);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(278, 9);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(92, 13);
            this.lb3.TabIndex = 10;
            this.lb3.Text = "Digite um número:";
            this.lb3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txbNumero3
            // 
            this.txbNumero3.Location = new System.Drawing.Point(281, 25);
            this.txbNumero3.Name = "txbNumero3";
            this.txbNumero3.Size = new System.Drawing.Size(100, 20);
            this.txbNumero3.TabIndex = 11;
            this.txbNumero3.TextChanged += new System.EventHandler(this.txbNumero3_TextChanged);
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.Location = new System.Drawing.Point(281, 81);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(75, 23);
            this.btnMaiorMenor.TabIndex = 12;
            this.btnMaiorMenor.Text = "Menor Maior";
            this.btnMaiorMenor.UseVisualStyleBackColor = true;
            this.btnMaiorMenor.Click += new System.EventHandler(this.btnMaiorMenor_Click);
            // 
            // btnImparPar
            // 
            this.btnImparPar.Location = new System.Drawing.Point(281, 120);
            this.btnImparPar.Name = "btnImparPar";
            this.btnImparPar.Size = new System.Drawing.Size(75, 23);
            this.btnImparPar.TabIndex = 13;
            this.btnImparPar.Text = "Ímpar ou Par";
            this.btnImparPar.UseVisualStyleBackColor = true;
            this.btnImparPar.Click += new System.EventHandler(this.txbImparPar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(837, 464);
            this.Controls.Add(this.btnImparPar);
            this.Controls.Add(this.btnMaiorMenor);
            this.Controls.Add(this.txbNumero3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.btnSomar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txbNumero3;
        private System.Windows.Forms.Button btnMaiorMenor;
        private System.Windows.Forms.Button btnImparPar;
    }
}

