namespace UcakBiletiRezervasyon
{
    partial class kullaniciCheckIn
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
            this.kullaniciCheckInRezListesiDGV = new System.Windows.Forms.DataGridView();
            this.rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet24 = new UcakBiletiRezervasyon.SONDataSet24();
            this.checkInSonrakiAdimaGecButton = new System.Windows.Forms.Button();
            this.kullaniciCheckInRezListesiLabel = new System.Windows.Forms.Label();
            this.rezervasyonTableAdapter = new UcakBiletiRezervasyon.SONDataSet24TableAdapters.rezervasyonTableAdapter();
            this.checkInToAramenuButton = new System.Windows.Forms.Button();
            this.rezervasyon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciCheckInRezListesiDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet24)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciCheckInRezListesiDGV
            // 
            this.kullaniciCheckInRezListesiDGV.AutoGenerateColumns = false;
            this.kullaniciCheckInRezListesiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciCheckInRezListesiDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervasyon_id});
            this.kullaniciCheckInRezListesiDGV.DataSource = this.rezervasyonBindingSource;
            this.kullaniciCheckInRezListesiDGV.Location = new System.Drawing.Point(23, 97);
            this.kullaniciCheckInRezListesiDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciCheckInRezListesiDGV.Name = "kullaniciCheckInRezListesiDGV";
            this.kullaniciCheckInRezListesiDGV.RowHeadersWidth = 51;
            this.kullaniciCheckInRezListesiDGV.Size = new System.Drawing.Size(935, 279);
            this.kullaniciCheckInRezListesiDGV.TabIndex = 0;
            // 
            // rezervasyonBindingSource
            // 
            this.rezervasyonBindingSource.DataMember = "rezervasyon";
            this.rezervasyonBindingSource.DataSource = this.sONDataSet24;
            // 
            // sONDataSet24
            // 
            this.sONDataSet24.DataSetName = "SONDataSet24";
            this.sONDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInSonrakiAdimaGecButton
            // 
            this.checkInSonrakiAdimaGecButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.checkInSonrakiAdimaGecButton.Location = new System.Drawing.Point(391, 410);
            this.checkInSonrakiAdimaGecButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkInSonrakiAdimaGecButton.Name = "checkInSonrakiAdimaGecButton";
            this.checkInSonrakiAdimaGecButton.Size = new System.Drawing.Size(200, 38);
            this.checkInSonrakiAdimaGecButton.TabIndex = 2;
            this.checkInSonrakiAdimaGecButton.Text = "Ödeme Yöntemi Seç";
            this.checkInSonrakiAdimaGecButton.UseVisualStyleBackColor = true;
            this.checkInSonrakiAdimaGecButton.Click += new System.EventHandler(this.checkInTamamlaButton_Click);
            // 
            // kullaniciCheckInRezListesiLabel
            // 
            this.kullaniciCheckInRezListesiLabel.AutoSize = true;
            this.kullaniciCheckInRezListesiLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.kullaniciCheckInRezListesiLabel.Location = new System.Drawing.Point(396, 27);
            this.kullaniciCheckInRezListesiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciCheckInRezListesiLabel.Name = "kullaniciCheckInRezListesiLabel";
            this.kullaniciCheckInRezListesiLabel.Size = new System.Drawing.Size(193, 34);
            this.kullaniciCheckInRezListesiLabel.TabIndex = 3;
            this.kullaniciCheckInRezListesiLabel.Text = "Rezervasyonlarım";
            // 
            // rezervasyonTableAdapter
            // 
            this.rezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // checkInToAramenuButton
            // 
            this.checkInToAramenuButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.checkInToAramenuButton.Location = new System.Drawing.Point(23, 15);
            this.checkInToAramenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkInToAramenuButton.Name = "checkInToAramenuButton";
            this.checkInToAramenuButton.Size = new System.Drawing.Size(52, 34);
            this.checkInToAramenuButton.TabIndex = 9;
            this.checkInToAramenuButton.Text = "G";
            this.checkInToAramenuButton.UseVisualStyleBackColor = true;
            this.checkInToAramenuButton.Click += new System.EventHandler(this.checkInToAramenuButton_Click);
            // 
            // rezervasyon_id
            // 
            this.rezervasyon_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rezervasyon_id.DataPropertyName = "rezervasyon_id";
            this.rezervasyon_id.HeaderText = "Rez. No";
            this.rezervasyon_id.MinimumWidth = 6;
            this.rezervasyon_id.Name = "rezervasyon_id";
            this.rezervasyon_id.Width = 84;
            // 
            // kullaniciCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 485);
            this.Controls.Add(this.checkInToAramenuButton);
            this.Controls.Add(this.kullaniciCheckInRezListesiLabel);
            this.Controls.Add(this.checkInSonrakiAdimaGecButton);
            this.Controls.Add(this.kullaniciCheckInRezListesiDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kullaniciCheckIn";
            this.Text = "Kullanıcı Check-IN";
            this.Load += new System.EventHandler(this.kullaniciCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciCheckInRezListesiDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kullaniciCheckInRezListesiDGV;
        private System.Windows.Forms.Button checkInSonrakiAdimaGecButton;
        private System.Windows.Forms.Label kullaniciCheckInRezListesiLabel;
        private SONDataSet24 sONDataSet24;
        private System.Windows.Forms.BindingSource rezervasyonBindingSource;
        private SONDataSet24TableAdapters.rezervasyonTableAdapter rezervasyonTableAdapter;
        private System.Windows.Forms.Button checkInToAramenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyon_id;
    }
}