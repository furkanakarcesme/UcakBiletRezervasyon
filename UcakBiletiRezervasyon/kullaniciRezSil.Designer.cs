namespace UcakBiletiRezervasyon
{
    partial class kullaniciRezSil
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
            this.kullaniciRezSilDaGrView = new System.Windows.Forms.DataGridView();
            this.rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet20 = new UcakBiletiRezervasyon.SONDataSet20();
            this.kullaniciRezSilButton = new System.Windows.Forms.Button();
            this.kullaniciRezSilLabel = new System.Windows.Forms.Label();
            this.rezervasyonTableAdapter = new UcakBiletiRezervasyon.SONDataSet20TableAdapters.rezervasyonTableAdapter();
            this.rezSilToRezIslemleri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciRezSilDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciRezSilDaGrView
            // 
            this.kullaniciRezSilDaGrView.AutoGenerateColumns = false;
            this.kullaniciRezSilDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciRezSilDaGrView.DataSource = this.rezervasyonBindingSource;
            this.kullaniciRezSilDaGrView.Location = new System.Drawing.Point(21, 112);
            this.kullaniciRezSilDaGrView.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciRezSilDaGrView.Name = "kullaniciRezSilDaGrView";
            this.kullaniciRezSilDaGrView.RowHeadersWidth = 51;
            this.kullaniciRezSilDaGrView.Size = new System.Drawing.Size(800, 357);
            this.kullaniciRezSilDaGrView.TabIndex = 0;
            // 
            // rezervasyonBindingSource
            // 
            this.rezervasyonBindingSource.DataMember = "rezervasyon";
            this.rezervasyonBindingSource.DataSource = this.sONDataSet20;
            // 
            // sONDataSet20
            // 
            this.sONDataSet20.DataSetName = "SONDataSet20";
            this.sONDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciRezSilButton
            // 
            this.kullaniciRezSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.kullaniciRezSilButton.Location = new System.Drawing.Point(367, 485);
            this.kullaniciRezSilButton.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciRezSilButton.Name = "kullaniciRezSilButton";
            this.kullaniciRezSilButton.Size = new System.Drawing.Size(107, 37);
            this.kullaniciRezSilButton.TabIndex = 1;
            this.kullaniciRezSilButton.Text = "İPTAL ET";
            this.kullaniciRezSilButton.UseVisualStyleBackColor = true;
            this.kullaniciRezSilButton.Click += new System.EventHandler(this.kullaniciRezSilButton_Click);
            // 
            // kullaniciRezSilLabel
            // 
            this.kullaniciRezSilLabel.AutoSize = true;
            this.kullaniciRezSilLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.kullaniciRezSilLabel.Location = new System.Drawing.Point(306, 58);
            this.kullaniciRezSilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciRezSilLabel.Name = "kullaniciRezSilLabel";
            this.kullaniciRezSilLabel.Size = new System.Drawing.Size(235, 34);
            this.kullaniciRezSilLabel.TabIndex = 2;
            this.kullaniciRezSilLabel.Text = "REZERVASYON İPTALİ";
            // 
            // rezervasyonTableAdapter
            // 
            this.rezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // rezSilToRezIslemleri
            // 
            this.rezSilToRezIslemleri.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezSilToRezIslemleri.Location = new System.Drawing.Point(21, 23);
            this.rezSilToRezIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.rezSilToRezIslemleri.Name = "rezSilToRezIslemleri";
            this.rezSilToRezIslemleri.Size = new System.Drawing.Size(52, 34);
            this.rezSilToRezIslemleri.TabIndex = 13;
            this.rezSilToRezIslemleri.Text = "G";
            this.rezSilToRezIslemleri.UseVisualStyleBackColor = true;
            this.rezSilToRezIslemleri.Click += new System.EventHandler(this.rezSilToRezIslemleri_Click);
            // 
            // kullaniciRezSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 535);
            this.Controls.Add(this.rezSilToRezIslemleri);
            this.Controls.Add(this.kullaniciRezSilLabel);
            this.Controls.Add(this.kullaniciRezSilButton);
            this.Controls.Add(this.kullaniciRezSilDaGrView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kullaniciRezSil";
            this.Text = "kullaniciRezSil";
            this.Load += new System.EventHandler(this.kullaniciRezSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciRezSilDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kullaniciRezSilDaGrView;
        private System.Windows.Forms.Button kullaniciRezSilButton;
        private System.Windows.Forms.Label kullaniciRezSilLabel;
        private SONDataSet20 sONDataSet20;
        private System.Windows.Forms.BindingSource rezervasyonBindingSource;
        private SONDataSet20TableAdapters.rezervasyonTableAdapter rezervasyonTableAdapter;
        private System.Windows.Forms.Button rezSilToRezIslemleri;
    }
}