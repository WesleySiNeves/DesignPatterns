
namespace FabricaPizzaUI
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
            this.cmbLocalidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBoxSaboresPizza = new System.Windows.Forms.CheckedListBox();
            this.BtnFazerPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLocalidade
            // 
            this.cmbLocalidade.FormattingEnabled = true;
            this.cmbLocalidade.Items.AddRange(new object[] {
            "SP",
            "RJ"});
            this.cmbLocalidade.Location = new System.Drawing.Point(100, 72);
            this.cmbLocalidade.Name = "cmbLocalidade";
            this.cmbLocalidade.Size = new System.Drawing.Size(121, 23);
            this.cmbLocalidade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Regiao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pizzaria ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pizza";
            // 
            // ListBoxSaboresPizza
            // 
            this.ListBoxSaboresPizza.FormattingEnabled = true;
            this.ListBoxSaboresPizza.Items.AddRange(new object[] {
            "Mussarela",
            "Calabresa",
            "Margarita"});
            this.ListBoxSaboresPizza.Location = new System.Drawing.Point(100, 166);
            this.ListBoxSaboresPizza.Name = "ListBoxSaboresPizza";
            this.ListBoxSaboresPizza.Size = new System.Drawing.Size(121, 76);
            this.ListBoxSaboresPizza.TabIndex = 5;
            // 
            // BtnFazerPedido
            // 
            this.BtnFazerPedido.Location = new System.Drawing.Point(100, 300);
            this.BtnFazerPedido.Name = "BtnFazerPedido";
            this.BtnFazerPedido.Size = new System.Drawing.Size(121, 23);
            this.BtnFazerPedido.TabIndex = 6;
            this.BtnFazerPedido.Text = "Fazer Pedido";
            this.BtnFazerPedido.UseVisualStyleBackColor = true;
            this.BtnFazerPedido.Click += new System.EventHandler(this.BtnFazerPedido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 572);
            this.Controls.Add(this.BtnFazerPedido);
            this.Controls.Add(this.ListBoxSaboresPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLocalidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbLocalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ListBoxSaboresPizza;
        private System.Windows.Forms.Button BtnFazerPedido;
    }
}

