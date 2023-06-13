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
    public partial class UyeEkle : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        string accessPath = AccessPath.accessString;


        public UyeEkle()
        {
            InitializeComponent();
        }

        private void uyeEkleButton_Click(object sender, EventArgs e)
        {
            if (uyeAdiEkleKayitText.Text != "" && uyeSoyEkleText.Text != "" && uyeKimlikEkleText.Text != ""
                    && uyeMailEkleText.Text != "" && uyeTelEkleText.Text != "" && uyeAdresEkleText.Text != ""
                    && uyeSifreEkleText.Text != "" && uyeSifreEkleOnayText.Text != "")
            {

                if (uyeSifreEkleText.Text == uyeSifreEkleOnayText.Text)
                {
                    string query = "INSERT INTO uyeler (ad,soyad,kimlik_no,dogum_tarihi,mail_adresi,tel,adres,sifre) VALUES" +
                        "(@ad,@soyad,@kimlik_no,@dogum_tarihi,@mail_adresi,@tel,@adres,@sifre)";

                    conn = new OleDbConnection(accessPath);
                    cmd = new OleDbCommand(query, conn);

                    string tarih = uyeEkleDateTimePicker.Value.ToShortDateString();

                    cmd.Parameters.AddWithValue("@ad", uyeAdiEkleKayitText.Text);
                    cmd.Parameters.AddWithValue("@soyad", uyeSoyEkleText.Text);
                    cmd.Parameters.AddWithValue("@kimlik_no", uyeKimlikEkleText.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", tarih);
                    cmd.Parameters.AddWithValue("@mail_adresi", uyeMailEkleText.Text);
                    cmd.Parameters.AddWithValue("@tel", uyeTelEkleText.Text);
                    cmd.Parameters.AddWithValue("@adres", uyeAdresEkleText.Text);
                    cmd.Parameters.AddWithValue("@sifre", uyeSifreEkleText.Text);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Üye ekleme işlemi başarılı. Üye işlemleri sayfasına yönlendiriliyorsunuz");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Üye ekleme işlemi başarısız.");
                    }




                }
                else
                {
                    MessageBox.Show("Girilen şifreler birbiriyle uyuşmuyor");
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurup tekrar deneyiniz!");
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeIslemleri u1 = new UyeIslemleri();
            u1.Show();
            this.Hide();
        }
    }
}
