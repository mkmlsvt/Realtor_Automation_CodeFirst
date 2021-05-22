using Realtor_Automation.Business;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtor_Automation.Forms
{
    public partial class frmGiris : Form
    {
        AdminBusiness adminBusiness;
        Admin admin;
        public frmGiris()
        {
            InitializeComponent();
            admin = new Admin();
            adminBusiness = new AdminBusiness();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(GirisKontrol()==true)
            {
                HomePage form = new HomePage();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatali İd ya da Şifre", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool GirisKontrol()
        {
            admin.Ad = txtId.Text;
            admin.Parola = txtParola.Text;
            var girisKontrol = adminBusiness.GirisKontrol(admin);
            return girisKontrol;
        }
    }
}
