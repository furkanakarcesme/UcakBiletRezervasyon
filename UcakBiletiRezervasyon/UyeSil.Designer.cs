namespace UcakBiletiRezervasyon
{
    partial class UyeSil
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
            this.uyeIdSilRadioButton = new System.Windows.Forms.RadioButton();
            this.kimlikSilRadioButton = new System.Windows.Forms.RadioButton();
            this.uyeKimlikSilTextBox = new System.Windows.Forms.TextBox();
            this.aramaSButton = new System.Windows.Forms.Button();
            this.uyeSilDaGrView = new System.Windows.Forms.DataGridView();
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
            this.sONDataSet3 = new UcakBiletiRezervasyon.SONDataSet3();
            this.uyeIdSilTextBox = new System.Windows.Forms.TextBox();
            this.uyelerTableAdapter = new UcakBiletiRezervasyon.SONDataSet3TableAdapters.uyelerTableAdapter();
            this.uyeSilLabel = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyeSilDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeIdSilRadioButton
            // 
            this.uyeIdSilRadioButton.AutoSize = true;
            this.uyeIdSilRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.uyeIdSilRadioButton.Location = new System.Drawing.Point(36, 88);
            this.uyeIdSilRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeIdSilRadioButton.Name = "uyeIdSilRadioButton";
            this.uyeIdSilRadioButton.Size = new System.Drawing.Size(81, 29);
            this.uyeIdSilRadioButton.TabIndex = 17;
            this.uyeIdSilRadioButton.TabStop = true;
            this.uyeIdSilRadioButton.Text = "Üye ID";
            this.uyeIdSilRadioButton.UseVisualStyleBackColor = true;
            this.uyeIdSilRadioButton.CheckedChanged += new System.EventHandler(this.uyeIdSilRadioButton_CheckedChanged);
            // 
            // kimlikSilRadioButton
            // 
            this.kimlikSilRadioButton.AutoSize = true;
            this.kimlikSilRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.kimlikSilRadioButton.Location = new System.Drawing.Point(456, 88);
            this.kimlikSilRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kimlikSilRadioButton.Name = "kimlikSilRadioButton";
            this.kimlikSilRadioButton.Size = new System.Drawing.Size(107, 29);
            this.kimlikSilRadioButton.TabIndex = 16;
            this.kimlikSilRadioButton.TabStop = true;
            this.kimlikSilRadioButton.Text = "Kimlik No";
            this.kimlikSilRadioButton.UseVisualStyleBackColor = true;
            this.kimlikSilRadioButton.CheckedChanged += new System.EventHandler(this.kimlikSilRadioButton_CheckedChanged);
            // 
            // uyeKimlikSilTextBox
            // 
            this.uyeKimlikSilTextBox.Location = new System.Drawing.Point(579, 93);
            this.uyeKimlikSilTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeKimlikSilTextBox.Name = "uyeKimlikSilTextBox";
            this.uyeKimlikSilTextBox.Size = new System.Drawing.Size(232, 22);
            this.uyeKimlikSilTextBox.TabIndex = 15;
            this.uyeKimlikSilTextBox.TextChanged += new System.EventHandler(this.uyeKimlikSilTextBox_TextChanged);
            // 
            // aramaSButton
            // 
            this.aramaSButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aramaSButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaSButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aramaSButton.Location = new System.Drawing.Point(1037, 88);
            this.aramaSButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aramaSButton.Name = "aramaSButton";
            this.aramaSButton.Size = new System.Drawing.Size(115, 34);
            this.aramaSButton.TabIndex = 14;
            this.aramaSButton.Text = "ARA";
            this.aramaSButton.UseVisualStyleBackColor = false;
            this.aramaSButton.Click += new System.EventHandler(this.aramaSButton_Click);
            // 
            // uyeSilDaGrView
            // 
            this.uyeSilDaGrView.AutoGenerateColumns = false;
            this.uyeSilDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeSilDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanici_id,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.kimliknoDataGridViewTextBoxColumn,
            this.dogumtarihiDataGridViewTextBoxColumn,
            this.mailadresiDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.uyeSilDaGrView.DataSource = this.uyelerBindingSource;
            this.uyeSilDaGrView.Location = new System.Drawing.Point(36, 141);
            this.uyeSilDaGrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeSilDaGrView.Name = "uyeSilDaGrView";
            this.uyeSilDaGrView.RowHeadersWidth = 51;
            this.uyeSilDaGrView.Size = new System.Drawing.Size(1257, 389);
            this.uyeSilDaGrView.TabIndex = 13;
            this.uyeSilDaGrView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uyeSilDaGrView_CellContentClick);
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
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
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
            this.uyelerBindingSource.DataSource = this.sONDataSet3;
            // 
            // sONDataSet3
            // 
            this.sONDataSet3.DataSetName = "SONDataSet3";
            this.sONDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeIdSilTextBox
            // 
            this.uyeIdSilTextBox.Location = new System.Drawing.Point(135, 93);
            this.uyeIdSilTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uyeIdSilTextBox.Name = "uyeIdSilTextBox";
            this.uyeIdSilTextBox.Size = new System.Drawing.Size(232, 22);
            this.uyeIdSilTextBox.TabIndex = 12;
            this.uyeIdSilTextBox.TextChanged += new System.EventHandler(this.uyeIdSilTextBox_TextChanged);
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // uyeSilLabel
            // 
            this.uyeSilLabel.AutoSize = true;
            this.uyeSilLabel.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 17F);
            this.uyeSilLabel.Location = new System.Drawing.Point(617, 21);
            this.uyeSilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uyeSilLabel.Name = "uyeSilLabel";
            this.uyeSilLabel.Size = new System.Drawing.Size(101, 37);
            this.uyeSilLabel.TabIndex = 20;
            this.uyeSilLabel.Text = "ÜYE SİL";
            this.uyeSilLabel.Click += new System.EventHandler(this.uyeSilLabel_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silButton.Location = new System.Drawing.Point(1179, 88);
            this.silButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(115, 34);
            this.silButton.TabIndex = 21;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UyeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.uyeSilLabel);
            this.Controls.Add(this.uyeIdSilRadioButton);
            this.Controls.Add(this.kimlikSilRadioButton);
            this.Controls.Add(this.uyeKimlikSilTextBox);
            this.Controls.Add(this.aramaSButton);
            this.Controls.Add(this.uyeSilDaGrView);
            this.Controls.Add(this.uyeIdSilTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UyeSil";
            this.Text = "Admin - Üye Sil";
            this.Load += new System.EventHandler(this.UyeSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyeSilDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton uyeIdSilRadioButton;
        private System.Windows.Forms.RadioButton kimlikSilRadioButton;
        private System.Windows.Forms.TextBox uyeKimlikSilTextBox;
        private System.Windows.Forms.Button aramaSButton;
        private System.Windows.Forms.DataGridView uyeSilDaGrView;
        private System.Windows.Forms.TextBox uyeIdSilTextBox;
        private SONDataSet3 sONDataSet3;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private SONDataSet3TableAdapters.uyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailadresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label uyeSilLabel;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button button1;
    }
}