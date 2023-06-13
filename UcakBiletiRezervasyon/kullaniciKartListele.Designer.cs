namespace UcakBiletiRezervasyon
{
    partial class kullaniciKartListele
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
            this.kartListeleDaGrView = new System.Windows.Forms.DataGridView();
            this.kartnumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet17 = new UcakBiletiRezervasyon.SONDataSet17();
            this.kartlarTableAdapter = new UcakBiletiRezervasyon.SONDataSet17TableAdapters.kartlarTableAdapter();
            this.kartListeleToOdemeIslemleri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kartListeleDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // kartListeleDaGrView
            // 
            this.kartListeleDaGrView.AutoGenerateColumns = false;
            this.kartListeleDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kartListeleDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kartnumarasiDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.uchaneDataGridViewTextBoxColumn});
            this.kartListeleDaGrView.DataSource = this.kartlarBindingSource;
            this.kartListeleDaGrView.Location = new System.Drawing.Point(44, 98);
            this.kartListeleDaGrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kartListeleDaGrView.Name = "kartListeleDaGrView";
            this.kartListeleDaGrView.RowHeadersWidth = 51;
            this.kartListeleDaGrView.Size = new System.Drawing.Size(399, 244);
            this.kartListeleDaGrView.TabIndex = 0;
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
            // kartlarBindingSource
            // 
            this.kartlarBindingSource.DataMember = "kartlar";
            this.kartlarBindingSource.DataSource = this.sONDataSet17;
            // 
            // sONDataSet17
            // 
            this.sONDataSet17.DataSetName = "SONDataSet17";
            this.sONDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartlarTableAdapter
            // 
            this.kartlarTableAdapter.ClearBeforeFill = true;
            // 
            // kartListeleToOdemeIslemleri
            // 
            this.kartListeleToOdemeIslemleri.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.kartListeleToOdemeIslemleri.Location = new System.Drawing.Point(44, 32);
            this.kartListeleToOdemeIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kartListeleToOdemeIslemleri.Name = "kartListeleToOdemeIslemleri";
            this.kartListeleToOdemeIslemleri.Size = new System.Drawing.Size(52, 34);
            this.kartListeleToOdemeIslemleri.TabIndex = 12;
            this.kartListeleToOdemeIslemleri.Text = "G";
            this.kartListeleToOdemeIslemleri.UseVisualStyleBackColor = true;
            this.kartListeleToOdemeIslemleri.Click += new System.EventHandler(this.kartListeleToOdemeIslemleri_Click);
            // 
            // kullaniciKartListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 357);
            this.Controls.Add(this.kartListeleToOdemeIslemleri);
            this.Controls.Add(this.kartListeleDaGrView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kullaniciKartListele";
            this.Text = "Kullanıcı - Kart Listele";
            this.Load += new System.EventHandler(this.kullaniciKartListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kartListeleDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kartListeleDaGrView;
        private SONDataSet17 sONDataSet17;
        private System.Windows.Forms.BindingSource kartlarBindingSource;
        private SONDataSet17TableAdapters.kartlarTableAdapter kartlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartnumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uchaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button kartListeleToOdemeIslemleri;
    }
}