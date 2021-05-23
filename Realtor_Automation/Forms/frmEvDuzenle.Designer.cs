
namespace Realtor_Automation.Forms
{
    partial class frmEvDuzenle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEvFiyat = new System.Windows.Forms.TextBox();
            this.masktxtEvKat = new System.Windows.Forms.MaskedTextBox();
            this.masktxtOdaSayi = new System.Windows.Forms.MaskedTextBox();
            this.masktxtMetreKare = new System.Windows.Forms.MaskedTextBox();
            this.cmboxEvTur = new System.Windows.Forms.ComboBox();
            this.cmboxIslemTur = new System.Windows.Forms.ComboBox();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmboxMTur = new System.Windows.Forms.ComboBox();
            this.masktxtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMSoyad = new System.Windows.Forms.TextBox();
            this.txtMAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEvDuzenle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.Color.Pink;
            this.btnResimSec.Location = new System.Drawing.Point(30, 223);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(256, 53);
            this.btnResimSec.TabIndex = 1;
            this.btnResimSec.Text = "RESİM SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oda Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Metre Kare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "İslem Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "ADRES";
            // 
            // txtEvFiyat
            // 
            this.txtEvFiyat.Location = new System.Drawing.Point(466, 21);
            this.txtEvFiyat.Name = "txtEvFiyat";
            this.txtEvFiyat.Size = new System.Drawing.Size(139, 22);
            this.txtEvFiyat.TabIndex = 9;
            // 
            // masktxtEvKat
            // 
            this.masktxtEvKat.Location = new System.Drawing.Point(466, 58);
            this.masktxtEvKat.Mask = "00000";
            this.masktxtEvKat.Name = "masktxtEvKat";
            this.masktxtEvKat.Size = new System.Drawing.Size(62, 22);
            this.masktxtEvKat.TabIndex = 10;
            this.masktxtEvKat.ValidatingType = typeof(int);
            // 
            // masktxtOdaSayi
            // 
            this.masktxtOdaSayi.Location = new System.Drawing.Point(466, 100);
            this.masktxtOdaSayi.Mask = "00000";
            this.masktxtOdaSayi.Name = "masktxtOdaSayi";
            this.masktxtOdaSayi.Size = new System.Drawing.Size(62, 22);
            this.masktxtOdaSayi.TabIndex = 11;
            this.masktxtOdaSayi.ValidatingType = typeof(int);
            // 
            // masktxtMetreKare
            // 
            this.masktxtMetreKare.Location = new System.Drawing.Point(466, 144);
            this.masktxtMetreKare.Mask = "00000";
            this.masktxtMetreKare.Name = "masktxtMetreKare";
            this.masktxtMetreKare.Size = new System.Drawing.Size(62, 22);
            this.masktxtMetreKare.TabIndex = 12;
            this.masktxtMetreKare.ValidatingType = typeof(int);
            // 
            // cmboxEvTur
            // 
            this.cmboxEvTur.FormattingEnabled = true;
            this.cmboxEvTur.Location = new System.Drawing.Point(466, 189);
            this.cmboxEvTur.Name = "cmboxEvTur";
            this.cmboxEvTur.Size = new System.Drawing.Size(121, 24);
            this.cmboxEvTur.TabIndex = 13;
            // 
            // cmboxIslemTur
            // 
            this.cmboxIslemTur.FormattingEnabled = true;
            this.cmboxIslemTur.Items.AddRange(new object[] {
            "Kiralik",
            "Satilik"});
            this.cmboxIslemTur.Location = new System.Drawing.Point(466, 223);
            this.cmboxIslemTur.Name = "cmboxIslemTur";
            this.cmboxIslemTur.Size = new System.Drawing.Size(121, 24);
            this.cmboxIslemTur.TabIndex = 14;
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(175, 352);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(284, 139);
            this.richtxtAdres.TabIndex = 15;
            this.richtxtAdres.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cmboxMTur);
            this.groupBox1.Controls.Add(this.masktxtTel);
            this.groupBox1.Controls.Add(this.txtMSoyad);
            this.groupBox1.Controls.Add(this.txtMAd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(661, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 342);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.Location = new System.Drawing.Point(38, 264);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 52);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "MÜŞTERİ EKLE";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmboxMTur
            // 
            this.cmboxMTur.FormattingEnabled = true;
            this.cmboxMTur.Location = new System.Drawing.Point(97, 172);
            this.cmboxMTur.Name = "cmboxMTur";
            this.cmboxMTur.Size = new System.Drawing.Size(121, 24);
            this.cmboxMTur.TabIndex = 7;
            // 
            // masktxtTel
            // 
            this.masktxtTel.Location = new System.Drawing.Point(97, 128);
            this.masktxtTel.Mask = "(999) 000-0000";
            this.masktxtTel.Name = "masktxtTel";
            this.masktxtTel.Size = new System.Drawing.Size(121, 22);
            this.masktxtTel.TabIndex = 6;
            // 
            // txtMSoyad
            // 
            this.txtMSoyad.Location = new System.Drawing.Point(97, 84);
            this.txtMSoyad.Name = "txtMSoyad";
            this.txtMSoyad.Size = new System.Drawing.Size(121, 22);
            this.txtMSoyad.TabIndex = 5;
            // 
            // txtMAd
            // 
            this.txtMAd.Location = new System.Drawing.Point(97, 42);
            this.txtMAd.Name = "txtMAd";
            this.txtMAd.Size = new System.Drawing.Size(121, 22);
            this.txtMAd.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "ad";
            // 
            // btnEvDuzenle
            // 
            this.btnEvDuzenle.BackColor = System.Drawing.Color.Lime;
            this.btnEvDuzenle.Location = new System.Drawing.Point(675, 410);
            this.btnEvDuzenle.Name = "btnEvDuzenle";
            this.btnEvDuzenle.Size = new System.Drawing.Size(227, 81);
            this.btnEvDuzenle.TabIndex = 17;
            this.btnEvDuzenle.Text = "EVİ DÜZENLE";
            this.btnEvDuzenle.UseVisualStyleBackColor = false;
            this.btnEvDuzenle.Click += new System.EventHandler(this.btnEvDuzenle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(944, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 342);
            this.dataGridView1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(466, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Eşyalı";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmEvDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1356, 603);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEvDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richtxtAdres);
            this.Controls.Add(this.cmboxIslemTur);
            this.Controls.Add(this.cmboxEvTur);
            this.Controls.Add(this.masktxtMetreKare);
            this.Controls.Add(this.masktxtOdaSayi);
            this.Controls.Add(this.masktxtEvKat);
            this.Controls.Add(this.txtEvFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmEvDuzenle";
            this.Text = "frmEvDuzenle";
            this.Load += new System.EventHandler(this.frmEvDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEvFiyat;
        private System.Windows.Forms.MaskedTextBox masktxtEvKat;
        private System.Windows.Forms.MaskedTextBox masktxtOdaSayi;
        private System.Windows.Forms.MaskedTextBox masktxtMetreKare;
        private System.Windows.Forms.ComboBox cmboxEvTur;
        private System.Windows.Forms.ComboBox cmboxIslemTur;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmboxMTur;
        private System.Windows.Forms.MaskedTextBox masktxtTel;
        private System.Windows.Forms.TextBox txtMSoyad;
        private System.Windows.Forms.TextBox txtMAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEvDuzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}