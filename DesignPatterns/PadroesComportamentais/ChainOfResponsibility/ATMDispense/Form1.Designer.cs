namespace ATMDispense
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpQuantidadeNotas50 = new System.Windows.Forms.NumericUpDown();
            this.UpQuantidadeNotas20 = new System.Windows.Forms.NumericUpDown();
            this.UpQuantidadeNotas10 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpQuantidadeNotas50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpQuantidadeNotas20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpQuantidadeNotas10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a ser Sacado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(414, 53);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(100, 23);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 206);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UpQuantidadeNotas10);
            this.tabPage1.Controls.Add(this.UpQuantidadeNotas20);
            this.tabPage1.Controls.Add(this.UpQuantidadeNotas50);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configurações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.btnSacar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade Notas de 50 r$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade Notas de 20  r$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade Notas de 10  r$";
            // 
            // UpQuantidadeNotas50
            // 
            this.UpQuantidadeNotas50.Location = new System.Drawing.Point(165, 21);
            this.UpQuantidadeNotas50.Name = "UpQuantidadeNotas50";
            this.UpQuantidadeNotas50.Size = new System.Drawing.Size(120, 20);
            this.UpQuantidadeNotas50.TabIndex = 6;
            // 
            // UpQuantidadeNotas20
            // 
            this.UpQuantidadeNotas20.Location = new System.Drawing.Point(165, 57);
            this.UpQuantidadeNotas20.Name = "UpQuantidadeNotas20";
            this.UpQuantidadeNotas20.Size = new System.Drawing.Size(120, 20);
            this.UpQuantidadeNotas20.TabIndex = 7;
            // 
            // UpQuantidadeNotas10
            // 
            this.UpQuantidadeNotas10.Location = new System.Drawing.Point(165, 95);
            this.UpQuantidadeNotas10.Name = "UpQuantidadeNotas10";
            this.UpQuantidadeNotas10.Size = new System.Drawing.Size(120, 20);
            this.UpQuantidadeNotas10.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpQuantidadeNotas50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpQuantidadeNotas20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpQuantidadeNotas10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown UpQuantidadeNotas10;
        private System.Windows.Forms.NumericUpDown UpQuantidadeNotas20;
        private System.Windows.Forms.NumericUpDown UpQuantidadeNotas50;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

