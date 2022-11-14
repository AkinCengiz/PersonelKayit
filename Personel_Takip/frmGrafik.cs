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
    public partial class frmGrafik : Form
    {
        public frmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MGURSES\\AKNCNGZ;Initial Catalog=PersonelKayit;Integrated Security=True");
        private void frmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PersonelSehir,count(*) from tbl_Personel group by PersonelSehir", baglanti);
            SqlDataReader dr = komutg1.ExecuteReader();
            while(dr.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr[0], dr[1]);
            }
            dr.Close();
            SqlCommand komutg2 = new SqlCommand("select PersonelMeslek,avg(cast(PersonelMaas as int)) from tbl_Personel group by PersonelMeslek", baglanti);
            dr = komutg2.ExecuteReader();
            while(dr.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr[0], dr[1]);
            }
            dr.Close();
            baglanti.Close();
        }
    }
}
