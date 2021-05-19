using Realtor_Automation.Business;
using Realtor_Automation.DTO;
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
    public partial class frmEvListele : Form
    {
        public static int gidececkBilgi;
        EvBusiness evBusiness;
        public frmEvListele()
        {
            InitializeComponent();
            evBusiness = new EvBusiness();
        }

        private void frmEvListele_Load(object sender, EventArgs e)
        {
            var allHouses = evBusiness.GetAllHouseDTO();
            FillDataGriedView(allHouses);
        }

        private void FillDataGriedView(List<EvDTO> allHouses)
        {
            dataGridView1.DataSource = allHouses;
            dataGridView1.Columns["EvTur"].Visible = false;
            dataGridView1.Columns["Musteri"].Visible = false;           
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            var evFilterObject = InitializeEvFilterObject();
            var filteredData = evBusiness.GetFilteredHouseData(evFilterObject);
            FillDataGriedView(filteredData);
        }

        private EvFilterDTO InitializeEvFilterObject()
        {
            var evFilterObj = new EvFilterDTO();

            evFilterObj.MusteriAd = string.IsNullOrWhiteSpace(txtMusteriAd.Text) ? null : txtMusteriAd.Text;
            evFilterObj.MusteriSoyad = string.IsNullOrWhiteSpace(txtMusteriSoyad.Text) ? null: txtMusteriSoyad.Text;
            evFilterObj.Esyali = chcboxEsyali.Checked ? true : default(bool?);
            evFilterObj.Musait = chcMusait.Checked ? true : default(bool?);
            evFilterObj.OdaSayisi = string.IsNullOrWhiteSpace(masktxtOdaSayi.Text) ? default(int?) : int.Parse(masktxtOdaSayi.Text);
            evFilterObj.SatilikKiralik = comboBox1.SelectedItem == null ? null : comboBox1.SelectedItem.ToString();
            evFilterObj.MaxFiyat = string.IsNullOrWhiteSpace(maskdTxtMaxFiyat.Text) ? default(int?) : int.Parse(maskdTxtMaxFiyat.Text);
            evFilterObj.MinFiyat = string.IsNullOrWhiteSpace(masktxtMinFiyat.Text) ? default(int?) : int.Parse(masktxtMinFiyat.Text);
            evFilterObj.MetreKare = string.IsNullOrWhiteSpace(maskedm2.Text) ? default(int?) : int.Parse(maskedm2.Text);
            evFilterObj.Kat = string.IsNullOrWhiteSpace(masktxtKat.Text) ? default(int?) : int.Parse(masktxtKat.Text);
            return evFilterObj;
        }

        private void btnEvSil_Click(object sender, EventArgs e)
        {
            DeleteHouse();
            var allHouses = evBusiness.GetAllHouseDTO();
            FillDataGriedView(allHouses);
            MessageBox.Show("silme islemi tamamlandi", "silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void DeleteHouse()
        {
            int SilincekId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            //gidececkBilgi = SilincekId;
            evBusiness.DeleteHouse(SilincekId);
        }

        private void btnEvGorDuz_Click(object sender, EventArgs e)
        {
            gidececkBilgi = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            frmEvDuzenle form = new frmEvDuzenle();
            form.Show();
            this.Close();
            //this.Close();
            //this.Dispose();
           // this.Refresh();
            
        }      
    }
}
