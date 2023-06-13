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
    public partial class AdminUcusGuncelle : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbDataReader dr;

        string accessPath = AccessPath.accessString;


        public AdminUcusGuncelle()
        {
            InitializeComponent();
        }

        private void adminUcusGetirGuncelleButton_Click(object sender, EventArgs e)
        {
            if (adminUcusIdRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);
                conn.Open();
                cmd = new OleDbCommand(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                               WHERE ucus_id LIKE '" + adminUcusIdAramaGuncelleText.Text + "%'", conn);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    
                    //bir önceki aramaya ait id'yi silmek için
                    adminUcusTarihiAramaGuncelle.Text = "";
                    
                    adminUcusKalkisIDGuncelleText.Text = dr["KalkisHavalimani"].ToString();
                    adminUcusVarisIDGuncelleText.Text = dr["VarisHavalimani"].ToString();
                    
                    adminUcusTarihiGuncelleText.Text = dr["ucus_tarihi"].ToString();
                    adminKalkisSaatGuncelleText.Text = dr["kalkis_saati"].ToString();
                    adminVarisSaatGuncelleText.Text = dr["inis_saati"].ToString();
                    adminUcretUcusGuncelleText.Text = dr["ucret"].ToString();

                    adminUcusKalkisIDGuncelleText.ReadOnly = true;
                    adminUcusVarisIDGuncelleText.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Hatalı uçuş id girişi yaptınız. Lütfen tekrar deneyin");
                }

                conn.Close();


            }
            else if (adminUcusTarihiRadioButton.Checked)
            {

                
                conn = new OleDbConnection(accessPath);
                conn.Open();
                cmd = new OleDbCommand(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                               WHERE ucuslar.ucus_tarihi LIKE '" + adminUcusTarihiAramaGuncelle.Text + "%'", conn);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    //bir önceki aramaya ait id'yi silmek için
                    adminUcusIdAramaGuncelleText.Text = "";
                    adminUcusKalkisIDGuncelleText.Text = dr["KalkisHavalimani"].ToString();
                    adminUcusVarisIDGuncelleText.Text = dr["VarisHavalimani"].ToString();

                    adminUcusTarihiGuncelleText.Text = dr["ucus_tarihi"].ToString();
                    adminKalkisSaatGuncelleText.Text = dr["kalkis_saati"].ToString();
                    adminVarisSaatGuncelleText.Text = dr["inis_saati"].ToString();
                    adminUcretUcusGuncelleText.Text = dr["ucret"].ToString();

                    adminUcusKalkisIDGuncelleText.ReadOnly = true;
                    adminUcusVarisIDGuncelleText.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Hatalı uçuş tarihi girişi yaptınız. Lütfen tekrar deneyin");
                }

                conn.Close();
                

            }
            else
            {
                MessageBox.Show("Bilgileri getirmek için lütfen parametrelerden birini seçiniz.");
            }
        }

        private void adminUcusGuncelleButton_Click(object sender, EventArgs e)
        {
            if (adminUcusTarihiGuncelleText.Text != "" && adminKalkisSaatGuncelleText.Text != "" && adminVarisSaatGuncelleText.Text != "" 
                && adminUcretUcusGuncelleText.Text != "")
            {

                if (adminUcusIdRadioButton.Checked)
                    {
                        cmd = new OleDbCommand();
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE ucuslar SET ucus_tarihi = @ucus_tarihi, kalkis_saati = @kalkis_saati, inis_saati = @inis_saati, ucret = @ucret WHERE ucus_id LIKE '" + adminUcusIdAramaGuncelleText.Text + "%'";

                        cmd.Parameters.AddWithValue("@ucus_tarihi", adminUcusTarihiGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@kalkis_saati", adminKalkisSaatGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@inis_saati", adminVarisSaatGuncelleText.Text);
                        cmd.Parameters.AddWithValue("@ucret", adminUcretUcusGuncelleText.Text);
                        

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız");
                        }

                }
                else if (adminUcusTarihiRadioButton.Checked)
                {
                    cmd = new OleDbCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE ucuslar SET ucus_tarihi = @ucus_tarihi, kalkis_saati = @kalkis_saati, inis_saati = @inis_saati, ucret = @ucret WHERE ucus_tarihi LIKE '" + adminUcusTarihiAramaGuncelle.Text + "%'";

                    cmd.Parameters.AddWithValue("@ucus_tarihi", adminUcusTarihiGuncelleText.Text);
                    cmd.Parameters.AddWithValue("@kalkis_saati", adminKalkisSaatGuncelleText.Text);
                    cmd.Parameters.AddWithValue("@inis_saati", adminVarisSaatGuncelleText.Text);
                    cmd.Parameters.AddWithValue("@ucret", adminUcretUcusGuncelleText.Text);


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
                MessageBox.Show("Lütfen tüm boşlukları doldurup tekrar deneyiniz!");
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusIslemleri u1 = new UcusIslemleri();
            u1.Show();
            this.Hide();
        }
    }
}
