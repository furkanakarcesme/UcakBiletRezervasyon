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
    public partial class AdminUyelikGuncelle : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbDataReader dr;

        string accessPath = AccessPath.accessString;

        public AdminUyelikGuncelle()
        {
            InitializeComponent();
        }

        private void AdminUyelikGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void uyeKimlikGuncelleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminBilgiGetirGuncelleButton_Click(object sender, EventArgs e)
        {
            if (adminUyeKimlikRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);
                conn.Open();
                cmd = new OleDbCommand("SELECT * FROM uyeler WHERE kimlik_no='" + adminKimlikGuncelleText.Text + "'", conn);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    //bir önceki aramaya ait id'yi silmek için
                    adminUyeIdGuncelle.Text = "";
                    adminAdiGuncelleText.Text = dr["ad"].ToString();
                    adminSoyGuncelleText.Text = dr["soyad"].ToString();
                    adminDogumGuncelleText.Text = dr["dogum_tarihi"].ToString();
                    adminMailGuncelleText.Text = dr["mail_adresi"].ToString();
                    adminTelGuncelleText.Text = dr["tel"].ToString();
                    adminAdresGuncelleText.Text = dr["adres"].ToString();
                    adminSifreGuncelleText.Text = dr["sifre"].ToString();
                    adminSifreOnayGuncelleText.Text = dr["sifre"].ToString();

                }
                else
                {
                    MessageBox.Show("Hatalı kimlik numarası girişi yaptınız. Lütfen tekrar deneyin");
                }

                conn.Close();


            } else if (adminUyeIdRadioButton.Checked)
            {

           
                conn = new OleDbConnection(accessPath);
                conn.Open();
                cmd = new OleDbCommand("SELECT * FROM uyeler WHERE kullanici_id LIKE '" + adminUyeIdGuncelle.Text + "%'", conn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    adminKimlikGuncelleText.Text = dr["kimlik_no"].ToString();
                    adminAdiGuncelleText.Text = dr["ad"].ToString();
                    adminSoyGuncelleText.Text = dr["soyad"].ToString();
                    adminDogumGuncelleText.Text = dr["dogum_tarihi"].ToString();
                    adminMailGuncelleText.Text = dr["mail_adresi"].ToString();
                    adminTelGuncelleText.Text = dr["tel"].ToString();
                    adminAdresGuncelleText.Text = dr["adres"].ToString();
                    adminSifreGuncelleText.Text = dr["sifre"].ToString();
                    adminSifreOnayGuncelleText.Text = dr["sifre"].ToString();

                }
                else
                {
                    MessageBox.Show("Hatalı kimlik numarası girişi yaptınız. Lütfen tekrar deneyin");
                }

                conn.Close();


            }
            else
            {
                MessageBox.Show("Bilgileri getirmek için lütfen parametrelerden birini seçiniz.");
            }
        }

        private void adminUyeGuncelleButton_Click(object sender, EventArgs e)
        {
            if (adminAdiGuncelleText.Text != "" && adminSoyGuncelleText.Text != "" && adminDogumGuncelleText.Text != "" && adminMailGuncelleText.Text != "" && adminTelGuncelleText.Text != "" && adminAdresGuncelleText.Text != ""
                    && adminSifreGuncelleText.Text != "" && adminSifreOnayGuncelleText.Text != "")
            {

                if (adminSifreGuncelleText.Text == adminSifreOnayGuncelleText.Text)
                {

                    if (adminUyeKimlikRadioButton.Checked)
                    {
                        cmd = new OleDbCommand();
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE uyeler SET ad = @ad, soyad = @soyad, dogum_tarihi = @dogum_tarihi, mail_adresi = @mail_adresi, tel = @tel, adres = @adres, sifre = @sifre WHERE kimlik_no LIKE '" + adminKimlikGuncelleText.Text + "'";

                        cmd.Parameters.AddWithValue("@ad", adminAdiGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@soyad", adminSoyGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@dogum_tarihi", adminDogumGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@mail_adresi", adminMailGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@tel", adminTelGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@adres", adminAdresGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@sifre", adminSifreGuncelleText.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız");
                        }

                    } else if (adminUyeIdRadioButton.Checked)
                    {
                        cmd = new OleDbCommand();
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE uyeler SET ad = @ad, soyad = @soyad, dogum_tarihi = @dogum_tarihi, mail_adresi = @mail_adresi, tel = @tel, adres = @adres, sifre = @sifre WHERE kullanici_id LIKE '" + adminUyeIdGuncelle.Text + "%'";

                        cmd.Parameters.AddWithValue("@ad", adminAdiGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@soyad", adminSoyGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@dogum_tarihi", adminDogumGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@mail_adresi", adminMailGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@tel", adminTelGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@adres", adminAdresGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@sifre", adminSifreGuncelleText.Text);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız");
                        }
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
