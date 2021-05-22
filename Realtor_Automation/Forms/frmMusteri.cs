using Realtor_Automation.Business;
using Realtor_Automation.DTO;
using Realtor_Automation.Loglar.MusteriLog;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtor_Automation.Forms
{
    public partial class frmMusteri : Form
    {
        Musteri degiscekMusteri;
        MusteriTurBusiness musteriTurBusiness;
        MusteriBusiness musteriBusiness;
        public frmMusteri()
        {
            InitializeComponent();
            musteriBusiness = new MusteriBusiness();
            musteriTurBusiness = new MusteriTurBusiness();
            degiscekMusteri = new Musteri();
        }
        private void CreateMusteriTurComboboxItems()
        {
            musteriTurBusiness = new MusteriTurBusiness();
            var musteriTurleriDict = musteriTurBusiness.GetAllMusteriTurData();
            comboBox1.DataSource = new BindingSource(musteriTurleriDict, null);
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            CreateMusteriTurComboboxItems();
            UpdateDataGridview();
        }
        private List<MusteriSpDTO> GetAllMusteriSpDto()
        {
           var musteriler = musteriBusiness.GetAllCustomersFromSp();
           return musteriler;
        }
        private void UpdateDataGridview()
        {
            dataGridView1.DataSource = GetAllMusteriSpDto();
        }
        private void DeleteCustomer()
        {
            string mAd = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string mSoyad = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            musteriBusiness.DeleteCustomer(mAd,mSoyad);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            UpdateDataGridview();
            IslemBasariliMesaj();
        }
        private void IslemBasariliMesaj()
        {
            MessageBox.Show("İşlem Başarıyla Gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            string a  = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txtAd.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            masktxtTel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            comboBox1.SelectedIndex = comboBox1.FindStringExact(a);
            degiscekMusteri.Ad = txtAd.Text;
            degiscekMusteri.Soyad = txtSoyad.Text;
            degiscekMusteri.TelNo = masktxtTel.Text;
        }
        private void UpdateCustomer()
        {
            Musteri musteri = new Musteri();
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.TelNo = masktxtTel.Text;
            musteri.MusteriTurId = int.Parse(comboBox1.SelectedValue.ToString());
            musteriBusiness.UpdateCustomer(musteri, degiscekMusteri);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Exception exception1 = new Exception();
            try
            {
                if(string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                {
                    throw exception1;
                }
                UpdateCustomer();
                UpdateDataGridview();
                IslemBasariliMesaj();
            }
            catch (Exception exception)
            {
                IslemBasarisizMesaj();               
                var musteriLog = new MusteriLog();
                using (StreamWriter writer = new StreamWriter(musteriLog.fullpath, true))
                {
                    writer.WriteLine(exception.Message + "\tMusteri Duzenleme Başarısız\t" + System.DateTime.Now.ToString());
                }
            }
            
        }
        private void IslemBasarisizMesaj()
        {
            MessageBox.Show("İşlem Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
