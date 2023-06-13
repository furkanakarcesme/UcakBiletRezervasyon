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
    public partial class RezIslemleri : Form
    {
        

        public RezIslemleri()
        {
            InitializeComponent();
            
        }

        private void rezGoruntuleButton_Click(object sender, EventArgs e)
        {
            RezGoruntule r1 = new RezGoruntule();
            r1.Show();
            this.Hide(); // admin menüsü
        }

        private void rezSilButton_Click(object sender, EventArgs e)
        {
            RezSil r2 = new RezSil();
            r2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            araSayfa a1 = new araSayfa();   
            a1.Show();
            this.Hide();    
        }
    }
}
