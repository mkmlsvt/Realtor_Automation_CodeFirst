
namespace Realtor_Automation.Forms
{
    partial class frmRapor
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
            this.dataGridSatilan = new System.Windows.Forms.DataGridView();
            this.dataGridKiralanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatilan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiralanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSatilan
            // 
            this.dataGridSatilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSatilan.Location = new System.Drawing.Point(12, 76);
            this.dataGridSatilan.Name = "dataGridSatilan";
            this.dataGridSatilan.RowHeadersWidth = 51;
            this.dataGridSatilan.RowTemplate.Height = 24;
            this.dataGridSatilan.Size = new System.Drawing.Size(614, 302);
            this.dataGridSatilan.TabIndex = 0;
            // 
            // dataGridKiralanan
            // 
            this.dataGridKiralanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKiralanan.Location = new System.Drawing.Point(739, 76);
            this.dataGridKiralanan.Name = "dataGridKiralanan";
            this.dataGridKiralanan.RowHeadersWidth = 51;
            this.dataGridKiralanan.RowTemplate.Height = 24;
            this.dataGridKiralanan.Size = new System.Drawing.Size(595, 302);
            this.dataGridKiralanan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SATILAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1006, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "KİRALANAN";
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridKiralanan);
            this.Controls.Add(this.dataGridSatilan);
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatilan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiralanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSatilan;
        private System.Windows.Forms.DataGridView dataGridKiralanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}