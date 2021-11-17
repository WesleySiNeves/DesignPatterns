
namespace SoldadoUi
{
    partial class Exercicio
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
            this.txtQuantidadeSoldados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShallowCopy = new System.Windows.Forms.Button();
            this.btnDeepCopy = new System.Windows.Forms.Button();
            this.ListBoxAcessorios = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTempoShallowCopy = new System.Windows.Forms.Label();
            this.lblDeepCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantidadeSoldados
            // 
            this.txtQuantidadeSoldados.Location = new System.Drawing.Point(213, 36);
            this.txtQuantidadeSoldados.Name = "txtQuantidadeSoldados";
            this.txtQuantidadeSoldados.Size = new System.Drawing.Size(117, 23);
            this.txtQuantidadeSoldados.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quantidade De Soldados";
            // 
            // btnShallowCopy
            // 
            this.btnShallowCopy.Location = new System.Drawing.Point(58, 253);
            this.btnShallowCopy.Name = "btnShallowCopy";
            this.btnShallowCopy.Size = new System.Drawing.Size(102, 23);
            this.btnShallowCopy.TabIndex = 15;
            this.btnShallowCopy.Text = "ShallowCopy";
            this.btnShallowCopy.UseVisualStyleBackColor = true;
            // 
            // btnDeepCopy
            // 
            this.btnDeepCopy.Location = new System.Drawing.Point(255, 253);
            this.btnDeepCopy.Name = "btnDeepCopy";
            this.btnDeepCopy.Size = new System.Drawing.Size(75, 23);
            this.btnDeepCopy.TabIndex = 16;
            this.btnDeepCopy.Text = "DeepCopy";
            this.btnDeepCopy.UseVisualStyleBackColor = true;
            // 
            // ListBoxAcessorios
            // 
            this.ListBoxAcessorios.FormattingEnabled = true;
            this.ListBoxAcessorios.Items.AddRange(new object[] {
            "pugio",
            "spatha",
            "pilum"});
            this.ListBoxAcessorios.Location = new System.Drawing.Point(58, 133);
            this.ListBoxAcessorios.Name = "ListBoxAcessorios";
            this.ListBoxAcessorios.Size = new System.Drawing.Size(272, 94);
            this.ListBoxAcessorios.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Acessorios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tempo";
            // 
            // lblTempoShallowCopy
            // 
            this.lblTempoShallowCopy.AutoSize = true;
            this.lblTempoShallowCopy.Location = new System.Drawing.Point(81, 315);
            this.lblTempoShallowCopy.Name = "lblTempoShallowCopy";
            this.lblTempoShallowCopy.Size = new System.Drawing.Size(68, 15);
            this.lblTempoShallowCopy.TabIndex = 20;
            this.lblTempoShallowCopy.Text = "Informacao";
            // 
            // lblDeepCopy
            // 
            this.lblDeepCopy.AutoSize = true;
            this.lblDeepCopy.Location = new System.Drawing.Point(262, 315);
            this.lblDeepCopy.Name = "lblDeepCopy";
            this.lblDeepCopy.Size = new System.Drawing.Size(68, 15);
            this.lblDeepCopy.TabIndex = 21;
            this.lblDeepCopy.Text = "Informacao";
            // 
            // Exercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeepCopy);
            this.Controls.Add(this.lblTempoShallowCopy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxAcessorios);
            this.Controls.Add(this.btnDeepCopy);
            this.Controls.Add(this.btnShallowCopy);
            this.Controls.Add(this.txtQuantidadeSoldados);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio";
            this.Text = "Exercicio Romano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantidadeSoldados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShallowCopy;
        private System.Windows.Forms.Button btnDeepCopy;
        private System.Windows.Forms.CheckedListBox ListBoxAcessorios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTempoShallowCopy;
        private System.Windows.Forms.Label lblDeepCopy;
    }
}

