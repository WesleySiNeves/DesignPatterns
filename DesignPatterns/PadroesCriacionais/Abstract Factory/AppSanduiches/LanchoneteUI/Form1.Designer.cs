
namespace LanchoneteUI
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
            this.cmbTipoCardapio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.checkedListItensCardapio = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cmbTipoCardapio
            // 
            this.cmbTipoCardapio.FormattingEnabled = true;
            this.cmbTipoCardapio.Items.AddRange(new object[] {
            "Adulto",
            "Infantil"});
            this.cmbTipoCardapio.Location = new System.Drawing.Point(92, 30);
            this.cmbTipoCardapio.Name = "cmbTipoCardapio";
            this.cmbTipoCardapio.Size = new System.Drawing.Size(153, 23);
            this.cmbTipoCardapio.TabIndex = 2;
            this.cmbTipoCardapio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCardapio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cardapio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Itens:";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Location = new System.Drawing.Point(92, 217);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(100, 23);
            this.btnFazerPedido.TabIndex = 6;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            // 
            // checkedListItensCardapio
            // 
            this.checkedListItensCardapio.FormattingEnabled = true;
            this.checkedListItensCardapio.Location = new System.Drawing.Point(72, 89);
            this.checkedListItensCardapio.Name = "checkedListItensCardapio";
            this.checkedListItensCardapio.Size = new System.Drawing.Size(173, 94);
            this.checkedListItensCardapio.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListItensCardapio);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoCardapio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoCardapio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.CheckedListBox checkedListItensCardapio;
    }
}

