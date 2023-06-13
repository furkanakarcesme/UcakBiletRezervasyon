namespace UcakBiletiRezervasyon
{
    partial class kullaniciRez_Listele
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
            this.kullaniciRezListeleIkiLabel = new System.Windows.Forms.Label();
            this.rezListeleIkiDataGridView = new System.Windows.Forms.DataGridView();
            this.rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet23 = new UcakBiletiRezervasyon.SONDataSet23();
            this.rezervasyonTableAdapter = new UcakBiletiRezervasyon.SONDataSet23TableAdapters.rezervasyonTableAdapter();
            this.rezListeleToRezIslemleriButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezListeleIkiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciRezListeleIkiLabel
            // 
            this.kullaniciRezListeleIkiLabel.AutoSize = true;
            this.kullaniciRezListeleIkiLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.kullaniciRezListeleIkiLabel.Location = new System.Drawing.Point(326, 38);
            this.kullaniciRezListeleIkiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciRezListeleIkiLabel.Name = "kullaniciRezListeleIkiLabel";
            this.kullaniciRezListeleIkiLabel.Size = new System.Drawing.Size(233, 34);
            this.kullaniciRezListeleIkiLabel.TabIndex = 3;
            this.kullaniciRezListeleIkiLabel.Text = "REZERVASYONLARIM";
            // 
            // rezListeleIkiDataGridView
            // 
            this.rezListeleIkiDataGridView.AutoGenerateColumns = false;
            this.rezListeleIkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezListeleIkiDataGridView.DataSource = this.rezervasyonBindingSource;
            this.rezListeleIkiDataGridView.Location = new System.Drawing.Point(16, 95);
            this.rezListeleIkiDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.rezListeleIkiDataGridView.Name = "rezListeleIkiDataGridView";
            this.rezListeleIkiDataGridView.RowHeadersWidth = 51;
            this.rezListeleIkiDataGridView.Size = new System.Drawing.Size(842, 277);
            this.rezListeleIkiDataGridView.TabIndex = 4;
            // 
            // rezervasyonBindingSource
            // 
            this.rezervasyonBindingSource.DataMember = "rezervasyon";
            this.rezervasyonBindingSource.DataSource = this.sONDataSet23;
            // 
            // sONDataSet23
            // 
            this.sONDataSet23.DataSetName = "SONDataSet23";
            this.sONDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyonTableAdapter
            // 
            this.rezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // rezListeleToRezIslemleriButton
            // 
            this.rezListeleToRezIslemleriButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezListeleToRezIslemleriButton.Location = new System.Drawing.Point(16, 6);
            this.rezListeleToRezIslemleriButton.Margin = new System.Windows.Forms.Padding(4);
            this.rezListeleToRezIslemleriButton.Name = "rezListeleToRezIslemleriButton";
            this.rezListeleToRezIslemleriButton.Size = new System.Drawing.Size(52, 34);
            this.rezListeleToRezIslemleriButton.TabIndex = 13;
            this.rezListeleToRezIslemleriButton.Text = "G";
            this.rezListeleToRezIslemleriButton.UseVisualStyleBackColor = true;
            this.rezListeleToRezIslemleriButton.Click += new System.EventHandler(this.rezListeleToRezIslemleriButton_Click);
            // 
            // kullaniciRez_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 398);
            this.Controls.Add(this.rezListeleToRezIslemleriButton);
            this.Controls.Add(this.rezListeleIkiDataGridView);
            this.Controls.Add(this.kullaniciRezListeleIkiLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kullaniciRez_Listele";
            this.Text = "kullaniciRez_Listele";
            this.Load += new System.EventHandler(this.kullaniciRez_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezListeleIkiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciRezListeleIkiLabel;
        private System.Windows.Forms.DataGridView rezListeleIkiDataGridView;
        private SONDataSet23 sONDataSet23;
        private System.Windows.Forms.BindingSource rezervasyonBindingSource;
        private SONDataSet23TableAdapters.rezervasyonTableAdapter rezervasyonTableAdapter;
        private System.Windows.Forms.Button rezListeleToRezIslemleriButton;
    }
}