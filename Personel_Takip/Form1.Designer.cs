namespace Personel_Takip
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelKayitDataSet1 = new Personel_Takip.PersonelKayitDataSet1();
            this.personelKayitDataSet = new Personel_Takip.PersonelKayitDataSet();
            this.personelKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter = new Personel_Takip.PersonelKayitDataSet1TableAdapters.tbl_PersonelTableAdapter();
            this.lblDurum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskMaas);
            this.groupBox1.Controls.Add(this.rdbBekar);
            this.groupBox1.Controls.Add(this.rdbEvli);
            this.groupBox1.Controls.Add(this.cmbSehir);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Bilgileri";
            // 
            // mskMaas
            // 
            this.mskMaas.Location = new System.Drawing.Point(107, 145);
            this.mskMaas.Mask = "00000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(153, 20);
            this.mskMaas.TabIndex = 6;
            this.mskMaas.ValidatingType = typeof(int);
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Checked = true;
            this.rdbBekar.Location = new System.Drawing.Point(170, 120);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(53, 17);
            this.rdbBekar.TabIndex = 5;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "Bekar";
            this.rdbBekar.UseVisualStyleBackColor = true;
            this.rdbBekar.CheckedChanged += new System.EventHandler(this.rdbBekar_CheckedChanged);
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Location = new System.Drawing.Point(107, 122);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(42, 17);
            this.rdbEvli.TabIndex = 4;
            this.rdbEvli.Text = "Evli";
            this.rdbEvli.UseVisualStyleBackColor = true;
            this.rdbEvli.CheckedChanged += new System.EventHandler(this.rdbEvli_CheckedChanged);
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(107, 95);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(153, 21);
            this.cmbSehir.TabIndex = 3;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(107, 173);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(154, 20);
            this.txtMeslek.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Personel Meslek :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(106, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(154, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personel Şehir :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(107, 69);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(154, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personel Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Durum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Maaş :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(106, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Soyad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRapor);
            this.groupBox2.Controls.Add(this.btnIstatistik);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(6, 164);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(254, 23);
            this.btnRapor.TabIndex = 5;
            this.btnRapor.Text = "Raporla";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(6, 135);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(254, 23);
            this.btnIstatistik.TabIndex = 4;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(6, 106);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(254, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(6, 77);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(254, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(6, 48);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(254, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(6, 19);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(254, 23);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 217);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personelSehirDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.personelDurumDataGridViewCheckBoxColumn,
            this.personelMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            this.personelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            // 
            // personelSehirDataGridViewTextBoxColumn
            // 
            this.personelSehirDataGridViewTextBoxColumn.DataPropertyName = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.HeaderText = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.Name = "personelSehirDataGridViewTextBoxColumn";
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            // 
            // personelDurumDataGridViewCheckBoxColumn
            // 
            this.personelDurumDataGridViewCheckBoxColumn.DataPropertyName = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.HeaderText = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.Name = "personelDurumDataGridViewCheckBoxColumn";
            // 
            // personelMeslekDataGridViewTextBoxColumn
            // 
            this.personelMeslekDataGridViewTextBoxColumn.DataPropertyName = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.HeaderText = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.Name = "personelMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelKayitDataSet1;
            // 
            // personelKayitDataSet1
            // 
            this.personelKayitDataSet1.DataSetName = "PersonelKayitDataSet1";
            this.personelKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelKayitDataSet
            // 
            this.personelKayitDataSet.DataSetName = "PersonelKayitDataSet";
            this.personelKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelKayitDataSetBindingSource
            // 
            this.personelKayitDataSetBindingSource.DataSource = this.personelKayitDataSet;
            this.personelKayitDataSetBindingSource.Position = 0;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(588, 188);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(35, 13);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "label8";
            this.lblDurum.TextChanged += new System.EventHandler(this.lblDurum_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayitDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource personelKayitDataSetBindingSource;
        private PersonelKayitDataSet personelKayitDataSet;
        private PersonelKayitDataSet1 personelKayitDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelKayitDataSet1TableAdapters.tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.MaskedTextBox mskMaas;
    }
}

