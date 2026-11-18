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
    public partial class FrmKapaliCihazlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ENES\\SQLEXPRESS01;Initial Catalog=AkilliEvDb;Integrated Security=True");

        public FrmKapaliCihazlar()
        {
            InitializeComponent();
        }

        private void FrmKapaliCihazlar_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

              
                string sorgu = "SELECT c.CihazAdi, c.Tuketim, o.OdaAdi " +
                               "FROM Cihazlar c " +
                               "JOIN Odalar o ON c.OdaID = o.OdaID " +
                               "WHERE c.Durum = 'Kapalı'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }
    }
}
