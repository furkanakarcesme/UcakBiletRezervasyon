namespace UcakBiletiRezervasyon
{
    partial class MusteriAra
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
            this.uyeIdAramaTextBox = new System.Windows.Forms.TextBox();
            this.uyeAraDaGrView = new System.Windows.Forms.DataGridView();
            this.kullanici_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailadresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet2 = new UcakBiletiRezervasyon.SONDataSet2();
            this.aramaButton = new System.Windows.Forms.Button();
            this.uyeIsimAramaTextBox = new System.Windows.Forms.TextBox();
            this.uyelerTableAdapter = new UcakBiletiRezervasyon.SONDataSet2TableAdapters.uyelerTableAdapter();
            this.adRadioButton = new System.Windows.Forms.RadioButton();
            this.uyeIdRadioButton = new System.Windows.Forms.RadioButton();
            this.soyadRadioButton = new System.Windows.Forms.RadioButton();
            this.uyeSoyAramaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uyeAraDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeIdAramaTextBox
            // 
            this.uyeIdAramaTextBox.Location = new System.Drawing.Point(123, 125);
            this.uyeIdAramaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeIdAramaTextBox.Name = "uyeIdAramaTextBox";
            this.uyeIdAramaTextBox.Size = new System.Drawing.Size(232, 22);
            this.uyeIdAramaTextBox.TabIndex = 0;
            // 
            // uyeAraDaGrView
            // 
            this.uyeAraDaGrView.AutoGenerateColumns = false;
            this.uyeAraDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeAraDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanici_id,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.kimliknoDataGridViewTextBoxColumn,
            this.dogumtarihiDataGridViewTextBoxColumn,
            this.mailadresiDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.uyeAraDaGrView.DataSource = this.uyelerBindingSource;
            this.uyeAraDaGrView.Location = new System.Drawing.Point(24, 173);
            this.uyeAraDaGrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeAraDaGrView.Name = "uyeAraDaGrView";
            this.uyeAraDaGrView.RowHeadersWidth = 51;
            this.uyeAraDaGrView.Size = new System.Drawing.Size(1257, 415);
            this.uyeAraDaGrView.TabIndex = 2;
            // 
            // kullanici_id
            // 
            this.kullanici_id.DataPropertyName = "kullanici_id";
            this.kullanici_id.HeaderText = "Üye ID";
            this.kullanici_id.MinimumWidth = 6;
            this.kullanici_id.Name = "kullanici_id";
            this.kullanici_id.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // kimliknoDataGridViewTextBoxColumn
            // 
            this.kimliknoDataGridViewTextBoxColumn.DataPropertyName = "kimlik_no";
            this.kimliknoDataGridViewTextBoxColumn.HeaderText = "Kimlik No";
            this.kimliknoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kimliknoDataGridViewTextBoxColumn.Name = "kimliknoDataGridViewTextBoxColumn";
            this.kimliknoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumtarihiDataGridViewTextBoxColumn
            // 
            this.dogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "dogum_tarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumtarihiDataGridViewTextBoxColumn.Name = "dogumtarihiDataGridViewTextBoxColumn";
            this.dogumtarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailadresiDataGridViewTextBoxColumn
            // 
            this.mailadresiDataGridViewTextBoxColumn.DataPropertyName = "mail_adresi";
            this.mailadresiDataGridViewTextBoxColumn.HeaderText = "Mail Adresi";
            this.mailadresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailadresiDataGridViewTextBoxColumn.Name = "mailadresiDataGridViewTextBoxColumn";
            this.mailadresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel. No";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "uyeler";
            this.uyelerBindingSource.DataSource = this.sONDataSet2;
            // 
            // sONDataSet2
            // 
            this.sONDataSet2.DataSetName = "SONDataSet2";
            this.sONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aramaButton
            // 
            this.aramaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aramaButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aramaButton.Location = new System.Drawing.Point(1170, 116);
            this.aramaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aramaButton.Name = "aramaButton";
            this.aramaButton.Size = new System.Drawing.Size(112, 41);
            this.aramaButton.TabIndex = 3;
            this.aramaButton.Text = "ARA";
            this.aramaButton.UseVisualStyleBackColor = false;
            this.aramaButton.Click += new System.EventHandler(this.aramaButton_Click);
            // 
            // uyeIsimAramaTextBox
            // 
            this.uyeIsimAramaTextBox.Location = new System.Drawing.Point(487, 125);
            this.uyeIsimAramaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeIsimAramaTextBox.Name = "uyeIsimAramaTextBox";
            this.uyeIsimAramaTextBox.Size = new System.Drawing.Size(232, 22);
            this.uyeIsimAramaTextBox.TabIndex = 5;
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // adRadioButton
            // 
            this.adRadioButton.AutoSize = true;
            this.adRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.adRadioButton.Location = new System.Drawing.Point(414, 120);
            this.adRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adRadioButton.Name = "adRadioButton";
            this.adRadioButton.Size = new System.Drawing.Size(53, 29);
            this.adRadioButton.TabIndex = 8;
            this.adRadioButton.TabStop = true;
            this.adRadioButton.Text = "Ad";
            this.adRadioButton.UseVisualStyleBackColor = true;
            // 
            // uyeIdRadioButton
            // 
            this.uyeIdRadioButton.AutoSize = true;
            this.uyeIdRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.uyeIdRadioButton.Location = new System.Drawing.Point(24, 120);
            this.uyeIdRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeIdRadioButton.Name = "uyeIdRadioButton";
            this.uyeIdRadioButton.Size = new System.Drawing.Size(81, 29);
            this.uyeIdRadioButton.TabIndex = 9;
            this.uyeIdRadioButton.TabStop = true;
            this.uyeIdRadioButton.Text = "Üye ID";
            this.uyeIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // soyadRadioButton
            // 
            this.soyadRadioButton.AutoSize = true;
            this.soyadRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.soyadRadioButton.Location = new System.Drawing.Point(767, 120);
            this.soyadRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soyadRadioButton.Name = "soyadRadioButton";
            this.soyadRadioButton.Size = new System.Drawing.Size(80, 29);
            this.soyadRadioButton.TabIndex = 10;
            this.soyadRadioButton.TabStop = true;
            this.soyadRadioButton.Text = "Soyad";
            this.soyadRadioButton.UseVisualStyleBackColor = true;
            // 
            // uyeSoyAramaTextBox
            // 
            this.uyeSoyAramaTextBox.Location = new System.Drawing.Point(868, 125);
            this.uyeSoyAramaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeSoyAramaTextBox.Name = "uyeSoyAramaTextBox";
            this.uyeSoyAramaTextBox.Size = new System.Drawing.Size(232, 22);
            this.uyeSoyAramaTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(24, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F);
            this.label1.Location = new System.Drawing.Point(564, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "ÜYE BİLGİSİ ARAMA";
            // 
            // MusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uyeSoyAramaTextBox);
            this.Controls.Add(this.soyadRadioButton);
            this.Controls.Add(this.uyeIdRadioButton);
            this.Controls.Add(this.adRadioButton);
            this.Controls.Add(this.uyeIsimAramaTextBox);
            this.Controls.Add(this.aramaButton);
            this.Controls.Add(this.uyeAraDaGrView);
            this.Controls.Add(this.uyeIdAramaTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriAra";
            this.Text = "Üye Bilgisi Arama";
            this.Load += new System.EventHandler(this.MusteriAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyeAraDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uyeIdAramaTextBox;
        private System.Windows.Forms.DataGridView uyeAraDaGrView;
        private System.Windows.Forms.Button aramaButton;
        private System.Windows.Forms.TextBox uyeIsimAramaTextBox;
        private SONDataSet2 sONDataSet2;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private SONDataSet2TableAdapters.uyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailadresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton adRadioButton;
        private System.Windows.Forms.RadioButton uyeIdRadioButton;
        private System.Windows.Forms.RadioButton soyadRadioButton;
        private System.Windows.Forms.TextBox uyeSoyAramaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}