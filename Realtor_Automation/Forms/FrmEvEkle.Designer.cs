
namespace Realtor_Automation.Forms
{
    partial class FrmEvEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chboxEsyali = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktxtOdaSayi = new System.Windows.Forms.MaskedTextBox();
            this.masktxtEvKat = new System.Windows.Forms.MaskedTextBox();
            this.masktxtMetreKare = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.cmboxEvTur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboxIslemTuru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmboxMTur = new System.Windows.Forms.ComboBox();
            this.masktxtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMSoyad = new System.Windows.Forms.TextBox();
            this.txtMAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realtorAutomationDataSet = new Realtor_Automation.RealtorAutomationDataSet();
            this.musteriTableAdapter = new Realtor_Automation.RealtorAutomationDataSetTableAdapters.MusteriTableAdapter();
            this.btnEvEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorAutomationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(12, 194);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(227, 47);
            this.btnResimSec.TabIndex = 1;
            this.btnResimSec.Text = "RESİM SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fiyat :";
            // 
            // txtEvFiyat
            // 
            this.txtEvFiyat.Location = new System.Drawing.Point(371, 21);
            this.txtEvFiyat.Name = "txtEvFiyat";
            this.txtEvFiyat.Size = new System.Drawing.Size(200, 22);
            this.txtEvFiyat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kat : ";
            // 
            // chboxEsyali
            // 
            this.chboxEsyali.AutoSize = true;
            this.chboxEsyali.Location = new System.Drawing.Point(371, 112);
            this.chboxEsyali.Name = "chboxEsyali";
            this.chboxEsyali.Size = new System.Drawing.Size(85, 21);
            this.chboxEsyali.TabIndex = 8;
            this.chboxEsyali.Text = "Eşyalı mı";
            this.chboxEsyali.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Oda Sayısı :";
            // 
            // masktxtOdaSayi
            // 
            this.masktxtOdaSayi.Location = new System.Drawing.Point(371, 156);
            this.masktxtOdaSayi.Mask = "00000";
            this.masktxtOdaSayi.Name = "masktxtOdaSayi";
            this.masktxtOdaSayi.Size = new System.Drawing.Size(44, 22);
            this.masktxtOdaSayi.TabIndex = 10;
            this.masktxtOdaSayi.ValidatingType = typeof(int);
            // 
            // masktxtEvKat
            // 
            this.masktxtEvKat.Location = new System.Drawing.Point(371, 63);
            this.masktxtEvKat.Mask = "00000";
            this.masktxtEvKat.Name = "masktxtEvKat";
            this.masktxtEvKat.Size = new System.Drawing.Size(44, 22);
            this.masktxtEvKat.TabIndex = 11;
            this.masktxtEvKat.ValidatingType = typeof(int);
            // 
            // masktxtMetreKare
            // 
            this.masktxtMetreKare.Location = new System.Drawing.Point(371, 206);
            this.masktxtMetreKare.Mask = "00000";
            this.masktxtMetreKare.Name = "masktxtMetreKare";
            this.masktxtMetreKare.Size = new System.Drawing.Size(44, 22);
            this.masktxtMetreKare.TabIndex = 12;
            this.masktxtMetreKare.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Metre Kare :";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(262, 377);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(309, 113);
            this.richtxtAdres.TabIndex = 14;
            this.richtxtAdres.Text = "";
            // 
            // cmboxEvTur
            // 
            this.cmboxEvTur.FormattingEnabled = true;
            this.cmboxEvTur.Location = new System.Drawing.Point(371, 251);
            this.cmboxEvTur.Name = "cmboxEvTur";
            this.cmboxEvTur.Size = new System.Drawing.Size(121, 24);
            this.cmboxEvTur.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Türü : ";
            // 
            // cmboxIslemTuru
            // 
            this.cmboxIslemTuru.FormattingEnabled = true;
            this.cmboxIslemTuru.Items.AddRange(new object[] {
            "Kiralik",
            "Satilik"});
            this.cmboxIslemTuru.Location = new System.Drawing.Point(371, 295);
            this.cmboxIslemTuru.Name = "cmboxIslemTuru";
            this.cmboxIslemTuru.Size = new System.Drawing.Size(121, 24);
            this.cmboxIslemTuru.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "İşlem Türü : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(162, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "ADRES :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cmboxMTur);
            this.groupBox1.Controls.Add(this.masktxtTel);
            this.groupBox1.Controls.Add(this.txtMSoyad);
            this.groupBox1.Controls.Add(this.txtMAd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(607, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 402);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(84, 295);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(163, 41);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmboxMTur
            // 
            this.cmboxMTur.FormattingEnabled = true;
            this.cmboxMTur.Location = new System.Drawing.Point(146, 190);
            this.cmboxMTur.Name = "cmboxMTur";
            this.cmboxMTur.Size = new System.Drawing.Size(121, 24);
            this.cmboxMTur.TabIndex = 7;
            // 
            // masktxtTel
            // 
            this.masktxtTel.Location = new System.Drawing.Point(146, 149);
            this.masktxtTel.Mask = "(999) 000-0000";
            this.masktxtTel.Name = "masktxtTel";
            this.masktxtTel.Size = new System.Drawing.Size(121, 22);
            this.masktxtTel.TabIndex = 6;
            // 
            // txtMSoyad
            // 
            this.txtMSoyad.Location = new System.Drawing.Point(146, 95);
            this.txtMSoyad.Name = "txtMSoyad";
            this.txtMSoyad.Size = new System.Drawing.Size(121, 22);
            this.txtMSoyad.TabIndex = 5;
            // 
            // txtMAd
            // 
            this.txtMAd.Location = new System.Drawing.Point(146, 54);
            this.txtMAd.Name = "txtMAd";
            this.txtMAd.Size = new System.Drawing.Size(121, 22);
            this.txtMAd.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Türü";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(922, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 469);
            this.dataGridView1.TabIndex = 22;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "TelNo";
            this.telNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            this.telNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.realtorAutomationDataSet;
            // 
            // realtorAutomationDataSet
            // 
            this.realtorAutomationDataSet.DataSetName = "RealtorAutomationDataSet";
            this.realtorAutomationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // btnEvEkle
            // 
            this.btnEvEkle.Location = new System.Drawing.Point(691, 452);
            this.btnEvEkle.Name = "btnEvEkle";
            this.btnEvEkle.Size = new System.Drawing.Size(163, 41);
            this.btnEvEkle.TabIndex = 23;
            this.btnEvEkle.Text = "EVİ KAYDET";
            this.btnEvEkle.UseVisualStyleBackColor = true;
            this.btnEvEkle.Click += new System.EventHandler(this.btnEvEkle_Click);
            // 
            // FrmEvEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 547);
            this.Controls.Add(this.btnEvEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmboxIslemTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmboxEvTur);
            this.Controls.Add(this.richtxtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masktxtMetreKare);
            this.Controls.Add(this.masktxtEvKat);
            this.Controls.Add(this.masktxtOdaSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chboxEsyali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEvFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmEvEkle";
            this.Text = "EV EKLE";
            this.Load += new System.EventHandler(this.FrmEvEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorAutomationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEvFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chboxEsyali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktxtOdaSayi;
        private System.Windows.Forms.MaskedTextBox masktxtEvKat;
        private System.Windows.Forms.MaskedTextBox masktxtMetreKare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.ComboBox cmboxEvTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboxIslemTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmboxMTur;
        private System.Windows.Forms.MaskedTextBox masktxtTel;
        private System.Windows.Forms.TextBox txtMSoyad;
        private System.Windows.Forms.TextBox txtMAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RealtorAutomationDataSet realtorAutomationDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private RealtorAutomationDataSetTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEvEkle;
    }
}