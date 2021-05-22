using Realtor_Automation.Business;
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
    public partial class frmIstatistik : Form
    {
        SatilanBusiness satilanBusiness;
        MusteriBusiness musteriBusiness;
        EvBusiness evBusiness;
        KiralananBusiness kiralananBusiness;
        public frmIstatistik()
        {
            InitializeComponent();
            evBusiness = new EvBusiness();
            musteriBusiness = new MusteriBusiness();
            satilanBusiness = new SatilanBusiness();
            kiralananBusiness = new KiralananBusiness();
        }

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            FillLabels();
        }

        private void FillLabels()
        {
            lblSatilanEvFiyatOrtalama.Text = satilanBusiness.SatilanOrtalama().ToString();
            lblKiralananEvFiyatOrtalama.Text = kiralananBusiness.KiralananOrtalama().ToString();
            lblKiralananEvSayi.Text = kiralananBusiness.ToplamKiralananSayi().ToString();
            lblSatilanEvSayi.Text = satilanBusiness.ToplamSatilanSayi().ToString();
            lblMusteriSayi.Text = musteriBusiness.ToplamMusteriSayi().ToString();
            lblEvSayi.Text = evBusiness.ToplamEvSayi().ToString();
        }
    }
}
