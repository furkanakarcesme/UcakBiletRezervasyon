namespace UcakBiletiRezervasyon
{
    partial class RezSil
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
            this.rezSilButton = new System.Windows.Forms.Button();
            this.rezSilAdaGoreSilRadioButton = new System.Windows.Forms.RadioButton();
            this.rezSilRezIdRadioButton = new System.Windows.Forms.RadioButton();
            this.rezSilRezIdSilTextBox = new System.Windows.Forms.TextBox();
            this.rezSilAramaRezSilButton = new System.Windows.Forms.Button();
            this.rezSilDaGrView = new System.Windows.Forms.DataGridView();
            this.rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet7 = new UcakBiletiRezervasyon.SONDataSet7();
            this.rezSilAdaGoreSilTextBox = new System.Windows.Forms.TextBox();
            this.rezervasyonTableAdapter = new UcakBiletiRezervasyon.SONDataSet7TableAdapters.rezervasyonTableAdapter();
            this.rezerSilLabel = new System.Windows.Forms.Label();
            this.rezSilKonumaGoreRadioButto = new System.Windows.Forms.RadioButton();
            this.rezlSilRezTarihiRadioButto = new System.Windows.Forms.RadioButton();
            this.rezSilRezTarihiTxtBox = new System.Windows.Forms.TextBox();
            this.rezSilSoyadaGoreSilTextBox = new System.Windows.Forms.TextBox();
            this.rezSilKalkisHavalimaninaGoreCombo = new System.Windows.Forms.ComboBox();
            this.havalimanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet12 = new UcakBiletiRezervasyon.SONDataSet12();
            this.rezSilVarisHavalimaninaGoreCombo = new System.Windows.Forms.ComboBox();
            this.havalimanivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet13 = new UcakBiletiRezervasyon.SONDataSet13();
            this.havalimani_kTableAdapter = new UcakBiletiRezervasyon.SONDataSet12TableAdapters.havalimani_kTableAdapter();
            this.havalimani_vTableAdapter = new UcakBiletiRezervasyon.SONDataSet13TableAdapters.havalimani_vTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.rezervasyon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyon_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rezSilDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // rezSilButton
            // 
            this.rezSilButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rezSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezSilButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rezSilButton.Location = new System.Drawing.Point(211, 405);
            this.rezSilButton.Name = "rezSilButton";
            this.rezSilButton.Size = new System.Drawing.Size(75, 28);
            this.rezSilButton.TabIndex = 37;
            this.rezSilButton.Text = "SİL";
            this.rezSilButton.UseVisualStyleBackColor = false;
            this.rezSilButton.Click += new System.EventHandler(this.rezSilButton_Click);
            // 
            // rezSilAdaGoreSilRadioButton
            // 
            this.rezSilAdaGoreSilRadioButton.AutoSize = true;
            this.rezSilAdaGoreSilRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezSilAdaGoreSilRadioButton.Location = new System.Drawing.Point(17, 146);
            this.rezSilAdaGoreSilRadioButton.Name = "rezSilAdaGoreSilRadioButton";
            this.rezSilAdaGoreSilRadioButton.Size = new System.Drawing.Size(92, 25);
            this.rezSilAdaGoreSilRadioButton.TabIndex = 35;
            this.rezSilAdaGoreSilRadioButton.TabStop = true;
            this.rezSilAdaGoreSilRadioButton.Text = "Ad - Soyad";
            this.rezSilAdaGoreSilRadioButton.UseVisualStyleBackColor = true;
            // 
            // rezSilRezIdRadioButton
            // 
            this.rezSilRezIdRadioButton.AutoSize = true;
            this.rezSilRezIdRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezSilRezIdRadioButton.Location = new System.Drawing.Point(17, 86);
            this.rezSilRezIdRadioButton.Name = "rezSilRezIdRadioButton";
            this.rezSilRezIdRadioButton.Size = new System.Drawing.Size(70, 25);
            this.rezSilRezIdRadioButton.TabIndex = 34;
            this.rezSilRezIdRadioButton.TabStop = true;
            this.rezSilRezIdRadioButton.Text = "Rez. ID";
            this.rezSilRezIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // rezSilRezIdSilTextBox
            // 
            this.rezSilRezIdSilTextBox.Location = new System.Drawing.Point(115, 90);
            this.rezSilRezIdSilTextBox.Name = "rezSilRezIdSilTextBox";
            this.rezSilRezIdSilTextBox.Size = new System.Drawing.Size(171, 20);
            this.rezSilRezIdSilTextBox.TabIndex = 33;
            // 
            // rezSilAramaRezSilButton
            // 
            this.rezSilAramaRezSilButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rezSilAramaRezSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezSilAramaRezSilButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rezSilAramaRezSilButton.Location = new System.Drawing.Point(115, 405);
            this.rezSilAramaRezSilButton.Name = "rezSilAramaRezSilButton";
            this.rezSilAramaRezSilButton.Size = new System.Drawing.Size(75, 28);
            this.rezSilAramaRezSilButton.TabIndex = 32;
            this.rezSilAramaRezSilButton.Text = "ARA";
            this.rezSilAramaRezSilButton.UseVisualStyleBackColor = false;
            this.rezSilAramaRezSilButton.Click += new System.EventHandler(this.rezSilAramaRezSilButton_Click);
            // 
            // rezSilDaGrView
            // 
            this.rezSilDaGrView.AutoGenerateColumns = false;
            this.rezSilDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezSilDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervasyon_id,
            this.rezervasyon_tarihi});
            this.rezSilDaGrView.DataSource = this.rezervasyonBindingSource;
            this.rezSilDaGrView.Location = new System.Drawing.Point(301, 86);
            this.rezSilDaGrView.Name = "rezSilDaGrView";
            this.rezSilDaGrView.RowHeadersWidth = 51;
            this.rezSilDaGrView.Size = new System.Drawing.Size(1038, 347);
            this.rezSilDaGrView.TabIndex = 31;
            this.rezSilDaGrView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezSilDaGrView_CellEnter);
            // 
            // rezervasyonBindingSource
            // 
            this.rezervasyonBindingSource.DataMember = "rezervasyon";
            this.rezervasyonBindingSource.DataSource = this.sONDataSet7;
            // 
            // sONDataSet7
            // 
            this.sONDataSet7.DataSetName = "SONDataSet7";
            this.sONDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezSilAdaGoreSilTextBox
            // 
            this.rezSilAdaGoreSilTextBox.Location = new System.Drawing.Point(115, 150);
            this.rezSilAdaGoreSilTextBox.Name = "rezSilAdaGoreSilTextBox";
            this.rezSilAdaGoreSilTextBox.Size = new System.Drawing.Size(171, 20);
            this.rezSilAdaGoreSilTextBox.TabIndex = 30;
            // 
            // rezervasyonTableAdapter
            // 
            this.rezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // rezerSilLabel
            // 
            this.rezerSilLabel.AutoSize = true;
            this.rezerSilLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F);
            this.rezerSilLabel.Location = new System.Drawing.Point(554, 25);
            this.rezerSilLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rezerSilLabel.Name = "rezerSilLabel";
            this.rezerSilLabel.Size = new System.Drawing.Size(151, 25);
            this.rezerSilLabel.TabIndex = 38;
            this.rezerSilLabel.Text = "REZERVASYON SİL";
            // 
            // rezSilKonumaGoreRadioButto
            // 
            this.rezSilKonumaGoreRadioButto.AutoSize = true;
            this.rezSilKonumaGoreRadioButto.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezSilKonumaGoreRadioButto.Location = new System.Drawing.Point(16, 237);
            this.rezSilKonumaGoreRadioButto.Name = "rezSilKonumaGoreRadioButto";
            this.rezSilKonumaGoreRadioButto.Size = new System.Drawing.Size(71, 25);
            this.rezSilKonumaGoreRadioButto.TabIndex = 40;
            this.rezSilKonumaGoreRadioButto.TabStop = true;
            this.rezSilKonumaGoreRadioButto.Text = "Konum";
            this.rezSilKonumaGoreRadioButto.UseVisualStyleBackColor = true;
            // 
            // rezlSilRezTarihiRadioButto
            // 
            this.rezlSilRezTarihiRadioButto.AutoSize = true;
            this.rezlSilRezTarihiRadioButto.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.rezlSilRezTarihiRadioButto.Location = new System.Drawing.Point(16, 328);
            this.rezlSilRezTarihiRadioButto.Name = "rezlSilRezTarihiRadioButto";
            this.rezlSilRezTarihiRadioButto.Size = new System.Drawing.Size(92, 25);
            this.rezlSilRezTarihiRadioButto.TabIndex = 42;
            this.rezlSilRezTarihiRadioButto.TabStop = true;
            this.rezlSilRezTarihiRadioButto.Text = "Rez. Tarihi";
            this.rezlSilRezTarihiRadioButto.UseVisualStyleBackColor = true;
            // 
            // rezSilRezTarihiTxtBox
            // 
            this.rezSilRezTarihiTxtBox.Location = new System.Drawing.Point(115, 332);
            this.rezSilRezTarihiTxtBox.Name = "rezSilRezTarihiTxtBox";
            this.rezSilRezTarihiTxtBox.Size = new System.Drawing.Size(171, 20);
            this.rezSilRezTarihiTxtBox.TabIndex = 41;
            // 
            // rezSilSoyadaGoreSilTextBox
            // 
            this.rezSilSoyadaGoreSilTextBox.Location = new System.Drawing.Point(115, 181);
            this.rezSilSoyadaGoreSilTextBox.Name = "rezSilSoyadaGoreSilTextBox";
            this.rezSilSoyadaGoreSilTextBox.Size = new System.Drawing.Size(171, 20);
            this.rezSilSoyadaGoreSilTextBox.TabIndex = 43;
            // 
            // rezSilKalkisHavalimaninaGoreCombo
            // 
            this.rezSilKalkisHavalimaninaGoreCombo.DataSource = this.havalimanikBindingSource;
            this.rezSilKalkisHavalimaninaGoreCombo.DisplayMember = "havalimani_adi";
            this.rezSilKalkisHavalimaninaGoreCombo.FormattingEnabled = true;
            this.rezSilKalkisHavalimaninaGoreCombo.Location = new System.Drawing.Point(115, 241);
            this.rezSilKalkisHavalimaninaGoreCombo.Name = "rezSilKalkisHavalimaninaGoreCombo";
            this.rezSilKalkisHavalimaninaGoreCombo.Size = new System.Drawing.Size(171, 21);
            this.rezSilKalkisHavalimaninaGoreCombo.TabIndex = 44;
            this.rezSilKalkisHavalimaninaGoreCombo.ValueMember = "havalimani_id";
            // 
            // havalimanikBindingSource
            // 
            this.havalimanikBindingSource.DataMember = "havalimani_k";
            this.havalimanikBindingSource.DataSource = this.sONDataSet12;
            // 
            // sONDataSet12
            // 
            this.sONDataSet12.DataSetName = "SONDataSet12";
            this.sONDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezSilVarisHavalimaninaGoreCombo
            // 
            this.rezSilVarisHavalimaninaGoreCombo.DataSource = this.havalimanivBindingSource;
            this.rezSilVarisHavalimaninaGoreCombo.DisplayMember = "havalimani_adi";
            this.rezSilVarisHavalimaninaGoreCombo.FormattingEnabled = true;
            this.rezSilVarisHavalimaninaGoreCombo.Location = new System.Drawing.Point(115, 273);
            this.rezSilVarisHavalimaninaGoreCombo.Name = "rezSilVarisHavalimaninaGoreCombo";
            this.rezSilVarisHavalimaninaGoreCombo.Size = new System.Drawing.Size(171, 21);
            this.rezSilVarisHavalimaninaGoreCombo.TabIndex = 45;
            this.rezSilVarisHavalimaninaGoreCombo.ValueMember = "havalimani_id";
            // 
            // havalimanivBindingSource
            // 
            this.havalimanivBindingSource.DataMember = "havalimani_v";
            this.havalimanivBindingSource.DataSource = this.sONDataSet13;
            // 
            // sONDataSet13
            // 
            this.sONDataSet13.DataSetName = "SONDataSet13";
            this.sONDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havalimani_kTableAdapter
            // 
            this.havalimani_kTableAdapter.ClearBeforeFill = true;
            // 
            // havalimani_vTableAdapter
            // 
            this.havalimani_vTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 46;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rezervasyon_id
            // 
            this.rezervasyon_id.DataPropertyName = "rezervasyon_id";
            this.rezervasyon_id.HeaderText = "Rez. ID";
            this.rezervasyon_id.MinimumWidth = 6;
            this.rezervasyon_id.Name = "rezervasyon_id";
            this.rezervasyon_id.Width = 125;
            // 
            // rezervasyon_tarihi
            // 
            this.rezervasyon_tarihi.DataPropertyName = "rezervasyon_tarihi";
            this.rezervasyon_tarihi.HeaderText = "Rez. Tarihi";
            this.rezervasyon_tarihi.MinimumWidth = 6;
            this.rezervasyon_tarihi.Name = "rezervasyon_tarihi";
            this.rezervasyon_tarihi.Width = 91;
            // 
            // RezSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rezSilVarisHavalimaninaGoreCombo);
            this.Controls.Add(this.rezSilKalkisHavalimaninaGoreCombo);
            this.Controls.Add(this.rezSilSoyadaGoreSilTextBox);
            this.Controls.Add(this.rezlSilRezTarihiRadioButto);
            this.Controls.Add(this.rezSilRezTarihiTxtBox);
            this.Controls.Add(this.rezSilKonumaGoreRadioButto);
            this.Controls.Add(this.rezerSilLabel);
            this.Controls.Add(this.rezSilButton);
            this.Controls.Add(this.rezSilAdaGoreSilRadioButton);
            this.Controls.Add(this.rezSilRezIdRadioButton);
            this.Controls.Add(this.rezSilRezIdSilTextBox);
            this.Controls.Add(this.rezSilAramaRezSilButton);
            this.Controls.Add(this.rezSilDaGrView);
            this.Controls.Add(this.rezSilAdaGoreSilTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RezSil";
            this.Text = "Rezervasyon Sil";
            this.Load += new System.EventHandler(this.RezSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezSilDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rezSilButton;
        private System.Windows.Forms.RadioButton rezSilAdaGoreSilRadioButton;
        private System.Windows.Forms.RadioButton rezSilRezIdRadioButton;
        private System.Windows.Forms.TextBox rezSilRezIdSilTextBox;
        private System.Windows.Forms.Button rezSilAramaRezSilButton;
        private System.Windows.Forms.DataGridView rezSilDaGrView;
        private System.Windows.Forms.TextBox rezSilAdaGoreSilTextBox;
        private SONDataSet7 sONDataSet7;
        private System.Windows.Forms.BindingSource rezervasyonBindingSource;
        private SONDataSet7TableAdapters.rezervasyonTableAdapter rezervasyonTableAdapter;
        private System.Windows.Forms.Label rezerSilLabel;
        private System.Windows.Forms.RadioButton rezSilKonumaGoreRadioButto;
        private System.Windows.Forms.RadioButton rezlSilRezTarihiRadioButto;
        private System.Windows.Forms.TextBox rezSilRezTarihiTxtBox;
        private System.Windows.Forms.TextBox rezSilSoyadaGoreSilTextBox;
        private System.Windows.Forms.ComboBox rezSilKalkisHavalimaninaGoreCombo;
        private System.Windows.Forms.ComboBox rezSilVarisHavalimaninaGoreCombo;
        private SONDataSet12 sONDataSet12;
        private System.Windows.Forms.BindingSource havalimanikBindingSource;
        private SONDataSet12TableAdapters.havalimani_kTableAdapter havalimani_kTableAdapter;
        private SONDataSet13 sONDataSet13;
        private System.Windows.Forms.BindingSource havalimanivBindingSource;
        private SONDataSet13TableAdapters.havalimani_vTableAdapter havalimani_vTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyon_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyon_tarihi;
    }
}