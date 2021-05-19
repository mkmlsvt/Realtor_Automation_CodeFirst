
namespace Realtor_Automation.Forms
{
    partial class frmEvListele
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
            this.panelFiltre = new System.Windows.Forms.Panel();
            this.maskdTxtMaxFiyat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chcMusait = new System.Windows.Forms.CheckBox();
            this.chcboxEsyali = new System.Windows.Forms.CheckBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.maskedm2 = new System.Windows.Forms.MaskedTextBox();
            this.masktxtMinFiyat = new System.Windows.Forms.MaskedTextBox();
            this.masktxtKat = new System.Windows.Forms.MaskedTextBox();
            this.masktxtOdaSayi = new System.Windows.Forms.MaskedTextBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvSil = new System.Windows.Forms.Button();
            this.btnEvGorDuz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFiltre
            // 
            this.panelFiltre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltre.Controls.Add(this.maskdTxtMaxFiyat);
            this.panelFiltre.Controls.Add(this.label4);
            this.panelFiltre.Controls.Add(this.comboBox1);
            this.panelFiltre.Controls.Add(this.chcMusait);
            this.panelFiltre.Controls.Add(this.chcboxEsyali);
            this.panelFiltre.Controls.Add(this.txtMusteriSoyad);
            this.panelFiltre.Controls.Add(this.txtMusteriAd);
            this.panelFiltre.Controls.Add(this.maskedm2);
            this.panelFiltre.Controls.Add(this.masktxtMinFiyat);
            this.panelFiltre.Controls.Add(this.masktxtKat);
            this.panelFiltre.Controls.Add(this.masktxtOdaSayi);
            this.panelFiltre.Controls.Add(this.btnFiltrele);
            this.panelFiltre.Controls.Add(this.label10);
            this.panelFiltre.Controls.Add(this.label9);
            this.panelFiltre.Controls.Add(this.label8);
            this.panelFiltre.Controls.Add(this.label7);
            this.panelFiltre.Controls.Add(this.label6);
            this.panelFiltre.Controls.Add(this.label3);
            this.panelFiltre.Controls.Add(this.label2);
            this.panelFiltre.Controls.Add(this.label1);
            this.panelFiltre.Location = new System.Drawing.Point(12, 12);
            this.panelFiltre.Name = "panelFiltre";
            this.panelFiltre.Size = new System.Drawing.Size(265, 556);
            this.panelFiltre.TabIndex = 0;
            // 
            // maskdTxtMaxFiyat
            // 
            this.maskdTxtMaxFiyat.Location = new System.Drawing.Point(125, 76);
            this.maskdTxtMaxFiyat.Mask = "00000000";
            this.maskdTxtMaxFiyat.Name = "maskdTxtMaxFiyat";
            this.maskdTxtMaxFiyat.Size = new System.Drawing.Size(100, 22);
            this.maskdTxtMaxFiyat.TabIndex = 21;
            this.maskdTxtMaxFiyat.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Max Fiyat";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "kiralik",
            "satilik"});
            this.comboBox1.Location = new System.Drawing.Point(125, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // chcMusait
            // 
            this.chcMusait.AutoSize = true;
            this.chcMusait.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcMusait.Location = new System.Drawing.Point(26, 192);
            this.chcMusait.Name = "chcMusait";
            this.chcMusait.Size = new System.Drawing.Size(89, 21);
            this.chcMusait.TabIndex = 18;
            this.chcMusait.Text = "Müsait mi";
            this.chcMusait.UseVisualStyleBackColor = true;
            // 
            // chcboxEsyali
            // 
            this.chcboxEsyali.AutoSize = true;
            this.chcboxEsyali.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcboxEsyali.Location = new System.Drawing.Point(31, 152);
            this.chcboxEsyali.Name = "chcboxEsyali";
            this.chcboxEsyali.Size = new System.Drawing.Size(84, 21);
            this.chcboxEsyali.TabIndex = 17;
            this.chcboxEsyali.Text = "esyali mi";
            this.chcboxEsyali.UseVisualStyleBackColor = true;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(125, 429);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(120, 22);
            this.txtMusteriSoyad.TabIndex = 16;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(125, 381);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(120, 22);
            this.txtMusteriAd.TabIndex = 15;
            // 
            // maskedm2
            // 
            this.maskedm2.Location = new System.Drawing.Point(125, 275);
            this.maskedm2.Name = "maskedm2";
            this.maskedm2.Size = new System.Drawing.Size(100, 22);
            this.maskedm2.TabIndex = 14;
            // 
            // masktxtMinFiyat
            // 
            this.masktxtMinFiyat.Location = new System.Drawing.Point(125, 43);
            this.masktxtMinFiyat.Mask = "00000000";
            this.masktxtMinFiyat.Name = "masktxtMinFiyat";
            this.masktxtMinFiyat.Size = new System.Drawing.Size(100, 22);
            this.masktxtMinFiyat.TabIndex = 13;
            this.masktxtMinFiyat.ValidatingType = typeof(int);
            // 
            // masktxtKat
            // 
            this.masktxtKat.Location = new System.Drawing.Point(125, 113);
            this.masktxtKat.Mask = "00000";
            this.masktxtKat.Name = "masktxtKat";
            this.masktxtKat.Size = new System.Drawing.Size(100, 22);
            this.masktxtKat.TabIndex = 12;
            this.masktxtKat.ValidatingType = typeof(int);
            // 
            // masktxtOdaSayi
            // 
            this.masktxtOdaSayi.Location = new System.Drawing.Point(125, 228);
            this.masktxtOdaSayi.Mask = "00000";
            this.masktxtOdaSayi.Name = "masktxtOdaSayi";
            this.masktxtOdaSayi.Size = new System.Drawing.Size(100, 22);
            this.masktxtOdaSayi.TabIndex = 11;
            this.masktxtOdaSayi.ValidatingType = typeof(int);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(55, 496);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(150, 38);
            this.btnFiltrele.TabIndex = 10;
            this.btnFiltrele.Text = "FİLTRELE";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "musteri soyisim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "musteri isim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "satilki-kiralik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "m2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "oda sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "kat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİLTRELE";
            // 
            // btnEvSil
            // 
            this.btnEvSil.Location = new System.Drawing.Point(382, 442);
            this.btnEvSil.Name = "btnEvSil";
            this.btnEvSil.Size = new System.Drawing.Size(185, 55);
            this.btnEvSil.TabIndex = 2;
            this.btnEvSil.Text = "SİL";
            this.btnEvSil.UseVisualStyleBackColor = true;
            this.btnEvSil.Click += new System.EventHandler(this.btnEvSil_Click);
            // 
            // btnEvGorDuz
            // 
            this.btnEvGorDuz.Location = new System.Drawing.Point(783, 442);
            this.btnEvGorDuz.Name = "btnEvGorDuz";
            this.btnEvGorDuz.Size = new System.Drawing.Size(189, 55);
            this.btnEvGorDuz.TabIndex = 3;
            this.btnEvGorDuz.Text = "GÖRÜNTÜLE/DÜZENLE";
            this.btnEvGorDuz.UseVisualStyleBackColor = true;
            this.btnEvGorDuz.Click += new System.EventHandler(this.btnEvGorDuz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 404);
            this.dataGridView1.TabIndex = 4;
            // 
            // frmEvListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEvGorDuz);
            this.Controls.Add(this.btnEvSil);
            this.Controls.Add(this.panelFiltre);
            this.Name = "frmEvListele";
            this.Text = "frmEvListele";
            this.Load += new System.EventHandler(this.frmEvListele_Load);
            this.panelFiltre.ResumeLayout(false);
            this.panelFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chcMusait;
        private System.Windows.Forms.CheckBox chcboxEsyali;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.MaskedTextBox maskedm2;
        private System.Windows.Forms.MaskedTextBox masktxtMinFiyat;
        private System.Windows.Forms.MaskedTextBox masktxtKat;
        private System.Windows.Forms.MaskedTextBox masktxtOdaSayi;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEvSil;
        private System.Windows.Forms.Button btnEvGorDuz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskdTxtMaxFiyat;
        private System.Windows.Forms.Label label4;
    }
}