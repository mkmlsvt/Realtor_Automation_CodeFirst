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
    public partial class frmIslem : Form
    {
        KiralananBusiness kiralananBusiness;
        SatilanBusiness satilanBusiness;        
        MusteriBusiness musteriBusiness;
        EvBusiness evBusiness;
        public frmIslem()
        {           
            InitializeComponent();
            evBusiness = new EvBusiness();
            kiralananBusiness = new KiralananBusiness();
            musteriBusiness = new MusteriBusiness();
            satilanBusiness = new SatilanBusiness();
        }

       

        private void frmIslem_Load(object sender, EventArgs e)
        {
            //var allHouses = evBusiness.GetAllHouseDTO();
            FillDataGriedViewEv();
            UpdateDatagridviewMusteri();
        }
        private void FillDataGriedViewEv()
        {
            dataGridEvler.DataSource = evBusiness.GetAllHouseDTO();
            dataGridEvler.Columns["EvTur"].Visible = false;
            dataGridEvler.Columns["Musteri"].Visible = false;
        }
        private void UpdateDatagridviewMusteri()
        {           
            dataGridMusteriler.DataSource = musteriBusiness.GetAllCustomersDTO();
            dataGridMusteriler.Columns["MusteriTur"].Visible = false;
        }
        private void AddSatilan()
        {
            Satilan satilan;
            satilan = new Satilan();
            satilan.EvId = int.Parse(dataGridEvler.Rows[dataGridEvler.CurrentRow.Index].Cells[0].Value.ToString());
            satilan.Tarih = Convert.ToDateTime(DateTime.Now.ToString());
            satilan.MusteriId = int.Parse(dataGridMusteriler.Rows[dataGridMusteriler.CurrentRow.Index].Cells[0].Value.ToString());
            satilanBusiness.AddSatilan(satilan);          
        }
        private void HouseUnAvailable()
        {
           int unavailableId = int.Parse(dataGridEvler.Rows[dataGridEvler.CurrentRow.Index].Cells[0].Value.ToString());
           evBusiness.HouseUnAvailable(unavailableId);
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            AddSatilan();
            HouseUnAvailable();
            MessageBox.Show("başarılı bir şekilde satıldı", "Satis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            AddKiralanan();
            HouseUnAvailable();
            MessageBox.Show("başarılı bir şekilde kiralandı", "Kiralamak", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AddKiralanan()
        {
            Kiralanan kiralanan;
            kiralanan = new Kiralanan();
            kiralanan.EvId = int.Parse(dataGridEvler.Rows[dataGridEvler.CurrentRow.Index].Cells[0].Value.ToString());
            kiralanan.Tarih = Convert.ToDateTime(DateTime.Now.ToString());
            kiralanan.MusteriId = int.Parse(dataGridMusteriler.Rows[dataGridMusteriler.CurrentRow.Index].Cells[0].Value.ToString());
            kiralananBusiness.AddKiralanan(kiralanan);

        }
    }
 
}

