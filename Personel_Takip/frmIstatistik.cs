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
    public partial class frmIstatistik : Form
    {
        public frmIstatistik()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=MGURSES\\AKNCNGZ;Initial Catalog=PersonelKayit;Integrated Security=True");
        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lblPersonelSayisi.Text = dr1[0].ToString();
            }
            dr1.Close();
            SqlCommand komut2 = new SqlCommand("select count(*) from tbl_Personel where PersonelDurum=1",baglanti);
            dr1 = komut2.ExecuteReader();
            while(dr1.Read())
            {
                lblEvliPersonel.Text = dr1[0].ToString();
            }
            dr1.Close();
            SqlCommand komut3 = new SqlCommand("select count(*) from tbl_Personel where PersonelDurum=0", baglanti);
            dr1 = komut3.ExecuteReader();
            while(dr1.Read())
            {
                lblBekarPersonel.Text = dr1[0].ToString();
            }
            dr1.Close();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PersonelSehir)) from tbl_Personel", baglanti);
            dr1 = komut4.ExecuteReader();
            while(dr1.Read())
            {
                lblSehirSayisi.Text = dr1[0].ToString();
            }
            dr1.Close();
            SqlCommand komut5 = new SqlCommand("select sum(cast(PersonelMaas as int)) from tbl_Personel", baglanti);
            dr1 = komut5.ExecuteReader();
            while(dr1.Read())
            {
                lblToplamMaas.Text = dr1[0].ToString();
            }
            dr1.Close();
            SqlCommand komut6 = new SqlCommand("select avg(cast(PersonelMaas as int)) from tbl_Personel", baglanti);
            dr1 = komut6.ExecuteReader();
            while(dr1.Read())
            {
                lblOrtalamaMaas.Text = dr1[0].ToString();
            }
            dr1.Close();
            baglanti.Close();
        }
    }
}
