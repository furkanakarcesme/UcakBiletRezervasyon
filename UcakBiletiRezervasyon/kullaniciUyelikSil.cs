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
    public partial class kullaniciUyelikSil : Form
    {


        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbDataReader dr;

        string accessPath = AccessPath.accessString;

        int kullaniciId;

        public kullaniciUyelikSil(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            fillGrid();
        }

        void fillGrid()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM uyeler WHERE kullanici_id= @kullaniciId", conn);
            cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                

                kullaniciKimlikSilTxt.Text = dr["kimlik_no"].ToString();
                kullaniciAdSilTxt.Text = dr["ad"].ToString();
                kullaniciSoyadSilTxt.Text = dr["soyad"].ToString();
                kullaniciDogumTarihiSilTxt.Text = dr["dogum_tarihi"].ToString();
                kullaniciMailSilTxt.Text = dr["mail_adresi"].ToString();
                kullaniciTelSilTxt.Text = dr["tel"].ToString();
                kullaniciAdresSilTxt.Text = dr["adres"].ToString();
                kullaniciSifreSilTxt.Text = dr["sifre"].ToString();
                kullaniciSifreOnaySilTxt.Text = dr["sifre"].ToString();

            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi!");
            }

            conn.Close();
        }


        private void kullaniciUyeSilButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();
            cmd = new OleDbCommand("DELETE FROM uyeler WHERE kullanici_id= @kullaniciId", conn);
            cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            

            if (cmd.ExecuteNonQuery() > 0 )
            {
                MessageBox.Show("Üyelik Silme işlemi başarılı. Giriş ekranına yönlendiriliyorsunuz!");
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi!");
            }

            conn.Close();
        }

        private void kullaniciUyelikSilToUyeIslemleri_Click(object sender, EventArgs e)
        {
            kullaniciUyeIslemleri u1 = new kullaniciUyeIslemleri(kullaniciId);
            u1.Show();
            this.Hide();

            
        }
    }
}
