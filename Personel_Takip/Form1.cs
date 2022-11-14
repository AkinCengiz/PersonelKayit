using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MGURSES\\AKNCNGZ;Initial Catalog=PersonelKayit;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            txtAd.Focus();
            // TODO: This line of code loads data into the 'personelKayitDataSet1.tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelKayitDataSet1.tbl_Personel);
            if (rdbEvli.Checked)
                lblDurum.Text = "True";
            if (rdbBekar.Checked)
                lblDurum.Text = "False";
        }
        void Temizle()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cmbSehir.Text = "";
            rdbBekar.Checked = true;
            mskMaas.Clear();
            txtMeslek.Clear();
            txtAd.Focus();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); */
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_Personel (PersonelAd, PersonelSoyad, PersonelSehir, PersonelDurum, PersonelMaas, PersonelMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut2.Parameters.AddWithValue("@p4", lblDurum.Text);
            komut2.Parameters.AddWithValue("@p5",mskMaas.Text);
            komut2.Parameters.AddWithValue("@p6", txtMeslek.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi..."); 
            baglanti.Open();
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_Personel (PersonelAd, PersonelSoyad, PersonelSehir, PersonelDurum, PersonelMaas, PersonelMeslek) values (@p1, @p2, @p3, @p4, @p5, @p6)",baglanti);
            komutkaydet.Parameters.AddWithValue("@p1", txtAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komutkaydet.Parameters.AddWithValue("@p4", lblDurum.Text);
            komutkaydet.Parameters.AddWithValue("@p5", mskMaas.Text);
            komutkaydet.Parameters.AddWithValue("@p6", txtMeslek.Text);
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi...");
            Temizle(); */
            baglanti.Open();
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_Personel (PersonelAd, PersonelSoyad, PersonelSehir, PersonelMaas, PersonelDurum, PersonelMeslek) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komutkaydet.Parameters.AddWithValue("@p1", txtAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komutkaydet.Parameters.AddWithValue("@p4", mskMaas.Text);
            komutkaydet.Parameters.AddWithValue("@p5", lblDurum.Text);
            komutkaydet.Parameters.AddWithValue("@p6", txtMeslek.Text);
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel kayıt edildi...");
            Temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelKayitDataSet1.tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelKayitDataSet1.tbl_Personel);
        }

        private void rdbEvli_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbEvli.Checked)
                lblDurum.Text = "True";
        }

        private void rdbBekar_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbBekar.Checked)
                lblDurum.Text = "False";
        }

        private void lblDurum_TextChanged(object sender, EventArgs e)
        {
            if(lblDurum.Text=="True")
            {
                rdbEvli.Checked = true;
            }
            if(lblDurum.Text=="False")
            {
                rdbBekar.Checked = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update tbl_Personel set PersonelAd=@p1, PersonelSoyad=@p2, PersonelSehir=@p3, PersonelMaas=@p4, PersonelDurum=@p5, PersonelMeslek=@p6 where PersonelId=@p7", baglanti);
            komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", mskMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", lblDurum.Text);
            komutGuncelle.Parameters.AddWithValue("@p6", txtMeslek.Text);
            komutGuncelle.Parameters.AddWithValue("@p7", txtId.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("delete from tbl_Personel where PersonelId=@p1", baglanti);
            komutSil.Parameters.AddWithValue("@p1", txtId.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik frm = new frmIstatistik();
            frm.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmGrafik frg = new frmGrafik();
            frg.Show();
        }
    }
}
