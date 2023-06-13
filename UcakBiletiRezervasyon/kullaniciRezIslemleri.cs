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
    public partial class kullaniciRezIslemleri : Form
    {

        int kullaniciId;
        public kullaniciRezIslemleri(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }

        private void kullaniciRezGoruntuleButton_Click(object sender, EventArgs e)
        {
            kullaniciRez_Listele r1 = new kullaniciRez_Listele(kullaniciId);
            r1.Show();
            this.Hide();


        }

        private void kullaniciRezSilButton_Click(object sender, EventArgs e)
        {
            kullaniciRezSil r2 = new kullaniciRezSil(kullaniciId);
            r2.Show();
            this.Hide();
        }

        private void rezIslemleriToAraSayfa_Click(object sender, EventArgs e)
        {
            kullaniciAraSayfa a1 = new kullaniciAraSayfa(kullaniciId);
            a1.Show();  
            this.Hide();
        }
    }
}
