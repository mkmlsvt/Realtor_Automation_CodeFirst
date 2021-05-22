using Realtor_Automation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtor_Automation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnEvListele_Click(object sender, EventArgs e)
        {
            frmEvListele form = new frmEvListele();
            //this.Hide();
            form.ShowDialog();
           // this.Hide();
        }

        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            FrmEvEkle formekle = new FrmEvEkle();
            //this.Hide();
            formekle.ShowDialog();
            
        }

        private void btnSatinKira_Click(object sender, EventArgs e)
        {
            frmIslem form = new frmIslem();
            form.ShowDialog();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            frmMusteri form = new frmMusteri();
            form.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRapor form = new frmRapor();
            form.ShowDialog();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik form = new frmIstatistik();
            form.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
