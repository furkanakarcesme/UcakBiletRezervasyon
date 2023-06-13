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
    public partial class kullaniciRezSil : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        int kullaniciId;

        string accessPath = AccessPath.accessString;


        public kullaniciRezSil(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            fillGrid();
        }

        void fillGrid()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();

            kullaniciRezSilDaGrView.AutoGenerateColumns = false;

            cmd = new OleDbCommand(@"SELECT ucuslar.kalkis_saati AS kalkisSaati,
                                ucuslar.inis_saati AS inisSaati,
                                ucuslar.ucus_tarihi AS ucusTarihi,
                                ucuslar.ucret AS ucusUcreti,
                                havalimani_k.havalimani_adi AS KalkisHavalimani,
                                havalimani_v.havalimani_adi AS VarisHavalimani,
                                rezervasyon.rezervasyon_id
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

            kullaniciRezSilDaGrView.DataSource = ds.Tables["rezervasyon"];

            // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
            if (kullaniciRezSilDaGrView.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                kullaniciRezSilDaGrView.Columns.Add(kalkisHavalimaniSutun);
                kalkisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                kullaniciRezSilDaGrView.Columns.Add(varisHavalimaniSutun);
                varisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                kullaniciRezSilDaGrView.Columns.Add(ucusTarihiSutun);
                ucusTarihiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                kullaniciRezSilDaGrView.Columns.Add(kalkisSaatiSutun);
                kalkisSaatiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                varisSaatiSutun.HeaderText = "Varış Saati";
                varisSaatiSutun.DataPropertyName = "inisSaati";
                kullaniciRezSilDaGrView.Columns.Add(varisSaatiSutun);
                varisSaatiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                kullaniciRezSilDaGrView.Columns.Add(ucusUcretiSutun);
                ucusUcretiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak
            }

            conn.Close();

        }

        private void kullaniciRezSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet20.rezervasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonTableAdapter.Fill(this.sONDataSet20.rezervasyon);

        }

        private void kullaniciRezSilButton_Click(object sender, EventArgs e)
        {
            if (kullaniciRezSilDaGrView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in kullaniciRezSilDaGrView.SelectedRows)
                    {
                        try
                        {

                            silRezSatir(selectedRow);
                            kullaniciRezSilDaGrView.Rows.Remove(selectedRow);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Rezervasyon iptal işlemi başarısız! Hata: " + ex.Message);
                        }
                    }
                }
            }
        }

        
        private void silRezSatir(DataGridViewRow row)
        {
            int rezervasyon_id = Convert.ToInt32(row.Cells["rezervasyon_id"].Value);

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                using (cmd = new OleDbCommand("DELETE FROM rezervasyon WHERE rezervasyon_id = @rezervasyon_id", conn))
                {
                    cmd.Parameters.AddWithValue("@rezervasyon_id", rezervasyon_id);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Rezervasyon iptal işlemi gerçekleştirilemedi.");
                    }
                }
            }
        }

        private void rezSilToRezIslemleri_Click(object sender, EventArgs e)
        {
            kullaniciRezIslemleri r1 = new kullaniciRezIslemleri(kullaniciId);
            r1.Show();
            this.Hide();
        }
    }
}
