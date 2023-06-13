namespace UcakBiletiRezervasyon
{
    partial class RezIslemleri
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
            this.rezGoruntuleButton = new System.Windows.Forms.Button();
            this.rezSilButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rezGoruntuleButton
            // 
            this.rezGoruntuleButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezGoruntuleButton.Location = new System.Drawing.Point(50, 129);
            this.rezGoruntuleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezGoruntuleButton.Name = "rezGoruntuleButton";
            this.rezGoruntuleButton.Size = new System.Drawing.Size(192, 47);
            this.rezGoruntuleButton.TabIndex = 0;
            this.rezGoruntuleButton.Text = "Rezervasyonlar";
            this.rezGoruntuleButton.UseVisualStyleBackColor = true;
            this.rezGoruntuleButton.Click += new System.EventHandler(this.rezGoruntuleButton_Click);
            // 
            // rezSilButton
            // 
            this.rezSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezSilButton.Location = new System.Drawing.Point(282, 129);
            this.rezSilButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezSilButton.Name = "rezSilButton";
            this.rezSilButton.Size = new System.Drawing.Size(192, 47);
            this.rezSilButton.TabIndex = 1;
            this.rezSilButton.Text = "Sil";
            this.rezSilButton.UseVisualStyleBackColor = true;
            this.rezSilButton.Click += new System.EventHandler(this.rezSilButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.label1.Location = new System.Drawing.Point(184, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "İŞLEM SEÇİNİZ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RezIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezSilButton);
            this.Controls.Add(this.rezGoruntuleButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RezIslemleri";
            this.Text = "RezIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rezGoruntuleButton;
        private System.Windows.Forms.Button rezSilButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}