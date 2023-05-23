namespace UcakBiletiRezervasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.AutoSize = true;
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(78, 56);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(88, 21);
            this.kullaniciAdiLabel.TabIndex = 0;
            this.kullaniciAdiLabel.Text = "Kullanıcı Adı";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(78, 105);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(39, 21);
            this.sifreLabel.TabIndex = 1;
            this.sifreLabel.Text = "Şifre";
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.Location = new System.Drawing.Point(221, 56);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(222, 20);
            this.kullaniciAdiText.TabIndex = 2;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(221, 105);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '•';
            this.sifreText.Size = new System.Drawing.Size(222, 20);
            this.sifreText.TabIndex = 3;
            // 
            // girisYapButton
            // 
            this.girisYapButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapButton.Location = new System.Drawing.Point(221, 163);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(104, 28);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 243);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciAdiText);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kullaniciAdiLabel);
            this.Name = "Form1";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button girisYapButton;
    }
}

