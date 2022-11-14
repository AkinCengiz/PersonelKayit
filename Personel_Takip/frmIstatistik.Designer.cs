namespace Personel_Takip
{
    partial class frmIstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPersonelSayisi = new System.Windows.Forms.Label();
            this.lblEvliPersonel = new System.Windows.Forms.Label();
            this.lblBekarPersonel = new System.Windows.Forms.Label();
            this.lblSehirSayisi = new System.Windows.Forms.Label();
            this.lblOrtalamaMaas = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel Sayısı :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Maaş :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama Maaş :";
            // 
            // lblPersonelSayisi
            // 
            this.lblPersonelSayisi.AutoSize = true;
            this.lblPersonelSayisi.Location = new System.Drawing.Point(172, 13);
            this.lblPersonelSayisi.Name = "lblPersonelSayisi";
            this.lblPersonelSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblPersonelSayisi.TabIndex = 6;
            this.lblPersonelSayisi.Text = "0";
            // 
            // lblEvliPersonel
            // 
            this.lblEvliPersonel.AutoSize = true;
            this.lblEvliPersonel.Location = new System.Drawing.Point(172, 40);
            this.lblEvliPersonel.Name = "lblEvliPersonel";
            this.lblEvliPersonel.Size = new System.Drawing.Size(13, 13);
            this.lblEvliPersonel.TabIndex = 7;
            this.lblEvliPersonel.Text = "0";
            // 
            // lblBekarPersonel
            // 
            this.lblBekarPersonel.AutoSize = true;
            this.lblBekarPersonel.Location = new System.Drawing.Point(172, 65);
            this.lblBekarPersonel.Name = "lblBekarPersonel";
            this.lblBekarPersonel.Size = new System.Drawing.Size(13, 13);
            this.lblBekarPersonel.TabIndex = 8;
            this.lblBekarPersonel.Text = "0";
            // 
            // lblSehirSayisi
            // 
            this.lblSehirSayisi.AutoSize = true;
            this.lblSehirSayisi.Location = new System.Drawing.Point(172, 90);
            this.lblSehirSayisi.Name = "lblSehirSayisi";
            this.lblSehirSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblSehirSayisi.TabIndex = 9;
            this.lblSehirSayisi.Text = "0";
            // 
            // lblOrtalamaMaas
            // 
            this.lblOrtalamaMaas.AutoSize = true;
            this.lblOrtalamaMaas.Location = new System.Drawing.Point(172, 144);
            this.lblOrtalamaMaas.Name = "lblOrtalamaMaas";
            this.lblOrtalamaMaas.Size = new System.Drawing.Size(13, 13);
            this.lblOrtalamaMaas.TabIndex = 10;
            this.lblOrtalamaMaas.Text = "0";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(172, 120);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(13, 13);
            this.lblToplamMaas.TabIndex = 11;
            this.lblToplamMaas.Text = "0";
            // 
            // frmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 177);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.lblOrtalamaMaas);
            this.Controls.Add(this.lblSehirSayisi);
            this.Controls.Add(this.lblBekarPersonel);
            this.Controls.Add(this.lblEvliPersonel);
            this.Controls.Add(this.lblPersonelSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIstatistik";
            this.Text = "frmIstatistik";
            this.Load += new System.EventHandler(this.frmIstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPersonelSayisi;
        private System.Windows.Forms.Label lblEvliPersonel;
        private System.Windows.Forms.Label lblBekarPersonel;
        private System.Windows.Forms.Label lblSehirSayisi;
        private System.Windows.Forms.Label lblOrtalamaMaas;
        private System.Windows.Forms.Label lblToplamMaas;
    }
}