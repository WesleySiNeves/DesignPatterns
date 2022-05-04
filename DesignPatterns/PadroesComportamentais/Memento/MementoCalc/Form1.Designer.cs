namespace MementoCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroIncial = new System.Windows.Forms.TextBox();
            this.txtNumeroFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultadoAtual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultadoAnterior = new System.Windows.Forms.Label();
            this.btnVerResultadoAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // txtNumeroIncial
            // 
            this.txtNumeroIncial.Location = new System.Drawing.Point(96, 72);
            this.txtNumeroIncial.Name = "txtNumeroIncial";
            this.txtNumeroIncial.Size = new System.Drawing.Size(175, 23);
            this.txtNumeroIncial.TabIndex = 1;
            // 
            // txtNumeroFinal
            // 
            this.txtNumeroFinal.Location = new System.Drawing.Point(96, 124);
            this.txtNumeroFinal.Name = "txtNumeroFinal";
            this.txtNumeroFinal.Size = new System.Drawing.Size(175, 23);
            this.txtNumeroFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(342, 126);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // lblResultadoAtual
            // 
            this.lblResultadoAtual.AutoSize = true;
            this.lblResultadoAtual.Location = new System.Drawing.Point(182, 181);
            this.lblResultadoAtual.Name = "lblResultadoAtual";
            this.lblResultadoAtual.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoAtual.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado Anterior";
            // 
            // lblResultadoAnterior
            // 
            this.lblResultadoAnterior.AutoSize = true;
            this.lblResultadoAnterior.Location = new System.Drawing.Point(263, 238);
            this.lblResultadoAnterior.Name = "lblResultadoAnterior";
            this.lblResultadoAnterior.Size = new System.Drawing.Size(105, 15);
            this.lblResultadoAnterior.TabIndex = 8;
            this.lblResultadoAnterior.Text = "Resultado Anterior";
            // 
            // btnVerResultadoAnterior
            // 
            this.btnVerResultadoAnterior.Location = new System.Drawing.Point(454, 128);
            this.btnVerResultadoAnterior.Name = "btnVerResultadoAnterior";
            this.btnVerResultadoAnterior.Size = new System.Drawing.Size(179, 23);
            this.btnVerResultadoAnterior.TabIndex = 9;
            this.btnVerResultadoAnterior.Text = "Resultado Anterior";
            this.btnVerResultadoAnterior.UseVisualStyleBackColor = true;
            this.btnVerResultadoAnterior.Click += new System.EventHandler(this.btnVerResultadoAnterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerResultadoAnterior);
            this.Controls.Add(this.lblResultadoAnterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultadoAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroIncial);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumeroIncial;
        private TextBox txtNumeroFinal;
        private Label label2;
        private Button btnCalcular;
        private Label label3;
        private Label lblResultadoAtual;
        private Label label4;
        private Label lblResultadoAnterior;
        private Button btnVerResultadoAnterior;
    }
}