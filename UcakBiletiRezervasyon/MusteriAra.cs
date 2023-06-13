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
    public partial class MusteriAra : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        string accessPath = AccessPath.accessString;
        public MusteriAra()
        {
            InitializeComponent();
            fillGrid();
        }
        void fillGrid()
        {

            conn = new OleDbConnection(accessPath);
            da = new OleDbDataAdapter("Select kullanici_id, ad, soyad, kimlik_no, dogum_tarihi, mail_adresi, tel, adres, sifre FROM uyeler", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "uyeler");
            uyeAraDaGrView.DataSource = ds.Tables["uyeler"];
            conn.Close();

        }

        private void aramaButton_Click(object sender, EventArgs e)
        {

            
            
            if (uyeIdRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);
                da = new OleDbDataAdapter("Select kullanici_id, ad, soyad, kimlik_no, dogum_tarihi, mail_adresi, tel, adres, sifre FROM uyeler where kullanici_id like '"
                    + uyeIdAramaTextBox.Text + "%'", conn);
                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "uyeler");
                uyeAraDaGrView.DataSource = ds.Tables["uyeler"];
                conn.Close();


            } else if (adRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);
                da = new OleDbDataAdapter("Select kullanici_id, ad, soyad, kimlik_no, dogum_tarihi, mail_adresi, tel, adres, sifre FROM uyeler where ad like '"
                    + uyeIsimAramaTextBox.Text + "%'", conn);
                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "uyeler");
                uyeAraDaGrView.DataSource = ds.Tables["uyeler"];
                conn.Close();

            } else if (soyadRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);
                da = new OleDbDataAdapter("Select kullanici_id, ad, soyad, kimlik_no, dogum_tarihi, mail_adresi, tel, adres, sifre FROM uyeler where soyad like '"
                    + uyeSoyAramaTextBox.Text + "%'", conn);
                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "uyeler");
                uyeAraDaGrView.DataSource = ds.Tables["uyeler"];
                conn.Close();


            } else
            {
                MessageBox.Show("Lütfen arama yapmak istediğiniz parametreyi seçiniz ve tekrar deneyiniz!");
            }


        }

        private void MusteriAra_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet2.uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.sONDataSet2.uyeler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeIslemleri u1 = new UyeIslemleri();
            u1.Show();
            this.Hide();
        }
    }
}
