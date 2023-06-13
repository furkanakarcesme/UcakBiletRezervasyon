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
    public partial class kullaniciAraSayfa : Form
    {
        int kullaniciId;

        public kullaniciAraSayfa(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void chechInYonlendir_Click(object sender, EventArgs e)
        {
            kullaniciCheckIn c1 = new kullaniciCheckIn(kullaniciId);
            c1.Show();
            this.Hide();
        }

        private void rezervasyonIslemleriYonlendir_Click(object sender, EventArgs e)
        {
            kullaniciRezIslemleri r1 = new kullaniciRezIslemleri(kullaniciId);
            r1.Show();
            this.Hide();
        }

        private void biletAlYonlendir_Click(object sender, EventArgs e)
        {
            kullaniciBiletAl b1 = new kullaniciBiletAl(kullaniciId);
            b1.Show();
            this.Hide();
        }

        private void odemeIslemleriYonlendir_Click(object sender, EventArgs e)
        {
            odemeIslemleri o1 = new odemeIslemleri(kullaniciId);
            o1.Show();
            this.Hide();
        }

        private void geriGirisSayfasinaButton_Click(object sender, EventArgs e)
        {
            KullaniciSec k1 = new KullaniciSec();
            k1.Show();
            this.Hide();
        }

        private void uyeIslemleriYonlendir_Click(object sender, EventArgs e)
        {
            kullaniciUyeIslemleri u1 = new kullaniciUyeIslemleri(kullaniciId);
            u1.Show();
            this.Hide();
        }
    }
}
