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
    public partial class kullaniciKartListele : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        string accessPath = AccessPath.accessString;

        int kullaniciId;


        public kullaniciKartListele(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            fillGrid();
        }

        private void kullaniciKartListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet17.kartlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kartlarTableAdapter.Fill(this.sONDataSet17.kartlar);

        }

        void fillGrid()
        {
            conn = new OleDbConnection(accessPath);
            conn.Open();
            da = new OleDbDataAdapter(@"SELECT * 
                               FROM kartlar
                               WHERE kullanici_id = @kullaniciId", conn);
            da.SelectCommand.Parameters.AddWithValue("@kullaniciId",kullaniciId);

            ds = new DataSet();
            
            da.Fill(ds, "kartlar");
            kartListeleDaGrView.DataSource = ds.Tables["kartlar"];
            /*
            if (kartListeleDaGrView.Columns.Count == 1)
            {
                // Kalkış Havalimanı sütunu ekle
                DataGridViewTextBoxColumn kartNumarasiSutun = new DataGridViewTextBoxColumn();
                kartNumarasiSutun.HeaderText = "Kart Numarası";
                kartNumarasiSutun.DataPropertyName = "KalkisHavalimani";
                kartListeleDaGrView.Columns.Insert(1, kartNumarasiSutun);
                kartNumarasiSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Sütunun genişliği içeriğe göre otomatik olarak ayarlanacak



                // Varış Havalimanı sütunu ekle
                DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                kartListeleDaGrView.Columns.Insert(2, varisHavalimaniSutun);
                varisHavalimaniSutun.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            }
            */

            conn.Close();
        }

        private void kartListeleToOdemeIslemleri_Click(object sender, EventArgs e)
        {
            odemeIslemleri o1 = new odemeIslemleri(kullaniciId);
            o1.Show();
            this.Hide();
        }
    }
}
