namespace UcakBiletiRezervasyon
{
    partial class KullaniciSec
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hosgeldinizLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(77, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kullanıcı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button3.Location = new System.Drawing.Point(227, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hosgeldinizLabel
            // 
            this.hosgeldinizLabel.AutoSize = true;
            this.hosgeldinizLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F);
            this.hosgeldinizLabel.Location = new System.Drawing.Point(36, 58);
            this.hosgeldinizLabel.Name = "hosgeldinizLabel";
            this.hosgeldinizLabel.Size = new System.Drawing.Size(369, 32);
            this.hosgeldinizLabel.TabIndex = 3;
            this.hosgeldinizLabel.Text = "Giriş Yapmak İstediğiniz Paneli Seçin";
            // 
            // KullaniciSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.hosgeldinizLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "KullaniciSec";
            this.Text = "KullaniciSec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label hosgeldinizLabel;
    }
}