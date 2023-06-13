namespace UcakBiletiRezervasyon
{
    partial class araSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(araSayfa));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cikisYappButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(17, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Uçuş İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button2.Location = new System.Drawing.Point(255, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Üye İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button3.Location = new System.Drawing.Point(492, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rezervasyon İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cikisYappButton
            // 
            this.cikisYappButton.FlatAppearance.BorderSize = 0;
            this.cikisYappButton.ImageKey = "cikis_yap.jpg";
            this.cikisYappButton.ImageList = this.ımageList1;
            this.cikisYappButton.Location = new System.Drawing.Point(643, 12);
            this.cikisYappButton.Name = "cikisYappButton";
            this.cikisYappButton.Size = new System.Drawing.Size(60, 50);
            this.cikisYappButton.TabIndex = 3;
            this.cikisYappButton.UseVisualStyleBackColor = true;
            this.cikisYappButton.Click += new System.EventHandler(this.cikisYappButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14F);
            this.label1.Location = new System.Drawing.Point(215, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cikis_yap.jpg");
            // 
            // araSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikisYappButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "araSayfa";
            this.Text = "araSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cikisYappButton;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
    }
}