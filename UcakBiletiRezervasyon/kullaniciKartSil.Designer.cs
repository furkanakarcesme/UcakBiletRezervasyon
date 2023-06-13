namespace UcakBiletiRezervasyon
{
    partial class kullaniciKartSil
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
            this.kartSilDaGrView = new System.Windows.Forms.DataGridView();
            this.kartlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet18 = new UcakBiletiRezervasyon.SONDataSet18();
            this.kartSilButton = new System.Windows.Forms.Button();
            this.kartlarTableAdapter = new UcakBiletiRezervasyon.SONDataSet18TableAdapters.kartlarTableAdapter();
            this.kartSilEkranıLabel = new System.Windows.Forms.Label();
            this.kartSilToOdemeIslemleri = new System.Windows.Forms.Button();
            this.kart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartnumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kartSilDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // kartSilDaGrView
            // 
            this.kartSilDaGrView.AutoGenerateColumns = false;
            this.kartSilDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kartSilDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kart_id,
            this.kartnumarasiDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.uchaneDataGridViewTextBoxColumn});
            this.kartSilDaGrView.DataSource = this.kartlarBindingSource;
            this.kartSilDaGrView.Location = new System.Drawing.Point(13, 100);
            this.kartSilDaGrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kartSilDaGrView.Name = "kartSilDaGrView";
            this.kartSilDaGrView.RowHeadersWidth = 51;
            this.kartSilDaGrView.Size = new System.Drawing.Size(569, 226);
            this.kartSilDaGrView.TabIndex = 0;
            // 
            // kartlarBindingSource
            // 
            this.kartlarBindingSource.DataMember = "kartlar";
            this.kartlarBindingSource.DataSource = this.sONDataSet18;
            // 
            // sONDataSet18
            // 
            this.sONDataSet18.DataSetName = "SONDataSet18";
            this.sONDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartSilButton
            // 
            this.kartSilButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kartSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.kartSilButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kartSilButton.Location = new System.Drawing.Point(231, 345);
            this.kartSilButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kartSilButton.Name = "kartSilButton";
            this.kartSilButton.Size = new System.Drawing.Size(131, 42);
            this.kartSilButton.TabIndex = 1;
            this.kartSilButton.Text = "Kartı Sil";
            this.kartSilButton.UseVisualStyleBackColor = false;
            this.kartSilButton.Click += new System.EventHandler(this.kartSilButton_Click);
            // 
            // kartlarTableAdapter
            // 
            this.kartlarTableAdapter.ClearBeforeFill = true;
            // 
            // kartSilEkranıLabel
            // 
            this.kartSilEkranıLabel.AutoSize = true;
            this.kartSilEkranıLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16F);
            this.kartSilEkranıLabel.Location = new System.Drawing.Point(255, 36);
            this.kartSilEkranıLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kartSilEkranıLabel.Name = "kartSilEkranıLabel";
            this.kartSilEkranıLabel.Size = new System.Drawing.Size(89, 34);
            this.kartSilEkranıLabel.TabIndex = 2;
            this.kartSilEkranıLabel.Text = "Kart Sil";
            // 
            // kartSilToOdemeIslemleri
            // 
            this.kartSilToOdemeIslemleri.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.kartSilToOdemeIslemleri.Location = new System.Drawing.Point(12, 9);
            this.kartSilToOdemeIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kartSilToOdemeIslemleri.Name = "kartSilToOdemeIslemleri";
            this.kartSilToOdemeIslemleri.Size = new System.Drawing.Size(52, 34);
            this.kartSilToOdemeIslemleri.TabIndex = 12;
            this.kartSilToOdemeIslemleri.Text = "G";
            this.kartSilToOdemeIslemleri.UseVisualStyleBackColor = true;
            this.kartSilToOdemeIslemleri.Click += new System.EventHandler(this.kartSilToOdemeIslemleri_Click);
            // 
            // kart_id
            // 
            this.kart_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kart_id.DataPropertyName = "kart_id";
            this.kart_id.HeaderText = "Kart No.";
            this.kart_id.MinimumWidth = 6;
            this.kart_id.Name = "kart_id";
            this.kart_id.Width = 83;
            // 
            // kartnumarasiDataGridViewTextBoxColumn
            // 
            this.kartnumarasiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kartnumarasiDataGridViewTextBoxColumn.DataPropertyName = "kart_numarasi";
            this.kartnumarasiDataGridViewTextBoxColumn.HeaderText = "Kart Numarası";
            this.kartnumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kartnumarasiDataGridViewTextBoxColumn.Name = "kartnumarasiDataGridViewTextBoxColumn";
            this.kartnumarasiDataGridViewTextBoxColumn.Width = 120;
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "ay";
            this.ayDataGridViewTextBoxColumn.HeaderText = "Ay";
            this.ayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            this.ayDataGridViewTextBoxColumn.Width = 52;
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "Yıl";
            this.yilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            this.yilDataGridViewTextBoxColumn.Width = 51;
            // 
            // uchaneDataGridViewTextBoxColumn
            // 
            this.uchaneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uchaneDataGridViewTextBoxColumn.DataPropertyName = "uc_hane";
            this.uchaneDataGridViewTextBoxColumn.HeaderText = "CVV";
            this.uchaneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uchaneDataGridViewTextBoxColumn.Name = "uchaneDataGridViewTextBoxColumn";
            this.uchaneDataGridViewTextBoxColumn.Width = 63;
            // 
            // kullaniciKartSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 409);
            this.Controls.Add(this.kartSilToOdemeIslemleri);
            this.Controls.Add(this.kartSilEkranıLabel);
            this.Controls.Add(this.kartSilButton);
            this.Controls.Add(this.kartSilDaGrView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kullaniciKartSil";
            this.Text = "Kullanıcı - Kart Sil";
            this.Load += new System.EventHandler(this.kullaniciKartSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kartSilDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kartSilDaGrView;
        private System.Windows.Forms.Button kartSilButton;
        private SONDataSet18 sONDataSet18;
        private System.Windows.Forms.BindingSource kartlarBindingSource;
        private SONDataSet18TableAdapters.kartlarTableAdapter kartlarTableAdapter;
        private System.Windows.Forms.Label kartSilEkranıLabel;
        private System.Windows.Forms.Button kartSilToOdemeIslemleri;
        private System.Windows.Forms.DataGridViewTextBoxColumn kart_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartnumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uchaneDataGridViewTextBoxColumn;
    }
}