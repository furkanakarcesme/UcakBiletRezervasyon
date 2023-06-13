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
    public partial class kullaniciKartEkle : Form
    {
        
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        int kullaniciId;


        string accessPath = AccessPath.accessString;


        public kullaniciKartEkle(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        /*
        private void kartEkleButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);


            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO kartlar (kullanici_id, kart_numarasi, ay, yil, uc_hane) VALUES (?, ?, ?, ?, ?)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
            cmd.Parameters.AddWithValue("@kart_numarasi", kartEkleKartNumarasiTxt.Text);
            cmd.Parameters.AddWithValue("@ay", kartEkleAyTxt.Text);
            cmd.Parameters.AddWithValue("@yil", kartEkleYilTxt.Text);
            cmd.Parameters.AddWithValue("@uc_hane", kartEkleUcHaneTxt.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kart ekleme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Kart ekleme işlemi başarısız.");
            }

            conn.Close();

        }
        */




        private void kartEkleButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);


            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;


            cmd.CommandText = "SELECT COUNT(*) FROM kartlar WHERE kullanici_id = @kullanici_id AND kart_numarasi = @kart_numarasi";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
            cmd.Parameters.AddWithValue("@kart_numarasi", kartEkleKartNumarasiTxt.Text);
            int kartSayisi = Convert.ToInt32(cmd.ExecuteScalar());

            if (kartSayisi > 0)
            {
                MessageBox.Show("Bu kullanıcı zaten bu kart numarasına sahip.");
                return;
            } 
            else
            {
                cmd.CommandText = "INSERT INTO kartlar (kullanici_id, kart_numarasi, ay, yil, uc_hane) VALUES (?, ?, ?, ?, ?)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
                cmd.Parameters.AddWithValue("@kart_numarasi", kartEkleKartNumarasiTxt.Text);
                cmd.Parameters.AddWithValue("@ay", kartEkleAyTxt.Text);
                cmd.Parameters.AddWithValue("@yil", kartEkleYilTxt.Text);
                cmd.Parameters.AddWithValue("@uc_hane", kartEkleUcHaneTxt.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kart ekleme işlemi başarılı.");
                }
                else
                {
                    MessageBox.Show("Kart ekleme işlemi başarısız.");
                }

                conn.Close();
            }

        }



        private void kartEkleToOdemeIslemleriButton_Click(object sender, EventArgs e)
        {
            odemeIslemleri o1 = new odemeIslemleri(kullaniciId);
            o1.Show();
            this.Hide();
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciKartEkle_Load(object sender, EventArgs e)
        {

        }

        
    }
}
