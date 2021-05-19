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
    public partial class FrmEvEkle : Form
    {
        private static FrmEvEkle form = null;
        string resimYolu;
        EvBusiness evBusiness;
        Ev ev;
        MusteriBusiness musteriBusiness;
        Musteri musteri;
        EvTurBusiness evTurBusiness;
        MusteriTurBusiness musteriTurBusiness;
        public FrmEvEkle()
        {
            InitializeComponent();
            form = this;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            resimYolu = openFileDialog1.FileName;
            //MessageBox.Show(resimYolu);
        }

        private void FrmEvEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realtorAutomationDataSet.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.realtorAutomationDataSet.Musteri);
            CreateEvTurComboboxItems();
            CreateMusteriTurComboboxItems();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(CustomersNullControl()== false)
            {
                MessageBox.Show("eksik degerleri doldurun","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               
                AddCustomer();
                Update_Datagridview_();
                Clear_Form();
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void AddHouse()
        {           
            evBusiness = new EvBusiness();
            ev = new Ev();
            ev.Fiyat = int.Parse(txtEvFiyat.Text);
            ev.Esyali = chboxEsyali.Checked;
            ev.Adres = richtxtAdres.Text;
            ev.Tarih = Convert.ToDateTime(DateTime.Now.ToString());
            ev.EvTurId = int.Parse(cmboxEvTur.SelectedValue.ToString());
            ev.Kat = int.Parse(masktxtEvKat.Text);
            ev.Resim = resimYolu;
            ev.Metrekare = int.Parse(masktxtMetreKare.Text);
            ev.OdaSayi = int.Parse(masktxtOdaSayi.Text);
            ev.Musait = true;           
            ev.KiralikSatilik = cmboxIslemTuru.SelectedItem.ToString();        
            ev.MusteriId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            evBusiness.AddHouse(ev);
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

        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            if(HouseNullControl()==false)
            {
                MessageBox.Show("eksik degerleri doldurun", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddHouse();
                Clear_Form();
                MessageBox.Show("Başarıyla Kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private List<Musteri> GetAllCustomers()
        {
            musteriBusiness = new MusteriBusiness();
            var musteriler = musteriBusiness.GetAllCustomers();
            return musteriler;
        }
        private void Update_Datagridview_()
        {
            dataGridView1.DataSource = GetAllCustomers();
        }
        private bool CustomersNullControl()
        {
            if(string.IsNullOrWhiteSpace(txtMSoyad.Text) || string.IsNullOrWhiteSpace(txtMAd.Text) || string.IsNullOrWhiteSpace(masktxtTel.Text))
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
            if(string.IsNullOrWhiteSpace(txtEvFiyat.Text)|| string.IsNullOrWhiteSpace(masktxtEvKat.Text)|| string.IsNullOrWhiteSpace(masktxtMetreKare.Text)|| string.IsNullOrWhiteSpace(masktxtOdaSayi.Text)|| cmboxIslemTuru.SelectedItem==null)
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
    }
}
