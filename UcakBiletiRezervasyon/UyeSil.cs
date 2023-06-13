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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UcakBiletiRezervasyon
{
    public partial class UyeSil : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        string accessPath = AccessPath.accessString;


        public UyeSil()
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
            uyeSilDaGrView.DataSource = ds.Tables["uyeler"];
            conn.Close();

        }

        private void UyeSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet3.uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.sONDataSet3.uyeler);

        }

        private void aramaSButton_Click(object sender, EventArgs e)
        {
            if (uyeIdSilRadioButton.Checked)
            {
                uyeKimlikSilTextBox.Text = "";
                conn = new OleDbConnection(accessPath);
                da = new OleDbDataAdapter("Select kullanici_id, ad, soyad, kimlik_no, dogum_tarihi, mail_adresi, tel, adres, sifre FROM uyeler where kullanici_id like '"
                    + uyeIdSilTextBox.Text + "%'", conn);
                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "uyeler");
                uyeSilDaGrView.DataSource = ds.Tables["uyeler"];
                conn.Close();


            }
            else if (kimlikSilRadioButton.Checked)
            {
                uyeIdSilTextBox.Text = "";
                conn = new OleDbConnection(accessPath);
                da = new OleDbDataAdapter("Select kullanici_id, ad, soyad, kimlik_no, dogum_tarihi, mail_adresi, tel, adres, sifre FROM uyeler where kimlik_no like '"
                    + uyeKimlikSilTextBox.Text + "%'", conn);
                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "uyeler");
                uyeSilDaGrView.DataSource = ds.Tables["uyeler"];
                conn.Close();

            }
            
            else
            {
                MessageBox.Show("Lütfen arama yapmak istediğiniz parametreyi seçiniz ve tekrar deneyiniz!");
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {

            if (uyeIdSilRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);
                cmd = new OleDbCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM uyeler WHERE kullanici_id LIKE '" + uyeIdSilTextBox.Text + "%'";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt silme işlemi başarılı!");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız!");
                }

                conn.Close();
                fillGrid();

            
            } 
            else if (kimlikSilRadioButton.Checked)
            {
                
                conn = new OleDbConnection(accessPath);
                cmd = new OleDbCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM uyeler WHERE kimlik_no LIKE '" + uyeKimlikSilTextBox.Text + "%'";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt silme işlemi başarılı!");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız!");
                }

                conn.Close();
                fillGrid();

            }
            else
            {
                MessageBox.Show("Lütfen arama yapmak istediğiniz parametreyi seçiniz ve tekrar deneyiniz!");
            }
            
        }

        private void kimlikSilRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uyeKimlikSilTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeIdSilTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeSilDaGrView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uyeIdSilRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uyeSilLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeIslemleri u1 = new UyeIslemleri();
            u1.Show();
            this.Hide();

        }
    }
}
