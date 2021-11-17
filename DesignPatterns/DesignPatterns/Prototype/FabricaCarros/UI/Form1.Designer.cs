
namespace UI
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
            this.btnCriarCarro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClonar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.NumericUpDown();
            this.lblTempoGastoNew = new System.Windows.Forms.Label();
            this.txtQuantidadeCarros = new System.Windows.Forms.TextBox();
            this.txtQuantidadeCavalos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTempoGastoClonagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarCarro
            // 
            this.btnCriarCarro.Location = new System.Drawing.Point(91, 291);
            this.btnCriarCarro.Name = "btnCriarCarro";
            this.btnCriarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnCriarCarro.TabIndex = 0;
            this.btnCriarCarro.Text = "CriarCarro";
            this.btnCriarCarro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade Carros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ano";
            // 
            // btnClonar
            // 
            this.btnClonar.Location = new System.Drawing.Point(206, 291);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(75, 23);
            this.btnClonar.TabIndex = 6;
            this.btnClonar.Text = "Clonar Carro";
            this.btnClonar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tempo Gasto";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(91, 79);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(190, 23);
            this.txtMarca.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(91, 128);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(190, 23);
            this.txtModelo.TabIndex = 9;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(91, 164);
            this.txtAno.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.txtAno.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(190, 23);
            this.txtAno.TabIndex = 10;
            this.txtAno.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // lblTempoGastoNew
            // 
            this.lblTempoGastoNew.AutoSize = true;
            this.lblTempoGastoNew.Location = new System.Drawing.Point(98, 344);
            this.lblTempoGastoNew.Name = "lblTempoGastoNew";
            this.lblTempoGastoNew.Size = new System.Drawing.Size(68, 15);
            this.lblTempoGastoNew.TabIndex = 11;
            this.lblTempoGastoNew.Text = "informacao";
            // 
            // txtQuantidadeCarros
            // 
            this.txtQuantidadeCarros.Location = new System.Drawing.Point(168, 45);
            this.txtQuantidadeCarros.Name = "txtQuantidadeCarros";
            this.txtQuantidadeCarros.Size = new System.Drawing.Size(113, 23);
            this.txtQuantidadeCarros.TabIndex = 12;
            // 
            // txtQuantidadeCavalos
            // 
            this.txtQuantidadeCavalos.Location = new System.Drawing.Point(156, 212);
            this.txtQuantidadeCavalos.Name = "txtQuantidadeCavalos";
            this.txtQuantidadeCavalos.Size = new System.Drawing.Size(125, 23);
            this.txtQuantidadeCavalos.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantidade Cavalos:";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(156, 238);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(125, 23);
            this.txtPotencia.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Potencia:";
            // 
            // lblTempoGastoClonagem
            // 
            this.lblTempoGastoClonagem.AutoSize = true;
            this.lblTempoGastoClonagem.Location = new System.Drawing.Point(213, 344);
            this.lblTempoGastoClonagem.Name = "lblTempoGastoClonagem";
            this.lblTempoGastoClonagem.Size = new System.Drawing.Size(68, 15);
            this.lblTempoGastoClonagem.TabIndex = 17;
            this.lblTempoGastoClonagem.Text = "informacao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 484);
            this.Controls.Add(this.lblTempoGastoClonagem);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantidadeCavalos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantidadeCarros);
            this.Controls.Add(this.lblTempoGastoNew);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClonar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarCarro);
            this.Name = "Form1";
            this.Text = "Fabrica de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.txtAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown txtAno;
        private System.Windows.Forms.Label lblTempoGastoNew;
        private System.Windows.Forms.TextBox txtQuantidadeCarros;
        private System.Windows.Forms.TextBox txtQuantidadeCavalos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTempoGastoClonagem;
    }
}

