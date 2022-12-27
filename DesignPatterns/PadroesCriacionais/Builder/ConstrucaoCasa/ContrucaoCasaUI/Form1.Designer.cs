
namespace ContrucaoCasaUISemPadrao
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDownQuantidadeQuartos = new System.Windows.Forms.NumericUpDown();
            this.UpDownQuantidadeBanheiros = new System.Windows.Forms.NumericUpDown();
            this.checkedListOpcoes = new System.Windows.Forms.CheckedListBox();
            this.btnConstruir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrecoCasa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeBanheiros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade Quartos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade Banheiros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opções:";
            // 
            // UpDownQuantidadeQuartos
            // 
            this.UpDownQuantidadeQuartos.Location = new System.Drawing.Point(173, 26);
            this.UpDownQuantidadeQuartos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDownQuantidadeQuartos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownQuantidadeQuartos.Name = "UpDownQuantidadeQuartos";
            this.UpDownQuantidadeQuartos.Size = new System.Drawing.Size(120, 23);
            this.UpDownQuantidadeQuartos.TabIndex = 3;
            this.UpDownQuantidadeQuartos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpDownQuantidadeBanheiros
            // 
            this.UpDownQuantidadeBanheiros.Location = new System.Drawing.Point(173, 78);
            this.UpDownQuantidadeBanheiros.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDownQuantidadeBanheiros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownQuantidadeBanheiros.Name = "UpDownQuantidadeBanheiros";
            this.UpDownQuantidadeBanheiros.Size = new System.Drawing.Size(120, 23);
            this.UpDownQuantidadeBanheiros.TabIndex = 4;
            this.UpDownQuantidadeBanheiros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkedListOpcoes
            // 
            this.checkedListOpcoes.FormattingEnabled = true;
            this.checkedListOpcoes.Items.AddRange(new object[] {
            "Casa com Garagem",
            "Casa com Piscina",
            "Casa com Obras de artes",
            "Casa com Jardins"});
            this.checkedListOpcoes.Location = new System.Drawing.Point(27, 162);
            this.checkedListOpcoes.Name = "checkedListOpcoes";
            this.checkedListOpcoes.Size = new System.Drawing.Size(266, 94);
            this.checkedListOpcoes.TabIndex = 5;
            // 
            // btnConstruir
            // 
            this.btnConstruir.Location = new System.Drawing.Point(218, 312);
            this.btnConstruir.Name = "btnConstruir";
            this.btnConstruir.Size = new System.Drawing.Size(75, 23);
            this.btnConstruir.TabIndex = 6;
            this.btnConstruir.Text = "Construir";
            this.btnConstruir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço da Casa";
            // 
            // lbPrecoCasa
            // 
            this.lbPrecoCasa.AutoSize = true;
            this.lbPrecoCasa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrecoCasa.Location = new System.Drawing.Point(588, 308);
            this.lbPrecoCasa.Name = "lbPrecoCasa";
            this.lbPrecoCasa.Size = new System.Drawing.Size(21, 25);
            this.lbPrecoCasa.TabIndex = 8;
            this.lbPrecoCasa.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.lbPrecoCasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConstruir);
            this.Controls.Add(this.checkedListOpcoes);
            this.Controls.Add(this.UpDownQuantidadeBanheiros);
            this.Controls.Add(this.UpDownQuantidadeQuartos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Construçao de Casas";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeBanheiros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UpDownQuantidadeQuartos;
        private System.Windows.Forms.NumericUpDown UpDownQuantidadeBanheiros;
        private System.Windows.Forms.CheckedListBox checkedListOpcoes;
        private System.Windows.Forms.Button btnConstruir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrecoCasa;
    }
}

