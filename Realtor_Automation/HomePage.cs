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
    }
}
