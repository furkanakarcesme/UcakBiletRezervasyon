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
    public partial class UyelikGuncelle : Form
    {
        int kullaniciId;

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbDataReader dr;

        string accessPath = AccessPath.accessString;


        public UyelikGuncelle(int kullaniciId)
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
                uyeKimlikGuncelleText.ReadOnly = true;

                uyeKimlikGuncelleText.Text = dr["kimlik_no"].ToString();
                uyeAdiGuncelleText.Text = dr["ad"].ToString();
                uyeSoyGuncelleText.Text = dr["soyad"].ToString();
                uyeDogumGuncelleText.Text = dr["dogum_tarihi"].ToString();
                uyeMailGuncelleText.Text = dr["mail_adresi"].ToString();
                uyeTelGuncelleText.Text = dr["tel"].ToString();
                uyeAdresGuncelleText.Text = dr["adres"].ToString();
                uyeSifreGuncelleText.Text = dr["sifre"].ToString();
                uyeSifreOnayGuncelleText.Text = dr["sifre"].ToString();

            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi!");
            }

            conn.Close();
        }
        
        private void bilgiGetirGuncelleButton_Click(object sender, EventArgs e)
        {
           
        }

        private void uyeKaydetButton_Click(object sender, EventArgs e)
        {

            if (uyeMailGuncelleText.Text != "" && uyeTelGuncelleText.Text != "" && uyeAdresGuncelleText.Text != ""
                    && uyeSifreGuncelleText.Text != "" && uyeSifreOnayGuncelleText.Text != "")
            {

                if (uyeSifreGuncelleText.Text == uyeSifreOnayGuncelleText.Text)
                {
                    cmd = new OleDbCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE uyeler SET mail_adresi = @mail_adresi, tel = @tel, adres = @adres, sifre = @sifre WHERE kimlik_no ='" + uyeKimlikGuncelleText.Text + "'";


                    cmd.Parameters.AddWithValue("@mail_adresi", uyeMailGuncelleText.Text);
                    cmd.Parameters.AddWithValue("@tel", uyeTelGuncelleText.Text);
                    cmd.Parameters.AddWithValue("@adres", uyeAdresGuncelleText.Text);
                    cmd.Parameters.AddWithValue("@sifre", uyeSifreGuncelleText.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Güncelleme başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız");
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

        private void kullaniciUyelikGuncelleToUyeIslemleri_Click(object sender, EventArgs e)
        {
            kullaniciUyeIslemleri u1 = new kullaniciUyeIslemleri(kullaniciId);
            u1.Show();
            this.Hide();
        }
    }
}
