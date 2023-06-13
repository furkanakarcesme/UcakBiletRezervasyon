using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiRezervasyon
{
    public partial class odemeIslemleri : Form
    {
        int kullaniciId;
        public odemeIslemleri(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void odemeToAraSayfaButton_Click(object sender, EventArgs e)
        {
            kullaniciAraSayfa a1 = new kullaniciAraSayfa(kullaniciId);
            a1.Show();
            this.Hide();
        }

        private void kartListeleyeYonlendirButton_Click(object sender, EventArgs e)
        {
            kullaniciKartListele k1 = new kullaniciKartListele(kullaniciId);
            k1.Show();
            this.Hide();
        }

        private void kartEkleyeYonlendirButton_Click(object sender, EventArgs e)
        {
            kullaniciKartEkle k2 = new kullaniciKartEkle(kullaniciId);
            k2.Show();
            this.Hide();

        }

        private void kartSileYonlendirButton_Click(object sender, EventArgs e)
        {
            kullaniciKartSil k3 = new kullaniciKartSil(kullaniciId);
            k3.Show();
            this.Hide();
        }
    }
}
