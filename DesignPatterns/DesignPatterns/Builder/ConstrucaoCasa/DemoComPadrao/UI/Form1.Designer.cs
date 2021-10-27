
namespace ContrucaoCasa.Padrao.UI
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
            this.btnCustomizarCasa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrecoCasa = new System.Windows.Forms.Label();
            this.btnContruirCasaPadrao = new System.Windows.Forms.Button();
            this.btnCasaComPiscina = new System.Windows.Forms.Button();
            this.btnCasaComObrasDeArtes = new System.Windows.Forms.Button();
            this.btnCasaComJardins = new System.Windows.Forms.Button();
            this.Customizar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeBanheiros)).BeginInit();
            this.Customizar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade Quartos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade Banheiros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opções:";
            // 
            // UpDownQuantidadeQuartos
            // 
            this.UpDownQuantidadeQuartos.Location = new System.Drawing.Point(181, 32);
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
            this.UpDownQuantidadeBanheiros.Location = new System.Drawing.Point(181, 70);
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
            this.checkedListOpcoes.Location = new System.Drawing.Point(6, 63);
            this.checkedListOpcoes.Name = "checkedListOpcoes";
            this.checkedListOpcoes.Size = new System.Drawing.Size(266, 94);
            this.checkedListOpcoes.TabIndex = 5;
            // 
            // btnCustomizarCasa
            // 
            this.btnCustomizarCasa.Location = new System.Drawing.Point(6, 183);
            this.btnCustomizarCasa.Name = "btnCustomizarCasa";
            this.btnCustomizarCasa.Size = new System.Drawing.Size(266, 23);
            this.btnCustomizarCasa.TabIndex = 6;
            this.btnCustomizarCasa.Text = "Construir casa customizada";
            this.btnCustomizarCasa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço da Casa";
            // 
            // lbPrecoCasa
            // 
            this.lbPrecoCasa.AutoSize = true;
            this.lbPrecoCasa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrecoCasa.Location = new System.Drawing.Point(753, 13);
            this.lbPrecoCasa.Name = "lbPrecoCasa";
            this.lbPrecoCasa.Size = new System.Drawing.Size(21, 25);
            this.lbPrecoCasa.TabIndex = 8;
            this.lbPrecoCasa.Text = "?";
            // 
            // btnContruirCasaPadrao
            // 
            this.btnContruirCasaPadrao.Location = new System.Drawing.Point(678, 63);
            this.btnContruirCasaPadrao.Name = "btnContruirCasaPadrao";
            this.btnContruirCasaPadrao.Size = new System.Drawing.Size(189, 23);
            this.btnContruirCasaPadrao.TabIndex = 9;
            this.btnContruirCasaPadrao.Text = "Casa Padrao";
            this.btnContruirCasaPadrao.UseVisualStyleBackColor = true;
            // 
            // btnCasaComPiscina
            // 
            this.btnCasaComPiscina.Location = new System.Drawing.Point(678, 113);
            this.btnCasaComPiscina.Name = "btnCasaComPiscina";
            this.btnCasaComPiscina.Size = new System.Drawing.Size(189, 23);
            this.btnCasaComPiscina.TabIndex = 10;
            this.btnCasaComPiscina.Text = "Casa Com Piscina";
            this.btnCasaComPiscina.UseVisualStyleBackColor = true;
            // 
            // btnCasaComObrasDeArtes
            // 
            this.btnCasaComObrasDeArtes.Location = new System.Drawing.Point(678, 159);
            this.btnCasaComObrasDeArtes.Name = "btnCasaComObrasDeArtes";
            this.btnCasaComObrasDeArtes.Size = new System.Drawing.Size(189, 23);
            this.btnCasaComObrasDeArtes.TabIndex = 11;
            this.btnCasaComObrasDeArtes.Text = "Casa Com Obras de Artes";
            this.btnCasaComObrasDeArtes.UseVisualStyleBackColor = true;
            // 
            // btnCasaComJardins
            // 
            this.btnCasaComJardins.Location = new System.Drawing.Point(678, 204);
            this.btnCasaComJardins.Name = "btnCasaComJardins";
            this.btnCasaComJardins.Size = new System.Drawing.Size(189, 23);
            this.btnCasaComJardins.TabIndex = 12;
            this.btnCasaComJardins.Text = "Casa Com Jardins";
            this.btnCasaComJardins.UseVisualStyleBackColor = true;
            // 
            // Customizar
            // 
            this.Customizar.Controls.Add(this.checkedListOpcoes);
            this.Customizar.Controls.Add(this.btnCustomizarCasa);
            this.Customizar.Controls.Add(this.lbPrecoCasa);
            this.Customizar.Controls.Add(this.label3);
            this.Customizar.Controls.Add(this.label4);
            this.Customizar.Location = new System.Drawing.Point(12, 277);
            this.Customizar.Name = "Customizar";
            this.Customizar.Size = new System.Drawing.Size(931, 219);
            this.Customizar.TabIndex = 13;
            this.Customizar.TabStop = false;
            this.Customizar.Text = "Customizar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UpDownQuantidadeBanheiros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UpDownQuantidadeQuartos);
            this.groupBox1.Location = new System.Drawing.Point(30, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 172);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quartos e Salas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Customizar);
            this.Controls.Add(this.btnCasaComJardins);
            this.Controls.Add(this.btnCasaComObrasDeArtes);
            this.Controls.Add(this.btnCasaComPiscina);
            this.Controls.Add(this.btnContruirCasaPadrao);
            this.Name = "Form1";
            this.Text = "Construçao de Casas";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQuantidadeBanheiros)).EndInit();
            this.Customizar.ResumeLayout(false);
            this.Customizar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UpDownQuantidadeQuartos;
        private System.Windows.Forms.NumericUpDown UpDownQuantidadeBanheiros;
        private System.Windows.Forms.CheckedListBox checkedListOpcoes;
        private System.Windows.Forms.Button btnCustomizarCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrecoCasa;
        private System.Windows.Forms.Button btnContruirCasaPadrao;
        private System.Windows.Forms.Button btnCasaComPiscina;
        private System.Windows.Forms.Button btnCasaComObrasDeArtes;
        private System.Windows.Forms.Button btnCasaComJardins;
        private System.Windows.Forms.GroupBox Customizar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

