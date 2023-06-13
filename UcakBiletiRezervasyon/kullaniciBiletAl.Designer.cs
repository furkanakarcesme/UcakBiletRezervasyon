namespace UcakBiletiRezervasyon
{
    partial class kullaniciBiletAl
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
            this.biletAlNeredenComboBox = new System.Windows.Forms.ComboBox();
            this.havalimanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet14 = new UcakBiletiRezervasyon.SONDataSet14();
            this.biletAlDTP = new System.Windows.Forms.DateTimePicker();
            this.biletAlDataGridView = new System.Windows.Forms.DataGridView();
            this.ucuslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet16 = new UcakBiletiRezervasyon.SONDataSet16();
            this.biletAlUcusAraButton = new System.Windows.Forms.Button();
            this.biletAlNeredenLabel = new System.Windows.Forms.Label();
            this.biletAlNereyeLabel = new System.Windows.Forms.Label();
            this.biletAlTarihLabel = new System.Windows.Forms.Label();
            this.biletAlNereyeComboBox = new System.Windows.Forms.ComboBox();
            this.havalimanivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet15 = new UcakBiletiRezervasyon.SONDataSet15();
            this.biletAlRezOlusturButton = new System.Windows.Forms.Button();
            this.havalimani_kTableAdapter = new UcakBiletiRezervasyon.SONDataSet14TableAdapters.havalimani_kTableAdapter();
            this.havalimani_vTableAdapter = new UcakBiletiRezervasyon.SONDataSet15TableAdapters.havalimani_vTableAdapter();
            this.ucuslarTableAdapter = new UcakBiletiRezervasyon.SONDataSet16TableAdapters.ucuslarTableAdapter();
            this.biletAlTumUcuslarButton = new System.Windows.Forms.Button();
            this.biletAlToAraSayfaButton = new System.Windows.Forms.Button();
            this.biletRezervasyonOlusturLabel = new System.Windows.Forms.Label();
            this.ucus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucus_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkis_saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inis_saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletAlDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // biletAlNeredenComboBox
            // 
            this.biletAlNeredenComboBox.DataSource = this.havalimanikBindingSource;
            this.biletAlNeredenComboBox.DisplayMember = "havalimani_adi";
            this.biletAlNeredenComboBox.FormattingEnabled = true;
            this.biletAlNeredenComboBox.Location = new System.Drawing.Point(101, 99);
            this.biletAlNeredenComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlNeredenComboBox.Name = "biletAlNeredenComboBox";
            this.biletAlNeredenComboBox.Size = new System.Drawing.Size(232, 24);
            this.biletAlNeredenComboBox.TabIndex = 0;
            this.biletAlNeredenComboBox.ValueMember = "havalimani_id";
            // 
            // havalimanikBindingSource
            // 
            this.havalimanikBindingSource.DataMember = "havalimani_k";
            this.havalimanikBindingSource.DataSource = this.sONDataSet14;
            // 
            // sONDataSet14
            // 
            this.sONDataSet14.DataSetName = "SONDataSet14";
            this.sONDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletAlDTP
            // 
            this.biletAlDTP.Location = new System.Drawing.Point(942, 101);
            this.biletAlDTP.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlDTP.Name = "biletAlDTP";
            this.biletAlDTP.Size = new System.Drawing.Size(232, 22);
            this.biletAlDTP.TabIndex = 1;
            // 
            // biletAlDataGridView
            // 
            this.biletAlDataGridView.AutoGenerateColumns = false;
            this.biletAlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletAlDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucus_id,
            this.ucus_tarihi,
            this.kalkis_saati,
            this.inis_saati,
            this.ucret});
            this.biletAlDataGridView.DataSource = this.ucuslarBindingSource;
            this.biletAlDataGridView.Location = new System.Drawing.Point(16, 210);
            this.biletAlDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlDataGridView.Name = "biletAlDataGridView";
            this.biletAlDataGridView.RowHeadersWidth = 51;
            this.biletAlDataGridView.Size = new System.Drawing.Size(1158, 485);
            this.biletAlDataGridView.TabIndex = 2;
            // 
            // ucuslarBindingSource
            // 
            this.ucuslarBindingSource.DataMember = "ucuslar";
            this.ucuslarBindingSource.DataSource = this.sONDataSet16;
            // 
            // sONDataSet16
            // 
            this.sONDataSet16.DataSetName = "SONDataSet16";
            this.sONDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletAlUcusAraButton
            // 
            this.biletAlUcusAraButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.biletAlUcusAraButton.Location = new System.Drawing.Point(1030, 151);
            this.biletAlUcusAraButton.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlUcusAraButton.Name = "biletAlUcusAraButton";
            this.biletAlUcusAraButton.Size = new System.Drawing.Size(144, 41);
            this.biletAlUcusAraButton.TabIndex = 3;
            this.biletAlUcusAraButton.Text = "Uçuş Ara";
            this.biletAlUcusAraButton.UseVisualStyleBackColor = true;
            this.biletAlUcusAraButton.Click += new System.EventHandler(this.biletAlUcusAraButton_Click);
            // 
            // biletAlNeredenLabel
            // 
            this.biletAlNeredenLabel.AutoSize = true;
            this.biletAlNeredenLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.biletAlNeredenLabel.Location = new System.Drawing.Point(16, 97);
            this.biletAlNeredenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biletAlNeredenLabel.Name = "biletAlNeredenLabel";
            this.biletAlNeredenLabel.Size = new System.Drawing.Size(72, 24);
            this.biletAlNeredenLabel.TabIndex = 4;
            this.biletAlNeredenLabel.Text = "Nereden";
            // 
            // biletAlNereyeLabel
            // 
            this.biletAlNereyeLabel.AutoSize = true;
            this.biletAlNereyeLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.biletAlNereyeLabel.Location = new System.Drawing.Point(423, 99);
            this.biletAlNereyeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biletAlNereyeLabel.Name = "biletAlNereyeLabel";
            this.biletAlNereyeLabel.Size = new System.Drawing.Size(61, 24);
            this.biletAlNereyeLabel.TabIndex = 5;
            this.biletAlNereyeLabel.Text = "Nereye";
            // 
            // biletAlTarihLabel
            // 
            this.biletAlTarihLabel.AutoSize = true;
            this.biletAlTarihLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.biletAlTarihLabel.Location = new System.Drawing.Point(875, 100);
            this.biletAlTarihLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biletAlTarihLabel.Name = "biletAlTarihLabel";
            this.biletAlTarihLabel.Size = new System.Drawing.Size(46, 24);
            this.biletAlTarihLabel.TabIndex = 7;
            this.biletAlTarihLabel.Text = "Tarih";
            // 
            // biletAlNereyeComboBox
            // 
            this.biletAlNereyeComboBox.DataSource = this.havalimanivBindingSource;
            this.biletAlNereyeComboBox.DisplayMember = "havalimani_adi";
            this.biletAlNereyeComboBox.FormattingEnabled = true;
            this.biletAlNereyeComboBox.Location = new System.Drawing.Point(495, 99);
            this.biletAlNereyeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlNereyeComboBox.Name = "biletAlNereyeComboBox";
            this.biletAlNereyeComboBox.Size = new System.Drawing.Size(232, 24);
            this.biletAlNereyeComboBox.TabIndex = 8;
            this.biletAlNereyeComboBox.ValueMember = "havalimani_id";
            // 
            // havalimanivBindingSource
            // 
            this.havalimanivBindingSource.DataMember = "havalimani_v";
            this.havalimanivBindingSource.DataSource = this.sONDataSet15;
            // 
            // sONDataSet15
            // 
            this.sONDataSet15.DataSetName = "SONDataSet15";
            this.sONDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletAlRezOlusturButton
            // 
            this.biletAlRezOlusturButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.biletAlRezOlusturButton.Location = new System.Drawing.Point(1006, 718);
            this.biletAlRezOlusturButton.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlRezOlusturButton.Name = "biletAlRezOlusturButton";
            this.biletAlRezOlusturButton.Size = new System.Drawing.Size(181, 41);
            this.biletAlRezOlusturButton.TabIndex = 9;
            this.biletAlRezOlusturButton.Text = "Rezervasyon Oluştur";
            this.biletAlRezOlusturButton.UseVisualStyleBackColor = true;
            this.biletAlRezOlusturButton.Click += new System.EventHandler(this.biletAlRezOlusturButton_Click);
            // 
            // havalimani_kTableAdapter
            // 
            this.havalimani_kTableAdapter.ClearBeforeFill = true;
            // 
            // havalimani_vTableAdapter
            // 
            this.havalimani_vTableAdapter.ClearBeforeFill = true;
            // 
            // ucuslarTableAdapter
            // 
            this.ucuslarTableAdapter.ClearBeforeFill = true;
            // 
            // biletAlTumUcuslarButton
            // 
            this.biletAlTumUcuslarButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F);
            this.biletAlTumUcuslarButton.Location = new System.Drawing.Point(21, 151);
            this.biletAlTumUcuslarButton.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlTumUcuslarButton.Name = "biletAlTumUcuslarButton";
            this.biletAlTumUcuslarButton.Size = new System.Drawing.Size(144, 41);
            this.biletAlTumUcuslarButton.TabIndex = 10;
            this.biletAlTumUcuslarButton.Text = "Tüm Uçuşlar";
            this.biletAlTumUcuslarButton.UseVisualStyleBackColor = true;
            this.biletAlTumUcuslarButton.Click += new System.EventHandler(this.biletAlTumUcuslarButton_Click);
            // 
            // biletAlToAraSayfaButton
            // 
            this.biletAlToAraSayfaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.biletAlToAraSayfaButton.Location = new System.Drawing.Point(16, 15);
            this.biletAlToAraSayfaButton.Margin = new System.Windows.Forms.Padding(4);
            this.biletAlToAraSayfaButton.Name = "biletAlToAraSayfaButton";
            this.biletAlToAraSayfaButton.Size = new System.Drawing.Size(52, 34);
            this.biletAlToAraSayfaButton.TabIndex = 11;
            this.biletAlToAraSayfaButton.Text = "G";
            this.biletAlToAraSayfaButton.UseVisualStyleBackColor = true;
            this.biletAlToAraSayfaButton.Click += new System.EventHandler(this.biletAlToAraSayfaButton_Click);
            // 
            // biletRezervasyonOlusturLabel
            // 
            this.biletRezervasyonOlusturLabel.AutoSize = true;
            this.biletRezervasyonOlusturLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F);
            this.biletRezervasyonOlusturLabel.Location = new System.Drawing.Point(438, 33);
            this.biletRezervasyonOlusturLabel.Name = "biletRezervasyonOlusturLabel";
            this.biletRezervasyonOlusturLabel.Size = new System.Drawing.Size(323, 32);
            this.biletRezervasyonOlusturLabel.TabIndex = 12;
            this.biletRezervasyonOlusturLabel.Text = "BİLET REZERVASYONU OLUŞTUR";
            // 
            // ucus_id
            // 
            this.ucus_id.DataPropertyName = "ucus_id";
            this.ucus_id.HeaderText = "Uçuş No";
            this.ucus_id.MinimumWidth = 6;
            this.ucus_id.Name = "ucus_id";
            this.ucus_id.Width = 125;
            // 
            // ucus_tarihi
            // 
            this.ucus_tarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ucus_tarihi.DataPropertyName = "ucus_tarihi";
            this.ucus_tarihi.HeaderText = "Uçuş Tarihi";
            this.ucus_tarihi.MinimumWidth = 6;
            this.ucus_tarihi.Name = "ucus_tarihi";
            this.ucus_tarihi.Width = 104;
            // 
            // kalkis_saati
            // 
            this.kalkis_saati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kalkis_saati.DataPropertyName = "kalkis_saati";
            this.kalkis_saati.HeaderText = "Kalkış Saati";
            this.kalkis_saati.MinimumWidth = 6;
            this.kalkis_saati.Name = "kalkis_saati";
            this.kalkis_saati.Width = 106;
            // 
            // inis_saati
            // 
            this.inis_saati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.inis_saati.DataPropertyName = "inis_saati";
            this.inis_saati.HeaderText = "İniş Saati";
            this.inis_saati.MinimumWidth = 6;
            this.inis_saati.Name = "inis_saati";
            this.inis_saati.Width = 90;
            // 
            // ucret
            // 
            this.ucret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ucret.DataPropertyName = "ucret";
            this.ucret.HeaderText = "Ücret";
            this.ucret.MinimumWidth = 6;
            this.ucret.Name = "ucret";
            this.ucret.Width = 68;
            // 
            // kullaniciBiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 778);
            this.Controls.Add(this.biletRezervasyonOlusturLabel);
            this.Controls.Add(this.biletAlToAraSayfaButton);
            this.Controls.Add(this.biletAlTumUcuslarButton);
            this.Controls.Add(this.biletAlRezOlusturButton);
            this.Controls.Add(this.biletAlNereyeComboBox);
            this.Controls.Add(this.biletAlTarihLabel);
            this.Controls.Add(this.biletAlNereyeLabel);
            this.Controls.Add(this.biletAlNeredenLabel);
            this.Controls.Add(this.biletAlUcusAraButton);
            this.Controls.Add(this.biletAlDataGridView);
            this.Controls.Add(this.biletAlDTP);
            this.Controls.Add(this.biletAlNeredenComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kullaniciBiletAl";
            this.Text = "Kullanıcı Bilet Al";
            this.Load += new System.EventHandler(this.kullaniciBiletAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletAlDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox biletAlNeredenComboBox;
        private System.Windows.Forms.DateTimePicker biletAlDTP;
        private System.Windows.Forms.DataGridView biletAlDataGridView;
        private System.Windows.Forms.Button biletAlUcusAraButton;
        private System.Windows.Forms.Label biletAlNeredenLabel;
        private System.Windows.Forms.Label biletAlNereyeLabel;
        private System.Windows.Forms.Label biletAlTarihLabel;
        private System.Windows.Forms.ComboBox biletAlNereyeComboBox;
        private System.Windows.Forms.Button biletAlRezOlusturButton;
        private SONDataSet14 sONDataSet14;
        private System.Windows.Forms.BindingSource havalimanikBindingSource;
        private SONDataSet14TableAdapters.havalimani_kTableAdapter havalimani_kTableAdapter;
        private SONDataSet15 sONDataSet15;
        private System.Windows.Forms.BindingSource havalimanivBindingSource;
        private SONDataSet15TableAdapters.havalimani_vTableAdapter havalimani_vTableAdapter;
        private SONDataSet16 sONDataSet16;
        private System.Windows.Forms.BindingSource ucuslarBindingSource;
        private SONDataSet16TableAdapters.ucuslarTableAdapter ucuslarTableAdapter;
        private System.Windows.Forms.Button biletAlTumUcuslarButton;
        private System.Windows.Forms.Button biletAlToAraSayfaButton;
        private System.Windows.Forms.Label biletRezervasyonOlusturLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucus_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucus_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkis_saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn inis_saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
    }
}