namespace UcakBiletiRezervasyon
{
    partial class UcusuSil
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
            this.ucusSilButton = new System.Windows.Forms.Button();
            this.ucusIdSilRadioButton = new System.Windows.Forms.RadioButton();
            this.ucusTarihiSilRadioButton = new System.Windows.Forms.RadioButton();
            this.ucusTarihiSilTextBox = new System.Windows.Forms.TextBox();
            this.aramaUcusSilButton = new System.Windows.Forms.Button();
            this.ucusSilAdminDaGrView = new System.Windows.Forms.DataGridView();
            this.ucus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucustarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucuslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet4 = new UcakBiletiRezervasyon.SONDataSet4();
            this.ucusIdSilTextBox = new System.Windows.Forms.TextBox();
            this.ucuslarTableAdapter = new UcakBiletiRezervasyon.SONDataSet4TableAdapters.ucuslarTableAdapter();
            this.varisHavalimaniUcusSilComboBox = new System.Windows.Forms.ComboBox();
            this.havalimanivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet9 = new UcakBiletiRezervasyon.SONDataSet9();
            this.kalkisHavalimaniUcusSilComboBox = new System.Windows.Forms.ComboBox();
            this.havalimanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONDataSet8 = new UcakBiletiRezervasyon.SONDataSet8();
            this.ucusSilKonumaGoreRadioButton = new System.Windows.Forms.RadioButton();
            this.havalimani_kTableAdapter = new UcakBiletiRezervasyon.SONDataSet8TableAdapters.havalimani_kTableAdapter();
            this.havalimani_vTableAdapter = new UcakBiletiRezervasyon.SONDataSet9TableAdapters.havalimani_vTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ucusSilAdminDaGrView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // ucusSilButton
            // 
            this.ucusSilButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucusSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucusSilButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucusSilButton.Location = new System.Drawing.Point(888, 162);
            this.ucusSilButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusSilButton.Name = "ucusSilButton";
            this.ucusSilButton.Size = new System.Drawing.Size(115, 34);
            this.ucusSilButton.TabIndex = 29;
            this.ucusSilButton.Text = "SİL";
            this.ucusSilButton.UseVisualStyleBackColor = false;
            this.ucusSilButton.Click += new System.EventHandler(this.ucusSilButton_Click);
            // 
            // ucusIdSilRadioButton
            // 
            this.ucusIdSilRadioButton.AutoSize = true;
            this.ucusIdSilRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusIdSilRadioButton.Location = new System.Drawing.Point(12, 114);
            this.ucusIdSilRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusIdSilRadioButton.Name = "ucusIdSilRadioButton";
            this.ucusIdSilRadioButton.Size = new System.Drawing.Size(92, 29);
            this.ucusIdSilRadioButton.TabIndex = 27;
            this.ucusIdSilRadioButton.TabStop = true;
            this.ucusIdSilRadioButton.Text = "Uçuş ID";
            this.ucusIdSilRadioButton.UseVisualStyleBackColor = true;
            // 
            // ucusTarihiSilRadioButton
            // 
            this.ucusTarihiSilRadioButton.AutoSize = true;
            this.ucusTarihiSilRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusTarihiSilRadioButton.Location = new System.Drawing.Point(12, 162);
            this.ucusTarihiSilRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusTarihiSilRadioButton.Name = "ucusTarihiSilRadioButton";
            this.ucusTarihiSilRadioButton.Size = new System.Drawing.Size(120, 29);
            this.ucusTarihiSilRadioButton.TabIndex = 26;
            this.ucusTarihiSilRadioButton.TabStop = true;
            this.ucusTarihiSilRadioButton.Text = "Uçuş Tarihi";
            this.ucusTarihiSilRadioButton.UseVisualStyleBackColor = true;
            // 
            // ucusTarihiSilTextBox
            // 
            this.ucusTarihiSilTextBox.Location = new System.Drawing.Point(160, 167);
            this.ucusTarihiSilTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusTarihiSilTextBox.Name = "ucusTarihiSilTextBox";
            this.ucusTarihiSilTextBox.Size = new System.Drawing.Size(232, 22);
            this.ucusTarihiSilTextBox.TabIndex = 25;
            // 
            // aramaUcusSilButton
            // 
            this.aramaUcusSilButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aramaUcusSilButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaUcusSilButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aramaUcusSilButton.Location = new System.Drawing.Point(888, 109);
            this.aramaUcusSilButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aramaUcusSilButton.Name = "aramaUcusSilButton";
            this.aramaUcusSilButton.Size = new System.Drawing.Size(115, 34);
            this.aramaUcusSilButton.TabIndex = 24;
            this.aramaUcusSilButton.Text = "ARA";
            this.aramaUcusSilButton.UseVisualStyleBackColor = false;
            this.aramaUcusSilButton.Click += new System.EventHandler(this.aramaUcusSilButton_Click);
            // 
            // ucusSilAdminDaGrView
            // 
            this.ucusSilAdminDaGrView.AutoGenerateColumns = false;
            this.ucusSilAdminDaGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucusSilAdminDaGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ucus_id,
            this.ucustarihiDataGridViewTextBoxColumn,
            this.kalkissaatiDataGridViewTextBoxColumn,
            this.inissaatiDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.ucusSilAdminDaGrView.DataSource = this.ucuslarBindingSource;
            this.ucusSilAdminDaGrView.Location = new System.Drawing.Point(12, 219);
            this.ucusSilAdminDaGrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusSilAdminDaGrView.Name = "ucusSilAdminDaGrView";
            this.ucusSilAdminDaGrView.RowHeadersWidth = 51;
            this.ucusSilAdminDaGrView.Size = new System.Drawing.Size(991, 389);
            this.ucusSilAdminDaGrView.TabIndex = 23;
            this.ucusSilAdminDaGrView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ucusSilAdminDaGrView_CellEnter);
            // 
            // ucus_id
            // 
            this.ucus_id.DataPropertyName = "ucus_id";
            this.ucus_id.HeaderText = "Uçuş No.";
            this.ucus_id.MinimumWidth = 6;
            this.ucus_id.Name = "ucus_id";
            this.ucus_id.Width = 125;
            // 
            // ucustarihiDataGridViewTextBoxColumn
            // 
            this.ucustarihiDataGridViewTextBoxColumn.DataPropertyName = "ucus_tarihi";
            this.ucustarihiDataGridViewTextBoxColumn.HeaderText = "Uçuş Tarihi";
            this.ucustarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucustarihiDataGridViewTextBoxColumn.Name = "ucustarihiDataGridViewTextBoxColumn";
            this.ucustarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalkissaatiDataGridViewTextBoxColumn
            // 
            this.kalkissaatiDataGridViewTextBoxColumn.DataPropertyName = "kalkis_saati";
            this.kalkissaatiDataGridViewTextBoxColumn.HeaderText = "Kalkış Saati";
            this.kalkissaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkissaatiDataGridViewTextBoxColumn.Name = "kalkissaatiDataGridViewTextBoxColumn";
            this.kalkissaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // inissaatiDataGridViewTextBoxColumn
            // 
            this.inissaatiDataGridViewTextBoxColumn.DataPropertyName = "inis_saati";
            this.inissaatiDataGridViewTextBoxColumn.HeaderText = "İniş Saati";
            this.inissaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inissaatiDataGridViewTextBoxColumn.Name = "inissaatiDataGridViewTextBoxColumn";
            this.inissaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ücret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucuslarBindingSource
            // 
            this.ucuslarBindingSource.DataMember = "ucuslar";
            this.ucuslarBindingSource.DataSource = this.sONDataSet4;
            // 
            // sONDataSet4
            // 
            this.sONDataSet4.DataSetName = "SONDataSet4";
            this.sONDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucusIdSilTextBox
            // 
            this.ucusIdSilTextBox.Location = new System.Drawing.Point(160, 119);
            this.ucusIdSilTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusIdSilTextBox.Name = "ucusIdSilTextBox";
            this.ucusIdSilTextBox.Size = new System.Drawing.Size(232, 22);
            this.ucusIdSilTextBox.TabIndex = 22;
            // 
            // ucuslarTableAdapter
            // 
            this.ucuslarTableAdapter.ClearBeforeFill = true;
            // 
            // varisHavalimaniUcusSilComboBox
            // 
            this.varisHavalimaniUcusSilComboBox.DataSource = this.havalimanivBindingSource;
            this.varisHavalimaniUcusSilComboBox.DisplayMember = "havalimani_adi";
            this.varisHavalimaniUcusSilComboBox.FormattingEnabled = true;
            this.varisHavalimaniUcusSilComboBox.Location = new System.Drawing.Point(580, 166);
            this.varisHavalimaniUcusSilComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.varisHavalimaniUcusSilComboBox.Name = "varisHavalimaniUcusSilComboBox";
            this.varisHavalimaniUcusSilComboBox.Size = new System.Drawing.Size(248, 24);
            this.varisHavalimaniUcusSilComboBox.TabIndex = 32;
            this.varisHavalimaniUcusSilComboBox.ValueMember = "havalimani_id";
            // 
            // havalimanivBindingSource
            // 
            this.havalimanivBindingSource.DataMember = "havalimani_v";
            this.havalimanivBindingSource.DataSource = this.sONDataSet9;
            // 
            // sONDataSet9
            // 
            this.sONDataSet9.DataSetName = "SONDataSet9";
            this.sONDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalkisHavalimaniUcusSilComboBox
            // 
            this.kalkisHavalimaniUcusSilComboBox.DataSource = this.havalimanikBindingSource;
            this.kalkisHavalimaniUcusSilComboBox.DisplayMember = "havalimani_adi";
            this.kalkisHavalimaniUcusSilComboBox.FormattingEnabled = true;
            this.kalkisHavalimaniUcusSilComboBox.Location = new System.Drawing.Point(580, 118);
            this.kalkisHavalimaniUcusSilComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kalkisHavalimaniUcusSilComboBox.Name = "kalkisHavalimaniUcusSilComboBox";
            this.kalkisHavalimaniUcusSilComboBox.Size = new System.Drawing.Size(248, 24);
            this.kalkisHavalimaniUcusSilComboBox.TabIndex = 31;
            this.kalkisHavalimaniUcusSilComboBox.ValueMember = "havalimani_id";
            // 
            // havalimanikBindingSource
            // 
            this.havalimanikBindingSource.DataMember = "havalimani_k";
            this.havalimanikBindingSource.DataSource = this.sONDataSet8;
            // 
            // sONDataSet8
            // 
            this.sONDataSet8.DataSetName = "SONDataSet8";
            this.sONDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucusSilKonumaGoreRadioButton
            // 
            this.ucusSilKonumaGoreRadioButton.AutoSize = true;
            this.ucusSilKonumaGoreRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.ucusSilKonumaGoreRadioButton.Location = new System.Drawing.Point(424, 115);
            this.ucusSilKonumaGoreRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucusSilKonumaGoreRadioButton.Name = "ucusSilKonumaGoreRadioButton";
            this.ucusSilKonumaGoreRadioButton.Size = new System.Drawing.Size(139, 29);
            this.ucusSilKonumaGoreRadioButton.TabIndex = 30;
            this.ucusSilKonumaGoreRadioButton.TabStop = true;
            this.ucusSilKonumaGoreRadioButton.Text = "Konuma Göre";
            this.ucusSilKonumaGoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // havalimani_kTableAdapter
            // 
            this.havalimani_kTableAdapter.ClearBeforeFill = true;
            // 
            // havalimani_vTableAdapter
            // 
            this.havalimani_vTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15F);
            this.label1.Location = new System.Drawing.Point(444, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "UÇUŞU SİL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 34;
            this.button1.Text = "G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UcusuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varisHavalimaniUcusSilComboBox);
            this.Controls.Add(this.kalkisHavalimaniUcusSilComboBox);
            this.Controls.Add(this.ucusSilKonumaGoreRadioButton);
            this.Controls.Add(this.ucusSilButton);
            this.Controls.Add(this.ucusIdSilRadioButton);
            this.Controls.Add(this.ucusTarihiSilRadioButton);
            this.Controls.Add(this.ucusTarihiSilTextBox);
            this.Controls.Add(this.aramaUcusSilButton);
            this.Controls.Add(this.ucusSilAdminDaGrView);
            this.Controls.Add(this.ucusIdSilTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcusuSil";
            this.Text = "Uçuş Sil";
            this.Load += new System.EventHandler(this.UcusuSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucusSilAdminDaGrView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ucusSilButton;
        private System.Windows.Forms.RadioButton ucusIdSilRadioButton;
        private System.Windows.Forms.RadioButton ucusTarihiSilRadioButton;
        private System.Windows.Forms.TextBox ucusTarihiSilTextBox;
        private System.Windows.Forms.Button aramaUcusSilButton;
        private System.Windows.Forms.DataGridView ucusSilAdminDaGrView;
        private System.Windows.Forms.TextBox ucusIdSilTextBox;
        private SONDataSet4 sONDataSet4;
        private System.Windows.Forms.BindingSource ucuslarBindingSource;
        private SONDataSet4TableAdapters.ucuslarTableAdapter ucuslarTableAdapter;
        private System.Windows.Forms.ComboBox varisHavalimaniUcusSilComboBox;
        private System.Windows.Forms.ComboBox kalkisHavalimaniUcusSilComboBox;
        private System.Windows.Forms.RadioButton ucusSilKonumaGoreRadioButton;
        private SONDataSet8 sONDataSet8;
        private System.Windows.Forms.BindingSource havalimanikBindingSource;
        private SONDataSet8TableAdapters.havalimani_kTableAdapter havalimani_kTableAdapter;
        private SONDataSet9 sONDataSet9;
        private System.Windows.Forms.BindingSource havalimanivBindingSource;
        private SONDataSet9TableAdapters.havalimani_vTableAdapter havalimani_vTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucus_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucustarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkissaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inissaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}