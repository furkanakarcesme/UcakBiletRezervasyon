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
            this.mailAdresLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.mailAdresText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sifremiUnuttumLabel = new System.Windows.Forms.Label();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.form1ToKullaniciSecButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mailAdresLabel
            // 
            this.mailAdresLabel.AutoSize = true;
            this.mailAdresLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailAdresLabel.Location = new System.Drawing.Point(35, 59);
            this.mailAdresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailAdresLabel.Name = "mailAdresLabel";
            this.mailAdresLabel.Size = new System.Drawing.Size(112, 25);
            this.mailAdresLabel.TabIndex = 0;
            this.mailAdresLabel.Text = "MAİL ADRESİ";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(35, 121);
            this.sifreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(57, 25);
            this.sifreLabel.TabIndex = 1;
            this.sifreLabel.Text = "ŞİFRE";
            this.sifreLabel.Click += new System.EventHandler(this.sifreLabel_Click);
            // 
            // mailAdresText
            // 
            this.mailAdresText.Location = new System.Drawing.Point(225, 59);
            this.mailAdresText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailAdresText.Name = "mailAdresText";
            this.mailAdresText.Size = new System.Drawing.Size(295, 22);
            this.mailAdresText.TabIndex = 2;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(225, 119);
            this.sifreText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '•';
            this.sifreText.Size = new System.Drawing.Size(295, 22);
            this.sifreText.TabIndex = 3;
            // 
            // girisYapButton
            // 
            this.girisYapButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapButton.Location = new System.Drawing.Point(225, 202);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(139, 34);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(383, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Üye Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifremiUnuttumLabel
            // 
            this.sifremiUnuttumLabel.AutoSize = true;
            this.sifremiUnuttumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremiUnuttumLabel.Location = new System.Drawing.Point(412, 148);
            this.sifremiUnuttumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifremiUnuttumLabel.Name = "sifremiUnuttumLabel";
            this.sifremiUnuttumLabel.Size = new System.Drawing.Size(108, 17);
            this.sifremiUnuttumLabel.TabIndex = 6;
            this.sifremiUnuttumLabel.Text = "Şifremi Unuttum";
            this.sifremiUnuttumLabel.Click += new System.EventHandler(this.sifremiUnuttumLabel_Click);
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(225, 146);
            this.checkBoxSifreGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(113, 20);
            this.checkBoxSifreGoster.TabIndex = 8;
            this.checkBoxSifreGoster.Text = "Şifremi Göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // form1ToKullaniciSecButton
            // 
            this.form1ToKullaniciSecButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.form1ToKullaniciSecButton.Location = new System.Drawing.Point(16, 9);
            this.form1ToKullaniciSecButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form1ToKullaniciSecButton.Name = "form1ToKullaniciSecButton";
            this.form1ToKullaniciSecButton.Size = new System.Drawing.Size(52, 34);
            this.form1ToKullaniciSecButton.TabIndex = 12;
            this.form1ToKullaniciSecButton.Text = "G";
            this.form1ToKullaniciSecButton.UseVisualStyleBackColor = true;
            this.form1ToKullaniciSecButton.Click += new System.EventHandler(this.form1ToKullaniciSecButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 260);
            this.Controls.Add(this.form1ToKullaniciSecButton);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.sifremiUnuttumLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.mailAdresText);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.mailAdresLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mailAdresLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.TextBox mailAdresText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sifremiUnuttumLabel;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.Button form1ToKullaniciSecButton;
    }
}

