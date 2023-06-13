namespace UcakBiletiRezervasyon
{
    partial class kullaniciUyeIslemleri
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
            this.kullaniciBilgileriGuncelleButton = new System.Windows.Forms.Button();
            this.kullaniciUyeligiSilButton = new System.Windows.Forms.Button();
            this.uyeIslemleriToAraMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciBilgileriGuncelleButton
            // 
            this.kullaniciBilgileriGuncelleButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kullaniciBilgileriGuncelleButton.Location = new System.Drawing.Point(16, 94);
            this.kullaniciBilgileriGuncelleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciBilgileriGuncelleButton.Name = "kullaniciBilgileriGuncelleButton";
            this.kullaniciBilgileriGuncelleButton.Size = new System.Drawing.Size(152, 63);
            this.kullaniciBilgileriGuncelleButton.TabIndex = 0;
            this.kullaniciBilgileriGuncelleButton.Text = "Bilgileri Güncelle";
            this.kullaniciBilgileriGuncelleButton.UseVisualStyleBackColor = true;
            this.kullaniciBilgileriGuncelleButton.Click += new System.EventHandler(this.kullaniciBilgileriGuncelleButton_Click);
            // 
            // kullaniciUyeligiSilButton
            // 
            this.kullaniciUyeligiSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kullaniciUyeligiSilButton.Location = new System.Drawing.Point(199, 94);
            this.kullaniciUyeligiSilButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciUyeligiSilButton.Name = "kullaniciUyeligiSilButton";
            this.kullaniciUyeligiSilButton.Size = new System.Drawing.Size(145, 63);
            this.kullaniciUyeligiSilButton.TabIndex = 1;
            this.kullaniciUyeligiSilButton.Text = "Üyeliği Sil";
            this.kullaniciUyeligiSilButton.UseVisualStyleBackColor = true;
            this.kullaniciUyeligiSilButton.Click += new System.EventHandler(this.kullaniciUyeligiSilButton_Click);
            // 
            // uyeIslemleriToAraMenuButton
            // 
            this.uyeIslemleriToAraMenuButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.uyeIslemleriToAraMenuButton.Location = new System.Drawing.Point(16, 15);
            this.uyeIslemleriToAraMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeIslemleriToAraMenuButton.Name = "uyeIslemleriToAraMenuButton";
            this.uyeIslemleriToAraMenuButton.Size = new System.Drawing.Size(45, 34);
            this.uyeIslemleriToAraMenuButton.TabIndex = 2;
            this.uyeIslemleriToAraMenuButton.Text = "G";
            this.uyeIslemleriToAraMenuButton.UseVisualStyleBackColor = true;
            this.uyeIslemleriToAraMenuButton.Click += new System.EventHandler(this.uyeIslemleriToAraMenuButton_Click);
            // 
            // kullaniciUyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 201);
            this.Controls.Add(this.uyeIslemleriToAraMenuButton);
            this.Controls.Add(this.kullaniciUyeligiSilButton);
            this.Controls.Add(this.kullaniciBilgileriGuncelleButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kullaniciUyeIslemleri";
            this.Text = "kullaniciUyeIslemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullaniciBilgileriGuncelleButton;
        private System.Windows.Forms.Button kullaniciUyeligiSilButton;
        private System.Windows.Forms.Button uyeIslemleriToAraMenuButton;
    }
}