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
    public partial class UcusIslemleri : Form
    {
        public UcusIslemleri()
        {
            InitializeComponent();
        }

        private void ucusEkleButton_Click(object sender, EventArgs e)
        {
            UcusEkle u1 = new UcusEkle();
            u1.Show();
            this.Hide();
        }

        private void ucusSilButton_Click(object sender, EventArgs e)
        {
            UcusuSil u2 = new UcusuSil();
            u2.Show();
            this.Hide();
        }

        private void ucusBilgiGuncelleButton_Click(object sender, EventArgs e)
        {
            AdminUcusGuncelle u3 = new AdminUcusGuncelle();
            u3.Show();
            this.Hide();    
        }

        private void ucuslarButton_Click(object sender, EventArgs e)
        {
            UcuslarListesi u4 = new UcuslarListesi();
            u4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGirisEkrani a1 = new AdminGirisEkrani();
            a1.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            araSayfa a2 = new araSayfa();   
            a2.Show();
            this.Hide();
        }
    }
}
