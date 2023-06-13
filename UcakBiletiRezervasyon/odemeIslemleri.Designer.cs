namespace UcakBiletiRezervasyon
{
    partial class odemeIslemleri
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
            this.kartListeleyeYonlendirButton = new System.Windows.Forms.Button();
            this.kartEkleyeYonlendirButton = new System.Windows.Forms.Button();
            this.kartSileYonlendirButton = new System.Windows.Forms.Button();
            this.odemeToAraSayfaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kartListeleyeYonlendirButton
            // 
            this.kartListeleyeYonlendirButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kartListeleyeYonlendirButton.Location = new System.Drawing.Point(21, 70);
            this.kartListeleyeYonlendirButton.Name = "kartListeleyeYonlendirButton";
            this.kartListeleyeYonlendirButton.Size = new System.Drawing.Size(75, 37);
            this.kartListeleyeYonlendirButton.TabIndex = 0;
            this.kartListeleyeYonlendirButton.Text = "Kartlarım";
            this.kartListeleyeYonlendirButton.UseVisualStyleBackColor = true;
            this.kartListeleyeYonlendirButton.Click += new System.EventHandler(this.kartListeleyeYonlendirButton_Click);
            // 
            // kartEkleyeYonlendirButton
            // 
            this.kartEkleyeYonlendirButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kartEkleyeYonlendirButton.Location = new System.Drawing.Point(157, 70);
            this.kartEkleyeYonlendirButton.Name = "kartEkleyeYonlendirButton";
            this.kartEkleyeYonlendirButton.Size = new System.Drawing.Size(75, 37);
            this.kartEkleyeYonlendirButton.TabIndex = 1;
            this.kartEkleyeYonlendirButton.Text = "Kart Ekle";
            this.kartEkleyeYonlendirButton.UseVisualStyleBackColor = true;
            this.kartEkleyeYonlendirButton.Click += new System.EventHandler(this.kartEkleyeYonlendirButton_Click);
            // 
            // kartSileYonlendirButton
            // 
            this.kartSileYonlendirButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kartSileYonlendirButton.Location = new System.Drawing.Point(291, 70);
            this.kartSileYonlendirButton.Name = "kartSileYonlendirButton";
            this.kartSileYonlendirButton.Size = new System.Drawing.Size(75, 37);
            this.kartSileYonlendirButton.TabIndex = 2;
            this.kartSileYonlendirButton.Text = "Kart Sil";
            this.kartSileYonlendirButton.UseVisualStyleBackColor = true;
            this.kartSileYonlendirButton.Click += new System.EventHandler(this.kartSileYonlendirButton_Click);
            // 
            // odemeToAraSayfaButton
            // 
            this.odemeToAraSayfaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.odemeToAraSayfaButton.Location = new System.Drawing.Point(21, 20);
            this.odemeToAraSayfaButton.Name = "odemeToAraSayfaButton";
            this.odemeToAraSayfaButton.Size = new System.Drawing.Size(35, 27);
            this.odemeToAraSayfaButton.TabIndex = 6;
            this.odemeToAraSayfaButton.Text = "G";
            this.odemeToAraSayfaButton.UseVisualStyleBackColor = true;
            this.odemeToAraSayfaButton.Click += new System.EventHandler(this.odemeToAraSayfaButton_Click);
            // 
            // odemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 142);
            this.Controls.Add(this.odemeToAraSayfaButton);
            this.Controls.Add(this.kartSileYonlendirButton);
            this.Controls.Add(this.kartEkleyeYonlendirButton);
            this.Controls.Add(this.kartListeleyeYonlendirButton);
            this.Name = "odemeIslemleri";
            this.Text = "Kullanıcı - Ödeme İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kartListeleyeYonlendirButton;
        private System.Windows.Forms.Button kartEkleyeYonlendirButton;
        private System.Windows.Forms.Button kartSileYonlendirButton;
        private System.Windows.Forms.Button odemeToAraSayfaButton;
    }
}