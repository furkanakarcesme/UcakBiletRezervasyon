namespace UcakBiletiRezervasyon
{
    partial class UcusIslemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcusIslemleri));
            this.ucuslarButton = new System.Windows.Forms.Button();
            this.ucusEkleButton = new System.Windows.Forms.Button();
            this.ucusBilgiGuncelleButton = new System.Windows.Forms.Button();
            this.ucusSilButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ucuslarButton
            // 
            this.ucuslarButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucuslarButton.Location = new System.Drawing.Point(58, 113);
            this.ucuslarButton.Margin = new System.Windows.Forms.Padding(4);
            this.ucuslarButton.Name = "ucuslarButton";
            this.ucuslarButton.Size = new System.Drawing.Size(107, 42);
            this.ucuslarButton.TabIndex = 0;
            this.ucuslarButton.Text = "Uçuşlar";
            this.ucuslarButton.UseVisualStyleBackColor = true;
            this.ucuslarButton.Click += new System.EventHandler(this.ucuslarButton_Click);
            // 
            // ucusEkleButton
            // 
            this.ucusEkleButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusEkleButton.Location = new System.Drawing.Point(217, 113);
            this.ucusEkleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ucusEkleButton.Name = "ucusEkleButton";
            this.ucusEkleButton.Size = new System.Drawing.Size(107, 42);
            this.ucusEkleButton.TabIndex = 1;
            this.ucusEkleButton.Text = "Ekle";
            this.ucusEkleButton.UseVisualStyleBackColor = true;
            this.ucusEkleButton.Click += new System.EventHandler(this.ucusEkleButton_Click);
            // 
            // ucusBilgiGuncelleButton
            // 
            this.ucusBilgiGuncelleButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusBilgiGuncelleButton.Location = new System.Drawing.Point(58, 196);
            this.ucusBilgiGuncelleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ucusBilgiGuncelleButton.Name = "ucusBilgiGuncelleButton";
            this.ucusBilgiGuncelleButton.Size = new System.Drawing.Size(107, 42);
            this.ucusBilgiGuncelleButton.TabIndex = 2;
            this.ucusBilgiGuncelleButton.Text = "Güncelle";
            this.ucusBilgiGuncelleButton.UseVisualStyleBackColor = true;
            this.ucusBilgiGuncelleButton.Click += new System.EventHandler(this.ucusBilgiGuncelleButton_Click);
            // 
            // ucusSilButton
            // 
            this.ucusSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusSilButton.Location = new System.Drawing.Point(217, 196);
            this.ucusSilButton.Margin = new System.Windows.Forms.Padding(4);
            this.ucusSilButton.Name = "ucusSilButton";
            this.ucusSilButton.Size = new System.Drawing.Size(107, 42);
            this.ucusSilButton.TabIndex = 3;
            this.ucusSilButton.Text = "Sil";
            this.ucusSilButton.UseVisualStyleBackColor = true;
            this.ucusSilButton.Click += new System.EventHandler(this.ucusSilButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "cikis_yap.jpg";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(285, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cikis_yap.jpg");
            // 
            // UcusIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucusSilButton);
            this.Controls.Add(this.ucusBilgiGuncelleButton);
            this.Controls.Add(this.ucusEkleButton);
            this.Controls.Add(this.ucuslarButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcusIslemleri";
            this.Text = "Uçuş İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucuslarButton;
        private System.Windows.Forms.Button ucusEkleButton;
        private System.Windows.Forms.Button ucusBilgiGuncelleButton;
        private System.Windows.Forms.Button ucusSilButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}