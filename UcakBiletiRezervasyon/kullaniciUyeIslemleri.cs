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
    public partial class kullaniciUyeIslemleri : Form
    {
        int kullaniciId;

        public kullaniciUyeIslemleri(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void kullaniciBilgileriGuncelleButton_Click(object sender, EventArgs e)
        {
            UyelikGuncelle u1 = new UyelikGuncelle(kullaniciId);
            u1.Show();
            this.Hide();

        }

        private void kullaniciUyeligiSilButton_Click(object sender, EventArgs e)
        {
            kullaniciUyelikSil u2 = new kullaniciUyelikSil(kullaniciId);
            u2.Show();
            this.Hide();

        }

        private void uyeIslemleriToAraMenuButton_Click(object sender, EventArgs e)
        {
            kullaniciAraSayfa a1 = new kullaniciAraSayfa(kullaniciId);
            a1.Show();
            this.Hide();
        }
    }
}
