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
    public partial class kullaniciCheckIn : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        int kullaniciId;

        string accessPath = AccessPath.accessString;


        public kullaniciCheckIn(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            fillGridRez();
            
        }

        void fillGridRez()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();

            kullaniciCheckInRezListesiDGV.AutoGenerateColumns = false;

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

            kullaniciCheckInRezListesiDGV.DataSource = ds.Tables["rezervasyon"];

            // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
            if (kullaniciCheckInRezListesiDGV.Columns.Count == 1)
            {
                DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                kullaniciCheckInRezListesiDGV.Columns.Insert(1, kalkisHavalimaniSutun);
                kalkisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                kullaniciCheckInRezListesiDGV.Columns.Insert(2, varisHavalimaniSutun);
                varisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn ucusTarihiSutun = new DataGridViewTextBoxColumn();
                ucusTarihiSutun.HeaderText = "Uçuş Tarihi";
                ucusTarihiSutun.DataPropertyName = "ucusTarihi";
                kullaniciCheckInRezListesiDGV.Columns.Insert(3, ucusTarihiSutun);
                ucusTarihiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn kalkisSaatiSutun = new DataGridViewTextBoxColumn();
                kalkisSaatiSutun.HeaderText = "Kalkış Saati";
                kalkisSaatiSutun.DataPropertyName = "kalkisSaati";
                kullaniciCheckInRezListesiDGV.Columns.Insert(4, kalkisSaatiSutun);
                kalkisSaatiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak


                DataGridViewTextBoxColumn varisSaatiSutun = new DataGridViewTextBoxColumn();
                varisSaatiSutun.HeaderText = "Varış Saati";
                varisSaatiSutun.DataPropertyName = "inisSaati";
                kullaniciCheckInRezListesiDGV.Columns.Insert(5, varisSaatiSutun);
                varisSaatiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak



                DataGridViewTextBoxColumn ucusUcretiSutun = new DataGridViewTextBoxColumn();
                ucusUcretiSutun.HeaderText = "Uçuş Ücreti";
                ucusUcretiSutun.DataPropertyName = "ucusUcreti";
                kullaniciCheckInRezListesiDGV.Columns.Insert(6, ucusUcretiSutun);
                ucusUcretiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak

            }

            conn.Close();

        }



        
        private void checkInTamamlaButton_Click(object sender, EventArgs e)
        {
            

            if (kullaniciCheckInRezListesiDGV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırdaki rezervasyon için ödeme sayfasına yönlendiriliyorsunuz, emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in kullaniciCheckInRezListesiDGV.SelectedRows)
                    {
                        try
                        {

                            int ucusId = checkInSatir(selectedRow);

                            checkInIkinciAsama c1 = new checkInIkinciAsama(kullaniciId,ucusId);
                            c1.Show();
                            this.Hide();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Rezervasyon seçme işlemi başarısız! Hata: " + ex.Message);
                        }
                    }
                }
            }



        }

        /*
        private int checkInSatir(DataGridViewRow row)
        {
            int rezervasyon_id = Convert.ToInt32(row.Cells["rezervasyon_id"].Value);

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                using (cmd = new OleDbCommand("SELECT ucus_id FROM rezervasyon WHERE rezervasyon_id = @rezervasyon_id", conn))
                {
                    cmd.Parameters.AddWithValue("@rezervasyon_id", rezervasyon_id);

                    

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Rezervasyon iptal işlemi gerçekleştirilemedi.");
                    }

                    return ucusId;
                }
            }
        }
        */


        private int checkInSatir(DataGridViewRow row)
        {
            int rezervasyon_id = Convert.ToInt32(row.Cells["rezervasyon_id"].Value);
            int ucusId = 0;

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                using (cmd = new OleDbCommand("SELECT ucus_id FROM rezervasyon WHERE rezervasyon_id = @rezervasyon_id", conn))
                {
                    cmd.Parameters.AddWithValue("@rezervasyon_id", rezervasyon_id);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        ucusId = Convert.ToInt32(result);
                    }
                }
            }

            return ucusId;
        }

        private void kullaniciCheckIn_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet24.rezervasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonTableAdapter.Fill(this.sONDataSet24.rezervasyon);

        }

        private void checkInToAramenuButton_Click(object sender, EventArgs e)
        {
            kullaniciAraSayfa a1 = new kullaniciAraSayfa(kullaniciId);
            a1.Show();
            this.Hide();
        }
    }
}
