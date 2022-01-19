
namespace AplicacaoControleRemoto
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
            this.btnTvControl = new System.Windows.Forms.Button();
            this.btnradioControl = new System.Windows.Forms.Button();
            this.btnAdvancedControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTvControl
            // 
            this.btnTvControl.Location = new System.Drawing.Point(38, 109);
            this.btnTvControl.Name = "btnTvControl";
            this.btnTvControl.Size = new System.Drawing.Size(125, 23);
            this.btnTvControl.TabIndex = 0;
            this.btnTvControl.Text = "Controle TV";
            this.btnTvControl.UseVisualStyleBackColor = true;
            // 
            // btnradioControl
            // 
            this.btnradioControl.Location = new System.Drawing.Point(222, 109);
            this.btnradioControl.Name = "btnradioControl";
            this.btnradioControl.Size = new System.Drawing.Size(128, 23);
            this.btnradioControl.TabIndex = 1;
            this.btnradioControl.Text = "Controle Radio";
            this.btnradioControl.UseVisualStyleBackColor = true;
            // 
            // btnAdvancedControl
            // 
            this.btnAdvancedControl.Location = new System.Drawing.Point(398, 109);
            this.btnAdvancedControl.Name = "btnAdvancedControl";
            this.btnAdvancedControl.Size = new System.Drawing.Size(128, 23);
            this.btnAdvancedControl.TabIndex = 2;
            this.btnAdvancedControl.Text = "Advanced Control";
            this.btnAdvancedControl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdvancedControl);
            this.Controls.Add(this.btnradioControl);
            this.Controls.Add(this.btnTvControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTvControl;
        private System.Windows.Forms.Button btnradioControl;
        private System.Windows.Forms.Button btnAdvancedControl;
    }
}

