using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkilliEvOtomasyonu
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnCihazlar_Click(object sender, EventArgs e)
        {
            FrmCihazlar fr = new FrmCihazlar(); 
            fr.ShowDialog();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar frm = new FrmOdalar();
            frm.ShowDialog();
        }

        private void btnAciklar_Click(object sender, EventArgs e)
        {
            FrmAcikCihazlar frm = new FrmAcikCihazlar();
            frm.ShowDialog();
        }

        private void btnKapalilar_Click(object sender, EventArgs e)
        {
            FrmKapaliCihazlar frm = new FrmKapaliCihazlar();
            frm.ShowDialog();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
