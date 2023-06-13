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
    public partial class BiletRezervasyonu : Form
    {

        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader dr;
        DataSet ds;
        OleDbDataAdapter da;

        string accessPath = AccessPath.accessString;

        public BiletRezervasyonu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM uyeBilgileri WHERE KimlikNo='" + kimlikResText.Text + "'", conn);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                kimlikResText.ReadOnly = true;
                uyeAdResText.ReadOnly = true;
                uyeSoyResText.ReadOnly = true;
                dogumTarihiResText.ReadOnly = true;
                uyeMailResText.ReadOnly = true;
                uyeTelResText.ReadOnly = true;
                uyeAdresResText.ReadOnly = true;

                uyeAdResText.Text = dr["Ad"].ToString();
                uyeSoyResText.Text = dr["Soyad"].ToString();
                dogumTarihiResText.Text = dr["DogumTarihi"].ToString();
                uyeMailResText.Text = dr["Mail"].ToString();
                uyeTelResText.Text = dr["Tel"].ToString();
                uyeAdresResText.Text = dr["Adres"].ToString();
                
            }
            else
            {
                MessageBox.Show("Hatalı kimlik numarası girişi yaptınız. Lütfen tekrar deneyin");
            }

            conn.Close();
        }





        private void BiletRezervasyonu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev2DataSet7.havalimanlari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimanlariTableAdapter3.Fill(this.odev2DataSet7.havalimanlari);
            // TODO: Bu kod satırı 'odev2DataSet6.havalimanlari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimanlariTableAdapter2.Fill(this.odev2DataSet6.havalimanlari);

        }

        private void showFlightsButton_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(accessPath);
            da = new OleDbDataAdapter("SELECT Kalkis, Varis, UcusTarihiDeneme, KalkisSaat, InisSaat, UcusSuresi, Ucret FROM ucuslar where Kalkis LIKE '"
                + comboBox1.Text + "%'", conn);
            ds = new DataSet();
            conn.Open();
            
            da.Fill(ds, "ucuslar");
            ucuslarDataGridView.DataSource = ds.Tables["ucuslar"];
            ucuslarDataGridView.Columns["KalkisSaat"].DefaultCellStyle.Format = "HH:mm";
            ucuslarDataGridView.Columns["InisSaat"].DefaultCellStyle.Format = "HH:mm";
            ucuslarDataGridView.Columns["UcusSuresi"].DefaultCellStyle.Format = "HH:mm";
            

            conn.Close();
        }

        private void ucuslarDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            
            uyeUcusTarihiResText.Text = ucuslarDataGridView.CurrentRow.Cells[2].Value.ToString();
            kalkisSaatiResText.Text = ucuslarDataGridView.CurrentRow.Cells[3].Value.ToString();
            ucretResText.Text = ucuslarDataGridView.CurrentRow.Cells[6].Value.ToString();
            uyeUcusTarihiResText.ReadOnly = true;
            kalkisSaatiResText.ReadOnly = true;
            ucretResText.ReadOnly = true;
            
            
        }
    }
}
