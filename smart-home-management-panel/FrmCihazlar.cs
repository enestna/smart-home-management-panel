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
    public partial class FrmCihazlar : Form
    {

       
        SqlConnection baglanti = new SqlConnection("Data Source=ENES\\SQLEXPRESS01;Initial Catalog=AkilliEvDb;Integrated Security=True");
        public FrmCihazlar()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
               
                baglanti.Open();

                
                string sorgu = "SELECT c.CihazID, c.CihazAdi, c.Tuketim, c.Durum, o.OdaAdi " +
                               "FROM Cihazlar c " +
                               "JOIN Odalar o ON c.OdaID = o.OdaID";

               
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
            finally
            {
                
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdalarKutusunuDoldur();

            
            btnListele.PerformClick();
        }

        

        void OdalarKutusunuDoldur()
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

               
                SqlDataAdapter da = new SqlDataAdapter("SELECT OdaID, OdaAdi FROM Odalar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

               
                cmbOdalar.DisplayMember = "OdaAdi"; 
                cmbOdalar.ValueMember = "OdaID";    
                cmbOdalar.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Odalar yüklenirken hata: " + hata.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                
                string sql = "INSERT INTO Cihazlar (CihazAdi, Tuketim, Durum, OdaID) VALUES (@p1, @p2, @p3, @p4)";
                SqlCommand komut = new SqlCommand(sql, baglanti);

              
                komut.Parameters.AddWithValue("@p1", txtCihazAd.Text);          
                komut.Parameters.AddWithValue("@p2", int.Parse(txtTuketim.Text)); 
                komut.Parameters.AddWithValue("@p3", cmbDurum.Text);             
                komut.Parameters.AddWithValue("@p4", cmbOdalar.SelectedValue);   

                
                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Cihaz başarıyla eklendi!");

                
                btnListele.PerformClick();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Ekleme hatası: " + hata.Message);
            }
        }

       
        int secilenID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];

                secilenID = int.Parse(satir.Cells[0].Value.ToString()); 
                txtCihazAd.Text = satir.Cells[1].Value.ToString();
                txtTuketim.Text = satir.Cells[2].Value.ToString();
                cmbDurum.Text = satir.Cells[3].Value.ToString();
                cmbOdalar.Text = satir.Cells[4].Value.ToString(); 
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Cihazlar WHERE CihazID = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", secilenID);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Silindi!");
                btnListele.PerformClick(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden silinecek bir satır seçin!");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                
                string sql = "UPDATE Cihazlar SET CihazAdi=@p1, Tuketim=@p2, Durum=@p3, OdaID=@p4 WHERE CihazID=@p5";
                SqlCommand komut = new SqlCommand(sql, baglanti);

                komut.Parameters.AddWithValue("@p1", txtCihazAd.Text);
                komut.Parameters.AddWithValue("@p2", int.Parse(txtTuketim.Text));
                komut.Parameters.AddWithValue("@p3", cmbDurum.Text);
                komut.Parameters.AddWithValue("@p4", cmbOdalar.SelectedValue);
                komut.Parameters.AddWithValue("@p5", secilenID); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Güncellendi!");
                btnListele.PerformClick();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme hatası: " + hata.Message);
            }   
        }
    }
}
