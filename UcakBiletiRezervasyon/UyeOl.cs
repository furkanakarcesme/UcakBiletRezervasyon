using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UcakBiletiRezervasyon
{
    public partial class UyeOl : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        string accessPath = AccessPath.accessString;


        public UyeOl()
        {
            InitializeComponent();
        }

        private void uyeKaydetButton_Click(object sender, EventArgs e)
        {

            if (uyeAdiKayitText.Text != "" && uyeSoyText.Text != "" && uyeKimlikText.Text != "" 
                    && uyeMailText.Text != "" && uyeTelText.Text != "" && uyeAdresText.Text != ""
                    && uyeSifreText.Text != "" && uyeSifreOnayText.Text != "")
            {

                if (uyeSifreText.Text == uyeSifreOnayText.Text)
                {
                    string query = "INSERT INTO uyeler (ad,soyad,kimlik_no,dogum_tarihi,mail_adresi,tel,adres,sifre) VALUES" +
                        "(@ad,@soyad,@kimlik_no,@dogum_tarihi,@mail_adresi,@tel,@adres,@sifre)";

                    conn = new OleDbConnection(accessPath);
                    cmd = new OleDbCommand(query, conn);

                    string tarih = uyeDateTimePicker.Value.ToShortDateString();

                    cmd.Parameters.AddWithValue("@ad", uyeAdiKayitText.Text);
                    cmd.Parameters.AddWithValue("@soyad", uyeSoyText.Text);
                    cmd.Parameters.AddWithValue("@kimlik_no", uyeKimlikText.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", tarih);
                    cmd.Parameters.AddWithValue("@mail_adresi", uyeMailText.Text);
                    cmd.Parameters.AddWithValue("@tel", uyeTelText.Text);
                    cmd.Parameters.AddWithValue("@adres", uyeAdresText.Text);
                    cmd.Parameters.AddWithValue("@sifre", uyeSifreText.Text);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Üye olma işlemi başarılı. Giriş sayfasına yönlendiriliyorsunuz");
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                    }
                        else
                    {
                        MessageBox.Show("Üye Olma işlemi başarısız.");
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

            conn.Close();// En son bunun yerini değiştirdim

        }
    }
}
