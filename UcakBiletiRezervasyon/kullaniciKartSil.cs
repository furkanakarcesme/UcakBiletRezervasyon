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
    public partial class kullaniciKartSil : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        string accessPath = AccessPath.accessString;

        int kullaniciId;


        public kullaniciKartSil(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            fillGrid();

        }

        void fillGrid()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();
            da = new OleDbDataAdapter(@"SELECT * 
                               FROM kartlar
                               WHERE kullanici_id = @kullaniciId", conn);
            da.SelectCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            ds = new DataSet();

            da.Fill(ds, "kartlar");
            kartSilDaGrView.DataSource = ds.Tables["kartlar"];

            conn.Close();
        }


        private void kullaniciKartSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet18.kartlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kartlarTableAdapter.Fill(this.sONDataSet18.kartlar);

        }

        private void kartSilButton_Click(object sender, EventArgs e)
        {
            if (kartSilDaGrView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in kartSilDaGrView.SelectedRows)
                    {
                        try
                        {

                            silKartSatir(selectedRow);
                            kartSilDaGrView.Rows.Remove(selectedRow);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kayıt silme işlemi başarısız! Hata: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void silKartSatir(DataGridViewRow row)
        {
            int kart_id = Convert.ToInt32(row.Cells["kart_id"].Value);

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                using (cmd = new OleDbCommand("DELETE FROM kartlar WHERE kart_id = @kart_id", conn))
                {
                    cmd.Parameters.AddWithValue("@kart_id", kart_id);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Kayıt silme işlemi gerçekleştirilemedi.");
                    }
                }
            }
        }

        private void kartSilToOdemeIslemleri_Click(object sender, EventArgs e)
        {
            odemeIslemleri o1 = new odemeIslemleri(kullaniciId);
            o1.Show();
            this.Hide();
        }
    }
}
