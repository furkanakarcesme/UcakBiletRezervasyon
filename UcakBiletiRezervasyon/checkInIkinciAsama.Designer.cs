namespace UcakBiletiRezervasyon
{
    partial class checkInIkinciAsama
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
            this.kullaniciCheckInKartListesiLabel = new System.Windows.Forms.Label();
            this.kullaniciCheckInKartListesiDGV = new System.Windows.Forms.DataGridView();
            this.kart_numarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uc_hane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet25 = new UcakBiletiRezervasyon.SONDataSet25();
            this.checkInTamamlaButton = new System.Windows.Forms.Button();
            this.kartlarTableAdapter = new UcakBiletiRezervasyon.SONDataSet25TableAdapters.kartlarTableAdapter();
            this.kartSecToCheckInButton = new System.Windows.Forms.Button();
            this.kartidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartnumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciCheckInKartListesiDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet25)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciCheckInKartListesiLabel
            // 
            this.kullaniciCheckInKartListesiLabel.AutoSize = true;
            this.kullaniciCheckInKartListesiLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.kullaniciCheckInKartListesiLabel.Location = new System.Drawing.Point(280, 17);
            this.kullaniciCheckInKartListesiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciCheckInKartListesiLabel.Name = "kullaniciCheckInKartListesiLabel";
            this.kullaniciCheckInKartListesiLabel.Size = new System.Drawing.Size(101, 34);
            this.kullaniciCheckInKartListesiLabel.TabIndex = 6;
            this.kullaniciCheckInKartListesiLabel.Text = "Kart Seç";
            // 
            // kullaniciCheckInKartListesiDGV
            // 
            this.kullaniciCheckInKartListesiDGV.AutoGenerateColumns = false;
            this.kullaniciCheckInKartListesiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciCheckInKartListesiDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kart_numarasi,
            this.ay,
            this.yil,
            this.uc_hane,
            this.kart_id,
            this.kartidDataGridViewTextBoxColumn,
            this.kartnumarasiDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.uchaneDataGridViewTextBoxColumn,
            this.kullaniciidDataGridViewTextBoxColumn});
            this.kullaniciCheckInKartListesiDGV.DataSource = this.kartlarBindingSource;
            this.kullaniciCheckInKartListesiDGV.Location = new System.Drawing.Point(35, 69);
            this.kullaniciCheckInKartListesiDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciCheckInKartListesiDGV.Name = "kullaniciCheckInKartListesiDGV";
            this.kullaniciCheckInKartListesiDGV.RowHeadersWidth = 51;
            this.kullaniciCheckInKartListesiDGV.Size = new System.Drawing.Size(595, 279);
            this.kullaniciCheckInKartListesiDGV.TabIndex = 5;
            // 
            // kart_numarasi
            // 
            this.kart_numarasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kart_numarasi.DataPropertyName = "kart_numarasi";
            this.kart_numarasi.HeaderText = "Kart Numarası";
            this.kart_numarasi.MinimumWidth = 6;
            this.kart_numarasi.Name = "kart_numarasi";
            this.kart_numarasi.Width = 120;
            // 
            // ay
            // 
            this.ay.DataPropertyName = "ay";
            this.ay.HeaderText = "Ay";
            this.ay.MinimumWidth = 6;
            this.ay.Name = "ay";
            this.ay.Width = 125;
            // 
            // yil
            // 
            this.yil.DataPropertyName = "yil";
            this.yil.HeaderText = "Yıl";
            this.yil.MinimumWidth = 6;
            this.yil.Name = "yil";
            this.yil.Width = 125;
            // 
            // uc_hane
            // 
            this.uc_hane.DataPropertyName = "uc_hane";
            this.uc_hane.HeaderText = "CVV";
            this.uc_hane.MinimumWidth = 6;
            this.uc_hane.Name = "uc_hane";
            this.uc_hane.Width = 125;
            // 
            // kart_id
            // 
            this.kart_id.DataPropertyName = "kart_id";
            this.kart_id.HeaderText = "Kart Id";
            this.kart_id.MinimumWidth = 6;
            this.kart_id.Name = "kart_id";
            this.kart_id.Width = 125;
            // 
            // kartlarBindingSource
            // 
            this.kartlarBindingSource.DataMember = "kartlar";
            this.kartlarBindingSource.DataSource = this.sONDataSet25;
            // 
            // sONDataSet25
            // 
            this.sONDataSet25.DataSetName = "SONDataSet25";
            this.sONDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInTamamlaButton
            // 
            this.checkInTamamlaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.checkInTamamlaButton.Location = new System.Drawing.Point(239, 377);
            this.checkInTamamlaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkInTamamlaButton.Name = "checkInTamamlaButton";
            this.checkInTamamlaButton.Size = new System.Drawing.Size(200, 38);
            this.checkInTamamlaButton.TabIndex = 7;
            this.checkInTamamlaButton.Text = "Chcek-In\'i  Tamamla";
            this.checkInTamamlaButton.UseVisualStyleBackColor = true;
            this.checkInTamamlaButton.Click += new System.EventHandler(this.checkInTamamlaButton_Click_1);
            // 
            // kartlarTableAdapter
            // 
            this.kartlarTableAdapter.ClearBeforeFill = true;
            // 
            // kartSecToCheckInButton
            // 
            this.kartSecToCheckInButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.kartSecToCheckInButton.Location = new System.Drawing.Point(17, 17);
            this.kartSecToCheckInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kartSecToCheckInButton.Name = "kartSecToCheckInButton";
            this.kartSecToCheckInButton.Size = new System.Drawing.Size(52, 34);
            this.kartSecToCheckInButton.TabIndex = 8;
            this.kartSecToCheckInButton.Text = "G";
            this.kartSecToCheckInButton.UseVisualStyleBackColor = true;
            this.kartSecToCheckInButton.Click += new System.EventHandler(this.kartSecToCheckInButton_Click);
            // 
            // kartidDataGridViewTextBoxColumn
            // 
            this.kartidDataGridViewTextBoxColumn.DataPropertyName = "kart_id";
            this.kartidDataGridViewTextBoxColumn.HeaderText = "kart_id";
            this.kartidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kartidDataGridViewTextBoxColumn.Name = "kartidDataGridViewTextBoxColumn";
            this.kartidDataGridViewTextBoxColumn.Width = 125;
            // 
            // kartnumarasiDataGridViewTextBoxColumn
            // 
            this.kartnumarasiDataGridViewTextBoxColumn.DataPropertyName = "kart_numarasi";
            this.kartnumarasiDataGridViewTextBoxColumn.HeaderText = "kart_numarasi";
            this.kartnumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kartnumarasiDataGridViewTextBoxColumn.Name = "kartnumarasiDataGridViewTextBoxColumn";
            this.kartnumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "ay";
            this.ayDataGridViewTextBoxColumn.HeaderText = "ay";
            this.ayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            this.ayDataGridViewTextBoxColumn.Width = 125;
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "yil";
            this.yilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            this.yilDataGridViewTextBoxColumn.Width = 125;
            // 
            // uchaneDataGridViewTextBoxColumn
            // 
            this.uchaneDataGridViewTextBoxColumn.DataPropertyName = "uc_hane";
            this.uchaneDataGridViewTextBoxColumn.HeaderText = "uc_hane";
            this.uchaneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uchaneDataGridViewTextBoxColumn.Name = "uchaneDataGridViewTextBoxColumn";
            this.uchaneDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciidDataGridViewTextBoxColumn
            // 
            this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "kullanici_id";
            this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "kullanici_id";
            this.kullaniciidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
            this.kullaniciidDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkInIkinciAsama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 436);
            this.Controls.Add(this.kartSecToCheckInButton);
            this.Controls.Add(this.checkInTamamlaButton);
            this.Controls.Add(this.kullaniciCheckInKartListesiLabel);
            this.Controls.Add(this.kullaniciCheckInKartListesiDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "checkInIkinciAsama";
            this.Text = "checkInIkinciAsama";
            this.Load += new System.EventHandler(this.checkInIkinciAsama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciCheckInKartListesiDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciCheckInKartListesiLabel;
        private System.Windows.Forms.DataGridView kullaniciCheckInKartListesiDGV;
        private System.Windows.Forms.Button checkInTamamlaButton;
        private SONDataSet25 sONDataSet25;
        private System.Windows.Forms.BindingSource kartlarBindingSource;
        private SONDataSet25TableAdapters.kartlarTableAdapter kartlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kart_numarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ay;
        private System.Windows.Forms.DataGridViewTextBoxColumn yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn uc_hane;
        private System.Windows.Forms.DataGridViewTextBoxColumn kart_id;
        private System.Windows.Forms.Button kartSecToCheckInButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartnumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uchaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
    }
}