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
    public partial class UcusuSil : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;


        string accessPath = AccessPath.accessString;


        public UcusuSil()
        {
            InitializeComponent();
            fillGrid();
        }


        void fillGrid()
        {

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
                               INNER JOIN havalimani_v ON ucuslar.varis_yeri_id = havalimani_v.havalimani_id", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "ucuslar");
            ucusSilAdminDaGrView.DataSource = ds.Tables["ucuslar"];


            // Kalkış Havalimanı sütunu ekle
            DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
            kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
            kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
            ucusSilAdminDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

            // Varış Havalimanı sütunu ekle
            DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
            varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
            varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
            ucusSilAdminDaGrView.Columns.Insert(2, varisHavalimaniSutun);


            conn.Close();

        }


        private void UcusuSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sONDataSet9.havalimani_v' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_vTableAdapter.Fill(this.sONDataSet9.havalimani_v);
            // TODO: Bu kod satırı 'sONDataSet8.havalimani_k' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havalimani_kTableAdapter.Fill(this.sONDataSet8.havalimani_k);
            // TODO: Bu kod satırı 'sONDataSet4.ucuslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucuslarTableAdapter.Fill(this.sONDataSet4.ucuslar);

        }


        private void aramaUcusSilButton_Click(object sender, EventArgs e)
        {
            if (ucusIdSilRadioButton.Checked)
            {
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
                               WHERE ucus_id LIKE '" + ucusIdSilTextBox.Text + "%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@ucus_id", ucusIdSilTextBox.Text + "%");


                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "ucuslar");
                ucusSilAdminDaGrView.DataSource = ds.Tables["ucuslar"];


                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (ucusSilAdminDaGrView.Columns.Count == 5)
                {
                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    ucusSilAdminDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    ucusSilAdminDaGrView.Columns.Insert(2, varisHavalimaniSutun);

                }


                conn.Close();

            }
            else if (ucusTarihiSilRadioButton.Checked)
            {


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
                               WHERE ucuslar.ucus_tarihi LIKE '" + ucusTarihiSilTextBox.Text + "%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@ucus_tarihi", ucusTarihiSilTextBox.Text + "%");

                ds = new DataSet();
                conn.Open();
                da.Fill(ds, "ucuslar");
                ucusSilAdminDaGrView.DataSource = ds.Tables["ucuslar"];

                //ucusListeleUcusAramaDaGrView.AutoGenerateColumns = false;


                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (ucusSilAdminDaGrView.Columns.Count == 5)
                {
                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    ucusSilAdminDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    ucusSilAdminDaGrView.Columns.Insert(2, varisHavalimaniSutun);

                }

                conn.Close();

            }
            else if (ucusSilKonumaGoreRadioButton.Checked)
            {

                string kalkisHavalimani = kalkisHavalimaniUcusSilComboBox.Text;
                string varisHavalimani = varisHavalimaniUcusSilComboBox.Text;

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
                ucusSilAdminDaGrView.DataSource = ds.Tables["ucuslar"];

                // Sadece ilk arama yapıldığında tablolar oluşsun tekrar tekrar oluşmasın diye kontrol yapılır
                if (ucusSilAdminDaGrView.Columns.Count == 5)
                {
                    // Kalkış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn kalkisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    kalkisHavalimaniSutun.HeaderText = "Kalkış Havalimanı";
                    kalkisHavalimaniSutun.DataPropertyName = "KalkisHavalimani";
                    ucusSilAdminDaGrView.Columns.Insert(1, kalkisHavalimaniSutun);

                    // Varış Havalimanı sütunu ekle
                    DataGridViewTextBoxColumn varisHavalimaniSutun = new DataGridViewTextBoxColumn();
                    varisHavalimaniSutun.HeaderText = "Varış Havalimanı";
                    varisHavalimaniSutun.DataPropertyName = "VarisHavalimani";
                    ucusSilAdminDaGrView.Columns.Insert(2, varisHavalimaniSutun);

                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("Lütfen arama yapmak istediğiniz parametreyi seçiniz ve tekrar deneyiniz!");
            }

        }


        private void ucusSilButton_Click(object sender, EventArgs e)
        {
            if (ucusSilAdminDaGrView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in ucusSilAdminDaGrView.SelectedRows)
                    {
                        try
                        {

                            silSatir(selectedRow);
                            ucusSilAdminDaGrView.Rows.Remove(selectedRow);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kayıt silme işlemi başarısız! Hata: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void silSatir(DataGridViewRow row)
        {
            int ucus_id = Convert.ToInt32(row.Cells["ucus_id"].Value);

            using (conn = new OleDbConnection(accessPath))
            {
                conn.Open();

                using (cmd = new OleDbCommand("DELETE FROM ucuslar WHERE ucus_id = @ucus_id", conn))
                {
                    cmd.Parameters.AddWithValue("@ucus_id", ucus_id);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("Kayıt silme işlemi gerçekleştirilemedi.");
                    }
                }
            }
        }


        private void ucusSilAdminDaGrView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusIslemleri u1 = new UcusIslemleri();
            u1.Show();
            this.Hide();
        }
    }
}
