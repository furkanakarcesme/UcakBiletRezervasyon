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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UcakBiletiRezervasyon
{
    public partial class UcuslarListesi : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        string accessPath = AccessPath.accessString;


        public UcuslarListesi()
        {
            InitializeComponent();
            fillGrid();
        }

        void fillGrid()
        {

            conn = new OleDbConnection(accessPath);

            ucusListeleUcusAramaDaGrView.AutoGenerateColumns = false;

            da = new OleDbDataAdapter(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "ucuslar");
            ucusListeleUcusAramaDaGrView.DataSource = ds.Tables["ucuslar"];


            // Kalkış Havalimanı sütunu ekle
            DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
            kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
            kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
            ucusListeleUcusAramaDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

            // Varış Havalimanı sütunu ekle
            DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
            varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
            varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
            ucusListeleUcusAramaDaGrView.Columns.Insert(2, varisHavalimaniSutun);


            conn.Close();
        }



        private void UcuslarListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet1.havalimani_v' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_vTableAdapter.Fill(this.sONDataSet1.havalimani_v);
            // TODO: Bu kod satırı 'sONDataSet.havalimani_k' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_kTableAdapter.Fill(this.sONDataSet.havalimani_k);
            // TODO: Bu kod satırı 'sONDataSet5.ucuslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucuslarTableAdapter.Fill(this.sONDataSet5.ucuslar);

        }

        private void aramaButton_Click(object sender, EventArgs e)
        {
            if (ucusListeleUcusIdyeGoreRadioButton.Checked)
            {
                conn = new OleDbConnection(accessPath);

                ucusListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                da = new OleDbDataAdapter(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id 
                               WHERE ucus_id LIKE '" + ucusListeleUcusIdAramaTextBox.Text + "%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@ucus_id", ucusListeleUcusIdAramaTextBox.Text + "%");

                
                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "ucuslar");
                ucusListeleUcusAramaDaGrView.DataSource = ds.Tables["ucuslar"];


                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (ucusListeleUcusAramaDaGrView.Columns.Count == 5)
                {
                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    ucusListeleUcusAramaDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    ucusListeleUcusAramaDaGrView.Columns.Insert(2, varisHavalimaniSutun);

                }


                conn.Close();

            }
            else if (ucusListeleUcusTarihineGoreRadioButton.Checked)
            {

             
                conn = new OleDbConnection(accessPath);

                ucusListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                da = new OleDbDataAdapter(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                               WHERE ucuslar.ucus_tarihi LIKE '" + ucusListeleUcustarihiAramaTextBox.Text + "%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@ucus_tarihi", ucusListeleUcustarihiAramaTextBox.Text + "%");

                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "ucuslar");
                ucusListeleUcusAramaDaGrView.DataSource = ds.Tables["ucuslar"];

                //ucusListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (ucusListeleUcusAramaDaGrView.Columns.Count == 5)
                {
                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    ucusListeleUcusAramaDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    ucusListeleUcusAramaDaGrView.Columns.Insert(2, varisHavalimaniSutun);

                }

                conn.Close();

            }
            else if (ucusListeleKonumaGoreRadioButton.Checked)
            {

                string kalkisHavalimani = kalkisHavalimaniUcusListeleComboBox.Text;
                string varisHavalimani = varisHavalimaniUcusListesiComboBox.Text;

                conn = new OleDbConnection(accessPath);
                da = new OleDbDataAdapter(@"SELECT ucuslar.ucus_id, 
                                      havalimani_k.havalimani_adi AS KalkisHavalimani,
                                      havalimani_v.havalimani_adi AS VarisHavalimani,
                                      ucuslar.kalkis_saati,
                                      ucuslar.inis_saati,
                                      ucuslar.ucus_tarihi,
                                      ucuslar.ucret 
                               FROM (ucuslar
                               INNER JOIN havalimani_k ON ucuslar.kalkis_yeri_id = havalimani_k.havalimani_id)
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id
                               WHERE havalimani_k.havalimani_adi = @kalkisHavalimani
                               AND havalimani_v.havalimani_adi = @varisHavalimani", conn);

                da.SelectCommand.Parameters.AddWithValue("@kalkisHavalimani", kalkisHavalimani);
                da.SelectCommand.Parameters.AddWithValue("@varisHavalimani", varisHavalimani);

                ds = new DataSet();
                conn.Open();

                da.Fill(ds, "ucuslar");
                ucusListeleUcusAramaDaGrView.DataSource = ds.Tables["ucuslar"];

                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (ucusListeleUcusAramaDaGrView.Columns.Count == 5)
                {
                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    ucusListeleUcusAramaDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    ucusListeleUcusAramaDaGrView.Columns.Insert(2, varisHavalimaniSutun);

                }

                conn.Close();

            }
            else
            {

                MessageBox.Show("Lütfen arama yapmak istediğiniz parametreyi seçiniz ve tekrar deneyiniz!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusIslemleri u1 = new UcusIslemleri();
            u1.Show();
            this.Hide();
        }
    }
}
