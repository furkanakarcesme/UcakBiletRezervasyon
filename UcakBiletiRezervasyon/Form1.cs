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
    public partial class Form1 : Form
    {

        
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds;

        string accessPath = AccessPath.accessString;    //AccessPath.accessString;

        public Form1()
        {
            InitializeComponent();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmd.CommandText = "SELECT kullanici_id FROM uyeler WHERE mail_adresi='" + mailAdresText.Text + "' AND sifre='" + sifreText.Text + "'";
            dr = cmd.ExecuteReader();


            
            
            if (dr.Read())
            {
                int kullaniciId = (int)dr["kullanici_id"];
                //Session.KullaniciId = kullaniciId;

                kullaniciAraSayfa a1 = new kullaniciAraSayfa(kullaniciId); 
                a1.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Mail adresi veya şifre hatalı");
            }

            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeOl u1 = new UyeOl();
            u1.Show();
            this.Hide();
        }

        private void sifremiUnuttumLabel_Click(object sender, EventArgs e)
        {
            
            SifremiUnuttum s1 = new SifremiUnuttum();
            s1.Show();
            this.Hide();

        }

        private void sifreLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked)
            {
                sifreText.PasswordChar = '\0'; // null char default değer göstermek için
            } else
            {
                sifreText.PasswordChar = '•';
            }
                     
        }

        private void form1ToKullaniciSecButton_Click(object sender, EventArgs e)
        {
            KullaniciSec k1 = new KullaniciSec();
            k1.Show();  
            this.Hide();
        }
    }
}
