using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AkilliEvOtomasyonu
{
    public partial class FrmOdalar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ENES\\SQLEXPRESS01;Initial Catalog=AkilliEvDb;Integrated Security=True");
        int secilenOdaID = 0;
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Odalar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
                baglanti.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Odalar (OdaAdi) VALUES (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtOdaAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Oda Eklendi!");
                btnListele.PerformClick(); 
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                secilenOdaID = int.Parse(satir.Cells[0].Value.ToString());
                txtOdaAdi.Text = satir.Cells[1].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Odalar SET OdaAdi=@p1 WHERE OdaID=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtOdaAdi.Text);
                komut.Parameters.AddWithValue("@p2", secilenOdaID);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Oda İsmi Güncellendi!");
                btnListele.PerformClick();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Odalar WHERE OdaID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", secilenOdaID);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Oda Silindi!");
                btnListele.PerformClick();
            }
            catch (Exception)
            {
              
                MessageBox.Show("Bu odayı silemezsiniz! Önce içindeki cihazları silmeniz gerekiyor.");
                baglanti.Close();
            }
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {

        }
    }
}
