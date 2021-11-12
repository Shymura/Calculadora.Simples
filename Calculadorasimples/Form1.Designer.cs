namespace Calculadorasimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblSubtracao = new System.Windows.Forms.Label();
            this.lblDivisao = new System.Windows.Forms.Label();
            this.lblMultiplicacao = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(19, 32);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(22, 15);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "N1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(19, 83);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(22, 15);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "N2";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(19, 249);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(41, 15);
            this.lblSoma.TabIndex = 2;
            this.lblSoma.Text = "SOMA";
            // 
            // lblSubtracao
            // 
            this.lblSubtracao.AutoSize = true;
            this.lblSubtracao.Location = new System.Drawing.Point(19, 333);
            this.lblSubtracao.Name = "lblSubtracao";
            this.lblSubtracao.Size = new System.Drawing.Size(73, 15);
            this.lblSubtracao.TabIndex = 3;
            this.lblSubtracao.Text = "SUBTRAÇÃO";
            // 
            // lblDivisao
            // 
            this.lblDivisao.AutoSize = true;
            this.lblDivisao.Location = new System.Drawing.Point(154, 249);
            this.lblDivisao.Name = "lblDivisao";
            this.lblDivisao.Size = new System.Drawing.Size(51, 15);
            this.lblDivisao.TabIndex = 4;
            this.lblDivisao.Text = "DIVISÃO";
            // 
            // lblMultiplicacao
            // 
            this.lblMultiplicacao.AutoSize = true;
            this.lblMultiplicacao.Location = new System.Drawing.Point(154, 333);
            this.lblMultiplicacao.Name = "lblMultiplicacao";
            this.lblMultiplicacao.Size = new System.Drawing.Size(97, 15);
            this.lblMultiplicacao.TabIndex = 5;
            this.lblMultiplicacao.Text = "MULTIPLICAÇÃO";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(82, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(192, 23);
            this.txt1.TabIndex = 7;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(82, 83);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(192, 23);
            this.txt2.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(19, 165);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(256, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 380);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblMultiplicacao);
            this.Controls.Add(this.lblDivisao);
            this.Controls.Add(this.lblSubtracao);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblSubtracao;
        private System.Windows.Forms.Label lblDivisao;
        private System.Windows.Forms.Label lblMultiplicacao;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnCalcular;
    }
}
