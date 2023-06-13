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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UcakBiletiRezervasyon
{
    public partial class UcusEkle : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;



        string accessPath = AccessPath.accessString;
        public UcusEkle()
        {
            InitializeComponent();
        }

        private void ucusInfoKaydetButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);

            
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            
            string tarih1 = dateTimePickerUcusTarihi.Value.ToShortDateString();

            string kalkis_adi = kalkisComboBox.Text;
            string varis_adi = varisComboBox.Text;

            // Kalkış havalimanı ID'sini almak için sorgu
            cmd.CommandText = "SELECT havalimani_id FROM havalimani_k WHERE havalimani_adi = ?";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@kalkis_adi", kalkis_adi);
            
            int kalkis_id = (int)cmd.ExecuteScalar();

            // Varış havalimanı ID'sini almak için sorgu
            cmd.CommandText = "SELECT havalimani_id FROM havalimani_v WHERE havalimani_adi = ?";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@varis_adi", varis_adi);
            
            int varis_id = (int)cmd.ExecuteScalar();

            // Uçuşları eklemek için sorgu
            cmd.CommandText = "INSERT INTO ucuslar (kalkis_yeri_id, varis_yeri_id, ucus_tarihi, kalkis_saati, inis_saati, ucret) VALUES (?, ?, ?, ?, ?, ?)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@kalkis_id", kalkis_id);
            cmd.Parameters.AddWithValue("@varis_id", varis_id);
            cmd.Parameters.AddWithValue("@ucus_tarihi", tarih1);
            cmd.Parameters.AddWithValue("@kalkis_saati", kalkisSaatText.Text);
            cmd.Parameters.AddWithValue("@inis_saati", varisSaatText.Text);
            cmd.Parameters.AddWithValue("@ucret", ucretUcusEkleText.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Ucus ekleme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Ucus ekleme işlemi başarısız.");
            }


            conn.Close();
        }

        private void UcusEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet1.havalimani_v' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_vTableAdapter.Fill(this.sONDataSet1.havalimani_v);
            // TODO: Bu kod satırı 'sONDataSet.havalimani_k' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_kTableAdapter.Fill(this.sONDataSet.havalimani_k);

        }

        private void koltukSayisiEcoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusIslemleri u1 = new UcusIslemleri();
            u1.Show();
            this.Hide();
        }
    }
}
