namespace UcakBiletiRezervasyon
{
    partial class BiletRezervasyonu
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
            this.neredenResLabel = new System.Windows.Forms.Label();
            this.nereyeResLabel = new System.Windows.Forms.Label();
            this.showFlightsButton = new System.Windows.Forms.Button();
            this.ucuslarDataGridView = new System.Windows.Forms.DataGridView();
            this.uyeKimlikResLabel = new System.Windows.Forms.Label();
            this.uyeAdResLabel = new System.Windows.Forms.Label();
            this.uyeSoyadResLabel = new System.Windows.Forms.Label();
            this.uyeDogumResLabel = new System.Windows.Forms.Label();
            this.uyeMailResLabel = new System.Windows.Forms.Label();
            this.uyeTelResLabel = new System.Windows.Forms.Label();
            this.uyeAdresResLabel = new System.Windows.Forms.Label();
            this.ucusTarihLabel = new System.Windows.Forms.Label();
            this.ucusNoLabel = new System.Windows.Forms.Label();
            this.koltukNoLabel = new System.Windows.Forms.Label();
            this.kimlikResText = new System.Windows.Forms.TextBox();
            this.uyeAdResText = new System.Windows.Forms.TextBox();
            this.uyeSoyResText = new System.Windows.Forms.TextBox();
            this.uyeMailResText = new System.Windows.Forms.TextBox();
            this.uyeTelResText = new System.Windows.Forms.TextBox();
            this.kalkisSaatiResText = new System.Windows.Forms.TextBox();
            this.uyeAdresResText = new System.Windows.Forms.TextBox();
            this.ucretResText = new System.Windows.Forms.TextBox();
            this.resevasyonuTamamlaButton = new System.Windows.Forms.Button();
            this.uyeBilgisiGetirButton = new System.Windows.Forms.Button();
            this.odev2DataSet4 = new UcakBiletiRezervasyon.odev2DataSet4();
            this.havalimanlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.havalimanlariTableAdapter = new UcakBiletiRezervasyon.odev2DataSet4TableAdapters.havalimanlariTableAdapter();
            this.odev2DataSet5 = new UcakBiletiRezervasyon.odev2DataSet5();
            this.havalimanlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.havalimanlariTableAdapter1 = new UcakBiletiRezervasyon.odev2DataSet5TableAdapters.havalimanlariTableAdapter();
            this.dogumTarihiResText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.odev2DataSet6 = new UcakBiletiRezervasyon.odev2DataSet6();
            this.havalimanlariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.havalimanlariTableAdapter2 = new UcakBiletiRezervasyon.odev2DataSet6TableAdapters.havalimanlariTableAdapter();
            this.odev2DataSet7 = new UcakBiletiRezervasyon.odev2DataSet7();
            this.havalimanlariBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.havalimanlariTableAdapter3 = new UcakBiletiRezervasyon.odev2DataSet7TableAdapters.havalimanlariTableAdapter();
            this.uyeUcusTarihiResText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // neredenResLabel
            // 
            this.neredenResLabel.AutoSize = true;
            this.neredenResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.neredenResLabel.Location = new System.Drawing.Point(25, 25);
            this.neredenResLabel.Name = "neredenResLabel";
            this.neredenResLabel.Size = new System.Drawing.Size(57, 20);
            this.neredenResLabel.TabIndex = 0;
            this.neredenResLabel.Text = "Nereden";
            // 
            // nereyeResLabel
            // 
            this.nereyeResLabel.AutoSize = true;
            this.nereyeResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nereyeResLabel.Location = new System.Drawing.Point(282, 25);
            this.nereyeResLabel.Name = "nereyeResLabel";
            this.nereyeResLabel.Size = new System.Drawing.Size(48, 20);
            this.nereyeResLabel.TabIndex = 1;
            this.nereyeResLabel.Text = "Nereye";
            // 
            // showFlightsButton
            // 
            this.showFlightsButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showFlightsButton.Location = new System.Drawing.Point(537, 23);
            this.showFlightsButton.Name = "showFlightsButton";
            this.showFlightsButton.Size = new System.Drawing.Size(75, 29);
            this.showFlightsButton.TabIndex = 2;
            this.showFlightsButton.Text = "Göster";
            this.showFlightsButton.UseVisualStyleBackColor = true;
            this.showFlightsButton.Click += new System.EventHandler(this.showFlightsButton_Click);
            // 
            // ucuslarDataGridView
            // 
            this.ucuslarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucuslarDataGridView.Location = new System.Drawing.Point(29, 74);
            this.ucuslarDataGridView.Name = "ucuslarDataGridView";
            this.ucuslarDataGridView.Size = new System.Drawing.Size(583, 619);
            this.ucuslarDataGridView.TabIndex = 3;
            this.ucuslarDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ucuslarDataGridView_CellEnter);
            // 
            // uyeKimlikResLabel
            // 
            this.uyeKimlikResLabel.AutoSize = true;
            this.uyeKimlikResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeKimlikResLabel.Location = new System.Drawing.Point(668, 85);
            this.uyeKimlikResLabel.Name = "uyeKimlikResLabel";
            this.uyeKimlikResLabel.Size = new System.Drawing.Size(103, 20);
            this.uyeKimlikResLabel.TabIndex = 4;
            this.uyeKimlikResLabel.Text = "Kimlik Numarası";
            // 
            // uyeAdResLabel
            // 
            this.uyeAdResLabel.AutoSize = true;
            this.uyeAdResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeAdResLabel.Location = new System.Drawing.Point(668, 137);
            this.uyeAdResLabel.Name = "uyeAdResLabel";
            this.uyeAdResLabel.Size = new System.Drawing.Size(48, 20);
            this.uyeAdResLabel.TabIndex = 5;
            this.uyeAdResLabel.Text = "Üye Ad";
            this.uyeAdResLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // uyeSoyadResLabel
            // 
            this.uyeSoyadResLabel.AutoSize = true;
            this.uyeSoyadResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeSoyadResLabel.Location = new System.Drawing.Point(668, 191);
            this.uyeSoyadResLabel.Name = "uyeSoyadResLabel";
            this.uyeSoyadResLabel.Size = new System.Drawing.Size(67, 20);
            this.uyeSoyadResLabel.TabIndex = 6;
            this.uyeSoyadResLabel.Text = "Üye Soyad";
            // 
            // uyeDogumResLabel
            // 
            this.uyeDogumResLabel.AutoSize = true;
            this.uyeDogumResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeDogumResLabel.Location = new System.Drawing.Point(668, 242);
            this.uyeDogumResLabel.Name = "uyeDogumResLabel";
            this.uyeDogumResLabel.Size = new System.Drawing.Size(84, 20);
            this.uyeDogumResLabel.TabIndex = 7;
            this.uyeDogumResLabel.Text = "Doğum Tarihi";
            // 
            // uyeMailResLabel
            // 
            this.uyeMailResLabel.AutoSize = true;
            this.uyeMailResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeMailResLabel.Location = new System.Drawing.Point(668, 294);
            this.uyeMailResLabel.Name = "uyeMailResLabel";
            this.uyeMailResLabel.Size = new System.Drawing.Size(46, 20);
            this.uyeMailResLabel.TabIndex = 8;
            this.uyeMailResLabel.Text = "E-Mail";
            // 
            // uyeTelResLabel
            // 
            this.uyeTelResLabel.AutoSize = true;
            this.uyeTelResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeTelResLabel.Location = new System.Drawing.Point(668, 344);
            this.uyeTelResLabel.Name = "uyeTelResLabel";
            this.uyeTelResLabel.Size = new System.Drawing.Size(108, 20);
            this.uyeTelResLabel.TabIndex = 9;
            this.uyeTelResLabel.Text = "Telefon Numarası";
            // 
            // uyeAdresResLabel
            // 
            this.uyeAdresResLabel.AutoSize = true;
            this.uyeAdresResLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeAdresResLabel.Location = new System.Drawing.Point(668, 395);
            this.uyeAdresResLabel.Name = "uyeAdresResLabel";
            this.uyeAdresResLabel.Size = new System.Drawing.Size(42, 20);
            this.uyeAdresResLabel.TabIndex = 10;
            this.uyeAdresResLabel.Text = "Adres";
            // 
            // ucusTarihLabel
            // 
            this.ucusTarihLabel.AutoSize = true;
            this.ucusTarihLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucusTarihLabel.Location = new System.Drawing.Point(668, 490);
            this.ucusTarihLabel.Name = "ucusTarihLabel";
            this.ucusTarihLabel.Size = new System.Drawing.Size(74, 20);
            this.ucusTarihLabel.TabIndex = 11;
            this.ucusTarihLabel.Text = "Uçuş Tarihi";
            // 
            // ucusNoLabel
            // 
            this.ucusNoLabel.AutoSize = true;
            this.ucusNoLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucusNoLabel.Location = new System.Drawing.Point(668, 542);
            this.ucusNoLabel.Name = "ucusNoLabel";
            this.ucusNoLabel.Size = new System.Drawing.Size(79, 20);
            this.ucusNoLabel.TabIndex = 12;
            this.ucusNoLabel.Text = "Kalkış Saati";
            // 
            // koltukNoLabel
            // 
            this.koltukNoLabel.AutoSize = true;
            this.koltukNoLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.koltukNoLabel.Location = new System.Drawing.Point(668, 595);
            this.koltukNoLabel.Name = "koltukNoLabel";
            this.koltukNoLabel.Size = new System.Drawing.Size(42, 20);
            this.koltukNoLabel.TabIndex = 13;
            this.koltukNoLabel.Text = "Ücret";
            // 
            // kimlikResText
            // 
            this.kimlikResText.Location = new System.Drawing.Point(826, 85);
            this.kimlikResText.Name = "kimlikResText";
            this.kimlikResText.Size = new System.Drawing.Size(213, 20);
            this.kimlikResText.TabIndex = 15;
            // 
            // uyeAdResText
            // 
            this.uyeAdResText.Location = new System.Drawing.Point(826, 137);
            this.uyeAdResText.Name = "uyeAdResText";
            this.uyeAdResText.Size = new System.Drawing.Size(213, 20);
            this.uyeAdResText.TabIndex = 16;
            // 
            // uyeSoyResText
            // 
            this.uyeSoyResText.Location = new System.Drawing.Point(826, 191);
            this.uyeSoyResText.Name = "uyeSoyResText";
            this.uyeSoyResText.Size = new System.Drawing.Size(213, 20);
            this.uyeSoyResText.TabIndex = 17;
            // 
            // uyeMailResText
            // 
            this.uyeMailResText.Location = new System.Drawing.Point(826, 294);
            this.uyeMailResText.Name = "uyeMailResText";
            this.uyeMailResText.Size = new System.Drawing.Size(213, 20);
            this.uyeMailResText.TabIndex = 18;
            // 
            // uyeTelResText
            // 
            this.uyeTelResText.Location = new System.Drawing.Point(826, 344);
            this.uyeTelResText.Name = "uyeTelResText";
            this.uyeTelResText.Size = new System.Drawing.Size(213, 20);
            this.uyeTelResText.TabIndex = 19;
            // 
            // kalkisSaatiResText
            // 
            this.kalkisSaatiResText.Location = new System.Drawing.Point(826, 542);
            this.kalkisSaatiResText.Name = "kalkisSaatiResText";
            this.kalkisSaatiResText.Size = new System.Drawing.Size(213, 20);
            this.kalkisSaatiResText.TabIndex = 20;
            // 
            // uyeAdresResText
            // 
            this.uyeAdresResText.Location = new System.Drawing.Point(826, 395);
            this.uyeAdresResText.Multiline = true;
            this.uyeAdresResText.Name = "uyeAdresResText";
            this.uyeAdresResText.Size = new System.Drawing.Size(213, 67);
            this.uyeAdresResText.TabIndex = 20;
            // 
            // ucretResText
            // 
            this.ucretResText.Location = new System.Drawing.Point(826, 595);
            this.ucretResText.Name = "ucretResText";
            this.ucretResText.Size = new System.Drawing.Size(213, 20);
            this.ucretResText.TabIndex = 22;
            // 
            // resevasyonuTamamlaButton
            // 
            this.resevasyonuTamamlaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resevasyonuTamamlaButton.Location = new System.Drawing.Point(826, 659);
            this.resevasyonuTamamlaButton.Name = "resevasyonuTamamlaButton";
            this.resevasyonuTamamlaButton.Size = new System.Drawing.Size(213, 34);
            this.resevasyonuTamamlaButton.TabIndex = 23;
            this.resevasyonuTamamlaButton.Text = "Rezervasyonu Tamamla";
            this.resevasyonuTamamlaButton.UseVisualStyleBackColor = true;
            // 
            // uyeBilgisiGetirButton
            // 
            this.uyeBilgisiGetirButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeBilgisiGetirButton.Location = new System.Drawing.Point(1092, 78);
            this.uyeBilgisiGetirButton.Name = "uyeBilgisiGetirButton";
            this.uyeBilgisiGetirButton.Size = new System.Drawing.Size(146, 35);
            this.uyeBilgisiGetirButton.TabIndex = 24;
            this.uyeBilgisiGetirButton.Text = "Üye Bilgilerini Getir";
            this.uyeBilgisiGetirButton.UseVisualStyleBackColor = true;
            this.uyeBilgisiGetirButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // odev2DataSet4
            // 
            this.odev2DataSet4.DataSetName = "odev2DataSet4";
            this.odev2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havalimanlariBindingSource
            // 
            this.havalimanlariBindingSource.DataMember = "havalimanlari";
            this.havalimanlariBindingSource.DataSource = this.odev2DataSet4;
            // 
            // havalimanlariTableAdapter
            // 
            this.havalimanlariTableAdapter.ClearBeforeFill = true;
            // 
            // odev2DataSet5
            // 
            this.odev2DataSet5.DataSetName = "odev2DataSet5";
            this.odev2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havalimanlariBindingSource1
            // 
            this.havalimanlariBindingSource1.DataMember = "havalimanlari";
            this.havalimanlariBindingSource1.DataSource = this.odev2DataSet5;
            // 
            // havalimanlariTableAdapter1
            // 
            this.havalimanlariTableAdapter1.ClearBeforeFill = true;
            // 
            // dogumTarihiResText
            // 
            this.dogumTarihiResText.Location = new System.Drawing.Point(826, 243);
            this.dogumTarihiResText.Name = "dogumTarihiResText";
            this.dogumTarihiResText.Size = new System.Drawing.Size(213, 20);
            this.dogumTarihiResText.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.havalimanlariBindingSource2;
            this.comboBox1.DisplayMember = "Sehirler";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Kimlik";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.havalimanlariBindingSource3;
            this.comboBox2.DisplayMember = "Sehirler";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(336, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "Kimlik";
            // 
            // odev2DataSet6
            // 
            this.odev2DataSet6.DataSetName = "odev2DataSet6";
            this.odev2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havalimanlariBindingSource2
            // 
            this.havalimanlariBindingSource2.DataMember = "havalimanlari";
            this.havalimanlariBindingSource2.DataSource = this.odev2DataSet6;
            // 
            // havalimanlariTableAdapter2
            // 
            this.havalimanlariTableAdapter2.ClearBeforeFill = true;
            // 
            // odev2DataSet7
            // 
            this.odev2DataSet7.DataSetName = "odev2DataSet7";
            this.odev2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havalimanlariBindingSource3
            // 
            this.havalimanlariBindingSource3.DataMember = "havalimanlari";
            this.havalimanlariBindingSource3.DataSource = this.odev2DataSet7;
            // 
            // havalimanlariTableAdapter3
            // 
            this.havalimanlariTableAdapter3.ClearBeforeFill = true;
            // 
            // uyeUcusTarihiResText
            // 
            this.uyeUcusTarihiResText.Location = new System.Drawing.Point(826, 491);
            this.uyeUcusTarihiResText.Name = "uyeUcusTarihiResText";
            this.uyeUcusTarihiResText.Size = new System.Drawing.Size(213, 20);
            this.uyeUcusTarihiResText.TabIndex = 31;
            // 
            // BiletRezervasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 730);
            this.Controls.Add(this.uyeUcusTarihiResText);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dogumTarihiResText);
            this.Controls.Add(this.uyeBilgisiGetirButton);
            this.Controls.Add(this.resevasyonuTamamlaButton);
            this.Controls.Add(this.ucretResText);
            this.Controls.Add(this.uyeAdresResText);
            this.Controls.Add(this.kalkisSaatiResText);
            this.Controls.Add(this.uyeTelResText);
            this.Controls.Add(this.uyeMailResText);
            this.Controls.Add(this.uyeSoyResText);
            this.Controls.Add(this.uyeAdResText);
            this.Controls.Add(this.kimlikResText);
            this.Controls.Add(this.koltukNoLabel);
            this.Controls.Add(this.ucusNoLabel);
            this.Controls.Add(this.ucusTarihLabel);
            this.Controls.Add(this.uyeAdresResLabel);
            this.Controls.Add(this.uyeTelResLabel);
            this.Controls.Add(this.uyeMailResLabel);
            this.Controls.Add(this.uyeDogumResLabel);
            this.Controls.Add(this.uyeSoyadResLabel);
            this.Controls.Add(this.uyeAdResLabel);
            this.Controls.Add(this.uyeKimlikResLabel);
            this.Controls.Add(this.ucuslarDataGridView);
            this.Controls.Add(this.showFlightsButton);
            this.Controls.Add(this.nereyeResLabel);
            this.Controls.Add(this.neredenResLabel);
            this.Name = "BiletRezervasyonu";
            this.Text = "Bilet Rezervasyonu";
            this.Load += new System.EventHandler(this.BiletRezervasyonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlariBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label neredenResLabel;
        private System.Windows.Forms.Label nereyeResLabel;
        private System.Windows.Forms.Button showFlightsButton;
        private System.Windows.Forms.DataGridView ucuslarDataGridView;
        private System.Windows.Forms.Label uyeKimlikResLabel;
        private System.Windows.Forms.Label uyeAdResLabel;
        private System.Windows.Forms.Label uyeSoyadResLabel;
        private System.Windows.Forms.Label uyeDogumResLabel;
        private System.Windows.Forms.Label uyeMailResLabel;
        private System.Windows.Forms.Label uyeTelResLabel;
        private System.Windows.Forms.Label uyeAdresResLabel;
        private System.Windows.Forms.Label ucusTarihLabel;
        private System.Windows.Forms.Label ucusNoLabel;
        private System.Windows.Forms.Label koltukNoLabel;
        private System.Windows.Forms.TextBox kimlikResText;
        private System.Windows.Forms.TextBox uyeAdResText;
        private System.Windows.Forms.TextBox uyeSoyResText;
        private System.Windows.Forms.TextBox uyeMailResText;
        private System.Windows.Forms.TextBox uyeTelResText;
        private System.Windows.Forms.TextBox kalkisSaatiResText;
        private System.Windows.Forms.TextBox uyeAdresResText;
        private System.Windows.Forms.TextBox ucretResText;
        private System.Windows.Forms.Button resevasyonuTamamlaButton;
        private System.Windows.Forms.Button uyeBilgisiGetirButton;
        private odev2DataSet4 odev2DataSet4;
        private System.Windows.Forms.BindingSource havalimanlariBindingSource;
        private odev2DataSet4TableAdapters.havalimanlariTableAdapter havalimanlariTableAdapter;
        private odev2DataSet5 odev2DataSet5;
        private System.Windows.Forms.BindingSource havalimanlariBindingSource1;
        private odev2DataSet5TableAdapters.havalimanlariTableAdapter havalimanlariTableAdapter1;
        private System.Windows.Forms.TextBox dogumTarihiResText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private odev2DataSet6 odev2DataSet6;
        private System.Windows.Forms.BindingSource havalimanlariBindingSource2;
        private odev2DataSet6TableAdapters.havalimanlariTableAdapter havalimanlariTableAdapter2;
        private odev2DataSet7 odev2DataSet7;
        private System.Windows.Forms.BindingSource havalimanlariBindingSource3;
        private odev2DataSet7TableAdapters.havalimanlariTableAdapter havalimanlariTableAdapter3;
        private System.Windows.Forms.TextBox uyeUcusTarihiResText;
    }
}