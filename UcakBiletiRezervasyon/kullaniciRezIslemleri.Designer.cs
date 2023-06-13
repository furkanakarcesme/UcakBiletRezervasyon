namespace UcakBiletiRezervasyon
{
    partial class kullaniciRezIslemleri
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
            this.kullaniciRezSilButton = new System.Windows.Forms.Button();
            this.kullaniciRezGoruntuleButton = new System.Windows.Forms.Button();
            this.rezIslemleriToAraSayfa = new System.Windows.Forms.Button();
            this.islemSecKullaniciRezIslemleri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullaniciRezSilButton
            // 
            this.kullaniciRezSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kullaniciRezSilButton.Location = new System.Drawing.Point(203, 96);
            this.kullaniciRezSilButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciRezSilButton.Name = "kullaniciRezSilButton";
            this.kullaniciRezSilButton.Size = new System.Drawing.Size(141, 47);
            this.kullaniciRezSilButton.TabIndex = 3;
            this.kullaniciRezSilButton.Text = "Sil";
            this.kullaniciRezSilButton.UseVisualStyleBackColor = true;
            this.kullaniciRezSilButton.Click += new System.EventHandler(this.kullaniciRezSilButton_Click);
            // 
            // kullaniciRezGoruntuleButton
            // 
            this.kullaniciRezGoruntuleButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kullaniciRezGoruntuleButton.Location = new System.Drawing.Point(34, 96);
            this.kullaniciRezGoruntuleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciRezGoruntuleButton.Name = "kullaniciRezGoruntuleButton";
            this.kullaniciRezGoruntuleButton.Size = new System.Drawing.Size(140, 47);
            this.kullaniciRezGoruntuleButton.TabIndex = 2;
            this.kullaniciRezGoruntuleButton.Text = "Rezervasyonlar";
            this.kullaniciRezGoruntuleButton.UseVisualStyleBackColor = true;
            this.kullaniciRezGoruntuleButton.Click += new System.EventHandler(this.kullaniciRezGoruntuleButton_Click);
            // 
            // rezIslemleriToAraSayfa
            // 
            this.rezIslemleriToAraSayfa.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezIslemleriToAraSayfa.Location = new System.Drawing.Point(13, 13);
            this.rezIslemleriToAraSayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rezIslemleriToAraSayfa.Name = "rezIslemleriToAraSayfa";
            this.rezIslemleriToAraSayfa.Size = new System.Drawing.Size(52, 34);
            this.rezIslemleriToAraSayfa.TabIndex = 12;
            this.rezIslemleriToAraSayfa.Text = "G";
            this.rezIslemleriToAraSayfa.UseVisualStyleBackColor = true;
            this.rezIslemleriToAraSayfa.Click += new System.EventHandler(this.rezIslemleriToAraSayfa_Click);
            // 
            // islemSecKullaniciRezIslemleri
            // 
            this.islemSecKullaniciRezIslemleri.AutoSize = true;
            this.islemSecKullaniciRezIslemleri.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F);
            this.islemSecKullaniciRezIslemleri.Location = new System.Drawing.Point(110, 34);
            this.islemSecKullaniciRezIslemleri.Name = "islemSecKullaniciRezIslemleri";
            this.islemSecKullaniciRezIslemleri.Size = new System.Drawing.Size(164, 30);
            this.islemSecKullaniciRezIslemleri.TabIndex = 13;
            this.islemSecKullaniciRezIslemleri.Text = "Bir İşlem Seçiniz";
            // 
            // kullaniciRezIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 196);
            this.Controls.Add(this.islemSecKullaniciRezIslemleri);
            this.Controls.Add(this.rezIslemleriToAraSayfa);
            this.Controls.Add(this.kullaniciRezSilButton);
            this.Controls.Add(this.kullaniciRezGoruntuleButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kullaniciRezIslemleri";
            this.Text = "kullaniciRezIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kullaniciRezSilButton;
        private System.Windows.Forms.Button kullaniciRezGoruntuleButton;
        private System.Windows.Forms.Button rezIslemleriToAraSayfa;
        private System.Windows.Forms.Label islemSecKullaniciRezIslemleri;
    }
}