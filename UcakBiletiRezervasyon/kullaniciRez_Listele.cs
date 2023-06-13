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
    public partial class kullaniciRez_Listele : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        int kullaniciId;

        string accessPath = AccessPath.accessString;


        public kullaniciRez_Listele(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            fillGrid();
        }


        void fillGrid()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();

            rezListeleIkiDataGridView.AutoGenerateColumns = false;  

            cmd = new OleDbCommand(@"SELECT ucuslar.kalkis_saati AS kalkisSaati,
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
                            WHERE rezervasyon.kullanici_id = @kullaniciId", conn);

            cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "rezervasyon");

            rezListeleIkiDataGridView.DataSource = ds.Tables["rezervasyon"];

            // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
            if (rezListeleIkiDataGridView.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                rezListeleIkiDataGridView.Columns.Add(kalkisHavalimaniSutun);
                kalkisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                rezListeleIkiDataGridView.Columns.Add(varisHavalimaniSutun);
                varisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                rezListeleIkiDataGridView.Columns.Add(ucusTarihiSutun);
                ucusTarihiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                rezListeleIkiDataGridView.Columns.Add(kalkisSaatiSutun);
                kalkisSaatiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                varisSaatiSutun.HeaderText = "Varış Saati";
                varisSaatiSutun.DataPropertyName = "inisSaati";
                rezListeleIkiDataGridView.Columns.Add(varisSaatiSutun);
                varisSaatiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                rezListeleIkiDataGridView.Columns.Add(ucusUcretiSutun);
                ucusUcretiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak

            }

            conn.Close();

        }


        private void kullaniciRez_Listele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet23.rezervasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonTableAdapter.Fill(this.sONDataSet23.rezervasyon);

        }

        private void rezListeleToRezIslemleriButton_Click(object sender, EventArgs e)
        {
            kullaniciRezIslemleri r1 = new kullaniciRezIslemleri(kullaniciId);
            r1.Show();
            this.Hide();
        }
    }
}
