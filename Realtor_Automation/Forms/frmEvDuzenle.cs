using Realtor_Automation.Business;
using Realtor_Automation.Loglar.EvLog;
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
    public partial class frmEvDuzenle : Form
    {      
        int duzenlenecekId = frmEvListele.gidececkBilgi;
        private static frmEvDuzenle form = null;
        Musteri musteri;
        EvBusiness evBusiness;
        EvTurBusiness evTurBusiness;
        MusteriBusiness musteriBusiness;
        MusteriTurBusiness musteriTurBusiness;
        string resimYolu;
        public frmEvDuzenle()
        {
            InitializeComponent();
            form = this;

        }

        private void btnResimSec_Click(object sender, EventArgs e)
        { 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            resimYolu = openFileDialog1.FileName;
            //MessageBox.Show(resimYolu);
        }
        private void CreateMusteriTurComboboxItems()
        {
            musteriTurBusiness = new MusteriTurBusiness();
            var musteriTurleriDict = musteriTurBusiness.GetAllMusteriTurData();
            cmboxMTur.DataSource = new BindingSource(musteriTurleriDict, null);
            cmboxMTur.ValueMember = "Key";
            cmboxMTur.DisplayMember = "Value";
        }
        private void CreateEvTurComboboxItems()
        {
            evTurBusiness = new EvTurBusiness();
            var evTurleriDictionary = evTurBusiness.GetAllEvTur();
            cmboxEvTur.DataSource = new BindingSource(evTurleriDictionary, null);
            cmboxEvTur.DisplayMember = "Value";
            cmboxEvTur.ValueMember = "Key";
        }
        private void AddCustomer()
        {
            musteriBusiness = new MusteriBusiness();
            musteri = new Musteri();
            musteri.Ad = txtMAd.Text;
            musteri.Soyad = txtMSoyad.Text;
            musteri.TelNo = masktxtTel.Text;
            musteri.MusteriTurId = int.Parse(cmboxMTur.SelectedValue.ToString());
            musteriBusiness.AddCustomer(musteri);
        }
        private List<Musteri> GetAllCustomers()
        {
            musteriBusiness = new MusteriBusiness();
            var musteriler = musteriBusiness.GetAllCustomers();
            return musteriler;
        }
        private void Update_Datagridview_()
        {
            musteriBusiness = new MusteriBusiness();
            dataGridView1.DataSource =musteriBusiness.GetAllCustomersDTO();
            dataGridView1.Columns["MusteriTur"].Visible = false;
        }
        private bool CustomersNullControl()
        {
            if (string.IsNullOrWhiteSpace(txtMSoyad.Text) || string.IsNullOrWhiteSpace(txtMAd.Text) || string.IsNullOrWhiteSpace(masktxtTel.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool HouseNullControl()
        {
            if (string.IsNullOrWhiteSpace(txtEvFiyat.Text) || string.IsNullOrWhiteSpace(masktxtEvKat.Text) || string.IsNullOrWhiteSpace(masktxtMetreKare.Text) || string.IsNullOrWhiteSpace(masktxtOdaSayi.Text) || cmboxIslemTur.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Clear_Form()
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    txtbox.Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    CheckBox chkbox = (CheckBox)control;
                    chkbox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
                else if (control is MaskedTextBox)
                {
                    MaskedTextBox maskd = (MaskedTextBox)control;
                    maskd.Text = string.Empty;
                }
                else if (control is RichTextBox)
                {
                    RichTextBox rich = (RichTextBox)control;
                    rich.Text = string.Empty;
                }
                else if (control is GroupBox)
                {
                    ResetGroupBox_Items(control);
                }
            }
        }
        private static void ResetGroupBox_Items(Control control)
        {
            GroupBox grp = (GroupBox)control;
            foreach (Control subControl in grp.Controls)
            {
                if (subControl is TextBox)
                {
                    subControl.ResetText();
                }
                else if (subControl is MaskedTextBox)
                {
                    subControl.ResetText();
                }
            }
        }

        private void frmEvDuzenle_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Update_Datagridview_();
            CreateEvTurComboboxItems();
            CreateMusteriTurComboboxItems();
            FillHouseControls();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CustomersNullControl() == false)
            {
                MessageBox.Show("eksik degerleri doldurun", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                AddCustomer();
                Update_Datagridview_();
                ResetGroupBox_Items(groupBox1);
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Ev GetHouseById(int id)
        {
            evBusiness = new EvBusiness();
            Ev ev = evBusiness.GetHouseById(id) ;
            return ev;
        }
        private void FillHouseControls()
        {
            Ev ev = GetHouseById(duzenlenecekId);
            txtEvFiyat.Text = ev.Fiyat.ToString();
            masktxtEvKat.Text = ev.Kat.ToString();
            masktxtMetreKare.Text = ev.Metrekare.ToString();
            masktxtOdaSayi.Text = ev.OdaSayi.ToString();
            richtxtAdres.Text=ev.Adres.ToString();
            cmboxEvTur.SelectedItem = ev.EvTur.Ad.ToString();
            cmboxIslemTur.SelectedItem = ev.KiralikSatilik.ToString();
            pictureBox1.ImageLocation = ev.Resim;
            resimYolu = pictureBox1.ImageLocation;
            //ev.MusteriId != int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()))
            dataGridView1.CurrentCell.Selected = false;
            dataGridView1.CurrentRow.Selected = false;
            dataGridView1.Rows
                         .OfType<DataGridViewRow>()
                         .Where(x => (int)x.Cells["Id"].Value == ev.MusteriId)
                         .ToArray<DataGridViewRow>()[0]
                         .Selected = true;
           

        }

        private void btnEvDuzenle_Click(object sender, EventArgs e)
        {
            if (HouseNullControl()==false)
            {
                MessageBox.Show("eksik degerleri doldurun", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateHouse();
                //MessageBox.Show("Başarıyla Kaydedildi-- anasayfaya yonlendirilceksiniz", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //HomePage form = new HomePage();
                this.Close();
                //form.Show();
                //formEvListe.Show();
                //this.Close();
                  
               
            }
        }
        private void UpdateHouse()
        {
            try
            {
                evBusiness = new EvBusiness();
                Ev ev = new Ev();
                ev.Adres = richtxtAdres.Text;
                ev.Esyali = checkBox1.Checked;
                ev.EvTurId = int.Parse(cmboxEvTur.SelectedValue.ToString());
                ev.Fiyat = int.Parse(txtEvFiyat.Text);
                ev.Kat = int.Parse(masktxtEvKat.Text);
                ev.KiralikSatilik = cmboxIslemTur.SelectedItem.ToString();
                ev.Metrekare = int.Parse(masktxtMetreKare.Text);
                ev.MusteriId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                ev.OdaSayi = int.Parse(masktxtOdaSayi.Text);
                ev.Resim = resimYolu;
                evBusiness.UpdateHouse(duzenlenecekId, ev);
                MessageBox.Show("Başarıyla Kaydedildi-- anasayfaya yonlendirilceksiniz", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Girdiğinz değelerde hata ile karşılaşışdı Tekrar deneyin...", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var evlog = new EvLog();
                using (StreamWriter writer = new StreamWriter(evlog.fullpath, true))
                {
                    writer.WriteLine(exception.Message + "\tEv Duzenleme Başarısız\t" + System.DateTime.Now.ToString());
                }
            }
            
        }
       
    }
}
