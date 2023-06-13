namespace UcakBiletiRezervasyon
{
    partial class UyeIslemleri
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
            this.uyeListesineGit = new System.Windows.Forms.Button();
            this.uyeEkleyeGit = new System.Windows.Forms.Button();
            this.uyeDuzenleyeGit = new System.Windows.Forms.Button();
            this.uyeSileGit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uyeListesineGit
            // 
            this.uyeListesineGit.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.uyeListesineGit.Location = new System.Drawing.Point(59, 116);
            this.uyeListesineGit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeListesineGit.Name = "uyeListesineGit";
            this.uyeListesineGit.Size = new System.Drawing.Size(138, 50);
            this.uyeListesineGit.TabIndex = 0;
            this.uyeListesineGit.Text = "Üye Listesi";
            this.uyeListesineGit.UseVisualStyleBackColor = true;
            this.uyeListesineGit.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyeEkleyeGit
            // 
            this.uyeEkleyeGit.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.uyeEkleyeGit.Location = new System.Drawing.Point(227, 191);
            this.uyeEkleyeGit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeEkleyeGit.Name = "uyeEkleyeGit";
            this.uyeEkleyeGit.Size = new System.Drawing.Size(138, 50);
            this.uyeEkleyeGit.TabIndex = 1;
            this.uyeEkleyeGit.Text = "Üye Ekle";
            this.uyeEkleyeGit.UseVisualStyleBackColor = true;
            this.uyeEkleyeGit.Click += new System.EventHandler(this.uyeEkleyeGit_Click);
            // 
            // uyeDuzenleyeGit
            // 
            this.uyeDuzenleyeGit.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.uyeDuzenleyeGit.Location = new System.Drawing.Point(227, 116);
            this.uyeDuzenleyeGit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeDuzenleyeGit.Name = "uyeDuzenleyeGit";
            this.uyeDuzenleyeGit.Size = new System.Drawing.Size(138, 50);
            this.uyeDuzenleyeGit.TabIndex = 2;
            this.uyeDuzenleyeGit.Text = "Üye Düzenle";
            this.uyeDuzenleyeGit.UseVisualStyleBackColor = true;
            this.uyeDuzenleyeGit.Click += new System.EventHandler(this.uyeDuzenleyeGit_Click);
            // 
            // uyeSileGit
            // 
            this.uyeSileGit.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.uyeSileGit.Location = new System.Drawing.Point(59, 191);
            this.uyeSileGit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeSileGit.Name = "uyeSileGit";
            this.uyeSileGit.Size = new System.Drawing.Size(138, 50);
            this.uyeSileGit.TabIndex = 3;
            this.uyeSileGit.Text = "Üye Sil";
            this.uyeSileGit.UseVisualStyleBackColor = true;
            this.uyeSileGit.Click += new System.EventHandler(this.uyeSileGit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.label1.Location = new System.Drawing.Point(136, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "İŞLEM SEÇİNİZ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uyeSileGit);
            this.Controls.Add(this.uyeDuzenleyeGit);
            this.Controls.Add(this.uyeEkleyeGit);
            this.Controls.Add(this.uyeListesineGit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UyeIslemleri";
            this.Text = "Admin Üye İşlemleri";
            this.Load += new System.EventHandler(this.UyeIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uyeListesineGit;
        private System.Windows.Forms.Button uyeEkleyeGit;
        private System.Windows.Forms.Button uyeDuzenleyeGit;
        private System.Windows.Forms.Button uyeSileGit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}