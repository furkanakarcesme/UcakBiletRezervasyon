namespace UcakBiletiRezervasyon
{
    partial class UcuslarListesi
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
            this.ucusListeleKonumaGoreRadioButton = new System.Windows.Forms.RadioButton();
            this.ucusListeleUcusIdyeGoreRadioButton = new System.Windows.Forms.RadioButton();
            this.ucusListeleUcusTarihineGoreRadioButton = new System.Windows.Forms.RadioButton();
            this.ucusListeleUcustarihiAramaTextBox = new System.Windows.Forms.TextBox();
            this.aramaButton = new System.Windows.Forms.Button();
            this.ucusListeleUcusAramaDaGrView = new System.Windows.Forms.DataGridView();
            this.ucuslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet5 = new UcakBiletiRezervasyon.SONDataSet5();
            this.ucusListeleUcusIdAramaTextBox = new System.Windows.Forms.TextBox();
            this.ucuslarTableAdapter = new UcakBiletiRezervasyon.SONDataSet5TableAdapters.ucuslarTableAdapter();
            this.kalkisHavalimaniUcusListeleComboBox = new System.Windows.Forms.ComboBox();
            this.havalimanikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet = new UcakBiletiRezervasyon.SONDataSet();
            this.varisHavalimaniUcusListesiComboBox = new System.Windows.Forms.ComboBox();
            this.havalimanivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet1 = new UcakBiletiRezervasyon.SONDataSet1();
            this.havalimanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.havalimani_kTableAdapter = new UcakBiletiRezervasyon.SONDataSetTableAdapters.havalimani_kTableAdapter();
            this.havalimani_vTableAdapter = new UcakBiletiRezervasyon.SONDataSet1TableAdapters.havalimani_vTableAdapter();
            this.ucus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucus_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkis_saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inis_saati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1234 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ucusListeleUcusAramaDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ucusListeleKonumaGoreRadioButton
            // 
            this.ucusListeleKonumaGoreRadioButton.AutoSize = true;
            this.ucusListeleKonumaGoreRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusListeleKonumaGoreRadioButton.Location = new System.Drawing.Point(374, 103);
            this.ucusListeleKonumaGoreRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusListeleKonumaGoreRadioButton.Name = "ucusListeleKonumaGoreRadioButton";
            this.ucusListeleKonumaGoreRadioButton.Size = new System.Drawing.Size(139, 29);
            this.ucusListeleKonumaGoreRadioButton.TabIndex = 18;
            this.ucusListeleKonumaGoreRadioButton.TabStop = true;
            this.ucusListeleKonumaGoreRadioButton.Text = "Konuma Göre";
            this.ucusListeleKonumaGoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // ucusListeleUcusIdyeGoreRadioButton
            // 
            this.ucusListeleUcusIdyeGoreRadioButton.AutoSize = true;
            this.ucusListeleUcusIdyeGoreRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusListeleUcusIdyeGoreRadioButton.Location = new System.Drawing.Point(41, 103);
            this.ucusListeleUcusIdyeGoreRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusListeleUcusIdyeGoreRadioButton.Name = "ucusListeleUcusIdyeGoreRadioButton";
            this.ucusListeleUcusIdyeGoreRadioButton.Size = new System.Drawing.Size(92, 29);
            this.ucusListeleUcusIdyeGoreRadioButton.TabIndex = 17;
            this.ucusListeleUcusIdyeGoreRadioButton.TabStop = true;
            this.ucusListeleUcusIdyeGoreRadioButton.Text = "Uçuş ID";
            this.ucusListeleUcusIdyeGoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // ucusListeleUcusTarihineGoreRadioButton
            // 
            this.ucusListeleUcusTarihineGoreRadioButton.AutoSize = true;
            this.ucusListeleUcusTarihineGoreRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusListeleUcusTarihineGoreRadioButton.Location = new System.Drawing.Point(41, 167);
            this.ucusListeleUcusTarihineGoreRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusListeleUcusTarihineGoreRadioButton.Name = "ucusListeleUcusTarihineGoreRadioButton";
            this.ucusListeleUcusTarihineGoreRadioButton.Size = new System.Drawing.Size(120, 29);
            this.ucusListeleUcusTarihineGoreRadioButton.TabIndex = 16;
            this.ucusListeleUcusTarihineGoreRadioButton.TabStop = true;
            this.ucusListeleUcusTarihineGoreRadioButton.Text = "Uçuş Tarihi";
            this.ucusListeleUcusTarihineGoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // ucusListeleUcustarihiAramaTextBox
            // 
            this.ucusListeleUcustarihiAramaTextBox.Location = new System.Drawing.Point(170, 172);
            this.ucusListeleUcustarihiAramaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusListeleUcustarihiAramaTextBox.Name = "ucusListeleUcustarihiAramaTextBox";
            this.ucusListeleUcustarihiAramaTextBox.Size = new System.Drawing.Size(159, 22);
            this.ucusListeleUcustarihiAramaTextBox.TabIndex = 15;
            // 
            // aramaButton
            // 
            this.aramaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aramaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aramaButton.Location = new System.Drawing.Point(840, 98);
            this.aramaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aramaButton.Name = "aramaButton";
            this.aramaButton.Size = new System.Drawing.Size(112, 41);
            this.aramaButton.TabIndex = 14;
            this.aramaButton.Text = "ARA";
            this.aramaButton.UseVisualStyleBackColor = false;
            this.aramaButton.Click += new System.EventHandler(this.aramaButton_Click);
            // 
            // ucusListeleUcusAramaDaGrView
            // 
            this.ucusListeleUcusAramaDaGrView.AutoGenerateColumns = false;
            this.ucusListeleUcusAramaDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucusListeleUcusAramaDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucus_id,
            this.ucus_tarihi,
            this.kalkis_saati,
            this.inis_saati,
            this.ucret});
            this.ucusListeleUcusAramaDaGrView.DataSource = this.ucuslarBindingSource;
            this.ucusListeleUcusAramaDaGrView.Location = new System.Drawing.Point(41, 235);
            this.ucusListeleUcusAramaDaGrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusListeleUcusAramaDaGrView.Name = "ucusListeleUcusAramaDaGrView";
            this.ucusListeleUcusAramaDaGrView.RowHeadersWidth = 51;
            this.ucusListeleUcusAramaDaGrView.Size = new System.Drawing.Size(911, 414);
            this.ucusListeleUcusAramaDaGrView.TabIndex = 13;
            // 
            // ucuslarBindingSource
            // 
            this.ucuslarBindingSource.DataMember = "ucuslar";
            this.ucuslarBindingSource.DataSource = this.sONDataSet5;
            // 
            // sONDataSet5
            // 
            this.sONDataSet5.DataSetName = "SONDataSet5";
            this.sONDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucusListeleUcusIdAramaTextBox
            // 
            this.ucusListeleUcusIdAramaTextBox.Location = new System.Drawing.Point(170, 108);
            this.ucusListeleUcusIdAramaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusListeleUcusIdAramaTextBox.Name = "ucusListeleUcusIdAramaTextBox";
            this.ucusListeleUcusIdAramaTextBox.Size = new System.Drawing.Size(159, 22);
            this.ucusListeleUcusIdAramaTextBox.TabIndex = 12;
            // 
            // ucuslarTableAdapter
            // 
            this.ucuslarTableAdapter.ClearBeforeFill = true;
            // 
            // kalkisHavalimaniUcusListeleComboBox
            // 
            this.kalkisHavalimaniUcusListeleComboBox.DataSource = this.havalimanikBindingSource1;
            this.kalkisHavalimaniUcusListeleComboBox.DisplayMember = "havalimani_adi";
            this.kalkisHavalimaniUcusListeleComboBox.FormattingEnabled = true;
            this.kalkisHavalimaniUcusListeleComboBox.Location = new System.Drawing.Point(552, 108);
            this.kalkisHavalimaniUcusListeleComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kalkisHavalimaniUcusListeleComboBox.Name = "kalkisHavalimaniUcusListeleComboBox";
            this.kalkisHavalimaniUcusListeleComboBox.Size = new System.Drawing.Size(248, 24);
            this.kalkisHavalimaniUcusListeleComboBox.TabIndex = 19;
            this.kalkisHavalimaniUcusListeleComboBox.ValueMember = "havalimani_id";
            // 
            // havalimanikBindingSource1
            // 
            this.havalimanikBindingSource1.DataMember = "havalimani_k";
            this.havalimanikBindingSource1.DataSource = this.sONDataSet;
            // 
            // sONDataSet
            // 
            this.sONDataSet.DataSetName = "SONDataSet";
            this.sONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varisHavalimaniUcusListesiComboBox
            // 
            this.varisHavalimaniUcusListesiComboBox.DataSource = this.havalimanivBindingSource;
            this.varisHavalimaniUcusListesiComboBox.DisplayMember = "havalimani_adi";
            this.varisHavalimaniUcusListesiComboBox.FormattingEnabled = true;
            this.varisHavalimaniUcusListesiComboBox.Location = new System.Drawing.Point(552, 172);
            this.varisHavalimaniUcusListesiComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.varisHavalimaniUcusListesiComboBox.Name = "varisHavalimaniUcusListesiComboBox";
            this.varisHavalimaniUcusListesiComboBox.Size = new System.Drawing.Size(248, 24);
            this.varisHavalimaniUcusListesiComboBox.TabIndex = 20;
            this.varisHavalimaniUcusListesiComboBox.ValueMember = "havalimani_id";
            // 
            // havalimanivBindingSource
            // 
            this.havalimanivBindingSource.DataMember = "havalimani_v";
            this.havalimanivBindingSource.DataSource = this.sONDataSet1BindingSource;
            // 
            // sONDataSet1BindingSource
            // 
            this.sONDataSet1BindingSource.DataSource = this.sONDataSet1;
            this.sONDataSet1BindingSource.Position = 0;
            // 
            // sONDataSet1
            // 
            this.sONDataSet1.DataSetName = "SONDataSet1";
            this.sONDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havalimanikBindingSource
            // 
            this.havalimanikBindingSource.DataMember = "havalimani_k";
            this.havalimanikBindingSource.DataSource = this.sONDataSet;
            // 
            // havalimani_kTableAdapter
            // 
            this.havalimani_kTableAdapter.ClearBeforeFill = true;
            // 
            // havalimani_vTableAdapter
            // 
            this.havalimani_vTableAdapter.ClearBeforeFill = true;
            // 
            // ucus_id
            // 
            this.ucus_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ucus_id.DataPropertyName = "ucus_id";
            this.ucus_id.HeaderText = "Uçuş No.";
            this.ucus_id.MinimumWidth = 6;
            this.ucus_id.Name = "ucus_id";
            this.ucus_id.Width = 91;
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
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F);
            this.label1234.Location = new System.Drawing.Point(391, 30);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(195, 32);
            this.label1234.TabIndex = 21;
            this.label1234.Text = "UÇUŞLARI LİSTELE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UcuslarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1234);
            this.Controls.Add(this.varisHavalimaniUcusListesiComboBox);
            this.Controls.Add(this.kalkisHavalimaniUcusListeleComboBox);
            this.Controls.Add(this.ucusListeleKonumaGoreRadioButton);
            this.Controls.Add(this.ucusListeleUcusIdyeGoreRadioButton);
            this.Controls.Add(this.ucusListeleUcusTarihineGoreRadioButton);
            this.Controls.Add(this.ucusListeleUcustarihiAramaTextBox);
            this.Controls.Add(this.aramaButton);
            this.Controls.Add(this.ucusListeleUcusAramaDaGrView);
            this.Controls.Add(this.ucusListeleUcusIdAramaTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcuslarListesi";
            this.Text = "UcuslarListesi";
            this.Load += new System.EventHandler(this.UcuslarListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucusListeleUcusAramaDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton ucusListeleKonumaGoreRadioButton;
        private System.Windows.Forms.RadioButton ucusListeleUcusIdyeGoreRadioButton;
        private System.Windows.Forms.RadioButton ucusListeleUcusTarihineGoreRadioButton;
        private System.Windows.Forms.TextBox ucusListeleUcustarihiAramaTextBox;
        private System.Windows.Forms.Button aramaButton;
        private System.Windows.Forms.DataGridView ucusListeleUcusAramaDaGrView;
        private System.Windows.Forms.TextBox ucusListeleUcusIdAramaTextBox;
        private SONDataSet5 sONDataSet5;
        private System.Windows.Forms.BindingSource ucuslarBindingSource;
        private SONDataSet5TableAdapters.ucuslarTableAdapter ucuslarTableAdapter;
        private System.Windows.Forms.ComboBox kalkisHavalimaniUcusListeleComboBox;
        private System.Windows.Forms.ComboBox varisHavalimaniUcusListesiComboBox;
        private SONDataSet sONDataSet;
        private System.Windows.Forms.BindingSource havalimanikBindingSource;
        private SONDataSetTableAdapters.havalimani_kTableAdapter havalimani_kTableAdapter;
        private System.Windows.Forms.BindingSource sONDataSet1BindingSource;
        private SONDataSet1 sONDataSet1;
        private System.Windows.Forms.BindingSource havalimanivBindingSource;
        private SONDataSet1TableAdapters.havalimani_vTableAdapter havalimani_vTableAdapter;
        private System.Windows.Forms.BindingSource havalimanikBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucus_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucus_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkis_saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn inis_saati;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.Label label1234;
        private System.Windows.Forms.Button button1;
    }
}