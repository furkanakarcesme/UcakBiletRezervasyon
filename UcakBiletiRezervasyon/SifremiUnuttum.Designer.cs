namespace UcakBiletiRezervasyon
{
    partial class SifremiUnuttum
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
            this.ePostaLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.onaylaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ePostaLabel
            // 
            this.ePostaLabel.AutoSize = true;
            this.ePostaLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ePostaLabel.Location = new System.Drawing.Point(39, 41);
            this.ePostaLabel.Name = "ePostaLabel";
            this.ePostaLabel.Size = new System.Drawing.Size(80, 21);
            this.ePostaLabel.TabIndex = 0;
            this.ePostaLabel.Text = "Mail Adresi";
            this.ePostaLabel.Click += new System.EventHandler(this.ePostaLabel_Click);
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTextBox.Location = new System.Drawing.Point(160, 41);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(268, 20);
            this.mailTextBox.TabIndex = 1;
            // 
            // onaylaButton
            // 
            this.onaylaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaButton.Location = new System.Drawing.Point(245, 81);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(83, 30);
            this.onaylaButton.TabIndex = 2;
            this.onaylaButton.Text = "Onayla";
            this.onaylaButton.UseVisualStyleBackColor = true;
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 142);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.ePostaLabel);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ePostaLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Button onaylaButton;
    }
}