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
    public partial class SifremiUnuttum : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds;

        string accessPath = AccessPath.accessString;
        

        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void ePostaLabel_Click(object sender, EventArgs e)
        {

        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            if (mailTextBox.Text != "")
            {

                conn = new OleDbConnection(accessPath);
                cmd = new OleDbCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "Select * FROM uyeler WHERE mail_adresi='" + mailTextBox.Text + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Mail adresine şifre resetlemek için link gönderildi!");
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Mail adresi veri tabanında bulunamadı!");
                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("Lütfen mail adresinizi giriniz");
            }
            
            
        }
    }
}
