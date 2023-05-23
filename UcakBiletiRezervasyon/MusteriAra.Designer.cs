namespace UcakBiletiRezervasyon
{
    partial class MusteriAra
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
            this.uyeAdiAramaText = new System.Windows.Forms.TextBox();
            this.musteriAdLabel = new System.Windows.Forms.Label();
            this.uyeAraDaGrView = new System.Windows.Forms.DataGridView();
            this.aramaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyeAraDaGrView)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeAdiAramaText
            // 
            this.uyeAdiAramaText.Location = new System.Drawing.Point(116, 18);
            this.uyeAdiAramaText.Name = "uyeAdiAramaText";
            this.uyeAdiAramaText.Size = new System.Drawing.Size(477, 20);
            this.uyeAdiAramaText.TabIndex = 0;
            // 
            // musteriAdLabel
            // 
            this.musteriAdLabel.AutoSize = true;
            this.musteriAdLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriAdLabel.Location = new System.Drawing.Point(12, 16);
            this.musteriAdLabel.Name = "musteriAdLabel";
            this.musteriAdLabel.Size = new System.Drawing.Size(55, 21);
            this.musteriAdLabel.TabIndex = 1;
            this.musteriAdLabel.Text = "Üye Adı";
            // 
            // uyeAraDaGrView
            // 
            this.uyeAraDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeAraDaGrView.Location = new System.Drawing.Point(16, 60);
            this.uyeAraDaGrView.Name = "uyeAraDaGrView";
            this.uyeAraDaGrView.Size = new System.Drawing.Size(757, 316);
            this.uyeAraDaGrView.TabIndex = 2;
            // 
            // aramaButton
            // 
            this.aramaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaButton.Location = new System.Drawing.Point(648, 11);
            this.aramaButton.Name = "aramaButton";
            this.aramaButton.Size = new System.Drawing.Size(125, 33);
            this.aramaButton.TabIndex = 3;
            this.aramaButton.Text = "Ara";
            this.aramaButton.UseVisualStyleBackColor = true;
            // 
            // MusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.aramaButton);
            this.Controls.Add(this.uyeAraDaGrView);
            this.Controls.Add(this.musteriAdLabel);
            this.Controls.Add(this.uyeAdiAramaText);
            this.Name = "MusteriAra";
            this.Text = "Üye Bilgisi Arama";
            ((System.ComponentModel.ISupportInitialize)(this.uyeAraDaGrView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uyeAdiAramaText;
        private System.Windows.Forms.Label musteriAdLabel;
        private System.Windows.Forms.DataGridView uyeAraDaGrView;
        private System.Windows.Forms.Button aramaButton;
    }
}