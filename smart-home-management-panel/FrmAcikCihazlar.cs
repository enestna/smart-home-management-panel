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
    public partial class FrmAcikCihazlar : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=ENES\\SQLEXPRESS01;Initial Catalog=AkilliEvDb;Integrated Security=True");
        public FrmAcikCihazlar()
        {
            InitializeComponent();
        }

        private void FrmAcikCihazlar_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // SADECE AÇIK CİHAZLARI GETİR
                // JOIN ile Oda adını da alıyoruz
                string sorgu = "SELECT c.CihazAdi, c.Tuketim, o.OdaAdi " +
                               "FROM Cihazlar c " +
                               "JOIN Odalar o ON c.OdaID = o.OdaID " +
                               "WHERE c.Durum = 'Açık'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Tabloya bas

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }
    }
}
