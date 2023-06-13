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
    public partial class AdminGirisEkrani : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds;

        string accessPath = AccessPath.accessString;


        public AdminGirisEkrani()
        {
            InitializeComponent();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);
            cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM admin WHERE mail_adresi='" + mailAdresiText.Text + "'AND sifre='" + sifreTexti.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                araSayfa a1 = new araSayfa();
                a1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Mail adresi veya şifre hatalı");
            }

            conn.Close();
        }


        private void sifremiUnuttumLabel_Click(object sender, EventArgs e)
        {

            SifremiUnuttum s1 = new SifremiUnuttum();
            s1.Show();
            this.Hide();

        }


       

        private void checkBoxSifreGosterv1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGosterv1.Checked)
            {
                sifreTexti.PasswordChar = '\0'; // null char default değer göstermek için
            }
            else
            {
                sifreTexti.PasswordChar = '•';
            }
        }

        private void buttonToKullaniciSece_Click(object sender, EventArgs e)
        {
            KullaniciSec k1 = new KullaniciSec();
            k1.Show();
            this.Hide();
        }
    }
}
