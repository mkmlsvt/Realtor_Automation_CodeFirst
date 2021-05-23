
namespace Realtor_Automation.Forms
{
    partial class frmIslem
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
            this.dataGridEvler = new System.Windows.Forms.DataGridView();
            this.dataGridMusteriler = new System.Windows.Forms.DataGridView();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnKirala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEvler
            // 
            this.dataGridEvler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvler.Location = new System.Drawing.Point(12, 12);
            this.dataGridEvler.Name = "dataGridEvler";
            this.dataGridEvler.RowHeadersWidth = 51;
            this.dataGridEvler.RowTemplate.Height = 24;
            this.dataGridEvler.Size = new System.Drawing.Size(638, 316);
            this.dataGridEvler.TabIndex = 0;
            // 
            // dataGridMusteriler
            // 
            this.dataGridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMusteriler.Location = new System.Drawing.Point(728, 12);
            this.dataGridMusteriler.Name = "dataGridMusteriler";
            this.dataGridMusteriler.RowHeadersWidth = 51;
            this.dataGridMusteriler.RowTemplate.Height = 24;
            this.dataGridMusteriler.Size = new System.Drawing.Size(627, 316);
            this.dataGridMusteriler.TabIndex = 1;
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSat.Location = new System.Drawing.Point(581, 348);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(205, 72);
            this.btnSat.TabIndex = 2;
            this.btnSat.Text = "SAT";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKirala.Location = new System.Drawing.Point(581, 448);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(205, 72);
            this.btnKirala.TabIndex = 3;
            this.btnKirala.Text = "KİRALA";
            this.btnKirala.UseVisualStyleBackColor = false;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // frmIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1367, 554);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.dataGridMusteriler);
            this.Controls.Add(this.dataGridEvler);
            this.Name = "frmIslem";
            this.Text = "İŞLEM SAYFASI";
            this.Load += new System.EventHandler(this.frmIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEvler;
        private System.Windows.Forms.DataGridView dataGridMusteriler;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnKirala;
    }
}