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
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriAra m1 = new MusteriAra();
            m1.Show();
            this.Hide();
        }

        private void uyeDuzenleyeGit_Click(object sender, EventArgs e)
        {
            AdminUyelikGuncelle a1 = new AdminUyelikGuncelle();
            a1.Show();
            this.Hide();
        }

        private void uyeEkleyeGit_Click(object sender, EventArgs e)
        {
            UyeEkle u1 = new UyeEkle();
            u1.Show();
            this.Hide();
        }

        private void uyeSileGit_Click(object sender, EventArgs e)
        {
            UyeSil u2 = new UyeSil();
            u2.Show();
            this.Hide();
        }

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            araSayfa a1 = new araSayfa();
            a1.Show();
            this.Hide();
        }
    }
}
