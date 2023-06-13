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
    public partial class araSayfa : Form
    {
        public araSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusIslemleri u1 = new UcusIslemleri();
            u1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeIslemleri u2 = new UyeIslemleri();
            u2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RezIslemleri r1 = new RezIslemleri();
            r1.Show();  
            this.Hide();    
        }

        private void cikisYappButton_Click(object sender, EventArgs e)
        {
            AdminGirisEkrani a1 = new AdminGirisEkrani();
            a1.Show();
            this.Hide();
        }
    }
}
