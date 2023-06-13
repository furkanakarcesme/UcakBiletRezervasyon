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
    public partial class kullaniciBiletAl : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        int kullaniciId;
            //Session.KullaniciId;




        string accessPath = AccessPath.accessString;


        public kullaniciBiletAl(int kullaniciId)
        {
            InitializeComponent();
            fillGrid();
            this.kullaniciId = kullaniciId;
        }


        void fillGrid()
        {

            conn = new OleDbConnection(accessPath);

            biletAlDataGridView.AutoGenerateColumns = false;

            da = new OleDbDataAdapter(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "ucuslar");
            biletAlDataGridView.DataSource = ds.Tables["ucuslar"];

            
            if (biletAlDataGridView.Columns.Count == 5)
            {
                // Kalkış Havalimanı sütunu ekle
                DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                biletAlDataGridView.Columns.Insert(1, kalkisHavalimaniSutun);
                kalkisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak



                // Varış Havalimanı sütunu ekle
                DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                biletAlDataGridView.Columns.Insert(2, varisHavalimaniSutun); 
                varisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 


            }


            conn.Close();
        }

        private void kullaniciBiletAl_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet16.ucuslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucuslarTableAdapter.Fill(this.sONDataSet16.ucuslar);
            // TODO: Bu kod satırı 'sONDataSet15.havalimani_v' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_vTableAdapter.Fill(this.sONDataSet15.havalimani_v);
            // TODO: Bu kod satırı 'sONDataSet14.havalimani_k' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_kTableAdapter.Fill(this.sONDataSet14.havalimani_k);

        }

        private void biletAlUcusAraButton_Click(object sender, EventArgs e)
        {
            string kalkisHavalimani = biletAlNeredenComboBox.Text;
            string varisHavalimani = biletAlNereyeComboBox.Text;
            string ucusTarihi = biletAlDTP.Value.ToShortDateString(); ;

            conn = new OleDbConnection(accessPath);
            
            biletAlDataGridView.AutoGenerateColumns = false;

            da = new OleDbDataAdapter(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                               WHERE havalimani_k.havalimani_adi = @kalkisHavalimani
                               AND havalimani_v.havalimani_adi = @varisHavalimani 
                               AND ucuslar.ucus_tarihi = @ucusTarihi", conn);

            da.SelectCommand.Parameters.AddWithValue("@kalkisHavalimani", kalkisHavalimani);
            da.SelectCommand.Parameters.AddWithValue("@varisHavalimani", varisHavalimani);
            da.SelectCommand.Parameters.AddWithValue("@ucusTarihi", ucusTarihi);

            ds = new DataSet();
            conn.Open();

            da.Fill(ds, "ucuslar");
            biletAlDataGridView.DataSource = ds.Tables["ucuslar"];

            

            // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
            if (biletAlDataGridView.Columns.Count == 5)
            {
                // Kalkış Havalimanı sütunu ekle
                DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                biletAlDataGridView.Columns.Insert(1, kalkisHavalimaniSutun);

                // Varış Havalimanı sütunu ekle
                DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                biletAlDataGridView.Columns.Insert(2, varisHavalimaniSutun);

            }

            conn.Close();




        }

        private void biletAlTumUcuslarButton_Click(object sender, EventArgs e)
        {

            fillGrid();

        }

        private void biletAlRezOlusturButton_Click(object sender, EventArgs e)
        {

            using (OleDbConnection conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                
                

                if (biletAlDataGridView.SelectedRows.Count > 0)
                {
                    if (biletAlDataGridView.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = biletAlDataGridView.SelectedRows[0];
                        int ucusId = (int)selectedRow.Cells["ucus_id"].Value;
                        string ucusTarihi = selectedRow.Cells["ucus_tarihi"].Value.ToString();

                        // Önceden aynı kullanıcı ve uçuş için rezervasyon yapılıp yapılmadığını kontrol et
                        OleDbCommand rezervasyonKontrolCmd = new OleDbCommand("SELECT COUNT(*) FROM rezervasyon WHERE ucus_id = @ucusId AND kullanici_id = @kullaniciId", conn);
                        rezervasyonKontrolCmd.Parameters.AddWithValue("@ucusId", ucusId);
                        rezervasyonKontrolCmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        int rezervasyonSayisi = Convert.ToInt32(rezervasyonKontrolCmd.ExecuteScalar());

                        if (rezervasyonSayisi > 0)
                        {
                            MessageBox.Show("Bu uçuş için zaten rezervasyon yapılmış!");
                            return;
                        }

                        // Rezervasyon sayısını kontrol et
                        OleDbCommand rezervasyonSayisiCmd = new OleDbCommand("SELECT COUNT(*) FROM rezervasyon WHERE ucus_id = @ucusId", conn);
                        rezervasyonSayisiCmd.Parameters.AddWithValue("@ucusId", ucusId);
                        int rezervasyonSayisiGenel = Convert.ToInt32(rezervasyonSayisiCmd.ExecuteScalar());

                        // Satılmış bilet sayısını kontrol et
                        OleDbCommand satilmisBiletSayisiCmd = new OleDbCommand("SELECT COUNT(*) FROM satilmisBilet WHERE ucus_id = @ucusId", conn);
                        satilmisBiletSayisiCmd.Parameters.AddWithValue("@ucusId", ucusId);
                        int satilmisBiletSayisi = Convert.ToInt32(satilmisBiletSayisiCmd.ExecuteScalar());

                        // Toplam rezervasyon ve satılmış bilet sayısını kontrol et
                        int toplamBiletSayisi = rezervasyonSayisiGenel + satilmisBiletSayisi;

                        if (toplamBiletSayisi >= 5)
                        {
                            MessageBox.Show("Bu uçuş dolu!");
                            return;
                        }

                        OleDbCommand rezEkleCmd = new OleDbCommand("INSERT INTO rezervasyon (ucus_id, rezervasyon_tarihi, kullanici_id) VALUES (@ucusId, @ucusTarihi, @kullaniciId)", conn);
                        rezEkleCmd.Parameters.AddWithValue("@ucusId", ucusId);
                        rezEkleCmd.Parameters.AddWithValue("@ucusTarihi", ucusTarihi);
                        rezEkleCmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        int affectedRows = rezEkleCmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Rezervasyon kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon kaydedilemedi.");
                        }
                    }


                    /*
                    DataGridViewRow selectedRow = biletAlDataGridView.SelectedRows[0];
                    int ucusId = (int)selectedRow.Cells["ucus_id"].Value;
                    string ucusTarihi = selectedRow.Cells["ucus_tarihi"].Value.ToString();


                    OleDbCommand dolulukKontrolcCmd = new OleDbCommand("SELECT COUNT(*) FROM rezervasyon WHERE ucus_id = @ucusId", conn);
                    dolulukKontrolcCmd.Parameters.AddWithValue("@ucusId", ucusId);

                    int rezervasyonSayisi = Convert.ToInt32(dolulukKontrolcCmd.ExecuteScalar());
                    if (rezervasyonSayisi >= 10)
                    {
                        MessageBox.Show("Bu uçuş dolu!");
                        return; 

                    } 
                    else 
                    {
                        OleDbCommand rezEkleCmd = new OleDbCommand("INSERT INTO rezervasyon (ucus_id, rezervasyon_tarihi, kullanici_id) VALUES (@ucusId, @ucusTarihi, @kullaniciId)", conn);

                        rezEkleCmd.Parameters.AddWithValue("@ucusId", ucusId);
                        rezEkleCmd.Parameters.AddWithValue("@ucusTarihi", ucusTarihi);
                        rezEkleCmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        int affectedRows = rezEkleCmd.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Rezervasyon kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon kaydedilemedi.");
                        }

                    }
                    */


                }
             
            }

        }

        private void biletAlToAraSayfaButton_Click(object sender, EventArgs e)
        {
            kullaniciAraSayfa a1 = new kullaniciAraSayfa(kullaniciId);
            a1.Show();
            this.Hide();
        }
    }
}
