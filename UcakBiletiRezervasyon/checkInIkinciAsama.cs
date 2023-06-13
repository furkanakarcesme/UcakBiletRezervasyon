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
    public partial class checkInIkinciAsama : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        int kullaniciId;
        int ucusId;

        string accessPath = AccessPath.accessString;



        public checkInIkinciAsama(int kullaniciId, int ucusId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.ucusId = ucusId;
            fillGridKart();
        }



        void fillGridKart()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();
            da = new OleDbDataAdapter(@"SELECT kart_numarasi,ay,yil,uc_hane,kart_id
                               FROM kartlar
                               WHERE kullanici_id = @kullaniciId", conn);
            da.SelectCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            ds = new DataSet();

            da.Fill(ds, "kartlar");
            kullaniciCheckInKartListesiDGV.DataSource = ds.Tables["kartlar"];

            conn.Close();
        }


        private void checkInTamamlaButton_Click(object sender, EventArgs e)
        {

        }


        private void checkInTamamlaButton_Click_1(object sender, EventArgs e)
        {
            if (kullaniciCheckInKartListesiDGV.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırdaki rezervasyon için ödeme sayfasına yönlendiriliyorsunuz, emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in kullaniciCheckInKartListesiDGV.SelectedRows)
                    {
                        try
                        {

                            kartSatir(selectedRow);
                            kullaniciCheckInKartListesiDGV.Rows.Remove(selectedRow);

                            checkInIkinciAsama c1 = new checkInIkinciAsama(kullaniciId, ucusId);
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


        private void kartSatir(DataGridViewRow row)
        {
            int kart_id = Convert.ToInt32(row.Cells["kart_id"].Value);

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                // Satış işlemi
                using (cmd = new OleDbCommand("INSERT INTO satilmisBilet (ucus_id, kullanici_id, kart_id) VALUES (@ucus_id, @kullanici_id, @kart_id)", conn))
                {
                    cmd.Parameters.AddWithValue("@ucus_id", ucusId);
                    cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
                    cmd.Parameters.AddWithValue("@kart_id", kart_id);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Satış işlemi gerçekleştirilemedi.");
                    }
                }

                // Rezervasyonun silinmesi
                using (cmd = new OleDbCommand("DELETE FROM rezervasyon WHERE ucus_id = @ucus_id AND kullanici_id = @kullanici_id", conn))
                {
                    cmd.Parameters.AddWithValue("@ucus_id", ucusId);
                    cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Rezervasyon iptal işlemi gerçekleştirilemedi.");
                    }
                }
            }
        }

        private void checkInIkinciAsama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet25.kartlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kartlarTableAdapter.Fill(this.sONDataSet25.kartlar);

        }

        private void kartSecToCheckInButton_Click(object sender, EventArgs e)
        {
            kullaniciCheckIn k1 = new kullaniciCheckIn(kullaniciId);
            k1.Show();
            this.Hide();
        }






        /*
        private void kartSatir(DataGridViewRow row)
        {
            int kart_id = Convert.ToInt32(row.Cells["kart_id"].Value);

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                using (cmd = new OleDbCommand("INSERT INTO satilmisBilet WHERE kart_id = @kart_id", conn))
                {
                    cmd.Parameters.AddWithValue("@kart_id", kart_id);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Rezervasyon iptal işlemi gerçekleştirilemedi.");
                    }
                }
            }
        }
        */


    }

}
