using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiRezervasyon
{
    public partial class RezGoruntule : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        
        
        string accessPath = AccessPath.accessString;

        public RezGoruntule()
        {
            InitializeComponent();
            fillGrid();
        }


        void fillGrid()
        {

            conn = new OleDbConnection(accessPath);

            rezListeleUcusAramaDaGrView.AutoGenerateColumns = false;


            da = new OleDbDataAdapter(@"SELECT rezervasyon.rezervasyon_id,
                            rezervasyon.ucus_id,
                            rezervasyon.kullanici_id,
                            rezervasyon.rezervasyon_tarihi,
                            uyeler.ad AS uyeAdi,
                            uyeler.soyad AS uyeSoyad,
                            uyeler.kimlik_no AS uyeKimlik,
                            ucuslar.kalkis_saati AS kalkisSaati,
                            ucuslar.inis_saati AS inisSaati,
                            ucuslar.ucus_tarihi AS ucusTarihi,
                            ucuslar.ucret AS ucusUcreti,
                            havalimani_k.havalimani_adi AS KalkisHavalimani,
                            havalimani_v.havalimani_adi AS VarisHavalimani
                        FROM (((rezervasyon
                        INNER JOIN uyeler ON rezervasyon.kullanici_id = uyeler.kullanici_id)
                        INNER JOIN ucuslar ON rezervasyon.ucus_id = ucuslar.ucus_id)
                        INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                        INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id", conn);

            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "rezervasyon");
            rezListeleUcusAramaDaGrView.DataSource = ds.Tables["rezervasyon"];

            // Üye adı sütunu ekle

            DataGridViewTextBoxColumn uyeAdSutun = new DataGridViewTextBoxColumn();
            uyeAdSutun.HeaderText = "Üye Adı";
            uyeAdSutun.DataPropertyName = "uyeAdi";
            rezListeleUcusAramaDaGrView.Columns.Insert(1, uyeAdSutun);


            // Üye soyad sütunu ekle
            DataGridViewTextBoxColumn uyeSoyadSutun = new DataGridViewTextBoxColumn();
            uyeSoyadSutun.HeaderText = "Üye Soyadı";
            uyeSoyadSutun.DataPropertyName = "uyeSoyad";
            rezListeleUcusAramaDaGrView.Columns.Insert(2, uyeSoyadSutun);

            // Üye kimlik no sütunu ekle
            DataGridViewTextBoxColumn uyeKimlikNoSutun = new DataGridViewTextBoxColumn();
            uyeKimlikNoSutun.HeaderText = "Üye Kimlik No";
            uyeKimlikNoSutun.DataPropertyName = "uyeKimlik";
            rezListeleUcusAramaDaGrView.Columns.Insert(3, uyeKimlikNoSutun);


            // Kalkış Havalimanı sütunu ekle
            DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
            kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
            kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
            rezListeleUcusAramaDaGrView.Columns.Insert(4, kalkisHavalimaniSutun);

            // Varış Havalimanı sütunu ekle
            DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
            varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
            varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
            rezListeleUcusAramaDaGrView.Columns.Insert(5, varisHavalimaniSutun);

            // Uçuş Tarihi sütunu ekle
            //DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
            //ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
            //ucusTarihiSutun.DataPropertyName = "ucusTarihi";
            //rezListeleUcusAramaDaGrView.Columns.Insert(6, ucusTarihiSutun);

            // Kalkış Saati sütunu ekle
            DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
            kalkisSaatiSutun.HeaderText = "Kalkış Saati";
            kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
            rezListeleUcusAramaDaGrView.Columns.Insert(7, kalkisSaatiSutun);

            // Varış Saati sütunu ekle
            DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
            varisSaatiSutun.HeaderText = "Varış Saati";
            varisSaatiSutun.DataPropertyName = "inisSaati";
            rezListeleUcusAramaDaGrView.Columns.Insert(8,varisSaatiSutun);

            // Uçuş Ücreti sütunu ekle

            DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
            ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
            ucusUcretiSutun.DataPropertyName = "ucusUcreti";
            rezListeleUcusAramaDaGrView.Columns.Insert(9,ucusUcretiSutun);

            conn.Close();


        }

        private void RezGoruntule_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet11.havalimani_v' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_vTableAdapter.Fill(this.sONDataSet11.havalimani_v);
            // TODO: Bu kod satırı 'sONDataSet10.havalimani_k' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_kTableAdapter1.Fill(this.sONDataSet10.havalimani_k);
            // TODO: Bu kod satırı 'sONDataSet8.havalimani_k' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_kTableAdapter.Fill(this.sONDataSet8.havalimani_k);
            // TODO: Bu kod satırı 'sONDataSet6.rezervasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonTableAdapter.Fill(this.sONDataSet6.rezervasyon);


        }

        private void rezListeleAramaButton_Click(object sender, EventArgs e)
        {

            if (rezListeleRezIdyeGoreRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);

                rezListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                da = new OleDbDataAdapter(@"SELECT rezervasyon.rezervasyon_id,
                            rezervasyon.ucus_id,
                            rezervasyon.kullanici_id,
                            rezervasyon.rezervasyon_tarihi,
                            uyeler.ad AS uyeAdi,
                            uyeler.soyad AS uyeSoyad,
                            uyeler.kimlik_no AS uyeKimlik,
                            ucuslar.kalkis_saati AS kalkisSaati,
                            ucuslar.inis_saati AS inisSaati,
                            ucuslar.ucus_tarihi AS ucusTarihi,
                            ucuslar.ucret AS ucusUcreti,
                            havalimani_k.havalimani_adi AS KalkisHavalimani,
                            havalimani_v.havalimani_adi AS VarisHavalimani
                        FROM (((rezervasyon
                        INNER JOIN uyeler ON rezervasyon.kullanici_id = uyeler.kullanici_id)
                        INNER JOIN ucuslar ON rezervasyon.ucus_id = ucuslar.ucus_id)
                        INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                        INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                        WHERE rezervasyon.rezervasyon_id LIKE '" + rezListeleRezIdAramaTextBox.Text + "%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@rezervasyon_id", rezListeleRezIdAramaTextBox.Text + "%");


                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "rezervasyon");
                rezListeleUcusAramaDaGrView.DataSource = ds.Tables["rezervasyon"];

                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (rezListeleUcusAramaDaGrView.Columns.Count == 1)
                {
                    // Üye adı sütunu ekle

                    DataGridViewTextBoxColumn uyeAdSutun = new DataGridViewTextBoxColumn();
                    uyeAdSutun.HeaderText = "Üye Adı";
                    uyeAdSutun.DataPropertyName = "uyeAdi";
                    rezListeleUcusAramaDaGrView.Columns.Insert(1, uyeAdSutun);


                    // Üye soyad sütunu ekle
                    DataGridViewTextBoxColumn uyeSoyadSutun = new DataGridViewTextBoxColumn();
                    uyeSoyadSutun.HeaderText = "Üye Soyadı";
                    uyeSoyadSutun.DataPropertyName = "uyeSoyad";
                    rezListeleUcusAramaDaGrView.Columns.Insert(2, uyeSoyadSutun);

                    // Üye kimlik no sütunu ekle
                    DataGridViewTextBoxColumn uyeKimlikNoSutun = new DataGridViewTextBoxColumn();
                    uyeKimlikNoSutun.HeaderText = "Üye Kimlik No";
                    uyeKimlikNoSutun.DataPropertyName = "uyeKimlik";
                    rezListeleUcusAramaDaGrView.Columns.Insert(3, uyeKimlikNoSutun);


                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    rezListeleUcusAramaDaGrView.Columns.Insert(4, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    rezListeleUcusAramaDaGrView.Columns.Insert(5, varisHavalimaniSutun);

                    // Uçuş Tarihi sütunu ekle
                    //DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                    //ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                    //ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                    //rezListeleUcusAramaDaGrView.Columns.Insert(6, ucusTarihiSutun);

                    // Kalkış Saati sütunu ekle
                    DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                    kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                    kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                    rezListeleUcusAramaDaGrView.Columns.Insert(7, kalkisSaatiSutun);

                    // Varış Saati sütunu ekle
                    DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                    varisSaatiSutun.HeaderText = "Varış Saati";
                    varisSaatiSutun.DataPropertyName = "inisSaati";
                    rezListeleUcusAramaDaGrView.Columns.Insert(8, varisSaatiSutun);

                    // Uçuş Ücreti sütunu ekle

                    DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                    ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                    ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                    rezListeleUcusAramaDaGrView.Columns.Insert(9, ucusUcretiSutun);

                }

                conn.Close();


            }
            else if (rezListeleAdaGoreRadioButton.Checked)
            {
                if (rezListeleAdaGoreTextBox.Text != null && rezListeleSoyadaGoreTextBox.Text != null)
                {
                    conn = new OleDbConnection(accessPath);

                    rezListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                    da = new OleDbDataAdapter(@"SELECT rezervasyon.rezervasyon_id,
                            rezervasyon.ucus_id,
                            rezervasyon.kullanici_id,
                            rezervasyon.rezervasyon_tarihi,
                            uyeler.ad AS uyeAdi,
                            uyeler.soyad AS uyeSoyad,
                            uyeler.kimlik_no AS uyeKimlik,
                            ucuslar.kalkis_saati AS kalkisSaati,
                            ucuslar.inis_saati AS inisSaati,
                            ucuslar.ucus_tarihi AS ucusTarihi,
                            ucuslar.ucret AS ucusUcreti,
                            havalimani_k.havalimani_adi AS KalkisHavalimani,
                            havalimani_v.havalimani_adi AS VarisHavalimani
                        FROM (((rezervasyon
                        INNER JOIN uyeler ON rezervasyon.kullanici_id = uyeler.kullanici_id)
                        INNER JOIN ucuslar ON rezervasyon.ucus_id = ucuslar.ucus_id)
                        INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                        INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                        WHERE uyeler.ad LIKE @ad + '%' AND uyeler.soyad = @soyad", conn);

                    da.SelectCommand.Parameters.AddWithValue("@ad", rezListeleAdaGoreTextBox.Text);
                    da.SelectCommand.Parameters.AddWithValue("@soyad", rezListeleSoyadaGoreTextBox.Text);


                    ds = new DataSet();
                    conn.Open();
                    da.Fill(ds, "rezervasyon");
                    rezListeleUcusAramaDaGrView.DataSource = ds.Tables["rezervasyon"];

                    // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                    if (rezListeleUcusAramaDaGrView.Columns.Count == 1)
                    {
                        // Üye adı sütunu ekle

                        DataGridViewTextBoxColumn uyeAdSutun = new DataGridViewTextBoxColumn();
                        uyeAdSutun.HeaderText = "Üye Adı";
                        uyeAdSutun.DataPropertyName = "uyeAdi";
                        rezListeleUcusAramaDaGrView.Columns.Insert(1, uyeAdSutun);


                        // Üye soyad sütunu ekle
                        DataGridViewTextBoxColumn uyeSoyadSutun = new DataGridViewTextBoxColumn();
                        uyeSoyadSutun.HeaderText = "Üye Soyadı";
                        uyeSoyadSutun.DataPropertyName = "uyeSoyad";
                        rezListeleUcusAramaDaGrView.Columns.Insert(2, uyeSoyadSutun);

                        // Üye kimlik no sütunu ekle
                        DataGridViewTextBoxColumn uyeKimlikNoSutun = new DataGridViewTextBoxColumn();
                        uyeKimlikNoSutun.HeaderText = "Üye Kimlik No";
                        uyeKimlikNoSutun.DataPropertyName = "uyeKimlik";
                        rezListeleUcusAramaDaGrView.Columns.Insert(3, uyeKimlikNoSutun);


                        // Kalkış Havalimanı sütunu ekle
                        DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                        kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                        kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                        rezListeleUcusAramaDaGrView.Columns.Insert(4, kalkisHavalimaniSutun);

                        // Varış Havalimanı sütunu ekle
                        DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                        varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                        varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                        rezListeleUcusAramaDaGrView.Columns.Insert(5, varisHavalimaniSutun);

                        // Uçuş Tarihi sütunu ekle
                        //DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                        //ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                        //ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                        //rezListeleUcusAramaDaGrView.Columns.Insert(6, ucusTarihiSutun);

                        // Kalkış Saati sütunu ekle
                        DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                        kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                        kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                        rezListeleUcusAramaDaGrView.Columns.Insert(7, kalkisSaatiSutun);

                        // Varış Saati sütunu ekle
                        DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                        varisSaatiSutun.HeaderText = "Varış Saati";
                        varisSaatiSutun.DataPropertyName = "inisSaati";
                        rezListeleUcusAramaDaGrView.Columns.Insert(8, varisSaatiSutun);

                        // Uçuş Ücreti sütunu ekle

                        DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                        ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                        ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                        rezListeleUcusAramaDaGrView.Columns.Insert(9, ucusUcretiSutun);

                    }

                    conn.Close();
                }
                else if (rezListeleSoyadaGoreTextBox.Text == null)
                {
                    MessageBox.Show("Lütfen soyad kutucuğunu doldurup tekrar deneyin!");
                }                 
            }
            else if (rezListeleRezTarihiRadio.Checked)
            {
                conn = new OleDbConnection(accessPath);

                rezListeleUcusAramaDaGrView.AutoGenerateColumns = false;

                da = new OleDbDataAdapter(@"SELECT rezervasyon.rezervasyon_id,
                            rezervasyon.ucus_id,
                            rezervasyon.kullanici_id,
                            rezervasyon.rezervasyon_tarihi,
                            uyeler.ad AS uyeAdi,
                            uyeler.soyad AS uyeSoyad,
                            uyeler.kimlik_no AS uyeKimlik,
                            ucuslar.kalkis_saati AS kalkisSaati,
                            ucuslar.inis_saati AS inisSaati,
                            ucuslar.ucus_tarihi AS ucusTarihi,
                            ucuslar.ucret AS ucusUcreti,
                            havalimani_k.havalimani_adi AS KalkisHavalimani,
                            havalimani_v.havalimani_adi AS VarisHavalimani
                        FROM (((rezervasyon
                        INNER JOIN uyeler ON rezervasyon.kullanici_id = uyeler.kullanici_id)
                        INNER JOIN ucuslar ON rezervasyon.ucus_id = ucuslar.ucus_id)
                        INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                        INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                        WHERE rezervasyon.rezervasyon_tarihi LIKE '" + rezListeleRezTarihiTextBox.Text + "%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@rezervasyon_tarihi", rezListeleRezTarihiTextBox.Text + "%");

                
                //count == 1 i de değiştirmemiz gerekebilir birçok yerde 
                

                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "rezervasyon");
                rezListeleUcusAramaDaGrView.DataSource = ds.Tables["rezervasyon"];

                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (rezListeleUcusAramaDaGrView.Columns.Count == 2)
                {
                    // Üye adı sütunu ekle

                    DataGridViewTextBoxColumn uyeAdSutun = new DataGridViewTextBoxColumn();
                    uyeAdSutun.HeaderText = "Üye Adı";
                    uyeAdSutun.DataPropertyName = "uyeAdi";
                    rezListeleUcusAramaDaGrView.Columns.Insert(1, uyeAdSutun);


                    // Üye soyad sütunu ekle
                    DataGridViewTextBoxColumn uyeSoyadSutun = new DataGridViewTextBoxColumn();
                    uyeSoyadSutun.HeaderText = "Üye Soyadı";
                    uyeSoyadSutun.DataPropertyName = "uyeSoyad";
                    rezListeleUcusAramaDaGrView.Columns.Insert(2, uyeSoyadSutun);

                    // Üye kimlik no sütunu ekle
                    DataGridViewTextBoxColumn uyeKimlikNoSutun = new DataGridViewTextBoxColumn();
                    uyeKimlikNoSutun.HeaderText = "Üye Kimlik No";
                    uyeKimlikNoSutun.DataPropertyName = "uyeKimlik";
                    rezListeleUcusAramaDaGrView.Columns.Insert(3, uyeKimlikNoSutun);


                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    rezListeleUcusAramaDaGrView.Columns.Insert(4, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    rezListeleUcusAramaDaGrView.Columns.Insert(5, varisHavalimaniSutun);

                    // Uçuş Tarihi sütunu ekle
                    //DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                    //ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                    //ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                    //rezListeleUcusAramaDaGrView.Columns.Insert(6, ucusTarihiSutun);

                    // Kalkış Saati sütunu ekle
                    DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                    kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                    kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                    rezListeleUcusAramaDaGrView.Columns.Insert(7, kalkisSaatiSutun);

                    // Varış Saati sütunu ekle
                    DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                    varisSaatiSutun.HeaderText = "Varış Saati";
                    varisSaatiSutun.DataPropertyName = "inisSaati";
                    rezListeleUcusAramaDaGrView.Columns.Insert(8, varisSaatiSutun);

                    // Uçuş Ücreti sütunu ekle

                    DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                    ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                    ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                    rezListeleUcusAramaDaGrView.Columns.Insert(9, ucusUcretiSutun);

                }

                conn.Close();

            }
            else if(rezListeleKonumaGoreRadioButton.Checked)
            {
                string kalkisHavalimani = rezListeleKalkisHavalimaniComboBox.Text;
                string varisHavalimani = rezListeleVarisHavalimaniComboBox.Text;

                conn = new OleDbConnection(accessPath);

                rezListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                da = new OleDbDataAdapter(@"SELECT rezervasyon.rezervasyon_id,
                            rezervasyon.ucus_id,
                            rezervasyon.kullanici_id,
                            rezervasyon.rezervasyon_tarihi,
                            uyeler.ad AS uyeAdi,
                            uyeler.soyad AS uyeSoyad,
                            uyeler.kimlik_no AS uyeKimlik,
                            ucuslar.kalkis_saati AS kalkisSaati,
                            ucuslar.inis_saati AS inisSaati,
                            ucuslar.ucus_tarihi AS ucusTarihi,
                            ucuslar.ucret AS ucusUcreti,
                            havalimani_k.havalimani_adi AS KalkisHavalimani,
                            havalimani_v.havalimani_adi AS VarisHavalimani
                        FROM (((rezervasyon
                        INNER JOIN uyeler ON rezervasyon.kullanici_id = uyeler.kullanici_id)
                        INNER JOIN ucuslar ON rezervasyon.ucus_id = ucuslar.ucus_id)
                        INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                        INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                        WHERE havalimani_k.havalimani_adi = @kalkisHavalimani AND havalimani_v.havalimani_adi = @varisHavalimani", conn);

                da.SelectCommand.Parameters.AddWithValue("@kalkisHavalimani", kalkisHavalimani);
                da.SelectCommand.Parameters.AddWithValue("@varisHavalimani", varisHavalimani);

                ds = new DataSet();
                conn.Open();

                da.Fill(ds, "rezervasyon");
                rezListeleUcusAramaDaGrView.DataSource = ds.Tables["rezervasyon"];

                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (rezListeleUcusAramaDaGrView.Columns.Count == 2)
                {
                    // Üye adı sütunu ekle

                    DataGridViewTextBoxColumn uyeAdSutun = new DataGridViewTextBoxColumn();
                    uyeAdSutun.HeaderText = "Üye Adı";
                    uyeAdSutun.DataPropertyName = "uyeAdi";
                    rezListeleUcusAramaDaGrView.Columns.Insert(1, uyeAdSutun);


                    // Üye soyad sütunu ekle
                    DataGridViewTextBoxColumn uyeSoyadSutun = new DataGridViewTextBoxColumn();
                    uyeSoyadSutun.HeaderText = "Üye Soyadı";
                    uyeSoyadSutun.DataPropertyName = "uyeSoyad";
                    rezListeleUcusAramaDaGrView.Columns.Insert(2, uyeSoyadSutun);

                    // Üye kimlik no sütunu ekle
                    DataGridViewTextBoxColumn uyeKimlikNoSutun = new DataGridViewTextBoxColumn();
                    uyeKimlikNoSutun.HeaderText = "Üye Kimlik No";
                    uyeKimlikNoSutun.DataPropertyName = "uyeKimlik";
                    rezListeleUcusAramaDaGrView.Columns.Insert(3, uyeKimlikNoSutun);


                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    rezListeleUcusAramaDaGrView.Columns.Insert(4, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    rezListeleUcusAramaDaGrView.Columns.Insert(5, varisHavalimaniSutun);

                    // Uçuş Tarihi sütunu ekle
                    //DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                    //ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                    //ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                    //rezListeleUcusAramaDaGrView.Columns.Insert(6, ucusTarihiSutun);

                    // Kalkış Saati sütunu ekle
                    DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                    kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                    kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                    rezListeleUcusAramaDaGrView.Columns.Insert(7, kalkisSaatiSutun);

                    // Varış Saati sütunu ekle
                    DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                    varisSaatiSutun.HeaderText = "Varış Saati";
                    varisSaatiSutun.DataPropertyName = "inisSaati";
                    rezListeleUcusAramaDaGrView.Columns.Insert(8, varisSaatiSutun);

                    // Uçuş Ücreti sütunu ekle

                    DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                    ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                    ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                    rezListeleUcusAramaDaGrView.Columns.Insert(9, ucusUcretiSutun);

                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("Lütfen arama yapmak istediğiniz parametreyi seçiniz ve tekrar deneyiniz!");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezIslemleri r1 = new RezIslemleri();
            r1.Show();
            this.Hide();
        }
    }
}
