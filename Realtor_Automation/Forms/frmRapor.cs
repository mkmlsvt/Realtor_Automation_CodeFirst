using Realtor_Automation.Business;
using Realtor_Automation.DTO;
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
    public partial class frmRapor : Form
    {
        KiralananBusiness kiralananBusiness;
        SatilanBusiness satilanBusiness;
        public frmRapor()
        {
            InitializeComponent();
            satilanBusiness = new SatilanBusiness();
            kiralananBusiness = new KiralananBusiness();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            UpdateSatilanDataGridView(GetAllSatilanDTO());
            UpdateKiralananDataGridView(GetKiralananDTO());
        }
        private List<SatilanDTO> GetAllSatilanDTO()
        {
            var allSatilan = satilanBusiness.GetAllSatilanDTO();
            return allSatilan;
        }
        private void UpdateSatilanDataGridView(List<SatilanDTO> satilanDTO)
        {
            dataGridSatilan.DataSource = satilanDTO;
            dataGridSatilan.Columns["Musteri"].Visible = false;
            dataGridSatilan.Columns["Ev"].Visible = false;
        }
        private void UpdateKiralananDataGridView(List<KiralananDTO> kiralananDTO)
        {
            dataGridKiralanan.DataSource = kiralananDTO;
            dataGridKiralanan.Columns["Musteri"].Visible = false;
            dataGridKiralanan.Columns["Ev"].Visible = false;
        }
        private List<KiralananDTO> GetKiralananDTO()
        {
            var kiralananDTO  = kiralananBusiness.GetAllKiralananDTO();
            return kiralananDTO;
        }

    }
}
