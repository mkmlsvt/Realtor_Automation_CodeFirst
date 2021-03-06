
namespace Realtor_Automation
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnEvEkle = new System.Windows.Forms.Button();
            this.btnEvListele = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSatinKira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvEkle
            // 
            this.btnEvEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEvEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEvEkle.Location = new System.Drawing.Point(79, 43);
            this.btnEvEkle.Name = "btnEvEkle";
            this.btnEvEkle.Size = new System.Drawing.Size(187, 84);
            this.btnEvEkle.TabIndex = 0;
            this.btnEvEkle.Text = "EV/MUSTERİ EKLE";
            this.btnEvEkle.UseVisualStyleBackColor = false;
            this.btnEvEkle.Click += new System.EventHandler(this.btnEvEkle_Click);
            // 
            // btnEvListele
            // 
            this.btnEvListele.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEvListele.ForeColor = System.Drawing.Color.White;
            this.btnEvListele.Location = new System.Drawing.Point(390, 43);
            this.btnEvListele.Name = "btnEvListele";
            this.btnEvListele.Size = new System.Drawing.Size(187, 84);
            this.btnEvListele.TabIndex = 1;
            this.btnEvListele.Text = "EV LİSTELE";
            this.btnEvListele.UseVisualStyleBackColor = false;
            this.btnEvListele.Click += new System.EventHandler(this.btnEvListele_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMusteriListele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMusteriListele.Location = new System.Drawing.Point(79, 166);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(187, 84);
            this.btnMusteriListele.TabIndex = 3;
            this.btnMusteriListele.Text = "MÜŞTERİLER";
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRaporlar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRaporlar.Location = new System.Drawing.Point(390, 176);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(187, 84);
            this.btnRaporlar.TabIndex = 4;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIstatistik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIstatistik.Location = new System.Drawing.Point(706, 176);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(187, 84);
            this.btnIstatistik.TabIndex = 5;
            this.btnIstatistik.Text = "İSTATİSTİK";
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnCikis.Location = new System.Drawing.Point(791, 459);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 42);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSatinKira
            // 
            this.btnSatinKira.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSatinKira.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSatinKira.Location = new System.Drawing.Point(706, 43);
            this.btnSatinKira.Name = "btnSatinKira";
            this.btnSatinKira.Size = new System.Drawing.Size(187, 84);
            this.btnSatinKira.TabIndex = 7;
            this.btnSatinKira.Text = "SATIŞ / KİRALAMA";
            this.btnSatinKira.UseVisualStyleBackColor = false;
            this.btnSatinKira.Click += new System.EventHandler(this.btnSatinKira_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 522);
            this.Controls.Add(this.btnSatinKira);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnEvListele);
            this.Controls.Add(this.btnEvEkle);
            this.MinimumSize = new System.Drawing.Size(955, 569);
            this.Name = "HomePage";
            this.Text = "ANA SAYFA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvEkle;
        private System.Windows.Forms.Button btnEvListele;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSatinKira;
    }
}

